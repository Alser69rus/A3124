Public Class aseOptimE
    Public fCheck1 As Boolean = True
    Public fCheck2 As Boolean = True
    Public fCheck3 As Boolean = True
    Public fCheck4 As Boolean = True

    Public fE1 As Single = 1400
    Public fE2 As Single = 1400
    Public fE3 As Single = 1400
    Public fE4 As Single = 1400

    Public fDE1 As Single = 360
    Public fDE2 As Single = 360
    Public fDE3 As Single = 360
    Public fDE4 As Single = 360

    Public fReg1 As Integer = 0
    Public fReg2 As Integer = 0
    Public fReg3 As Integer = 0
    Public fReg4 As Integer = 0

    Public Sub RefreshField()
        If fCheck1 Then
            btnE1.Visible = True
            btnDE1.Visible = True
            btnReg1.Visible = True
        Else
            btnE1.Visible = False
            btnDE1.Visible = False
            btnReg1.Visible = False
        End If

        If fCheck2 Then
            btnE2.Visible = True
            btnDE2.Visible = True
            btnReg2.Visible = True
        Else
            btnE2.Visible = False
            btnDE2.Visible = False
            btnReg2.Visible = False
        End If

        If fCheck3 Then
            btnE3.Visible = True
            btnDE3.Visible = True
            btnReg3.Visible = True
        Else
            btnE3.Visible = False
            btnDE3.Visible = False
            btnReg3.Visible = False
        End If

        If fCheck4 Then
            btnE4.Visible = True
            btnDE4.Visible = True
            btnReg4.Visible = True
        Else
            btnE4.Visible = False
            btnDE4.Visible = False
            btnReg4.Visible = False
        End If

        btnE1.Text = "E1=" & fE1
        btnE2.Text = "E2=" & fE2
        btnE3.Text = "E3=" & fE3
        btnE4.Text = "E4=" & fE4

        btnDE1.Text = "±" & fDE1 & " Дж"
        btnDE2.Text = "±" & fDE2 & " Дж"
        btnDE3.Text = "±" & fDE3 & " Дж"
        btnDE4.Text = "±" & fDE4 & " Дж"

        If fReg1 = 0 Then
            btnReg1.Text = "Не показывать"
        ElseIf fReg1 = 1 Then
            btnReg1.Text = "Показывать"
        Else
            btnReg1.Text = "Учитывать"
        End If

        If fReg2 = 0 Then
            btnReg2.Text = "Не показывать"
        ElseIf fReg2 = 1 Then
            btnReg2.Text = "Показывать"
        Else
            btnReg2.Text = "Учитывать"
        End If

        If fReg3 = 0 Then
            btnReg3.Text = "Не показывать"
        ElseIf fReg3 = 1 Then
            btnReg3.Text = "Показывать"
        Else
            btnReg3.Text = "Учитывать"
        End If

        If fReg4 = 0 Then
            btnReg4.Text = "Не показывать"
        ElseIf fReg4 = 1 Then
            btnReg4.Text = "Показывать"
        Else
            btnReg4.Text = "Учитывать"
        End If

    End Sub

    Private Sub btnReg1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReg1.Click
        If fReg1 = 0 Then
            fReg1 = 1
        ElseIf fReg1 = 1 Then
            fReg1 = 2
        Else
            fReg1 = 0
        End If
        RefreshField()

    End Sub

    Private Sub btnReg2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReg2.Click
        If fReg2 = 0 Then
            fReg2 = 1
        ElseIf fReg2 = 1 Then
            fReg2 = 2
        Else
            fReg2 = 0
        End If
        RefreshField()
    End Sub

    Private Sub btnReg3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReg3.Click
        If fReg3 = 0 Then
            fReg3 = 1
        ElseIf fReg3 = 1 Then
            fReg3 = 2
        Else
            fReg3 = 0
        End If
        RefreshField()
    End Sub

    Private Sub btnReg4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReg4.Click
        If fReg4 = 0 Then
            fReg4 = 1
        ElseIf fReg4 = 1 Then
            fReg4 = 2
        Else
            fReg4 = 0
        End If
        RefreshField()
    End Sub

    Private Sub btnE1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnE1.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = fE1
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fE1 = frm.btnResult.Text
            RefreshField()
        End If
        frm.Dispose()

    End Sub

    Private Sub btnE2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnE2.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = fE2
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fE2 = frm.btnResult.Text
            RefreshField()
        End If
        frm.Dispose()

    End Sub

    Private Sub btnE3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnE3.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = fE3
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fE3 = frm.btnResult.Text
            RefreshField()
        End If
        frm.Dispose()

    End Sub

    Private Sub btnE4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnE4.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = fE4
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fE4 = frm.btnResult.Text
            RefreshField()
        End If
        frm.Dispose()

    End Sub

    Private Sub btnDE1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDE1.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = fDE1
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fDE1 = frm.btnResult.Text
            RefreshField()
        End If
        frm.Dispose()

    End Sub

    Private Sub btnDE2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDE2.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = fDE2
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fDE2 = frm.btnResult.Text
            RefreshField()
        End If
        frm.Dispose()
    End Sub

    Private Sub btnDE3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDE3.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = fDE3
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fDE3 = frm.btnResult.Text
            RefreshField()
        End If
        frm.Dispose()
    End Sub

    Private Sub btnDE4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDE4.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = fDE4
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fDE4 = frm.btnResult.Text
            RefreshField()
        End If
        frm.Dispose()
    End Sub
End Class