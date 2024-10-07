Imports ZedGraph
Imports System.Threading

Public Class frmManual
    Public stend As clStend = frmGMain.stend
    Public opros As clOpros = stend.opros
    Dim oscill As Boolean = False




    Private Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        frmMainMenu.Show()
        frmGMain.chkManual = False
        Debug.Print("Авто")
        frmGMain.trFzad.Value = 0
        opros.reg_Fzp.Reset()
        stend.SetRazbor()
        stend.StAngle = clStend.eAngle.Stop
        stend.StAmpl = clStend.eAmpl.Stop
        stend.StV = clStend.eVelocity.Stop
        Me.Close()
        Timer1.Stop()
    End Sub

    Public Sub New()

        ' Этот вызов является обязательным для конструктора.
        InitializeComponent()
       




    End Sub

    Protected Overrides Sub Finalize()



        MyBase.Finalize()
    End Sub

    Private Sub btnRegim_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRegim.Click
        If stend.GetRegim = 0 Then
            stend.SetSbor(65)
            stend.StAmpl = clStend.eAmpl.Stop
            stend.StAngle = clStend.eAngle.Stop
            stend.StV = clStend.eVelocity.Stop
        Else
            frmGMain.trFzad.Value = 0
            opros.reg_Fzp.Reset()
            stend.SetRazbor()
        End If
        frmGMain.pUIStendRefreshUpdate()
    End Sub

   

    Public Sub Refresh_Dig()

        Dim reg As Integer
        Dim fzp As Single
        Dim Ffp As Single
        Dim Ip As Single
        Dim Up As Single
        Dim Ampl As Single
        Dim Angl As Single
        Dim Tg As Single
        Dim Ts As Single
        Dim Bs As Single
        Dim Br As Single



        reg = stend.GetRegim
        fzp = opros.reg_Fzp.GetValue(1)
        Ffp = opros.Ffp.GetValue(1)
        Ip = opros.Ip.GetValue(2)
        Up = opros.Up.GetValue(0)
        Ampl = opros.Ampl.GetValue(1)
        Angl = Math.Round(opros.AngleE.GetValue(2, False) * 2) / 2
        Tg = Math.Round(opros.Tgidro.GetValue(2, False) * 2) / 2
        Ts = Math.Round(opros.Tsredi.GetValue(2, False) * 2) / 2
        Br = opros.Brast_max.GetValue(0) / 1000
        Bs = opros.Bsjat_max.GetValue(0) / 1000
        fzp = opros.reg_Fzp.GetValue(1)



        If reg = 0 Then
            btnRegim.ImageIndex = 0
            btnV.Enabled = True
        Else
            btnRegim.ImageIndex = 1
            btnV.Enabled = True
        End If

        btnFzp.Text = "Частота задания " & fzp
        btnFfp.Text = "Частота " & Ffp
        btnIp.Text = "Ток " & Ip
        btnUp.Text = "Напряжение " & Up



        If stend.StAmpl = clStend.eAmpl.Stop Then
            If stend.Ampl < 18 Then
                btnAmpl.Text = "Ход " & opros.Ampl.GetValue(0) & " мм"
            Else
                btnAmpl.Text = "Ход " & stend.Ampl & " мм"
            End If

        Else
            btnAmpl.Text = "Ход " & opros.Ampl.GetValue(0).ToString & "(" & stend.Ampl & ") мм"
        End If

        If stend.StV = clStend.eVelocity.Stop Then
            btnV.Text = opros.Velocity.GetValue(3).ToString("f3") & " м/с"
        ElseIf stend.StV = clStend.eVelocity.Work Then
            btnV.Text = opros.Velocity.GetValue(3).ToString("f3") & " м/с"
        Else
            btnV.Text = opros.Velocity.GetValue(3).ToString("f3") & "(" & stend.Velocity & ") м/с"
        End If


        If stend.StAngle = clStend.eAngle.Stop Then
            btnAng.Text = "Угол наклона " & Angl.ToString("f0") & "°"
        Else
            btnAng.Text = "Угол наклона " & Angl.ToString("f0") & "(" & stend.Angle.ToString("f0") & ")°"
        End If


        btnTg.Text = "Температура гидрогасителя " & Tg.ToString("f0") & " °С"
        btnTs.Text = "Температура воздуха " & Ts.ToString("f0") & " °С"

        If Tg < 85 Then
            btnRegim.Enabled = True
            btnAmpl.Enabled = True
        End If



        If Tg < 35 Then
            btnTg.ImageIndex = 0
        ElseIf Tg < 65 Then
            btnTg.ImageIndex = 1
        ElseIf Tg < 85 Then
            btnTg.ImageIndex = 2
        Else
            btnTg.ImageIndex = 3
            btnRegim.Enabled = False
            btnAmpl.Enabled = False

        End If

        btnBr.Text = "Усилие растяжения " & Br.ToString("f1") & " кН"
        btnBs.Text = "Усилие сжатия " & Bs.ToString("f1") & " кН"



        Label6.Text = stend.tick
        'Label4.Text = stend.rw.T_MIN_GIDRo
        'Label5.Text = opros.dtt.GetValue(1).ToString("f1")
        Label4.Text = opros.Velocity.GetAcseleration().ToString("f3")
        Label5.Text = opros.Ampl.GetValue(1).ToString("f1")


    End Sub

    Public Sub Refresh_Osc(ByRef Ch0() As Short, ByRef Ch1() As Short, ByRef Ch2() As Short, ByRef Ch3() As Short, ByRef Ch4() As Short, ByRef Ch5() As Short, ByRef Ch6() As Short, ByRef Ch7() As Short)
        Dim g As Graphics
        Dim myPen As New System.Drawing.Pen(System.Drawing.Color.SkyBlue)
        Dim w As Single = Panel1.Width
        Dim h As Single = Panel1.Height
        Dim i As Integer


        Dim chA(2047) As Point

        g = Panel1.CreateGraphics
        DrawOsc()

        If oscill Then
            ReDim chA(1023)
            myPen.Color = Color.Blue

            For i = 200 To 1223
                chA(i - 200).X = w * (i - 200) / 1024
                chA(i - 200).Y = 1 * h - h * Ch3(i) / 2048

            Next

            g.DrawLines(myPen, chA)
            myPen.Color = Color.Red

            For i = 200 To 1223
                chA(i - 200).X = w * (i - 200) / 1024
                chA(i - 200).Y = 0.75 * h - h * Ch2(i) / 4096

            Next
            g.DrawLines(myPen, chA)


        Else
            myPen.Color = Color.DarkGreen
            ReDim chA(2047 - 400)
            Dim tmin, tmax, tavrg As Integer
            tmin = Ch3(i + 200)
            tmax = tmin
            tavrg = tmin
            For i = 0 To 2047 - 400
                tmin = Math.Min(tmin, Ch3(i + 200))
                tmax = Math.Max(tmax, Ch3(i + 200))
            Next
            tavrg = (tmin + tmax) / 2
            For i = 0 To 2047 - 400
                chA(i).X = 250 * (Ch3(i + 200) - tavrg) / 1024 + w / 2
                chA(i).Y = 0.5 * h - h * Ch2(i + 200) / 4096
            Next
            g.DrawLines(myPen, chA)
            myPen.Color = Color.SkyBlue
            'g.DrawLine(myPen, chA(2047), chA(2047))
        End If

        g.Dispose()
        myPen.Dispose()

    End Sub

    

    Private Sub Panel1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.Click
        oscill = Not oscill
        
        DrawOsc()
    End Sub

    Private Sub DrawOsc()
        Dim g As Graphics
        Dim myPen As New System.Drawing.Pen(System.Drawing.Color.Black)
        Dim w As Single = Panel1.Width
        Dim h As Single = Panel1.Height

        g = Panel1.CreateGraphics
        myPen.Color = Color.SkyBlue
        g.Clear(Color.SkyBlue)

        myPen.Color = Color.Black
        g.DrawRectangle(myPen, 0, 0, w - 1, h - 1)

        g.DrawLine(myPen, 0, h / 2, w, h / 2)
        g.DrawLine(myPen, w / 2, 0, w / 2, h)

        myPen.Color = Color.Gray
        g.DrawLine(myPen, CSng(w * 0.25), 0, CSng(w * 0.25), h)
        g.DrawLine(myPen, CSng(w * 0.75), 0, CSng(w * 0.75), h)
        g.DrawLine(myPen, 0, CSng(h * 0.25), w, CSng(h * 0.25))
        g.DrawLine(myPen, 0, CSng(h * 0.75), w, CSng(h * 0.75))
        myPen.Color = Color.SkyBlue

        If oscill Then
            btnOscTitle.Text = "Показания датчиков"
        Else
            btnOscTitle.Text = "Диаграмма гидрогасителя"
        End If

        myPen.Dispose()
        g.Dispose()
    End Sub


    Private Sub btnStop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStop.Click
        stend.SetRazbor()
        opros.reg_Fzp.Reset()
        stend.StAngle = clStend.eAngle.Stop
        stend.StAmpl = clStend.eAmpl.Stop
        stend.StV = clStend.eVelocity.Stop
        stend.StendErr = clStend.eErr.None

    End Sub

    Private Sub btnAmpl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAmpl.Click
        Dim frm As New frmSetAmpl
        

        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            stend.Ampl = frm.Value
            Timer1.Enabled = True
        End If
        frm.Dispose()

    End Sub

    Private Sub btnAng_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAng.Click
        Dim frm As New frmSetAngle

        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            stend.Angle = frm.Value
            Timer1.Enabled = True

        End If
        frm.Dispose()

    End Sub

    Private Sub btnV_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnV.Click
        Dim frm As New frmSetV
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            stend.Velocity = frm.value
            Timer1.Enabled = True
        End If

        frm.Dispose()


    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Timer1.Enabled = False
        stend.DoWork()
        ' Timer1.Enabled = True
        Label3.Text = opros.lcard.GetCurrentRate.ToString("f1")

        Select Case stend.StAngle
            Case clStend.eAngle.Stop
                Label1.Text = "stop"
            Case clStend.eAngle.AngleDown
                Label1.Text = "adwn"
            Case clStend.eAngle.AngleUp
                Label1.Text = "aup"
            Case clStend.eAngle.LCardInit
                Label1.Text = "lcard"
            Case clStend.eAngle.Measure
                Label1.Text = "mes"
            Case clStend.eAngle.Reset
                Label1.Text = "reset"
            Case clStend.eAngle.WaitBeforeMesasure
                Label1.Text = "wait mes"
            Case clStend.eAngle.WaitLCardInit
                Label1.Text = "wait lcard"
            Case clStend.eAngle.WaitReset
                Label1.Text = "wait res"
            Case clStend.eAngle.AngleDrebezg
                Label1.Text = "Ang Dreb"
            Case clStend.eAngle.AngleDrebezg2
                Label1.Text = "Ang Dr 2"
        End Select
        Select Case stend.StendErr
            Case clStend.eErr.Angle
                Label2.Text = "err angl"
                MsgBox("Ошибка установки угла", MsgBoxStyle.Critical, "Ошибка")


            Case clStend.eErr.Angle0
                Label2.Text = "err angl 0"
                MsgBox("Сработал концевой выключатель 0", MsgBoxStyle.Critical, "Ошибка")
                stend.SetRazbor()
                opros.reg_Fzp.Reset()
                stend.StAngle = clStend.eAngle.Stop
                stend.StAmpl = clStend.eAmpl.Stop
                stend.StV = clStend.eVelocity.Stop
                stend.StendErr = clStend.eErr.None
                Timer1.Enabled = False

            Case clStend.eErr.Angle90
                Label2.Text = "err angl 90"
                MsgBox("Сработал концевой выключатель 90", MsgBoxStyle.Critical, "Ошибка")
                stend.SetRazbor()
                opros.reg_Fzp.Reset()
                stend.StAngle = clStend.eAngle.Stop
                stend.StAmpl = clStend.eAmpl.Stop
                stend.StV = clStend.eVelocity.Stop
                stend.StendErr = clStend.eErr.None
                Timer1.Enabled = False


            Case clStend.eErr.Lcard
                Label2.Text = "err lcard"
                MsgBox("Ошибка L-Card", MsgBoxStyle.Critical, "Ошибка")
                stend.SetRazbor()
                opros.reg_Fzp.Reset()
                stend.StAngle = clStend.eAngle.Stop
                stend.StAmpl = clStend.eAmpl.Stop
                stend.StV = clStend.eVelocity.Stop
                stend.StendErr = clStend.eErr.None
                Timer1.Enabled = False

            Case clStend.eErr.None
                Label2.Text = "err none"

            Case clStend.eErr.Razbor
                Label2.Text = "err razb"
                MsgBox("Ошибка остановки ПЧВ", MsgBoxStyle.Critical, "Ошибка")
                stend.SetRazbor()
                opros.reg_Fzp.Reset()
                stend.StAngle = clStend.eAngle.Stop
                stend.StAmpl = clStend.eAmpl.Stop
                stend.StV = clStend.eVelocity.Stop
                stend.StendErr = clStend.eErr.None
                Timer1.Enabled = False

            Case clStend.eErr.Sbor
                MsgBox("Ошибка запуска ПЧВ", MsgBoxStyle.Critical, "Ошибка")
                stend.SetRazbor()
                opros.reg_Fzp.Reset()
                stend.StAngle = clStend.eAngle.Stop
                stend.StAmpl = clStend.eAmpl.Stop
                stend.StV = clStend.eVelocity.Stop
                stend.StendErr = clStend.eErr.None
                Timer1.Enabled = False

            Case clStend.eErr.SetAmpl
                MsgBox("Ошибка установки амплитуды", MsgBoxStyle.Critical, "Ошибка")
                stend.SetRazbor()
                opros.reg_Fzp.Reset()
                stend.StAngle = clStend.eAngle.Stop
                stend.StAmpl = clStend.eAmpl.Stop
                stend.StV = clStend.eVelocity.Stop
                stend.StendErr = clStend.eErr.None
                Timer1.Enabled = False

            Case clStend.eErr.SetVelocity
                MsgBox("Ошибка установки скорости", MsgBoxStyle.Critical, "Ошибка")
                stend.SetRazbor()
                opros.reg_Fzp.Reset()
                stend.StAngle = clStend.eAngle.Stop
                stend.StAmpl = clStend.eAmpl.Stop
                stend.StV = clStend.eVelocity.Stop
                stend.StendErr = clStend.eErr.None
                Timer1.Enabled = False

            Case clStend.eErr.StopVelocity
                MsgBox("Ошибка остановки", MsgBoxStyle.Critical, "Ошибка")
                stend.SetRazbor()
                opros.reg_Fzp.Reset()
                stend.StAngle = clStend.eAngle.Stop
                stend.StAmpl = clStend.eAmpl.Stop
                stend.StV = clStend.eVelocity.Stop
                stend.StendErr = clStend.eErr.None
                Timer1.Enabled = False

            Case clStend.eErr.Tmax
                MsgBox("Превышена допустимая температура", MsgBoxStyle.Critical, "Ошибка")
                stend.SetRazbor()
                opros.reg_Fzp.Reset()
                stend.StAngle = clStend.eAngle.Stop
                stend.StAmpl = clStend.eAmpl.Stop
                stend.StV = clStend.eVelocity.Stop
                stend.StendErr = clStend.eErr.None
                Timer1.Enabled = False

        End Select

        If stend.StendErr <> clStend.eErr.None Then
            stend.SetRazbor()
            stend.opros.reg_Fzp.Reset()
            stend.StAngle = clStend.eAngle.Stop
            stend.StAmpl = clStend.eAmpl.Stop
            stend.StV = clStend.eVelocity.Stop
            stend.StendErr = clStend.eErr.None
            Timer1.Enabled = False
        End If

        Select Case stend.StAmpl
            Case clStend.eAmpl.Check
                Label7.Text = "Chek"
            Case clStend.eAmpl.Measure
                Label7.Text = "meas"
            Case clStend.eAmpl.Reset
                Label7.Text = "reset"
            Case clStend.eAmpl.SetA
                Label7.Text = "setA"
            Case clStend.eAmpl.SetV1
                Label7.Text = "SetV1"
            Case clStend.eAmpl.SetV2
                Label7.Text = "SetV2"
            Case clStend.eAmpl.Stop
                Label7.Text = "Stop"
            Case clStend.eAmpl.Wait
                Label7.Text = "wait"
            Case clStend.eAmpl.WaitRazbor
                Label7.Text = "razbor"
            Case clStend.eAmpl.WaitSbor
                Label7.Text = "Sbor"
            Case clStend.eAmpl.WaitVelocity
                Label7.Text = "Velo"
            Case Else
                Label7.Text = "Else"
        End Select

        Select Case stend.StV
            Case clStend.eVelocity.Check
                Label8.Text = "Chek"
            Case clStend.eVelocity.Correction
                Label8.Text = "Corr"
            Case clStend.eVelocity.Razbor
                Label8.Text = "razbor"
            Case clStend.eVelocity.Sbor
                Label8.Text = "sbor"
            Case clStend.eVelocity.SetV
                Label8.Text = "setv"
            Case clStend.eVelocity.Slow
                Label8.Text = "slow"
            Case clStend.eVelocity.Stop
                Label8.Text = "stop"
            Case clStend.eVelocity.Wait
                Label8.Text = "wait"
            Case clStend.eVelocity.WaitCorrection
                Label8.Text = "W corr"
            Case clStend.eVelocity.WaitSbor
                Label8.Text = "W sbor"
            Case clStend.eVelocity.Work
                Label8.Text = "work"
            Case Else
                Label8.Text = "else"
        End Select

        'If frmGMain.stend.StAngle = clStend.eAngle.Stop And stend.StAmpl = clStend.eAmpl.Stop And stend.StV = clStend.eVelocity.Stop Then

        '    Timer1.Enabled = False
        '    Debug.Print("timer off")
        'End If



    End Sub

    Private Sub frmManual_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'frmGMain.chkManual = True
        

        Label1.Visible = stend.rw.SAFEMODE
        Label2.Visible = stend.rw.SAFEMODE
        Label3.Visible = stend.rw.SAFEMODE
        Label4.Visible = stend.rw.SAFEMODE
        Label5.Visible = stend.rw.SAFEMODE
        Label6.Visible = stend.rw.SAFEMODE
        Label7.Visible = stend.rw.SAFEMODE
        Label8.Visible = stend.rw.SAFEMODE
        btnFzp.Visible = stend.rw.SAFEMODE
        btnFfp.Visible = stend.rw.SAFEMODE
        btnUp.Visible = stend.rw.SAFEMODE
        btnIp.Visible = stend.rw.SAFEMODE

        Refresh_Dig()
        ' Добавьте все инициализирующие действия после вызова InitializeComponent().
        Debug.Print("ручное")
    End Sub
End Class