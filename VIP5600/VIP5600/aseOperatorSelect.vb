Public Class aseOperatorSelect

    Private Sub aseOperatorSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "GidrogasitelDataSet.Operators". При необходимости она может быть перемещена или удалена.
        Me.OperatorsTableAdapter.Fill(Me.GidrogasitelDataSet.Operators)

    End Sub


    Private Sub btnPgUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPgUp.Click
        Dim i As Integer = ListBox1.SelectedIndex
        i = i - 9
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
        i = i + 9
        If i > ListBox1.Items.Count - 1 Then i = ListBox1.Items.Count - 1
        If ListBox1.Items.Count > 0 Then ListBox1.SelectedIndex = i
        RefreshField()
    End Sub

    Public Sub RefreshField()
        If ListBox1.Items.Count > 18 Then
            btnPgUp.Visible = True
            btnUp.Visible = True
            btnDown.Visible = True
            btnPgDown.Visible = True

            Dim g As Graphics
            g = Panel1.CreateGraphics
            g.Clear(Color.SkyBlue)
            g.DrawLine(Pens.Black, 20, 5, 20, 328)

            Dim i As Single
            i = ListBox1.SelectedIndex * (318) / (ListBox1.Items.Count - 1)
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

    Private Sub ListBox1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ListBox1.DrawItem
        Dim MyBrush As Brush
        e.DrawBackground()
        Dim row As GidrogasitelDataSet.OperatorsRow
        row = ListBox1.Items(e.Index).row
        Dim s As String = ""
        If row IsNot Nothing And row.RowState <> DataRowState.Deleted Then
            s = row.Last & " " & row.First & " " & row.Second
        End If

        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            MyBrush = SystemBrushes.HighlightText
        Else
            MyBrush = Brushes.Black
        End If


        e.Graphics.DrawString(s, e.Font, MyBrush, e.Bounds)
       

        'e.DrawFocusRectangle()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        ListBox1.Refresh()

    End Sub


    Private Sub Panel1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseClick
        Dim i As Integer
        i = Math.Truncate(ListBox1.Items.Count * (e.Y - 5) / 328)
        If i < 0 Then i = 0
        If i > ListBox1.Items.Count - 1 Then i = ListBox1.Items.Count - 1
        If ListBox1.Items.Count > 0 Then ListBox1.SelectedIndex = i
    End Sub
End Class