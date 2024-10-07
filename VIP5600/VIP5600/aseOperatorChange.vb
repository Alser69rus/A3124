Public Class aseOperatorChange

    Public fLast As String
    Public fFirst As String
    Public fSecond As String
    Public fAppointment As Long


    Public Sub RefreshField()
        Me.AppointmentTableAdapter.Fill(Me.GidrogasitelDataSet.Appointment)
        btnLast.Text = "Фамилия: " & fLast
        btnFirst.Text = "Имя: " & fFirst
        btnSecond.Text = "Отчество: " & fSecond
        Dim row As GidrogasitelDataSet.AppointmentRow = GidrogasitelDataSet.Appointment.FindByID(fAppointment)
        If row IsNot Nothing Then
            btnAppointment.Text = "Должность: " + row.Appointment
        End If

    End Sub



    Private Sub btnAppointment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAppointment.Click
        Dim frm As New aseAppointmentSelect
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fAppointment = frm.ListBox1.Tag
            RefreshField()
        End If
        frm.Dispose()

    End Sub


    Private Sub btnLast_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Dim frm As New frmKeypad
        frm.btnResult.Text = fLast
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fLast = frm.btnResult.Text
            RefreshField()

        End If
        frm.Dispose()

    End Sub

    Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        Dim frm As New frmKeypad
        frm.btnResult.Text = fFirst
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fFirst = frm.btnResult.Text
            RefreshField()

        End If
        frm.Dispose()

    End Sub

    Private Sub btnSecond_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSecond.Click
        Dim frm As New frmKeypad
        frm.btnResult.Text = fSecond
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fSecond = frm.btnResult.Text
            RefreshField()

        End If
        frm.Dispose()

    End Sub

    Private Sub aseOperatorChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "GidrogasitelDataSet.Appointment". При необходимости она может быть перемещена или удалена.
        Me.AppointmentTableAdapter.Fill(Me.GidrogasitelDataSet.Appointment)

    End Sub
End Class