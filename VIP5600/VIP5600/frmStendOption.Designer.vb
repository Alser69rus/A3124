<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStendOption
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnPort1 = New System.Windows.Forms.Button()
        Me.btnPort2 = New System.Windows.Forms.Button()
        Me.btnBaudrate = New System.Windows.Forms.Button()
        Me.btnDatabits = New System.Windows.Forms.Button()
        Me.btnStopbits = New System.Windows.Forms.Button()
        Me.btnParity = New System.Windows.Forms.Button()
        Me.btnHandshake = New System.Windows.Forms.Button()
        Me.btnPath = New System.Windows.Forms.Button()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.btnSafe = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
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
        Me.btnBack.Text = "Настройки стенда"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnPort1
        '
        Me.btnPort1.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnPort1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPort1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnPort1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPort1.Location = New System.Drawing.Point(80, 140)
        Me.btnPort1.Margin = New System.Windows.Forms.Padding(5)
        Me.btnPort1.Name = "btnPort1"
        Me.btnPort1.Size = New System.Drawing.Size(300, 50)
        Me.btnPort1.TabIndex = 1
        Me.btnPort1.Text = "Port1="
        Me.btnPort1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPort1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPort1.UseVisualStyleBackColor = True
        '
        'btnPort2
        '
        Me.btnPort2.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnPort2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPort2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnPort2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPort2.Location = New System.Drawing.Point(450, 140)
        Me.btnPort2.Margin = New System.Windows.Forms.Padding(5)
        Me.btnPort2.Name = "btnPort2"
        Me.btnPort2.Size = New System.Drawing.Size(300, 50)
        Me.btnPort2.TabIndex = 2
        Me.btnPort2.Text = "Port2="
        Me.btnPort2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPort2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPort2.UseVisualStyleBackColor = True
        '
        'btnBaudrate
        '
        Me.btnBaudrate.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnBaudrate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBaudrate.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnBaudrate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBaudrate.Location = New System.Drawing.Point(80, 200)
        Me.btnBaudrate.Margin = New System.Windows.Forms.Padding(5)
        Me.btnBaudrate.Name = "btnBaudrate"
        Me.btnBaudrate.Size = New System.Drawing.Size(300, 50)
        Me.btnBaudrate.TabIndex = 3
        Me.btnBaudrate.Text = "Baudrate="
        Me.btnBaudrate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBaudrate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBaudrate.UseVisualStyleBackColor = True
        '
        'btnDatabits
        '
        Me.btnDatabits.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnDatabits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDatabits.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnDatabits.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDatabits.Location = New System.Drawing.Point(450, 200)
        Me.btnDatabits.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDatabits.Name = "btnDatabits"
        Me.btnDatabits.Size = New System.Drawing.Size(300, 50)
        Me.btnDatabits.TabIndex = 4
        Me.btnDatabits.Text = "Databits="
        Me.btnDatabits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDatabits.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDatabits.UseVisualStyleBackColor = True
        '
        'btnStopbits
        '
        Me.btnStopbits.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnStopbits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStopbits.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnStopbits.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStopbits.Location = New System.Drawing.Point(80, 260)
        Me.btnStopbits.Margin = New System.Windows.Forms.Padding(5)
        Me.btnStopbits.Name = "btnStopbits"
        Me.btnStopbits.Size = New System.Drawing.Size(300, 50)
        Me.btnStopbits.TabIndex = 5
        Me.btnStopbits.Text = "Stopbits="
        Me.btnStopbits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStopbits.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStopbits.UseVisualStyleBackColor = True
        '
        'btnParity
        '
        Me.btnParity.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnParity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnParity.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnParity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnParity.Location = New System.Drawing.Point(450, 260)
        Me.btnParity.Margin = New System.Windows.Forms.Padding(5)
        Me.btnParity.Name = "btnParity"
        Me.btnParity.Size = New System.Drawing.Size(300, 50)
        Me.btnParity.TabIndex = 6
        Me.btnParity.Text = "Parity="
        Me.btnParity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnParity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnParity.UseVisualStyleBackColor = True
        '
        'btnHandshake
        '
        Me.btnHandshake.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnHandshake.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHandshake.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnHandshake.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHandshake.Location = New System.Drawing.Point(80, 320)
        Me.btnHandshake.Margin = New System.Windows.Forms.Padding(5)
        Me.btnHandshake.Name = "btnHandshake"
        Me.btnHandshake.Size = New System.Drawing.Size(300, 50)
        Me.btnHandshake.TabIndex = 7
        Me.btnHandshake.Text = "Handshake="
        Me.btnHandshake.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHandshake.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHandshake.UseVisualStyleBackColor = True
        '
        'btnPath
        '
        Me.btnPath.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPath.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnPath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPath.Location = New System.Drawing.Point(80, 380)
        Me.btnPath.Margin = New System.Windows.Forms.Padding(5)
        Me.btnPath.Name = "btnPath"
        Me.btnPath.Size = New System.Drawing.Size(600, 50)
        Me.btnPath.TabIndex = 8
        Me.btnPath.Text = "Path="
        Me.btnPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPath.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPath.UseVisualStyleBackColor = True
        '
        'btnLog
        '
        Me.btnLog.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLog.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLog.Location = New System.Drawing.Point(80, 440)
        Me.btnLog.Margin = New System.Windows.Forms.Padding(5)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(300, 50)
        Me.btnLog.TabIndex = 9
        Me.btnLog.Text = "Log="
        Me.btnLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLog.UseVisualStyleBackColor = True
        '
        'btnSafe
        '
        Me.btnSafe.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnSafe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSafe.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnSafe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSafe.Location = New System.Drawing.Point(450, 440)
        Me.btnSafe.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSafe.Name = "btnSafe"
        Me.btnSafe.Size = New System.Drawing.Size(300, 50)
        Me.btnSafe.TabIndex = 10
        Me.btnSafe.Text = "Safe mode="
        Me.btnSafe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSafe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSafe.UseVisualStyleBackColor = True
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
        Me.btnOk.TabIndex = 11
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
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Нет"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmStendOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnSafe)
        Me.Controls.Add(Me.btnLog)
        Me.Controls.Add(Me.btnPath)
        Me.Controls.Add(Me.btnHandshake)
        Me.Controls.Add(Me.btnParity)
        Me.Controls.Add(Me.btnStopbits)
        Me.Controls.Add(Me.btnDatabits)
        Me.Controls.Add(Me.btnBaudrate)
        Me.Controls.Add(Me.btnPort2)
        Me.Controls.Add(Me.btnPort1)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "frmStendOption"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnPort1 As System.Windows.Forms.Button
    Friend WithEvents btnPort2 As System.Windows.Forms.Button
    Friend WithEvents btnBaudrate As System.Windows.Forms.Button
    Friend WithEvents btnDatabits As System.Windows.Forms.Button
    Friend WithEvents btnStopbits As System.Windows.Forms.Button
    Friend WithEvents btnParity As System.Windows.Forms.Button
    Friend WithEvents btnHandshake As System.Windows.Forms.Button
    Friend WithEvents btnPath As System.Windows.Forms.Button
    Friend WithEvents btnLog As System.Windows.Forms.Button
    Friend WithEvents btnSafe As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
