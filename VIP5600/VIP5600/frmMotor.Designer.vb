<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMotor
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnN = New System.Windows.Forms.Button()
        Me.btnK = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 32.0!)
        Me.btnBack.Image = Global.Gidrogasitel.My.Resources.Resources.circle_back_arrow_32
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(80, 25)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(5)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(600, 75)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Параметры двигателя"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnN
        '
        Me.btnN.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnN.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnN.Location = New System.Drawing.Point(80, 140)
        Me.btnN.Margin = New System.Windows.Forms.Padding(5)
        Me.btnN.Name = "btnN"
        Me.btnN.Size = New System.Drawing.Size(600, 50)
        Me.btnN.TabIndex = 1
        Me.btnN.Text = "Частота вращения"
        Me.btnN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnN.UseVisualStyleBackColor = True
        '
        'btnK
        '
        Me.btnK.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnK.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnK.Location = New System.Drawing.Point(80, 200)
        Me.btnK.Margin = New System.Windows.Forms.Padding(5)
        Me.btnK.Name = "btnK"
        Me.btnK.Size = New System.Drawing.Size(600, 50)
        Me.btnK.TabIndex = 2
        Me.btnK.Text = "Коэффициент редуктора"
        Me.btnK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnK.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnOk.Image = Global.Gidrogasitel.My.Resources.Resources.Ok
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(80, 500)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(5)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(200, 75)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "Да"
        Me.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnCancel.Image = Global.Gidrogasitel.My.Resources.Resources.button_cancel
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(450, 500)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(200, 75)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Нет"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmMotor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnK)
        Me.Controls.Add(Me.btnN)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "frmMotor"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnN As System.Windows.Forms.Button
    Friend WithEvents btnK As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
