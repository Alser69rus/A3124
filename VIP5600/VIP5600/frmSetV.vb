Public Class frmSetV
    Public Value As Single
    Public Sub New()


        ' Этот вызов является обязательным для конструктора.
        InitializeComponent()

        Value = frmGMain.opros.Velocity.GetValue(3)
        btnV.Text = Value.ToString("f3") & " м/с"
        If Value > 0.6 Then Value = 0.6
        If Value < 0 Then Value = 0

        TrackBar1.Value = Value * 1000
        ' Добавьте все инициализирующие действия после вызова InitializeComponent().


    End Sub

    Private Sub TrackBar1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TrackBar1.MouseDown


        Value = 600 * (e.X - 10) / (TrackBar1.Width - 20)
        If Value > 600 Then
            Value = 600
        ElseIf Value < 0 Then
            Value = 0

        End If

        TrackBar1.Value = Value


    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
       
    End Sub

    Private Sub TrackBar1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TrackBar1.ValueChanged
        Value = TrackBar1.Value / 1000
        btnV.Text = Value.ToString("f3") & " м/с"
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Value = 0
        TrackBar1.Value = 0
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Value = 0.02
        TrackBar1.Value = 20

    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Value = 0.06
        TrackBar1.Value = 60
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        Value = 0.075
        TrackBar1.Value = 75
    End Sub

    Private Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click
        Value = 0.15
        TrackBar1.Value = 150
    End Sub

    Private Sub Button6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.Click
        Value = 0.3
        TrackBar1.Value = 300
    End Sub

    Private Sub Button7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.Click
        Value = 0.6
        TrackBar1.Value = 600
    End Sub

    Private Sub btnV_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnV.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = Value.ToString("f3")
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Value = frm.btnResult.Text
            If Value > 0.6 Then Value = 0.6
            If Value < 0 Then Value = 0
            TrackBar1.Value = 1000 * Value
        End If
        frm.Dispose()

    End Sub
End Class