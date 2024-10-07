Public Class aseApparatTypeSelect

    Private Sub aseApparatTypeSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "GidrogasitelDataSet.ApparatType". При необходимости она может быть перемещена или удалена.
        Me.ApparatTypeTableAdapter.Fill(Me.GidrogasitelDataSet.ApparatType)

    End Sub

    Private Sub btnPgUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPgUp.Click
        Dim i As Integer = ListBox1.SelectedIndex
        i = i - 10
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
        i = i + 10
        If i > ListBox1.Items.Count - 1 Then i = ListBox1.Items.Count - 1
        If ListBox1.Items.Count > 0 Then ListBox1.SelectedIndex = i
    End Sub

    Private Sub Panel1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseClick
        Dim i As Integer = Math.Truncate((e.Y - 5) * ListBox1.Items.Count / 360)
        If i < 0 Then i = 0
        If i > ListBox1.Items.Count - 1 Then i = ListBox1.Items.Count - 1
        If ListBox1.Items.Count > 0 Then ListBox1.SelectedIndex = i
        PanelDraw()

    End Sub

    Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        PanelDraw()

    End Sub
    Private Sub PanelDraw()
        If ListBox1.Items.Count > 10 Then
            btnPgUp.Visible = True
            btnUp.Visible = True
            btnDown.Visible = True
            btnPgDown.Visible = True
            Dim g As Graphics
            g = Panel1.CreateGraphics
            g.Clear(Color.LightSteelBlue)
            g.DrawLine(Pens.Black, 20, 5, 20, 365)
            Dim i As Single = 350 * ListBox1.SelectedIndex / (ListBox1.Items.Count - 1)
            g.FillEllipse(Brushes.Black, 15, 5 + i, 10, 10)
            g.FillEllipse(Brushes.LightSteelBlue, 18, 8 + i, 4, 4)
            g.Dispose()

        Else
            btnPgUp.Visible = False
            btnUp.Visible = False
            btnDown.Visible = False
            btnPgDown.Visible = False
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        PanelDraw()
    End Sub
End Class