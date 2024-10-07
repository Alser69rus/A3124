<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aseOptimG
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aseOptimG))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
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
        Me.btnBack.Text = "Диаграммы гасителя"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1.ImageKey = "Прямоугольник.png"
        Me.btn1.ImageList = Me.ImageList1
        Me.btn1.Location = New System.Drawing.Point(80, 140)
        Me.btn1.Margin = New System.Windows.Forms.Padding(5)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(300, 200)
        Me.btn1.TabIndex = 1
        Me.btn1.Text = "V1=0,075 м/с"
        Me.btn1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn1.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Оси.png")
        Me.ImageList1.Images.SetKeyName(1, "Овал.png")
        Me.ImageList1.Images.SetKeyName(2, "Прямоугольник.png")
        Me.ImageList1.Images.SetKeyName(3, "Пустой.png")
        '
        'btn3
        '
        Me.btn3.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn3.ImageList = Me.ImageList1
        Me.btn3.Location = New System.Drawing.Point(80, 350)
        Me.btn3.Margin = New System.Windows.Forms.Padding(5)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(300, 200)
        Me.btn3.TabIndex = 2
        Me.btn3.Text = "V3=0,300 м/с"
        Me.btn3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn2.ImageList = Me.ImageList1
        Me.btn2.Location = New System.Drawing.Point(390, 140)
        Me.btn2.Margin = New System.Windows.Forms.Padding(5)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(300, 200)
        Me.btn2.TabIndex = 3
        Me.btn2.Text = "V2=0,150 м/с"
        Me.btn2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn4.ImageList = Me.ImageList1
        Me.btn4.Location = New System.Drawing.Point(390, 350)
        Me.btn4.Margin = New System.Windows.Forms.Padding(5)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(300, 200)
        Me.btn4.TabIndex = 4
        Me.btn4.Text = "V4=0,600 м/с"
        Me.btn4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn4.UseVisualStyleBackColor = True
        '
        'aseOptimG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "aseOptimG"
        Me.Text = "aseOptimG"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class
