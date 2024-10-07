<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aseBD
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
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnFiltr = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.MainBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GidrogasitelDataSet = New Gidrogasitel.GidrogasitelDataSet()
        Me.MainTableAdapter = New Gidrogasitel.GidrogasitelDataSetTableAdapters.mainTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPgDown = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnPgUp = New System.Windows.Forms.Button()
        Me.OperatorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OperatorsTableAdapter = New Gidrogasitel.GidrogasitelDataSetTableAdapters.OperatorsTableAdapter()
        Me.ApparatsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApparatsTableAdapter = New Gidrogasitel.GidrogasitelDataSetTableAdapters.ApparatsTableAdapter()
        Me.RemontBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RemontTableAdapter = New Gidrogasitel.GidrogasitelDataSetTableAdapters.RemontTableAdapter()
        Me.AppointmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AppointmentTableAdapter = New Gidrogasitel.GidrogasitelDataSetTableAdapters.AppointmentTableAdapter()
        Me.RezultBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RezultTableAdapter = New Gidrogasitel.GidrogasitelDataSetTableAdapters.RezultTableAdapter()
        Me.ApparatTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApparatTypeTableAdapter = New Gidrogasitel.GidrogasitelDataSetTableAdapters.ApparatTypeTableAdapter()
        CType(Me.MainBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GidrogasitelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.OperatorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApparatsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemontBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RezultBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApparatTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnBack.Text = "Протоколы испытаний"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShow.Image = Global.Gidrogasitel.My.Resources.Resources.my_reports
        Me.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShow.Location = New System.Drawing.Point(80, 511)
        Me.btnShow.Margin = New System.Windows.Forms.Padding(5)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(200, 75)
        Me.btnShow.TabIndex = 1
        Me.btnShow.Text = "Показать"
        Me.btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnFiltr
        '
        Me.btnFiltr.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnFiltr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltr.Image = Global.Gidrogasitel.My.Resources.Resources.filter_32
        Me.btnFiltr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFiltr.Location = New System.Drawing.Point(290, 511)
        Me.btnFiltr.Margin = New System.Windows.Forms.Padding(5)
        Me.btnFiltr.Name = "btnFiltr"
        Me.btnFiltr.Size = New System.Drawing.Size(200, 75)
        Me.btnFiltr.TabIndex = 2
        Me.btnFiltr.Text = "Фильтр"
        Me.btnFiltr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFiltr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFiltr.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel.Image = Global.Gidrogasitel.My.Resources.Resources.document_delete
        Me.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDel.Location = New System.Drawing.Point(500, 511)
        Me.btnDel.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(200, 75)
        Me.btnDel.TabIndex = 3
        Me.btnDel.Text = "Удалить"
        Me.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.SkyBlue
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.DataSource = Me.MainBindingSource
        Me.ListBox1.DisplayMember = "ID"
        Me.ListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 37
        Me.ListBox1.Location = New System.Drawing.Point(80, 111)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(660, 370)
        Me.ListBox1.TabIndex = 4
        '
        'MainBindingSource
        '
        Me.MainBindingSource.DataMember = "main"
        Me.MainBindingSource.DataSource = Me.GidrogasitelDataSet
        '
        'GidrogasitelDataSet
        '
        Me.GidrogasitelDataSet.DataSetName = "GidrogasitelDataSet"
        Me.GidrogasitelDataSet.EnforceConstraints = False
        Me.GidrogasitelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MainTableAdapter
        '
        Me.MainTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnPgDown)
        Me.Panel1.Controls.Add(Me.btnDown)
        Me.Panel1.Controls.Add(Me.btnUp)
        Me.Panel1.Controls.Add(Me.btnPgUp)
        Me.Panel1.Location = New System.Drawing.Point(640, 111)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5)
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
        Me.btnPgDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
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
        Me.btnDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
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
        Me.btnUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
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
        Me.btnPgUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPgUp.UseVisualStyleBackColor = True
        '
        'OperatorsBindingSource
        '
        Me.OperatorsBindingSource.DataMember = "Operators"
        Me.OperatorsBindingSource.DataSource = Me.GidrogasitelDataSet
        '
        'OperatorsTableAdapter
        '
        Me.OperatorsTableAdapter.ClearBeforeFill = True
        '
        'ApparatsBindingSource
        '
        Me.ApparatsBindingSource.DataMember = "Apparats"
        Me.ApparatsBindingSource.DataSource = Me.GidrogasitelDataSet
        '
        'ApparatsTableAdapter
        '
        Me.ApparatsTableAdapter.ClearBeforeFill = True
        '
        'RemontBindingSource
        '
        Me.RemontBindingSource.DataMember = "Remont"
        Me.RemontBindingSource.DataSource = Me.GidrogasitelDataSet
        '
        'RemontTableAdapter
        '
        Me.RemontTableAdapter.ClearBeforeFill = True
        '
        'AppointmentBindingSource
        '
        Me.AppointmentBindingSource.DataMember = "Appointment"
        Me.AppointmentBindingSource.DataSource = Me.GidrogasitelDataSet
        '
        'AppointmentTableAdapter
        '
        Me.AppointmentTableAdapter.ClearBeforeFill = True
        '
        'RezultBindingSource
        '
        Me.RezultBindingSource.DataMember = "Rezult"
        Me.RezultBindingSource.DataSource = Me.GidrogasitelDataSet
        '
        'RezultTableAdapter
        '
        Me.RezultTableAdapter.ClearBeforeFill = True
        '
        'ApparatTypeBindingSource
        '
        Me.ApparatTypeBindingSource.DataMember = "ApparatType"
        Me.ApparatTypeBindingSource.DataSource = Me.GidrogasitelDataSet
        '
        'ApparatTypeTableAdapter
        '
        Me.ApparatTypeTableAdapter.ClearBeforeFill = True
        '
        'aseBD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnFiltr)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "aseBD"
        Me.Text = "aseBD"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MainBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GidrogasitelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.OperatorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApparatsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemontBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RezultBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApparatTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnFiltr As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents GidrogasitelDataSet As Gidrogasitel.GidrogasitelDataSet
    Friend WithEvents MainBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MainTableAdapter As Gidrogasitel.GidrogasitelDataSetTableAdapters.mainTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents OperatorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OperatorsTableAdapter As Gidrogasitel.GidrogasitelDataSetTableAdapters.OperatorsTableAdapter
    Friend WithEvents ApparatsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ApparatsTableAdapter As Gidrogasitel.GidrogasitelDataSetTableAdapters.ApparatsTableAdapter
    Friend WithEvents btnPgDown As System.Windows.Forms.Button
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents btnPgUp As System.Windows.Forms.Button
    Friend WithEvents RemontBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RemontTableAdapter As Gidrogasitel.GidrogasitelDataSetTableAdapters.RemontTableAdapter
    Friend WithEvents AppointmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AppointmentTableAdapter As Gidrogasitel.GidrogasitelDataSetTableAdapters.AppointmentTableAdapter
    Friend WithEvents RezultBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RezultTableAdapter As Gidrogasitel.GidrogasitelDataSetTableAdapters.RezultTableAdapter
    Friend WithEvents ApparatTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ApparatTypeTableAdapter As Gidrogasitel.GidrogasitelDataSetTableAdapters.ApparatTypeTableAdapter
End Class
