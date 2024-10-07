<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aseFiltr
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
        Me.btnType = New System.Windows.Forms.Button()
        Me.btnNum = New System.Windows.Forms.Button()
        Me.btnDate1 = New System.Windows.Forms.Button()
        Me.btnDate2 = New System.Windows.Forms.Button()
        Me.btnRemont = New System.Windows.Forms.Button()
        Me.btnOperator = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnType
        '
        Me.btnType.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnType.Location = New System.Drawing.Point(80, 140)
        Me.btnType.Margin = New System.Windows.Forms.Padding(5)
        Me.btnType.Name = "btnType"
        Me.btnType.Size = New System.Drawing.Size(640, 50)
        Me.btnType.TabIndex = 1
        Me.btnType.Text = "Тип гидрогасителя "
        Me.btnType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnType.UseVisualStyleBackColor = True
        '
        'btnNum
        '
        Me.btnNum.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNum.Location = New System.Drawing.Point(80, 200)
        Me.btnNum.Margin = New System.Windows.Forms.Padding(5)
        Me.btnNum.Name = "btnNum"
        Me.btnNum.Size = New System.Drawing.Size(640, 50)
        Me.btnNum.TabIndex = 2
        Me.btnNum.Text = "Номер "
        Me.btnNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNum.UseVisualStyleBackColor = True
        '
        'btnDate1
        '
        Me.btnDate1.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnDate1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDate1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDate1.Location = New System.Drawing.Point(80, 260)
        Me.btnDate1.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDate1.Name = "btnDate1"
        Me.btnDate1.Size = New System.Drawing.Size(640, 50)
        Me.btnDate1.TabIndex = 3
        Me.btnDate1.Text = "Не раньше "
        Me.btnDate1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDate1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDate1.UseVisualStyleBackColor = True
        '
        'btnDate2
        '
        Me.btnDate2.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnDate2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDate2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDate2.Location = New System.Drawing.Point(80, 320)
        Me.btnDate2.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDate2.Name = "btnDate2"
        Me.btnDate2.Size = New System.Drawing.Size(640, 50)
        Me.btnDate2.TabIndex = 4
        Me.btnDate2.Text = "Не позднее "
        Me.btnDate2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDate2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDate2.UseVisualStyleBackColor = True
        '
        'btnRemont
        '
        Me.btnRemont.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnRemont.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemont.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemont.Location = New System.Drawing.Point(80, 380)
        Me.btnRemont.Margin = New System.Windows.Forms.Padding(5)
        Me.btnRemont.Name = "btnRemont"
        Me.btnRemont.Size = New System.Drawing.Size(640, 50)
        Me.btnRemont.TabIndex = 5
        Me.btnRemont.Text = "Вид ремонта "
        Me.btnRemont.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemont.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRemont.UseVisualStyleBackColor = True
        '
        'btnOperator
        '
        Me.btnOperator.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnOperator.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOperator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOperator.Location = New System.Drawing.Point(80, 440)
        Me.btnOperator.Margin = New System.Windows.Forms.Padding(5)
        Me.btnOperator.Name = "btnOperator"
        Me.btnOperator.Size = New System.Drawing.Size(640, 50)
        Me.btnOperator.TabIndex = 6
        Me.btnOperator.Text = "Оператор "
        Me.btnOperator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOperator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOperator.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(80, 554)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(563, 37)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "*Незаполненые параметры не учитываются"
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
        Me.btnBack.Text = "Настройки фильтра"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'aseFiltr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOperator)
        Me.Controls.Add(Me.btnRemont)
        Me.Controls.Add(Me.btnDate2)
        Me.Controls.Add(Me.btnDate1)
        Me.Controls.Add(Me.btnNum)
        Me.Controls.Add(Me.btnType)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "aseFiltr"
        Me.Text = "aseFiltr"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnType As System.Windows.Forms.Button
    Friend WithEvents btnNum As System.Windows.Forms.Button
    Friend WithEvents btnDate1 As System.Windows.Forms.Button
    Friend WithEvents btnDate2 As System.Windows.Forms.Button
    Friend WithEvents btnRemont As System.Windows.Forms.Button
    Friend WithEvents btnOperator As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
