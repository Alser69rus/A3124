Public Class aseOptimG
    Public fReg1 As Integer = 0
    Public fReg2 As Integer = 0
    Public fReg3 As Integer = 0
    Public fReg4 As Integer = 0

    Public fCheck1 As Boolean = True
    Public fCheck2 As Boolean = True
    Public fCheck3 As Boolean = True
    Public fCheck4 As Boolean = True

    Public fV1 As Single = 0.3
    Public fV2 As Single = 0.3
    Public fV3 As Single = 0.3
    Public fV4 As Single = 0.3


    Public Sub RefreshField()
        btn1.Visible = fCheck1
        btn2.Visible = fCheck2
        btn3.Visible = fCheck3
        btn4.Visible = fCheck4

        btn1.ImageIndex = fReg1
        btn2.ImageIndex = fReg2
        btn3.ImageIndex = fReg3
        btn4.ImageIndex = fReg4

        btn1.Text = "V1=" & fV1 & " м/с"
        btn2.Text = "V2=" & fV2 & " м/с"
        btn3.Text = "V3=" & fV3 & " м/с"
        btn4.Text = "V4=" & fV4 & " м/с"
    End Sub

    Private Sub btn1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn1.Click
        fReg1 = fReg1 + 1
        If fReg1 > 3 Then fReg1 = 0
        RefreshField()

    End Sub

    Private Sub btn2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn2.Click
        fReg2 = fReg2 + 1
        If fReg2 > 3 Then fReg2 = 0
        RefreshField()
    End Sub

    Private Sub btn3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn3.Click
        fReg3 = fReg3 + 1
        If fReg3 > 3 Then fReg3 = 0
        RefreshField()
    End Sub

    Private Sub btn4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn4.Click
        fReg4 = fReg4 + 1
        If fReg4 > 3 Then fReg4 = 0
        RefreshField()
    End Sub
End Class