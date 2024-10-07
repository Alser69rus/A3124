<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aseReport
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
        Me.PrintPreviewControl1 = New System.Windows.Forms.PrintPreviewControl()
        Me.Doc = New System.Drawing.Printing.PrintDocument()
        Me.btnM = New System.Windows.Forms.ComboBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSelectPrinter = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintPreviewControl1
        '
        Me.PrintPreviewControl1.AutoZoom = False
        Me.PrintPreviewControl1.BackColor = System.Drawing.Color.SkyBlue
        Me.PrintPreviewControl1.Document = Me.Doc
        Me.PrintPreviewControl1.Location = New System.Drawing.Point(40, 108)
        Me.PrintPreviewControl1.Margin = New System.Windows.Forms.Padding(5)
        Me.PrintPreviewControl1.Name = "PrintPreviewControl1"
        Me.PrintPreviewControl1.Size = New System.Drawing.Size(720, 478)
        Me.PrintPreviewControl1.TabIndex = 0
        Me.PrintPreviewControl1.Zoom = 0.75R
        '
        'Doc
        '
        '
        'btnM
        '
        Me.btnM.BackColor = System.Drawing.Color.SkyBlue
        Me.btnM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.btnM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnM.FormattingEnabled = True
        Me.btnM.Items.AddRange(New Object() {"40", "60", "80", "100", "150", "200"})
        Me.btnM.Location = New System.Drawing.Point(536, 30)
        Me.btnM.Margin = New System.Windows.Forms.Padding(5, 15, 5, 15)
        Me.btnM.Name = "btnM"
        Me.btnM.Size = New System.Drawing.Size(80, 45)
        Me.btnM.TabIndex = 4
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Gidrogasitel.My.Resources.Resources.zoom2
        Me.PictureBox1.Location = New System.Drawing.Point(481, 30)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btnSelectPrinter
        '
        Me.btnSelectPrinter.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnSelectPrinter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectPrinter.Image = Global.Gidrogasitel.My.Resources.Resources.document_print_preview_64
        Me.btnSelectPrinter.Location = New System.Drawing.Point(626, 14)
        Me.btnSelectPrinter.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSelectPrinter.Name = "btnSelectPrinter"
        Me.btnSelectPrinter.Size = New System.Drawing.Size(75, 75)
        Me.btnSelectPrinter.TabIndex = 3
        Me.btnSelectPrinter.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Image = Global.Gidrogasitel.My.Resources.Resources.print_2_64
        Me.btnPrint.Location = New System.Drawing.Point(711, 14)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(5)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 75)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 32.0!)
        Me.Button1.Image = Global.Gidrogasitel.My.Resources.Resources.circle_back_arrow_32
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(80, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(319, 75)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Отчет"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'aseReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnM)
        Me.Controls.Add(Me.btnSelectPrinter)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PrintPreviewControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "aseReport"
        Me.Text = "aseReport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrintPreviewControl1 As System.Windows.Forms.PrintPreviewControl
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Doc As System.Drawing.Printing.PrintDocument
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnSelectPrinter As System.Windows.Forms.Button
    Friend WithEvents btnM As System.Windows.Forms.ComboBox
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
