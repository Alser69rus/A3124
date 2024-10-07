Public Class aseGasitelSelect



    Private Sub aseGasitelSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "GidrogasitelDataSet.Apparats". При необходимости она может быть перемещена или удалена.
        Me.ApparatsTableAdapter.Fill(Me.GidrogasitelDataSet.Apparats)

    End Sub

    Private Sub btnPgUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPgUp.Click
        Dim i As Integer = ListBox1.SelectedIndex
        i = i - 8
        If i < 0 Then i = 0
        If ListBox1.Items.Count > 0 Then ListBox1.SelectedIndex = i
    End Sub

    Private Sub btnUp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUp.Click
        Dim i As Integer = ListBox1.SelectedIndex
        i = i - 1
        If i < 0 Then i = 0
        If ListBox1.Items.Count > 0 Then ListBox1.SelectedIndex = i
    End Sub

    Private Sub btnDown_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDown.Click
        Dim i As Integer = ListBox1.SelectedIndex
        i = i + 1
        If i > ListBox1.Items.Count - 1 Then i = ListBox1.Items.Count - 1
        If ListBox1.Items.Count > 0 Then ListBox1.SelectedIndex = i
    End Sub

    Private Sub btnPgDown_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPgDown.Click
        Dim i As Integer = ListBox1.SelectedIndex
        i = i + 8
        If i > ListBox1.Items.Count - 1 Then i = ListBox1.Items.Count - 1
        If ListBox1.Items.Count > 0 Then ListBox1.SelectedIndex = i
        RefreshField()
    End Sub

    Public Sub RefreshField()
        If ListBox1.Items.Count > 16 Then
            btnPgUp.Visible = True
            btnUp.Visible = True
            btnDown.Visible = True
            btnPgDown.Visible = True

            Dim g As Graphics
            g = Panel1.CreateGraphics
            g.Clear(Color.SkyBlue)
            g.DrawLine(Pens.Black, 20, 5, 20, 291)

            Dim i As Single
            i = ListBox1.SelectedIndex * (281) / (ListBox1.Items.Count - 1)
            g.FillEllipse(Brushes.Black, 15, i, 10, 10)
            g.FillEllipse(Brushes.SkyBlue, 18, i + 3, 4, 4)

            g.Dispose()

        Else
            btnPgUp.Visible = False
            btnUp.Visible = False
            btnDown.Visible = False
            btnPgDown.Visible = False
        End If
    End Sub

    Private Sub aseGasitelSelect_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        RefreshField()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        RefreshField()
    End Sub

    
    Private Sub Panel1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseClick
        Dim i As Integer
        i = Math.Truncate(ListBox1.Items.Count * (e.Y - 5) / 291)
        If i < 0 Then i = 0
        If i > ListBox1.Items.Count - 1 Then i = ListBox1.Items.Count - 1
        If ListBox1.Items.Count > 0 Then ListBox1.SelectedIndex = i
    End Sub
End Class