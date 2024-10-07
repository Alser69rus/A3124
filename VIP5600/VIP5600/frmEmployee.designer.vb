<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmbApointment = New System.Windows.Forms.ComboBox
        Me.btnApointment = New System.Windows.Forms.Button
        Me.txtClockNumberValue = New System.Windows.Forms.TextBox
        Me.txtSecondNameValue = New System.Windows.Forms.TextBox
        Me.txtFirstNameValue = New System.Windows.Forms.TextBox
        Me.txtLastNameValue = New System.Windows.Forms.TextBox
        Me.lstEmployee = New System.Windows.Forms.ListBox
        Me.btnSelect = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.lblClockNumber = New System.Windows.Forms.Label
        Me.lblAppointment = New System.Windows.Forms.Label
        Me.lblSecondName = New System.Windows.Forms.Label
        Me.lblFirstName = New System.Windows.Forms.Label
        Me.lblLastName = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'cmbApointment
        '
        Me.cmbApointment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbApointment.FormattingEnabled = True
        Me.cmbApointment.Location = New System.Drawing.Point(302, 81)
        Me.cmbApointment.Name = "cmbApointment"
        Me.cmbApointment.Size = New System.Drawing.Size(89, 21)
        Me.cmbApointment.TabIndex = 3
        Me.cmbApointment.Visible = False
        '
        'btnApointment
        '
        Me.btnApointment.Location = New System.Drawing.Point(397, 79)
        Me.btnApointment.Name = "btnApointment"
        Me.btnApointment.Size = New System.Drawing.Size(25, 23)
        Me.btnApointment.TabIndex = 5
        Me.btnApointment.Text = "..."
        Me.btnApointment.UseVisualStyleBackColor = True
        Me.btnApointment.Visible = False
        '
        'txtClockNumberValue
        '
        Me.txtClockNumberValue.Location = New System.Drawing.Point(302, 106)
        Me.txtClockNumberValue.Name = "txtClockNumberValue"
        Me.txtClockNumberValue.Size = New System.Drawing.Size(120, 20)
        Me.txtClockNumberValue.TabIndex = 4
        Me.txtClockNumberValue.Visible = False
        '
        'txtSecondNameValue
        '
        Me.txtSecondNameValue.Location = New System.Drawing.Point(302, 58)
        Me.txtSecondNameValue.MaxLength = 20
        Me.txtSecondNameValue.Name = "txtSecondNameValue"
        Me.txtSecondNameValue.Size = New System.Drawing.Size(120, 20)
        Me.txtSecondNameValue.TabIndex = 2
        '
        'txtFirstNameValue
        '
        Me.txtFirstNameValue.Location = New System.Drawing.Point(302, 34)
        Me.txtFirstNameValue.MaxLength = 20
        Me.txtFirstNameValue.Name = "txtFirstNameValue"
        Me.txtFirstNameValue.Size = New System.Drawing.Size(120, 20)
        Me.txtFirstNameValue.TabIndex = 1
        '
        'txtLastNameValue
        '
        Me.txtLastNameValue.Location = New System.Drawing.Point(302, 10)
        Me.txtLastNameValue.MaxLength = 10
        Me.txtLastNameValue.Name = "txtLastNameValue"
        Me.txtLastNameValue.Size = New System.Drawing.Size(120, 20)
        Me.txtLastNameValue.TabIndex = 0
        '
        'lstEmployee
        '
        Me.lstEmployee.DisplayMember = "AppointmentID"
        Me.lstEmployee.Location = New System.Drawing.Point(8, 5)
        Me.lstEmployee.Name = "lstEmployee"
        Me.lstEmployee.Size = New System.Drawing.Size(176, 121)
        Me.lstEmployee.TabIndex = 10
        Me.lstEmployee.ValueMember = "AppointmentID"
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(320, 141)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(96, 24)
        Me.btnSelect.TabIndex = 9
        Me.btnSelect.Text = "Выбрать"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(216, 141)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(96, 24)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Удалить"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(112, 141)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(96, 24)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.Text = "Изменить"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(8, 141)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(96, 24)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Добавить"
        '
        'lblClockNumber
        '
        Me.lblClockNumber.Location = New System.Drawing.Point(192, 109)
        Me.lblClockNumber.Name = "lblClockNumber"
        Me.lblClockNumber.Size = New System.Drawing.Size(104, 23)
        Me.lblClockNumber.TabIndex = 15
        Me.lblClockNumber.Text = "Табельный номер"
        Me.lblClockNumber.Visible = False
        '
        'lblAppointment
        '
        Me.lblAppointment.Location = New System.Drawing.Point(192, 85)
        Me.lblAppointment.Name = "lblAppointment"
        Me.lblAppointment.Size = New System.Drawing.Size(104, 23)
        Me.lblAppointment.TabIndex = 14
        Me.lblAppointment.Text = "Должность"
        Me.lblAppointment.Visible = False
        '
        'lblSecondName
        '
        Me.lblSecondName.Location = New System.Drawing.Point(192, 61)
        Me.lblSecondName.Name = "lblSecondName"
        Me.lblSecondName.Size = New System.Drawing.Size(104, 23)
        Me.lblSecondName.TabIndex = 13
        Me.lblSecondName.Text = "Отчество"
        '
        'lblFirstName
        '
        Me.lblFirstName.Location = New System.Drawing.Point(192, 37)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(104, 23)
        Me.lblFirstName.TabIndex = 12
        Me.lblFirstName.Text = "Имя"
        '
        'lblLastName
        '
        Me.lblLastName.Location = New System.Drawing.Point(192, 13)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(104, 23)
        Me.lblLastName.TabIndex = 11
        Me.lblLastName.Text = "Фамилия"
        '
        'frmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 171)
        Me.Controls.Add(Me.cmbApointment)
        Me.Controls.Add(Me.btnApointment)
        Me.Controls.Add(Me.txtClockNumberValue)
        Me.Controls.Add(Me.txtSecondNameValue)
        Me.Controls.Add(Me.txtFirstNameValue)
        Me.Controls.Add(Me.txtLastNameValue)
        Me.Controls.Add(Me.lstEmployee)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblClockNumber)
        Me.Controls.Add(Me.lblAppointment)
        Me.Controls.Add(Me.lblSecondName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblLastName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Данные о сотрудниках"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbApointment As System.Windows.Forms.ComboBox
    Friend WithEvents btnApointment As System.Windows.Forms.Button
    Friend WithEvents txtClockNumberValue As System.Windows.Forms.TextBox
    Friend WithEvents txtSecondNameValue As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstNameValue As System.Windows.Forms.TextBox
    Friend WithEvents txtLastNameValue As System.Windows.Forms.TextBox
    Friend WithEvents lstEmployee As System.Windows.Forms.ListBox
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lblClockNumber As System.Windows.Forms.Label
    Friend WithEvents lblAppointment As System.Windows.Forms.Label
    Friend WithEvents lblSecondName As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
End Class
