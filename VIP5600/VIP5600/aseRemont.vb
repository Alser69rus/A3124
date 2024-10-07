Public Class aseRemont


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "GidrogasitelDataSet.Remont". При необходимости она может быть перемещена или удалена.
        Me.RemontTableAdapter.Fill(Me.GidrogasitelDataSet.Remont)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "GidrogasitelDataSet.Remont". При необходимости она может быть перемещена или удалена.
        'Me.RemontTableAdapter.Fill(Me.GidrogasitelDataSet.Remont)

    End Sub

    Public Sub New()

        ' Этот вызов является обязательным для конструктора.
        InitializeComponent()


        ' Добавьте все инициализирующие действия после вызова InitializeComponent().

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPgUp.Click
        Dim i As Integer = ListBox1.SelectedIndex
        i = i - 9
        If i < 0 Then i = 0
        If ListBox1.Items.Count > 0 Then
            ListBox1.SelectedIndex = i
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp.Click
        Dim i As Integer = ListBox1.SelectedIndex
        i = i - 1
        If i < 0 Then i = 0
        If ListBox1.Items.Count > 0 Then
            ListBox1.SelectedIndex = i
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown.Click
        Dim i As Integer = ListBox1.SelectedIndex
        i = i + 1
        If i > ListBox1.Items.Count - 1 Then i = ListBox1.Items.Count - 1
        If ListBox1.Items.Count > 0 Then
            ListBox1.SelectedIndex = i
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPgDown.Click
        Dim i As Integer = ListBox1.SelectedIndex
        i = i + 9
        If i > ListBox1.Items.Count - 1 Then i = ListBox1.Items.Count - 1
        If ListBox1.Items.Count > 0 Then
            ListBox1.SelectedIndex = i
        End If

    End Sub



    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim g As Graphics
        g = Panel1.CreateGraphics

        g.Clear(Color.SkyBlue)
        If ListBox1.Items.Count > 1 Then
            Dim v As Single = 355 * ListBox1.SelectedIndex / (ListBox1.Items.Count - 1)
            g.DrawLine(Pens.Black, 20, 5, 20, 365)
            g.FillEllipse(Brushes.Black, 15, 5 + v, 10, 10)
            g.FillEllipse(Brushes.SkyBlue, 18, 8 + v, 4, 4)
        End If
        g.Dispose()
    End Sub

    Private Sub Panel1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseClick
        Dim i As Integer = e.Y
        i = (i - 5) * ListBox1.Items.Count / 360
        If i < 0 Then i = 0
        If i > ListBox1.Items.Count - 1 Then i = ListBox1.Items.Count - 1
        If ListBox1.Items.Count > 0 Then ListBox1.SelectedIndex = i

    End Sub



    Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        If ListBox1.Items.Count < 19 Then
            Panel1.Visible = False
        Else
            Panel1.Visible = True
        End If
        Dim g As Graphics
        g = Panel1.CreateGraphics

        g.Clear(Color.SkyBlue)

        g.DrawLine(Pens.Black, 20, 5, 20, 365)
        g.FillEllipse(Brushes.Black, 15, 5, 10, 10)
        g.FillEllipse(Brushes.SkyBlue, 18, 8, 4, 4)
        g.Dispose()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click

        ' RemontTableAdapter.Update(GidrogasitelDataSet)
        'ListBox1.Update()

        frmMenuOption.Show()
        Me.Close()
    End Sub

    Private Sub BindingSource1_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles RemontBindingSource.ListChanged
        If ListBox1.Items.Count < 19 Then
            Panel1.Visible = False
        Else
            Panel1.Visible = True
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim frm As New frmKeypad
        Dim row As GidrogasitelDataSet.RemontRow
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Dim row As GidrogasitelDataSet.RemontRow = GidrogasitelDataSet.Remont.NewRemontRow()
            'row.Remont = frm.btnResult.Text
            ' GidrogasitelDataSet.Remont.AddRemontRow(row)
            ' Dim i As Integer = ListBox1.SelectedIndex
            
            'RemontTableAdapter.Insert(s)
            'RemontTableAdapter.Update(GidrogasitelDataSet)
            ' RemontTableAdapter.Fill(GidrogasitelDataSet.Remont)

            ' If i < 0 Then i = 0
            'If i > ListBox1.Items.Count - 1 Then i = ListBox1.Items.Count - 1
            'ListBox1.SelectedIndex = i

            row = GidrogasitelDataSet.Remont.NewRemontRow
            Dim s As String = frm.btnResult.Text
            If s.Length > 10 Then s = s.Substring(0, 10)
            row.Remont = s
            GidrogasitelDataSet.Remont.AddRemontRow(row)
            RemontTableAdapter.Update(GidrogasitelDataSet.Remont)
        End If
        frm.Dispose()
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        'GidrogasitelDataSet.Remont.RemoveRemontRow(GidrogasitelDataSet.Remont.FindByID(ListBox1.Tag))
        'GidrogasitelDataSet.AcceptChanges()
        ' Dim i As Integer

        Dim r As GidrogasitelDataSet.RemontRow = GidrogasitelDataSet.Remont.FindByID(ListBox1.Tag)

        'i = ListBox1.SelectedIndex
        r.Delete()
        'RemontTableAdapter.Delete(ListBox1.Tag)
        RemontTableAdapter.Update(GidrogasitelDataSet.Remont)

        'RemontTableAdapter.Fill(GidrogasitelDataSet.Remont)
        ' If i < 0 Then i = 0

        ' If i > ListBox1.Items.Count - 1 Then i = ListBox1.Items.Count - 1
        'If i > 0 Then ListBox1.SelectedIndex = i

    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim frm As New frmKeypad
        Dim row As GidrogasitelDataSet.RemontRow = GidrogasitelDataSet.Remont.FindByID(ListBox1.Tag)
        frm.btnResult.Text = row.Remont
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim s As String = frm.btnResult.Text
            If s.Length > 10 Then s = s.Substring(0, 10)
            row.Remont = s
            RemontTableAdapter.Update(GidrogasitelDataSet.Remont)
        End If

        frm.Dispose()
    End Sub
End Class