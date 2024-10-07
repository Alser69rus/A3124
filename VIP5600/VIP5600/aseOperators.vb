Public Class aseOperators

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        frmMenuOption.Show()
        Me.Close()

    End Sub

    Private Sub aseOperators_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "GidrogasitelDataSet.Operators". При необходимости она может быть перемещена или удалена.
        Me.OperatorsTableAdapter.Fill(Me.GidrogasitelDataSet.Operators)

    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If ListBox1.Items.Count > 0 Then
            Dim row As GidrogasitelDataSet.OperatorsRow = GidrogasitelDataSet.Operators.FindByID(ListBox1.Tag)
            'OperatorsTableAdapter.Delete(row.ID)
            row.Delete()
            'GidrogasitelDataSet.Operators.RemoveOperatorsRow(row)
            OperatorsTableAdapter.Update(GidrogasitelDataSet.Operators)
        End If

    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim frm As New aseOperatorChange
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim row As GidrogasitelDataSet.OperatorsRow = GidrogasitelDataSet.Operators.NewOperatorsRow
            row.Last = frm.fLast
            row.First = frm.fFirst
            row.Second = frm.fSecond
            row.Appointment = frm.fAppointment
            GidrogasitelDataSet.Operators.AddOperatorsRow(row)
            OperatorsTableAdapter.Update(GidrogasitelDataSet.Operators)
        End If

            frmMainMenu.Dispose()

    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim row As GidrogasitelDataSet.OperatorsRow = GidrogasitelDataSet.Operators.FindByID(ListBox1.Tag)

        Dim frm As New aseOperatorChange
        frm.fLast = row.Last
        frm.fFirst = row.First
        frm.fSecond = row.Second
        frm.fAppointment = row.Appointment
        frm.RefreshField()

        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            row.First = frm.fFirst
            row.Second = frm.fSecond
            row.Last = frm.fLast
            row.Appointment = frm.fAppointment
            OperatorsTableAdapter.Update(GidrogasitelDataSet.Operators)
            ListBox1.Refresh()
        End If

        frm.Dispose()

    End Sub

 

    Private Sub ListBox1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ListBox1.DrawItem
        e.DrawBackground()
        Dim row As GidrogasitelDataSet.OperatorsRow
        Dim MyBrush As Brush

        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            MyBrush = SystemBrushes.HighlightText
        Else
            MyBrush = Brushes.Black
        End If

        row = ListBox1.Items(e.Index).row
        If row.RowState <> DataRowState.Deleted Then
            If e.Index = ListBox1.SelectedIndex Then
                e.Graphics.DrawString(row.Last + " " + row.First + " " + row.Second, e.Font, MyBrush, e.Bounds)
            Else
                e.Graphics.DrawString(row.Last + " " + row.First + " " + row.Second, e.Font, MyBrush, e.Bounds)
            End If

            'e.DrawFocusRectangle()
        End If


    End Sub

    Private Sub btnPgDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPgDown.Click
        Dim i As Integer = ListBox1.SelectedIndex
        i = i + 10
        If i > ListBox1.Items.Count - 1 Then i = ListBox1.Items.Count - 1
        If ListBox1.Items.Count > 0 Then ListBox1.SelectedIndex = i
    End Sub

    Private Sub btnDown_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDown.Click
        Dim i As Integer = ListBox1.SelectedIndex
        i = i + 1
        If i > ListBox1.Items.Count - 1 Then i = ListBox1.Items.Count - 1
        If ListBox1.Items.Count > 0 Then ListBox1.SelectedIndex = i
    End Sub

    Private Sub btnPgUp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPgUp.Click
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

    Private Sub Panel1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseClick
        Dim i As Single = Math.Truncate((e.Y - 5) * ListBox1.Items.Count / 360)
        If i < 0 Then i = 0
        If i > ListBox1.Items.Count - 1 Then i = ListBox1.Items.Count - 1
        ListBox1.SelectedIndex = i
    End Sub

    Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Dim g As Graphics
        g = Panel1.CreateGraphics
        g.Clear(Color.SkyBlue)
        If ListBox1.Items.Count > 10 Then
            btnUp.Visible = True
            btnPgUp.Visible = True
            btnPgDown.Visible = True
            btnDown.Visible = True
            g.DrawLine(Pens.Black, 20, 5, 20, 365)
            g.FillEllipse(Brushes.Black, 15, 5, 10, 10)
            g.FillEllipse(Brushes.SkyBlue, 18, 8, 4, 4)
        Else
            btnUp.Visible = False
            btnPgUp.Visible = False
            btnPgDown.Visible = False
            btnDown.Visible = False

        End If

        g.Dispose()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim g As Graphics
        g = Panel1.CreateGraphics
        g.Clear(Color.SkyBlue)
        
        If ListBox1.Items.Count > 10 Then
            Dim i As Single = 350 * ListBox1.SelectedIndex / (ListBox1.Items.Count - 1)
            g.DrawLine(Pens.Black, 20, 5, 20, 365)
            g.FillEllipse(Brushes.Black, 15, 5 + i, 10, 10)
            g.FillEllipse(Brushes.SkyBlue, 18, 8 + i, 4, 4)

        End If
        'ListBox1.Refresh()
        g.Dispose()

    End Sub

    Private Sub OperatorsBindingSource_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles OperatorsBindingSource.ListChanged
        If ListBox1.Items.Count > 10 Then

            btnUp.Visible = True
            btnPgUp.Visible = True
            btnPgDown.Visible = True
            btnDown.Visible = True

            Dim g As Graphics
            g = Panel1.CreateGraphics
            g.Clear(Color.SkyBlue)
            If ListBox1.Items.Count > 1 Then
                Dim i As Single = 350 * ListBox1.SelectedIndex / (ListBox1.Items.Count - 1)
                g.DrawLine(Pens.Black, 20, 5, 20, 365)
                g.FillEllipse(Brushes.Black, 15, 5 + i, 10, 10)
                g.FillEllipse(Brushes.SkyBlue, 18, 8 + i, 4, 4)

            End If

            g.Dispose()
        Else

            btnUp.Visible = False
            btnPgUp.Visible = False
            btnPgDown.Visible = False
            btnDown.Visible = False
        End If
    End Sub
End Class