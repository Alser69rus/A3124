﻿Imports ZedGraph
Imports System.Threading

Public Class frmGMain

    Dim WithEvents lcard As clLcardGidro
    Public WithEvents CheckManager As clTreeView.CCheckManager

    Public ta As GidrogasitelDataSetTableAdapters.TableAdapterManager

    Dim Protokol As clDrawingProtokol
    Dim WithEvents PrintDocument As New MyPrintDocument

    Private Delegate Sub StendRefreshUpdate()

    Dim RW As New clRWini

    Public WithEvents stend As clStend
    Public WithEvents opros As clOpros
    Public chkManual As Boolean = False



    Public Sub Zooms(ByVal Frm As Form)
        Dim KoefW As Double, KoefH As Double

        Const Swis = 1680 ' при разрешении экрана 
        Const Shig = 1050 '1280х800 на котором СОЗДАВАЛАСЬ форма 

        Dim Cntrl As Control
        KoefW = Screen.PrimaryScreen.WorkingArea.Width / Swis
        KoefH = Screen.PrimaryScreen.WorkingArea.Height / Shig
        Frm.Height = Frm.Height * KoefH
        Frm.Width = Frm.Width * KoefW

        On Error GoTo LnErr
        For Each Cntrl In Frm.Controls
            With Cntrl
                .Left = .Left * KoefW
                .Top = .Top * KoefH
                .Width = .Width * KoefW
                If KoefH < 0.95 Then
                    .Height = .Height * KoefH * 1.4
                Else
                    .Height = .Height * KoefH
                End If

            End With
        Next
LnErr:
        Err.Clear()
        Resume Next
    End Sub

    Private Sub frmGMain_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Dim objWMIService, objComputer As Object

        If Not CBool(RW.SAFEMODE) Then
            objWMIService = GetObject("Winmgmts:{impersonationLevel=impersonate,(Debug,Shutdown)}")


            For Each objComputer In objWMIService.InstancesOf("Win32_OperatingSystem")

                objComputer.Win32shutdown(12, 0) '12 - выключить компьютер, 2 - перезагрузить
            Next
        End If
        



    End Sub



    Private Sub frmGMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing


        ApparatsBindingSource.EndEdit()

        OperatorsBindingSource.EndEdit()

        MainBindingSource.EndEdit()


        'If Me.CheckManager.ThreadMenage IsNot Nothing Then
        '    MessageBox.Show("Завершите выполнение проверок!!!", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    e.Cancel = True
        '    Exit Sub
        'End If

        RemoveHandler opros.ValueChange, AddressOf opros_ValueChange
        ' Label53.Text = "Отключен опрос"
        If stend.GetRegim <> 0 Then
            stend.SetRazbor()
        End If


        Threading.Thread.Sleep(2000)
        ' Label53.Text = "Команда на разбор"
        If Not CBool(RW.SAFEMODE) Then
            stend.PowerOff()
        End If
        ' Label53.Text = "Отключение питания"
        Threading.Thread.Sleep(3000)

        bThreadExit = False
        opros.Ended()
        ' Label53.Text = "Завершен опрос"

        ' While (opros.IsExit)
        'Threading.Thread.Sleep(500)
        ' End While
        'Label53.Text = "Опрос закрылся"

        stend.smds.Ended()
        ' Label53.Text = "Завершен смсд"



        'Threading.Thread.Sleep(3000)





        ' While (bThreadIsAlive)
        'MsgBox(Threading.Thread.CurrentThread.ManagedThreadId)

        Threading.Thread.Sleep(2000)
        ' End While



        'Label53.Text = "Не ждем"
        lcard.Stoping()
        'Label53.Text = "Лкард завершен"

        RemoveHandler lcard.ADC_Complete, AddressOf lcard_ADC_Complete


        If CheckManager Is Nothing Then Exit Sub
        'Label53.Text = "Отключен менеджер"
        ta.UpdateAll(ds)
        'Label53.Text = "База обновлена"
        Me.DataGridView1.DataSource = Nothing
        Me.DataGridView1.DataMember = Nothing


    End Sub


    Private Sub frmGMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'Dim x() As Double = {0, 2, 2, 0, 0}
        'Dim y() As Double = {0, 0, 2, 2, 2}
        'CalculateArea(y, x, 1, 1)

        'Zooms(Me)

        'MessageBox.Show("1")
        ds = New GidrogasitelDataSet
        ta = New GidrogasitelDataSetTableAdapters.TableAdapterManager()

        'MessageBox.Show("2")
        ta.mainTableAdapter = New GidrogasitelDataSetTableAdapters.mainTableAdapter
        ta.RemontTableAdapter = New GidrogasitelDataSetTableAdapters.RemontTableAdapter
        ta.ApparatsTableAdapter = New GidrogasitelDataSetTableAdapters.ApparatsTableAdapter
        ta.AppointmentTableAdapter = New GidrogasitelDataSetTableAdapters.AppointmentTableAdapter
        ta.OperatorsTableAdapter = New GidrogasitelDataSetTableAdapters.OperatorsTableAdapter
        ta.RezultTableAdapter = New GidrogasitelDataSetTableAdapters.RezultTableAdapter
        ta.ApparatTypeTableAdapter = New GidrogasitelDataSetTableAdapters.ApparatTypeTableAdapter

        'MessageBox.Show("start2")
        With ta
            .ApparatTypeTableAdapter.Fill(ds.ApparatType)
            .RemontTableAdapter.Fill(ds.Remont)
            .OperatorsTableAdapter.Fill(ds.Operators)
            .ApparatsTableAdapter.Fill(ds.Apparats)
            .AppointmentTableAdapter.Fill(ds.Appointment)
            .RezultTableAdapter.Fill(ds.Rezult)
            .mainTableAdapter.Fill(ds.main)
        End With


        'Dim rez As GidrogasitelDataSet.RezultRow = ds.Rezult.NewRezultRow

        'analise_izmer(rez)

        'MessageBox.Show("start3")

        lcard = New clLcardGidro(Me)

        tbtnZoom.SelectedIndex = 1
        PrintDocument.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(100, 50, 50, 50)
        PrintView.Show()

        'MessageBox.Show("start4")
        Protokol = New clDrawingProtokol(PrintDocument, ds, RW)

        CheckManager = New clTreeView.CCheckManager()
        Me.TreeViewEx1.CheckManager = CheckManager
        Me.TreeViewEx1.ExpandAll()

        'MessageBox.Show("start5")
        chAvtoChecks.Enabled = True
        Me.btnManage.Enabled = True

        'MessageBox.Show("start6")

        stend = New clStend(Me, lcard)
        opros = stend.opros

        pUIStendRefreshUpdate()

        With Me.cmbTypeTD
            .DataSource = ds.Apparats
            .DisplayMember = "Name"
            .DataBindings.Add("Tag", ds.Apparats, "ID")
        End With

        With Me.cmbAppointment
            .DataSource = ds.Appointment
            .DisplayMember = "Appointment"
            .DataBindings.Add("Tag", ds.Appointment, "ID")
        End With

        With Me.cmbOperator
            .DataSource = ds.Operators
            .DisplayMember = "Last"
            .DataBindings.Add("Tag", ds.Operators, "ID")
        End With

        With Me.cmbTypeRemonta
            .DataSource = ds.Remont
            .DisplayMember = "Remont"
            .DataBindings.Add("Tag", ds.Remont, "ID")
        End With

        MainBindingSource.DataSource = ds
        MainBindingSource.DataMember = "main"

        ApparatsBindingSource.DataSource = ds
        ApparatsBindingSource.DataMember = "Apparats"

        OperatorsBindingSource.DataSource = ds
        OperatorsBindingSource.DataMember = "Operators"

        Me.DataGridView1.DataSource = MainBindingSource

        'If ds.main.Count > 0 Then
        '    idx_protokol = ds.main.Rows(0).Item("ID")
        'End If

        numFilter.Value = CDec(RW.NUM_GARMONIC)


        Dim threinit As New Threading.Thread(AddressOf reinit_lcard_thread)
        threinit.Name = "LCardreinit"
        threinit.Start()



        frmMainMenu.Show()
        Me.Hide()

    End Sub


    Private Sub tpProtokol_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tpProtokol.Enter
        If main IsNot Nothing Then
            RefreshProtokol(main.ID)
        End If
    End Sub

    Dim cnt_oscil As Integer = 3
    Dim val_oscil1(2048 * cnt_oscil - 1) As Short
    Dim val_oscil2(2048 * cnt_oscil - 1) As Short


    Private Sub CheckManager_AutoCheckCompleted() Handles CheckManager.AutoCheckCompleted


        Dim oUIUpdater As New StendRefreshUpdate(AddressOf pUIAutocheckCompleted)
        Try
            If Me.IsHandleCreated Then
                SyncLock Me
                    Me.BeginInvoke(oUIUpdater)
                End SyncLock
            End If

        Catch ex As NullReferenceException
            Beep()
        End Try


    End Sub

    Public Sub pUIAutocheckCompleted()
        btnManage.Text = "Выполнить выбранные проверки"
        TreeViewEx1.Enabled = True
        Me.btnManage.Enabled = True
        ta.ApparatsTableAdapter.Update(ds.Apparats)
        ta.RezultTableAdapter.Update(ds.Rezult)
        ta.mainTableAdapter.Update(ds.main)

    End Sub


    Private Sub CheckManager_Message(ByVal _Message As String) Handles CheckManager.Message
        'Me.lblInfo.Text = _Message
    End Sub

    Private Sub CheckManager_RefreshWait(ByVal Elapsed As System.TimeSpan, ByVal Duration As System.TimeSpan) Handles CheckManager.RefreshWait
        'Dim Remaining As TimeSpan

        'If Elapsed.TotalMilliseconds < Duration.TotalMilliseconds Then
        '    Me.pgbTime.Value = Elapsed.TotalMilliseconds / Duration.TotalMilliseconds * Me.pgbTime.Maximum
        '    Remaining = Duration.Subtract(Elapsed)
        '    Me.lblElapsedTime.Text = Int(Elapsed.TotalMinutes).ToString & ":" & CInt(Elapsed.Seconds).ToString
        '    Me.lblRemainingTime.Text = Int(Remaining.TotalMinutes).ToString & ":" & CInt(Remaining.Seconds).ToString
        'Else 'Закончилось время ожидания
        '    Me.pgbTime.Value = 0
        '    Me.lblElapsedTime.Text = vbNullString
        '    Me.lblRemainingTime.Text = vbNullString
        '    Me.lblInfo.Text = vbNullString
        'End If
    End Sub

    Private Sub CheckManager_SetWait(ByVal _Wait As Integer, ByVal _NoCancel As Boolean, ByVal _Message As String) Handles CheckManager.SetWait
        'Me.lblInfo.Text = _Message
    End Sub

    Private Sub TreeViewEx1_NewMessage(ByVal _Message As String) Handles TreeViewEx1.NewMessage
        Me.lblInfo.Text = _Message
    End Sub

    Private Sub TreeViewEx1_NewWait(ByVal _Wait As Integer, ByVal _NoCancel As Boolean, ByVal _Message As String) Handles TreeViewEx1.NewWait
        Me.lblInfo.Text = _Message
    End Sub

    Private Sub TreeViewEx1_RefreshWait(ByVal Elapsed As System.TimeSpan, ByVal Duration As System.TimeSpan) Handles TreeViewEx1.RefreshWait
        Dim Remaining As TimeSpan

        If Elapsed.TotalMilliseconds < Duration.TotalMilliseconds Then
            Me.pgbTime.Value = Elapsed.TotalMilliseconds / Duration.TotalMilliseconds * Me.pgbTime.Maximum
            Remaining = Duration.Subtract(Elapsed)
            Me.lblElapsedTime.Text = Int(Elapsed.TotalMinutes).ToString & ":" & CInt(Elapsed.Seconds).ToString
            Me.lblRemainingTime.Text = Int(Remaining.TotalMinutes).ToString & ":" & CInt(Remaining.Seconds).ToString
        Else 'Закончилось время ожидания
            Me.pgbTime.Value = 0
            Me.lblElapsedTime.Text = vbNullString
            Me.lblRemainingTime.Text = vbNullString
            Me.lblInfo.Text = vbNullString
        End If
    End Sub

    Private Sub RefreshProtokol(ByVal _idx As Integer)
        Protokol.SetIndexDataSet(_idx)
        PrintView.Document = PrintDocument()
        PrintView.InvalidatePreview()
    End Sub

    Private Sub ОПрограммеToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim about As New AboutBox1
        about.ShowDialog(Me)
        about = Nothing
    End Sub

    Private Sub tbtnZoom_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbtnZoom.SelectedIndexChanged
        Select Case tbtnZoom.SelectedIndex
            Case 0
                PrintView.AutoZoom = True
            Case 1
                PrintView.AutoZoom = False
                PrintView.Zoom = 1
            Case 2
                PrintView.AutoZoom = False
                PrintView.Zoom = 0.75
            Case 3
                PrintView.AutoZoom = False
                PrintView.Zoom = 0.5
            Case 4
                PrintView.AutoZoom = False
                PrintView.Zoom = 0.25
        End Select
    End Sub

    Private Sub chAvtoChecks_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chAvtoChecks.Click
        Me.CheckManager.StartAutoCheck()
    End Sub


    Private Sub sbtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbtnPrint.Click
        PrintDocument.Print()
    End Sub

    Private Sub sbtnSelPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbtnSelPrint.Click
        PrintDialog.PrinterSettings = New System.Drawing.Printing.PrinterSettings()

        If PrintDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PrintDocument.PrinterSettings = PrintDialog.PrinterSettings
            PrintDocument.Print()
        End If
    End Sub

    Private Sub sbtnSelPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbtnSelPage.Click
        With PageSetupDialog
            .EnableMetric = True
            .PageSettings = PrintDocument.DefaultPageSettings
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                PrintDocument.DefaultPageSettings = .PageSettings
                PrintView.InvalidatePreview()
            End If
        End With
    End Sub


    Private first_click As Boolean = True

    Dim rezult1 As GidrogasitelDataSet.RezultRow
    Dim rezult2 As GidrogasitelDataSet.RezultRow
    Dim rezult3 As GidrogasitelDataSet.RezultRow
    Dim rezult4 As GidrogasitelDataSet.RezultRow

    Dim main As GidrogasitelDataSet.mainRow

    Private Sub btnManage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManage.Click
        If btnManage.Text = "Выполнить выбранные проверки" Then

            Dim flag As Boolean = True

            If first_click = True Then
                flag = False
                first_click = False
            Else
                ''If MessageBox.Show("Выполнить передиагностику аппарата?", My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                'prtcl.Save()

                'daAppointment.Update(ds.Должности)
                'daData.Update(ds.Аппараты)
                'daOperator.Update(ds.Операторы)
                'daRemont.Update(ds.Ремонты)
                'daMain.Update(ds.main)
                'daBP.Update(ds.BP)
                'daImpuls.Update(ds.Impuls)
                'daIvs.Update(ds.Ivs)
                'daOtsechka.Update(ds.Otsecka)
                'daUvs.Update(ds.Uvs)
                'daVS.Update(ds.VS)
                'daVT.Update(ds.VT)
                'daVip.Update(ds.Выпрямитель)
                'daInv.Update(ds.Инвертор)

                'flag = False
                'End If

            End If


            If flag = False Then
                btnManage.Text = "Прервать ожидание"
                TreeViewEx1.Enabled = False

                Dim frmI As New frmGIspitaniaData(ds, ta, RW)
                If frmI.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
                    MessageBox.Show("Не введены данные об испытаниях." & ControlChars.CrLf & "Работа в автоматическом режиме не возможна", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    CheckManager_AutoCheckCompleted()
                Else

                    main = ds.main.NewmainRow


                    Dim parametr As GidrogasitelDataSet.ApparatsRow = ds.Apparats.FindByID(frmI.cmbTypeTD.Tag)

                    rezult1 = ds.Rezult.NewRezultRow
                    rezult2 = ds.Rezult.NewRezultRow
                    rezult3 = ds.Rezult.NewRezultRow
                    'rezult4 = ds.Rezult.NewRezultRow

                    ds.Rezult.AddRezultRow(rezult1)
                    ds.Rezult.AddRezultRow(rezult2)
                    ds.Rezult.AddRezultRow(rezult3)
                    'ds.Rezult.AddRezultRow(rezult4)


                    CheckManager.Clear()

                    With parametr


                        CheckManager.Add(New clUstanovkaGidrogasitel("Установка гасителя в рабочее положение - " & .ProkachkaAngle.ToString & " °", parametr, stend, RW))


                        If .Check_Prokachka = 1 Then
                            CheckManager.Add(New clUstanovkaAmplitude("Установка амплитуды прокачки - " & .ProkackaAmpl.ToString & " мм ", _
                                                                                               parametr, stend, RW, 0))
                            CheckManager.Add(New clProkachkaGidrogasitel("Прокачка при угле наклона " & .ProkachkaAngle.ToString & _
                                                                         " град. и скорости " & .ProkachkaSpeed.ToString & " м/c", parametr, stend, RW))

                        End If

                        If .Check_s1 = 1 Then
                            CheckManager.Add(New clUstanovkaAmplitude("Установка амплитуды первого испытания - " & .S1_Ampl.ToString & " мм ", _
                                                                                               parametr, stend, RW, 1))

                            CheckManager.Add(New clMeasureGidrogasitel("Испытание 1 гидрогасителя при угле наклона " & .S1_Angle.ToString & " град., скорости перемещения " & .S1_Speed1.ToString & " м/c и температуре 40 °C ", _
                                                                       parametr, rezult1, stend, RW, 1))

                        End If

                        If .Check_s2 = 1 Then
                            CheckManager.Add(New clUstanovkaAmplitude("Установка амплитуды второго испытания - " & .S2_Ampl.ToString & " мм ", _
                                                                                                parametr, stend, RW, 2))
                            CheckManager.Add(New clMeasureGidrogasitel("Испытание 2 гидрогасителя при угле наклона " & .S2_Angle.ToString & " град., скорости перемещения " & .S2_Speed2.ToString & " м/c и температуре 40 °C ", _
                                                                       parametr, rezult2, stend, RW, 2))

                        End If

                        If .Check_s3 = 1 Then
                            CheckManager.Add(New clUstanovkaAmplitude("Установка амплитуды третьего испытания - " & .S3_Ampl.ToString & " мм ", _
                                                                                               parametr, stend, RW, 3))
                            CheckManager.Add(New clMeasureGidrogasitel("Испытание 3 гидрогасителя при угле наклона " & .S3_Angle.ToString & " град., скорости перемещения " & .S3_Speed3.ToString & " м/c и температуре 40 °C ", _
                                                                       parametr, rezult3, stend, RW, 3))

                        End If

                        If .Check_s4 = 1 Then
                            CheckManager.Add(New clUstanovkaAmplitude("Установка амплитуды четвертого испытания - " & .S4_Ampl.ToString & " мм ", _
                                                                                                parametr, stend, RW, 4))
                            CheckManager.Add(New clMeasureGidrogasitel("Испытание 4 гидрогасителя при угле наклона " & .S4_Angle.ToString & " град., скорости перемещения " & .S4_Speed4.ToString & " м/c и температуре 40 °C ", _
                                                                       parametr, rezult4, stend, RW, 4))

                        End If


                        CheckManager.Add(New clUstanovkaGidrogasitel("Установка гасителя в вертикальное положение", parametr, stend, RW, True))
                    End With

                    Me.TreeViewEx1.CheckManager = CheckManager
                    Me.TreeViewEx1.ExpandAll()


                    With frmI
                        cmbTypeTD.Text = .cmbTypeTD.Text
                        txtNum.Text = .txtNum.Text
                        cmbAppointment.Text = .cmbAppointment.Text
                        cmbOperator.Text = .cmbOperator.Text
                        cmbTypeRemonta.Text = .cmbTypeRemonta.Text
                    End With

                    With main
                        .Type = frmI.cmbTypeTD.Tag
                        ._DateTime = Now
                        .Num = frmI.txtNum.Text
                        .Remont = frmI.cmbTypeRemonta.Tag
                        .Appointment = frmI.cmbAppointment.Tag
                        .OperatorsRow = ds.Operators.FindByID(frmI.cmbOperator.Tag)


                        'If main.ApparatsRow.Check_s1 = 1 Then
                        .Rezult1 = rezult1.ID
                        'End If

                        'If main.ApparatsRow.Check_s2 = 1 Then
                        .Rezult2 = rezult2.ID
                        'End If

                        'If main.ApparatsRow.Check_s3 = 1 Then
                        .Rezult3 = rezult3.ID
                        'End If

                        'If main.ApparatsRow.Check_s4 = 1 Then
                        '.Rezult4 = rezult4.ID
                        'End If
                    End With

                    ds.main.AddmainRow(main)

                    CheckManager.StartAutoCheck()

                End If

                frmI = Nothing
            Else
                btnManage.Text = "Прервать ожидание"
                TreeViewEx1.Enabled = False
                CheckManager.StartAutoCheck()
            End If

        Else
            If chAvtoChecks.Checked = True Then
                CheckManager.Waiter.AbortWaiting()
                CheckManager.Check.Abort()

            Else

                CheckManager.Waiter.AbortWaiting()
                CheckManager.AbortAllCheck = True
                'CheckManager.CancelAutoCheck()
                'CheckManager_AutoCheckCompleted()
                'CheckManager.Waiter.AbortWaiting()
                ' CheckManager.CancelAutoCheck()
            End If
        End If

    End Sub



    Private Sub opros_FinishOpros() Handles opros.FinishOpros
        'Dim oUIUpdater As New StendRefreshUpdate(AddressOf me_close)
        'Try
        '    'If Me.IsHandleCreated Then
        '    SyncLock Me
        '        Me.Invoke(oUIUpdater)
        '    End SyncLock
        '    'End If

        'Catch ex As NullReferenceException
        '    Beep()
        'End Try
    End Sub

    Private Sub opros_ValueChange() Handles opros.ValueChange
        Dim oUIUpdater As New StendRefreshUpdate(AddressOf pUIStendRefreshUpdate)
        Try
            'If Me.IsHandleCreated Then
            'SyncLock Me
            Me.Invoke(oUIUpdater)
            'End SyncLock
            'End If

        Catch ex As NullReferenceException
            Beep()
        End Try
    End Sub

    Public Sub pUIStendRefreshUpdate()
        Try

            'состояние режимов

            Dim new_regim As Integer = stend.GetRegim
            btnSbor.Tag = new_regim



            If frmManual.Visible Then
                frmManual.Refresh_Dig()
            ElseIf frmTenzo.Visible Then
                frmTenzo.RefreshDig()
            Else



                Select Case new_regim
                    Case 0
                        btnSbor.ImageIndex = 1
                        btnSbor.Text = "Включить привод"
                        trFzad.Enabled = False

                        'frmManual.btnRegim.ImageIndex = 0
                        ' frmManual.btnV.Enabled = False

                    Case (1)
                        btnSbor.ImageIndex = 2
                        btnSbor.Text = "Разбор схемы"
                        trFzad.Enabled = True

                        'frmManual.btnRegim.ImageIndex = 1
                        ' frmManual.btnV.Enabled = True

                End Select


                trFzad.Value = stend.opros.reg_Fzp.GetValue()
                lblFp.Text = stend.opros.Ffp.GetValue(1)
                lblIp.Text = stend.opros.Ip.GetValue(2)
                lblUp.Text = stend.opros.Up.GetValue(0)
                lblFmax.Text = stend.opros.max_fp.GetValue(1)


                lblAmpl.Text = stend.opros.Ampl.GetValue(0).ToString

                lblAngle.Text = (stend.opros.AngleE.GetValue(2)).ToString("f0")

                lblTgidro.Text = stend.opros.Tgidro.GetValue(1).ToString("f0")
                lblTos.Text = stend.opros.Tsredi.GetValue(1).ToString("f0")

                lblBrast.Text = (stend.opros.Brast_max.GetValue(0) / 1000).ToString("f1")
                lblBsjat.Text = (stend.opros.Bsjat_max.GetValue(0) / 1000).ToString("f1")

                If opros.K1.Sostoyanie Then
                    KM1.BackColor = Color.Red
                Else
                    KM1.BackColor = Color.Gray
                End If

                If opros.K2.Sostoyanie Then
                    KM2.BackColor = Color.Red
                Else
                    KM2.BackColor = Color.Gray
                End If

                If opros.K3.Sostoyanie Then
                    KM3.BackColor = Color.Red
                Else
                    KM3.BackColor = Color.Gray
                End If

                If opros.K4.Sostoyanie Then
                    KM4.BackColor = Color.Red
                Else
                    KM4.BackColor = Color.Gray
                End If

                If opros.K5.Sostoyanie Then
                    KM5.BackColor = Color.Red
                Else
                    KM5.BackColor = Color.Gray
                End If

                If opros.K6.Sostoyanie Then
                    KM6.BackColor = Color.Red
                Else
                    KM6.BackColor = Color.Gray
                End If

                If opros.K7.Sostoyanie Then
                    KM7.BackColor = Color.Red
                Else
                    KM7.BackColor = Color.Gray
                End If

                If opros.K8.Sostoyanie Then
                    KM8.BackColor = Color.Red
                Else
                    KM8.BackColor = Color.Gray
                End If

                If opros.DigIN2.mValue.GetBit(0) Then
                    KM9.BackColor = Color.Red
                Else
                    KM9.BackColor = Color.Gray
                End If

                If opros.DigIN2.mValue.GetBit(1) Then
                    KM10.BackColor = Color.Red
                Else
                    KM10.BackColor = Color.Gray
                End If

                If opros.DigIN2.mValue.GetBit(2) Then
                    KM11.BackColor = Color.Red
                Else
                    KM11.BackColor = Color.Gray
                End If

                If opros.DigIN2.mValue.GetBit(3) Then
                    KM12.BackColor = Color.Red
                Else
                    KM12.BackColor = Color.Gray
                End If

                If opros.DigIN2.mValue.GetBit(4) Then
                    KM13.BackColor = Color.Red
                Else
                    KM13.BackColor = Color.Gray
                End If

                If opros.DigIN2.mValue.GetBit(5) Then
                    KM14.BackColor = Color.Red
                Else
                    KM14.BackColor = Color.Gray
                End If

                If opros.DigIN2.mValue.GetBit(6) Then
                    KM15.BackColor = Color.Red
                Else
                    KM15.BackColor = Color.Gray
                End If

                If opros.DigIN2.mValue.GetBit(7) Then
                    KM16.BackColor = Color.Red
                Else
                    KM16.BackColor = Color.Gray
                End If

                btnAmplitudeDown.Enabled = Not opros.KoncevikAmplitudeMin.Sostoyanie

                With lblKoncevikAmplitude
                    If opros.KoncevikAmplitudeMin.Sostoyanie Then
                        .Text = "Вкл."
                        .BackColor = Color.Red
                    Else
                        .Text = "Откл."
                        .BackColor = Color.LightGreen
                    End If
                End With




                btnAngleDown.Enabled = Not opros.KoncevikAngle90.Sostoyanie

                With lblKoncevikNaklon0
                    If opros.KoncevikAngle0.Sostoyanie Then

                        .Text = "Вкл."
                        .BackColor = Color.Red
                    Else

                        .Text = "Выкл."
                        .BackColor = Color.LightGreen
                    End If
                End With


                btnAngleUp.Enabled = Not opros.KoncevikAngle0.Sostoyanie

                With lblKoncevikNaklon90
                    If opros.KoncevikAngle90.Sostoyanie Then

                        .Text = "Вкл."
                        .BackColor = Color.Red
                    Else

                        .Text = "Выкл."
                        .BackColor = Color.LightGreen
                    End If
                End With

                ' lblV.Text = Math.Round(Math.PI * (stend.opros.Ampl.GetValue(0) / 1000) * CInt(RW.N_NOM) * trFzad.Value / (60 * CSng(RW.PER_SHTOK) * 16384), 3)
                lblV.Text = Math.Round(Math.PI * (stend.opros.max_fp.GetValue(1) / 50) * (stend.opros.Ampl.GetValue(0) / 1000) * CInt(RW.N_NOM) * stend.opros.reg_Fzp.GetValue / (60 * CSng(RW.PER_SHTOK) * 16384), 3)
                lblV2.Text = Math.Round(Math.PI * (stend.opros.Ampl.GetValue(0) / 1000) * CInt(RW.N_NOM) * stend.opros.Ffp.GetValue(2) / (60 * CSng(RW.PER_SHTOK) * 50), 3)

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub btnAngleUp_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnAngleUp.MouseDown
        If e.Button = MouseButtons.Left Then
            btnAngleUp.Text = "Поднять"
        End If
        If e.Button = MouseButtons.Right Then
            btnAngleUp.Text = "Поднять"
        End If
        stend.AngleExcecute(clStend.eAction.Up)
    End Sub

    Private Sub btnAngleUp_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnAngleUp.MouseUp, btnAngleDown.MouseUp

        btnAngleUp.Text = "Поднять"

        stend.AngleExcecute(clStend.eAction.Stop)
    End Sub

    Private Sub btnAngleDown_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnAngleDown.MouseDown
        'If lblKoncevikNaklon.Tag = False Then
        stend.AngleExcecute(clStend.eAction.Down)
        'End If
    End Sub


    Private Sub btnAmplitudeUp_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnAmplitudeUp.MouseDown
        stend.AmplitudeExcecute(clStend.eAction.Up)
    End Sub

    Private Sub btnAmplitudeDown_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnAmplitudeDown.MouseDown
        'If lblKoncevikAmplitude.Tag = False Then
        stend.AmplitudeExcecute(clStend.eAction.Down)
        'End If
    End Sub

    Private Sub btnAmplitudeDown_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnAmplitudeDown.MouseUp, btnAmplitudeUp.MouseUp
        stend.AmplitudeExcecute(clStend.eAction.Stop)
    End Sub


    Private Sub btnSbor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSbor.Click
        If btnSbor.Tag = 0 Then
            stend.SetSbor(nudFmax.Value)
        Else
            stend.SetRazbor()
        End If

        pUIStendRefreshUpdate()

    End Sub





    Private Sub lcard_ADC_Complete(ByRef Ch0() As Short, ByRef Ch1() As Short, ByRef Ch2() As Short, ByRef Ch3() As Short, ByRef Ch4() As Short, ByRef Ch5() As Short, ByRef Ch6() As Short, ByRef Ch7() As Short) Handles lcard.ADC_Complete
        Dim v_ch2(Ch2.GetUpperBound(0)) As Double
        Dim e_val_ch2(Ch3.GetUpperBound(0)) As Short

        Dim v_ch3(Ch3.GetUpperBound(0)) As Double
        Dim e_val_ch3(Ch3.GetUpperBound(0)) As Short

        Dim i As Integer = 0

        For i = 0 To Ch3.GetUpperBound(0)
            v_ch2(i) = Ch2(i)
            v_ch3(i) = Ch3(i)
        Next


        Dim f_ch3 As New bpf(v_ch3, Ch3.Length)
        f_ch3.calculate()
        f_ch3.filtring(numFilter.Value, Ch3.Length - numFilter.Value)
        f_ch3.calculate()


        Dim j As Integer = 0
        For Each vl As Double In f_ch3.GetBack
            e_val_ch3(j) = vl
            j += 1
        Next


        Dim f_ch2 As New bpf(v_ch2, Ch2.Length)
        f_ch2.calculate()
        f_ch2.filtring(numFilter.Value, Ch2.Length - numFilter.Value)
        f_ch2.calculate()


        j = 0
        For Each vl As Double In f_ch2.GetBack
            e_val_ch2(j) = vl
            j += 1
        Next

        If frmManual.Visible Then
            frmManual.Refresh_Dig()
            frmManual.Refresh_Osc(Ch0, Ch1, e_val_ch2, e_val_ch3, Ch4, Ch5, Ch6, Ch7)
        ElseIf frmTs.Visible Then
            frmTs.refreshT(Ch1)
        ElseIf frmTg.Visible Then
            frmTg.refreshT(Ch0)
        ElseIf frmAngle.Visible Then
            frmAngle.refreshT(Ch4)
        ElseIf frmTenzo.Visible Then
            frmTenzo.RefreshOsc()
        ElseIf aseIspNew.Visible Then
            If aseIspNew.frmIspMain IsNot Nothing Then
                aseIspNew.frmIspMain.RefreshOsc(Ch0, Ch1, e_val_ch2, e_val_ch3, Ch4, Ch5, Ch6, Ch7)
            End If

        Else

            If opros.KM1.Sostoyanie And chFiltr.Checked Then



                Me.COscill1.DrawOscill(e_val_ch2, 1)
                Me.COscill1.DrawOscill2(e_val_ch3, 1)
                ' Dim g As Graphics = PB1.CreateGraphics()
                ' Dim drx As Integer
                'Dim dry As Integer

                ' For i = 0 To Ch3.GetUpperBound(0) - 1
                'drx = Int(e_val_ch2(i) / 10)
                'dry = Int(e_val_ch3(i) / 10)

                ' g.DrawLine(Pens.Black, e_val_ch2(i))


                ' Next


            Else

                Me.COscill1.DrawOscill(Ch2, 1)
                Me.COscill1.DrawOscill2(Ch3, 1)

            End If

        End If

    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        stend.AmplitudeExcecute(clStend.eAction.FindZero)
    End Sub


    Private Sub btnOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOptions.Click
        Dim mValue As Object

        mValue = InputBox("Введите пароль:", , , , )

        If mValue = RW.PASSWORD Then
            Dim f As New frmOptions(RW)
            f.ShowDialog()
            f.Dispose()
            f = Nothing
        End If

    End Sub


    Private Sub btnNewCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewCheck.Click
        first_click = True
        btnManage_Click(Nothing, Nothing)
    End Sub


    Private Sub btnApparatEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApparatEdit.Click

        Dim mValue As Object

        mValue = InputBox("Введите пароль:", , , , )

        If mValue = RW.PASSWORD Then
            ta.ApparatsTableAdapter.Fill(ds.Apparats)
            Dim f As New frmApparats(ds, RW)
            If f.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ta.ApparatsTableAdapter.Update(ds.Apparats)
            Else
                ta.ApparatsTableAdapter.Fill(ds.Apparats)
                With Me.cmbTypeTD
                    .DataSource = ds.Apparats
                    .DisplayMember = "Name"
                    '.DataBindings.Add("Tag", ds.Apparats, "ID")
                End With
            End If

            f.Dispose()
            f = Nothing
        End If
    End Sub


    Private Sub btnRemontEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemontEdit.Click
        Dim mValue As Object

        mValue = InputBox("Введите пароль:", , , , )

        If mValue = RW.PASSWORD Then

            ta.RemontTableAdapter.Fill(ds.Remont)
            Dim frmR As New frmRemont(ds)

            If frmR.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.cmbTypeRemonta.Text = frmR.Remont
                ta.RemontTableAdapter.Update(ds.Remont)
            Else
                ta.RemontTableAdapter.Fill(ds.Remont)
                With Me.cmbTypeRemonta
                    .DataSource = ds.Remont
                    .DisplayMember = "Remont"
                    '.DataBindings.Add("Tag", ds.Remont, "ID")
                End With
            End If

            frmR.Dispose()
            frmR = Nothing
        End If

    End Sub


    Private Sub btnOperatorEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOperatorEdit.Click
        Dim mValue As Object

        mValue = InputBox("Введите пароль:", , , , )

        If mValue = RW.PASSWORD Then
            ta.OperatorsTableAdapter.Fill(ds.Operators)
            Dim frmEE As New frmEmployee(ds)
            If frmEE.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.cmbOperator.Text = frmEE.LastName
                ta.OperatorsTableAdapter.Update(ds.Operators)
            Else
                ta.OperatorsTableAdapter.Fill(ds.Operators)
                With Me.cmbOperator
                    .DataSource = ds.Operators
                    .DisplayMember = "Last"
                    '.DataBindings.Add("Tag", ds.Operators, "ID")
                End With
            End If

            frmEE = Nothing
        End If
    End Sub


    Private Sub btnAppintmentEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAppintmentEdit.Click
        Dim mValue As Object

        mValue = InputBox("Введите пароль:", , , , )

        If mValue = RW.PASSWORD Then
            ta.AppointmentTableAdapter.Fill(ds.Appointment)
            Dim f As New frmAppointment(ds)
            If f.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.cmbAppointment.Text = f.txtAppointment.Text
                ta.AppointmentTableAdapter.Update(ds.Appointment)
            Else
                ta.AppointmentTableAdapter.Fill(ds.Appointment)
                With Me.cmbAppointment
                    .DataSource = ds.Appointment
                    .DisplayMember = "Appointment"
                    '.DataBindings.Add("Tag", ds.Appointment, "ID")
                End With
            End If

            f.Dispose()
            f = Nothing
        End If
    End Sub


    'Dim idx_protokol As Integer

    'Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick


    '    idx_protokol = DataGridView1.CurrentRow.Cells.Item("ID").Value

    'End Sub

    Private Sub btnProtokol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProtokol.Click
        Dim row As DataRowView = MainBindingSource.Current

        If row IsNot Nothing Then
            'idx_protokol = row.Item("ID")

            Dim f As New frmGDB(ds, row.Item("ID"))
            f.ShowDialog()
            f.Dispose()
            f = Nothing

        End If
    End Sub

    Private Sub chFiltr_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chFiltr.CheckedChanged
        numFilter.Enabled = chFiltr.Checked
    End Sub

    'частота дискретизации лкард в килогерцах
    Public Fdiskr As Double = 120.0

    Dim bThreadExit As Boolean = True
    Dim bThreadIsAlive As Boolean = True

    Private Sub reinit_lcard_thread()
        bThreadIsAlive = True
        Try
            While (bThreadExit)
               
                Threading.Thread.Sleep(1000)
               
                Dim t_Fdiskr As Double = 0

                If stend.opros.reg_Fzp.GetValue() > 0 Then

                    t_Fdiskr = CalculateFdiscrLcard(CInt(RW.N_NOM), (stend.opros.max_fp.GetValue(1) / 50) * (stend.opros.reg_Fzp.GetValue() / 16384), CSng(RW.PER_SHTOK), 4)
                    't_Fdiskr = CalculateFdiscrLcard(CInt(RW.N_NOM), stend.opros.reg_Fzp.GetValue() / 16384, CSng(RW.PER_SHTOK), 4)

                    If Math.Round(t_Fdiskr, 3) <> Math.Round(Fdiskr, 3) Then
                        Fdiskr = t_Fdiskr

                        lcard.ReInit(Fdiskr)

                    End If
                Else
                    Fdiskr = 120.0

                    'If Math.Round(lcard.GetCurrentRate, 3) <> Math.Round(Fdiskr, 3) Then
                    'Fdiskr = Math.Round(lcard.GetCurrentRate, 3)

                    lcard.ReInit(Fdiskr)

                    ' End If

                End If

                Debug.Print("lcard current rate - {0}", lcard.GetCurrentRate)
            End While
        Catch ex As ThreadAbortException
            Label53.Text = ex.Message

            Fdiskr = 0
        Finally
            Debug.Print("d3")
            bThreadIsAlive = False
        End Try

        

    End Sub

    Private Sub chAvto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chAvto.Click
        gbAmpl.Enabled = Not chAvto.Checked
        gbAngle.Enabled = Not chAvto.Checked
        gbPrivod.Enabled = Not chAvto.Checked

    End Sub

    Private Sub btnAngleUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAngleUp.Click

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        Me.Close()
    End Sub

    Private Sub numFilter_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numFilter.ValueChanged
        If opros IsNot Nothing Then
            If Me.IsHandleCreated Then
                RW.NUM_GARMONIC = numFilter.Value.ToString
            End If

        End If

    End Sub


    Private Sub btnAmplitudeUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAmplitudeUp.Click

    End Sub

    Private Sub gbAmpl_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbAmpl.Enter

    End Sub

    Private Sub btnAngleUp_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAngleUp.MouseLeave

    End Sub


    Private Sub trFzad_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles trFzad.ValueChanged
        stend.opros.reg_Fzp.SetValue(trFzad.Value, True)
    End Sub
End Class