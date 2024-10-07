<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aseObrabotka
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
        Me.btnOptim = New System.Windows.Forms.Button()
        Me.btnB = New System.Windows.Forms.Button()
        Me.btnE = New System.Windows.Forms.Button()
        Me.btnS = New System.Windows.Forms.Button()
        Me.btnG = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOptim
        '
        Me.btnOptim.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnOptim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOptim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOptim.Location = New System.Drawing.Point(80, 140)
        Me.btnOptim.Margin = New System.Windows.Forms.Padding(5)
        Me.btnOptim.Name = "btnOptim"
        Me.btnOptim.Size = New System.Drawing.Size(640, 50)
        Me.btnOptim.TabIndex = 1
        Me.btnOptim.Text = "Оптимизация амплитуды"
        Me.btnOptim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOptim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOptim.UseVisualStyleBackColor = True
        '
        'btnB
        '
        Me.btnB.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnB.Location = New System.Drawing.Point(80, 200)
        Me.btnB.Margin = New System.Windows.Forms.Padding(5)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(640, 50)
        Me.btnB.TabIndex = 2
        Me.btnB.Text = "Параметры сопротивления"
        Me.btnB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnB.UseVisualStyleBackColor = True
        '
        'btnE
        '
        Me.btnE.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnE.Location = New System.Drawing.Point(80, 260)
        Me.btnE.Margin = New System.Windows.Forms.Padding(5)
        Me.btnE.Name = "btnE"
        Me.btnE.Size = New System.Drawing.Size(640, 50)
        Me.btnE.TabIndex = 3
        Me.btnE.Text = "Энергоемкость"
        Me.btnE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnE.UseVisualStyleBackColor = True
        '
        'btnS
        '
        Me.btnS.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnS.Location = New System.Drawing.Point(80, 320)
        Me.btnS.Margin = New System.Windows.Forms.Padding(5)
        Me.btnS.Name = "btnS"
        Me.btnS.Size = New System.Drawing.Size(640, 50)
        Me.btnS.TabIndex = 4
        Me.btnS.Text = "Симметричность"
        Me.btnS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnS.UseVisualStyleBackColor = True
        '
        'btnG
        '
        Me.btnG.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnG.Location = New System.Drawing.Point(80, 380)
        Me.btnG.Margin = New System.Windows.Forms.Padding(5)
        Me.btnG.Name = "btnG"
        Me.btnG.Size = New System.Drawing.Size(640, 50)
        Me.btnG.TabIndex = 5
        Me.btnG.Text = "Анализ графика"
        Me.btnG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnG.UseVisualStyleBackColor = True
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
        Me.btnBack.Text = "Обработка результатов"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'aseObrabotka
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.btnG)
        Me.Controls.Add(Me.btnS)
        Me.Controls.Add(Me.btnE)
        Me.Controls.Add(Me.btnB)
        Me.Controls.Add(Me.btnOptim)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "aseObrabotka"
        Me.Text = "aseObrabotka"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnOptim As System.Windows.Forms.Button
    Friend WithEvents btnB As System.Windows.Forms.Button
    Friend WithEvents btnE As System.Windows.Forms.Button
    Friend WithEvents btnS As System.Windows.Forms.Button
    Friend WithEvents btnG As System.Windows.Forms.Button
End Class
