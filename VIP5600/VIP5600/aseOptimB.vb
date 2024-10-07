Public Class aseOptimB
    Public fBs1 As Single = 100
    Public fBs2 As Single = 100
    Public fBs3 As Single = 100
    Public fBs4 As Single = 100

    Public fBr1 As Single = 100
    Public fBr2 As Single = 100
    Public fBr3 As Single = 100
    Public fBr4 As Single = 100

    Public fBreg1 As Integer = 0
    Public fBreg2 As Integer = 0
    Public fBreg3 As Integer = 0
    Public fBreg4 As Integer = 0

    Public fCheck1 As Boolean = True
    Public fCheck2 As Boolean = True
    Public fCheck3 As Boolean = True
    Public fCheck4 As Boolean = True

    Public Sub RefreshField()
        If fCheck1 Then
            btnBr1.Visible = True
            btnBs1.Visible = True
            btnBReg1.Visible = True
            btnS.Visible = True
            btnR.Visible = True
            btnReg.Visible = True
        Else
            btnBr1.Visible = False
            btnBs1.Visible = False
            btnBReg1.Visible = False
            btnS.Visible = False
            btnR.Visible = False
            btnReg.Visible = False
        End If
        If fCheck2 Then
            btnBr2.Visible = True
            btnBs2.Visible = True
            btnBReg2.Visible = True
        Else
            btnBr2.Visible = False
            btnBs2.Visible = False
            btnBReg2.Visible = False
        End If
        If fCheck3 Then
            btnBr3.Visible = True
            btnBs3.Visible = True
            btnBReg3.Visible = True
        Else
            btnBr3.Visible = False
            btnBs3.Visible = False
            btnBReg3.Visible = False
        End If
        If fCheck4 Then
            btnBr4.Visible = True
            btnBs4.Visible = True
            btnBReg4.Visible = True
        Else
            btnBr4.Visible = False
            btnBs4.Visible = False
            btnBReg4.Visible = False
        End If

        btnBs1.Text = fBs1 & " кН*с/м"
        btnBs2.Text = fBs2 & " кН*с/м"
        btnBs3.Text = fBs3 & " кН*с/м"
        btnBs4.Text = fBs4 & " кН*с/м"

        btnBr1.Text = "B1=  " & fBr1
        btnBr2.Text = "B2=  " & fBr2
        btnBr3.Text = "B3=  " & fBr3
        btnBr4.Text = "B4=  " & fBr4

        If fBreg1 = 0 Then
            btnBReg1.Text = "Не показывать"
        ElseIf fBreg1 = 1 Then
            btnBReg1.Text = "Показывать"
        Else
            btnBReg1.Text = "Учитывать"
        End If

        If fBreg2 = 0 Then
            btnBReg2.Text = "Не показывать"
        ElseIf fBreg2 = 1 Then
            btnBReg2.Text = "Показывать"
        Else
            btnBReg2.Text = "Учитывать"
        End If

        If fBreg3 = 0 Then
            btnBReg3.Text = "Не показывать"
        ElseIf fBreg3 = 1 Then
            btnBReg3.Text = "Показывать"
        Else
            btnBReg3.Text = "Учитывать"
        End If

        If fBreg4 = 0 Then
            btnBReg4.Text = "Не показывать"
        ElseIf fBreg4 = 1 Then
            btnBReg4.Text = "Показывать"
        Else
            btnBReg4.Text = "Учитывать"
        End If
    End Sub

    Private Sub btnBReg1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBReg1.Click
        If fBreg1 = 0 Then
            fBreg1 = 1
        ElseIf fBreg1 = 1 Then
            fBreg1 = 2
        Else
            fBreg1 = 0
        End If
        RefreshField()

    End Sub

    Private Sub btnBReg2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBReg2.Click
        If fBreg2 = 0 Then
            fBreg2 = 1
        ElseIf fBreg2 = 1 Then
            fBreg2 = 2
        Else
            fBreg2 = 0
        End If
        RefreshField()
    End Sub

    Private Sub btnBReg3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBReg3.Click
        If fBreg3 = 0 Then
            fBreg3 = 1
        ElseIf fBreg3 = 1 Then
            fBreg3 = 2
        Else
            fBreg3 = 0
        End If
        RefreshField()
    End Sub

    Private Sub btnBReg4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBReg4.Click
        If fBreg4 = 0 Then
            fBreg4 = 1
        ElseIf fBreg4 = 1 Then
            fBreg4 = 2
        Else
            fBreg4 = 0
        End If
        RefreshField()
    End Sub

    Private Sub btnBs1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBs1.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = fBs1
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fBs1 = frm.btnResult.Text
            RefreshField()
        End If
        frm.Dispose()

    End Sub

    Private Sub btnBs2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBs2.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = fBs2
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fBs2 = frm.btnResult.Text
            RefreshField()
        End If
        frm.Dispose()
    End Sub

    Private Sub btnBs3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBs3.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = fBs3
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fBs3 = frm.btnResult.Text
            RefreshField()
        End If
        frm.Dispose()
    End Sub

    Private Sub btnBs4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBs4.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = fBs4
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fBs4 = frm.btnResult.Text
            RefreshField()
        End If
        frm.Dispose()
    End Sub

    Private Sub btnBr1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBr1.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = fBr1
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fBr1 = frm.btnResult.Text
            RefreshField()
        End If
        frm.Dispose()
    End Sub

    Private Sub btnBr2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBr2.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = fBr2
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fBr2 = frm.btnResult.Text
            RefreshField()
        End If
        frm.Dispose()
    End Sub

    Private Sub btnBr3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBr3.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = fBr3
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fBr3 = frm.btnResult.Text
            RefreshField()
        End If
        frm.Dispose()
    End Sub

    Private Sub btnBr4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBr4.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = fBr4
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fBr4 = frm.btnResult.Text
            RefreshField()
        End If
        frm.Dispose()
    End Sub
End Class