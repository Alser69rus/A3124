<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnOption = New System.Windows.Forms.Button()
        Me.btnManual = New System.Windows.Forms.Button()
        Me.btnProtokol = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 32.0!)
        Me.Label1.Location = New System.Drawing.Point(80, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 59)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Главное меню"
        '
        'btnOption
        '
        Me.btnOption.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOption.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnOption.Image = Global.Gidrogasitel.My.Resources.Resources.internt_web_technology_12_24
        Me.btnOption.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOption.Location = New System.Drawing.Point(80, 320)
        Me.btnOption.Name = "btnOption"
        Me.btnOption.Size = New System.Drawing.Size(600, 50)
        Me.btnOption.TabIndex = 4
        Me.btnOption.Text = "Настройки"
        Me.btnOption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOption.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOption.UseVisualStyleBackColor = True
        '
        'btnManual
        '
        Me.btnManual.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManual.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnManual.Image = Global.Gidrogasitel.My.Resources.Resources.icon_3_high_five_24
        Me.btnManual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnManual.Location = New System.Drawing.Point(80, 260)
        Me.btnManual.Name = "btnManual"
        Me.btnManual.Size = New System.Drawing.Size(600, 50)
        Me.btnManual.TabIndex = 3
        Me.btnManual.Text = "Ручное управление"
        Me.btnManual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnManual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnManual.UseVisualStyleBackColor = True
        '
        'btnProtokol
        '
        Me.btnProtokol.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnProtokol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProtokol.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnProtokol.Image = Global.Gidrogasitel.My.Resources.Resources.copy_24
        Me.btnProtokol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProtokol.Location = New System.Drawing.Point(80, 200)
        Me.btnProtokol.Name = "btnProtokol"
        Me.btnProtokol.Size = New System.Drawing.Size(600, 50)
        Me.btnProtokol.TabIndex = 2
        Me.btnProtokol.Text = "Протоколы испытаний"
        Me.btnProtokol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProtokol.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProtokol.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnNew.Image = Global.Gidrogasitel.My.Resources.Resources.Pressure_Reading_24
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.Location = New System.Drawing.Point(80, 140)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(600, 50)
        Me.btnNew.TabIndex = 1
        Me.btnNew.Text = "Начать новое испытание"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.DarkRed
        Me.btnExit.Image = Global.Gidrogasitel.My.Resources.Resources.quit
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(80, 380)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(600, 50)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Завершить работу"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOption)
        Me.Controls.Add(Me.btnManual)
        Me.Controls.Add(Me.btnProtokol)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmMainMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnProtokol As System.Windows.Forms.Button
    Friend WithEvents btnManual As System.Windows.Forms.Button
    Friend WithEvents btnOption As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
