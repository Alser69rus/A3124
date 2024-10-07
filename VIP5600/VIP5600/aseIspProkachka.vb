Public Class aseIspProkachka
    Public fStend As clStend = frmGMain.stend
    Public fOpros As clOpros = fStend.opros
    Public fState As eState

    Public fTick As Integer
    Public fAmpl As Single
    Public fVelo As Single
    Public fLog As String = ""

    Private ft As Integer = 50



    Enum eState
        Wait
        WaitBefore
        Ampl
        Velo
        Temp
        Pause
    End Enum
    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        btnStop.Visible = False
        btnCancel.Visible = True
        btnContinue.Visible = True
        fStend.SetRazbor()

        fStend.StV = clStend.eVelocity.Stop
        fStend.StAmpl = clStend.eAmpl.Stop
        Timer1.Stop()
        fState = eState.Pause

        btnA.ImageIndex = 0
        btnV.ImageIndex = 0
        btnTemp.ImageIndex = 0
        btnTime.ImageIndex = 0

    End Sub

    Private Sub btnContinue_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnContinue.Click
        btnStop.Visible = True
        btnCancel.Visible = False
        btnContinue.Visible = False

        ft = 50
        fState = eState.WaitBefore
        
        Timer1.Start()

    End Sub

    Private Sub aseIspProkachka_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        fState = eState.WaitBefore
       
        ft = 50
        Timer1.Start()
        pbTime.Maximum = fTick
        btnTime.Text = "Лимит времени " & (fTick / 10).ToString("f1") & " с"
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'fLog = fLog & ";" & fTick & ".s" & fState & "u" & fStend.StAngle & "a" & fStend.StAmpl & "v" & fStend.StV & "e" & fStend.StendErr
        If fStend.StendErr = clStend.eErr.None Then
            fStend.DoWork()

            Select Case fState
                Case eState.WaitBefore
                    ft = ft - 1
                    If ft < 0 Then
                        fStend.Ampl = fAmpl
                        fStend.Velocity = fVelo
                        fState = eState.Ampl
                    End If
                Case eState.Ampl
                    btnA.ImageIndex = 1

                    btnA.Text = "Ход гасителя " & fOpros.Ampl.GetValue(1).ToString("f1") & " (" & fAmpl.ToString("f1") & ") мм"
                    btnV.Text = "Скорость " & fOpros.Velocity.GetValue(3).ToString("f3") & " м/с"
                    btnTemp.Text = "Температура гасителя " & fOpros.Tgidro.GetValue(0, False) & "°С"

                    Dim i As Integer = 100 - Math.Abs(fOpros.Ampl.GetValue(1) - fAmpl) * 100 / fAmpl
                    If i < 0 Then i = 0
                    If i > 100 Then i = 100
                    pbA.Value = i

                    If fStend.StAmpl = clStend.eAmpl.Stop Then
                        btnA.ImageIndex = 2
                        fState = eState.Velo
                        pbA.Value = 100
                    End If

                Case eState.Velo
                    btnV.ImageIndex = 1
                    fTick = fTick - 1

                    btnA.Text = "Ход гасителя " & fOpros.Ampl.GetValue(1).ToString("f1")
                    btnV.Text = "Скорость " & fOpros.Velocity.GetValue(3).ToString("f3") & " (" & fVelo.ToString("f3") & ") м/с"
                    btnTemp.Text = "Температура гасителя " & fOpros.Tgidro.GetValue(0, False) & " (35)°С"
                    btnTime.Text = "Лимит времени " & (fTick / 10).ToString("f1") & " с"

                    Dim i As Integer = 100 - 100 * Math.Abs(fOpros.Velocity.GetValue(3) - fVelo) / fVelo
                    If i < 0 Then i = 0
                    If i > 100 Then i = 100
                    pbV.Value = i

                    i = 100 - (35 - fOpros.Tgidro.GetValue(0, False)) * 100 / 35
                    If i < 0 Then i = 0
                    If i > 100 Then i = 100
                    pbTemp.Value = i

                    i = pbTime.Maximum - fTick
                    pbTime.Value = i


                    If fOpros.Tgidro.GetValue(0, False) > 35 Or fTick <= 0 Then
                        fState = eState.Wait
                    End If

                    If fStend.StV = clStend.eVelocity.Work Then
                        fState = eState.Temp
                        btnV.ImageIndex = 2
                        pbV.Value = 100
                    End If

                Case eState.Temp
                    fTick = fTick - 1
                    btnTemp.ImageIndex = 1
                    btnTime.ImageIndex = 1

                    btnA.Text = "Ход гасителя " & fOpros.Ampl.GetValue(1).ToString("f1")
                    btnV.Text = "Скорость " & fOpros.Velocity.GetValue(3).ToString("f3") & " м/с"
                    btnTemp.Text = "Температура гасителя " & fOpros.Tgidro.GetValue(0, False) & " (35)°С"
                    btnTime.Text = "Лимит времени " & (fTick / 10).ToString("f1") & " с"

                    Dim i As Integer = 100 - (35 - fOpros.Tgidro.GetValue(0, False)) * 100 / 35

                    If i < 0 Then i = 0
                    If i > 100 Then i = 100
                    pbTemp.Value = i

                    i = pbTime.Maximum - fTick
                    pbTime.Value = i
                    If fOpros.Tgidro.GetValue(0, False) > 35 Or fTick <= 0 Then
                        fState = eState.Wait
                    End If

                    If fTick <= 0 Then
                        fState = eState.Wait
                    End If
                Case eState.Wait
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Timer1.Stop()
                    Me.Close()
                Case Else


            End Select
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Abort
            Timer1.Stop()
            fStend.SetRazbor()
            fStend.StAmpl = clStend.eAmpl.Stop
            fStend.StV = clStend.eVelocity.Stop
            Me.Close()

        End If

    End Sub
End Class