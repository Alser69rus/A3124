Public Class aseIspAngle
    Public fAngle As Single = 0
    Public fStend As clStend = frmGMain.stend
    Public fOpros As clOpros = frmGMain.stend.opros
    Public fTick As Integer = 0
    Public fState As eState = eState.Angle
    Public fLog As String = ""

    Enum eState
        Wait
        Angle
        Velocity
        Time
        Pause
    End Enum


    Private Sub aseIspAngle_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        fStend.Angle = fAngle
        fStend.Velocity = 0.075
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If fStend.StendErr = clStend.eErr.None Then
            'flog = flog & ";" & fTick & ".s" & fState & "u" & fStend.StAngle & "a" & fStend.StAmpl & "v" & fStend.StV & "e" & fStend.StendErr
            fTick = fTick + 1
            fStend.DoWork()


            btnTemp.Text = "Температура гасителя " & fOpros.Tgidro.GetValue(0, False) & "°С"

            btnV.Text = "Скорость " & fOpros.Velocity.GetValue(3).ToString("f3") & " (0,075) м/с"



            Select Case fState
                Case eState.Angle
                    btnAngle.ImageIndex = 1
                    'pbAngle.Visible = True
                    Dim i As Integer = 100 - Math.Abs(fOpros.AngleE.GetValue(1, False) - fAngle) * 100 / 90
                    If i < 0 Then i = 0
                    If i > 100 Then i = 100
                    pbAngle.Value = i
                    btnAngle.Text = "Наклон  " & fOpros.AngleE.GetValue(0, False) & " (" & fAngle & ")°"
                    If fStend.StAngle = clStend.eAngle.Stop Then
                        pbAngle.Value = 100
                        btnAngle.Text = "Наклон " & fAngle & "°"
                        fState = eState.Velocity
                        'pbAngle.Visible = False
                        btnAngle.ImageIndex = 2
                        fTick = 0
                    End If
                Case eState.Velocity
                    btnV.ImageIndex = 1
                    'pbV.Visible = True
                    Dim i As Integer = 100 - 100 * Math.Abs(fOpros.Velocity.GetValue(3) - 0.075) / 0.075
                    If i < 0 Then i = 0
                    If i > 100 Then i = 100
                    pbV.Value = i
                    i = 100 - 100 * (600 - fTick) / 600
                    If i < 0 Then i = 0
                    If i > 100 Then i = 100
                    pbT.Value = i
                    btnT.Text = "Прокачка " & (60 - fTick / 10).ToString("f1") & " c"
                    If fTick >= 600 Then
                        fState = eState.Wait
                        'pbT.Visible = False
                        btnT.ImageIndex = 2
                    End If

                    If fStend.StV = clStend.eVelocity.Work Then
                        fState = eState.Time
                        'pbV.Visible = False
                        btnV.ImageIndex = 2
                    End If
                Case eState.Time
                    btnT.ImageIndex = 1
                    'pbT.Visible = True
                    Dim i As Integer = 100 - 100 * (600 - fTick) / 600
                    If i < 0 Then i = 0
                    If i > 100 Then i = 100
                    pbT.Value = i
                    btnT.Text = "Прокачка " & (60 - fTick / 10).ToString("f1") & " c"
                    If fTick >= 600 Then
                        fState = eState.Wait
                        'pbT.Visible = False
                        btnT.ImageIndex = 2
                    End If
                Case Else
                    
                    fStend.SetRazbor()
                    fStend.StV = clStend.eVelocity.Stop
                    fStend.StAngle = clStend.eAngle.Stop
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Timer1.Enabled = False
                    Me.Close()

            End Select

        Else
            fStend.StV = clStend.eVelocity.Stop
            fStend.StAngle = clStend.eAngle.Stop
            fStend.SetRazbor()
            Me.DialogResult = Windows.Forms.DialogResult.Abort
            Timer1.Enabled = False
            Me.Close()

        End If


    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        btnStop.Visible = False
        btnCancel.Visible = True
        btnContinue.Visible = True
        fState = eState.Pause
        Timer1.Enabled = False
        fStend.SetRazbor()
        fStend.StAngle = clStend.eAngle.Stop
        fStend.StV = clStend.eVelocity.Stop

    End Sub

    Private Sub btnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinue.Click
        btnStop.Visible = True
        btnCancel.Visible = False
        btnContinue.Visible = False
        fState = eState.Angle
        Timer1.Enabled = True
        btnAngle.ImageIndex = 0
        btnV.ImageIndex = 0
        btnT.ImageIndex = 0
        fTick = 0
        fStend.Angle = fAngle
        fStend.Velocity = 0.075

    End Sub
End Class