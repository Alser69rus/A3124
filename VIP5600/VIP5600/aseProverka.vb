Public Class aseProverka
    Public fCheck As Boolean = True
    Public fV As Single = 0.3
    Public fAmpl As Single = 40
    Public fFs As Single = 11
    Public fDFs As Single = 3
    Public fFr As Single = 11
    Public fDFr As Single = 3
    Public fE As Integer = 1400
    Public fDE As Integer = 360
    Public fT As Integer = 300
    Public fReg As Integer = 0


    Public Sub RefreshField()
        If fCheck Then
            btnAmpl.Visible = True
            btnDE.Visible = True
            btnDFr.Visible = True
            btnDFs.Visible = True
            btnE.Visible = True
            btnFr.Visible = True
            btnFs.Visible = True
            btnReg.Visible = True
            btnSpeed.Visible = True
            btnT.Visible = True

            btnAmpl.Text = "Ход " & fAmpl.ToString("f1") & " мм"
            btnDE.Text = "±" & fDE & " Дж"
            btnDFr.Text = "±" & fDFr.ToString("f1") & " кН"
            btnDFs.Text = "±" & fDFs.ToString("f1") & " кН"
            btnE.Text = "Энергоемкость                 " & fE
            btnFr.Text = "Усилие растяжения         " & fFr.ToString("f1")
            btnFs.Text = "Усилие сжатия                  " & fFs.ToString("f1")
            btnSpeed.Text = "Скорость " & fV & " м/с"
            btnT.Text = "Длительность " & fT & " с"
            If fReg = 0 Then
                btnReg.Text = "Свободный режим"
            ElseIf fReg = 1 Then
                btnReg.Text = "Дроссельный режим"
            ElseIf fReg = 2 Then
                btnReg.Text = "Клапанный режим"
            Else
                btnReg.Text = "Режим не выбран"
            End If
        Else
            btnAmpl.Visible = False
            btnDE.Visible = False
            btnDFr.Visible = False
            btnDFs.Visible = False
            btnE.Visible = False
            btnFr.Visible = False
            btnFs.Visible = False
            btnReg.Visible = False
            btnSpeed.Visible = False
            btnT.Visible = False

        End If
    End Sub

    Private Sub btnReg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReg.Click
        If fReg = 0 Then
            fReg = 1
        ElseIf fReg = 1 Then
            fReg = 2
        ElseIf fReg = 2 Then
            fReg = 0
        Else

        End If
        RefreshField()

    End Sub

    Private Sub btnCheck_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        fCheck = Not fCheck
        If fCheck Then
            btnCheck.Text = "Выполнять проверку"
        Else
            btnCheck.Text = "Не выполнять проверку"
        End If
        RefreshField()

    End Sub

    Private Sub btnT_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnT.Click
        Dim frm As New frmNumpad

        frm.btnResult.Text = fT
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fT = frm.btnResult.Text
            If fT > 300 Then fT = 300
            If fT < 0 Then fT = 0
            RefreshField()
        End If



        frm.Dispose()

    End Sub

    Private Sub btnSpeed_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSpeed.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = fV
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fV = frm.btnResult.Text
            If fV < 0.02 Then fV = 0.02
            If fV > 0.6 Then fV = 0.6
            If fAmpl < functAmin(fV) Then fAmpl = functAmin(fV)
            If fAmpl > functAmax(fV) Then fAmpl = functAmax(fV)
            RefreshField()

        End If
        frm.Dispose()

    End Sub

    Private Sub btnAmpl_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAmpl.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = fAmpl
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fAmpl = frm.btnResult.Text
            If fAmpl < functAmin(fV) Then fAmpl = functAmin(fV)
            If fAmpl > functAmax(fV) Then fAmpl = functAmax(fV)
            RefreshField()
        End If
        frm.Dispose()

    End Sub

    Private Sub btnFs_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFs.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = fFs
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fFs = frm.btnResult.Text
            If fFs < 0 Then fFs = 0
            If fFs > 50 Then fFs = 50

        End If
        RefreshField()

        frm.Dispose()

    End Sub

    Private Sub btnDFs_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDFs.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = fDFs
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fDFs = frm.btnResult.Text
            If fDFs < 0 Then fDFs = 0
            If fDFs > 50 Then fDFs = 50

        End If
        RefreshField()

        frm.Dispose()
    End Sub

    Private Sub btnDFr_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDFr.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = fDFr
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fDFr = frm.btnResult.Text
            If fDFr < 0 Then fDFr = 0
            If fDFr > 50 Then fDFr = 50

        End If
        RefreshField()

        frm.Dispose()
    End Sub

    Private Sub btnFr_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFr.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = fFr
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fFr = frm.btnResult.Text
            If fFr < 0 Then fFr = 0
            If fFr > 50 Then fFr = 50

        End If
        RefreshField()

        frm.Dispose()
    End Sub

    Private Sub btnE_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnE.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = fE
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fE = frm.btnResult.Text
            If fE < 0 Then fE = 0
            If fE > 10000 Then fE = 10000

        End If
        RefreshField()

        frm.Dispose()
    End Sub

    Private Sub btnDE_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDE.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = fDE
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fDE = frm.btnResult.Text
            If fDE < 0 Then fDE = 0
            If fDE > 10000 Then fDE = 10000

        End If
        RefreshField()

        frm.Dispose()
    End Sub
End Class