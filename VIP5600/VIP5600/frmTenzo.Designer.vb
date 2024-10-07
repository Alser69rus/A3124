<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTenzo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTenzo))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnLim = New System.Windows.Forms.Button()
        Me.btnUOut = New System.Windows.Forms.Button()
        Me.btnUPow = New System.Windows.Forms.Button()
        Me.btnReg = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnD = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUIn = New System.Windows.Forms.Button()
        Me.btnCorA = New System.Windows.Forms.Button()
        Me.btnCorB = New System.Windows.Forms.Button()
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
        Me.btnBack.Text = "Тензодатчик"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnLim
        '
        Me.btnLim.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnLim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLim.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnLim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLim.Location = New System.Drawing.Point(80, 140)
        Me.btnLim.Margin = New System.Windows.Forms.Padding(5)
        Me.btnLim.Name = "btnLim"
        Me.btnLim.Size = New System.Drawing.Size(600, 50)
        Me.btnLim.TabIndex = 1
        Me.btnLim.Text = "Номинал тензодатчика "
        Me.btnLim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLim.UseVisualStyleBackColor = True
        '
        'btnUOut
        '
        Me.btnUOut.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnUOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUOut.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnUOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUOut.Location = New System.Drawing.Point(80, 200)
        Me.btnUOut.Margin = New System.Windows.Forms.Padding(5)
        Me.btnUOut.Name = "btnUOut"
        Me.btnUOut.Size = New System.Drawing.Size(600, 50)
        Me.btnUOut.TabIndex = 2
        Me.btnUOut.Text = "Напряжение тензодатчика"
        Me.btnUOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUOut.UseVisualStyleBackColor = True
        '
        'btnUPow
        '
        Me.btnUPow.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnUPow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUPow.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnUPow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUPow.Location = New System.Drawing.Point(80, 320)
        Me.btnUPow.Margin = New System.Windows.Forms.Padding(5)
        Me.btnUPow.Name = "btnUPow"
        Me.btnUPow.Size = New System.Drawing.Size(600, 50)
        Me.btnUPow.TabIndex = 3
        Me.btnUPow.Text = "Выход преобразователя"
        Me.btnUPow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUPow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUPow.UseVisualStyleBackColor = True
        '
        'btnReg
        '
        Me.btnReg.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReg.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnReg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReg.ImageIndex = 0
        Me.btnReg.ImageList = Me.ImageList1
        Me.btnReg.Location = New System.Drawing.Point(80, 380)
        Me.btnReg.Margin = New System.Windows.Forms.Padding(5)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(300, 50)
        Me.btnReg.TabIndex = 4
        Me.btnReg.Text = "ПЧВ"
        Me.btnReg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReg.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnReg.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "off.png")
        Me.ImageList1.Images.SetKeyName(1, "on.png")
        '
        'btnD
        '
        Me.btnD.Enabled = False
        Me.btnD.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnD.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnD.Location = New System.Drawing.Point(80, 440)
        Me.btnD.Margin = New System.Windows.Forms.Padding(5)
        Me.btnD.Name = "btnD"
        Me.btnD.Size = New System.Drawing.Size(300, 50)
        Me.btnD.TabIndex = 5
        Me.btnD.Text = "Br-Bs="
        Me.btnD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnD.UseVisualStyleBackColor = True
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
        Me.btnOk.TabIndex = 8
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
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Нет"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUIn
        '
        Me.btnUIn.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnUIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUIn.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnUIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUIn.Location = New System.Drawing.Point(80, 260)
        Me.btnUIn.Margin = New System.Windows.Forms.Padding(5)
        Me.btnUIn.Name = "btnUIn"
        Me.btnUIn.Size = New System.Drawing.Size(600, 50)
        Me.btnUIn.TabIndex = 10
        Me.btnUIn.Text = "Вход преобразователя"
        Me.btnUIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUIn.UseVisualStyleBackColor = True
        '
        'btnCorA
        '
        Me.btnCorA.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnCorA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCorA.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnCorA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCorA.Location = New System.Drawing.Point(450, 380)
        Me.btnCorA.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCorA.Name = "btnCorA"
        Me.btnCorA.Size = New System.Drawing.Size(300, 50)
        Me.btnCorA.TabIndex = 11
        Me.btnCorA.Text = "A="
        Me.btnCorA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCorA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCorA.UseVisualStyleBackColor = True
        '
        'btnCorB
        '
        Me.btnCorB.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnCorB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCorB.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnCorB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCorB.Location = New System.Drawing.Point(450, 440)
        Me.btnCorB.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCorB.Name = "btnCorB"
        Me.btnCorB.Size = New System.Drawing.Size(300, 50)
        Me.btnCorB.TabIndex = 12
        Me.btnCorB.Text = "B="
        Me.btnCorB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCorB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCorB.UseVisualStyleBackColor = True
        '
        'frmTenzo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.btnCorB)
        Me.Controls.Add(Me.btnCorA)
        Me.Controls.Add(Me.btnUIn)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnD)
        Me.Controls.Add(Me.btnReg)
        Me.Controls.Add(Me.btnUPow)
        Me.Controls.Add(Me.btnUOut)
        Me.Controls.Add(Me.btnLim)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "frmTenzo"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnLim As System.Windows.Forms.Button
    Friend WithEvents btnUOut As System.Windows.Forms.Button
    Friend WithEvents btnUPow As System.Windows.Forms.Button
    Friend WithEvents btnReg As System.Windows.Forms.Button
    Friend WithEvents btnD As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnUIn As System.Windows.Forms.Button
    Friend WithEvents btnCorA As System.Windows.Forms.Button
    Friend WithEvents btnCorB As System.Windows.Forms.Button
End Class
