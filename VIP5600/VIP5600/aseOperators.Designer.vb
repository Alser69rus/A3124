<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aseOperators
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.OperatorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GidrogasitelDataSet = New Gidrogasitel.GidrogasitelDataSet()
        Me.OperatorsTableAdapter = New Gidrogasitel.GidrogasitelDataSetTableAdapters.OperatorsTableAdapter()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPgDown = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnPgUp = New System.Windows.Forms.Button()
        CType(Me.OperatorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GidrogasitelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.btnBack.Size = New System.Drawing.Size(640, 75)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Перечень сотрудников"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.SkyBlue
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.OperatorsBindingSource, "ID", True))
        Me.ListBox1.DataSource = Me.OperatorsBindingSource
        Me.ListBox1.DisplayMember = "Last"
        Me.ListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 37
        Me.ListBox1.Location = New System.Drawing.Point(80, 140)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(640, 370)
        Me.ListBox1.TabIndex = 1
        '
        'OperatorsBindingSource
        '
        Me.OperatorsBindingSource.DataMember = "Operators"
        Me.OperatorsBindingSource.DataSource = Me.GidrogasitelDataSet
        '
        'GidrogasitelDataSet
        '
        Me.GidrogasitelDataSet.DataSetName = "GidrogasitelDataSet"
        Me.GidrogasitelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OperatorsTableAdapter
        '
        Me.OperatorsTableAdapter.ClearBeforeFill = True
        '
        'btnAdd
        '
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Image = Global.Gidrogasitel.My.Resources.Resources.More_32
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(80, 520)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(200, 75)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Добавить"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel.Image = Global.Gidrogasitel.My.Resources.Resources.Less_32
        Me.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDel.Location = New System.Drawing.Point(290, 520)
        Me.btnDel.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(200, 75)
        Me.btnDel.TabIndex = 3
        Me.btnDel.Text = "Удалить"
        Me.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Image = Global.Gidrogasitel.My.Resources.Resources.circle_edit_pen_pencil_32
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(500, 520)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(200, 75)
        Me.btnEdit.TabIndex = 4
        Me.btnEdit.Text = "Изменить"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnPgDown)
        Me.Panel1.Controls.Add(Me.btnDown)
        Me.Panel1.Controls.Add(Me.btnUp)
        Me.Panel1.Controls.Add(Me.btnPgUp)
        Me.Panel1.Location = New System.Drawing.Point(620, 140)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(100, 370)
        Me.Panel1.TabIndex = 5
        '
        'btnPgDown
        '
        Me.btnPgDown.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnPgDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPgDown.Image = Global.Gidrogasitel.My.Resources.Resources.double_arrow_down_32
        Me.btnPgDown.Location = New System.Drawing.Point(45, 315)
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
        Me.btnDown.Location = New System.Drawing.Point(45, 255)
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
        'aseOperators
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "aseOperators"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.OperatorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GidrogasitelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents GidrogasitelDataSet As Gidrogasitel.GidrogasitelDataSet
    Friend WithEvents OperatorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OperatorsTableAdapter As Gidrogasitel.GidrogasitelDataSetTableAdapters.OperatorsTableAdapter
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnPgDown As System.Windows.Forms.Button
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents btnPgUp As System.Windows.Forms.Button
End Class
