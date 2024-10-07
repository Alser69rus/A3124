<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aseProverka
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
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnSpeed = New System.Windows.Forms.Button()
        Me.btnAmpl = New System.Windows.Forms.Button()
        Me.btnFs = New System.Windows.Forms.Button()
        Me.btnDFs = New System.Windows.Forms.Button()
        Me.btnFr = New System.Windows.Forms.Button()
        Me.btnDFr = New System.Windows.Forms.Button()
        Me.btnE = New System.Windows.Forms.Button()
        Me.btnDE = New System.Windows.Forms.Button()
        Me.btnT = New System.Windows.Forms.Button()
        Me.btnReg = New System.Windows.Forms.Button()
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
        Me.btnBack.Size = New System.Drawing.Size(640, 75)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Контрольная скорость № 1"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCheck.Location = New System.Drawing.Point(80, 140)
        Me.btnCheck.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(640, 50)
        Me.btnCheck.TabIndex = 1
        Me.btnCheck.Text = "Выполнять проверку "
        Me.btnCheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'btnSpeed
        '
        Me.btnSpeed.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSpeed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSpeed.Location = New System.Drawing.Point(80, 200)
        Me.btnSpeed.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSpeed.Name = "btnSpeed"
        Me.btnSpeed.Size = New System.Drawing.Size(300, 50)
        Me.btnSpeed.TabIndex = 2
        Me.btnSpeed.Text = "Скорость 0,02 м/с"
        Me.btnSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSpeed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSpeed.UseVisualStyleBackColor = True
        '
        'btnAmpl
        '
        Me.btnAmpl.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnAmpl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAmpl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAmpl.Location = New System.Drawing.Point(390, 200)
        Me.btnAmpl.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAmpl.Name = "btnAmpl"
        Me.btnAmpl.Size = New System.Drawing.Size(300, 50)
        Me.btnAmpl.TabIndex = 3
        Me.btnAmpl.Text = "Ход 40 мм"
        Me.btnAmpl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAmpl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAmpl.UseVisualStyleBackColor = True
        '
        'btnFs
        '
        Me.btnFs.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnFs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFs.Location = New System.Drawing.Point(80, 320)
        Me.btnFs.Margin = New System.Windows.Forms.Padding(5)
        Me.btnFs.Name = "btnFs"
        Me.btnFs.Size = New System.Drawing.Size(400, 50)
        Me.btnFs.TabIndex = 4
        Me.btnFs.Text = "Усилие сжатия                  20,0"
        Me.btnFs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFs.UseVisualStyleBackColor = True
        '
        'btnDFs
        '
        Me.btnDFs.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnDFs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDFs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDFs.Location = New System.Drawing.Point(470, 320)
        Me.btnDFs.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDFs.Name = "btnDFs"
        Me.btnDFs.Size = New System.Drawing.Size(220, 50)
        Me.btnDFs.TabIndex = 5
        Me.btnDFs.Text = "±0,360 кН"
        Me.btnDFs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDFs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDFs.UseVisualStyleBackColor = True
        '
        'btnFr
        '
        Me.btnFr.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnFr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFr.Location = New System.Drawing.Point(80, 260)
        Me.btnFr.Margin = New System.Windows.Forms.Padding(5)
        Me.btnFr.Name = "btnFr"
        Me.btnFr.Size = New System.Drawing.Size(400, 50)
        Me.btnFr.TabIndex = 6
        Me.btnFr.Text = "Усилие растяжения         20,0"
        Me.btnFr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFr.UseVisualStyleBackColor = True
        '
        'btnDFr
        '
        Me.btnDFr.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnDFr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDFr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDFr.Location = New System.Drawing.Point(470, 260)
        Me.btnDFr.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDFr.Name = "btnDFr"
        Me.btnDFr.Size = New System.Drawing.Size(220, 50)
        Me.btnDFr.TabIndex = 7
        Me.btnDFr.Text = "±0,360 кН"
        Me.btnDFr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDFr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDFr.UseVisualStyleBackColor = True
        '
        'btnE
        '
        Me.btnE.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnE.Location = New System.Drawing.Point(80, 380)
        Me.btnE.Margin = New System.Windows.Forms.Padding(5)
        Me.btnE.Name = "btnE"
        Me.btnE.Size = New System.Drawing.Size(400, 50)
        Me.btnE.TabIndex = 8
        Me.btnE.Text = "Энергоемкость                 1450"
        Me.btnE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnE.UseVisualStyleBackColor = True
        '
        'btnDE
        '
        Me.btnDE.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnDE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDE.Location = New System.Drawing.Point(470, 380)
        Me.btnDE.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDE.Name = "btnDE"
        Me.btnDE.Size = New System.Drawing.Size(220, 50)
        Me.btnDE.TabIndex = 9
        Me.btnDE.Text = "±360 Дж"
        Me.btnDE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDE.UseVisualStyleBackColor = True
        '
        'btnT
        '
        Me.btnT.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnT.Location = New System.Drawing.Point(80, 440)
        Me.btnT.Margin = New System.Windows.Forms.Padding(5)
        Me.btnT.Name = "btnT"
        Me.btnT.Size = New System.Drawing.Size(300, 50)
        Me.btnT.TabIndex = 10
        Me.btnT.Text = "Длительность 300 с"
        Me.btnT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnT.UseVisualStyleBackColor = True
        '
        'btnReg
        '
        Me.btnReg.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReg.Location = New System.Drawing.Point(390, 440)
        Me.btnReg.Margin = New System.Windows.Forms.Padding(5)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(320, 50)
        Me.btnReg.TabIndex = 11
        Me.btnReg.Text = "Клапанный режим"
        Me.btnReg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReg.UseVisualStyleBackColor = True
        '
        'aseProverka
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.btnReg)
        Me.Controls.Add(Me.btnT)
        Me.Controls.Add(Me.btnDE)
        Me.Controls.Add(Me.btnE)
        Me.Controls.Add(Me.btnDFr)
        Me.Controls.Add(Me.btnFr)
        Me.Controls.Add(Me.btnDFs)
        Me.Controls.Add(Me.btnFs)
        Me.Controls.Add(Me.btnAmpl)
        Me.Controls.Add(Me.btnSpeed)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "aseProverka"
        Me.Text = "aseProverka"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents btnSpeed As System.Windows.Forms.Button
    Friend WithEvents btnAmpl As System.Windows.Forms.Button
    Friend WithEvents btnFs As System.Windows.Forms.Button
    Friend WithEvents btnDFs As System.Windows.Forms.Button
    Friend WithEvents btnFr As System.Windows.Forms.Button
    Friend WithEvents btnDFr As System.Windows.Forms.Button
    Friend WithEvents btnE As System.Windows.Forms.Button
    Friend WithEvents btnDE As System.Windows.Forms.Button
    Friend WithEvents btnT As System.Windows.Forms.Button
    Friend WithEvents btnReg As System.Windows.Forms.Button
End Class
