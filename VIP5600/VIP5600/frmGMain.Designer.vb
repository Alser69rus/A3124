<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGMain))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpList = New System.Windows.Forms.TabPage()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbTypeRemonta = New System.Windows.Forms.ComboBox()
        Me.cmbTypeTD = New System.Windows.Forms.ComboBox()
        Me.cmbAppointment = New System.Windows.Forms.ComboBox()
        Me.cmbOperator = New System.Windows.Forms.ComboBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.btnNewCheck = New System.Windows.Forms.Button()
        Me.TreeViewEx1 = New clTreeView.TreeViewEx()
        Me.tpStend = New System.Windows.Forms.TabPage()
        Me.numFilter = New System.Windows.Forms.NumericUpDown()
        Me.chFiltr = New System.Windows.Forms.CheckBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.lblBsjat = New System.Windows.Forms.Label()
        Me.lblBrast = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTgidro = New System.Windows.Forms.Label()
        Me.lblTos = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.KM16 = New System.Windows.Forms.PictureBox()
        Me.KM15 = New System.Windows.Forms.PictureBox()
        Me.KM14 = New System.Windows.Forms.PictureBox()
        Me.KM13 = New System.Windows.Forms.PictureBox()
        Me.KM12 = New System.Windows.Forms.PictureBox()
        Me.KM11 = New System.Windows.Forms.PictureBox()
        Me.KM10 = New System.Windows.Forms.PictureBox()
        Me.KM9 = New System.Windows.Forms.PictureBox()
        Me.KM8 = New System.Windows.Forms.PictureBox()
        Me.KM7 = New System.Windows.Forms.PictureBox()
        Me.KM6 = New System.Windows.Forms.PictureBox()
        Me.KM5 = New System.Windows.Forms.PictureBox()
        Me.KM4 = New System.Windows.Forms.PictureBox()
        Me.KM3 = New System.Windows.Forms.PictureBox()
        Me.KM2 = New System.Windows.Forms.PictureBox()
        Me.KM1 = New System.Windows.Forms.PictureBox()
        Me.chAvto = New System.Windows.Forms.CheckBox()
        Me.gbPrivod = New System.Windows.Forms.GroupBox()
        Me.lblV2 = New System.Windows.Forms.Label()
        Me.nudFmax = New System.Windows.Forms.NumericUpDown()
        Me.lblV = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.trFzad = New System.Windows.Forms.TrackBar()
        Me.lblFmax = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblFp = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblIp = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblUp = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnSbor = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.gbAmpl = New System.Windows.Forms.GroupBox()
        Me.lblKoncevikAmplitude = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.btnAmplitudeDown = New System.Windows.Forms.Button()
        Me.btnAmplitudeUp = New System.Windows.Forms.Button()
        Me.lblAmpl = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.gbAngle = New System.Windows.Forms.GroupBox()
        Me.lblKoncevikNaklon90 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.btnAngleDown = New System.Windows.Forms.Button()
        Me.btnAngleUp = New System.Windows.Forms.Button()
        Me.lblKoncevikNaklon0 = New System.Windows.Forms.Label()
        Me.lblAngle = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.COscill1 = New pOscill.cOscill()
        Me.tpProtokol = New System.Windows.Forms.TabPage()
        Me.PrintView = New System.Windows.Forms.PrintPreviewControl()
        Me.tool = New System.Windows.Forms.ToolStrip()
        Me.tbtnPrint = New System.Windows.Forms.ToolStripDropDownButton()
        Me.sbtnPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.sbtnSelPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.sbtnSelPage = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tbtnZoom = New System.Windows.Forms.ToolStripComboBox()
        Me.tpBaza = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ApparatsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ds = New Gidrogasitel.GidrogasitelDataSet()
        Me.NumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OperatorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.OperatorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRemontEdit = New System.Windows.Forms.Button()
        Me.btnAppintmentEdit = New System.Windows.Forms.Button()
        Me.btnOperatorEdit = New System.Windows.Forms.Button()
        Me.btnApparatEdit = New System.Windows.Forms.Button()
        Me.btnProtokol = New System.Windows.Forms.Button()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnManage = New System.Windows.Forms.Button()
        Me.chAvtoChecks = New System.Windows.Forms.CheckBox()
        Me.lblRemainingTime = New System.Windows.Forms.Label()
        Me.lblElapsedTime = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.pgbTime = New System.Windows.Forms.ProgressBar()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.PageSetupDialog = New System.Windows.Forms.PageSetupDialog()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.COscill2 = New pOscill.cOscill()
        Me.TabControl1.SuspendLayout()
        Me.tpList.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.tpStend.SuspendLayout()
        CType(Me.numFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.KM16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KM15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KM14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KM13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KM12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KM11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KM10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KM9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KM8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KM7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KM6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KM5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KM4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KM3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KM2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KM1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPrivod.SuspendLayout()
        CType(Me.nudFmax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trFzad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAmpl.SuspendLayout()
        Me.gbAngle.SuspendLayout()
        Me.tpProtokol.SuspendLayout()
        Me.tool.SuspendLayout()
        Me.tpBaza.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApparatsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OperatorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.tpList)
        Me.TabControl1.Controls.Add(Me.tpStend)
        Me.TabControl1.Controls.Add(Me.tpProtokol)
        Me.TabControl1.Controls.Add(Me.tpBaza)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(196, 50)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(800, 502)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 7
        '
        'tpList
        '
        Me.tpList.BackColor = System.Drawing.Color.SkyBlue
        Me.tpList.Controls.Add(Me.GroupBox9)
        Me.tpList.Controls.Add(Me.btnNewCheck)
        Me.tpList.Controls.Add(Me.TreeViewEx1)
        Me.tpList.Location = New System.Drawing.Point(4, 54)
        Me.tpList.Name = "tpList"
        Me.tpList.Size = New System.Drawing.Size(792, 444)
        Me.tpList.TabIndex = 2
        Me.tpList.Text = "Список"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.txtNum)
        Me.GroupBox9.Controls.Add(Me.Label3)
        Me.GroupBox9.Controls.Add(Me.Label5)
        Me.GroupBox9.Controls.Add(Me.Label15)
        Me.GroupBox9.Controls.Add(Me.cmbTypeRemonta)
        Me.GroupBox9.Controls.Add(Me.cmbTypeTD)
        Me.GroupBox9.Controls.Add(Me.cmbAppointment)
        Me.GroupBox9.Controls.Add(Me.cmbOperator)
        Me.GroupBox9.Controls.Add(Me.Label35)
        Me.GroupBox9.Controls.Add(Me.Label36)
        Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox9.Location = New System.Drawing.Point(3, 245)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(378, 193)
        Me.GroupBox9.TabIndex = 12
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Данные о текущих испытаниях"
        '
        'txtNum
        '
        Me.txtNum.Enabled = False
        Me.txtNum.Location = New System.Drawing.Point(205, 59)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(146, 20)
        Me.txtNum.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Должность"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Номер"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(19, 143)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(142, 13)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "Вид проводимого ремонта"
        '
        'cmbTypeRemonta
        '
        Me.cmbTypeRemonta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTypeRemonta.Enabled = False
        Me.cmbTypeRemonta.Location = New System.Drawing.Point(205, 139)
        Me.cmbTypeRemonta.Name = "cmbTypeRemonta"
        Me.cmbTypeRemonta.Size = New System.Drawing.Size(146, 21)
        Me.cmbTypeRemonta.TabIndex = 34
        '
        'cmbTypeTD
        '
        Me.cmbTypeTD.DisplayMember = "Type"
        Me.cmbTypeTD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTypeTD.Enabled = False
        Me.cmbTypeTD.Location = New System.Drawing.Point(205, 33)
        Me.cmbTypeTD.Name = "cmbTypeTD"
        Me.cmbTypeTD.Size = New System.Drawing.Size(146, 21)
        Me.cmbTypeTD.TabIndex = 31
        Me.cmbTypeTD.ValueMember = "Type"
        '
        'cmbAppointment
        '
        Me.cmbAppointment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAppointment.Enabled = False
        Me.cmbAppointment.Location = New System.Drawing.Point(205, 85)
        Me.cmbAppointment.Name = "cmbAppointment"
        Me.cmbAppointment.Size = New System.Drawing.Size(146, 21)
        Me.cmbAppointment.TabIndex = 32
        '
        'cmbOperator
        '
        Me.cmbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOperator.Enabled = False
        Me.cmbOperator.Location = New System.Drawing.Point(205, 112)
        Me.cmbOperator.Name = "cmbOperator"
        Me.cmbOperator.Size = New System.Drawing.Size(146, 21)
        Me.cmbOperator.TabIndex = 33
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(19, 116)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(69, 13)
        Me.Label35.TabIndex = 41
        Me.Label35.Text = "Испытатель"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.DarkRed
        Me.Label36.Location = New System.Drawing.Point(17, 36)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(130, 25)
        Me.Label36.TabIndex = 39
        Me.Label36.Text = "Тип аппарата"
        '
        'btnNewCheck
        '
        Me.btnNewCheck.BackColor = System.Drawing.Color.SkyBlue
        Me.btnNewCheck.FlatAppearance.BorderSize = 0
        Me.btnNewCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewCheck.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnNewCheck.ForeColor = System.Drawing.Color.Green
        Me.btnNewCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewCheck.Location = New System.Drawing.Point(405, 264)
        Me.btnNewCheck.Name = "btnNewCheck"
        Me.btnNewCheck.Size = New System.Drawing.Size(379, 56)
        Me.btnNewCheck.TabIndex = 11
        Me.btnNewCheck.Text = "Начать новую проверку"
        Me.btnNewCheck.UseVisualStyleBackColor = False
        '
        'TreeViewEx1
        '
        Me.TreeViewEx1.BackColor = System.Drawing.Color.SkyBlue
        Me.TreeViewEx1.CheckManager = Nothing
        Me.TreeViewEx1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TreeViewEx1.ForeColor = System.Drawing.Color.White
        Me.TreeViewEx1.FullRowSelect = True
        Me.TreeViewEx1.Location = New System.Drawing.Point(3, 3)
        Me.TreeViewEx1.Name = "TreeViewEx1"
        Me.TreeViewEx1.Size = New System.Drawing.Size(786, 235)
        Me.TreeViewEx1.TabIndex = 8
        '
        'tpStend
        '
        Me.tpStend.Controls.Add(Me.numFilter)
        Me.tpStend.Controls.Add(Me.chFiltr)
        Me.tpStend.Controls.Add(Me.GroupBox10)
        Me.tpStend.Controls.Add(Me.GroupBox1)
        Me.tpStend.Controls.Add(Me.KM16)
        Me.tpStend.Controls.Add(Me.KM15)
        Me.tpStend.Controls.Add(Me.KM14)
        Me.tpStend.Controls.Add(Me.KM13)
        Me.tpStend.Controls.Add(Me.KM12)
        Me.tpStend.Controls.Add(Me.KM11)
        Me.tpStend.Controls.Add(Me.KM10)
        Me.tpStend.Controls.Add(Me.KM9)
        Me.tpStend.Controls.Add(Me.KM8)
        Me.tpStend.Controls.Add(Me.KM7)
        Me.tpStend.Controls.Add(Me.KM6)
        Me.tpStend.Controls.Add(Me.KM5)
        Me.tpStend.Controls.Add(Me.KM4)
        Me.tpStend.Controls.Add(Me.KM3)
        Me.tpStend.Controls.Add(Me.KM2)
        Me.tpStend.Controls.Add(Me.KM1)
        Me.tpStend.Controls.Add(Me.chAvto)
        Me.tpStend.Controls.Add(Me.gbPrivod)
        Me.tpStend.Controls.Add(Me.gbAmpl)
        Me.tpStend.Controls.Add(Me.gbAngle)
        Me.tpStend.Controls.Add(Me.COscill1)
        Me.tpStend.Location = New System.Drawing.Point(4, 54)
        Me.tpStend.Name = "tpStend"
        Me.tpStend.Padding = New System.Windows.Forms.Padding(3)
        Me.tpStend.Size = New System.Drawing.Size(792, 444)
        Me.tpStend.TabIndex = 0
        Me.tpStend.Text = "Стенд"
        Me.tpStend.UseVisualStyleBackColor = True
        '
        'numFilter
        '
        Me.numFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.numFilter.Location = New System.Drawing.Point(264, 425)
        Me.numFilter.Maximum = New Decimal(New Integer() {512, 0, 0, 0})
        Me.numFilter.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numFilter.Name = "numFilter"
        Me.numFilter.Size = New System.Drawing.Size(63, 20)
        Me.numFilter.TabIndex = 29
        Me.numFilter.Value = New Decimal(New Integer() {32, 0, 0, 0})
        '
        'chFiltr
        '
        Me.chFiltr.AutoSize = True
        Me.chFiltr.Checked = True
        Me.chFiltr.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chFiltr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.chFiltr.Location = New System.Drawing.Point(35, 426)
        Me.chFiltr.Name = "chFiltr"
        Me.chFiltr.Size = New System.Drawing.Size(223, 17)
        Me.chFiltr.TabIndex = 28
        Me.chFiltr.Text = "Фильтрация, выше (номер гармоники)"
        Me.chFiltr.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.lblBsjat)
        Me.GroupBox10.Controls.Add(Me.lblBrast)
        Me.GroupBox10.Controls.Add(Me.Label39)
        Me.GroupBox10.Controls.Add(Me.Label40)
        Me.GroupBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox10.Location = New System.Drawing.Point(392, 172)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(191, 61)
        Me.GroupBox10.TabIndex = 5
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Сила сопротивления"
        '
        'lblBsjat
        '
        Me.lblBsjat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBsjat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBsjat.Location = New System.Drawing.Point(140, 39)
        Me.lblBsjat.Name = "lblBsjat"
        Me.lblBsjat.Size = New System.Drawing.Size(41, 18)
        Me.lblBsjat.TabIndex = 1
        Me.lblBsjat.Text = "20"
        Me.lblBsjat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBrast
        '
        Me.lblBrast.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBrast.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBrast.Location = New System.Drawing.Point(140, 18)
        Me.lblBrast.Name = "lblBrast"
        Me.lblBrast.Size = New System.Drawing.Size(41, 18)
        Me.lblBrast.TabIndex = 1
        Me.lblBrast.Text = "20"
        Me.lblBrast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label39
        '
        Me.Label39.Location = New System.Drawing.Point(10, 39)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(124, 18)
        Me.Label39.TabIndex = 0
        Me.Label39.Text = "при сжатии, кН"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label40
        '
        Me.Label40.Location = New System.Drawing.Point(10, 18)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(124, 18)
        Me.Label40.TabIndex = 0
        Me.Label40.Text = "при растяжении, кН"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTgidro)
        Me.GroupBox1.Controls.Add(Me.lblTos)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(592, 172)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(191, 61)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Температура"
        '
        'lblTgidro
        '
        Me.lblTgidro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTgidro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTgidro.Location = New System.Drawing.Point(144, 39)
        Me.lblTgidro.Name = "lblTgidro"
        Me.lblTgidro.Size = New System.Drawing.Size(41, 18)
        Me.lblTgidro.TabIndex = 1
        Me.lblTgidro.Text = "20"
        Me.lblTgidro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTos
        '
        Me.lblTos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTos.Location = New System.Drawing.Point(144, 18)
        Me.lblTos.Name = "lblTos"
        Me.lblTos.Size = New System.Drawing.Size(41, 18)
        Me.lblTos.TabIndex = 1
        Me.lblTos.Text = "20"
        Me.lblTos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "гидрогасителя, °С"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "окружающей среды, °С"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'KM16
        '
        Me.KM16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KM16.ErrorImage = Nothing
        Me.KM16.InitialImage = Nothing
        Me.KM16.Location = New System.Drawing.Point(308, 217)
        Me.KM16.Name = "KM16"
        Me.KM16.Size = New System.Drawing.Size(10, 10)
        Me.KM16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.KM16.TabIndex = 25
        Me.KM16.TabStop = False
        '
        'KM15
        '
        Me.KM15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KM15.ErrorImage = Nothing
        Me.KM15.InitialImage = Nothing
        Me.KM15.Location = New System.Drawing.Point(296, 217)
        Me.KM15.Name = "KM15"
        Me.KM15.Size = New System.Drawing.Size(10, 10)
        Me.KM15.TabIndex = 24
        Me.KM15.TabStop = False
        '
        'KM14
        '
        Me.KM14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KM14.ErrorImage = Nothing
        Me.KM14.InitialImage = Nothing
        Me.KM14.Location = New System.Drawing.Point(284, 217)
        Me.KM14.Name = "KM14"
        Me.KM14.Size = New System.Drawing.Size(10, 10)
        Me.KM14.TabIndex = 23
        Me.KM14.TabStop = False
        '
        'KM13
        '
        Me.KM13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KM13.ErrorImage = Nothing
        Me.KM13.InitialImage = Nothing
        Me.KM13.Location = New System.Drawing.Point(272, 217)
        Me.KM13.Name = "KM13"
        Me.KM13.Size = New System.Drawing.Size(10, 10)
        Me.KM13.TabIndex = 22
        Me.KM13.TabStop = False
        '
        'KM12
        '
        Me.KM12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KM12.ErrorImage = Nothing
        Me.KM12.InitialImage = Nothing
        Me.KM12.Location = New System.Drawing.Point(260, 217)
        Me.KM12.Name = "KM12"
        Me.KM12.Size = New System.Drawing.Size(10, 10)
        Me.KM12.TabIndex = 21
        Me.KM12.TabStop = False
        '
        'KM11
        '
        Me.KM11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KM11.ErrorImage = Nothing
        Me.KM11.InitialImage = Nothing
        Me.KM11.Location = New System.Drawing.Point(248, 217)
        Me.KM11.Name = "KM11"
        Me.KM11.Size = New System.Drawing.Size(10, 10)
        Me.KM11.TabIndex = 20
        Me.KM11.TabStop = False
        '
        'KM10
        '
        Me.KM10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KM10.ErrorImage = Nothing
        Me.KM10.InitialImage = Nothing
        Me.KM10.Location = New System.Drawing.Point(236, 217)
        Me.KM10.Name = "KM10"
        Me.KM10.Size = New System.Drawing.Size(10, 10)
        Me.KM10.TabIndex = 19
        Me.KM10.TabStop = False
        '
        'KM9
        '
        Me.KM9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KM9.ErrorImage = Nothing
        Me.KM9.InitialImage = Nothing
        Me.KM9.Location = New System.Drawing.Point(224, 217)
        Me.KM9.Name = "KM9"
        Me.KM9.Size = New System.Drawing.Size(10, 10)
        Me.KM9.TabIndex = 18
        Me.KM9.TabStop = False
        '
        'KM8
        '
        Me.KM8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KM8.ErrorImage = Nothing
        Me.KM8.InitialImage = Nothing
        Me.KM8.Location = New System.Drawing.Point(308, 195)
        Me.KM8.Name = "KM8"
        Me.KM8.Size = New System.Drawing.Size(10, 10)
        Me.KM8.TabIndex = 16
        Me.KM8.TabStop = False
        '
        'KM7
        '
        Me.KM7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KM7.ErrorImage = Nothing
        Me.KM7.InitialImage = Nothing
        Me.KM7.Location = New System.Drawing.Point(296, 195)
        Me.KM7.Name = "KM7"
        Me.KM7.Size = New System.Drawing.Size(10, 10)
        Me.KM7.TabIndex = 15
        Me.KM7.TabStop = False
        '
        'KM6
        '
        Me.KM6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KM6.ErrorImage = Nothing
        Me.KM6.InitialImage = Nothing
        Me.KM6.Location = New System.Drawing.Point(284, 195)
        Me.KM6.Name = "KM6"
        Me.KM6.Size = New System.Drawing.Size(10, 10)
        Me.KM6.TabIndex = 14
        Me.KM6.TabStop = False
        '
        'KM5
        '
        Me.KM5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KM5.ErrorImage = Nothing
        Me.KM5.InitialImage = Nothing
        Me.KM5.Location = New System.Drawing.Point(272, 195)
        Me.KM5.Name = "KM5"
        Me.KM5.Size = New System.Drawing.Size(10, 10)
        Me.KM5.TabIndex = 13
        Me.KM5.TabStop = False
        '
        'KM4
        '
        Me.KM4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KM4.ErrorImage = Nothing
        Me.KM4.InitialImage = Nothing
        Me.KM4.Location = New System.Drawing.Point(260, 195)
        Me.KM4.Name = "KM4"
        Me.KM4.Size = New System.Drawing.Size(10, 10)
        Me.KM4.TabIndex = 12
        Me.KM4.TabStop = False
        '
        'KM3
        '
        Me.KM3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KM3.ErrorImage = Nothing
        Me.KM3.InitialImage = Nothing
        Me.KM3.Location = New System.Drawing.Point(248, 195)
        Me.KM3.Name = "KM3"
        Me.KM3.Size = New System.Drawing.Size(10, 10)
        Me.KM3.TabIndex = 11
        Me.KM3.TabStop = False
        '
        'KM2
        '
        Me.KM2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KM2.ErrorImage = Nothing
        Me.KM2.InitialImage = Nothing
        Me.KM2.Location = New System.Drawing.Point(236, 195)
        Me.KM2.Name = "KM2"
        Me.KM2.Size = New System.Drawing.Size(10, 10)
        Me.KM2.TabIndex = 10
        Me.KM2.TabStop = False
        '
        'KM1
        '
        Me.KM1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KM1.ErrorImage = Nothing
        Me.KM1.InitialImage = Nothing
        Me.KM1.Location = New System.Drawing.Point(224, 195)
        Me.KM1.Name = "KM1"
        Me.KM1.Size = New System.Drawing.Size(10, 10)
        Me.KM1.TabIndex = 9
        Me.KM1.TabStop = False
        '
        'chAvto
        '
        Me.chAvto.AutoSize = True
        Me.chAvto.Checked = True
        Me.chAvto.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chAvto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.chAvto.Location = New System.Drawing.Point(10, 201)
        Me.chAvto.Name = "chAvto"
        Me.chAvto.Size = New System.Drawing.Size(201, 17)
        Me.chAvto.TabIndex = 8
        Me.chAvto.Text = "Автоматическое  управление"
        Me.chAvto.UseVisualStyleBackColor = True
        '
        'gbPrivod
        '
        Me.gbPrivod.Controls.Add(Me.lblV2)
        Me.gbPrivod.Controls.Add(Me.nudFmax)
        Me.gbPrivod.Controls.Add(Me.lblV)
        Me.gbPrivod.Controls.Add(Me.Label8)
        Me.gbPrivod.Controls.Add(Me.trFzad)
        Me.gbPrivod.Controls.Add(Me.lblFmax)
        Me.gbPrivod.Controls.Add(Me.Label9)
        Me.gbPrivod.Controls.Add(Me.lblFp)
        Me.gbPrivod.Controls.Add(Me.Label16)
        Me.gbPrivod.Controls.Add(Me.Label13)
        Me.gbPrivod.Controls.Add(Me.Label14)
        Me.gbPrivod.Controls.Add(Me.lblIp)
        Me.gbPrivod.Controls.Add(Me.Label12)
        Me.gbPrivod.Controls.Add(Me.lblUp)
        Me.gbPrivod.Controls.Add(Me.Label10)
        Me.gbPrivod.Controls.Add(Me.btnSbor)
        Me.gbPrivod.Enabled = False
        Me.gbPrivod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.gbPrivod.Location = New System.Drawing.Point(392, 10)
        Me.gbPrivod.Name = "gbPrivod"
        Me.gbPrivod.Size = New System.Drawing.Size(392, 156)
        Me.gbPrivod.TabIndex = 7
        Me.gbPrivod.TabStop = False
        Me.gbPrivod.Text = "Управление приводом"
        '
        'lblV2
        '
        Me.lblV2.AutoSize = True
        Me.lblV2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblV2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblV2.Location = New System.Drawing.Point(140, 112)
        Me.lblV2.Name = "lblV2"
        Me.lblV2.Size = New System.Drawing.Size(22, 25)
        Me.lblV2.TabIndex = 8
        Me.lblV2.Text = "0"
        '
        'nudFmax
        '
        Me.nudFmax.Enabled = False
        Me.nudFmax.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudFmax.Location = New System.Drawing.Point(324, 88)
        Me.nudFmax.Maximum = New Decimal(New Integer() {400, 0, 0, 0})
        Me.nudFmax.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudFmax.Name = "nudFmax"
        Me.nudFmax.Size = New System.Drawing.Size(63, 20)
        Me.nudFmax.TabIndex = 7
        Me.nudFmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudFmax.Value = New Decimal(New Integer() {65, 0, 0, 0})
        '
        'lblV
        '
        Me.lblV.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblV.Location = New System.Drawing.Point(138, 89)
        Me.lblV.Name = "lblV"
        Me.lblV.Size = New System.Drawing.Size(41, 18)
        Me.lblV.TabIndex = 1
        Me.lblV.Text = "20"
        Me.lblV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(206, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Частота (макс), Гц"
        '
        'trFzad
        '
        Me.trFzad.LargeChange = 64
        Me.trFzad.Location = New System.Drawing.Point(205, 35)
        Me.trFzad.Maximum = 16383
        Me.trFzad.Name = "trFzad"
        Me.trFzad.Size = New System.Drawing.Size(182, 45)
        Me.trFzad.SmallChange = 16
        Me.trFzad.TabIndex = 5
        Me.trFzad.TickFrequency = 512
        '
        'lblFmax
        '
        Me.lblFmax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFmax.Location = New System.Drawing.Point(139, 71)
        Me.lblFmax.Name = "lblFmax"
        Me.lblFmax.Size = New System.Drawing.Size(41, 18)
        Me.lblFmax.TabIndex = 1
        Me.lblFmax.Text = "0"
        Me.lblFmax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 29)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Контрольная скорость, м/c"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFp
        '
        Me.lblFp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFp.Location = New System.Drawing.Point(138, 53)
        Me.lblFp.Name = "lblFp"
        Me.lblFp.Size = New System.Drawing.Size(41, 18)
        Me.lblFp.TabIndex = 1
        Me.lblFp.Text = "0"
        Me.lblFp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(212, 8)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(135, 18)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Частота (заданная), Гц"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(9, 71)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(123, 18)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Частота (макс), Гц"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(9, 53)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(123, 18)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Частота (факт), Гц"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIp
        '
        Me.lblIp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIp.Location = New System.Drawing.Point(138, 35)
        Me.lblIp.Name = "lblIp"
        Me.lblIp.Size = New System.Drawing.Size(41, 18)
        Me.lblIp.TabIndex = 1
        Me.lblIp.Text = "0"
        Me.lblIp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(10, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(123, 18)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Ток, А"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUp
        '
        Me.lblUp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUp.Location = New System.Drawing.Point(138, 17)
        Me.lblUp.Name = "lblUp"
        Me.lblUp.Size = New System.Drawing.Size(41, 18)
        Me.lblUp.TabIndex = 1
        Me.lblUp.Text = "0"
        Me.lblUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(10, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 18)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Напряжение, В"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSbor
        '
        Me.btnSbor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSbor.ImageIndex = 1
        Me.btnSbor.ImageList = Me.ImageList1
        Me.btnSbor.Location = New System.Drawing.Point(209, 115)
        Me.btnSbor.Name = "btnSbor"
        Me.btnSbor.Size = New System.Drawing.Size(177, 34)
        Me.btnSbor.TabIndex = 4
        Me.btnSbor.Tag = "0"
        Me.btnSbor.Text = "Включить привод"
        Me.btnSbor.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "ledgreen.ico")
        Me.ImageList1.Images.SetKeyName(1, "ledgrey.ico")
        Me.ImageList1.Images.SetKeyName(2, "ledred.ico")
        Me.ImageList1.Images.SetKeyName(3, "ledred1.ico")
        '
        'gbAmpl
        '
        Me.gbAmpl.Controls.Add(Me.lblKoncevikAmplitude)
        Me.gbAmpl.Controls.Add(Me.Label34)
        Me.gbAmpl.Controls.Add(Me.btnAmplitudeDown)
        Me.gbAmpl.Controls.Add(Me.btnAmplitudeUp)
        Me.gbAmpl.Controls.Add(Me.lblAmpl)
        Me.gbAmpl.Controls.Add(Me.Label11)
        Me.gbAmpl.Enabled = False
        Me.gbAmpl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.gbAmpl.Location = New System.Drawing.Point(214, 10)
        Me.gbAmpl.Name = "gbAmpl"
        Me.gbAmpl.Size = New System.Drawing.Size(169, 156)
        Me.gbAmpl.TabIndex = 7
        Me.gbAmpl.TabStop = False
        Me.gbAmpl.Text = "Ход работы гасителя"
        '
        'lblKoncevikAmplitude
        '
        Me.lblKoncevikAmplitude.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblKoncevikAmplitude.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblKoncevikAmplitude.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblKoncevikAmplitude.Location = New System.Drawing.Point(120, 44)
        Me.lblKoncevikAmplitude.Name = "lblKoncevikAmplitude"
        Me.lblKoncevikAmplitude.Size = New System.Drawing.Size(41, 18)
        Me.lblKoncevikAmplitude.TabIndex = 7
        Me.lblKoncevikAmplitude.Text = "Откл."
        Me.lblKoncevikAmplitude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(7, 44)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(139, 18)
        Me.Label34.TabIndex = 6
        Me.Label34.Text = "Концевой выкл. 0"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAmplitudeDown
        '
        Me.btnAmplitudeDown.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAmplitudeDown.Image = Global.Gidrogasitel.My.Resources.Resources.down
        Me.btnAmplitudeDown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAmplitudeDown.Location = New System.Drawing.Point(10, 116)
        Me.btnAmplitudeDown.Name = "btnAmplitudeDown"
        Me.btnAmplitudeDown.Size = New System.Drawing.Size(151, 34)
        Me.btnAmplitudeDown.TabIndex = 5
        Me.btnAmplitudeDown.Tag = "0"
        Me.btnAmplitudeDown.Text = "Уменьшить"
        Me.btnAmplitudeDown.UseVisualStyleBackColor = True
        '
        'btnAmplitudeUp
        '
        Me.btnAmplitudeUp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAmplitudeUp.Image = CType(resources.GetObject("btnAmplitudeUp.Image"), System.Drawing.Image)
        Me.btnAmplitudeUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAmplitudeUp.Location = New System.Drawing.Point(10, 74)
        Me.btnAmplitudeUp.Name = "btnAmplitudeUp"
        Me.btnAmplitudeUp.Size = New System.Drawing.Size(151, 34)
        Me.btnAmplitudeUp.TabIndex = 5
        Me.btnAmplitudeUp.Tag = "0"
        Me.btnAmplitudeUp.Text = "Увеличить"
        Me.btnAmplitudeUp.UseVisualStyleBackColor = True
        '
        'lblAmpl
        '
        Me.lblAmpl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAmpl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAmpl.Location = New System.Drawing.Point(120, 22)
        Me.lblAmpl.Name = "lblAmpl"
        Me.lblAmpl.Size = New System.Drawing.Size(41, 18)
        Me.lblAmpl.TabIndex = 1
        Me.lblAmpl.Text = "90"
        Me.lblAmpl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(7, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(141, 18)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Ход, мм"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbAngle
        '
        Me.gbAngle.Controls.Add(Me.lblKoncevikNaklon90)
        Me.gbAngle.Controls.Add(Me.Label38)
        Me.gbAngle.Controls.Add(Me.btnAngleDown)
        Me.gbAngle.Controls.Add(Me.btnAngleUp)
        Me.gbAngle.Controls.Add(Me.lblKoncevikNaklon0)
        Me.gbAngle.Controls.Add(Me.lblAngle)
        Me.gbAngle.Controls.Add(Me.Label6)
        Me.gbAngle.Controls.Add(Me.Label7)
        Me.gbAngle.Enabled = False
        Me.gbAngle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.gbAngle.Location = New System.Drawing.Point(7, 10)
        Me.gbAngle.Name = "gbAngle"
        Me.gbAngle.Size = New System.Drawing.Size(200, 179)
        Me.gbAngle.TabIndex = 6
        Me.gbAngle.TabStop = False
        Me.gbAngle.Text = "Привод угла наклона"
        '
        'lblKoncevikNaklon90
        '
        Me.lblKoncevikNaklon90.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblKoncevikNaklon90.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblKoncevikNaklon90.Location = New System.Drawing.Point(151, 66)
        Me.lblKoncevikNaklon90.Name = "lblKoncevikNaklon90"
        Me.lblKoncevikNaklon90.Size = New System.Drawing.Size(41, 18)
        Me.lblKoncevikNaklon90.TabIndex = 7
        Me.lblKoncevikNaklon90.Text = "Откл."
        Me.lblKoncevikNaklon90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label38
        '
        Me.Label38.Location = New System.Drawing.Point(7, 66)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(138, 18)
        Me.Label38.TabIndex = 6
        Me.Label38.Text = "Концевой выкл. 90°"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAngleDown
        '
        Me.btnAngleDown.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAngleDown.Image = Global.Gidrogasitel.My.Resources.Resources.down
        Me.btnAngleDown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAngleDown.Location = New System.Drawing.Point(10, 139)
        Me.btnAngleDown.Name = "btnAngleDown"
        Me.btnAngleDown.Size = New System.Drawing.Size(182, 34)
        Me.btnAngleDown.TabIndex = 5
        Me.btnAngleDown.Tag = "0"
        Me.btnAngleDown.Text = "Опустить"
        Me.btnAngleDown.UseVisualStyleBackColor = True
        '
        'btnAngleUp
        '
        Me.btnAngleUp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAngleUp.Image = CType(resources.GetObject("btnAngleUp.Image"), System.Drawing.Image)
        Me.btnAngleUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAngleUp.Location = New System.Drawing.Point(10, 97)
        Me.btnAngleUp.Name = "btnAngleUp"
        Me.btnAngleUp.Size = New System.Drawing.Size(182, 34)
        Me.btnAngleUp.TabIndex = 5
        Me.btnAngleUp.Tag = "0"
        Me.btnAngleUp.Text = "Поднять"
        Me.btnAngleUp.UseVisualStyleBackColor = True
        '
        'lblKoncevikNaklon0
        '
        Me.lblKoncevikNaklon0.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblKoncevikNaklon0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblKoncevikNaklon0.Location = New System.Drawing.Point(151, 43)
        Me.lblKoncevikNaklon0.Name = "lblKoncevikNaklon0"
        Me.lblKoncevikNaklon0.Size = New System.Drawing.Size(41, 18)
        Me.lblKoncevikNaklon0.TabIndex = 1
        Me.lblKoncevikNaklon0.Text = "Откл."
        Me.lblKoncevikNaklon0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAngle
        '
        Me.lblAngle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAngle.Location = New System.Drawing.Point(151, 22)
        Me.lblAngle.Name = "lblAngle"
        Me.lblAngle.Size = New System.Drawing.Size(41, 18)
        Me.lblAngle.TabIndex = 1
        Me.lblAngle.Text = "90"
        Me.lblAngle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(7, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Концевой выкл. 0°"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(7, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 18)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Угол наклона гасителя, °"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'COscill1
        '
        Me.COscill1.AxisBot = 40.0!
        Me.COscill1.AxisLeft = 60.0!
        Me.COscill1.AxisRight = 20.0!
        Me.COscill1.AxisTop = 40.0!
        Me.COscill1.BackgroundImage = CType(resources.GetObject("COscill1.BackgroundImage"), System.Drawing.Image)
        Me.COscill1.FontAxis = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.COscill1.FontPoint = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.COscill1.FontTitle = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.COscill1.GrafColor = System.Drawing.Color.Red
        Me.COscill1.Location = New System.Drawing.Point(0, 227)
        Me.COscill1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.COscill1.Name = "COscill1"
        Me.COscill1.PointHight = 6.0!
        Me.COscill1.PointSize = 4.0!
        Me.COscill1.Size = New System.Drawing.Size(787, 216)
        Me.COscill1.Smoothing = False
        Me.COscill1.StepX = 512.0!
        Me.COscill1.StepY = 1024.0!
        Me.COscill1.TabIndex = 3
        Me.COscill1.TextAxisX = "Время"
        Me.COscill1.TextAxisXoffset = 10.0!
        Me.COscill1.TextAxisY = "Перемещение/Усилие"
        Me.COscill1.TextAxisYoffset = 0.0!
        Me.COscill1.TextTitleOffset = 0.0!
        Me.COscill1.TitleText = "График перемещения штока от времени"
        Me.COscill1.Xmax = 2048.0!
        Me.COscill1.Xmin = 0.0!
        Me.COscill1.Ymax = 2048.0!
        Me.COscill1.Ymin = 0.0!
        '
        'tpProtokol
        '
        Me.tpProtokol.Controls.Add(Me.PrintView)
        Me.tpProtokol.Controls.Add(Me.tool)
        Me.tpProtokol.Location = New System.Drawing.Point(4, 54)
        Me.tpProtokol.Name = "tpProtokol"
        Me.tpProtokol.Padding = New System.Windows.Forms.Padding(3)
        Me.tpProtokol.Size = New System.Drawing.Size(792, 444)
        Me.tpProtokol.TabIndex = 1
        Me.tpProtokol.Text = "Протокол"
        Me.tpProtokol.UseVisualStyleBackColor = True
        '
        'PrintView
        '
        Me.PrintView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrintView.Location = New System.Drawing.Point(3, 28)
        Me.PrintView.Name = "PrintView"
        Me.PrintView.Rows = 3
        Me.PrintView.Size = New System.Drawing.Size(786, 413)
        Me.PrintView.TabIndex = 9
        '
        'tool
        '
        Me.tool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbtnPrint, Me.ToolStripLabel1, Me.tbtnZoom})
        Me.tool.Location = New System.Drawing.Point(3, 3)
        Me.tool.Name = "tool"
        Me.tool.Size = New System.Drawing.Size(786, 25)
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
        'tpBaza
        '
        Me.tpBaza.Controls.Add(Me.DataGridView1)
        Me.tpBaza.Controls.Add(Me.btnExit)
        Me.tpBaza.Controls.Add(Me.btnRemontEdit)
        Me.tpBaza.Controls.Add(Me.btnAppintmentEdit)
        Me.tpBaza.Controls.Add(Me.btnOperatorEdit)
        Me.tpBaza.Controls.Add(Me.btnApparatEdit)
        Me.tpBaza.Controls.Add(Me.btnProtokol)
        Me.tpBaza.Controls.Add(Me.btnOptions)
        Me.tpBaza.Location = New System.Drawing.Point(4, 54)
        Me.tpBaza.Name = "tpBaza"
        Me.tpBaza.Size = New System.Drawing.Size(792, 444)
        Me.tpBaza.TabIndex = 3
        Me.tpBaza.Text = "База данных"
        Me.tpBaza.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.NumDataGridViewTextBoxColumn, Me.DateTimeDataGridViewTextBoxColumn, Me.OperatorDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MainBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 20
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(588, 432)
        Me.DataGridView1.TabIndex = 9
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.FillWeight = 60.0!
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 60
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn.DataSource = Me.ApparatsBindingSource
        Me.TypeDataGridViewTextBoxColumn.DisplayMember = "Name"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Тип"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        Me.TypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.TypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.TypeDataGridViewTextBoxColumn.ValueMember = "ID"
        Me.TypeDataGridViewTextBoxColumn.Width = 64
        '
        'ApparatsBindingSource
        '
        Me.ApparatsBindingSource.DataMember = "Apparats"
        Me.ApparatsBindingSource.DataSource = Me.ds
        '
        'ds
        '
        Me.ds.DataSetName = "GidrogasitelDataSet"
        Me.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NumDataGridViewTextBoxColumn
        '
        Me.NumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.NumDataGridViewTextBoxColumn.DataPropertyName = "Num"
        Me.NumDataGridViewTextBoxColumn.HeaderText = "Номер"
        Me.NumDataGridViewTextBoxColumn.Name = "NumDataGridViewTextBoxColumn"
        Me.NumDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumDataGridViewTextBoxColumn.Width = 89
        '
        'DateTimeDataGridViewTextBoxColumn
        '
        Me.DateTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DateTimeDataGridViewTextBoxColumn.DataPropertyName = "_DateTime"
        Me.DateTimeDataGridViewTextBoxColumn.HeaderText = "Дата"
        Me.DateTimeDataGridViewTextBoxColumn.Name = "DateTimeDataGridViewTextBoxColumn"
        Me.DateTimeDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateTimeDataGridViewTextBoxColumn.Width = 77
        '
        'OperatorDataGridViewTextBoxColumn
        '
        Me.OperatorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.OperatorDataGridViewTextBoxColumn.DataPropertyName = "Operator"
        Me.OperatorDataGridViewTextBoxColumn.DataSource = Me.OperatorsBindingSource
        Me.OperatorDataGridViewTextBoxColumn.DisplayMember = "Last"
        Me.OperatorDataGridViewTextBoxColumn.HeaderText = "Испытатель"
        Me.OperatorDataGridViewTextBoxColumn.Name = "OperatorDataGridViewTextBoxColumn"
        Me.OperatorDataGridViewTextBoxColumn.ReadOnly = True
        Me.OperatorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.OperatorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.OperatorDataGridViewTextBoxColumn.ValueMember = "ID"
        '
        'OperatorsBindingSource
        '
        Me.OperatorsBindingSource.DataMember = "Operators"
        Me.OperatorsBindingSource.DataSource = Me.ds
        '
        'MainBindingSource
        '
        Me.MainBindingSource.DataMember = "main"
        Me.MainBindingSource.DataSource = Me.ds
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(599, 389)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(189, 55)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Завершить работу"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnRemontEdit
        '
        Me.btnRemontEdit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemontEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnRemontEdit.Image = CType(resources.GetObject("btnRemontEdit.Image"), System.Drawing.Image)
        Me.btnRemontEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemontEdit.Location = New System.Drawing.Point(599, 252)
        Me.btnRemontEdit.Name = "btnRemontEdit"
        Me.btnRemontEdit.Size = New System.Drawing.Size(189, 55)
        Me.btnRemontEdit.TabIndex = 5
        Me.btnRemontEdit.Text = "Ремонты"
        Me.btnRemontEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRemontEdit.UseVisualStyleBackColor = True
        '
        'btnAppintmentEdit
        '
        Me.btnAppintmentEdit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAppintmentEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnAppintmentEdit.Image = CType(resources.GetObject("btnAppintmentEdit.Image"), System.Drawing.Image)
        Me.btnAppintmentEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAppintmentEdit.Location = New System.Drawing.Point(599, 195)
        Me.btnAppintmentEdit.Name = "btnAppintmentEdit"
        Me.btnAppintmentEdit.Size = New System.Drawing.Size(189, 55)
        Me.btnAppintmentEdit.TabIndex = 5
        Me.btnAppintmentEdit.Text = "Должности"
        Me.btnAppintmentEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAppintmentEdit.UseVisualStyleBackColor = True
        '
        'btnOperatorEdit
        '
        Me.btnOperatorEdit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOperatorEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnOperatorEdit.Image = CType(resources.GetObject("btnOperatorEdit.Image"), System.Drawing.Image)
        Me.btnOperatorEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOperatorEdit.Location = New System.Drawing.Point(599, 138)
        Me.btnOperatorEdit.Name = "btnOperatorEdit"
        Me.btnOperatorEdit.Size = New System.Drawing.Size(189, 55)
        Me.btnOperatorEdit.TabIndex = 5
        Me.btnOperatorEdit.Text = "Испытатели"
        Me.btnOperatorEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOperatorEdit.UseVisualStyleBackColor = True
        '
        'btnApparatEdit
        '
        Me.btnApparatEdit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApparatEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnApparatEdit.Image = CType(resources.GetObject("btnApparatEdit.Image"), System.Drawing.Image)
        Me.btnApparatEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnApparatEdit.Location = New System.Drawing.Point(599, 81)
        Me.btnApparatEdit.Name = "btnApparatEdit"
        Me.btnApparatEdit.Size = New System.Drawing.Size(189, 55)
        Me.btnApparatEdit.TabIndex = 5
        Me.btnApparatEdit.Text = "Аппараты"
        Me.btnApparatEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnApparatEdit.UseVisualStyleBackColor = True
        '
        'btnProtokol
        '
        Me.btnProtokol.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProtokol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnProtokol.Image = CType(resources.GetObject("btnProtokol.Image"), System.Drawing.Image)
        Me.btnProtokol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProtokol.Location = New System.Drawing.Point(599, 4)
        Me.btnProtokol.Name = "btnProtokol"
        Me.btnProtokol.Size = New System.Drawing.Size(189, 55)
        Me.btnProtokol.TabIndex = 5
        Me.btnProtokol.Text = "Протокол из базы"
        Me.btnProtokol.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProtokol.UseVisualStyleBackColor = True
        '
        'btnOptions
        '
        Me.btnOptions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnOptions.Image = CType(resources.GetObject("btnOptions.Image"), System.Drawing.Image)
        Me.btnOptions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOptions.Location = New System.Drawing.Point(599, 310)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(189, 55)
        Me.btnOptions.TabIndex = 5
        Me.btnOptions.Text = "Настройки стенда"
        Me.btnOptions.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOptions.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnManage)
        Me.Panel2.Controls.Add(Me.chAvtoChecks)
        Me.Panel2.Controls.Add(Me.lblRemainingTime)
        Me.Panel2.Controls.Add(Me.lblElapsedTime)
        Me.Panel2.Controls.Add(Me.Label53)
        Me.Panel2.Controls.Add(Me.Label52)
        Me.Panel2.Controls.Add(Me.pgbTime)
        Me.Panel2.Controls.Add(Me.lblInfo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 502)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 98)
        Me.Panel2.TabIndex = 6
        '
        'btnManage
        '
        Me.btnManage.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnManage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnManage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnManage.Location = New System.Drawing.Point(1, 36)
        Me.btnManage.Name = "btnManage"
        Me.btnManage.Size = New System.Drawing.Size(234, 61)
        Me.btnManage.TabIndex = 11
        Me.btnManage.Text = "Выполнить выбранные проверки"
        Me.btnManage.UseVisualStyleBackColor = False
        '
        'chAvtoChecks
        '
        Me.chAvtoChecks.AutoSize = True
        Me.chAvtoChecks.Checked = True
        Me.chAvtoChecks.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chAvtoChecks.Location = New System.Drawing.Point(3, 6)
        Me.chAvtoChecks.Name = "chAvtoChecks"
        Me.chAvtoChecks.Size = New System.Drawing.Size(226, 17)
        Me.chAvtoChecks.TabIndex = 10
        Me.chAvtoChecks.Text = "Автоматическое выполнение проверок"
        Me.chAvtoChecks.UseVisualStyleBackColor = True
        '
        'lblRemainingTime
        '
        Me.lblRemainingTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRemainingTime.Location = New System.Drawing.Point(743, 7)
        Me.lblRemainingTime.Name = "lblRemainingTime"
        Me.lblRemainingTime.Size = New System.Drawing.Size(45, 13)
        Me.lblRemainingTime.TabIndex = 7
        '
        'lblElapsedTime
        '
        Me.lblElapsedTime.Location = New System.Drawing.Point(452, 7)
        Me.lblElapsedTime.Name = "lblElapsedTime"
        Me.lblElapsedTime.Size = New System.Drawing.Size(39, 13)
        Me.lblElapsedTime.TabIndex = 5
        '
        'Label53
        '
        Me.Label53.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(509, 7)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(234, 13)
        Me.Label53.TabIndex = 6
        Me.Label53.Text = "Осталось времени до окончания проверки - "
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(239, 7)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(206, 13)
        Me.Label52.TabIndex = 4
        Me.Label52.Text = "Прошло времени от начала проверки - "
        '
        'pgbTime
        '
        Me.pgbTime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgbTime.Location = New System.Drawing.Point(240, 27)
        Me.pgbTime.Name = "pgbTime"
        Me.pgbTime.Size = New System.Drawing.Size(557, 14)
        Me.pgbTime.TabIndex = 8
        '
        'lblInfo
        '
        Me.lblInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInfo.BackColor = System.Drawing.SystemColors.Info
        Me.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(241, 44)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(555, 50)
        Me.lblInfo.TabIndex = 9
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrintDialog
        '
        Me.PrintDialog.AllowPrintToFile = False
        Me.PrintDialog.UseEXDialog = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.ErrorImage = Nothing
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(30, 451)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.ErrorImage = Nothing
        Me.PictureBox3.InitialImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(14, 451)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(13, 416)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(201, 17)
        Me.CheckBox2.TabIndex = 8
        Me.CheckBox2.Text = "Автоматическое  управление"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TrackBar2)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.Button3)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(231, 10)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(200, 233)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Управление приводом"
        '
        'TrackBar2
        '
        Me.TrackBar2.LargeChange = 10
        Me.TrackBar2.Location = New System.Drawing.Point(6, 121)
        Me.TrackBar2.Maximum = 100
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(182, 45)
        Me.TrackBar2.TabIndex = 5
        Me.TrackBar2.TickFrequency = 10
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Location = New System.Drawing.Point(151, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 18)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "0"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(7, 100)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(181, 18)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Частота (заданная), Гц"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(7, 64)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(141, 18)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Частота (факт), Гц"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.Location = New System.Drawing.Point(151, 43)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(41, 18)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "0"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(7, 43)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(141, 18)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Ток, А"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.Location = New System.Drawing.Point(151, 22)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(41, 18)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "0"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(7, 22)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(141, 18)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Напряжение, В"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button3
        '
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.ImageIndex = 1
        Me.Button3.ImageList = Me.ImageList1
        Me.Button3.Location = New System.Drawing.Point(10, 192)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(182, 34)
        Me.Button3.TabIndex = 4
        Me.Button3.Tag = "0"
        Me.Button3.Text = "Включить привод"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Button8)
        Me.GroupBox6.Controls.Add(Me.Button9)
        Me.GroupBox6.Controls.Add(Me.Label24)
        Me.GroupBox6.Controls.Add(Me.Label25)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(14, 249)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(200, 133)
        Me.GroupBox6.TabIndex = 7
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Амплитуда работы гасителя"
        '
        'Button8
        '
        Me.Button8.Image = Global.Gidrogasitel.My.Resources.Resources.down
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(10, 94)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(182, 34)
        Me.Button8.TabIndex = 5
        Me.Button8.Tag = "0"
        Me.Button8.Text = "Уменьшить"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(10, 52)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(182, 34)
        Me.Button9.TabIndex = 5
        Me.Button9.Tag = "0"
        Me.Button9.Text = "Увеличить"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label24.Location = New System.Drawing.Point(151, 22)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(41, 18)
        Me.Label24.TabIndex = 1
        Me.Label24.Text = "90"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(7, 22)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(141, 18)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Амплитуда, мм"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Button10)
        Me.GroupBox7.Controls.Add(Me.Button11)
        Me.GroupBox7.Controls.Add(Me.Label26)
        Me.GroupBox7.Controls.Add(Me.Label27)
        Me.GroupBox7.Controls.Add(Me.Label28)
        Me.GroupBox7.Controls.Add(Me.Label29)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(14, 87)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(200, 156)
        Me.GroupBox7.TabIndex = 6
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Привод угла наклона"
        '
        'Button10
        '
        Me.Button10.Image = Global.Gidrogasitel.My.Resources.Resources.down
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.Location = New System.Drawing.Point(10, 116)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(182, 34)
        Me.Button10.TabIndex = 5
        Me.Button10.Tag = "0"
        Me.Button10.Text = "Опустить"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Image = CType(resources.GetObject("Button11.Image"), System.Drawing.Image)
        Me.Button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button11.Location = New System.Drawing.Point(10, 74)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(182, 34)
        Me.Button11.TabIndex = 5
        Me.Button11.Tag = "0"
        Me.Button11.Text = "Поднять"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label26.Location = New System.Drawing.Point(151, 43)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(41, 18)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "Откл."
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label27.Location = New System.Drawing.Point(151, 22)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(41, 18)
        Me.Label27.TabIndex = 1
        Me.Label27.Text = "90"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(7, 43)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(133, 18)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Концевой выключатель"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(7, 22)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(141, 18)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "Угол наклона гасителя, °"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label30)
        Me.GroupBox8.Controls.Add(Me.Label31)
        Me.GroupBox8.Controls.Add(Me.Label32)
        Me.GroupBox8.Controls.Add(Me.Label33)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(14, 10)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(200, 67)
        Me.GroupBox8.TabIndex = 5
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Температура"
        '
        'Label30
        '
        Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label30.Location = New System.Drawing.Point(151, 43)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(41, 18)
        Me.Label30.TabIndex = 1
        Me.Label30.Text = "20"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label31.Location = New System.Drawing.Point(151, 22)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(41, 18)
        Me.Label31.TabIndex = 1
        Me.Label31.Text = "20"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(7, 43)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(133, 18)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "гидрогасителя, °С"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(7, 22)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(133, 18)
        Me.Label33.TabIndex = 0
        Me.Label33.Text = "окружающей среды, °С"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'COscill2
        '
        Me.COscill2.AxisBot = 40.0!
        Me.COscill2.AxisLeft = 60.0!
        Me.COscill2.AxisRight = 20.0!
        Me.COscill2.AxisTop = 40.0!
        Me.COscill2.BackgroundImage = CType(resources.GetObject("COscill2.BackgroundImage"), System.Drawing.Image)
        Me.COscill2.FontAxis = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.COscill2.FontPoint = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.COscill2.FontTitle = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.COscill2.GrafColor = System.Drawing.Color.Red
        Me.COscill2.Location = New System.Drawing.Point(232, 249)
        Me.COscill2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.COscill2.Name = "COscill2"
        Me.COscill2.PointHight = 6.0!
        Me.COscill2.PointSize = 4.0!
        Me.COscill2.Size = New System.Drawing.Size(503, 215)
        Me.COscill2.Smoothing = False
        Me.COscill2.StepX = 512.0!
        Me.COscill2.StepY = 1024.0!
        Me.COscill2.TabIndex = 3
        Me.COscill2.TextAxisX = "Время"
        Me.COscill2.TextAxisXoffset = 10.0!
        Me.COscill2.TextAxisY = "Перемещение/Усилие"
        Me.COscill2.TextAxisYoffset = 0.0!
        Me.COscill2.TextTitleOffset = 0.0!
        Me.COscill2.TitleText = "График перемещения штока от времени"
        Me.COscill2.Xmax = 6144.0!
        Me.COscill2.Xmin = 0.0!
        Me.COscill2.Ymax = 8192.0!
        Me.COscill2.Ymin = 0.0!
        '
        'frmGMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frmGMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Гидрогаситель"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.tpList.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.tpStend.ResumeLayout(False)
        Me.tpStend.PerformLayout()
        CType(Me.numFilter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.KM16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KM15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KM14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KM13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KM12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KM11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KM10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KM9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KM8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KM7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KM6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KM5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KM4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KM3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KM2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KM1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPrivod.ResumeLayout(False)
        Me.gbPrivod.PerformLayout()
        CType(Me.nudFmax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trFzad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAmpl.ResumeLayout(False)
        Me.gbAngle.ResumeLayout(False)
        Me.tpProtokol.ResumeLayout(False)
        Me.tpProtokol.PerformLayout()
        Me.tool.ResumeLayout(False)
        Me.tool.PerformLayout()
        Me.tpBaza.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApparatsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OperatorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tpStend As System.Windows.Forms.TabPage
    Friend WithEvents tpProtokol As System.Windows.Forms.TabPage
    Friend WithEvents PrintView As System.Windows.Forms.PrintPreviewControl
    Friend WithEvents tool As System.Windows.Forms.ToolStrip
    Friend WithEvents tbtnPrint As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents sbtnPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sbtnSelPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sbtnSelPage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tbtnZoom As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents chAvtoChecks As System.Windows.Forms.CheckBox
    Friend WithEvents lblRemainingTime As System.Windows.Forms.Label
    Friend WithEvents lblElapsedTime As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents pgbTime As System.Windows.Forms.ProgressBar
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents COscill1 As pOscill.cOscill
    Friend WithEvents PrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents PageSetupDialog As System.Windows.Forms.PageSetupDialog
    Friend WithEvents btnSbor As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTgidro As System.Windows.Forms.Label
    Friend WithEvents lblTos As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gbAngle As System.Windows.Forms.GroupBox
    Friend WithEvents lblAngle As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnAngleDown As System.Windows.Forms.Button
    Friend WithEvents btnAngleUp As System.Windows.Forms.Button
    Friend WithEvents gbAmpl As System.Windows.Forms.GroupBox
    Friend WithEvents btnAmplitudeDown As System.Windows.Forms.Button
    Friend WithEvents btnAmplitudeUp As System.Windows.Forms.Button
    Friend WithEvents lblAmpl As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents gbPrivod As System.Windows.Forms.GroupBox
    Friend WithEvents lblUp As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblFp As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblIp As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents chAvto As System.Windows.Forms.CheckBox
    Friend WithEvents trFzad As System.Windows.Forms.TrackBar
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents KM1 As System.Windows.Forms.PictureBox
    Friend WithEvents KM3 As System.Windows.Forms.PictureBox
    Friend WithEvents KM2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TrackBar2 As System.Windows.Forms.TrackBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents COscill2 As pOscill.cOscill
    Friend WithEvents KM8 As System.Windows.Forms.PictureBox
    Friend WithEvents KM7 As System.Windows.Forms.PictureBox
    Friend WithEvents KM6 As System.Windows.Forms.PictureBox
    Friend WithEvents KM5 As System.Windows.Forms.PictureBox
    Friend WithEvents KM4 As System.Windows.Forms.PictureBox
    Friend WithEvents nudFmax As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblFmax As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblKoncevikAmplitude As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents lblKoncevikNaklon0 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents KM16 As System.Windows.Forms.PictureBox
    Friend WithEvents KM15 As System.Windows.Forms.PictureBox
    Friend WithEvents KM14 As System.Windows.Forms.PictureBox
    Friend WithEvents KM13 As System.Windows.Forms.PictureBox
    Friend WithEvents KM12 As System.Windows.Forms.PictureBox
    Friend WithEvents KM11 As System.Windows.Forms.PictureBox
    Friend WithEvents KM10 As System.Windows.Forms.PictureBox
    Friend WithEvents KM9 As System.Windows.Forms.PictureBox
    Friend WithEvents btnManage As System.Windows.Forms.Button
    Friend WithEvents tpList As System.Windows.Forms.TabPage
    Friend WithEvents TreeViewEx1 As clTreeView.TreeViewEx
    Friend WithEvents btnNewCheck As System.Windows.Forms.Button
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents tpBaza As System.Windows.Forms.TabPage
    Friend WithEvents btnOptions As System.Windows.Forms.Button
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmbTypeRemonta As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTypeTD As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAppointment As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOperator As System.Windows.Forms.ComboBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnProtokol As System.Windows.Forms.Button
    Friend WithEvents btnRemontEdit As System.Windows.Forms.Button
    Friend WithEvents btnAppintmentEdit As System.Windows.Forms.Button
    Friend WithEvents btnOperatorEdit As System.Windows.Forms.Button
    Friend WithEvents btnApparatEdit As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MainBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ApparatsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OperatorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ds As Gidrogasitel.GidrogasitelDataSet
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents NumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OperatorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents lblKoncevikNaklon90 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents chFiltr As System.Windows.Forms.CheckBox
    Friend WithEvents numFilter As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents lblBsjat As System.Windows.Forms.Label
    Friend WithEvents lblBrast As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents lblV As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblV2 As System.Windows.Forms.Label
End Class
