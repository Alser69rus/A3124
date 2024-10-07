Public Class frmEmployee

    Dim ds As GidrogasitelDataSet

    Public Sub New(ByVal dataset As GidrogasitelDataSet)
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call

        ds = dataset

        Me.lstEmployee.DataSource = ds.Operators
        Me.lstEmployee.DisplayMember = "Last"
        Me.lstEmployee.DataBindings.Add("Tag", ds.Operators, "ID")

        'Me.txtLastNameValue.DataBindings.Add("Tag", ds.Operators, "AppointmentID")
        Me.txtLastNameValue.DataBindings.Add("Text", ds.Operators, "Last")
        Me.txtFirstNameValue.DataBindings.Add("Text", ds.Operators, "First")
        Me.txtSecondNameValue.DataBindings.Add("Text", ds.Operators, "Second")

        'Me.cmbApointment.DataSource = ds.Должности
        'Me.cmbApointment.ValueMember = "Appointment"
        'Me.cmbApointment.DataBindings.Add("Tag", ds.Должности, "CODE")
    End Sub


    Private Sub txtLastNameValue_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLastNameValue.TextChanged
        'If Me.txtLastNameValue.Tag IsNot Nothing Then
        '    Me.cmbApointment.Text = ds.Должности.FindByCODE(Me.txtLastNameValue.Tag).Appointment
        'End If

    End Sub

    Private Sub btnApointment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApointment.Click
        'Dim frmA As New frmAppointment(Me.ds)
        'If frmA.ShowDialog() = Windows.Forms.DialogResult.OK Then Me.cmbApointment.Text = frmA.Appointment
        'frmA = Nothing
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'Dim rowAppointment As DataSet1.ДолжностиRow = ds.Должности.FindByCODE(Me.cmbApointment.Tag)
        ds.Operators.AddOperatorsRow("<Имя>", "<Отчество>", "<Фамилия>", ds.Appointment.Item(0))
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim row As GidrogasitelDataSet.OperatorsRow = ds.Operators.FindByID(Me.lstEmployee.Tag)
        Me.ds.Operators.RemoveOperatorsRow(row)
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Me.txtLastNameValue.Tag = Me.cmbApointment.Tag
    End Sub

    Public LastName As String

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim row As GidrogasitelDataSet.OperatorsRow = ds.Operators.FindByID(Me.lstEmployee.Tag)
        LastName = row.Last
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

End Class