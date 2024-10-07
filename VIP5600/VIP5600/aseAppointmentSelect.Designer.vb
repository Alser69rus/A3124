<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aseAppointmentSelect
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GidrogasitelDataSet = New Gidrogasitel.GidrogasitelDataSet()
        Me.AppointmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AppointmentTableAdapter = New Gidrogasitel.GidrogasitelDataSetTableAdapters.AppointmentTableAdapter()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPgUp = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnPgDown = New System.Windows.Forms.Button()
        CType(Me.GidrogasitelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.AppointmentBindingSource, "ID", True))
        Me.ListBox1.DataSource = Me.AppointmentBindingSource
        Me.ListBox1.DisplayMember = "Appointment"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 37
        Me.ListBox1.Location = New System.Drawing.Point(25, 25)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(400, 370)
        Me.ListBox1.TabIndex = 0
        '
        'GidrogasitelDataSet
        '
        Me.GidrogasitelDataSet.DataSetName = "GidrogasitelDataSet"
        Me.GidrogasitelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'btnOk
        '
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.Image = Global.Gidrogasitel.My.Resources.Resources.Ok
        Me.btnOk.Location = New System.Drawing.Point(75, 405)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(5)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(300, 75)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "Выбрать"
        Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnPgDown)
        Me.Panel1.Controls.Add(Me.btnDown)
        Me.Panel1.Controls.Add(Me.btnUp)
        Me.Panel1.Controls.Add(Me.btnPgUp)
        Me.Panel1.Location = New System.Drawing.Point(325, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(100, 370)
        Me.Panel1.TabIndex = 2
        '
        'btnPgUp
        '
        Me.btnPgUp.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.btnPgUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPgUp.Image = Global.Gidrogasitel.My.Resources.Resources.double_arrow_up_32
        Me.btnPgUp.Location = New System.Drawing.Point(45, 5)
        Me.btnPgUp.Margin = New System.Windows.Forms.Padding(5)
        Me.btnPgUp.Name = "btnPgUp"
        Me.btnPgUp.Size = New System.Drawing.Size(50, 50)
        Me.btnPgUp.TabIndex = 0
        Me.btnPgUp.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUp.Image = Global.Gidrogasitel.My.Resources.Resources.collapse2_32
        Me.btnUp.Location = New System.Drawing.Point(45, 65)
        Me.btnUp.Margin = New System.Windows.Forms.Padding(5)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(50, 50)
        Me.btnUp.TabIndex = 1
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDown.Image = Global.Gidrogasitel.My.Resources.Resources.expand2_32
        Me.btnDown.Location = New System.Drawing.Point(45, 255)
        Me.btnDown.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(50, 50)
        Me.btnDown.TabIndex = 2
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnPgDown
        '
        Me.btnPgDown.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue
        Me.btnPgDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPgDown.Image = Global.Gidrogasitel.My.Resources.Resources.double_arrow_down_32
        Me.btnPgDown.Location = New System.Drawing.Point(45, 315)
        Me.btnPgDown.Margin = New System.Windows.Forms.Padding(5)
        Me.btnPgDown.Name = "btnPgDown"
        Me.btnPgDown.Size = New System.Drawing.Size(50, 50)
        Me.btnPgDown.TabIndex = 3
        Me.btnPgDown.UseVisualStyleBackColor = True
        '
        'aseAppointmentSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(450, 500)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.ListBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(175, 40)
        Me.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.Name = "aseAppointmentSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "aseAppointmentSelect"
        CType(Me.GidrogasitelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents GidrogasitelDataSet As Gidrogasitel.GidrogasitelDataSet
    Friend WithEvents AppointmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AppointmentTableAdapter As Gidrogasitel.GidrogasitelDataSetTableAdapters.AppointmentTableAdapter
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnPgDown As System.Windows.Forms.Button
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents btnPgUp As System.Windows.Forms.Button
End Class
