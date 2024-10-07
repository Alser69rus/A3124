Imports System.IO
Imports System.Text

Public Class aseIspNew

    Public fNum As String
    Public fDate As Date
    Public fRemont As GidrogasitelDataSet.RemontRow
    Public fOperator As GidrogasitelDataSet.OperatorsRow
    Public fAppointment As GidrogasitelDataSet.AppointmentRow
    Public fGasitel As GidrogasitelDataSet.ApparatsRow
    Public fStend As clStend = frmGMain.stend
    Public fOpros As clOpros = frmGMain.stend.opros
    Public fRw As clRWini = frmGMain.stend.rw
    Public fIspitanie As GidrogasitelDataSet.mainRow
    Public frmIspMain As aseIspMain = Nothing
    Public fRez1 As GidrogasitelDataSet.RezultRow
    Public fRez2 As GidrogasitelDataSet.RezultRow
    Public fRez3 As GidrogasitelDataSet.RezultRow
    Public fRez4 As GidrogasitelDataSet.RezultRow






    Private Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        frmMainMenu.Show()
        Me.Close()

    End Sub

    Private Sub aseIspNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "GidrogasitelDataSet.Apparats". При необходимости она может быть перемещена или удалена.
        Me.ApparatsTableAdapter.Fill(Me.GidrogasitelDataSet.Apparats)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "GidrogasitelDataSet.Rezult". При необходимости она может быть перемещена или удалена.
        Me.RezultTableAdapter.Fill(Me.GidrogasitelDataSet.Rezult)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "GidrogasitelDataSet.ApparatType". При необходимости она может быть перемещена или удалена.
        Me.ApparatTypeTableAdapter.Fill(Me.GidrogasitelDataSet.ApparatType)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "GidrogasitelDataSet.Remont". При необходимости она может быть перемещена или удалена.
        Me.RemontTableAdapter.Fill(Me.GidrogasitelDataSet.Remont)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "GidrogasitelDataSet.Operators". При необходимости она может быть перемещена или удалена.
        Me.OperatorsTableAdapter.Fill(Me.GidrogasitelDataSet.Operators)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "GidrogasitelDataSet.Appointment". При необходимости она может быть перемещена или удалена.
        Me.AppointmentTableAdapter.Fill(Me.GidrogasitelDataSet.Appointment)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "GidrogasitelDataSet.main". При необходимости она может быть перемещена или удалена.
        Me.MainTableAdapter.Fill(Me.GidrogasitelDataSet.main)

    End Sub

    Private Sub aseIspNew_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        fStend.StendErr = clStend.eErr.None

        'ApparatTypeTableAdapter.Update(GidrogasitelDataSet.ApparatType)
        'ApparatsTableAdapter.Update(GidrogasitelDataSet.Apparats)
        'OperatorsTableAdapter.Update(GidrogasitelDataSet.Operators)
        'AppointmentTableAdapter.Update(GidrogasitelDataSet.Appointment)
        'RemontTableAdapter.Update(GidrogasitelDataSet.Remont)
        RezultTableAdapter.Update(GidrogasitelDataSet.Rezult)
        MainTableAdapter.Update(GidrogasitelDataSet.main)

        GidrogasitelDataSet.AcceptChanges()

        'Me.ApparatTypeTableAdapter.Fill(Me.GidrogasitelDataSet.ApparatType)
        Me.RezultTableAdapter.Fill(Me.GidrogasitelDataSet.Rezult)
        'Me.AppointmentTableAdapter.Fill(Me.GidrogasitelDataSet.Appointment)
        'Me.RemontTableAdapter.Fill(Me.GidrogasitelDataSet.Remont)
        'Me.ApparatsTableAdapter.Fill(Me.GidrogasitelDataSet.Apparats)
        'Me.OperatorsTableAdapter.Fill(Me.GidrogasitelDataSet.Operators)
        Me.MainTableAdapter.Fill(Me.GidrogasitelDataSet.main)


        Dim frm1 As New aseGasitelSelect
        If frm1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim row As GidrogasitelDataSet.ApparatsRow
            row = frm1.ApparatsBindingSource.Current.row
            fGasitel = GidrogasitelDataSet.Apparats.FindByID(row.ID)
        Else
            frm1.Dispose()
            frmMainMenu.Show()
            Me.Close()
            Return
        End If
        frm1.Dispose()

        'Dim frm18 As New aseReport
        'frm18.fGasitel = fGasitel
        'frm18.fIsp = GidrogasitelDataSet.main.FindByID(96)
        'frm18.fRemontType = GidrogasitelDataSet.Remont.FindByID(frm18.fIsp.Remont)
        'frm18.fOperator = GidrogasitelDataSet.Operators.FindByID(1)
        'frm18.fAppointment = GidrogasitelDataSet.Appointment.FindByID(frm18.fOperator.Appointment)
        'frm18.fRez1 = GidrogasitelDataSet.Rezult.FindByID(frm18.fIsp.Rezult1)
        'frm18.fRez2 = GidrogasitelDataSet.Rezult.FindByID(frm18.fIsp.Rezult2)
        'frm18.fRez3 = GidrogasitelDataSet.Rezult.FindByID(frm18.fIsp.Rezult3)
        'frm18.fRez4 = GidrogasitelDataSet.Rezult.FindByID(frm18.fIsp.Rezult4)

        'frm18.fApparatType = GidrogasitelDataSet.ApparatType.FindByID(fGasitel.Type)
        'frm18.ShowDialog()
        'frm18.Dispose()

        Dim IspCount As Integer = 9
        If fGasitel.Check_Prokachka <> 0 Then
            IspCount = IspCount + 1
        End If
        If fGasitel.Check_s1 <> 0 Then
            IspCount = IspCount + 2
        End If
        If fGasitel.Check_s2 <> 0 Then
            IspCount = IspCount + 2
        End If
        If fGasitel.Check_s3 <> 0 Then
            IspCount = IspCount + 2
        End If
        If fGasitel.Check_s4 <> 0 Then
            IspCount = IspCount + 2
        End If


        Dim frm2 As New aseGasitelNum
        frm2.btnBack.Text = "Испытание (шаг 2 из " & IspCount & ")"
        If frm2.ShowDialog = Windows.Forms.DialogResult.OK Then
            If frm2.fNum.Length > 15 Then
                fNum = frm2.fNum.Substring(0, 15)
            Else
                fNum = frm2.fNum
            End If

            frm2.Dispose()
        Else
            frm2.Dispose()
            frmMainMenu.Show()
            Me.Close()
            Return
        End If


        fDate = Now

        Dim frm3 As New aseRemontSelect
        frm3.btnBack.Text = "Испытание (шаг 3 из " & IspCount & ")"
        If frm3.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim row As GidrogasitelDataSet.RemontRow = frm3.RemontBindingSource.Current.row
            fRemont = GidrogasitelDataSet.Remont.FindByID(row.ID)

        Else
            frm3.Dispose()
            frmMainMenu.Show()
            Me.Close()
            Return
        End If
        frm3.Dispose()

        Dim frm4 As New aseOperatorSelect
        frm4.btnBack.Text = "Испытание (шаг 4 из " & IspCount & ")"
        If frm4.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim row As GidrogasitelDataSet.OperatorsRow
            row = frm4.OperatorsBindingSource.Current.row
            fOperator = GidrogasitelDataSet.Operators.FindByID(row.ID)
            fAppointment = GidrogasitelDataSet.Appointment.FindByID(fOperator.Appointment)
        Else
            frm4.Dispose()
            frmMainMenu.Show()
            Me.Close()
            Return
        End If
        frm4.Dispose()

        Dim fAngle As Integer = fGasitel.ProkachkaAngle - fOpros.AngleE.GetValue(1, False)

        Dim frm5 As New aseIspPodgotovka
        frm5.btnBack.Text = "Испытание (шаг 5 из " & IspCount & ")"
        If Math.Abs(fAngle) < 5 Then
            frm5.RichTextBox2.Visible = False
        Else
            frm5.RichTextBox2.Visible = True
        End If

        If frm5.ShowDialog = Windows.Forms.DialogResult.OK Then

            fIspitanie = GidrogasitelDataSet.main.NewRow()

            fIspitanie.Type = fGasitel.ID
            fIspitanie.Num = fNum
            fIspitanie._DateTime = fDate
            fIspitanie.Remont = fRemont.ID
            fIspitanie._Operator = fOperator.ID
            fIspitanie.IsDel = False
            fIspitanie.Appointment = fOperator.Appointment
            'GidrogasitelDataSet.main.AddmainRow(fIspitanie)
            'MainTableAdapter.GetData.AddmainRow(fIspitanie)
            'MainTableAdapter.Update(GidrogasitelDataSet.main)
            GidrogasitelDataSet.main.Rows.Add(fIspitanie)

            'MainTableAdapter.Insert(fGasitel.ID, fNum, fDate, fRemont.ID, fOperator.Appointment, fOperator.ID, Nothing, Nothing, Nothing, Nothing, String.Empty)

            MainTableAdapter.Update(GidrogasitelDataSet.main)
            GidrogasitelDataSet.AcceptChanges()
            
        Else
            frm5.Dispose()
            frmMainMenu.Show()
            Me.Close()
            Return
        End If
        frm5.Dispose()


        Dim frm6 As New aseIspAngle
        frm6.btnBack.Text = "Испытание (шаг 6 из " & IspCount & ")"
        frm6.fAngle = fGasitel.ProkachkaAngle

        If frm6.ShowDialog = Windows.Forms.DialogResult.OK Then
            fIspitanie.Text = "Установка угла и предворительная прокачка завершена успешно"
            'MainTableAdapter.Update(GidrogasitelDataSet.main)
            MainTableAdapter.Update(fIspitanie)


        ElseIf frm6.DialogResult = Windows.Forms.DialogResult.Cancel Then
            fIspitanie.Text = "Установка угла и предворительная прокачка прерваны оператором"
            'MainTableAdapter.Update(GidrogasitelDataSet.main)
            MainTableAdapter.Update(GidrogasitelDataSet.main)
            frm6.Dispose()
            frmMainMenu.Show()
            Me.Close()
            Return
        Else
            IspErr()
            frm6.Dispose()
            frmMainMenu.Show()
            Me.Close()
            Return
        End If
        frm6.Dispose()

        Dim frm7 As New aseIspPodtvProkacki
        frm7.btnBack.Text = "Испытание (шаг 7 из " & IspCount & ")"
        If frm7.ShowDialog = Windows.Forms.DialogResult.OK Then
            frm7.Dispose()
            fIspitanie.Text = fIspitanie.Text & "; Уплотнения и втулки в норме"
            'MainTableAdapter.Update(GidrogasitelDataSet.main)
            MainTableAdapter.Update(GidrogasitelDataSet.main)
        Else
            fIspitanie.Text = fIspitanie.Text & "; Испытание прервано оператором"
            'MainTableAdapter.Update(GidrogasitelDataSet.main)
            MainTableAdapter.Update(GidrogasitelDataSet.main)
            frm7.Dispose()
            frmMainMenu.Show()
            Me.Close()
            Return
        End If

        If fGasitel.Check_Prokachka Then
            Dim frm8 As New aseIspProkachka
            frm8.btnBack.Text = "Испытание (шаг 8 из " & IspCount & ")"
            frm8.fTick = fGasitel.ProkachkaTime * 10
            frm8.fAmpl = fGasitel.ProkackaAmpl
            frm8.fVelo = fGasitel.ProkachkaSpeed
            If frm8.ShowDialog = Windows.Forms.DialogResult.OK Then
                fIspitanie.Text = fIspitanie.Text & "; Прокачка завершена. Времени осталось " & frm8.fTick / 10 & " с, температура" & fOpros.Tgidro.GetValue(0, False)
                'MainTableAdapter.Update(GidrogasitelDataSet.main)
                MainTableAdapter.Update(GidrogasitelDataSet.main)
                ' MsgBox(frm8.fLog)
                frm8.Dispose()
            ElseIf frm8.DialogResult = Windows.Forms.DialogResult.Cancel Then
                ' MsgBox(frm8.fLog)
                fIspitanie.Text = fIspitanie.Text & "; Прокачка прервана оператором"
                'MainTableAdapter.Update(GidrogasitelDataSet.main)
                MainTableAdapter.Update(GidrogasitelDataSet.main)
                frm8.Dispose()
                frmMainMenu.Show()
                Me.Close()
                Return
            Else
                ' MsgBox(frm8.fLog)
                IspErr()
                frm8.Dispose()
                frmMainMenu.Show()
                Me.Close()
                Return
            End If
        End If

        If fGasitel.Check_s1 Then
            Dim frm9 As New aseIspSetAmpl
            frm9.btnBack.Text = "Испытание (шаг 9 из " & IspCount & ")"
            frm9.fAmpl = fGasitel.S1_Ampl
            frm9.fvelo = fGasitel.S1_Speed1
            If frm9.ShowDialog = Windows.Forms.DialogResult.OK Then
                ' MsgBox(frm9.fLog)
                fIspitanie.Text = fIspitanie.Text & "; Установка амплитуды выполнена"
                'MainTableAdapter.Update(GidrogasitelDataSet.main)
                MainTableAdapter.Update(GidrogasitelDataSet.main)
                frm9.Dispose()
            ElseIf frm9.DialogResult = Windows.Forms.DialogResult.Cancel Then
                ' MsgBox(frm9.fLog)
                fIspitanie.Text = fIspitanie.Text & "; Установка амплитуды прервана оператором"
                'MainTableAdapter.Update(GidrogasitelDataSet.main)
                MainTableAdapter.Update(GidrogasitelDataSet.main)
                frm9.Dispose()
                frmMainMenu.Show()
                Me.Close()
                Return
            Else
                IspErr()
                frm9.Dispose()
                frmMainMenu.Show()
                Me.Close()
                Return
            End If
        End If

        If fGasitel.Check_s1 Then
            Dim frm10 As New aseIspMain
            frm10.btnBack.Text = "Испытание (шаг 10 из " & IspCount & ")"
            frm10.fVelo = fGasitel.S1_Speed1
            frm10.fTime = fGasitel.S1_Time * 10
            frmIspMain = frm10

            If frm10.ShowDialog = Windows.Forms.DialogResult.OK Then
                fRez1 = GidrogasitelDataSet.Rezult.NewRow
                GidrogasitelDataSet.Rezult.Rows.Add(fRez1)
                RezultTableAdapter.Update(GidrogasitelDataSet.Rezult)
                GidrogasitelDataSet.Rezult.AcceptChanges()
                fIspitanie.Text = fIspitanie.Text & " 1. V="
                fIspitanie.Rezult1 = fRez1.ID
                subIsp(fRez1)
                frm10.Dispose()

            ElseIf frm10.DialogResult = Windows.Forms.DialogResult.Cancel Then
                fIspitanie.Text = fIspitanie.Text & "; Испытание 1 прервано оператором"
                'MainTableAdapter.Update(GidrogasitelDataSet.main)
                MainTableAdapter.Update(GidrogasitelDataSet.main)
                frm10.Dispose()
                frmMainMenu.Show()
                Me.Close()
                Return
            Else
                IspErr()
                frm10.Dispose()
                frmMainMenu.Show()
                Me.Close()
                Return

            End If


            frmIspMain = Nothing
            frm10.Dispose()

        End If



        If fGasitel.Check_s2 Then
            Dim frm11 As New aseIspSetAmpl
            frm11.btnBack.Text = "Испытание (шаг 11 из " & IspCount & ")"
            frm11.fAmpl = fGasitel.S2_Ampl
            frm11.fvelo = fGasitel.S2_Speed2
            If frm11.ShowDialog = Windows.Forms.DialogResult.OK Then
                ' MsgBox(frm9.fLog)
                fIspitanie.Text = fIspitanie.Text & "; Установка амплитуды выполнена"
                'MainTableAdapter.Update(GidrogasitelDataSet.main)
                MainTableAdapter.Update(GidrogasitelDataSet.main)
                frm11.Dispose()
            ElseIf frm11.DialogResult = Windows.Forms.DialogResult.Cancel Then
                ' MsgBox(frm9.fLog)
                fIspitanie.Text = fIspitanie.Text & "; Установка амплитуды прервана оператором"
                'MainTableAdapter.Update(GidrogasitelDataSet.main)
                MainTableAdapter.Update(GidrogasitelDataSet.main)
                frm11.Dispose()
                frmMainMenu.Show()
                Me.Close()
                Return
            Else
                IspErr()
                frm11.Dispose()
                frmMainMenu.Show()
                Me.Close()
                Return
            End If
        End If

        If fGasitel.Check_s2 Then
            Dim frm12 As New aseIspMain
            frm12.btnBack.Text = "Испытание (шаг 12 из " & IspCount & ")"
            frm12.fVelo = fGasitel.S2_Speed2
            frm12.fTime = fGasitel.S2_Time * 10
            frmIspMain = frm12

            If frm12.ShowDialog = Windows.Forms.DialogResult.OK Then
                fRez2 = GidrogasitelDataSet.Rezult.NewRow
                GidrogasitelDataSet.Rezult.Rows.Add(fRez2)
                RezultTableAdapter.Update(GidrogasitelDataSet.Rezult)
                GidrogasitelDataSet.Rezult.AcceptChanges()
                fIspitanie.Text = fIspitanie.Text & " 2. V="
                fIspitanie.Rezult2 = fRez2.ID
                subIsp(fRez2)
                frm12.Dispose()

            ElseIf frm12.DialogResult = Windows.Forms.DialogResult.Cancel Then
                fIspitanie.Text = fIspitanie.Text & "; Испытание 2 прервано оператором"
                'MainTableAdapter.Update(GidrogasitelDataSet.main)
                MainTableAdapter.Update(GidrogasitelDataSet.main)
                frm12.Dispose()
                frmMainMenu.Show()
                Me.Close()
                Return
            Else
                IspErr()
                frm12.Dispose()
                frmMainMenu.Show()
                Me.Close()
                Return

            End If


            frmIspMain = Nothing
            frm12.Dispose()

        End If



        If fGasitel.Check_s3 Then
            Dim frm13 As New aseIspSetAmpl
            frm13.btnBack.Text = "Испытание (шаг 13 из " & IspCount & ")"
            frm13.fAmpl = fGasitel.S3_Ampl
            frm13.fvelo = fGasitel.S3_Speed3
            If frm13.ShowDialog = Windows.Forms.DialogResult.OK Then
                ' MsgBox(frm9.fLog)
                fIspitanie.Text = fIspitanie.Text & "; Установка амплитуды выполнена"
                ' MainTableAdapter.Update(GidrogasitelDataSet.main)
                MainTableAdapter.Update(GidrogasitelDataSet.main)
                frm13.Dispose()
            ElseIf frm13.DialogResult = Windows.Forms.DialogResult.Cancel Then
                ' MsgBox(frm9.fLog)
                fIspitanie.Text = fIspitanie.Text & "; Установка амплитуды прервана оператором"
                'MainTableAdapter.Update(GidrogasitelDataSet.main)
                MainTableAdapter.Update(GidrogasitelDataSet.main)
                frm13.Dispose()
                frmMainMenu.Show()
                Me.Close()
                Return
            Else
                IspErr()
                frm13.Dispose()
                frmMainMenu.Show()
                Me.Close()
                Return
            End If
        End If

        If fGasitel.Check_s3 Then
            Dim frm14 As New aseIspMain
            frm14.btnBack.Text = "Испытание (шаг 14 из " & IspCount & ")"
            frm14.fVelo = fGasitel.S3_Speed3
            frm14.fTime = fGasitel.S3_Time * 10
            frmIspMain = frm14

            If frm14.ShowDialog = Windows.Forms.DialogResult.OK Then
                fRez3 = GidrogasitelDataSet.Rezult.NewRow
                GidrogasitelDataSet.Rezult.Rows.Add(fRez3)
                RezultTableAdapter.Update(GidrogasitelDataSet.Rezult)
                GidrogasitelDataSet.Rezult.AcceptChanges()
                fIspitanie.Text = fIspitanie.Text & " 3. V="
                fIspitanie.Rezult3 = fRez3.ID
                subIsp(fRez3)
                frm14.Dispose()

            ElseIf frm14.DialogResult = Windows.Forms.DialogResult.Cancel Then
                fIspitanie.Text = fIspitanie.Text & "; Испытание 2 прервано оператором"
                'MainTableAdapter.Update(GidrogasitelDataSet.main)
                MainTableAdapter.Update(GidrogasitelDataSet.main)
                frm14.Dispose()
                frmMainMenu.Show()
                Me.Close()
                Return
            Else
                IspErr()
                frm14.Dispose()
                frmMainMenu.Show()
                Me.Close()
                Return

            End If


            frmIspMain = Nothing
            frm14.Dispose()

        End If



        If fGasitel.Check_s4 Then
            Dim frm15 As New aseIspSetAmpl
            frm15.btnBack.Text = "Испытание (шаг 15 из " & IspCount & ")"
            frm15.fAmpl = fGasitel.S4_Ampl
            frm15.fvelo = fGasitel.S4_Speed4
            If frm15.ShowDialog = Windows.Forms.DialogResult.OK Then
                ' MsgBox(frm9.fLog)
                fIspitanie.Text = fIspitanie.Text & "; Установка амплитуды выполнена"
                'MainTableAdapter.Update(GidrogasitelDataSet.main)
                MainTableAdapter.Update(GidrogasitelDataSet.main)
                frm15.Dispose()
            ElseIf frm15.DialogResult = Windows.Forms.DialogResult.Cancel Then
                ' MsgBox(frm9.fLog)
                fIspitanie.Text = fIspitanie.Text & "; Установка амплитуды прервана оператором"
                'MainTableAdapter.Update(GidrogasitelDataSet.main)
                MainTableAdapter.Update(GidrogasitelDataSet.main)
                frm15.Dispose()
                frmMainMenu.Show()
                Me.Close()
                Return
            Else
                IspErr()
                frm15.Dispose()
                frmMainMenu.Show()
                Me.Close()
                Return
            End If
        End If

        If fGasitel.Check_s4 Then
            Dim frm16 As New aseIspMain
            frm16.btnBack.Text = "Испытание (шаг 16 из " & IspCount & ")"
            frm16.fVelo = fGasitel.S4_Speed4
            frm16.fTime = fGasitel.S4_Time * 10
            frmIspMain = frm16

            If frm16.ShowDialog = Windows.Forms.DialogResult.OK Then
                fRez4 = GidrogasitelDataSet.Rezult.NewRow
                GidrogasitelDataSet.Rezult.Rows.Add(fRez4)
                RezultTableAdapter.Update(GidrogasitelDataSet.Rezult)
                GidrogasitelDataSet.Rezult.AcceptChanges()
                fIspitanie.Text = fIspitanie.Text & " 4. V="
                fIspitanie.Rezult4 = fRez4.ID
                subIsp(fRez4)
                frm16.Dispose()

            ElseIf frm16.DialogResult = Windows.Forms.DialogResult.Cancel Then
                fIspitanie.Text = fIspitanie.Text & "; Испытание 4 прервано оператором"
                'MainTableAdapter.Update(GidrogasitelDataSet.main)
                MainTableAdapter.Update(GidrogasitelDataSet.main)
                frm16.Dispose()
                frmMainMenu.Show()
                Me.Close()
                Return
            Else
                IspErr()
                frm16.Dispose()
                frmMainMenu.Show()
                Me.Close()
                Return

            End If


            frmIspMain = Nothing
            frm16.Dispose()

        End If

        Dim frm17 As New aseIspEnd
        frm17.btnBack.Text = "Испытание (шаг " & IspCount & " из " & IspCount & ")"
        frm17.ShowDialog()
        fIspitanie.Text = "Испытания успешно завершены"
        'MainTableAdapter.Update(GidrogasitelDataSet.main)
        MainTableAdapter.Update(GidrogasitelDataSet.main)
        GidrogasitelDataSet.AcceptChanges()
        frm17.Dispose()

        Dim frm18 As New aseReport
        frm18.fGasitel = fGasitel
        frm18.fIsp = fIspitanie
        frm18.fRemontType = fRemont
        frm18.fOperator = fOperator
        frm18.fAppointment = fAppointment
        frm18.fRez1 = fRez1
        frm18.fRez2 = fRez2
        frm18.fRez3 = fRez3
        frm18.fRez4 = fRez4
        frm18.fApparatType = GidrogasitelDataSet.ApparatType.FindByID(fGasitel.Type)
        frm18.ShowDialog()
        frm18.Dispose()

        'MsgBox(fIspitanie.Text)
        frmMainMenu.Show()
        Me.Close()
        Return

    End Sub

    Public Sub IspErr()
        fIspitanie.IsDel = True
        Select Case fStend.StendErr
            Case clStend.eErr.Lcard
                fIspitanie.Text = fIspitanie.Text & "Возникла ошибка Л-кард"
                MsgBox("Возникла ошибка Л-кард")
                'MainTableAdapter.Update(GidrogasitelDataSet.main)
                MainTableAdapter.Update(GidrogasitelDataSet.main)
            Case clStend.eErr.Razbor
                fIspitanie.Text = fIspitanie.Text & "Не удалось остановить ПЧВ"
                MsgBox("Не удалось остановить ПЧВ")
                'MainTableAdapter.Update(GidrogasitelDataSet.main)
                MainTableAdapter.Update(GidrogasitelDataSet.main)
            Case clStend.eErr.Sbor
                fIspitanie.Text = fIspitanie.Text & "Не удалось запустить ПЧВ"
                MsgBox("Не удалось запустить ПЧВ")
                'MainTableAdapter.Update(GidrogasitelDataSet.main)
                MainTableAdapter.Update(GidrogasitelDataSet.main)
            Case clStend.eErr.SetAmpl
                fIspitanie.Text = fIspitanie.Text & "Не удалось установить амплитуду"
                MsgBox("Не удалось установить амплитуду")
                'MainTableAdapter.Update(GidrogasitelDataSet.main)
                MainTableAdapter.Update(GidrogasitelDataSet.main)
            Case clStend.eErr.Tmax
                fIspitanie.Text = fIspitanie.Text & "Превышена температура гасителя"
                MsgBox("Температура гасителя больше 85 градусов")
                'MainTableAdapter.Update(GidrogasitelDataSet.main)
                MainTableAdapter.Update(GidrogasitelDataSet.main)
            Case clStend.eErr.SetVelocity
                fIspitanie.Text = fIspitanie.Text & "Не удалось установить скорость"
                MsgBox("Не удалось установить скорость")
                'MainTableAdapter.Update(GidrogasitelDataSet.main)
                MainTableAdapter.Update(GidrogasitelDataSet.main)
            Case clStend.eErr.StopVelocity
                fIspitanie.Text = fIspitanie.Text & "Не удалось остановить вращение"
                MsgBox("Не удалось остановить вращение")
                'MainTableAdapter.Update(GidrogasitelDataSet.main)
                MainTableAdapter.Update(GidrogasitelDataSet.main)
            Case clStend.eErr.Angle
                fIspitanie.Text = fIspitanie.Text & "При установке угла возникла ошибка"
                MsgBox(fIspitanie.Text)
                'MainTableAdapter.Update(GidrogasitelDataSet.main)
                MainTableAdapter.Update(GidrogasitelDataSet.main)
            Case clStend.eErr.Angle0
                fIspitanie.Text = fIspitanie.Text & "При установке угла сработал датчик 0"
                MsgBox(fIspitanie.Text)
                'MainTableAdapter.Update(GidrogasitelDataSet.main)
                MainTableAdapter.Update(GidrogasitelDataSet.main)
            Case clStend.eErr.Angle90
                fIspitanie.Text = "При установке угла сработал датчик 90"
                MsgBox(fIspitanie.Text)
                'MainTableAdapter.Update(GidrogasitelDataSet.main)
                MainTableAdapter.Update(GidrogasitelDataSet.main)
            Case Else
                fIspitanie.Text = fIspitanie.Text & "Неизвестная ошибка"
                MsgBox("Неизвестная ошибка" & fStend.StendErr & "/" & fStend.StAmpl & "/" & fStend.StV)
                'MainTableAdapter.Update(GidrogasitelDataSet.main)
                MainTableAdapter.Update(GidrogasitelDataSet.main)
        End Select
    End Sub

    Public Sub subIsp(ByRef Rez As GidrogasitelDataSet.RezultRow)

        Rez.A = fOpros.Ampl.GetValue(1)
        Rez.Speed = fOpros.Velocity.GetValue(3)
        Rez.B_dec = frmIspMain.fBr
        Rez.B_inc = frmIspMain.fBs
        Rez.P_dec = fOpros.Brast_max.GetValue(0) / 1000
        Rez.P_inc = fOpros.Bsjat_max.GetValue(0) / 1000

        If CBool(fRw.SAFEMODE) Then
            Dim mFileName As String = "aseBuff1.adc"
            Dim mPath As String = My.Application.Info.DirectoryPath & "\LOG\"

            Directory.CreateDirectory(mPath)
            Dim fs As FileStream = IO.File.Create(mPath & mFileName)
            fs.Close()
            fs.Dispose()


            Dim mSW As StreamWriter = New StreamWriter(mPath & mFileName, True, Encoding.GetEncoding(1251))

            For i As Integer = 0 To 2047
                mSW.Write(vbCrLf & frmIspMain.fChA(i).ToString("f0") & vbTab & frmIspMain.fChF(i).ToString("f0"))
            Next

            mSW.Close()
            mSW.Dispose()
        End If

        Dim idx As Integer = fOpros.PeriodLen - 1
        Dim arrL(idx) As Single
        Dim arrF(idx) As Single
        Dim arrSmL(idx) As Single
        Dim arrSmF(idx) As Single
        Dim strL As String = ""
        Dim strF As String = ""

        For i = 0 To idx
            Dim l As Single = 0
            Dim f As Single = 0

            For j = 0 To fOpros.PeriodCount - 1
                l = l + frmIspMain.fChA(fOpros.PeriodCross0 + i + j * fOpros.PeriodLen)
                f = f + frmIspMain.fChF(fOpros.PeriodCross0 + i + j * fOpros.PeriodLen)
            Next
            If fOpros.PeriodCount > 0 Then
                l = l / fOpros.PeriodCount
                f = f / fOpros.PeriodCount
            End If

            arrL(i) = l
            arrF(i) = f
        Next

        If idx > 2 Then
            arrSmL(0) = (arrL(0) + arrL(1) + 3 * arrL(1) - 2 * arrL(2)) / 3
            arrSmL(idx) = (arrL(idx) + arrL(idx - 1) + 3 * arrL(idx - 1) - 2 * arrL(idx - 2)) / 3
            arrSmF(0) = (arrF(0) + arrF(1) + 3 * arrF(1) - 2 * arrF(2)) / 3
            arrSmF(idx) = (arrF(idx) + arrF(idx - 1) + 3 * arrF(idx - 1) - 2 * arrF(idx - 2)) / 3
        End If

        For i = 1 To idx - 1
            arrSmF(i) = (arrF(i - 1) + arrF(i) + arrF(i + 1)) / 3
            arrSmL(i) = (arrL(i - 1) + arrL(i) + arrL(i + 1)) / 3
        Next

        For i = 0 To idx

            If strL.Length < 4 Then
                strL = CShort(arrSmL(i)).ToString("X4")
            Else
                strL = strL & "," & CShort(arrSmL(i)).ToString("X4")
            End If

            If strF.Length < 4 Then
                strF = CShort(arrSmF(i)).ToString("X4")
            Else
                strF = strF & "," & CShort(arrSmF(i)).ToString("X4")
            End If

        Next

        If CBool(fRw.SAFEMODE) Then
            Dim mFileName As String = "asePeriod1.adc"
            Dim mPath As String = My.Application.Info.DirectoryPath & "\LOG\"

            Directory.CreateDirectory(mPath)
            Dim fs As FileStream = IO.File.Create(mPath & mFileName)
            fs.Close()
            fs.Dispose()


            Dim mSW As StreamWriter = New StreamWriter(mPath & mFileName, True, Encoding.GetEncoding(1251))

            For i As Integer = 0 To UBound(arrL)
                mSW.Write(vbCrLf & arrSmL(i).ToString("f0") & vbTab & arrSmF(i).ToString("f0"))
            Next

            mSW.Close()
            mSW.Dispose()
        End If


        Dim KL As Single = 5 * fRw.LEN_DATCHIK_DISTANCE / (CSng(fRw.R_DATCHIK_DISTANCE) * 0.016 * 1000 * lHALF_DISCRETS)
        Dim KF As Single = 5 * CSng(fRw.LIM_POWER) * CSng(fRw.U_IN_POWER) / (CSng(fRw.U_OUT_TENZO) * CSng(fRw.U_POWER) * lHALF_DISCRETS)
        Dim fE As Single = Math.Abs(50 * CalculateArea2(arrSmL, arrSmF, KL, KF)) / fOpros.Ampl.GetValue(1)
        fE = Math.Round(fE)
        Rez.E = fE

        If (Rez.P_inc + Rez.P_dec) > 0.1 Then
            Rez.Symmetry = Math.Round(200 * Math.Abs(Rez.P_dec - Rez.P_inc) / (Rez.P_inc + Rez.P_dec), 1)
        Else
            Rez.Symmetry = 1000
        End If

        Rez.Values = strL
        Rez.Values2 = strF

        fIspitanie.Text = fIspitanie.Text & fOpros.Velocity.GetValue(3) & " F=" & Rez.P_dec & "/" & Rez.P_inc & " E=" & Rez.E & " S=" & Rez.Symmetry

        RezultTableAdapter.Update(GidrogasitelDataSet.Rezult)
        MainTableAdapter.Update(GidrogasitelDataSet.main)


    End Sub
End Class