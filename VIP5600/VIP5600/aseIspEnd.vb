Public Class aseIspEnd

    Public fState As eState
    Public fTick As Integer
    Public fStend As clStend = frmGMain.stend
    Public fOpros As clOpros = fStend.opros


    Enum eState
        Wait
        Velo
        Angle
        Angle2
        Reset
        Pause
    End Enum

    Private Sub aseIspEnd_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        fState = eState.Wait
        fTick = 50
        btnV.Text = "Скорость " & fOpros.Velocity.GetValue(3).ToString("f3") & " м/с"
        btnA.Text = "Угол наклона " & fOpros.AngleE.GetValue(0) & "°"
        If fOpros.AngleE.GetValue(0) > 1 Then
            RichTextBox1.Visible = True
        End If
        Dim i As Integer = 100 * fOpros.Velocity.GetValue(3) / 0.6
        If i < 0 Then i = 0
        If i > 100 Then i = 100
        pbV.Value = i

        i = 100 * fOpros.AngleE.GetValue(0) / 90
        If i < 0 Then i = 0
        If i > 100 Then i = 100
        pbA.Value = i

        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        fStend.DoWork()

        btnV.Text = "Скорость " & fOpros.Velocity.GetValue(3).ToString("f3") & " м/с"
        btnA.Text = "Угол наклона " & fOpros.AngleE.GetValue(0) & "°"
        If fOpros.AngleE.GetValue(0) > 1 Then
            RichTextBox1.Visible = True
        End If
        Dim i As Integer = 100 * fOpros.Ffp.GetValue(1) / 65
        If i < 0 Then i = 0
        If i > 100 Then i = 100
        pbV.Value = i

        i = 100 * fOpros.AngleE.GetValue(0) / 90
        If i < 0 Then i = 0
        If i > 100 Then i = 100
        pbA.Value = i

        Select Case fState
            Case eState.Wait
                fTick = fTick - 1
                If fTick < 0 Then
                    fState = eState.Velo
                    fStend.StV = clStend.eVelocity.Slow
                End If
            Case eState.Velo
                If fStend.StV = clStend.eVelocity.Stop Then
                    fState = eState.Angle
                    'fStend.Angle = 0
                    fTick = 50
                End If
            Case eState.Angle
                fTick = fTick - 1
                If fTick < 0 Then
                    fStend.Angle = 0
                    fStend.Velocity = 0.075
                    fState = eState.Angle2
                    fTick = 50
                End If
            Case eState.Angle2
                fTick = fTick - 1
                If fStend.StAngle = clStend.eAngle.Stop And fTick < 0 Then
                    fState = eState.Reset
                End If
            Case eState.Reset
                Me.DialogResult = Windows.Forms.DialogResult.OK
                fStend.SetRazbor()
                Timer1.Stop()
                Me.Close()
            Case Else
                Me.DialogResult = Windows.Forms.DialogResult.Abort
                Timer1.Stop()
                fStend.SetRazbor()
                Me.Close()

        End Select
    End Sub

    Private Sub btnStop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStop.Click
        btnCancel.Visible = True
        btnContinue.Visible = True
        btnStop.Visible = False
        Timer1.Stop()
        fStend.SetRazbor()
        fState = eState.Pause

    End Sub

    Private Sub btnContinue_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnContinue.Click
        btnCancel.Visible = False
        btnContinue.Visible = False
        btnStop.Visible = True

        fState = eState.Wait
        fTick = 50
        btnV.Text = "Скорость " & fOpros.Velocity.GetValue(3).ToString("f3") & " м/с"
        btnA.Text = "Угол наклона " & fOpros.AngleE.GetValue(0) & "°"
        If fOpros.AngleE.GetValue(0) > 1 Then
            RichTextBox1.Visible = True
        Else
            RichTextBox1.Visible = False
        End If
        Dim i As Integer = 100 * fOpros.Velocity.GetValue(3) / 0.6
        If i < 0 Then i = 0
        If i > 100 Then i = 100
        pbV.Value = i

        i = 100 * fOpros.AngleE.GetValue(0) / 90
        If i < 0 Then i = 0
        If i > 100 Then i = 100
        pbA.Value = i

        Timer1.Start()

        
    End Sub
End Class