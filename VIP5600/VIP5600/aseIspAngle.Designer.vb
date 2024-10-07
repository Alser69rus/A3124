<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aseIspAngle
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aseIspAngle))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.pbAngle = New System.Windows.Forms.ProgressBar()
        Me.pbV = New System.Windows.Forms.ProgressBar()
        Me.pbT = New System.Windows.Forms.ProgressBar()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnTemp = New System.Windows.Forms.Button()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnT = New System.Windows.Forms.Button()
        Me.btnV = New System.Windows.Forms.Button()
        Me.btnAngle = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "empty.png")
        Me.ImageList1.Images.SetKeyName(1, "Forward.png")
        Me.ImageList1.Images.SetKeyName(2, "Ok.png")
        Me.ImageList1.Images.SetKeyName(3, "button_cancel.png")
        '
        'pbAngle
        '
        Me.pbAngle.Location = New System.Drawing.Point(630, 213)
        Me.pbAngle.Margin = New System.Windows.Forms.Padding(5, 18, 5, 18)
        Me.pbAngle.Name = "pbAngle"
        Me.pbAngle.Size = New System.Drawing.Size(100, 24)
        Me.pbAngle.TabIndex = 4
        '
        'pbV
        '
        Me.pbV.Location = New System.Drawing.Point(630, 273)
        Me.pbV.Margin = New System.Windows.Forms.Padding(5, 18, 5, 18)
        Me.pbV.Name = "pbV"
        Me.pbV.Size = New System.Drawing.Size(100, 24)
        Me.pbV.TabIndex = 5
        '
        'pbT
        '
        Me.pbT.Location = New System.Drawing.Point(630, 333)
        Me.pbT.Margin = New System.Windows.Forms.Padding(5, 18, 5, 18)
        Me.pbT.Name = "pbT"
        Me.pbT.Size = New System.Drawing.Size(100, 24)
        Me.pbT.TabIndex = 6
        '
        'btnStop
        '
        Me.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStop.Font = New System.Drawing.Font("Segoe UI", 32.0!)
        Me.btnStop.ForeColor = System.Drawing.Color.DarkRed
        Me.btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStop.Location = New System.Drawing.Point(290, 511)
        Me.btnStop.Margin = New System.Windows.Forms.Padding(5)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(200, 75)
        Me.btnStop.TabIndex = 7
        Me.btnStop.Text = "СТОП"
        Me.btnStop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnTemp
        '
        Me.btnTemp.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTemp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTemp.ImageIndex = 0
        Me.btnTemp.ImageList = Me.ImageList1
        Me.btnTemp.Location = New System.Drawing.Point(48, 380)
        Me.btnTemp.Margin = New System.Windows.Forms.Padding(5)
        Me.btnTemp.Name = "btnTemp"
        Me.btnTemp.Size = New System.Drawing.Size(572, 50)
        Me.btnTemp.TabIndex = 10
        Me.btnTemp.Text = "Температура гасителя 30°С"
        Me.btnTemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTemp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTemp.UseVisualStyleBackColor = True
        '
        'btnContinue
        '
        Me.btnContinue.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContinue.Image = Global.Gidrogasitel.My.Resources.Resources.Ok
        Me.btnContinue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnContinue.Location = New System.Drawing.Point(500, 511)
        Me.btnContinue.Margin = New System.Windows.Forms.Padding(5)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(220, 75)
        Me.btnContinue.TabIndex = 9
        Me.btnContinue.Text = "Продолжить"
        Me.btnContinue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnContinue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnContinue.UseVisualStyleBackColor = True
        Me.btnContinue.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Image = Global.Gidrogasitel.My.Resources.Resources.button_cancel
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(80, 511)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(200, 75)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Отмена"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'btnT
        '
        Me.btnT.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnT.ImageIndex = 0
        Me.btnT.ImageList = Me.ImageList1
        Me.btnT.Location = New System.Drawing.Point(48, 320)
        Me.btnT.Margin = New System.Windows.Forms.Padding(5)
        Me.btnT.Name = "btnT"
        Me.btnT.Size = New System.Drawing.Size(572, 50)
        Me.btnT.TabIndex = 3
        Me.btnT.Text = "Прокачка 60 c"
        Me.btnT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnT.UseVisualStyleBackColor = True
        '
        'btnV
        '
        Me.btnV.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnV.ImageIndex = 0
        Me.btnV.ImageList = Me.ImageList1
        Me.btnV.Location = New System.Drawing.Point(48, 260)
        Me.btnV.Margin = New System.Windows.Forms.Padding(5)
        Me.btnV.Name = "btnV"
        Me.btnV.Size = New System.Drawing.Size(572, 50)
        Me.btnV.TabIndex = 2
        Me.btnV.Text = "Скорость 0,000 (0,075) м/с"
        Me.btnV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnV.UseVisualStyleBackColor = True
        '
        'btnAngle
        '
        Me.btnAngle.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnAngle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAngle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAngle.ImageIndex = 0
        Me.btnAngle.ImageList = Me.ImageList1
        Me.btnAngle.Location = New System.Drawing.Point(48, 200)
        Me.btnAngle.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAngle.Name = "btnAngle"
        Me.btnAngle.Size = New System.Drawing.Size(572, 50)
        Me.btnAngle.TabIndex = 1
        Me.btnAngle.Text = "Наклон до 45 (90)° "
        Me.btnAngle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAngle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAngle.UseVisualStyleBackColor = True
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
        Me.btnBack.Size = New System.Drawing.Size(640, 75)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Испытание (шаг 6 из 20)"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(527, 37)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Выполняется предварительная прокачка"
        '
        'aseIspAngle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTemp)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.pbT)
        Me.Controls.Add(Me.pbV)
        Me.Controls.Add(Me.pbAngle)
        Me.Controls.Add(Me.btnT)
        Me.Controls.Add(Me.btnV)
        Me.Controls.Add(Me.btnAngle)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "aseIspAngle"
        Me.Text = "aseIspAngle"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnAngle As System.Windows.Forms.Button
    Friend WithEvents btnV As System.Windows.Forms.Button
    Friend WithEvents btnT As System.Windows.Forms.Button
    Friend WithEvents pbAngle As System.Windows.Forms.ProgressBar
    Friend WithEvents pbV As System.Windows.Forms.ProgressBar
    Friend WithEvents pbT As System.Windows.Forms.ProgressBar
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnContinue As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnTemp As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
