<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGIspitaniaData
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnEditRemont = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbTypeRemonta = New System.Windows.Forms.ComboBox
        Me.btnEditEmployee = New System.Windows.Forms.Button
        Me.cmbTypeTD = New System.Windows.Forms.ComboBox
        Me.btnOk = New System.Windows.Forms.Button
        Me.cmbOperator = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.cmbAppointment = New System.Windows.Forms.ComboBox
        Me.btnAppointment = New System.Windows.Forms.Button
        Me.btnApparatEdit = New System.Windows.Forms.Button
        Me.txtNum = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Должность"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Номер"
        '
        'btnEditRemont
        '
        Me.btnEditRemont.Location = New System.Drawing.Point(322, 112)
        Me.btnEditRemont.Name = "btnEditRemont"
        Me.btnEditRemont.Size = New System.Drawing.Size(24, 21)
        Me.btnEditRemont.TabIndex = 21
        Me.btnEditRemont.Text = "..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Вид проводимого ремонта"
        '
        'cmbTypeRemonta
        '
        Me.cmbTypeRemonta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTypeRemonta.Location = New System.Drawing.Point(200, 112)
        Me.cmbTypeRemonta.Name = "cmbTypeRemonta"
        Me.cmbTypeRemonta.Size = New System.Drawing.Size(116, 21)
        Me.cmbTypeRemonta.TabIndex = 19
        '
        'btnEditEmployee
        '
        Me.btnEditEmployee.Location = New System.Drawing.Point(322, 85)
        Me.btnEditEmployee.Name = "btnEditEmployee"
        Me.btnEditEmployee.Size = New System.Drawing.Size(24, 21)
        Me.btnEditEmployee.TabIndex = 20
        Me.btnEditEmployee.Text = "..."
        '
        'cmbTypeTD
        '
        Me.cmbTypeTD.DisplayMember = "Type"
        Me.cmbTypeTD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTypeTD.Location = New System.Drawing.Point(200, 6)
        Me.cmbTypeTD.Name = "cmbTypeTD"
        Me.cmbTypeTD.Size = New System.Drawing.Size(116, 21)
        Me.cmbTypeTD.TabIndex = 17
        Me.cmbTypeTD.ValueMember = "Type"
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.Location = New System.Drawing.Point(190, 150)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 24)
        Me.btnOk.TabIndex = 22
        Me.btnOk.Text = "Ввод"
        '
        'cmbOperator
        '
        Me.cmbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOperator.Location = New System.Drawing.Point(200, 85)
        Me.cmbOperator.Name = "cmbOperator"
        Me.cmbOperator.Size = New System.Drawing.Size(116, 21)
        Me.cmbOperator.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Испытатель"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Тип аппарата"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(271, 150)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 24)
        Me.btnCancel.TabIndex = 23
        Me.btnCancel.Text = "Отмена"
        '
        'cmbAppointment
        '
        Me.cmbAppointment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAppointment.Location = New System.Drawing.Point(200, 58)
        Me.cmbAppointment.Name = "cmbAppointment"
        Me.cmbAppointment.Size = New System.Drawing.Size(116, 21)
        Me.cmbAppointment.TabIndex = 18
        '
        'btnAppointment
        '
        Me.btnAppointment.Location = New System.Drawing.Point(322, 58)
        Me.btnAppointment.Name = "btnAppointment"
        Me.btnAppointment.Size = New System.Drawing.Size(24, 21)
        Me.btnAppointment.TabIndex = 20
        Me.btnAppointment.Text = "..."
        '
        'btnApparatEdit
        '
        Me.btnApparatEdit.Location = New System.Drawing.Point(322, 6)
        Me.btnApparatEdit.Name = "btnApparatEdit"
        Me.btnApparatEdit.Size = New System.Drawing.Size(24, 21)
        Me.btnApparatEdit.TabIndex = 20
        Me.btnApparatEdit.Text = "..."
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(200, 32)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(146, 20)
        Me.txtNum.TabIndex = 30
        '
        'frmGIspitaniaData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 181)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnEditRemont)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbTypeRemonta)
        Me.Controls.Add(Me.btnApparatEdit)
        Me.Controls.Add(Me.btnAppointment)
        Me.Controls.Add(Me.btnEditEmployee)
        Me.Controls.Add(Me.cmbTypeTD)
        Me.Controls.Add(Me.cmbAppointment)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.cmbOperator)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGIspitaniaData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Данные об испытании"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnEditRemont As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbTypeRemonta As System.Windows.Forms.ComboBox
    Friend WithEvents btnEditEmployee As System.Windows.Forms.Button
    Friend WithEvents cmbTypeTD As System.Windows.Forms.ComboBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents cmbOperator As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents cmbAppointment As System.Windows.Forms.ComboBox
    Friend WithEvents btnAppointment As System.Windows.Forms.Button
    Friend WithEvents btnApparatEdit As System.Windows.Forms.Button
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
End Class
