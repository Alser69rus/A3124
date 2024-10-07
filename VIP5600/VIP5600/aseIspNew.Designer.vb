<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aseIspNew
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
        Me.GidrogasitelDataSet = New Gidrogasitel.GidrogasitelDataSet()
        Me.BindingMain = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainTableAdapter = New Gidrogasitel.GidrogasitelDataSetTableAdapters.mainTableAdapter()
        Me.BindingAppointment = New System.Windows.Forms.BindingSource(Me.components)
        Me.AppointmentTableAdapter = New Gidrogasitel.GidrogasitelDataSetTableAdapters.AppointmentTableAdapter()
        Me.BindingOperators = New System.Windows.Forms.BindingSource(Me.components)
        Me.OperatorsTableAdapter = New Gidrogasitel.GidrogasitelDataSetTableAdapters.OperatorsTableAdapter()
        Me.BindingRemont = New System.Windows.Forms.BindingSource(Me.components)
        Me.RemontTableAdapter = New Gidrogasitel.GidrogasitelDataSetTableAdapters.RemontTableAdapter()
        Me.BindingApparatType = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApparatTypeTableAdapter = New Gidrogasitel.GidrogasitelDataSetTableAdapters.ApparatTypeTableAdapter()
        Me.BindingRezult = New System.Windows.Forms.BindingSource(Me.components)
        Me.RezultTableAdapter = New Gidrogasitel.GidrogasitelDataSetTableAdapters.RezultTableAdapter()
        Me.BindingApparats = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApparatsTableAdapter = New Gidrogasitel.GidrogasitelDataSetTableAdapters.ApparatsTableAdapter()
        CType(Me.GidrogasitelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingAppointment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingOperators, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingRemont, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingApparatType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingRezult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingApparats, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnBack.Text = "Испытание гидрогасителя"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'GidrogasitelDataSet
        '
        Me.GidrogasitelDataSet.DataSetName = "GidrogasitelDataSet"
        Me.GidrogasitelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingMain
        '
        Me.BindingMain.DataMember = "main"
        Me.BindingMain.DataSource = Me.GidrogasitelDataSet
        '
        'MainTableAdapter
        '
        Me.MainTableAdapter.ClearBeforeFill = True
        '
        'BindingAppointment
        '
        Me.BindingAppointment.DataMember = "Appointment"
        Me.BindingAppointment.DataSource = Me.GidrogasitelDataSet
        '
        'AppointmentTableAdapter
        '
        Me.AppointmentTableAdapter.ClearBeforeFill = True
        '
        'BindingOperators
        '
        Me.BindingOperators.DataMember = "Operators"
        Me.BindingOperators.DataSource = Me.GidrogasitelDataSet
        '
        'OperatorsTableAdapter
        '
        Me.OperatorsTableAdapter.ClearBeforeFill = True
        '
        'BindingRemont
        '
        Me.BindingRemont.DataMember = "Remont"
        Me.BindingRemont.DataSource = Me.GidrogasitelDataSet
        '
        'RemontTableAdapter
        '
        Me.RemontTableAdapter.ClearBeforeFill = True
        '
        'BindingApparatType
        '
        Me.BindingApparatType.DataMember = "ApparatType"
        Me.BindingApparatType.DataSource = Me.GidrogasitelDataSet
        '
        'ApparatTypeTableAdapter
        '
        Me.ApparatTypeTableAdapter.ClearBeforeFill = True
        '
        'BindingRezult
        '
        Me.BindingRezult.DataMember = "Rezult"
        Me.BindingRezult.DataSource = Me.GidrogasitelDataSet
        '
        'RezultTableAdapter
        '
        Me.RezultTableAdapter.ClearBeforeFill = True
        '
        'BindingApparats
        '
        Me.BindingApparats.DataMember = "Apparats"
        Me.BindingApparats.DataSource = Me.GidrogasitelDataSet
        '
        'ApparatsTableAdapter
        '
        Me.ApparatsTableAdapter.ClearBeforeFill = True
        '
        'aseIspNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "aseIspNew"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GidrogasitelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingAppointment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingOperators, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingRemont, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingApparatType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingRezult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingApparats, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents GidrogasitelDataSet As Gidrogasitel.GidrogasitelDataSet
    Friend WithEvents BindingMain As System.Windows.Forms.BindingSource
    Friend WithEvents MainTableAdapter As Gidrogasitel.GidrogasitelDataSetTableAdapters.mainTableAdapter
    Friend WithEvents BindingAppointment As System.Windows.Forms.BindingSource
    Friend WithEvents AppointmentTableAdapter As Gidrogasitel.GidrogasitelDataSetTableAdapters.AppointmentTableAdapter
    Friend WithEvents BindingOperators As System.Windows.Forms.BindingSource
    Friend WithEvents OperatorsTableAdapter As Gidrogasitel.GidrogasitelDataSetTableAdapters.OperatorsTableAdapter
    Friend WithEvents BindingRemont As System.Windows.Forms.BindingSource
    Friend WithEvents RemontTableAdapter As Gidrogasitel.GidrogasitelDataSetTableAdapters.RemontTableAdapter
    Friend WithEvents BindingApparatType As System.Windows.Forms.BindingSource
    Friend WithEvents ApparatTypeTableAdapter As Gidrogasitel.GidrogasitelDataSetTableAdapters.ApparatTypeTableAdapter
    Friend WithEvents BindingRezult As System.Windows.Forms.BindingSource
    Friend WithEvents RezultTableAdapter As Gidrogasitel.GidrogasitelDataSetTableAdapters.RezultTableAdapter
    Friend WithEvents BindingApparats As System.Windows.Forms.BindingSource
    Friend WithEvents ApparatsTableAdapter As Gidrogasitel.GidrogasitelDataSetTableAdapters.ApparatsTableAdapter
End Class
