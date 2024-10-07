<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aseIspMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aseIspMain))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnV = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnTime = New System.Windows.Forms.Button()
        Me.btnFr = New System.Windows.Forms.Button()
        Me.btnFs = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.pbV = New System.Windows.Forms.ProgressBar()
        Me.pbTime = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnTemp = New System.Windows.Forms.Button()
        Me.btnB = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
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
        Me.btnBack.Text = "Испытание (шаг 10 из 20)"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnV
        '
        Me.btnV.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnV.ImageIndex = 0
        Me.btnV.ImageList = Me.ImageList1
        Me.btnV.Location = New System.Drawing.Point(48, 140)
        Me.btnV.Margin = New System.Windows.Forms.Padding(5)
        Me.btnV.Name = "btnV"
        Me.btnV.Size = New System.Drawing.Size(420, 50)
        Me.btnV.TabIndex = 1
        Me.btnV.Text = "Скорость 0,000 (0,075) м/с"
        Me.btnV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnV.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "empty.png")
        Me.ImageList1.Images.SetKeyName(1, "Forward.png")
        Me.ImageList1.Images.SetKeyName(2, "Ok.png")
        Me.ImageList1.Images.SetKeyName(3, "button_cancel.png")
        Me.ImageList1.Images.SetKeyName(4, "temperature_1.png")
        Me.ImageList1.Images.SetKeyName(5, "temperature_2.png")
        Me.ImageList1.Images.SetKeyName(6, "temperature_3.png")
        Me.ImageList1.Images.SetKeyName(7, "temperature_5.png")
        '
        'btnTime
        '
        Me.btnTime.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTime.ImageIndex = 0
        Me.btnTime.ImageList = Me.ImageList1
        Me.btnTime.Location = New System.Drawing.Point(48, 200)
        Me.btnTime.Margin = New System.Windows.Forms.Padding(5)
        Me.btnTime.Name = "btnTime"
        Me.btnTime.Size = New System.Drawing.Size(420, 50)
        Me.btnTime.TabIndex = 2
        Me.btnTime.Text = "Лимит времени 60,0 с"
        Me.btnTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTime.UseVisualStyleBackColor = True
        '
        'btnFr
        '
        Me.btnFr.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnFr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFr.Location = New System.Drawing.Point(80, 320)
        Me.btnFr.Margin = New System.Windows.Forms.Padding(5)
        Me.btnFr.Name = "btnFr"
        Me.btnFr.Size = New System.Drawing.Size(420, 50)
        Me.btnFr.TabIndex = 3
        Me.btnFr.Text = "Усилие растяжения 20,0 кН"
        Me.btnFr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFr.UseVisualStyleBackColor = True
        '
        'btnFs
        '
        Me.btnFs.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnFs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFs.Location = New System.Drawing.Point(80, 380)
        Me.btnFs.Margin = New System.Windows.Forms.Padding(5)
        Me.btnFs.Name = "btnFs"
        Me.btnFs.Size = New System.Drawing.Size(420, 50)
        Me.btnFs.TabIndex = 4
        Me.btnFs.Text = "Усилие сжатия 20,0 кН"
        Me.btnFs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFs.UseVisualStyleBackColor = True
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
        'pbV
        '
        Me.pbV.Location = New System.Drawing.Point(520, 153)
        Me.pbV.Margin = New System.Windows.Forms.Padding(5, 18, 5, 18)
        Me.pbV.Name = "pbV"
        Me.pbV.Size = New System.Drawing.Size(100, 24)
        Me.pbV.TabIndex = 10
        '
        'pbTime
        '
        Me.pbTime.Location = New System.Drawing.Point(520, 213)
        Me.pbTime.Margin = New System.Windows.Forms.Padding(5, 18, 5, 18)
        Me.pbTime.Name = "pbTime"
        Me.pbTime.Size = New System.Drawing.Size(100, 24)
        Me.pbTime.TabIndex = 11
        '
        'Timer1
        '
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(520, 260)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 200)
        Me.Panel1.TabIndex = 13
        '
        'btnTemp
        '
        Me.btnTemp.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTemp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTemp.ImageIndex = 4
        Me.btnTemp.ImageList = Me.ImageList1
        Me.btnTemp.Location = New System.Drawing.Point(48, 260)
        Me.btnTemp.Margin = New System.Windows.Forms.Padding(5)
        Me.btnTemp.Name = "btnTemp"
        Me.btnTemp.Size = New System.Drawing.Size(420, 50)
        Me.btnTemp.TabIndex = 6
        Me.btnTemp.Text = "Температура гасителя 56°С"
        Me.btnTemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTemp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTemp.UseVisualStyleBackColor = True
        '
        'btnB
        '
        Me.btnB.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnB.Location = New System.Drawing.Point(80, 440)
        Me.btnB.Margin = New System.Windows.Forms.Padding(5)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(360, 50)
        Me.btnB.TabIndex = 14
        Me.btnB.Text = "В=100/100 кН*м/с"
        Me.btnB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnB.UseVisualStyleBackColor = True
        '
        'aseIspMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.btnB)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pbTime)
        Me.Controls.Add(Me.pbV)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnTemp)
        Me.Controls.Add(Me.btnFs)
        Me.Controls.Add(Me.btnFr)
        Me.Controls.Add(Me.btnTime)
        Me.Controls.Add(Me.btnV)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "aseIspMain"
        Me.Text = "aseIspMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnV As System.Windows.Forms.Button
    Friend WithEvents btnTime As System.Windows.Forms.Button
    Friend WithEvents btnFr As System.Windows.Forms.Button
    Friend WithEvents btnFs As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnContinue As System.Windows.Forms.Button
    Friend WithEvents pbV As System.Windows.Forms.ProgressBar
    Friend WithEvents pbTime As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnTemp As System.Windows.Forms.Button
    Friend WithEvents btnB As System.Windows.Forms.Button
End Class
