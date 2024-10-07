Public Class aseApparats

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        frmMenuOption.Show()
        Me.Close()

    End Sub

    Private Sub aseApparats_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "GidrogasitelDataSet.Apparats". При необходимости она может быть перемещена или удалена.
        Me.ApparatsTableAdapter.Fill(Me.GidrogasitelDataSet.Apparats)

    End Sub

    Private Sub btnPgUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPgUp.Click
        Dim i As Integer = ListBox1.SelectedIndex
        i = i - 10
        If i < 0 Then i = 0
        If ListBox1.Items.Count > 0 Then ListBox1.SelectedIndex = i
    End Sub

    Private Sub btnUp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUp.Click
        Dim i As Integer = ListBox1.SelectedIndex
        i = i - 1
        If i < 0 Then i = 0
        If ListBox1.Items.Count > 0 Then ListBox1.SelectedIndex = i
    End Sub

    Private Sub btnDown_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDown.Click
        Dim i As Integer = ListBox1.SelectedIndex
        i = i + 1
        If i > ListBox1.Items.Count - 1 Then i = ListBox1.Items.Count - 1
        If ListBox1.Items.Count > 0 Then ListBox1.SelectedIndex = i
    End Sub

    Private Sub btnPgDown_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPgDown.Click
        Dim i As Integer = ListBox1.SelectedIndex
        i = i + 10
        If i > ListBox1.Items.Count - 1 Then i = ListBox1.Items.Count - 1
        If ListBox1.Items.Count > 0 Then ListBox1.SelectedIndex = i
    End Sub
    Private Sub PanelDraw()
        If ListBox1.Items.Count > 10 Then
            btnPgUp.Visible = True
            btnUp.Visible = True
            btnDown.Visible = True
            btnPgDown.Visible = True
            Dim g As Graphics
            g = Panel1.CreateGraphics
            g.Clear(Color.SkyBlue)
            g.DrawLine(Pens.Black, 20, 5, 20, 365)
            Dim i As Single = 350 * ListBox1.SelectedIndex / (ListBox1.Items.Count - 1)
            g.FillEllipse(Brushes.Black, 15, 5 + i, 10, 10)
            g.FillEllipse(Brushes.SkyBlue, 18, 8 + i, 4, 4)
            g.Dispose()

        Else
            btnPgUp.Visible = False
            btnUp.Visible = False
            btnDown.Visible = False
            btnPgDown.Visible = False
        End If
    End Sub

    Private Sub Panel1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseClick
        Dim i As Integer = Math.Truncate((e.Y - 5) * ListBox1.Items.Count / 360)
        If i < 0 Then i = 0
        If i > ListBox1.Items.Count - 1 Then i = ListBox1.Items.Count - 1
        If ListBox1.Items.Count > 0 Then ListBox1.SelectedIndex = i
        PanelDraw()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        PanelDraw()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        PanelDraw()

    End Sub

    Private Sub ApparatsBindingSource_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ApparatsBindingSource.DataSourceChanged
        PanelDraw()

    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim frm As New aseGasitel
        Dim row As GidrogasitelDataSet.ApparatsRow = ApparatsBindingSource.Current.row

        If row IsNot Nothing Then
            frm.fName = row.Name
            frm.fType = row.Type
            frm.fAngle = row.S1_Angle
            frm.fProkachkaCheck = row.Check_Prokachka
            frm.fProkachkaSpeed = row.ProkachkaSpeed
            frm.fProkachkaAmpl = row.ProkackaAmpl
            frm.fProkachkaTime = row.ProkachkaTime

            frm.fCheck1 = row.Check_s1
            frm.fV1 = row.S1_Speed1
            frm.fAmpl1 = row.S1_Ampl
            frm.fFs1 = row.P_inc_s1
            frm.fDFs1 = row.DP_inc_s1
            frm.fFr1 = row.P_dec_s1
            frm.fDFr1 = row.DP_dec_s1
            frm.fE1 = row.E_s1
            frm.fDE1 = row.DE_s1
            frm.fT1 = row.S1_Time
            frm.fReg1 = row.Reg_s1
            frm.fBs1 = row.B_inc_s1
            frm.fBr1 = row.B_dec_s1
            frm.fBReg1 = row.Breg_s1
            frm.fEReg1 = row.Ereg_s1
            frm.fS1 = row.Symmetry_s1
            frm.fSReg1 = row.Sreg_s1

            frm.fCheck2 = row.Check_s2
            frm.fV2 = row.S2_Speed2
            frm.fAmpl2 = row.S2_Ampl
            frm.fFs2 = row.P_inc_s2
            frm.fDFs2 = row.DP_inc_s2
            frm.fFr2 = row.P_dec_s2
            frm.fDFr2 = row.DP_dec_s2
            frm.fE2 = row.E_s2
            frm.fDE2 = row.DE_s2
            frm.fT2 = row.S2_Time
            frm.fReg2 = row.Reg_s2
            frm.fBs2 = row.B_inc_s2
            frm.fBr2 = row.B_dec_s2
            frm.fBReg2 = row.Breg_s2
            frm.fEReg2 = row.Ereg_s2
            frm.fS2 = row.Symmetry_s2
            frm.fSReg2 = row.Sreg_s2

            frm.fCheck3 = row.Check_s3
            frm.fV3 = row.S3_Speed3
            frm.fAmpl3 = row.S3_Ampl
            frm.fFs3 = row.P_inc_s3
            frm.fDFs3 = row.DP_inc_s3
            frm.fFr3 = row.P_dec_s3
            frm.fDFr3 = row.DP_dec_s3
            frm.fE3 = row.E_s3
            frm.fDE3 = row.DE_s3
            frm.fT3 = row.S3_Time
            frm.fReg3 = row.Reg_s3
            frm.fBs3 = row.B_inc_s3
            frm.fBr3 = row.B_dec_s3
            frm.fBReg3 = row.Breg_s3
            frm.fEReg3 = row.Ereg_s3
            frm.fS3 = row.Symmetry_s3
            frm.fSReg3 = row.Sreg_s3

            frm.fCheck4 = row.Check_s4
            frm.fV4 = row.S4_Speed4
            frm.fAmpl4 = row.S4_Ampl
            frm.fFs4 = row.P_inc_s4
            frm.fDFs4 = row.DP_inc_s4
            frm.fFr4 = row.P_dec_s4
            frm.fDFr4 = row.DP_dec_s4
            frm.fE4 = row.E_s4
            frm.fDE4 = row.DE_s4
            frm.fT4 = row.S4_Time
            frm.fReg4 = row.Reg_s4
            frm.fBs4 = row.B_inc_s4
            frm.fBr4 = row.B_dec_s4
            frm.fBReg4 = row.Breg_s4
            frm.fEReg4 = row.Ereg_s4
            frm.fS4 = row.Symmetry_s4
            frm.fSReg4 = row.Sreg_s4
        End If
        
        frm.RefreshField()
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            row.Name = frm.fName
            row.P_inc_s1 = frm.fFs1
            row.P_inc_s2 = frm.fFs2
            row.P_inc_s3 = frm.fFs3
            row.P_inc_s4 = frm.fFs4

            row.P_dec_s1 = frm.fFr1
            row.P_dec_s2 = frm.fFr2
            row.P_dec_s3 = frm.fFr3
            row.P_dec_s4 = frm.fFr4

            row.B_inc_s1 = frm.fBs1
            row.B_inc_s2 = frm.fBs2
            row.B_inc_s3 = frm.fBs3
            row.B_inc_s4 = frm.fBs4

            row.B_dec_s1 = frm.fBr1
            row.B_dec_s2 = frm.fBr2
            row.B_dec_s3 = frm.fBr3
            row.B_dec_s4 = frm.fBr4

            row.E_s1 = frm.fE1
            row.E_s2 = frm.fE2
            row.E_s3 = frm.fE3
            row.E_s4 = frm.fE4

            row.Symmetry_s1 = frm.fS1
            row.Symmetry_s2 = frm.fS2
            row.Symmetry_s3 = frm.fS3
            row.Symmetry_s4 = frm.fS4

            row.Check_s1 = frm.fCheck1
            row.Check_s2 = frm.fCheck2
            row.Check_s3 = frm.fCheck3
            row.Check_s4 = frm.fCheck4

            row.ProkachkaTime = frm.fProkachkaTime
            row.ProkackaAmpl = frm.fProkachkaAmpl
            row.ProkachkaSpeed = frm.fProkachkaSpeed
            row.ProkachkaMotorSpeedMax = 65
            row.ProkachkaMotorSpeed = functVtoN(frm.fProkachkaSpeed, frm.fProkachkaAmpl)

            row.S1_Time = frm.fT1
            row.S2_Time = frm.fT2
            row.S3_Time = frm.fT3
            row.S4_Time = frm.fT4

            row.S1_Ampl = frm.fAmpl1
            row.S2_Ampl = frm.fAmpl2
            row.S3_Ampl = frm.fAmpl3
            row.S4_Ampl = frm.fAmpl4

            row.S1_MotorSpeed = functVtoN(frm.fV1, frm.fAmpl1)
            row.S2_MotorSpeed = functVtoN(frm.fV2, frm.fAmpl2)
            row.S3_MotorSpeed = functVtoN(frm.fV3, frm.fAmpl3)
            row.S4_MotorSpeed = functVtoN(frm.fV4, frm.fAmpl4)

            row.S1_MotorSpeedMax = 65
            row.S2_MotorSpeedMax = 65
            row.S3_MotorSpeedMax = 65
            row.S4_MotorSpeedMax = 65

            row.d_cold = 25
            row.d_hot = 25
            row.d_nom = 25

            row.Type = frm.fType

            row.S1_Angle = frm.fAngle
            row.S2_Angle = frm.fAngle
            row.S3_Angle = frm.fAngle
            row.S4_Angle = frm.fAngle
            row.ProkachkaAngle = frm.fAngle

            row.Check_Prokachka = frm.fProkachkaCheck

            row.S1_Speed1 = frm.fV1
            row.S2_Speed2 = frm.fV2
            row.S3_Speed3 = frm.fV3
            row.S4_Speed4 = frm.fV4

            row.DP_inc_s1 = frm.fDFs1
            row.DP_inc_s2 = frm.fDFs2
            row.DP_inc_s3 = frm.fDFs3
            row.DP_inc_s4 = frm.fDFs4

            row.DP_dec_s1 = frm.fDFr1
            row.DP_dec_s2 = frm.fDFr2
            row.DP_dec_s3 = frm.fDFr3
            row.DP_dec_s4 = frm.fDFr4

            row.DE_s1 = frm.fDE1
            row.DE_s2 = frm.fDE2
            row.DE_s3 = frm.fDE3
            row.DE_s4 = frm.fDE4

            row.Reg_s1 = frm.fReg1
            row.Reg_s2 = frm.fReg2
            row.Reg_s3 = frm.fReg3
            row.Reg_s4 = frm.fReg4

            row.Breg_s1 = frm.fBReg1
            row.Breg_s2 = frm.fBReg2
            row.Breg_s3 = frm.fBReg3
            row.Breg_s4 = frm.fBReg4

            row.Ereg_s1 = frm.fEReg1
            row.Ereg_s2 = frm.fEReg2
            row.Ereg_s3 = frm.fEReg3
            row.Ereg_s4 = frm.fEReg4

            row.Sreg_s1 = frm.fSReg1
            row.Sreg_s2 = frm.fSReg2
            row.Sreg_s3 = frm.fSReg3
            row.Sreg_s4 = frm.fSReg4


            ApparatsTableAdapter.Update(GidrogasitelDataSet.Apparats)
            frm.RefreshField()
        End If
        frm.Dispose()
        PanelDraw()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim frm As New aseGasitel
        Dim row As GidrogasitelDataSet.ApparatsRow = GidrogasitelDataSet.Apparats.NewApparatsRow
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            row.Name = frm.fName
            row.P_inc_s1 = frm.fFs1
            row.P_inc_s2 = frm.fFs2
            row.P_inc_s3 = frm.fFs3
            row.P_inc_s4 = frm.fFs4

            row.P_dec_s1 = frm.fFr1
            row.P_dec_s2 = frm.fFr2
            row.P_dec_s3 = frm.fFr3
            row.P_dec_s4 = frm.fFr4

            row.B_inc_s1 = frm.fBs1
            row.B_inc_s2 = frm.fBs2
            row.B_inc_s3 = frm.fBs3
            row.B_inc_s4 = frm.fBs4

            row.B_dec_s1 = frm.fBr1
            row.B_dec_s2 = frm.fBr2
            row.B_dec_s3 = frm.fBr3
            row.B_dec_s4 = frm.fBr4

            row.E_s1 = frm.fE1
            row.E_s2 = frm.fE2
            row.E_s3 = frm.fE3
            row.E_s4 = frm.fE4

            row.Symmetry_s1 = frm.fS1
            row.Symmetry_s2 = frm.fS2
            row.Symmetry_s3 = frm.fS3
            row.Symmetry_s4 = frm.fS4

            row.Check_s1 = frm.fCheck1
            row.Check_s2 = frm.fCheck2
            row.Check_s3 = frm.fCheck3
            row.Check_s4 = frm.fCheck4

            row.ProkachkaTime = frm.fProkachkaTime
            row.ProkackaAmpl = frm.fProkachkaAmpl
            row.ProkachkaSpeed = frm.fProkachkaSpeed
            row.ProkachkaMotorSpeedMax = 65
            row.ProkachkaMotorSpeed = functVtoN(frm.fProkachkaSpeed, frm.fProkachkaAmpl)

            row.S1_Time = frm.fT1
            row.S2_Time = frm.fT2
            row.S3_Time = frm.fT3
            row.S4_Time = frm.fT4

            row.S1_Ampl = frm.fAmpl1
            row.S2_Ampl = frm.fAmpl2
            row.S3_Ampl = frm.fAmpl3
            row.S4_Ampl = frm.fAmpl4

            row.S1_MotorSpeed = functVtoN(frm.fV1, frm.fAmpl1)
            row.S2_MotorSpeed = functVtoN(frm.fV2, frm.fAmpl2)
            row.S3_MotorSpeed = functVtoN(frm.fV3, frm.fAmpl3)
            row.S4_MotorSpeed = functVtoN(frm.fV4, frm.fAmpl4)

            row.S1_MotorSpeedMax = 65
            row.S2_MotorSpeedMax = 65
            row.S3_MotorSpeedMax = 65
            row.S4_MotorSpeedMax = 65

            row.d_cold = 25
            row.d_hot = 25
            row.d_nom = 25

            row.Type = frm.fType

            row.S1_Angle = frm.fAngle
            row.S2_Angle = frm.fAngle
            row.S3_Angle = frm.fAngle
            row.S4_Angle = frm.fAngle
            row.ProkachkaAngle = frm.fAngle

            row.Check_Prokachka = frm.fProkachkaCheck

            row.S1_Speed1 = frm.fV1
            row.S2_Speed2 = frm.fV2
            row.S3_Speed3 = frm.fV3
            row.S4_Speed4 = frm.fV4

            row.DP_inc_s1 = frm.fDFs1
            row.DP_inc_s2 = frm.fDFs2
            row.DP_inc_s3 = frm.fDFs3
            row.DP_inc_s4 = frm.fDFs4

            row.DP_dec_s1 = frm.fDFr1
            row.DP_dec_s2 = frm.fDFr2
            row.DP_dec_s3 = frm.fDFr3
            row.DP_dec_s4 = frm.fDFr4

            row.DE_s1 = frm.fDE1
            row.DE_s2 = frm.fDE2
            row.DE_s3 = frm.fDE3
            row.DE_s4 = frm.fDE4

            row.Reg_s1 = frm.fReg1
            row.Reg_s2 = frm.fReg2
            row.Reg_s3 = frm.fReg3
            row.Reg_s4 = frm.fReg4

            row.Breg_s1 = frm.fBReg1
            row.Breg_s2 = frm.fBReg2
            row.Breg_s3 = frm.fBReg3
            row.Breg_s4 = frm.fBReg4

            row.Ereg_s1 = frm.fEReg1
            row.Ereg_s2 = frm.fEReg2
            row.Ereg_s3 = frm.fEReg3
            row.Ereg_s4 = frm.fEReg4

            row.Sreg_s1 = frm.fSReg1
            row.Sreg_s2 = frm.fSReg2
            row.Sreg_s3 = frm.fSReg3
            row.Sreg_s4 = frm.fSReg4

            GidrogasitelDataSet.Apparats.AddApparatsRow(row)
            ApparatsTableAdapter.Update(GidrogasitelDataSet.Apparats)

            frm.RefreshField()
        End If
        frm.Dispose()
        PanelDraw()
    End Sub

    Private Sub btnDel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Dim row As GidrogasitelDataSet.ApparatsRow = ApparatsBindingSource.Current.row
        row.Delete()
        ApparatsTableAdapter.Update(GidrogasitelDataSet.Apparats)
        PanelDraw()
    End Sub
End Class