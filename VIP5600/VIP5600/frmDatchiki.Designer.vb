<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatchiki
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
        Me.btnTs = New System.Windows.Forms.Button()
        Me.btnTg = New System.Windows.Forms.Button()
        Me.btnAngle = New System.Windows.Forms.Button()
        Me.btnAmpl = New System.Windows.Forms.Button()
        Me.btnMotor = New System.Windows.Forms.Button()
        Me.btnTenzo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnBack.Image = Global.Gidrogasitel.My.Resources.Resources.circle_back_arrow_32
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(80, 25)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(600, 75)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Настройки датчиков"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnTs
        '
        Me.btnTs.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnTs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTs.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnTs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTs.Location = New System.Drawing.Point(80, 140)
        Me.btnTs.Name = "btnTs"
        Me.btnTs.Size = New System.Drawing.Size(600, 50)
        Me.btnTs.TabIndex = 1
        Me.btnTs.Text = "Температура воздуха"
        Me.btnTs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTs.UseVisualStyleBackColor = True
        '
        'btnTg
        '
        Me.btnTg.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnTg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTg.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnTg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTg.Location = New System.Drawing.Point(80, 200)
        Me.btnTg.Name = "btnTg"
        Me.btnTg.Size = New System.Drawing.Size(600, 50)
        Me.btnTg.TabIndex = 2
        Me.btnTg.Text = "Температура гасителя"
        Me.btnTg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTg.UseVisualStyleBackColor = True
        '
        'btnAngle
        '
        Me.btnAngle.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnAngle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAngle.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnAngle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAngle.Location = New System.Drawing.Point(80, 260)
        Me.btnAngle.Name = "btnAngle"
        Me.btnAngle.Size = New System.Drawing.Size(600, 50)
        Me.btnAngle.TabIndex = 3
        Me.btnAngle.Text = "Угол наклона"
        Me.btnAngle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAngle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAngle.UseVisualStyleBackColor = True
        '
        'btnAmpl
        '
        Me.btnAmpl.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnAmpl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAmpl.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnAmpl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAmpl.Location = New System.Drawing.Point(80, 320)
        Me.btnAmpl.Name = "btnAmpl"
        Me.btnAmpl.Size = New System.Drawing.Size(600, 50)
        Me.btnAmpl.TabIndex = 4
        Me.btnAmpl.Text = "Амплитуда"
        Me.btnAmpl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAmpl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAmpl.UseVisualStyleBackColor = True
        '
        'btnMotor
        '
        Me.btnMotor.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnMotor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMotor.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnMotor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMotor.Location = New System.Drawing.Point(80, 380)
        Me.btnMotor.Name = "btnMotor"
        Me.btnMotor.Size = New System.Drawing.Size(600, 50)
        Me.btnMotor.TabIndex = 5
        Me.btnMotor.Text = "Двигатель"
        Me.btnMotor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMotor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMotor.UseVisualStyleBackColor = True
        '
        'btnTenzo
        '
        Me.btnTenzo.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnTenzo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTenzo.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnTenzo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTenzo.Location = New System.Drawing.Point(80, 440)
        Me.btnTenzo.Name = "btnTenzo"
        Me.btnTenzo.Size = New System.Drawing.Size(600, 50)
        Me.btnTenzo.TabIndex = 6
        Me.btnTenzo.Text = "Тензодатчик"
        Me.btnTenzo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTenzo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTenzo.UseVisualStyleBackColor = True
        '
        'frmDatchiki
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.btnTenzo)
        Me.Controls.Add(Me.btnMotor)
        Me.Controls.Add(Me.btnAmpl)
        Me.Controls.Add(Me.btnAngle)
        Me.Controls.Add(Me.btnTg)
        Me.Controls.Add(Me.btnTs)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "frmDatchiki"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnTs As System.Windows.Forms.Button
    Friend WithEvents btnTg As System.Windows.Forms.Button
    Friend WithEvents btnAngle As System.Windows.Forms.Button
    Friend WithEvents btnAmpl As System.Windows.Forms.Button
    Friend WithEvents btnMotor As System.Windows.Forms.Button
    Friend WithEvents btnTenzo As System.Windows.Forms.Button
End Class
