<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRemont
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
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtRemont = New System.Windows.Forms.TextBox()
        Me.lstRemont = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnSelect
        '
        Me.btnSelect.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSelect.Location = New System.Drawing.Point(114, 194)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(96, 24)
        Me.btnSelect.TabIndex = 5
        Me.btnSelect.Text = "Выбрать"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(114, 164)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(96, 24)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Удалить"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(12, 194)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(96, 24)
        Me.btnEdit.TabIndex = 4
        Me.btnEdit.Text = "Изменить"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 164)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(96, 24)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Добавить"
        '
        'txtRemont
        '
        Me.txtRemont.Location = New System.Drawing.Point(12, 138)
        Me.txtRemont.MaxLength = 10
        Me.txtRemont.Name = "txtRemont"
        Me.txtRemont.Size = New System.Drawing.Size(199, 20)
        Me.txtRemont.TabIndex = 1
        '
        'lstRemont
        '
        Me.lstRemont.FormattingEnabled = True
        Me.lstRemont.Location = New System.Drawing.Point(12, 11)
        Me.lstRemont.Name = "lstRemont"
        Me.lstRemont.Size = New System.Drawing.Size(198, 121)
        Me.lstRemont.TabIndex = 0
        '
        'frmRemont
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(220, 225)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtRemont)
        Me.Controls.Add(Me.lstRemont)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRemont"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ремонты"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtRemont As System.Windows.Forms.TextBox
    Friend WithEvents lstRemont As System.Windows.Forms.ListBox
End Class
