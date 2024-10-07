<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aseGasitelSelect
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ApparatsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GidrogasitelDataSet = New Gidrogasitel.GidrogasitelDataSet()
        Me.ApparatsTableAdapter = New Gidrogasitel.GidrogasitelDataSetTableAdapters.ApparatsTableAdapter()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPgDown = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnPgUp = New System.Windows.Forms.Button()
        CType(Me.ApparatsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GidrogasitelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.btnBack.Text = "Испытание (шаг 1 из 17)"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(355, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Укажите тип гидрогасителя"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.SkyBlue
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.ColumnWidth = 270
        Me.ListBox1.DataSource = Me.ApparatsBindingSource
        Me.ListBox1.DisplayMember = "Name"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 37
        Me.ListBox1.Location = New System.Drawing.Point(80, 200)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.ListBox1.MultiColumn = True
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(540, 333)
        Me.ListBox1.TabIndex = 2
        '
        'ApparatsBindingSource
        '
        Me.ApparatsBindingSource.DataMember = "Apparats"
        Me.ApparatsBindingSource.DataSource = Me.GidrogasitelDataSet
        '
        'GidrogasitelDataSet
        '
        Me.GidrogasitelDataSet.DataSetName = "GidrogasitelDataSet"
        Me.GidrogasitelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ApparatsTableAdapter
        '
        Me.ApparatsTableAdapter.ClearBeforeFill = True
        '
        'btnOk
        '
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.Image = Global.Gidrogasitel.My.Resources.Resources.Ok
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(250, 511)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(5)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(200, 75)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "Выбрать"
        Me.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(80, 496)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(540, 37)
        Me.Panel2.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnPgDown)
        Me.Panel1.Controls.Add(Me.btnDown)
        Me.Panel1.Controls.Add(Me.btnUp)
        Me.Panel1.Controls.Add(Me.btnPgUp)
        Me.Panel1.Location = New System.Drawing.Point(620, 200)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(100, 333)
        Me.Panel1.TabIndex = 5
        '
        'btnPgDown
        '
        Me.btnPgDown.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnPgDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPgDown.Image = Global.Gidrogasitel.My.Resources.Resources.double_arrow_down_32
        Me.btnPgDown.Location = New System.Drawing.Point(45, 241)
        Me.btnPgDown.Margin = New System.Windows.Forms.Padding(5)
        Me.btnPgDown.Name = "btnPgDown"
        Me.btnPgDown.Size = New System.Drawing.Size(50, 50)
        Me.btnPgDown.TabIndex = 3
        Me.btnPgDown.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDown.Image = Global.Gidrogasitel.My.Resources.Resources.expand2_32
        Me.btnDown.Location = New System.Drawing.Point(45, 181)
        Me.btnDown.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(50, 50)
        Me.btnDown.TabIndex = 2
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUp.Image = Global.Gidrogasitel.My.Resources.Resources.collapse2_32
        Me.btnUp.Location = New System.Drawing.Point(45, 65)
        Me.btnUp.Margin = New System.Windows.Forms.Padding(5)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(50, 50)
        Me.btnUp.TabIndex = 1
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnPgUp
        '
        Me.btnPgUp.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnPgUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPgUp.Image = Global.Gidrogasitel.My.Resources.Resources.double_arrow_up_32
        Me.btnPgUp.Location = New System.Drawing.Point(45, 5)
        Me.btnPgUp.Margin = New System.Windows.Forms.Padding(5)
        Me.btnPgUp.Name = "btnPgUp"
        Me.btnPgUp.Size = New System.Drawing.Size(50, 50)
        Me.btnPgUp.TabIndex = 0
        Me.btnPgUp.UseVisualStyleBackColor = True
        '
        'aseGasitelSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "aseGasitelSelect"
        Me.Text = "aseGasitelSelect"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ApparatsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GidrogasitelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents GidrogasitelDataSet As Gidrogasitel.GidrogasitelDataSet
    Friend WithEvents ApparatsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ApparatsTableAdapter As Gidrogasitel.GidrogasitelDataSetTableAdapters.ApparatsTableAdapter
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnPgDown As System.Windows.Forms.Button
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents btnPgUp As System.Windows.Forms.Button
End Class
