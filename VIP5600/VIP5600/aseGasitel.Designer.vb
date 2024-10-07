<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aseGasitel
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
        Me.btnType = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnName = New System.Windows.Forms.Button()
        Me.btnPrep = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.GidrogasitelDataSet1 = New Gidrogasitel.GidrogasitelDataSet()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApparatTypeTableAdapter = New Gidrogasitel.GidrogasitelDataSetTableAdapters.ApparatTypeTableAdapter()
        CType(Me.GidrogasitelDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnType
        '
        Me.btnType.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnType.Location = New System.Drawing.Point(80, 200)
        Me.btnType.Margin = New System.Windows.Forms.Padding(5)
        Me.btnType.Name = "btnType"
        Me.btnType.Size = New System.Drawing.Size(640, 50)
        Me.btnType.TabIndex = 1
        Me.btnType.Text = "Тип гидрогасителя:"
        Me.btnType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnType.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn1.Location = New System.Drawing.Point(80, 320)
        Me.btn1.Margin = New System.Windows.Forms.Padding(5)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(315, 50)
        Me.btn1.TabIndex = 2
        Me.btn1.Text = "1."
        Me.btn1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn2.Location = New System.Drawing.Point(80, 380)
        Me.btn2.Margin = New System.Windows.Forms.Padding(5)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(315, 50)
        Me.btn2.TabIndex = 3
        Me.btn2.Text = "2."
        Me.btn2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn3.Location = New System.Drawing.Point(405, 320)
        Me.btn3.Margin = New System.Windows.Forms.Padding(5)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(315, 50)
        Me.btn3.TabIndex = 4
        Me.btn3.Text = "3."
        Me.btn3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn4.Location = New System.Drawing.Point(405, 380)
        Me.btn4.Margin = New System.Windows.Forms.Padding(5)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(315, 50)
        Me.btn4.TabIndex = 5
        Me.btn4.Text = "4."
        Me.btn4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.Location = New System.Drawing.Point(80, 440)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(5)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(640, 50)
        Me.btnReport.TabIndex = 6
        Me.btnReport.Text = "Обработка результатов"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnName
        '
        Me.btnName.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnName.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnName.Location = New System.Drawing.Point(80, 140)
        Me.btnName.Margin = New System.Windows.Forms.Padding(5)
        Me.btnName.Name = "btnName"
        Me.btnName.Size = New System.Drawing.Size(660, 50)
        Me.btnName.TabIndex = 7
        Me.btnName.Text = "Обозначение:"
        Me.btnName.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnName.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnName.UseVisualStyleBackColor = True
        '
        'btnPrep
        '
        Me.btnPrep.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnPrep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrep.Location = New System.Drawing.Point(80, 260)
        Me.btnPrep.Margin = New System.Windows.Forms.Padding(5)
        Me.btnPrep.Name = "btnPrep"
        Me.btnPrep.Size = New System.Drawing.Size(640, 50)
        Me.btnPrep.TabIndex = 8
        Me.btnPrep.Text = "Подготовка к испытанию"
        Me.btnPrep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrep.UseVisualStyleBackColor = True
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
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(640, 75)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Гидрогаситель"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'GidrogasitelDataSet1
        '
        Me.GidrogasitelDataSet1.DataSetName = "GidrogasitelDataSet"
        Me.GidrogasitelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "ApparatType"
        Me.BindingSource1.DataSource = Me.GidrogasitelDataSet1
        '
        'ApparatTypeTableAdapter
        '
        Me.ApparatTypeTableAdapter.ClearBeforeFill = True
        '
        'aseGasitel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.btnPrep)
        Me.Controls.Add(Me.btnName)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btnType)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "aseGasitel"
        Me.Text = "aseGasitel"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GidrogasitelDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnType As System.Windows.Forms.Button
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents btnName As System.Windows.Forms.Button
    Friend WithEvents btnPrep As System.Windows.Forms.Button
    Friend WithEvents GidrogasitelDataSet1 As Gidrogasitel.GidrogasitelDataSet
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ApparatTypeTableAdapter As Gidrogasitel.GidrogasitelDataSetTableAdapters.ApparatTypeTableAdapter
End Class
