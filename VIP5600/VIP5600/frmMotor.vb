Public Class frmMotor
    Dim N As Integer
    Dim K As Single

    Private Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        frmDatchiki.Show()
        Me.Close()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        frmDatchiki.Show()
        Me.Close()
    End Sub

    Public Sub New()

        ' Этот вызов является обязательным для конструктора.
        InitializeComponent()

        ' Добавьте все инициализирующие действия после вызова InitializeComponent().
        N = frmGMain.stend.rw.N_NOM
        K = frmGMain.stend.rw.PER_SHTOK

        btnN.Text = "Частота вращения " & N & " об/мин"
        btnK.Text = "Коэффициент редуктора " & K

    End Sub

    Private Sub btnOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOk.Click
        frmGMain.stend.rw.N_NOM = N
        frmGMain.stend.rw.PER_SHTOK = K

        frmDatchiki.Show()
        Me.Close()
    End Sub

    Private Sub btnN_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnN.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = N
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            N = frm.btnResult.Text
            btnN.Text = "Частота вращения " & N & " об/мин"
        End If
        frm.Dispose()

    End Sub

    Private Sub btnK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnK.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = K
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            K = frm.btnResult.Text
            btnK.Text = "Коэффициент редуктора " & K
        End If
        frm.Dispose()
    End Sub
End Class