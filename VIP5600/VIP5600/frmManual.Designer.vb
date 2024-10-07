<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManual))
        Me.ilSwitch = New System.Windows.Forms.ImageList(Me.components)
        Me.ilTemp = New System.Windows.Forms.ImageList(Me.components)
        Me.btnFzp = New System.Windows.Forms.Button()
        Me.btnFfp = New System.Windows.Forms.Button()
        Me.btnIp = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnOscTitle = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnTg = New System.Windows.Forms.Button()
        Me.btnTs = New System.Windows.Forms.Button()
        Me.btnBr = New System.Windows.Forms.Button()
        Me.btnBs = New System.Windows.Forms.Button()
        Me.btnV = New System.Windows.Forms.Button()
        Me.btnRegim = New System.Windows.Forms.Button()
        Me.btnAmpl = New System.Windows.Forms.Button()
        Me.btnAng = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ilSwitch
        '
        Me.ilSwitch.ImageStream = CType(resources.GetObject("ilSwitch.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilSwitch.TransparentColor = System.Drawing.Color.Transparent
        Me.ilSwitch.Images.SetKeyName(0, "off.png")
        Me.ilSwitch.Images.SetKeyName(1, "on.png")
        '
        'ilTemp
        '
        Me.ilTemp.ImageStream = CType(resources.GetObject("ilTemp.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilTemp.TransparentColor = System.Drawing.Color.Transparent
        Me.ilTemp.Images.SetKeyName(0, "temperature_1.png")
        Me.ilTemp.Images.SetKeyName(1, "temperature_2.png")
        Me.ilTemp.Images.SetKeyName(2, "temperature_3.png")
        Me.ilTemp.Images.SetKeyName(3, "temperature_5.png")
        '
        'btnFzp
        '
        Me.btnFzp.Enabled = False
        Me.btnFzp.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnFzp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFzp.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnFzp.Location = New System.Drawing.Point(518, 12)
        Me.btnFzp.Name = "btnFzp"
        Me.btnFzp.Size = New System.Drawing.Size(200, 30)
        Me.btnFzp.TabIndex = 10
        Me.btnFzp.Text = "Частота задания 65 Гц"
        Me.btnFzp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFzp.UseVisualStyleBackColor = True
        Me.btnFzp.Visible = False
        '
        'btnFfp
        '
        Me.btnFfp.Enabled = False
        Me.btnFfp.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnFfp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFfp.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnFfp.Location = New System.Drawing.Point(518, 48)
        Me.btnFfp.Name = "btnFfp"
        Me.btnFfp.Size = New System.Drawing.Size(200, 30)
        Me.btnFfp.TabIndex = 11
        Me.btnFfp.Text = "Частота текущая 0 Гц"
        Me.btnFfp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFfp.UseVisualStyleBackColor = True
        Me.btnFfp.Visible = False
        '
        'btnIp
        '
        Me.btnIp.Enabled = False
        Me.btnIp.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnIp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIp.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnIp.Location = New System.Drawing.Point(518, 84)
        Me.btnIp.Name = "btnIp"
        Me.btnIp.Size = New System.Drawing.Size(200, 30)
        Me.btnIp.TabIndex = 12
        Me.btnIp.Text = "Ток 0 А"
        Me.btnIp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIp.UseVisualStyleBackColor = True
        Me.btnIp.Visible = False
        '
        'btnUp
        '
        Me.btnUp.Enabled = False
        Me.btnUp.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUp.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnUp.Location = New System.Drawing.Point(518, 120)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(200, 30)
        Me.btnUp.TabIndex = 13
        Me.btnUp.Text = "Напряжение 0 В"
        Me.btnUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUp.UseVisualStyleBackColor = True
        Me.btnUp.Visible = False
        '
        'btnOscTitle
        '
        Me.btnOscTitle.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnOscTitle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue
        Me.btnOscTitle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.btnOscTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOscTitle.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnOscTitle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnOscTitle.Location = New System.Drawing.Point(485, 156)
        Me.btnOscTitle.Name = "btnOscTitle"
        Me.btnOscTitle.Size = New System.Drawing.Size(257, 30)
        Me.btnOscTitle.TabIndex = 14
        Me.btnOscTitle.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(456, 200)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 250)
        Me.Panel1.TabIndex = 15
        '
        'Timer1
        '
        '
        'btnStop
        '
        Me.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStop.Font = New System.Drawing.Font("Segoe UI", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnStop.ForeColor = System.Drawing.Color.Red
        Me.btnStop.Location = New System.Drawing.Point(80, 500)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(200, 75)
        Me.btnStop.TabIndex = 16
        Me.btnStop.Text = "Стоп"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnTg
        '
        Me.btnTg.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnTg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue
        Me.btnTg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.btnTg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTg.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnTg.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnTg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTg.ImageIndex = 0
        Me.btnTg.ImageList = Me.ilTemp
        Me.btnTg.Location = New System.Drawing.Point(485, 508)
        Me.btnTg.Name = "btnTg"
        Me.btnTg.Size = New System.Drawing.Size(286, 50)
        Me.btnTg.TabIndex = 9
        Me.btnTg.Text = "Температура гасителя 20°С"
        Me.btnTg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTg.UseVisualStyleBackColor = True
        '
        'btnTs
        '
        Me.btnTs.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnTs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue
        Me.btnTs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.btnTs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTs.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnTs.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnTs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTs.ImageIndex = 1
        Me.btnTs.ImageList = Me.ilTemp
        Me.btnTs.Location = New System.Drawing.Point(485, 452)
        Me.btnTs.Name = "btnTs"
        Me.btnTs.Size = New System.Drawing.Size(286, 50)
        Me.btnTs.TabIndex = 8
        Me.btnTs.Text = "Температура воздуха 20°С"
        Me.btnTs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTs.UseVisualStyleBackColor = True
        '
        'btnBr
        '
        Me.btnBr.Enabled = False
        Me.btnBr.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnBr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBr.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnBr.Image = Global.Gidrogasitel.My.Resources.Resources.move_up_24
        Me.btnBr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBr.Location = New System.Drawing.Point(80, 440)
        Me.btnBr.Name = "btnBr"
        Me.btnBr.Size = New System.Drawing.Size(380, 50)
        Me.btnBr.TabIndex = 7
        Me.btnBr.Text = "Усилие растяжения 0 кН"
        Me.btnBr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBr.UseVisualStyleBackColor = True
        '
        'btnBs
        '
        Me.btnBs.Enabled = False
        Me.btnBs.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnBs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue
        Me.btnBs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.btnBs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBs.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnBs.Image = Global.Gidrogasitel.My.Resources.Resources.move_down_24
        Me.btnBs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBs.Location = New System.Drawing.Point(80, 380)
        Me.btnBs.Name = "btnBs"
        Me.btnBs.Size = New System.Drawing.Size(370, 50)
        Me.btnBs.TabIndex = 6
        Me.btnBs.Text = "Усилие сжатия 0 кН"
        Me.btnBs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBs.UseVisualStyleBackColor = True
        '
        'btnV
        '
        Me.btnV.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnV.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnV.Image = Global.Gidrogasitel.My.Resources.Resources.button_rotate_24
        Me.btnV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnV.Location = New System.Drawing.Point(80, 320)
        Me.btnV.Name = "btnV"
        Me.btnV.Size = New System.Drawing.Size(350, 50)
        Me.btnV.TabIndex = 4
        Me.btnV.Text = "Cкорость 0 м/с"
        Me.btnV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnV.UseVisualStyleBackColor = True
        '
        'btnRegim
        '
        Me.btnRegim.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnRegim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegim.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnRegim.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegim.ImageIndex = 0
        Me.btnRegim.ImageList = Me.ilSwitch
        Me.btnRegim.Location = New System.Drawing.Point(80, 260)
        Me.btnRegim.Name = "btnRegim"
        Me.btnRegim.Size = New System.Drawing.Size(250, 50)
        Me.btnRegim.TabIndex = 3
        Me.btnRegim.Text = "Вращение"
        Me.btnRegim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegim.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnRegim.UseVisualStyleBackColor = True
        '
        'btnAmpl
        '
        Me.btnAmpl.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnAmpl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAmpl.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnAmpl.Image = Global.Gidrogasitel.My.Resources.Resources.move_up_down_24
        Me.btnAmpl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAmpl.Location = New System.Drawing.Point(80, 200)
        Me.btnAmpl.Name = "btnAmpl"
        Me.btnAmpl.Size = New System.Drawing.Size(350, 50)
        Me.btnAmpl.TabIndex = 2
        Me.btnAmpl.Text = "Ход 40 мм"
        Me.btnAmpl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAmpl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAmpl.UseVisualStyleBackColor = True
        '
        'btnAng
        '
        Me.btnAng.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnAng.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAng.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnAng.Image = Global.Gidrogasitel.My.Resources.Resources.angle_24
        Me.btnAng.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAng.Location = New System.Drawing.Point(80, 140)
        Me.btnAng.Name = "btnAng"
        Me.btnAng.Size = New System.Drawing.Size(350, 50)
        Me.btnAng.TabIndex = 1
        Me.btnAng.Text = "Угол наклона 0°"
        Me.btnAng.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAng.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAng.UseVisualStyleBackColor = True
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
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Ручное управление"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(175, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(220, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(273, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(175, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Label6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(231, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Label7"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(287, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Label8"
        '
        'frmManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnOscTitle)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.btnIp)
        Me.Controls.Add(Me.btnFfp)
        Me.Controls.Add(Me.btnFzp)
        Me.Controls.Add(Me.btnTg)
        Me.Controls.Add(Me.btnTs)
        Me.Controls.Add(Me.btnBr)
        Me.Controls.Add(Me.btnBs)
        Me.Controls.Add(Me.btnV)
        Me.Controls.Add(Me.btnRegim)
        Me.Controls.Add(Me.btnAmpl)
        Me.Controls.Add(Me.btnAng)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "frmManual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnAng As System.Windows.Forms.Button
    Friend WithEvents btnAmpl As System.Windows.Forms.Button
    Friend WithEvents btnRegim As System.Windows.Forms.Button
    Friend WithEvents btnV As System.Windows.Forms.Button
    Friend WithEvents ilSwitch As System.Windows.Forms.ImageList
    Friend WithEvents btnBs As System.Windows.Forms.Button
    Friend WithEvents btnBr As System.Windows.Forms.Button
    Friend WithEvents btnTs As System.Windows.Forms.Button
    Friend WithEvents ilTemp As System.Windows.Forms.ImageList
    Friend WithEvents btnTg As System.Windows.Forms.Button
    Friend WithEvents btnFzp As System.Windows.Forms.Button
    Friend WithEvents btnFfp As System.Windows.Forms.Button
    Friend WithEvents btnIp As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents btnOscTitle As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
