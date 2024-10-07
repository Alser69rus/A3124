Public Class aseIspSetAmpl
    Public fAmpl As Single
    Public fvelo As Single
    Public fTick As Integer = 0
    Public fStend As clStend = frmGMain.stend
    Public fOpros As clOpros = fStend.opros
    Public fState As eState
    Public fLog As String = ""
    Public fCurr As String = ""
    Private ft As Integer = 50


    Enum eState
        Wait
        Ampl
        Velo
        Pause
    End Enum
    Private Sub btnStop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStop.Click
        Timer1.Stop()
        fStend.SetRazbor()
        fState = eState.Pause
        btnStop.Visible = False
        btnCancel.Visible = True
        btnContinue.Visible = True
        fStend.StAmpl = clStend.eAmpl.Stop
    End Sub

    Private Sub aseIspSetAmpl_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        fState = eState.Wait
        fTick = fTick + 50
        Timer1.Start()
        ft = 50
        btnA.Text = "Ход гасителя " & fOpros.Ampl.GetValue(1).ToString("f1") & " (" & fAmpl.ToString("f1") & ") мм"
        btnV.Text = "Скорость " & fOpros.Velocity.GetValue(3).ToString("f3") & " м/с"
        btnT.Text = "Температура гасителя " & fOpros.Tgidro.GetValue(0, False) & "°С"
        fStend.StV = fvelo
    End Sub

    Private Sub btnContinue_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnContinue.Click
        btnStop.Visible = True
        btnCancel.Visible = False
        btnContinue.Visible = False
        ' fStend.Ampl = fAmpl
        fState = eState.Wait
        fStend.Velocity = fvelo
        Timer1.Start()
        ft = 50

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        fTick = fTick + 1
        'Dim s = "s" & fState & "u" & fStend.StAngle & "a" & fStend.StAmpl & "v" & fStend.StV & "e" & fStend.StendErr
        'If s <> fCurr Then
        '    fCurr = s
        '    fLog = fLog & ";" & fTick & "." & s
        'End If
        fStend.DoWork()


        If fStend.StendErr = clStend.eErr.None Then
            'fTick = fTick + 1
            Select Case fState
                Case eState.Wait
                    ft = ft - 1
                    If ft < 0 Then
                        If Math.Abs(fOpros.Ampl.GetValue(1) - fAmpl) > 1 Then
                            fState = eState.Ampl
                            fStend.Ampl = fAmpl
                            fStend.Velocity = fvelo
                        Else
                            fState = eState.Velo
                            fStend.Velocity = fvelo
                        End If
                    End If
                    
                Case eState.Ampl


                    btnA.Text = "Ход гасителя " & fOpros.Ampl.GetValue(1).ToString("f1") & " (" & fAmpl.ToString("f1") & ") мм"
                    btnV.Text = "Скорость " & fOpros.Velocity.GetValue(3).ToString("f3") & " м/с"
                    btnT.Text = "Температура гасителя " & fOpros.Tgidro.GetValue(0, False) & "°С"
                    Dim i As Integer = 100 - Math.Abs(100 * (fOpros.Ampl.GetValue(1) - fAmpl) / fAmpl)
                    If i < 0 Then i = 0
                    If i > 100 Then i = 100
                    pbA.Value = i

                    If fStend.StAmpl = clStend.eAmpl.Stop Then
                        fState = eState.Velo
                    End If
                Case eState.Velo
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Timer1.Stop()
                    Me.Close()
            End Select
        Else
            Timer1.Stop()
            fStend.SetRazbor()
            fStend.StAmpl = clStend.eAmpl.Stop
            fStend.StV = clStend.eVelocity.Stop
            Me.DialogResult = Windows.Forms.DialogResult.Abort
            Me.Close()
        End If
    End Sub
End Class