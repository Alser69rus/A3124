<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnaliseDataGidrogasitel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnaliseDataGidrogasitel))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblNumStrok = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnOpenFile = New System.Windows.Forms.Button
        Me.Частота = New System.Windows.Forms.Label
        Me.Период = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtF = New System.Windows.Forms.TextBox
        Me.txtT = New System.Windows.Forms.TextBox
        Me.txtAmplDist = New System.Windows.Forms.TextBox
        Me.txtLen = New System.Windows.Forms.TextBox
        Me.txtMax2Dist = New System.Windows.Forms.TextBox
        Me.txtMin1Dist = New System.Windows.Forms.TextBox
        Me.txtMax2 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtMin = New System.Windows.Forms.TextBox
        Me.txtMax1Dist = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtMax1 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.COscill3 = New pOscill.cOscill
        Me.COscill2 = New pOscill.cOscill
        Me.btnNext = New System.Windows.Forms.Button
        Me.COscill1 = New pOscill.cOscill
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblNumStrok)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btnOpenFile)
        Me.Panel1.Controls.Add(Me.Частота)
        Me.Panel1.Controls.Add(Me.Период)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtF)
        Me.Panel1.Controls.Add(Me.txtT)
        Me.Panel1.Controls.Add(Me.txtAmplDist)
        Me.Panel1.Controls.Add(Me.txtLen)
        Me.Panel1.Controls.Add(Me.txtMax2Dist)
        Me.Panel1.Controls.Add(Me.txtMin1Dist)
        Me.Panel1.Controls.Add(Me.txtMax2)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtMin)
        Me.Panel1.Controls.Add(Me.txtMax1Dist)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtMax1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(205, 677)
        Me.Panel1.TabIndex = 0
        '
        'lblNumStrok
        '
        Me.lblNumStrok.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblNumStrok.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblNumStrok.Location = New System.Drawing.Point(116, 655)
        Me.lblNumStrok.Name = "lblNumStrok"
        Me.lblNumStrok.Size = New System.Drawing.Size(83, 13)
        Me.lblNumStrok.TabIndex = 6
        Me.lblNumStrok.Text = "---"
        Me.lblNumStrok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 655)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Количество строк"
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOpenFile.Location = New System.Drawing.Point(3, 619)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(196, 23)
        Me.btnOpenFile.TabIndex = 4
        Me.btnOpenFile.Text = "Файл"
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'Частота
        '
        Me.Частота.AutoSize = True
        Me.Частота.Location = New System.Drawing.Point(12, 268)
        Me.Частота.Name = "Частота"
        Me.Частота.Size = New System.Drawing.Size(49, 13)
        Me.Частота.TabIndex = 3
        Me.Частота.Text = "Частота"
        '
        'Период
        '
        Me.Период.AutoSize = True
        Me.Период.Location = New System.Drawing.Point(12, 242)
        Me.Период.Name = "Период"
        Me.Период.Size = New System.Drawing.Size(45, 13)
        Me.Период.TabIndex = 3
        Me.Период.Text = "Период"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 216)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Амплитуда"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Количество отсчетов"
        '
        'txtF
        '
        Me.txtF.Location = New System.Drawing.Point(147, 265)
        Me.txtF.Name = "txtF"
        Me.txtF.Size = New System.Drawing.Size(52, 20)
        Me.txtF.TabIndex = 2
        '
        'txtT
        '
        Me.txtT.Location = New System.Drawing.Point(147, 239)
        Me.txtT.Name = "txtT"
        Me.txtT.Size = New System.Drawing.Size(52, 20)
        Me.txtT.TabIndex = 2
        '
        'txtAmplDist
        '
        Me.txtAmplDist.Location = New System.Drawing.Point(147, 213)
        Me.txtAmplDist.Name = "txtAmplDist"
        Me.txtAmplDist.Size = New System.Drawing.Size(52, 20)
        Me.txtAmplDist.TabIndex = 2
        '
        'txtLen
        '
        Me.txtLen.Location = New System.Drawing.Point(147, 108)
        Me.txtLen.Name = "txtLen"
        Me.txtLen.Size = New System.Drawing.Size(52, 20)
        Me.txtLen.TabIndex = 2
        '
        'txtMax2Dist
        '
        Me.txtMax2Dist.Location = New System.Drawing.Point(147, 187)
        Me.txtMax2Dist.Name = "txtMax2Dist"
        Me.txtMax2Dist.Size = New System.Drawing.Size(52, 20)
        Me.txtMax2Dist.TabIndex = 2
        '
        'txtMin1Dist
        '
        Me.txtMin1Dist.Location = New System.Drawing.Point(147, 161)
        Me.txtMin1Dist.Name = "txtMin1Dist"
        Me.txtMin1Dist.Size = New System.Drawing.Size(52, 20)
        Me.txtMin1Dist.TabIndex = 2
        '
        'txtMax2
        '
        Me.txtMax2.Location = New System.Drawing.Point(147, 82)
        Me.txtMax2.Name = "txtMax2"
        Me.txtMax2.Size = New System.Drawing.Size(52, 20)
        Me.txtMax2.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Макс2 по перемещению"
        '
        'txtMin
        '
        Me.txtMin.Location = New System.Drawing.Point(147, 56)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(52, 20)
        Me.txtMin.TabIndex = 2
        '
        'txtMax1Dist
        '
        Me.txtMax1Dist.Location = New System.Drawing.Point(147, 135)
        Me.txtMax1Dist.Name = "txtMax1Dist"
        Me.txtMax1Dist.Size = New System.Drawing.Size(52, 20)
        Me.txtMax1Dist.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Максимум2 по времени"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 164)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Мин по перемещению"
        '
        'txtMax1
        '
        Me.txtMax1.Location = New System.Drawing.Point(147, 30)
        Me.txtMax1.Name = "txtMax1"
        Me.txtMax1.Size = New System.Drawing.Size(52, 20)
        Me.txtMax1.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Макс1 по перемещению"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Минимум по времени"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Максимум1 по времени"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Экстремумы графика перемещения"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.COscill3)
        Me.Panel2.Controls.Add(Me.COscill2)
        Me.Panel2.Controls.Add(Me.btnNext)
        Me.Panel2.Controls.Add(Me.COscill1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(205, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(573, 677)
        Me.Panel2.TabIndex = 1
        '
        'COscill3
        '
        Me.COscill3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.COscill3.AxisBot = 40.0!
        Me.COscill3.AxisLeft = 60.0!
        Me.COscill3.AxisRight = 20.0!
        Me.COscill3.AxisTop = 40.0!
        Me.COscill3.BackgroundImage = CType(resources.GetObject("COscill3.BackgroundImage"), System.Drawing.Image)
        Me.COscill3.FontAxis = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.COscill3.FontPoint = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.COscill3.FontTitle = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.COscill3.GrafColor = System.Drawing.Color.Red
        Me.COscill3.Location = New System.Drawing.Point(0, 400)
        Me.COscill3.Name = "COscill3"
        Me.COscill3.PointHight = 6.0!
        Me.COscill3.PointSize = 4.0!
        Me.COscill3.Size = New System.Drawing.Size(573, 236)
        Me.COscill3.Smoothing = False
        Me.COscill3.StepX = 500.0!
        Me.COscill3.StepY = 512.0!
        Me.COscill3.TabIndex = 3
        Me.COscill3.TextAxisX = "Время"
        Me.COscill3.TextAxisXoffset = 10.0!
        Me.COscill3.TextAxisY = "Перемещение/Усилие"
        Me.COscill3.TextAxisYoffset = 0.0!
        Me.COscill3.TextTitleOffset = 0.0!
        Me.COscill3.TitleText = "Выборка перемещения/усилия штока от времени"
        Me.COscill3.Xmax = 6500.0!
        Me.COscill3.Xmin = 0.0!
        Me.COscill3.Ymax = 4096.0!
        Me.COscill3.Ymin = 0.0!
        '
        'COscill2
        '
        Me.COscill2.AxisBot = 40.0!
        Me.COscill2.AxisLeft = 60.0!
        Me.COscill2.AxisRight = 20.0!
        Me.COscill2.AxisTop = 40.0!
        Me.COscill2.BackgroundImage = CType(resources.GetObject("COscill2.BackgroundImage"), System.Drawing.Image)
        Me.COscill2.Dock = System.Windows.Forms.DockStyle.Top
        Me.COscill2.FontAxis = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.COscill2.FontPoint = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.COscill2.FontTitle = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.COscill2.GrafColor = System.Drawing.Color.Red
        Me.COscill2.Location = New System.Drawing.Point(0, 200)
        Me.COscill2.Name = "COscill2"
        Me.COscill2.PointHight = 6.0!
        Me.COscill2.PointSize = 4.0!
        Me.COscill2.Size = New System.Drawing.Size(573, 200)
        Me.COscill2.Smoothing = False
        Me.COscill2.StepX = 512.0!
        Me.COscill2.StepY = 2048.0!
        Me.COscill2.TabIndex = 2
        Me.COscill2.TextAxisX = "Время"
        Me.COscill2.TextAxisXoffset = 10.0!
        Me.COscill2.TextAxisY = "Перемещение/Усилие"
        Me.COscill2.TextAxisYoffset = 0.0!
        Me.COscill2.TextTitleOffset = 0.0!
        Me.COscill2.TitleText = "Выборка перемещения/усилия штока от времени"
        Me.COscill2.Xmax = 2048.0!
        Me.COscill2.Xmin = 0.0!
        Me.COscill2.Ymax = 8192.0!
        Me.COscill2.Ymin = 0.0!
        '
        'btnNext
        '
        Me.btnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNext.Location = New System.Drawing.Point(428, 642)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(133, 23)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "Следующий отрезок >>"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'COscill1
        '
        Me.COscill1.AxisBot = 40.0!
        Me.COscill1.AxisLeft = 60.0!
        Me.COscill1.AxisRight = 20.0!
        Me.COscill1.AxisTop = 40.0!
        Me.COscill1.BackgroundImage = CType(resources.GetObject("COscill1.BackgroundImage"), System.Drawing.Image)
        Me.COscill1.Dock = System.Windows.Forms.DockStyle.Top
        Me.COscill1.FontAxis = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.COscill1.FontPoint = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.COscill1.FontTitle = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.COscill1.GrafColor = System.Drawing.Color.Red
        Me.COscill1.Location = New System.Drawing.Point(0, 0)
        Me.COscill1.Name = "COscill1"
        Me.COscill1.PointHight = 6.0!
        Me.COscill1.PointSize = 4.0!
        Me.COscill1.Size = New System.Drawing.Size(573, 200)
        Me.COscill1.Smoothing = False
        Me.COscill1.StepX = 512.0!
        Me.COscill1.StepY = 2048.0!
        Me.COscill1.TabIndex = 0
        Me.COscill1.TextAxisX = "Время"
        Me.COscill1.TextAxisXoffset = 10.0!
        Me.COscill1.TextAxisY = "Перемещение/Усилие"
        Me.COscill1.TextAxisYoffset = 0.0!
        Me.COscill1.TextTitleOffset = 0.0!
        Me.COscill1.TitleText = "График перемещения/усилия штока от времени"
        Me.COscill1.Xmax = 2048.0!
        Me.COscill1.Xmin = 0.0!
        Me.COscill1.Ymax = 8192.0!
        Me.COscill1.Ymin = 0.0!
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "adc"
        Me.OpenFileDialog1.Filter = "Данные ацп|*.adc"
        Me.OpenFileDialog1.InitialDirectory = "C:\WORK\progi\vb net\Stends\Gidrogasitel\VIP5600\VIP5600\bin\Debug\LOG"
        '
        'frmAnaliseDataGidrogasitel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 677)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmAnaliseDataGidrogasitel"
        Me.Text = "Анализ результатов работы гидрогасителя"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents COscill1 As pOscill.cOscill
    Friend WithEvents btnOpenFile As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLen As System.Windows.Forms.TextBox
    Friend WithEvents txtMin As System.Windows.Forms.TextBox
    Friend WithEvents txtMax1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblNumStrok As System.Windows.Forms.Label
    Friend WithEvents COscill2 As pOscill.cOscill
    Friend WithEvents txtMax2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtAmplDist As System.Windows.Forms.TextBox
    Friend WithEvents txtMax2Dist As System.Windows.Forms.TextBox
    Friend WithEvents txtMin1Dist As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtMax1Dist As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Период As System.Windows.Forms.Label
    Friend WithEvents txtT As System.Windows.Forms.TextBox
    Friend WithEvents Частота As System.Windows.Forms.Label
    Friend WithEvents txtF As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents COscill3 As pOscill.cOscill
End Class
