Public Class aseAppointment

    Private Sub aseAppointment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "GidrogasitelDataSet.Appointment". При необходимости она может быть перемещена или удалена.
        Me.AppointmentTableAdapter.Fill(Me.GidrogasitelDataSet.Appointment)
        

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        frmMenuOption.Show()
        Me.Close()

    End Sub

    Private Sub btnPgUp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPgUp.Click
        Dim i As Integer = ListBox1.SelectedIndex
        i = i - 10
        If i < 0 Then i = 0
        If ListBox1.Items.Count > 0 Then ListBox1.SelectedIndex = i

    End Sub

    Private Sub btnPgDown_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPgDown.Click
        Dim i As Integer = ListBox1.SelectedIndex
        i = i + 10
        If i > ListBox1.Items.Count - 1 Then
            i = ListBox1.Items.Count - 1
        End If
        If ListBox1.Items.Count > 0 Then
            ListBox1.SelectedIndex = i
        End If
    End Sub

    Private Sub btnUp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUp.Click
        Dim i As Integer = ListBox1.SelectedIndex
        i = i - 1
        If i < 0 Then i = 0
        If ListBox1.Items.Count > 0 Then
            ListBox1.SelectedIndex = i
        End If
    End Sub

    Private Sub btnDown_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDown.Click
        Dim i As Integer = ListBox1.SelectedIndex
        i = i + 1
        If i > ListBox1.Items.Count - 1 Then
            i = ListBox1.Items.Count - 1
        End If
        If ListBox1.Items.Count > 0 Then
            ListBox1.SelectedIndex = i
        End If
    End Sub

    Private Sub Panel1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseClick
        Dim i As Integer = (e.Y - 5) * ListBox1.Items.Count / 360
        If i < 0 Then i = 0
        If i > ListBox1.Items.Count - 1 Then i = ListBox1.Items.Count - 1
        If ListBox1.Items.Count > 0 Then ListBox1.SelectedIndex = i

    End Sub

  

    Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        If ListBox1.Items.Count > 10 Then
            Panel1.Visible = True
            Dim g As Graphics

            g = Panel1.CreateGraphics
            g.Clear(Color.SkyBlue)
            g.DrawLine(Pens.Black, 20, 5, 20, 365)
            g.FillEllipse(Brushes.Black, 15, 5, 10, 10)
            g.FillEllipse(Brushes.SkyBlue, 18, 8, 4, 4)
            g.Dispose()
        Else
            Panel1.Visible = False

        End If
    End Sub

    Private Sub AppointmentBindingSource_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles AppointmentBindingSource.ListChanged
        If ListBox1.Items.Count > 10 Then
            Panel1.Visible = True
            Dim g As Graphics
            g = Panel1.CreateGraphics
            g.Clear(Color.SkyBlue)
            g.DrawLine(Pens.Black, 20, 5, 20, 365)
            Dim i As Single
            If ListBox1.Items.Count > 1 Then
                i = 355 * ListBox1.SelectedIndex / (ListBox1.Items.Count - 1)
            End If

            g.FillEllipse(Brushes.Black, 15, 5 + i, 10, 10)
            g.FillEllipse(Brushes.SkyBlue, 18, 8 + i, 4, 4)
            g.Dispose()
        Else
            Panel1.Visible = False
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

        Dim g As Graphics
        g = Panel1.CreateGraphics
        g.Clear(Color.SkyBlue)
        g.DrawLine(Pens.Black, 20, 5, 20, 365)
        If ListBox1.Items.Count > 1 Then
            Dim i As Single = 355 * ListBox1.SelectedIndex / (ListBox1.Items.Count - 1)
            g.FillEllipse(Brushes.Black, 15, 5 + i, 10, 10)
            g.FillEllipse(Brushes.SkyBlue, 18, 8 + i, 4, 4)
        End If
        g.Dispose()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim row As GidrogasitelDataSet.AppointmentRow = GidrogasitelDataSet.Appointment.NewAppointmentRow
        Dim frm As New frmKeypad

        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim s As String = frm.btnResult.Text
            If s.Length > 30 Then
                s = s.Substring(0, 30)
            End If
            row.Appointment = s
            GidrogasitelDataSet.Appointment.AddAppointmentRow(row)
            AppointmentTableAdapter.Update(GidrogasitelDataSet.Appointment)
        End If

        frm.Dispose()

    End Sub

    Private Sub btnDel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Dim row As GidrogasitelDataSet.AppointmentRow = GidrogasitelDataSet.Appointment.FindByID(ListBox1.Tag)
        row.Delete()
        AppointmentTableAdapter.Update(GidrogasitelDataSet.Appointment)
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim row As GidrogasitelDataSet.AppointmentRow = GidrogasitelDataSet.Appointment.FindByID(ListBox1.Tag)
        Dim frm As New frmKeypad
        frm.btnResult.Text = row.Appointment
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim s As String = frm.btnResult.Text
            If s.Length > 30 Then
                s = s.Substring(0, 30)
            End If
            row.Appointment = s
            AppointmentTableAdapter.Update(GidrogasitelDataSet.Appointment)
        End If
        frm.Dispose()

    End Sub
End Class