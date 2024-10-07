Public Class frmAppointment
    Dim ds As GidrogasitelDataSet
    Public Sub New(ByVal DataSet As GidrogasitelDataSet)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ds = DataSet

        bs.DataSource = ds
        bs.DataMember = "Appointment"

        With Me.lstAppintment
            .DataSource = bs
            .DisplayMember = "Appointment"
        End With

        Me.txtAppointment.DataBindings.Add("Text", bs, "Appointment")
        Me.txtAppointment.DataBindings.Add("Tag", bs, "ID")

        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim row As GidrogasitelDataSet.AppointmentRow = ds.Appointment.NewAppointmentRow
        ds.Appointment.AddAppointmentRow("<Новая должность>")
        
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        'Dim row As GidrogasitelDataSet.AppointmentRow = ds.Appointment.FindByID(Me.txtAppointment.Tag)
        'Me.ds.Appointment.RemoveAppointmentRow(row)

        If bs.Count > 1 Then
            bs.RemoveCurrent()
            bs.MoveLast()
        Else
            MessageBox.Show("Последняя запись не может быть удалена!", My.Application.Info.Title, _
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        'Dim row As GidrogasitelDataSet.AppointmentRow = ds.Appointment.FindByID(Me.txtAppointment.Tag)
        'row.Appointment = Me.txtAppointment.Text

        bs.ResetBindings(False)
    End Sub

    Public Appointment As String

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim row As GidrogasitelDataSet.AppointmentRow = ds.Appointment.FindByID(Me.txtAppointment.Tag)
        Appointment = row.Appointment
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub


    Private Sub frmAppointment_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.DialogResult = Windows.Forms.DialogResult.OK Then
            bs.EndEdit()
        Else
            bs.CancelEdit()
            bs.ResetBindings(False)
        End If
    End Sub

 
End Class