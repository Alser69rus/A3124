<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aseOperatorChange
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
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnSecond = New System.Windows.Forms.Button()
        Me.btnAppointment = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GidrogasitelDataSet = New Gidrogasitel.GidrogasitelDataSet()
        Me.AppointmentTableAdapter = New Gidrogasitel.GidrogasitelDataSetTableAdapters.AppointmentTableAdapter()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GidrogasitelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnBack.Size = New System.Drawing.Size(480, 75)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Данные сотрудника"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLast.Location = New System.Drawing.Point(80, 140)
        Me.btnLast.Margin = New System.Windows.Forms.Padding(5)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(480, 50)
        Me.btnLast.TabIndex = 1
        Me.btnLast.Text = "Фамилия:"
        Me.btnLast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFirst.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFirst.Location = New System.Drawing.Point(80, 200)
        Me.btnFirst.Margin = New System.Windows.Forms.Padding(5)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(480, 50)
        Me.btnFirst.TabIndex = 2
        Me.btnFirst.Text = "Имя:"
        Me.btnFirst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFirst.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnSecond
        '
        Me.btnSecond.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnSecond.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSecond.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSecond.Location = New System.Drawing.Point(80, 260)
        Me.btnSecond.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSecond.Name = "btnSecond"
        Me.btnSecond.Size = New System.Drawing.Size(480, 50)
        Me.btnSecond.TabIndex = 3
        Me.btnSecond.Text = "Отчество:"
        Me.btnSecond.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSecond.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSecond.UseVisualStyleBackColor = True
        '
        'btnAppointment
        '
        Me.btnAppointment.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAppointment.Location = New System.Drawing.Point(80, 320)
        Me.btnAppointment.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAppointment.Name = "btnAppointment"
        Me.btnAppointment.Size = New System.Drawing.Size(480, 50)
        Me.btnAppointment.TabIndex = 4
        Me.btnAppointment.Text = "Должность:"
        Me.btnAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAppointment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAppointment.UseVisualStyleBackColor = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Appointment"
        Me.BindingSource1.DataSource = Me.GidrogasitelDataSet
        '
        'GidrogasitelDataSet
        '
        Me.GidrogasitelDataSet.DataSetName = "GidrogasitelDataSet"
        Me.GidrogasitelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AppointmentTableAdapter
        '
        Me.AppointmentTableAdapter.ClearBeforeFill = True
        '
        'aseOperatorChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.btnAppointment)
        Me.Controls.Add(Me.btnSecond)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "aseOperatorChange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GidrogasitelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnSecond As System.Windows.Forms.Button
    Friend WithEvents btnAppointment As System.Windows.Forms.Button
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents GidrogasitelDataSet As Gidrogasitel.GidrogasitelDataSet
    Friend WithEvents AppointmentTableAdapter As Gidrogasitel.GidrogasitelDataSetTableAdapters.AppointmentTableAdapter
End Class
