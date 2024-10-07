<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAmpl
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
        Me.btnL = New System.Windows.Forms.Button()
        Me.btnU = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.btnMax = New System.Windows.Forms.Button()
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
        Me.btnBack.Text = "Датчик перемещения"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnL
        '
        Me.btnL.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnL.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnL.Location = New System.Drawing.Point(80, 140)
        Me.btnL.Margin = New System.Windows.Forms.Padding(5)
        Me.btnL.Name = "btnL"
        Me.btnL.Size = New System.Drawing.Size(300, 50)
        Me.btnL.TabIndex = 1
        Me.btnL.Text = "ΔL="
        Me.btnL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnL.UseVisualStyleBackColor = True
        '
        'btnU
        '
        Me.btnU.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnU.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnU.Location = New System.Drawing.Point(80, 200)
        Me.btnU.Margin = New System.Windows.Forms.Padding(5)
        Me.btnU.Name = "btnU"
        Me.btnU.Size = New System.Drawing.Size(300, 50)
        Me.btnU.TabIndex = 2
        Me.btnU.Text = "ΔU="
        Me.btnU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnU.UseVisualStyleBackColor = True
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
        'btnMin
        '
        Me.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnMin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMin.Location = New System.Drawing.Point(80, 260)
        Me.btnMin.Margin = New System.Windows.Forms.Padding(5)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(600, 50)
        Me.btnMin.TabIndex = 5
        Me.btnMin.Text = "Минимальный ход 20 мм"
        Me.btnMin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMin.UseVisualStyleBackColor = True
        '
        'btnMax
        '
        Me.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMax.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnMax.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMax.Location = New System.Drawing.Point(80, 320)
        Me.btnMax.Margin = New System.Windows.Forms.Padding(5)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(600, 50)
        Me.btnMax.TabIndex = 6
        Me.btnMax.Text = "Максимальный ход 40 мм"
        Me.btnMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMax.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMax.UseVisualStyleBackColor = True
        '
        'frmAmpl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.btnMax)
        Me.Controls.Add(Me.btnMin)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnU)
        Me.Controls.Add(Me.btnL)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "frmAmpl"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnL As System.Windows.Forms.Button
    Friend WithEvents btnU As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnMin As System.Windows.Forms.Button
    Friend WithEvents btnMax As System.Windows.Forms.Button
End Class
