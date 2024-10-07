Public Class frmSetAmpl

    Public Value As Single

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        TrackBar1.Value = 20
        Value = 20
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        TrackBar1.Value = 25
        Value = 25
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        TrackBar1.Value = 30
        Value = 30
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        TrackBar1.Value = 35
        Value = 35
    End Sub

    Private Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click
        TrackBar1.Value = 40
        Value = 40
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TrackBar1.Value = 50
        Value = 50
    End Sub



    Private Sub TrackBar1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TrackBar1.MouseDown

        Value = 20 * (e.X - 10) / (TrackBar1.Width - 20) + 20

        If Value > 40 Then Value = 40
        If Value < 20 Then Value = 20
        TrackBar1.Value = Value


    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll

    End Sub



    Private Sub TrackBar1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TrackBar1.ValueChanged

        Me.btnAmpl.Text = TrackBar1.Value & " мм"
        Value = TrackBar1.Value
    End Sub

    Private Sub btnAmpl_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAmpl.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = Value
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Value = frm.btnResult.Text
            If Value > 40 Then Value = 40
            If Value < 20 Then Value = 20
            TrackBar1.Value = Value
        End If
        frm.Dispose()

    End Sub

    Public Sub New()

        ' Этот вызов является обязательным для конструктора.
        InitializeComponent()

        Value = frmGMain.stend.Ampl
        If Value > 40 Then
            TrackBar1.Value = 40
        ElseIf Value < 20 Then
            TrackBar1.Value = 20
        Else
            TrackBar1.Value = Value
        End If
        Me.btnAmpl.Text = TrackBar1.Value & " мм"
        ' Добавьте все инициализирующие действия после вызова InitializeComponent().

    End Sub

End Class