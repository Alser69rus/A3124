<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aseIspSetAmpl
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnT = New System.Windows.Forms.Button()
        Me.btnA = New System.Windows.Forms.Button()
        Me.btnV = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.pbA = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(482, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Производится изменение амплитуды"
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
        Me.btnStop.TabIndex = 5
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
        Me.btnCancel.TabIndex = 6
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
        Me.btnContinue.TabIndex = 7
        Me.btnContinue.Text = "Продолжить"
        Me.btnContinue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnContinue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnContinue.UseVisualStyleBackColor = True
        Me.btnContinue.Visible = False
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
        Me.btnBack.Text = "Испытание (шаг 9 из 20)"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnT
        '
        Me.btnT.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnT.Location = New System.Drawing.Point(80, 320)
        Me.btnT.Margin = New System.Windows.Forms.Padding(5)
        Me.btnT.Name = "btnT"
        Me.btnT.Size = New System.Drawing.Size(540, 50)
        Me.btnT.TabIndex = 1
        Me.btnT.Text = "Температура гасителя 38°С"
        Me.btnT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnT.UseVisualStyleBackColor = True
        '
        'btnA
        '
        Me.btnA.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnA.Location = New System.Drawing.Point(80, 200)
        Me.btnA.Margin = New System.Windows.Forms.Padding(5)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(540, 50)
        Me.btnA.TabIndex = 3
        Me.btnA.Text = "Ход гасителя 38,0 (40,0) мм"
        Me.btnA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnA.UseVisualStyleBackColor = True
        '
        'btnV
        '
        Me.btnV.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnV.Location = New System.Drawing.Point(80, 260)
        Me.btnV.Margin = New System.Windows.Forms.Padding(5)
        Me.btnV.Name = "btnV"
        Me.btnV.Size = New System.Drawing.Size(540, 50)
        Me.btnV.TabIndex = 4
        Me.btnV.Text = "Скорость 0,000 м/с"
        Me.btnV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnV.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'pbA
        '
        Me.pbA.Location = New System.Drawing.Point(630, 213)
        Me.pbA.Margin = New System.Windows.Forms.Padding(5, 18, 5, 18)
        Me.pbA.Name = "pbA"
        Me.pbA.Size = New System.Drawing.Size(100, 24)
        Me.pbA.TabIndex = 8
        '
        'aseIspSetAmpl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.pbA)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnV)
        Me.Controls.Add(Me.btnA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnT)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "aseIspSetAmpl"
        Me.Text = "aseIspSetAmpl"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnContinue As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnT As System.Windows.Forms.Button
    Friend WithEvents btnA As System.Windows.Forms.Button
    Friend WithEvents btnV As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents pbA As System.Windows.Forms.ProgressBar
End Class
