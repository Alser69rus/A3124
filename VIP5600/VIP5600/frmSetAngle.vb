Public Class frmSetAngle

    Public Value As Single


    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Value = 0
        TrackBar1.Value = 0
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Value = 15
        TrackBar1.Value = 15
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Value = 30
        TrackBar1.Value = 30
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        Value = 45
        TrackBar1.Value = 45
    End Sub

    Private Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click
        Value = 60
        TrackBar1.Value = 60
    End Sub

    Private Sub Button7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.Click
        Value = 90
        TrackBar1.Value = 90
    End Sub

    Private Sub Button6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.Click
        Value = 75
        TrackBar1.Value = 75
    End Sub

    Private Sub TrackBar1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TrackBar1.MouseDown
        Value = 90 * (e.X - 10) / (TrackBar1.Width - 20)
        If Value < 0 Then Value = 0
        If Value > 90 Then Value = 90
        Me.TrackBar1.Value = Value


    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
       
    End Sub

    Private Sub TrackBar1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TrackBar1.ValueChanged
        Value = TrackBar1.Value
        Me.btnAngle.Text = Value & "°"

    End Sub

    Public Sub New()

        ' Этот вызов является обязательным для конструктора.
        InitializeComponent()
        Value = frmGMain.stend.Angle
        If Value > 90 Then
            TrackBar1.Value = 90
        ElseIf Value < 0 Then
            TrackBar1.Value = 0
        Else
            TrackBar1.Value = Value
        End If
        ' Me.TrackBar1.Value = frmGMain.stend.Angle
        Me.btnAngle.Text = Value & "°"
        ' Добавьте все инициализирующие действия после вызова InitializeComponent().

    End Sub

    Private Sub btnAngle_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAngle.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = Value
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Value = frm.btnResult.Text
            If Value > 90 Then Value = 90
            If Value < 0 Then Value = 0
            TrackBar1.Value = Value

        End If
        frm.Dispose()

    End Sub
End Class