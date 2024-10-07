<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApparats
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
        Me.cmbName = New System.Windows.Forms.ComboBox()
        Me.AsBSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ds = New Gidrogasitel.GidrogasitelDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudS1 = New System.Windows.Forms.NumericUpDown()
        Me.pnlSpeed1 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nudSymetr1 = New System.Windows.Forms.NumericUpDown()
        Me.nudBdec = New System.Windows.Forms.NumericUpDown()
        Me.nudBinc1 = New System.Windows.Forms.NumericUpDown()
        Me.nudPdec1 = New System.Windows.Forms.NumericUpDown()
        Me.nudPinc1 = New System.Windows.Forms.NumericUpDown()
        Me.nudE1 = New System.Windows.Forms.NumericUpDown()
        Me.nudFmax1 = New System.Windows.Forms.NumericUpDown()
        Me.nudF1 = New System.Windows.Forms.NumericUpDown()
        Me.nudAngle1 = New System.Windows.Forms.NumericUpDown()
        Me.nudA1 = New System.Windows.Forms.NumericUpDown()
        Me.nudT1 = New System.Windows.Forms.NumericUpDown()
        Me.chSpeed1 = New System.Windows.Forms.CheckBox()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.ApparatTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.chSpeed2 = New System.Windows.Forms.CheckBox()
        Me.pnlSpeed2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.nudSymetr2 = New System.Windows.Forms.NumericUpDown()
        Me.nudBdec2 = New System.Windows.Forms.NumericUpDown()
        Me.nudBinc2 = New System.Windows.Forms.NumericUpDown()
        Me.nudPdec2 = New System.Windows.Forms.NumericUpDown()
        Me.nudPinc2 = New System.Windows.Forms.NumericUpDown()
        Me.nudE2 = New System.Windows.Forms.NumericUpDown()
        Me.nudFmax2 = New System.Windows.Forms.NumericUpDown()
        Me.nudF2 = New System.Windows.Forms.NumericUpDown()
        Me.nudAngle2 = New System.Windows.Forms.NumericUpDown()
        Me.nudA2 = New System.Windows.Forms.NumericUpDown()
        Me.nudT2 = New System.Windows.Forms.NumericUpDown()
        Me.nudS2 = New System.Windows.Forms.NumericUpDown()
        Me.chSpeed3 = New System.Windows.Forms.CheckBox()
        Me.pnlSpeed3 = New System.Windows.Forms.GroupBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.nudSymetr3 = New System.Windows.Forms.NumericUpDown()
        Me.nudBdec3 = New System.Windows.Forms.NumericUpDown()
        Me.nudBinc3 = New System.Windows.Forms.NumericUpDown()
        Me.nudPdec3 = New System.Windows.Forms.NumericUpDown()
        Me.nudPinc3 = New System.Windows.Forms.NumericUpDown()
        Me.nudE3 = New System.Windows.Forms.NumericUpDown()
        Me.nudFmax3 = New System.Windows.Forms.NumericUpDown()
        Me.nudF3 = New System.Windows.Forms.NumericUpDown()
        Me.nudAngle3 = New System.Windows.Forms.NumericUpDown()
        Me.nudA3 = New System.Windows.Forms.NumericUpDown()
        Me.nudT3 = New System.Windows.Forms.NumericUpDown()
        Me.nudS3 = New System.Windows.Forms.NumericUpDown()
        Me.chSpeed4 = New System.Windows.Forms.CheckBox()
        Me.pnlSpeed4 = New System.Windows.Forms.GroupBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.nudSymetr4 = New System.Windows.Forms.NumericUpDown()
        Me.nudBdec4 = New System.Windows.Forms.NumericUpDown()
        Me.nudBinc4 = New System.Windows.Forms.NumericUpDown()
        Me.nudPdec4 = New System.Windows.Forms.NumericUpDown()
        Me.nudPinc4 = New System.Windows.Forms.NumericUpDown()
        Me.nudE4 = New System.Windows.Forms.NumericUpDown()
        Me.nudFmax4 = New System.Windows.Forms.NumericUpDown()
        Me.nudF4 = New System.Windows.Forms.NumericUpDown()
        Me.nudAngle4 = New System.Windows.Forms.NumericUpDown()
        Me.nudA4 = New System.Windows.Forms.NumericUpDown()
        Me.nudT4 = New System.Windows.Forms.NumericUpDown()
        Me.nudS4 = New System.Windows.Forms.NumericUpDown()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.pnlProkachka = New System.Windows.Forms.GroupBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.nudFmaxProkachka = New System.Windows.Forms.NumericUpDown()
        Me.nudFprivod = New System.Windows.Forms.NumericUpDown()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.nudSpeedProkachka = New System.Windows.Forms.NumericUpDown()
        Me.nudTimeProkachka = New System.Windows.Forms.NumericUpDown()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.nudAmplitudeProkachka = New System.Windows.Forms.NumericUpDown()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.nudAngleProkachka = New System.Windows.Forms.NumericUpDown()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.chProkachka = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lblbl = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.nudDTMin = New System.Windows.Forms.NumericUpDown()
        Me.nudDT80 = New System.Windows.Forms.NumericUpDown()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.nudDVmax = New System.Windows.Forms.NumericUpDown()
        Me.nudD40 = New System.Windows.Forms.NumericUpDown()
        Me.btnEditNameGasitel = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.AsBSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudS1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSpeed1.SuspendLayout()
        CType(Me.nudSymetr1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBdec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBinc1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPdec1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPinc1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudE1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFmax1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudF1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAngle1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudA1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudT1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApparatTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSpeed2.SuspendLayout()
        CType(Me.nudSymetr2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBdec2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBinc2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPdec2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPinc2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudE2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFmax2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudF2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAngle2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudA2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudT2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudS2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSpeed3.SuspendLayout()
        CType(Me.nudSymetr3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBdec3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBinc3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPdec3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPinc3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudE3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFmax3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudF3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAngle3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudA3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudT3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudS3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSpeed4.SuspendLayout()
        CType(Me.nudSymetr4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBdec4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBinc4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPdec4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPinc4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudE4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFmax4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudF4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAngle4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudA4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudT4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudS4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlProkachka.SuspendLayout()
        CType(Me.nudFmaxProkachka, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFprivod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSpeedProkachka, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTimeProkachka, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAmplitudeProkachka, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAngleProkachka, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.nudDTMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDT80, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDVmax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudD40, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbName
        '
        Me.cmbName.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.AsBSource, "ID", True))
        Me.cmbName.DataSource = Me.AsBSource
        Me.cmbName.DisplayMember = "Name"
        Me.cmbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbName.FormattingEnabled = True
        Me.cmbName.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.cmbName.Location = New System.Drawing.Point(109, 6)
        Me.cmbName.Name = "cmbName"
        Me.cmbName.Size = New System.Drawing.Size(140, 21)
        Me.cmbName.TabIndex = 0
        '
        'AsBSource
        '
        Me.AsBSource.DataMember = "Apparats"
        Me.AsBSource.DataSource = Me.ds
        '
        'ds
        '
        Me.ds.DataSetName = "GidrogasitelDataSet"
        Me.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Гидрогаситель"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Скорость, м/c"
        '
        'nudS1
        '
        Me.nudS1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudS1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "S1_Speed1", True))
        Me.nudS1.DecimalPlaces = 3
        Me.nudS1.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nudS1.Location = New System.Drawing.Point(124, 21)
        Me.nudS1.Maximum = New Decimal(New Integer() {6, 0, 0, 65536})
        Me.nudS1.Minimum = New Decimal(New Integer() {2, 0, 0, 131072})
        Me.nudS1.Name = "nudS1"
        Me.nudS1.Size = New System.Drawing.Size(53, 20)
        Me.nudS1.TabIndex = 2
        Me.nudS1.Value = New Decimal(New Integer() {2, 0, 0, 131072})
        '
        'pnlSpeed1
        '
        Me.pnlSpeed1.Controls.Add(Me.Label15)
        Me.pnlSpeed1.Controls.Add(Me.Label14)
        Me.pnlSpeed1.Controls.Add(Me.Label13)
        Me.pnlSpeed1.Controls.Add(Me.Label12)
        Me.pnlSpeed1.Controls.Add(Me.Label11)
        Me.pnlSpeed1.Controls.Add(Me.Label10)
        Me.pnlSpeed1.Controls.Add(Me.Label9)
        Me.pnlSpeed1.Controls.Add(Me.Label8)
        Me.pnlSpeed1.Controls.Add(Me.Label7)
        Me.pnlSpeed1.Controls.Add(Me.Label6)
        Me.pnlSpeed1.Controls.Add(Me.Label5)
        Me.pnlSpeed1.Controls.Add(Me.Label2)
        Me.pnlSpeed1.Controls.Add(Me.nudSymetr1)
        Me.pnlSpeed1.Controls.Add(Me.nudBdec)
        Me.pnlSpeed1.Controls.Add(Me.nudBinc1)
        Me.pnlSpeed1.Controls.Add(Me.nudPdec1)
        Me.pnlSpeed1.Controls.Add(Me.nudPinc1)
        Me.pnlSpeed1.Controls.Add(Me.nudE1)
        Me.pnlSpeed1.Controls.Add(Me.nudFmax1)
        Me.pnlSpeed1.Controls.Add(Me.nudF1)
        Me.pnlSpeed1.Controls.Add(Me.nudAngle1)
        Me.pnlSpeed1.Controls.Add(Me.nudA1)
        Me.pnlSpeed1.Controls.Add(Me.nudT1)
        Me.pnlSpeed1.Controls.Add(Me.nudS1)
        Me.pnlSpeed1.Location = New System.Drawing.Point(8, 60)
        Me.pnlSpeed1.Name = "pnlSpeed1"
        Me.pnlSpeed1.Size = New System.Drawing.Size(180, 279)
        Me.pnlSpeed1.TabIndex = 3
        Me.pnlSpeed1.TabStop = False
        Me.pnlSpeed1.Text = "Параметры на 1-ой скорости"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(4, 257)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(117, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Симметричность B, %"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(4, 235)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(102, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "B (раст.),  кН/(м/c)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(4, 214)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(113, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "B (сжатие),  кН/(м/c)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(4, 193)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Fmax, при раст., кН"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 172)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Fmax при сжатии, кН"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 151)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Энергоемкость, Дж"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = " Fмакс привода, Гц"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Частота привода, Гц"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Угол, град"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Ход, мм"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Время проверки, с"
        '
        'nudSymetr1
        '
        Me.nudSymetr1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudSymetr1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "Symmetry_s1", True))
        Me.nudSymetr1.DecimalPlaces = 2
        Me.nudSymetr1.Location = New System.Drawing.Point(124, 252)
        Me.nudSymetr1.Name = "nudSymetr1"
        Me.nudSymetr1.Size = New System.Drawing.Size(53, 20)
        Me.nudSymetr1.TabIndex = 2
        '
        'nudBdec
        '
        Me.nudBdec.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudBdec.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "B_dec_s1", True))
        Me.nudBdec.DecimalPlaces = 2
        Me.nudBdec.Location = New System.Drawing.Point(124, 231)
        Me.nudBdec.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudBdec.Name = "nudBdec"
        Me.nudBdec.Size = New System.Drawing.Size(53, 20)
        Me.nudBdec.TabIndex = 2
        '
        'nudBinc1
        '
        Me.nudBinc1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudBinc1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "B_inc_s1", True))
        Me.nudBinc1.DecimalPlaces = 2
        Me.nudBinc1.Location = New System.Drawing.Point(124, 210)
        Me.nudBinc1.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudBinc1.Name = "nudBinc1"
        Me.nudBinc1.Size = New System.Drawing.Size(53, 20)
        Me.nudBinc1.TabIndex = 2
        '
        'nudPdec1
        '
        Me.nudPdec1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudPdec1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "P_dec_s1", True))
        Me.nudPdec1.DecimalPlaces = 2
        Me.nudPdec1.Location = New System.Drawing.Point(124, 189)
        Me.nudPdec1.Name = "nudPdec1"
        Me.nudPdec1.Size = New System.Drawing.Size(53, 20)
        Me.nudPdec1.TabIndex = 2
        '
        'nudPinc1
        '
        Me.nudPinc1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudPinc1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "P_inc_s1", True))
        Me.nudPinc1.DecimalPlaces = 2
        Me.nudPinc1.Location = New System.Drawing.Point(124, 168)
        Me.nudPinc1.Name = "nudPinc1"
        Me.nudPinc1.Size = New System.Drawing.Size(53, 20)
        Me.nudPinc1.TabIndex = 2
        '
        'nudE1
        '
        Me.nudE1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudE1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "E_s1", True))
        Me.nudE1.DecimalPlaces = 1
        Me.nudE1.Location = New System.Drawing.Point(124, 147)
        Me.nudE1.Maximum = New Decimal(New Integer() {60000, 0, 0, 0})
        Me.nudE1.Name = "nudE1"
        Me.nudE1.Size = New System.Drawing.Size(53, 20)
        Me.nudE1.TabIndex = 2
        '
        'nudFmax1
        '
        Me.nudFmax1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudFmax1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "S1_MotorSpeedMax", True))
        Me.nudFmax1.DecimalPlaces = 1
        Me.nudFmax1.Enabled = False
        Me.nudFmax1.Location = New System.Drawing.Point(124, 126)
        Me.nudFmax1.Maximum = New Decimal(New Integer() {65, 0, 0, 0})
        Me.nudFmax1.Name = "nudFmax1"
        Me.nudFmax1.Size = New System.Drawing.Size(53, 20)
        Me.nudFmax1.TabIndex = 2
        '
        'nudF1
        '
        Me.nudF1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudF1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "S1_MotorSpeed", True))
        Me.nudF1.DecimalPlaces = 1
        Me.nudF1.Enabled = False
        Me.nudF1.Location = New System.Drawing.Point(124, 105)
        Me.nudF1.Maximum = New Decimal(New Integer() {65, 0, 0, 0})
        Me.nudF1.Name = "nudF1"
        Me.nudF1.Size = New System.Drawing.Size(53, 20)
        Me.nudF1.TabIndex = 2
        '
        'nudAngle1
        '
        Me.nudAngle1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudAngle1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "S1_Angle", True))
        Me.nudAngle1.Location = New System.Drawing.Point(124, 84)
        Me.nudAngle1.Maximum = New Decimal(New Integer() {600, 0, 0, 0})
        Me.nudAngle1.Name = "nudAngle1"
        Me.nudAngle1.Size = New System.Drawing.Size(53, 20)
        Me.nudAngle1.TabIndex = 2
        '
        'nudA1
        '
        Me.nudA1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudA1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "S1_Ampl", True))
        Me.nudA1.Location = New System.Drawing.Point(124, 63)
        Me.nudA1.Maximum = New Decimal(New Integer() {600, 0, 0, 0})
        Me.nudA1.Name = "nudA1"
        Me.nudA1.Size = New System.Drawing.Size(53, 20)
        Me.nudA1.TabIndex = 2
        '
        'nudT1
        '
        Me.nudT1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudT1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "S1_Time", True))
        Me.nudT1.Location = New System.Drawing.Point(124, 42)
        Me.nudT1.Maximum = New Decimal(New Integer() {3600, 0, 0, 0})
        Me.nudT1.Name = "nudT1"
        Me.nudT1.Size = New System.Drawing.Size(53, 20)
        Me.nudT1.TabIndex = 2
        '
        'chSpeed1
        '
        Me.chSpeed1.AutoSize = True
        Me.chSpeed1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.AsBSource, "Check_s1", True))
        Me.chSpeed1.Location = New System.Drawing.Point(11, 35)
        Me.chSpeed1.Name = "chSpeed1"
        Me.chSpeed1.Size = New System.Drawing.Size(151, 17)
        Me.chSpeed1.TabIndex = 4
        Me.chSpeed1.Text = "Работа на 1-ой скорости"
        Me.chSpeed1.UseVisualStyleBackColor = True
        '
        'cmbType
        '
        Me.cmbType.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.ApparatTypeBindingSource, "ID", True))
        Me.cmbType.DataSource = Me.ApparatTypeBindingSource
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Location = New System.Drawing.Point(329, 6)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(58, 21)
        Me.cmbType.TabIndex = 0
        '
        'ApparatTypeBindingSource
        '
        Me.ApparatTypeBindingSource.DataMember = "ApparatType"
        Me.ApparatTypeBindingSource.DataSource = Me.ds
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(297, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Тип"
        '
        'lbl
        '
        Me.lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(668, 11)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(24, 13)
        Me.lbl.TabIndex = 6
        Me.lbl.Text = "ID -"
        '
        'txtId
        '
        Me.txtId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsBSource, "ID", True))
        Me.txtId.Location = New System.Drawing.Point(698, 7)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(56, 20)
        Me.txtId.TabIndex = 7
        '
        'chSpeed2
        '
        Me.chSpeed2.AutoSize = True
        Me.chSpeed2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.AsBSource, "Check_s2", True))
        Me.chSpeed2.Location = New System.Drawing.Point(200, 35)
        Me.chSpeed2.Name = "chSpeed2"
        Me.chSpeed2.Size = New System.Drawing.Size(151, 17)
        Me.chSpeed2.TabIndex = 9
        Me.chSpeed2.Text = "Работа на 2-ой скорости"
        Me.chSpeed2.UseVisualStyleBackColor = True
        '
        'pnlSpeed2
        '
        Me.pnlSpeed2.Controls.Add(Me.Label4)
        Me.pnlSpeed2.Controls.Add(Me.Label16)
        Me.pnlSpeed2.Controls.Add(Me.Label17)
        Me.pnlSpeed2.Controls.Add(Me.Label18)
        Me.pnlSpeed2.Controls.Add(Me.Label19)
        Me.pnlSpeed2.Controls.Add(Me.Label20)
        Me.pnlSpeed2.Controls.Add(Me.Label21)
        Me.pnlSpeed2.Controls.Add(Me.Label22)
        Me.pnlSpeed2.Controls.Add(Me.Label23)
        Me.pnlSpeed2.Controls.Add(Me.Label24)
        Me.pnlSpeed2.Controls.Add(Me.Label25)
        Me.pnlSpeed2.Controls.Add(Me.Label26)
        Me.pnlSpeed2.Controls.Add(Me.nudSymetr2)
        Me.pnlSpeed2.Controls.Add(Me.nudBdec2)
        Me.pnlSpeed2.Controls.Add(Me.nudBinc2)
        Me.pnlSpeed2.Controls.Add(Me.nudPdec2)
        Me.pnlSpeed2.Controls.Add(Me.nudPinc2)
        Me.pnlSpeed2.Controls.Add(Me.nudE2)
        Me.pnlSpeed2.Controls.Add(Me.nudFmax2)
        Me.pnlSpeed2.Controls.Add(Me.nudF2)
        Me.pnlSpeed2.Controls.Add(Me.nudAngle2)
        Me.pnlSpeed2.Controls.Add(Me.nudA2)
        Me.pnlSpeed2.Controls.Add(Me.nudT2)
        Me.pnlSpeed2.Controls.Add(Me.nudS2)
        Me.pnlSpeed2.Location = New System.Drawing.Point(197, 60)
        Me.pnlSpeed2.Name = "pnlSpeed2"
        Me.pnlSpeed2.Size = New System.Drawing.Size(180, 279)
        Me.pnlSpeed2.TabIndex = 8
        Me.pnlSpeed2.TabStop = False
        Me.pnlSpeed2.Text = "Параметры на 2-ой скорости"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Симметричность B, %"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(4, 235)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(102, 13)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "B (раст.),  кН/(м/c)"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(4, 214)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(113, 13)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "B (сжатие),  кН/(м/c)"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(4, 193)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(105, 13)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "Fmax, при раст., кН"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(4, 172)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(113, 13)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Fmax при сжатии, кН"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(4, 149)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(109, 13)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Энергоемкость, Дж"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(4, 128)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(105, 13)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = " Fмакс привода, Гц"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(4, 107)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(112, 13)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "Частота привода, Гц"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(4, 86)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(61, 13)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "Угол, град"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(4, 65)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(48, 13)
        Me.Label24.TabIndex = 1
        Me.Label24.Text = "Ход, мм"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(4, 44)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(115, 13)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "Время проверки, сек"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(4, 23)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(80, 13)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "Скорость, м/c"
        '
        'nudSymetr2
        '
        Me.nudSymetr2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudSymetr2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "Symmetry_s2", True))
        Me.nudSymetr2.DecimalPlaces = 2
        Me.nudSymetr2.Location = New System.Drawing.Point(124, 252)
        Me.nudSymetr2.Name = "nudSymetr2"
        Me.nudSymetr2.Size = New System.Drawing.Size(53, 20)
        Me.nudSymetr2.TabIndex = 2
        '
        'nudBdec2
        '
        Me.nudBdec2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudBdec2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "B_dec_s2", True))
        Me.nudBdec2.DecimalPlaces = 2
        Me.nudBdec2.Location = New System.Drawing.Point(124, 231)
        Me.nudBdec2.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudBdec2.Name = "nudBdec2"
        Me.nudBdec2.Size = New System.Drawing.Size(53, 20)
        Me.nudBdec2.TabIndex = 2
        '
        'nudBinc2
        '
        Me.nudBinc2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudBinc2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "B_inc_s2", True))
        Me.nudBinc2.DecimalPlaces = 2
        Me.nudBinc2.Location = New System.Drawing.Point(124, 210)
        Me.nudBinc2.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudBinc2.Name = "nudBinc2"
        Me.nudBinc2.Size = New System.Drawing.Size(53, 20)
        Me.nudBinc2.TabIndex = 2
        '
        'nudPdec2
        '
        Me.nudPdec2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudPdec2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "P_dec_s2", True))
        Me.nudPdec2.DecimalPlaces = 2
        Me.nudPdec2.Location = New System.Drawing.Point(124, 189)
        Me.nudPdec2.Name = "nudPdec2"
        Me.nudPdec2.Size = New System.Drawing.Size(53, 20)
        Me.nudPdec2.TabIndex = 2
        '
        'nudPinc2
        '
        Me.nudPinc2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudPinc2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "P_inc_s2", True))
        Me.nudPinc2.DecimalPlaces = 2
        Me.nudPinc2.Location = New System.Drawing.Point(124, 168)
        Me.nudPinc2.Name = "nudPinc2"
        Me.nudPinc2.Size = New System.Drawing.Size(53, 20)
        Me.nudPinc2.TabIndex = 2
        '
        'nudE2
        '
        Me.nudE2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudE2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "E_s2", True))
        Me.nudE2.DecimalPlaces = 1
        Me.nudE2.Location = New System.Drawing.Point(124, 147)
        Me.nudE2.Maximum = New Decimal(New Integer() {60000, 0, 0, 0})
        Me.nudE2.Name = "nudE2"
        Me.nudE2.Size = New System.Drawing.Size(53, 20)
        Me.nudE2.TabIndex = 2
        '
        'nudFmax2
        '
        Me.nudFmax2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudFmax2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "S2_MotorSpeedMax", True))
        Me.nudFmax2.DecimalPlaces = 1
        Me.nudFmax2.Enabled = False
        Me.nudFmax2.Location = New System.Drawing.Point(124, 126)
        Me.nudFmax2.Maximum = New Decimal(New Integer() {65, 0, 0, 0})
        Me.nudFmax2.Name = "nudFmax2"
        Me.nudFmax2.Size = New System.Drawing.Size(53, 20)
        Me.nudFmax2.TabIndex = 2
        '
        'nudF2
        '
        Me.nudF2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudF2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "S2_MotorSpeed", True))
        Me.nudF2.DecimalPlaces = 1
        Me.nudF2.Enabled = False
        Me.nudF2.Location = New System.Drawing.Point(124, 105)
        Me.nudF2.Maximum = New Decimal(New Integer() {65, 0, 0, 0})
        Me.nudF2.Name = "nudF2"
        Me.nudF2.Size = New System.Drawing.Size(53, 20)
        Me.nudF2.TabIndex = 2
        '
        'nudAngle2
        '
        Me.nudAngle2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudAngle2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "S2_Angle", True))
        Me.nudAngle2.Location = New System.Drawing.Point(124, 84)
        Me.nudAngle2.Maximum = New Decimal(New Integer() {600, 0, 0, 0})
        Me.nudAngle2.Name = "nudAngle2"
        Me.nudAngle2.Size = New System.Drawing.Size(53, 20)
        Me.nudAngle2.TabIndex = 2
        '
        'nudA2
        '
        Me.nudA2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudA2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "S2_Ampl", True))
        Me.nudA2.Location = New System.Drawing.Point(124, 63)
        Me.nudA2.Maximum = New Decimal(New Integer() {600, 0, 0, 0})
        Me.nudA2.Name = "nudA2"
        Me.nudA2.Size = New System.Drawing.Size(53, 20)
        Me.nudA2.TabIndex = 2
        '
        'nudT2
        '
        Me.nudT2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudT2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "S2_Time", True))
        Me.nudT2.Location = New System.Drawing.Point(124, 42)
        Me.nudT2.Maximum = New Decimal(New Integer() {3600, 0, 0, 0})
        Me.nudT2.Name = "nudT2"
        Me.nudT2.Size = New System.Drawing.Size(53, 20)
        Me.nudT2.TabIndex = 2
        '
        'nudS2
        '
        Me.nudS2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudS2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "S2_Speed2", True))
        Me.nudS2.DecimalPlaces = 3
        Me.nudS2.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nudS2.Location = New System.Drawing.Point(124, 21)
        Me.nudS2.Maximum = New Decimal(New Integer() {6, 0, 0, 65536})
        Me.nudS2.Minimum = New Decimal(New Integer() {2, 0, 0, 131072})
        Me.nudS2.Name = "nudS2"
        Me.nudS2.Size = New System.Drawing.Size(53, 20)
        Me.nudS2.TabIndex = 2
        Me.nudS2.Value = New Decimal(New Integer() {2, 0, 0, 131072})
        '
        'chSpeed3
        '
        Me.chSpeed3.AutoSize = True
        Me.chSpeed3.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.AsBSource, "Check_s3", True))
        Me.chSpeed3.Location = New System.Drawing.Point(389, 35)
        Me.chSpeed3.Name = "chSpeed3"
        Me.chSpeed3.Size = New System.Drawing.Size(151, 17)
        Me.chSpeed3.TabIndex = 11
        Me.chSpeed3.Text = "Работа на 3-ой скорости"
        Me.chSpeed3.UseVisualStyleBackColor = True
        '
        'pnlSpeed3
        '
        Me.pnlSpeed3.Controls.Add(Me.Label27)
        Me.pnlSpeed3.Controls.Add(Me.Label28)
        Me.pnlSpeed3.Controls.Add(Me.Label29)
        Me.pnlSpeed3.Controls.Add(Me.Label30)
        Me.pnlSpeed3.Controls.Add(Me.Label31)
        Me.pnlSpeed3.Controls.Add(Me.Label32)
        Me.pnlSpeed3.Controls.Add(Me.Label33)
        Me.pnlSpeed3.Controls.Add(Me.Label34)
        Me.pnlSpeed3.Controls.Add(Me.Label35)
        Me.pnlSpeed3.Controls.Add(Me.Label36)
        Me.pnlSpeed3.Controls.Add(Me.Label37)
        Me.pnlSpeed3.Controls.Add(Me.Label38)
        Me.pnlSpeed3.Controls.Add(Me.nudSymetr3)
        Me.pnlSpeed3.Controls.Add(Me.nudBdec3)
        Me.pnlSpeed3.Controls.Add(Me.nudBinc3)
        Me.pnlSpeed3.Controls.Add(Me.nudPdec3)
        Me.pnlSpeed3.Controls.Add(Me.nudPinc3)
        Me.pnlSpeed3.Controls.Add(Me.nudE3)
        Me.pnlSpeed3.Controls.Add(Me.nudFmax3)
        Me.pnlSpeed3.Controls.Add(Me.nudF3)
        Me.pnlSpeed3.Controls.Add(Me.nudAngle3)
        Me.pnlSpeed3.Controls.Add(Me.nudA3)
        Me.pnlSpeed3.Controls.Add(Me.nudT3)
        Me.pnlSpeed3.Controls.Add(Me.nudS3)
        Me.pnlSpeed3.Location = New System.Drawing.Point(386, 60)
        Me.pnlSpeed3.Name = "pnlSpeed3"
        Me.pnlSpeed3.Size = New System.Drawing.Size(180, 279)
        Me.pnlSpeed3.TabIndex = 10
        Me.pnlSpeed3.TabStop = False
        Me.pnlSpeed3.Text = "Параметры на 3-ей скорости"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(4, 257)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(117, 13)
        Me.Label27.TabIndex = 19
        Me.Label27.Text = "Симметричность B, %"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(4, 235)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(102, 13)
        Me.Label28.TabIndex = 20
        Me.Label28.Text = "B (раст.),  кН/(м/c)"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(4, 214)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(113, 13)
        Me.Label29.TabIndex = 17
        Me.Label29.Text = "B (сжатие),  кН/(м/c)"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(4, 193)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(105, 13)
        Me.Label30.TabIndex = 18
        Me.Label30.Text = "Fmax, при раст., кН"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(4, 170)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(113, 13)
        Me.Label31.TabIndex = 16
        Me.Label31.Text = "Fmax при сжатии, кН"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(4, 147)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(109, 13)
        Me.Label32.TabIndex = 14
        Me.Label32.Text = "Энергоемкость, Дж"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(4, 126)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(105, 13)
        Me.Label33.TabIndex = 9
        Me.Label33.Text = " Fмакс привода, Гц"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(4, 105)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(112, 13)
        Me.Label34.TabIndex = 8
        Me.Label34.Text = "Частота привода, Гц"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(4, 84)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(61, 13)
        Me.Label35.TabIndex = 10
        Me.Label35.Text = "Угол, град"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(4, 63)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(48, 13)
        Me.Label36.TabIndex = 12
        Me.Label36.Text = "Ход, мм"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(4, 42)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(115, 13)
        Me.Label37.TabIndex = 11
        Me.Label37.Text = "Время проверки, сек"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(4, 21)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(80, 13)
        Me.Label38.TabIndex = 13
        Me.Label38.Text = "Скорость, м/c"
        '
        'nudSymetr3
        '
        Me.nudSymetr3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudSymetr3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "Symmetry_s3", True))
        Me.nudSymetr3.DecimalPlaces = 2
        Me.nudSymetr3.Location = New System.Drawing.Point(124, 254)
        Me.nudSymetr3.Name = "nudSymetr3"
        Me.nudSymetr3.Size = New System.Drawing.Size(53, 20)
        Me.nudSymetr3.TabIndex = 2
        '
        'nudBdec3
        '
        Me.nudBdec3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudBdec3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "B_dec_s3", True))
        Me.nudBdec3.DecimalPlaces = 2
        Me.nudBdec3.Location = New System.Drawing.Point(124, 233)
        Me.nudBdec3.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudBdec3.Name = "nudBdec3"
        Me.nudBdec3.Size = New System.Drawing.Size(53, 20)
        Me.nudBdec3.TabIndex = 2
        '
        'nudBinc3
        '
        Me.nudBinc3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudBinc3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "B_inc_s3", True))
        Me.nudBinc3.DecimalPlaces = 2
        Me.nudBinc3.Location = New System.Drawing.Point(124, 212)
        Me.nudBinc3.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudBinc3.Name = "nudBinc3"
        Me.nudBinc3.Size = New System.Drawing.Size(53, 20)
        Me.nudBinc3.TabIndex = 2
        '
        'nudPdec3
        '
        Me.nudPdec3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudPdec3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "P_dec_s3", True))
        Me.nudPdec3.DecimalPlaces = 2
        Me.nudPdec3.Location = New System.Drawing.Point(124, 191)
        Me.nudPdec3.Name = "nudPdec3"
        Me.nudPdec3.Size = New System.Drawing.Size(53, 20)
        Me.nudPdec3.TabIndex = 2
        '
        'nudPinc3
        '
        Me.nudPinc3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudPinc3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "P_inc_s3", True))
        Me.nudPinc3.DecimalPlaces = 2
        Me.nudPinc3.Location = New System.Drawing.Point(124, 170)
        Me.nudPinc3.Name = "nudPinc3"
        Me.nudPinc3.Size = New System.Drawing.Size(53, 20)
        Me.nudPinc3.TabIndex = 2
        '
        'nudE3
        '
        Me.nudE3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudE3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "E_s3", True))
        Me.nudE3.DecimalPlaces = 1
        Me.nudE3.Location = New System.Drawing.Point(124, 149)
        Me.nudE3.Maximum = New Decimal(New Integer() {60000, 0, 0, 0})
        Me.nudE3.Name = "nudE3"
        Me.nudE3.Size = New System.Drawing.Size(53, 20)
        Me.nudE3.TabIndex = 2
        '
        'nudFmax3
        '
        Me.nudFmax3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudFmax3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "S3_MotorSpeedMax", True))
        Me.nudFmax3.DecimalPlaces = 1
        Me.nudFmax3.Enabled = False
        Me.nudFmax3.Location = New System.Drawing.Point(124, 128)
        Me.nudFmax3.Maximum = New Decimal(New Integer() {65, 0, 0, 0})
        Me.nudFmax3.Name = "nudFmax3"
        Me.nudFmax3.Size = New System.Drawing.Size(53, 20)
        Me.nudFmax3.TabIndex = 2
        '
        'nudF3
        '
        Me.nudF3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudF3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "S3_MotorSpeed", True))
        Me.nudF3.DecimalPlaces = 1
        Me.nudF3.Enabled = False
        Me.nudF3.Location = New System.Drawing.Point(124, 107)
        Me.nudF3.Maximum = New Decimal(New Integer() {65, 0, 0, 0})
        Me.nudF3.Name = "nudF3"
        Me.nudF3.Size = New System.Drawing.Size(53, 20)
        Me.nudF3.TabIndex = 2
        '
        'nudAngle3
        '
        Me.nudAngle3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudAngle3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "S3_Angle", True))
        Me.nudAngle3.Location = New System.Drawing.Point(124, 86)
        Me.nudAngle3.Maximum = New Decimal(New Integer() {600, 0, 0, 0})
        Me.nudAngle3.Name = "nudAngle3"
        Me.nudAngle3.Size = New System.Drawing.Size(53, 20)
        Me.nudAngle3.TabIndex = 2
        '
        'nudA3
        '
        Me.nudA3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudA3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "S3_Ampl", True))
        Me.nudA3.Location = New System.Drawing.Point(124, 65)
        Me.nudA3.Maximum = New Decimal(New Integer() {600, 0, 0, 0})
        Me.nudA3.Name = "nudA3"
        Me.nudA3.Size = New System.Drawing.Size(53, 20)
        Me.nudA3.TabIndex = 2
        '
        'nudT3
        '
        Me.nudT3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudT3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "S3_Time", True))
        Me.nudT3.Location = New System.Drawing.Point(124, 44)
        Me.nudT3.Maximum = New Decimal(New Integer() {3600, 0, 0, 0})
        Me.nudT3.Name = "nudT3"
        Me.nudT3.Size = New System.Drawing.Size(53, 20)
        Me.nudT3.TabIndex = 2
        '
        'nudS3
        '
        Me.nudS3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudS3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "S3_Speed3", True))
        Me.nudS3.DecimalPlaces = 3
        Me.nudS3.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nudS3.Location = New System.Drawing.Point(124, 23)
        Me.nudS3.Maximum = New Decimal(New Integer() {6, 0, 0, 65536})
        Me.nudS3.Minimum = New Decimal(New Integer() {2, 0, 0, 131072})
        Me.nudS3.Name = "nudS3"
        Me.nudS3.Size = New System.Drawing.Size(53, 20)
        Me.nudS3.TabIndex = 2
        Me.nudS3.Value = New Decimal(New Integer() {2, 0, 0, 131072})
        '
        'chSpeed4
        '
        Me.chSpeed4.AutoSize = True
        Me.chSpeed4.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.AsBSource, "Check_s4", True))
        Me.chSpeed4.Location = New System.Drawing.Point(578, 35)
        Me.chSpeed4.Name = "chSpeed4"
        Me.chSpeed4.Size = New System.Drawing.Size(151, 17)
        Me.chSpeed4.TabIndex = 13
        Me.chSpeed4.Text = "Работа на 4-ой скорости"
        Me.chSpeed4.UseVisualStyleBackColor = True
        '
        'pnlSpeed4
        '
        Me.pnlSpeed4.Controls.Add(Me.Label39)
        Me.pnlSpeed4.Controls.Add(Me.Label40)
        Me.pnlSpeed4.Controls.Add(Me.Label41)
        Me.pnlSpeed4.Controls.Add(Me.Label42)
        Me.pnlSpeed4.Controls.Add(Me.Label43)
        Me.pnlSpeed4.Controls.Add(Me.Label44)
        Me.pnlSpeed4.Controls.Add(Me.Label45)
        Me.pnlSpeed4.Controls.Add(Me.Label46)
        Me.pnlSpeed4.Controls.Add(Me.Label47)
        Me.pnlSpeed4.Controls.Add(Me.Label48)
        Me.pnlSpeed4.Controls.Add(Me.Label49)
        Me.pnlSpeed4.Controls.Add(Me.Label50)
        Me.pnlSpeed4.Controls.Add(Me.nudSymetr4)
        Me.pnlSpeed4.Controls.Add(Me.nudBdec4)
        Me.pnlSpeed4.Controls.Add(Me.nudBinc4)
        Me.pnlSpeed4.Controls.Add(Me.nudPdec4)
        Me.pnlSpeed4.Controls.Add(Me.nudPinc4)
        Me.pnlSpeed4.Controls.Add(Me.nudE4)
        Me.pnlSpeed4.Controls.Add(Me.nudFmax4)
        Me.pnlSpeed4.Controls.Add(Me.nudF4)
        Me.pnlSpeed4.Controls.Add(Me.nudAngle4)
        Me.pnlSpeed4.Controls.Add(Me.nudA4)
        Me.pnlSpeed4.Controls.Add(Me.nudT4)
        Me.pnlSpeed4.Controls.Add(Me.nudS4)
        Me.pnlSpeed4.Location = New System.Drawing.Point(575, 60)
        Me.pnlSpeed4.Name = "pnlSpeed4"
        Me.pnlSpeed4.Size = New System.Drawing.Size(180, 279)
        Me.pnlSpeed4.TabIndex = 12
        Me.pnlSpeed4.TabStop = False
        Me.pnlSpeed4.Text = "Параметры на 4-ой скорости"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(4, 255)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(117, 13)
        Me.Label39.TabIndex = 19
        Me.Label39.Text = "Симметричность B, %"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(4, 233)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(102, 13)
        Me.Label40.TabIndex = 20
        Me.Label40.Text = "B (раст.),  кН/(м/c)"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(4, 212)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(113, 13)
        Me.Label41.TabIndex = 17
        Me.Label41.Text = "B (сжатие),  кН/(м/c)"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(4, 191)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(105, 13)
        Me.Label42.TabIndex = 18
        Me.Label42.Text = "Fmax, при раст., кН"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(4, 172)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(113, 13)
        Me.Label43.TabIndex = 16
        Me.Label43.Text = "Fmax при сжатии, кН"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(4, 149)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(109, 13)
        Me.Label44.TabIndex = 14
        Me.Label44.Text = "Энергоемкость, Дж"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(4, 128)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(105, 13)
        Me.Label45.TabIndex = 9
        Me.Label45.Text = " Fмакс привода, Гц"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(4, 107)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(112, 13)
        Me.Label46.TabIndex = 8
        Me.Label46.Text = "Частота привода, Гц"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(4, 86)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(61, 13)
        Me.Label47.TabIndex = 10
        Me.Label47.Text = "Угол, град"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(4, 65)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(48, 13)
        Me.Label48.TabIndex = 12
        Me.Label48.Text = "Ход, мм"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(4, 44)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(115, 13)
        Me.Label49.TabIndex = 11
        Me.Label49.Text = "Время проверки, сек"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(4, 23)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(80, 13)
        Me.Label50.TabIndex = 13
        Me.Label50.Text = "Скорость, м/c"
        '
        'nudSymetr4
        '
        Me.nudSymetr4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudSymetr4.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "Symmetry_s4", True))
        Me.nudSymetr4.DecimalPlaces = 2
        Me.nudSymetr4.Location = New System.Drawing.Point(124, 252)
        Me.nudSymetr4.Name = "nudSymetr4"
        Me.nudSymetr4.Size = New System.Drawing.Size(53, 20)
        Me.nudSymetr4.TabIndex = 2
        '
        'nudBdec4
        '
        Me.nudBdec4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudBdec4.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "B_dec_s4", True))
        Me.nudBdec4.DecimalPlaces = 2
        Me.nudBdec4.Location = New System.Drawing.Point(124, 231)
        Me.nudBdec4.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudBdec4.Name = "nudBdec4"
        Me.nudBdec4.Size = New System.Drawing.Size(53, 20)
        Me.nudBdec4.TabIndex = 2
        '
        'nudBinc4
        '
        Me.nudBinc4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudBinc4.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "B_inc_s4", True))
        Me.nudBinc4.DecimalPlaces = 2
        Me.nudBinc4.Location = New System.Drawing.Point(124, 210)
        Me.nudBinc4.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudBinc4.Name = "nudBinc4"
        Me.nudBinc4.Size = New System.Drawing.Size(53, 20)
        Me.nudBinc4.TabIndex = 2
        '
        'nudPdec4
        '
        Me.nudPdec4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudPdec4.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "P_dec_s4", True))
        Me.nudPdec4.DecimalPlaces = 2
        Me.nudPdec4.Location = New System.Drawing.Point(124, 189)
        Me.nudPdec4.Name = "nudPdec4"
        Me.nudPdec4.Size = New System.Drawing.Size(53, 20)
        Me.nudPdec4.TabIndex = 2
        '
        'nudPinc4
        '
        Me.nudPinc4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudPinc4.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "P_inc_s4", True))
        Me.nudPinc4.DecimalPlaces = 2
        Me.nudPinc4.Location = New System.Drawing.Point(124, 168)
        Me.nudPinc4.Name = "nudPinc4"
        Me.nudPinc4.Size = New System.Drawing.Size(53, 20)
        Me.nudPinc4.TabIndex = 2
        '
        'nudE4
        '
        Me.nudE4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudE4.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "E_s4", True))
        Me.nudE4.DecimalPlaces = 1
        Me.nudE4.Location = New System.Drawing.Point(124, 147)
        Me.nudE4.Maximum = New Decimal(New Integer() {60000, 0, 0, 0})
        Me.nudE4.Name = "nudE4"
        Me.nudE4.Size = New System.Drawing.Size(53, 20)
        Me.nudE4.TabIndex = 2
        '
        'nudFmax4
        '
        Me.nudFmax4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudFmax4.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "S4_MotorSpeedMax", True))
        Me.nudFmax4.DecimalPlaces = 1
        Me.nudFmax4.Enabled = False
        Me.nudFmax4.Location = New System.Drawing.Point(124, 126)
        Me.nudFmax4.Maximum = New Decimal(New Integer() {65, 0, 0, 0})
        Me.nudFmax4.Name = "nudFmax4"
        Me.nudFmax4.Size = New System.Drawing.Size(53, 20)
        Me.nudFmax4.TabIndex = 2
        '
        'nudF4
        '
        Me.nudF4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudF4.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "S4_MotorSpeed", True))
        Me.nudF4.DecimalPlaces = 1
        Me.nudF4.Enabled = False
        Me.nudF4.Location = New System.Drawing.Point(124, 105)
        Me.nudF4.Maximum = New Decimal(New Integer() {65, 0, 0, 0})
        Me.nudF4.Name = "nudF4"
        Me.nudF4.Size = New System.Drawing.Size(53, 20)
        Me.nudF4.TabIndex = 2
        '
        'nudAngle4
        '
        Me.nudAngle4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudAngle4.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "S4_Angle", True))
        Me.nudAngle4.Location = New System.Drawing.Point(124, 84)
        Me.nudAngle4.Maximum = New Decimal(New Integer() {600, 0, 0, 0})
        Me.nudAngle4.Name = "nudAngle4"
        Me.nudAngle4.Size = New System.Drawing.Size(53, 20)
        Me.nudAngle4.TabIndex = 2
        '
        'nudA4
        '
        Me.nudA4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudA4.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "S4_Ampl", True))
        Me.nudA4.Location = New System.Drawing.Point(124, 63)
        Me.nudA4.Maximum = New Decimal(New Integer() {600, 0, 0, 0})
        Me.nudA4.Name = "nudA4"
        Me.nudA4.Size = New System.Drawing.Size(53, 20)
        Me.nudA4.TabIndex = 2
        '
        'nudT4
        '
        Me.nudT4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudT4.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "S4_Time", True))
        Me.nudT4.Location = New System.Drawing.Point(124, 42)
        Me.nudT4.Maximum = New Decimal(New Integer() {3600, 0, 0, 0})
        Me.nudT4.Name = "nudT4"
        Me.nudT4.Size = New System.Drawing.Size(53, 20)
        Me.nudT4.TabIndex = 2
        '
        'nudS4
        '
        Me.nudS4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudS4.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "S4_Speed4", True))
        Me.nudS4.DecimalPlaces = 3
        Me.nudS4.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nudS4.Location = New System.Drawing.Point(124, 21)
        Me.nudS4.Maximum = New Decimal(New Integer() {6, 0, 0, 65536})
        Me.nudS4.Minimum = New Decimal(New Integer() {2, 0, 0, 131072})
        Me.nudS4.Name = "nudS4"
        Me.nudS4.Size = New System.Drawing.Size(53, 20)
        Me.nudS4.TabIndex = 2
        Me.nudS4.Value = New Decimal(New Integer() {2, 0, 0, 131072})
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(675, 513)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Отмена"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApply.Location = New System.Drawing.Point(594, 513)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 14
        Me.btnApply.Text = "Изменить"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(15, 513)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Добавить"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDel.Location = New System.Drawing.Point(96, 513)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 23)
        Me.btnDel.TabIndex = 14
        Me.btnDel.Text = "Удалить"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.Location = New System.Drawing.Point(513, 513)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 14
        Me.btnOk.Text = "Ок"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'pnlProkachka
        '
        Me.pnlProkachka.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlProkachka.Controls.Add(Me.Label60)
        Me.pnlProkachka.Controls.Add(Me.Label59)
        Me.pnlProkachka.Controls.Add(Me.nudFmaxProkachka)
        Me.pnlProkachka.Controls.Add(Me.nudFprivod)
        Me.pnlProkachka.Controls.Add(Me.Label51)
        Me.pnlProkachka.Controls.Add(Me.nudSpeedProkachka)
        Me.pnlProkachka.Controls.Add(Me.nudTimeProkachka)
        Me.pnlProkachka.Controls.Add(Me.Label52)
        Me.pnlProkachka.Controls.Add(Me.nudAmplitudeProkachka)
        Me.pnlProkachka.Controls.Add(Me.Label53)
        Me.pnlProkachka.Controls.Add(Me.nudAngleProkachka)
        Me.pnlProkachka.Controls.Add(Me.Label55)
        Me.pnlProkachka.Location = New System.Drawing.Point(8, 345)
        Me.pnlProkachka.Name = "pnlProkachka"
        Me.pnlProkachka.Size = New System.Drawing.Size(180, 162)
        Me.pnlProkachka.TabIndex = 15
        Me.pnlProkachka.TabStop = False
        Me.pnlProkachka.Text = "Прокачка"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(4, 132)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(105, 13)
        Me.Label60.TabIndex = 8
        Me.Label60.Text = " Fмакс привода, Гц"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(4, 110)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(112, 13)
        Me.Label59.TabIndex = 8
        Me.Label59.Text = "Частота привода, Гц"
        '
        'nudFmaxProkachka
        '
        Me.nudFmaxProkachka.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudFmaxProkachka.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "ProkachkaMotorSpeedMax", True))
        Me.nudFmaxProkachka.DecimalPlaces = 1
        Me.nudFmaxProkachka.Enabled = False
        Me.nudFmaxProkachka.Location = New System.Drawing.Point(124, 130)
        Me.nudFmaxProkachka.Maximum = New Decimal(New Integer() {65, 0, 0, 0})
        Me.nudFmaxProkachka.Name = "nudFmaxProkachka"
        Me.nudFmaxProkachka.Size = New System.Drawing.Size(53, 20)
        Me.nudFmaxProkachka.TabIndex = 9
        '
        'nudFprivod
        '
        Me.nudFprivod.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudFprivod.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "ProkachkaMotorSpeed", True))
        Me.nudFprivod.DecimalPlaces = 1
        Me.nudFprivod.Enabled = False
        Me.nudFprivod.Location = New System.Drawing.Point(124, 108)
        Me.nudFprivod.Maximum = New Decimal(New Integer() {65, 0, 0, 0})
        Me.nudFprivod.Name = "nudFprivod"
        Me.nudFprivod.Size = New System.Drawing.Size(53, 20)
        Me.nudFprivod.TabIndex = 9
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(4, 22)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(80, 13)
        Me.Label51.TabIndex = 6
        Me.Label51.Text = "Скорость, м/c"
        '
        'nudSpeedProkachka
        '
        Me.nudSpeedProkachka.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nudSpeedProkachka.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "ProkachkaSpeed", True))
        Me.nudSpeedProkachka.DecimalPlaces = 3
        Me.nudSpeedProkachka.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nudSpeedProkachka.Location = New System.Drawing.Point(124, 20)
        Me.nudSpeedProkachka.Maximum = New Decimal(New Integer() {6, 0, 0, 65536})
        Me.nudSpeedProkachka.Minimum = New Decimal(New Integer() {2, 0, 0, 131072})
        Me.nudSpeedProkachka.Name = "nudSpeedProkachka"
        Me.nudSpeedProkachka.Size = New System.Drawing.Size(53, 20)
        Me.nudSpeedProkachka.TabIndex = 7
        Me.nudSpeedProkachka.Value = New Decimal(New Integer() {2, 0, 0, 131072})
        '
        'nudTimeProkachka
        '
        Me.nudTimeProkachka.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nudTimeProkachka.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "ProkachkaTime", True))
        Me.nudTimeProkachka.Location = New System.Drawing.Point(124, 42)
        Me.nudTimeProkachka.Maximum = New Decimal(New Integer() {3600, 0, 0, 0})
        Me.nudTimeProkachka.Name = "nudTimeProkachka"
        Me.nudTimeProkachka.Size = New System.Drawing.Size(53, 20)
        Me.nudTimeProkachka.TabIndex = 2
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(4, 44)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(115, 13)
        Me.Label52.TabIndex = 1
        Me.Label52.Text = "Время проверки, сек"
        '
        'nudAmplitudeProkachka
        '
        Me.nudAmplitudeProkachka.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nudAmplitudeProkachka.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "ProkackaAmpl", True))
        Me.nudAmplitudeProkachka.Location = New System.Drawing.Point(124, 64)
        Me.nudAmplitudeProkachka.Maximum = New Decimal(New Integer() {600, 0, 0, 0})
        Me.nudAmplitudeProkachka.Name = "nudAmplitudeProkachka"
        Me.nudAmplitudeProkachka.Size = New System.Drawing.Size(53, 20)
        Me.nudAmplitudeProkachka.TabIndex = 2
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(4, 66)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(48, 13)
        Me.Label53.TabIndex = 1
        Me.Label53.Text = "Ход, мм"
        '
        'nudAngleProkachka
        '
        Me.nudAngleProkachka.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nudAngleProkachka.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "ProkachkaAngle", True))
        Me.nudAngleProkachka.Location = New System.Drawing.Point(124, 86)
        Me.nudAngleProkachka.Maximum = New Decimal(New Integer() {600, 0, 0, 0})
        Me.nudAngleProkachka.Name = "nudAngleProkachka"
        Me.nudAngleProkachka.Size = New System.Drawing.Size(53, 20)
        Me.nudAngleProkachka.TabIndex = 2
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(4, 88)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(61, 13)
        Me.Label55.TabIndex = 1
        Me.Label55.Text = "Угол, град"
        '
        'chProkachka
        '
        Me.chProkachka.AutoSize = True
        Me.chProkachka.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chProkachka.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.AsBSource, "Check_Prokachka", True))
        Me.chProkachka.Location = New System.Drawing.Point(435, 9)
        Me.chProkachka.Name = "chProkachka"
        Me.chProkachka.Size = New System.Drawing.Size(131, 17)
        Me.chProkachka.TabIndex = 5
        Me.chProkachka.Text = "Выполнять прокачку"
        Me.chProkachka.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.lblbl)
        Me.GroupBox6.Controls.Add(Me.Label57)
        Me.GroupBox6.Controls.Add(Me.nudDTMin)
        Me.GroupBox6.Controls.Add(Me.nudDT80)
        Me.GroupBox6.Controls.Add(Me.Label56)
        Me.GroupBox6.Controls.Add(Me.Label54)
        Me.GroupBox6.Controls.Add(Me.nudDVmax)
        Me.GroupBox6.Controls.Add(Me.nudD40)
        Me.GroupBox6.Location = New System.Drawing.Point(197, 345)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(557, 162)
        Me.GroupBox6.TabIndex = 16
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Допуски"
        '
        'lblbl
        '
        Me.lblbl.AutoSize = True
        Me.lblbl.Enabled = False
        Me.lblbl.Location = New System.Drawing.Point(4, 113)
        Me.lblbl.Name = "lblbl"
        Me.lblbl.Size = New System.Drawing.Size(475, 26)
        Me.lblbl.TabIndex = 8
        Me.lblbl.Text = "Отклонение от номинальных значений при пониженной температуре и скорости 0,015 м/" & _
            "c, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "не более %"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Enabled = False
        Me.Label57.Location = New System.Drawing.Point(4, 85)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(452, 13)
        Me.Label57.TabIndex = 8
        Me.Label57.Text = "Отклонение от номинальных значений при 80 град. С и скорости 0,015 м/c, не более " & _
            "%"
        '
        'nudDTMin
        '
        Me.nudDTMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudDTMin.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "d_cold", True))
        Me.nudDTMin.Enabled = False
        Me.nudDTMin.Location = New System.Drawing.Point(484, 109)
        Me.nudDTMin.Name = "nudDTMin"
        Me.nudDTMin.Size = New System.Drawing.Size(71, 20)
        Me.nudDTMin.TabIndex = 9
        '
        'nudDT80
        '
        Me.nudDT80.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudDT80.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "d_hot", True))
        Me.nudDT80.Enabled = False
        Me.nudDT80.Location = New System.Drawing.Point(484, 81)
        Me.nudDT80.Name = "nudDT80"
        Me.nudDT80.Size = New System.Drawing.Size(71, 20)
        Me.nudDT80.TabIndex = 9
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Enabled = False
        Me.Label56.Location = New System.Drawing.Point(4, 57)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(368, 13)
        Me.Label56.TabIndex = 6
        Me.Label56.Text = "Отклонение от номинальных значений при максимальной скорости, %"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(4, 29)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(444, 26)
        Me.Label54.TabIndex = 6
        Me.Label54.Text = "Отклонение от номинальных значений при 40 град. С и всех контрольных скоростях, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "не более  %"
        '
        'nudDVmax
        '
        Me.nudDVmax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudDVmax.Enabled = False
        Me.nudDVmax.Location = New System.Drawing.Point(484, 53)
        Me.nudDVmax.Name = "nudDVmax"
        Me.nudDVmax.Size = New System.Drawing.Size(71, 20)
        Me.nudDVmax.TabIndex = 7
        '
        'nudD40
        '
        Me.nudD40.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudD40.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AsBSource, "d_nom", True))
        Me.nudD40.Location = New System.Drawing.Point(484, 25)
        Me.nudD40.Name = "nudD40"
        Me.nudD40.Size = New System.Drawing.Size(71, 20)
        Me.nudD40.TabIndex = 7
        '
        'btnEditNameGasitel
        '
        Me.btnEditNameGasitel.Location = New System.Drawing.Point(255, 5)
        Me.btnEditNameGasitel.Name = "btnEditNameGasitel"
        Me.btnEditNameGasitel.Size = New System.Drawing.Size(36, 23)
        Me.btnEditNameGasitel.TabIndex = 17
        Me.btnEditNameGasitel.Text = "..."
        Me.btnEditNameGasitel.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.AsBSource, "Ch_A", True))
        Me.CheckBox1.Location = New System.Drawing.Point(238, 522)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 18
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'frmApparats
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(762, 548)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btnEditNameGasitel)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.pnlProkachka)
        Me.Controls.Add(Me.chProkachka)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.chSpeed4)
        Me.Controls.Add(Me.pnlSpeed4)
        Me.Controls.Add(Me.chSpeed3)
        Me.Controls.Add(Me.pnlSpeed3)
        Me.Controls.Add(Me.chSpeed2)
        Me.Controls.Add(Me.pnlSpeed2)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.chSpeed1)
        Me.Controls.Add(Me.pnlSpeed1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.cmbName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmApparats"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Данные гидрогасителей"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AsBSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudS1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSpeed1.ResumeLayout(False)
        Me.pnlSpeed1.PerformLayout()
        CType(Me.nudSymetr1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBdec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBinc1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPdec1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPinc1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudE1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFmax1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudF1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAngle1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudA1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudT1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApparatTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSpeed2.ResumeLayout(False)
        Me.pnlSpeed2.PerformLayout()
        CType(Me.nudSymetr2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBdec2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBinc2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPdec2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPinc2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudE2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFmax2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudF2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAngle2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudA2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudT2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudS2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSpeed3.ResumeLayout(False)
        Me.pnlSpeed3.PerformLayout()
        CType(Me.nudSymetr3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBdec3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBinc3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPdec3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPinc3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudE3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFmax3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudF3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAngle3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudA3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudT3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudS3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSpeed4.ResumeLayout(False)
        Me.pnlSpeed4.PerformLayout()
        CType(Me.nudSymetr4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBdec4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBinc4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPdec4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPinc4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudE4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFmax4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudF4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAngle4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudA4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudT4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudS4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlProkachka.ResumeLayout(False)
        Me.pnlProkachka.PerformLayout()
        CType(Me.nudFmaxProkachka, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFprivod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSpeedProkachka, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTimeProkachka, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAmplitudeProkachka, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAngleProkachka, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.nudDTMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDT80, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDVmax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudD40, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbName As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nudS1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents pnlSpeed1 As System.Windows.Forms.GroupBox
    Friend WithEvents chSpeed1 As System.Windows.Forms.CheckBox
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nudA1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudT1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents nudF1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudAngle1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents nudFmax1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents nudE1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents nudPdec1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudPinc1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudSymetr1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudBdec As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudBinc1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents chSpeed2 As System.Windows.Forms.CheckBox
    Friend WithEvents pnlSpeed2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents nudSymetr2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudBdec2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudBinc2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudPdec2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudPinc2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudE2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudFmax2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudF2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudAngle2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudA2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudT2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudS2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents chSpeed3 As System.Windows.Forms.CheckBox
    Friend WithEvents pnlSpeed3 As System.Windows.Forms.GroupBox
    Friend WithEvents nudSymetr3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudBdec3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudBinc3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudPdec3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudPinc3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudE3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudFmax3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudF3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudAngle3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudA3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudT3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudS3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents chSpeed4 As System.Windows.Forms.CheckBox
    Friend WithEvents pnlSpeed4 As System.Windows.Forms.GroupBox
    Friend WithEvents nudSymetr4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudBdec4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudBinc4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudPdec4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudPinc4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudE4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudFmax4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudF4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudAngle4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudA4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudT4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudS4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents pnlProkachka As System.Windows.Forms.GroupBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents nudSpeedProkachka As System.Windows.Forms.NumericUpDown
    Friend WithEvents chProkachka As System.Windows.Forms.CheckBox
    Friend WithEvents nudTimeProkachka As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents nudAmplitudeProkachka As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents nudAngleProkachka As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents nudD40 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents nudDVmax As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents nudDT80 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblbl As System.Windows.Forms.Label
    Friend WithEvents nudDTMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents ds As Gidrogasitel.GidrogasitelDataSet
    Friend WithEvents AsBSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents nudFmaxProkachka As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudFprivod As System.Windows.Forms.NumericUpDown
    Friend WithEvents ApparatTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnEditNameGasitel As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
