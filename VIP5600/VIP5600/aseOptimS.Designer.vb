<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aseOptimS
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
        Me.btnS1 = New System.Windows.Forms.Button()
        Me.btnS2 = New System.Windows.Forms.Button()
        Me.btnS3 = New System.Windows.Forms.Button()
        Me.btnS4 = New System.Windows.Forms.Button()
        Me.btnReg1 = New System.Windows.Forms.Button()
        Me.btnReg2 = New System.Windows.Forms.Button()
        Me.btnReg3 = New System.Windows.Forms.Button()
        Me.btnReg4 = New System.Windows.Forms.Button()
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
        Me.btnBack.Text = "Симметричность"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnS1
        '
        Me.btnS1.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnS1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnS1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnS1.Location = New System.Drawing.Point(80, 140)
        Me.btnS1.Margin = New System.Windows.Forms.Padding(5)
        Me.btnS1.Name = "btnS1"
        Me.btnS1.Size = New System.Drawing.Size(300, 50)
        Me.btnS1.TabIndex = 1
        Me.btnS1.Text = "S1=25%"
        Me.btnS1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnS1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnS1.UseVisualStyleBackColor = True
        '
        'btnS2
        '
        Me.btnS2.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnS2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnS2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnS2.Location = New System.Drawing.Point(80, 200)
        Me.btnS2.Margin = New System.Windows.Forms.Padding(5)
        Me.btnS2.Name = "btnS2"
        Me.btnS2.Size = New System.Drawing.Size(300, 50)
        Me.btnS2.TabIndex = 2
        Me.btnS2.Text = "S2=25%"
        Me.btnS2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnS2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnS2.UseVisualStyleBackColor = True
        '
        'btnS3
        '
        Me.btnS3.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnS3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnS3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnS3.Location = New System.Drawing.Point(80, 260)
        Me.btnS3.Margin = New System.Windows.Forms.Padding(5)
        Me.btnS3.Name = "btnS3"
        Me.btnS3.Size = New System.Drawing.Size(300, 50)
        Me.btnS3.TabIndex = 3
        Me.btnS3.Text = "S3=25%"
        Me.btnS3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnS3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnS3.UseVisualStyleBackColor = True
        '
        'btnS4
        '
        Me.btnS4.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnS4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnS4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnS4.Location = New System.Drawing.Point(80, 320)
        Me.btnS4.Margin = New System.Windows.Forms.Padding(5)
        Me.btnS4.Name = "btnS4"
        Me.btnS4.Size = New System.Drawing.Size(300, 50)
        Me.btnS4.TabIndex = 4
        Me.btnS4.Text = "S4=25%"
        Me.btnS4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnS4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnS4.UseVisualStyleBackColor = True
        '
        'btnReg1
        '
        Me.btnReg1.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnReg1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReg1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReg1.Location = New System.Drawing.Point(390, 140)
        Me.btnReg1.Margin = New System.Windows.Forms.Padding(5)
        Me.btnReg1.Name = "btnReg1"
        Me.btnReg1.Size = New System.Drawing.Size(300, 50)
        Me.btnReg1.TabIndex = 5
        Me.btnReg1.Text = "Не учитывать"
        Me.btnReg1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReg1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReg1.UseVisualStyleBackColor = True
        '
        'btnReg2
        '
        Me.btnReg2.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnReg2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReg2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReg2.Location = New System.Drawing.Point(390, 200)
        Me.btnReg2.Margin = New System.Windows.Forms.Padding(5)
        Me.btnReg2.Name = "btnReg2"
        Me.btnReg2.Size = New System.Drawing.Size(300, 50)
        Me.btnReg2.TabIndex = 6
        Me.btnReg2.Text = "Не учитывать"
        Me.btnReg2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReg2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReg2.UseVisualStyleBackColor = True
        '
        'btnReg3
        '
        Me.btnReg3.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnReg3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReg3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReg3.Location = New System.Drawing.Point(390, 260)
        Me.btnReg3.Margin = New System.Windows.Forms.Padding(5)
        Me.btnReg3.Name = "btnReg3"
        Me.btnReg3.Size = New System.Drawing.Size(300, 50)
        Me.btnReg3.TabIndex = 7
        Me.btnReg3.Text = "Не учитывать"
        Me.btnReg3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReg3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReg3.UseVisualStyleBackColor = True
        '
        'btnReg4
        '
        Me.btnReg4.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnReg4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReg4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReg4.Location = New System.Drawing.Point(390, 320)
        Me.btnReg4.Margin = New System.Windows.Forms.Padding(5)
        Me.btnReg4.Name = "btnReg4"
        Me.btnReg4.Size = New System.Drawing.Size(300, 50)
        Me.btnReg4.TabIndex = 8
        Me.btnReg4.Text = "Не учитывать"
        Me.btnReg4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReg4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReg4.UseVisualStyleBackColor = True
        '
        'aseOptimS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.btnReg4)
        Me.Controls.Add(Me.btnReg3)
        Me.Controls.Add(Me.btnReg2)
        Me.Controls.Add(Me.btnReg1)
        Me.Controls.Add(Me.btnS4)
        Me.Controls.Add(Me.btnS3)
        Me.Controls.Add(Me.btnS2)
        Me.Controls.Add(Me.btnS1)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "aseOptimS"
        Me.Text = "aseOptimS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnS1 As System.Windows.Forms.Button
    Friend WithEvents btnS2 As System.Windows.Forms.Button
    Friend WithEvents btnS3 As System.Windows.Forms.Button
    Friend WithEvents btnS4 As System.Windows.Forms.Button
    Friend WithEvents btnReg1 As System.Windows.Forms.Button
    Friend WithEvents btnReg2 As System.Windows.Forms.Button
    Friend WithEvents btnReg3 As System.Windows.Forms.Button
    Friend WithEvents btnReg4 As System.Windows.Forms.Button
End Class
