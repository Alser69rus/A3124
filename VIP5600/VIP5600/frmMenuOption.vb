Public Class frmMenuOption


    Private Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        frmMainMenu.Show()
        Me.Close()

    End Sub


    Public Sub New()

        ' Этот вызов является обязательным для конструктора.
        InitializeComponent()

        ' Добавьте все инициализирующие действия после вызова InitializeComponent().

    End Sub

    Private Sub btnDat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDat.Click
        frmDatchiki.Show()
        Me.Close()

    End Sub

    Private Sub btnOpt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOpt.Click
        frmStendOption.Show()
        Me.Close()

    End Sub

    Private Sub btnRemont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemont.Click
        aseRemont.Show()
        Me.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        aseAppointment.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        aseOperators.Show()
        Me.Close()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        aseApparats.Show()
        Me.Close()

    End Sub

    Private Sub btnApparatsType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApparatsType.Click
        aseApparatsType.Show()
        Me.Close()

    End Sub
End Class