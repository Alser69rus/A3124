Public Class asePreparation
    Public fAngle As Integer = 0
    Public fProkachkaCheck As Boolean = True
    Public fProkachkaSpeed As Single = 0.3
    Public fProkachkaAmpl As Single = frmGMain.stend.rw.MAX_AMPL
    Public fProkachkaTime As Integer = 300

    Public Sub RefreshField()
        btnAngle.Text = "Угол наклона " & fAngle & "°"
        If fProkachkaCheck Then
            btnCheck.Text = "Прокачку выполнять"
            btnAmpl.Visible = True
            btnV.Visible = True
            btnT.Visible = True

            btnAmpl.Text = "Ход гасителя " & fProkachkaAmpl & " мм"
            btnV.Text = "Скорость " & fProkachkaSpeed & " м/с"
            btnT.Text = "Не дольше " & fProkachkaTime & " с"

        Else
            btnCheck.Text = "Не выполнять прокачку"
            btnAmpl.Visible = False
            btnV.Visible = False
            btnT.Visible = False
        End If
    End Sub

    Private Sub btnAngle_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAngle.Click
        Dim frm As New frmNumpad

        frm.btnResult.Text = fAngle
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fAngle = frm.btnResult.Text
            If fAngle < 0 Then fAngle = 0
            If fAngle > 90 Then fAngle = 90
            RefreshField()

        End If
        frm.Dispose()

    End Sub

    Private Sub btnCheck_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        fProkachkaCheck = Not fProkachkaCheck
        RefreshField()
    End Sub

    Private Sub btnT_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnT.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = fProkachkaTime
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fProkachkaTime = frm.btnResult.Text
            If fProkachkaTime < 0 Then fProkachkaTime = 0
            If fProkachkaTime > 300 Then fProkachkaTime = 300
            RefreshField()

        End If
        frm.Dispose()

    End Sub


    Private Sub btnV_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnV.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = fProkachkaSpeed
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fProkachkaSpeed = frm.btnResult.Text
            If fProkachkaSpeed < 0.02 Then fProkachkaSpeed = 0.02
            If fProkachkaSpeed > 0.6 Then fProkachkaSpeed = 0.6
            If fProkachkaAmpl < functAmin(fProkachkaSpeed) Then fProkachkaAmpl = functAmin(fProkachkaSpeed)
            If fProkachkaAmpl > functAmax(fProkachkaSpeed) Then fProkachkaAmpl = functAmax(fProkachkaSpeed)
            fProkachkaAmpl = Math.Round(fProkachkaAmpl, 1)
            RefreshField()

        End If
        frm.Dispose()

    End Sub

    Private Sub btnAmpl_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAmpl.Click
        Dim frm As New frmNumpad

        frm.btnResult.Text = fProkachkaAmpl
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fProkachkaAmpl = frm.btnResult.Text
            If fProkachkaAmpl < functAmin(fProkachkaSpeed) Then fProkachkaAmpl = functAmin(fProkachkaSpeed)
            If fProkachkaAmpl > functAmax(fProkachkaSpeed) Then fProkachkaAmpl = functAmax(fProkachkaSpeed)
            fProkachkaAmpl = Math.Round(fProkachkaAmpl, 1)
            RefreshField()
        End If
        frm.Dispose()

    End Sub
End Class