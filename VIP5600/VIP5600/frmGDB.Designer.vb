<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGDB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGDB))
        Me.PrintView = New System.Windows.Forms.PrintPreviewControl()
        Me.tool = New System.Windows.Forms.ToolStrip()
        Me.tbtnPrint = New System.Windows.Forms.ToolStripDropDownButton()
        Me.sbtnPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.sbtnSelPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.sbtnSelPage = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tbtnZoom = New System.Windows.Forms.ToolStripComboBox()
        Me.ds = New Gidrogasitel.GidrogasitelDataSet()
        Me.PageSetupDialog = New System.Windows.Forms.PageSetupDialog()
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.tool.SuspendLayout()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintView
        '
        Me.PrintView.AutoZoom = False
        Me.PrintView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrintView.Location = New System.Drawing.Point(0, 25)
        Me.PrintView.Name = "PrintView"
        Me.PrintView.Rows = 3
        Me.PrintView.Size = New System.Drawing.Size(794, 546)
        Me.PrintView.TabIndex = 9
        Me.PrintView.Zoom = 0.85R
        '
        'tool
        '
        Me.tool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbtnPrint, Me.ToolStripLabel1, Me.tbtnZoom})
        Me.tool.Location = New System.Drawing.Point(0, 0)
        Me.tool.Name = "tool"
        Me.tool.Size = New System.Drawing.Size(794, 25)
        Me.tool.TabIndex = 8
        Me.tool.Text = "ToolStrip1"
        '
        'tbtnPrint
        '
        Me.tbtnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbtnPrint.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sbtnPrint, Me.sbtnSelPrint, Me.sbtnSelPage})
        Me.tbtnPrint.Image = CType(resources.GetObject("tbtnPrint.Image"), System.Drawing.Image)
        Me.tbtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbtnPrint.Name = "tbtnPrint"
        Me.tbtnPrint.Size = New System.Drawing.Size(29, 22)
        Me.tbtnPrint.Text = "ToolStripButton1"
        '
        'sbtnPrint
        '
        Me.sbtnPrint.Image = CType(resources.GetObject("sbtnPrint.Image"), System.Drawing.Image)
        Me.sbtnPrint.Name = "sbtnPrint"
        Me.sbtnPrint.Size = New System.Drawing.Size(195, 22)
        Me.sbtnPrint.Text = "Печать"
        '
        'sbtnSelPrint
        '
        Me.sbtnSelPrint.Name = "sbtnSelPrint"
        Me.sbtnSelPrint.Size = New System.Drawing.Size(195, 22)
        Me.sbtnSelPrint.Text = "Выбор принтера"
        '
        'sbtnSelPage
        '
        Me.sbtnSelPage.Image = CType(resources.GetObject("sbtnSelPage.Image"), System.Drawing.Image)
        Me.sbtnSelPage.Name = "sbtnSelPage"
        Me.sbtnSelPage.Size = New System.Drawing.Size(195, 22)
        Me.sbtnSelPage.Text = "Параметры страницы"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.AutoSize = False
        Me.ToolStripLabel1.Image = CType(resources.GetObject("ToolStripLabel1.Image"), System.Drawing.Image)
        Me.ToolStripLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(55, 22)
        Me.ToolStripLabel1.Text = "Zoom"
        '
        'tbtnZoom
        '
        Me.tbtnZoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tbtnZoom.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.tbtnZoom.Items.AddRange(New Object() {"Авто", "100%", "75%", "50%", "25%"})
        Me.tbtnZoom.Name = "tbtnZoom"
        Me.tbtnZoom.Size = New System.Drawing.Size(100, 25)
        '
        'ds
        '
        Me.ds.DataSetName = "GidrogasitelDataSet"
        Me.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrintDialog
        '
        Me.PrintDialog.AllowPrintToFile = False
        Me.PrintDialog.UseEXDialog = True
        '
        'frmGDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 571)
        Me.Controls.Add(Me.PrintView)
        Me.Controls.Add(Me.tool)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGDB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Результаты испытаний"
        Me.tool.ResumeLayout(False)
        Me.tool.PerformLayout()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintView As System.Windows.Forms.PrintPreviewControl
    Friend WithEvents tool As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tbtnZoom As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ds As Gidrogasitel.GidrogasitelDataSet
    Friend WithEvents PageSetupDialog As System.Windows.Forms.PageSetupDialog
    Friend WithEvents PrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents tbtnPrint As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents sbtnPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sbtnSelPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sbtnSelPage As System.Windows.Forms.ToolStripMenuItem
End Class
