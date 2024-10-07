<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class asePreparation
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
        Me.btnAngle = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnAmpl = New System.Windows.Forms.Button()
        Me.btnV = New System.Windows.Forms.Button()
        Me.btnT = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.OK
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
        Me.btnBack.Text = "Подготовка к испытанию"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnAngle
        '
        Me.btnAngle.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnAngle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAngle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAngle.Location = New System.Drawing.Point(80, 140)
        Me.btnAngle.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAngle.Name = "btnAngle"
        Me.btnAngle.Size = New System.Drawing.Size(600, 50)
        Me.btnAngle.TabIndex = 1
        Me.btnAngle.Text = "Угол наклона 0"
        Me.btnAngle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAngle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAngle.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCheck.Location = New System.Drawing.Point(80, 200)
        Me.btnCheck.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(600, 50)
        Me.btnCheck.TabIndex = 2
        Me.btnCheck.Text = "Прокачку выполнять"
        Me.btnCheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'btnAmpl
        '
        Me.btnAmpl.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnAmpl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAmpl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAmpl.Location = New System.Drawing.Point(80, 320)
        Me.btnAmpl.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAmpl.Name = "btnAmpl"
        Me.btnAmpl.Size = New System.Drawing.Size(600, 50)
        Me.btnAmpl.TabIndex = 3
        Me.btnAmpl.Text = "Ход гасителя 40 мм"
        Me.btnAmpl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAmpl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAmpl.UseVisualStyleBackColor = True
        '
        'btnV
        '
        Me.btnV.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnV.Location = New System.Drawing.Point(80, 260)
        Me.btnV.Margin = New System.Windows.Forms.Padding(5)
        Me.btnV.Name = "btnV"
        Me.btnV.Size = New System.Drawing.Size(600, 50)
        Me.btnV.TabIndex = 4
        Me.btnV.Text = "Скорость 0,3 м/с"
        Me.btnV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnV.UseVisualStyleBackColor = True
        '
        'btnT
        '
        Me.btnT.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnT.Location = New System.Drawing.Point(80, 380)
        Me.btnT.Margin = New System.Windows.Forms.Padding(5)
        Me.btnT.Name = "btnT"
        Me.btnT.Size = New System.Drawing.Size(600, 50)
        Me.btnT.TabIndex = 5
        Me.btnT.Text = "Не дольше 300 с"
        Me.btnT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnT.UseVisualStyleBackColor = True
        '
        'asePreparation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.btnT)
        Me.Controls.Add(Me.btnV)
        Me.Controls.Add(Me.btnAmpl)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.btnAngle)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "asePreparation"
        Me.Text = "asePreparation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnAngle As System.Windows.Forms.Button
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents btnAmpl As System.Windows.Forms.Button
    Friend WithEvents btnV As System.Windows.Forms.Button
    Friend WithEvents btnT As System.Windows.Forms.Button
End Class
