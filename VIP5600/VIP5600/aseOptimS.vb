Public Class aseOptimS
    Public fCheck1 As Boolean = True
    Public fCheck2 As Boolean = True
    Public fCheck3 As Boolean = True
    Public fCheck4 As Boolean = True

    Public fS1 As Single = 25
    Public fS2 As Single = 25
    Public fS3 As Single = 25
    Public fS4 As Single = 25

    Public fReg1 As Integer = 0
    Public fReg2 As Integer = 0
    Public fReg3 As Integer = 0
    Public fReg4 As Integer = 0

    Public Sub RefreshField()
        If fCheck1 Then
            btnS1.Visible = True
            btnReg1.Visible = True
        Else
            btnS1.Visible = False
            btnReg1.Visible = False
        End If
        If fCheck2 Then
            btnS2.Visible = True
            btnReg2.Visible = True
        Else
            btnS2.Visible = False
            btnReg2.Visible = False
        End If
        If fCheck3 Then
            btnS3.Visible = True
            btnReg3.Visible = True
        Else
            btnS3.Visible = False
            btnReg3.Visible = False
        End If
        If fCheck4 Then
            btnS4.Visible = True
            btnReg4.Visible = True
        Else
            btnS4.Visible = False
            btnReg4.Visible = False
        End If

        btnS1.Text = "S1=" & fS1 & "%"
        btnS2.Text = "S2=" & fS2 & "%"
        btnS3.Text = "S3=" & fS3 & "%"
        btnS4.Text = "S4=" & fS4 & "%"

        If fReg1 = 0 Then
            btnReg1.Text = "Не учитывать"
        Else
            btnReg1.Text = "Учитывать"
        End If

        If fReg2 = 0 Then
            btnReg2.Text = "Не учитывать"
        Else
            btnReg2.Text = "Учитывать"
        End If

        If fReg3 = 0 Then
            btnReg3.Text = "Не учитывать"
        Else
            btnReg3.Text = "Учитывать"
        End If

        If fReg4 = 0 Then
            btnReg4.Text = "Не учитывать"
        Else
            btnReg4.Text = "Учитывать"
        End If
       
    End Sub

    Private Sub btnS1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnS1.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = fS1
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fS1 = frm.btnResult.Text
            RefreshField()
        End If
        frm.Dispose()

    End Sub

    Private Sub btnS2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnS2.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = fS2
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fS2 = frm.btnResult.Text
            RefreshField()
        End If
        frm.Dispose()
    End Sub

    Private Sub btnS3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnS3.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = fS3
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fS3 = frm.btnResult.Text
            RefreshField()
        End If
        frm.Dispose()
    End Sub

    Private Sub btnS4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnS4.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = fS4
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fS4 = frm.btnResult.Text
            RefreshField()
        End If
        frm.Dispose()
    End Sub

    Private Sub btnReg1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReg1.Click
        If fReg1 = 0 Then
            fReg1 = 1
        Else
            fReg1 = 0
        End If
        RefreshField()

        
    End Sub

    Private Sub btnReg2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReg2.Click
        If fReg2 = 0 Then
            fReg2 = 1
        Else
            fReg2 = 0
        End If
        RefreshField()

    End Sub

    Private Sub btnReg3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReg3.Click
        If fReg3 = 0 Then
            fReg3 = 1
        Else
            fReg3 = 0
        End If
        RefreshField()

    End Sub

    Private Sub btnReg4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReg4.Click
        If fReg4 = 0 Then
            fReg4 = 1
        Else
            fReg4 = 0
        End If
        RefreshField()

    End Sub
End Class