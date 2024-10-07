<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAppointment
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
        Me.components = New System.ComponentModel.Container
        Me.lstAppintment = New System.Windows.Forms.ListBox
        Me.btnSelect = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.txtAppointment = New System.Windows.Forms.TextBox
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstAppintment
        '
        Me.lstAppintment.FormattingEnabled = True
        Me.lstAppintment.Location = New System.Drawing.Point(9, 11)
        Me.lstAppintment.Name = "lstAppintment"
        Me.lstAppintment.Size = New System.Drawing.Size(198, 121)
        Me.lstAppintment.TabIndex = 6
        '
        'btnSelect
        '
        Me.btnSelect.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSelect.Location = New System.Drawing.Point(111, 194)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(96, 24)
        Me.btnSelect.TabIndex = 11
        Me.btnSelect.Text = "Выбрать"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(111, 164)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(96, 24)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Удалить"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(9, 194)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(96, 24)
        Me.btnEdit.TabIndex = 10
        Me.btnEdit.Text = "Изменить"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(9, 164)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(96, 24)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Добавить"
        '
        'txtAppointment
        '
        Me.txtAppointment.Location = New System.Drawing.Point(8, 138)
        Me.txtAppointment.MaxLength = 30
        Me.txtAppointment.Name = "txtAppointment"
        Me.txtAppointment.Size = New System.Drawing.Size(199, 20)
        Me.txtAppointment.TabIndex = 7
        '
        'frmAppointment
        '
        Me.AcceptButton = Me.btnSelect
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(216, 228)
        Me.Controls.Add(Me.lstAppintment)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtAppointment)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAppointment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Должности"
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstAppintment As System.Windows.Forms.ListBox
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtAppointment As System.Windows.Forms.TextBox
    Friend WithEvents bs As System.Windows.Forms.BindingSource
End Class
