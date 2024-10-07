<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuOption
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
        Me.btnDat = New System.Windows.Forms.Button()
        Me.btnRemont = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btnOpt = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnApparatsType = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDat
        '
        Me.btnDat.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDat.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnDat.Location = New System.Drawing.Point(80, 436)
        Me.btnDat.Name = "btnDat"
        Me.btnDat.Size = New System.Drawing.Size(600, 50)
        Me.btnDat.TabIndex = 2
        Me.btnDat.Text = "Датчики"
        Me.btnDat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDat.UseVisualStyleBackColor = True
        '
        'btnRemont
        '
        Me.btnRemont.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnRemont.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemont.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnRemont.Location = New System.Drawing.Point(80, 376)
        Me.btnRemont.Name = "btnRemont"
        Me.btnRemont.Size = New System.Drawing.Size(600, 50)
        Me.btnRemont.TabIndex = 3
        Me.btnRemont.Text = "Виды ремонтов"
        Me.btnRemont.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemont.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button4.Location = New System.Drawing.Point(80, 316)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(600, 50)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Должности"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button5.Location = New System.Drawing.Point(80, 256)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(600, 50)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Сотрудники"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button6.Location = New System.Drawing.Point(80, 140)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(600, 50)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Гидрогасители"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.UseVisualStyleBackColor = True
        '
        'btnOpt
        '
        Me.btnOpt.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnOpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpt.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnOpt.Location = New System.Drawing.Point(80, 496)
        Me.btnOpt.Name = "btnOpt"
        Me.btnOpt.Size = New System.Drawing.Size(600, 50)
        Me.btnOpt.TabIndex = 7
        Me.btnOpt.Text = "Настройки стенда"
        Me.btnOpt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOpt.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 32.0!)
        Me.btnBack.Image = Global.Gidrogasitel.My.Resources.Resources.circle_back_arrow_32
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(80, 25)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(600, 75)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Настройки"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnApparatsType
        '
        Me.btnApparatsType.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnApparatsType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApparatsType.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnApparatsType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnApparatsType.Location = New System.Drawing.Point(80, 198)
        Me.btnApparatsType.Margin = New System.Windows.Forms.Padding(5)
        Me.btnApparatsType.Name = "btnApparatsType"
        Me.btnApparatsType.Size = New System.Drawing.Size(600, 50)
        Me.btnApparatsType.TabIndex = 8
        Me.btnApparatsType.Text = "Типы гидрогасителей"
        Me.btnApparatsType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnApparatsType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnApparatsType.UseVisualStyleBackColor = True
        '
        'frmMenuOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.btnApparatsType)
        Me.Controls.Add(Me.btnOpt)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnRemont)
        Me.Controls.Add(Me.btnDat)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "frmMenuOption"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnDat As System.Windows.Forms.Button
    Friend WithEvents btnRemont As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents btnOpt As System.Windows.Forms.Button
    Friend WithEvents btnApparatsType As System.Windows.Forms.Button
End Class
