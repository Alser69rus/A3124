
Public Class aseIspMain

    Public fVelo As Single
    Public fTime As Integer
    Public fTick As Integer
    Public fStend As clStend = frmGMain.stend
    Public fOpros As clOpros = fStend.opros
    Public fState As eState
    Public fChF(2047) As Short
    Public fChA(2047) As Short
    Public fLog As String = "isp"
    Public fBr As Single
    Public fBs As Single




    Enum eState
        Wait
        Velocity
        Pause
    End Enum

    Private Sub aseIspMain_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Timer1.Start()
        fStend.Velocity = fVelo
        fTick = fTime
        fState = eState.Velocity
    End Sub

    Private Sub btnStop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStop.Click
        btnStop.Visible = False
        btnCancel.Visible = True
        btnContinue.Visible = True
        Timer1.Stop()
        fStend.SetRazbor()
        fStend.StV = clStend.eVelocity.Stop
        fState = eState.Pause
    End Sub

    Private Sub btnContinue_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnContinue.Click
        btnStop.Visible = True
        btnCancel.Visible = False
        btnContinue.Visible = False
        fStend.Velocity = fVelo
        fTick = fTime
        fState = eState.Velocity

        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' fLog = fLog & ";" & fTick & ".s" & fState & "u" & fStend.StAngle & "a" & fStend.StAmpl & "v" & fStend.StV & "e" & fStend.StendErr
        fStend.DoWork()

        If fStend.StendErr = clStend.eErr.None Then
            Dim v As Single = fOpros.Velocity.GetValue(3)
            Dim fr = fOpros.Brast_max.GetValue(0) / 1000
            Dim fs = fOpros.Bsjat_max.GetValue(0) / 1000

            fTick = fTick - 1

            btnV.Text = "Скорость " & v.ToString("f3") & " (" & fVelo.ToString("f3") & ") м/с"
            btnTime.Text = "Лимит времени " & (fTick / 10).ToString("f1") & " с"
            btnTemp.Text = "Температура гасителя " & fOpros.Tgidro.GetValue(0, False) & "°С"
            btnFr.Text = "Усилие растяжения " & fr.ToString("f1") & " кН"
            btnFs.Text = "Усилие сжатия " & fs.ToString("f1") & " кН"

            If v >= 0.02 And v <= 0.7 Then
                fBr = (fr / v)
                fBs = (fs / v)
                btnB.Text = "В=" & fBr.ToString("f0") & "/" & fBs.ToString("f0") & " кН*м/с"
            Else
                btnB.Text = "В= --/-- кН*м/с"
            End If

            If fStend.StV = clStend.eVelocity.Work Then
                btnV.ImageIndex = 2
            Else
                btnV.ImageIndex = 1
            End If

            If fTick > 0 Then
                btnTime.ImageIndex = 0
            Else
                btnTime.ImageIndex = 3
            End If

            If fOpros.Tgidro.GetValue(0, False) < 35 Then
                btnTemp.ImageIndex = 4
            ElseIf fOpros.Tgidro.GetValue(0, False) < 65 Then
                btnTemp.ImageIndex = 5
            ElseIf fOpros.Tgidro.GetValue(0, False) < 85 Then
                btnTemp.ImageIndex = 6
            Else
                btnTemp.ImageIndex = 7
            End If

            Dim i As Integer = 100 - 100 * Math.Abs(fVelo - v) / fVelo
            If i < 0 Then i = 0
            If i > 100 Then i = 100
            pbV.Value = i

            i = 100 - 100 * fTick / fTime
            If i < 0 Then i = 0
            If i > 100 Then i = 100
            pbTime.Value = i


            If fStend.StV = clStend.eVelocity.Work Then
                Dim t As Integer = 25 + Math.PI * fOpros.Ampl.GetValue(1) / (25 * fVelo)
                If fTick > t Then fTick = t
            End If

            If fTick < 0 Then
                If fStend.StV = clStend.eVelocity.Work Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Timer1.Stop()
                    Me.Close()
                Else
                    Me.DialogResult = Windows.Forms.DialogResult.Abort
                    Timer1.Stop()
                    Me.Close()
                End If
            End If


        Else
            Me.DialogResult = Windows.Forms.DialogResult.Abort
            Timer1.Stop()
            fStend.SetRazbor()
            fStend.StV = clStend.eVelocity.Stop
            Me.Close()

        End If
    End Sub

    Public Sub RefreshOsc(ByRef Ch0() As Short, ByRef Ch1() As Short, ByRef Ch2() As Short, ByRef Ch3() As Short, ByRef Ch4() As Short, ByRef Ch5() As Short, ByRef Ch6() As Short, ByRef Ch7() As Short)
        Dim g As Graphics
        Dim w As Single = Panel1.Width
        Dim h As Single = Panel1.Height
        Dim i As Integer

        Dim chA(2047 - 400) As Point

        g = Panel1.CreateGraphics

        g.Clear(Color.SkyBlue)


        g.DrawRectangle(Pens.Black, 0, 0, w - 1, h - 1)

        g.DrawLine(Pens.Black, 0, h / 2, w, h / 2)
        g.DrawLine(Pens.Black, w / 2, 0, w / 2, h)


        g.DrawLine(Pens.Gray, CSng(w * 0.25), 0, CSng(w * 0.25), h)
        g.DrawLine(Pens.Gray, CSng(w * 0.75), 0, CSng(w * 0.75), h)
        g.DrawLine(Pens.Gray, 0, CSng(h * 0.25), w, CSng(h * 0.25))
        g.DrawLine(Pens.Gray, 0, CSng(h * 0.75), w, CSng(h * 0.75))


        For i = 0 To 2047 - 400
            chA(i).X = w * Ch3(i + 200) / 1024
            chA(i).Y = 0.5 * h - h * Ch2(i + 200) / 4096
        Next

        Dim tmin, tmax, tavrg As Integer
        tmin = chA(0).X
        tmax = tmin
        tavrg = tmin
        For i = 0 To 2047 - 400
            tmin = Math.Min(tmin, chA(i).X)
            tmax = Math.Max(tmax, chA(i).X)
        Next
        tavrg = (tmin + tmax) / 2
        For i = 0 To 2047 - 400
            chA(i).X = chA(i).X - tavrg + w / 2
        Next


        g.DrawLines(Pens.DarkGreen, chA)

        g.Dispose()

        System.Array.Copy(Ch3, fChA, 2048)
        System.Array.Copy(Ch2, fChF, 2048)

    End Sub
End Class