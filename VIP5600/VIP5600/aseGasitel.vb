Public Class aseGasitel

    Public fName As String
    Public fType As Long
    Public fAngle As Integer = 0
    Public fProkachkaCheck As Boolean = True
    Public fProkachkaSpeed As Single = 0.3
    Public fProkachkaAmpl As Single = frmGMain.stend.rw.MAX_AMPL
    Public fProkachkaTime As Integer = 300

    Public fCheck1 As Boolean = False
    Public fV1 As Single = 0.06
    Public fAmpl1 As Single = 40
    Public fFs1 As Single = 3
    Public fDFs1 As Single = 0.7
    Public fFr1 As Single = 3
    Public fDFr1 As Single = 0.7
    Public fE1 As Integer = 0
    Public fDE1 As Integer = 0
    Public fT1 As Integer = 300
    Public fReg1 As Integer = 0
    Public fBs1 As Single = 0
    Public fBr1 As Single = 0
    Public fBReg1 As Integer = 0
    Public fEReg1 As Integer = 0
    Public fS1 As Single = 25
    Public fSReg1 As Integer = 0

    Public fCheck2 As Boolean = False
    Public fV2 As Single = 0.15
    Public fAmpl2 As Single = 40
    Public fFs2 As Single = 6
    Public fDFs2 As Single = 2
    Public fFr2 As Single = 6
    Public fDFr2 As Single = 2
    Public fE2 As Integer = 0
    Public fDE2 As Integer = 0
    Public fT2 As Integer = 300
    Public fReg2 As Integer = 0
    Public fBs2 As Single = 0
    Public fBr2 As Single = 0
    Public fBReg2 As Integer = 0
    Public fEReg2 As Integer = 0
    Public fS2 As Single = 25
    Public fSReg2 As Integer = 0

    Public fCheck3 As Boolean = False
    Public fV3 As Single = 0.3
    Public fAmpl3 As Single = 40
    Public fFs3 As Single = 7
    Public fDFs3 As Single = 2
    Public fFr3 As Single = 7
    Public fDFr3 As Single = 2
    Public fE3 As Integer = 0
    Public fDE3 As Integer = 0
    Public fT3 As Integer = 120
    Public fReg3 As Integer = 0
    Public fBs3 As Single = 0
    Public fBr3 As Single = 0
    Public fBReg3 As Integer = 0
    Public fEReg3 As Integer = 0
    Public fS3 As Single = 25
    Public fSReg3 As Integer = 0

    Public fCheck4 As Boolean = False
    Public fV4 As Single = 0.6
    Public fAmpl4 As Single = 40
    Public fFs4 As Single = 13
    Public fDFs4 As Single = 3
    Public fFr4 As Single = 13
    Public fDFr4 As Single = 3
    Public fE4 As Integer = 0
    Public fDE4 As Integer = 0
    Public fT4 As Integer = 60
    Public fReg4 As Integer = 0
    Public fBs4 As Single = 0
    Public fBr4 As Single = 0
    Public fBReg4 As Integer = 0
    Public fEReg4 As Integer = 0
    Public fS4 As Single = 25
    Public fSReg4 As Integer = 0





    Private Sub btnName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnName.Click
        Dim frm As New frmKeypad
        frm.btnResult.Text = fName
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fName = frm.btnResult.Text
            If fName.Length > 30 Then fName = fName.Substring(0, 30)
            RefreshField()
        End If
        frm.Dispose()

    End Sub

    Public Sub RefreshField()

        btnName.Text = "Обозначение: " & fName

        Me.ApparatTypeTableAdapter.Fill(Me.GidrogasitelDataSet1.ApparatType)
        Dim row As GidrogasitelDataSet.ApparatTypeRow
        row = GidrogasitelDataSet1.ApparatType.FindByID(fType)
        If row IsNot Nothing Then
            btnType.Text = "Тип гидрогасителя: " & row.Name
        End If

        If fCheck1 Then
            btn1.Text = "1. " & fFr1.ToString("f1") & "/" & fFs1.ToString("f1") & "-" & fV1.ToString("f3")
        Else
            btn1.Text = "1. Нет"
            fCheck2 = False
            btn2.Text = "2. Нет"
            fCheck3 = False
            btn3.Text = "3. Нет"
            fCheck4 = False
            btn4.Text = "4. Нет"
        End If

        If fCheck2 Then
            btn2.Text = "2. " & fFr2.ToString("f1") & "/" & fFs2.ToString("f1") & "-" & fV2.ToString("f3")
        Else
            fCheck2 = False
            btn2.Text = "2. Нет"
            fCheck3 = False
            btn3.Text = "3. Нет"
            fCheck4 = False
            btn4.Text = "4. Нет"
        End If

        If fCheck3 Then
            btn3.Text = "3. " & fFr3.ToString("f1") & "/" & fFs3.ToString("f1") & "-" & fV3.ToString("f3")
        Else
            
            fCheck3 = False
            btn3.Text = "3. Нет"
            fCheck4 = False
            btn4.Text = "4. Нет"
        End If

        If fCheck4 Then
            btn4.Text = "4. " & fFr4.ToString("f1") & "/" & fFs4.ToString("f1") & "-" & fV4.ToString("f3")
        Else
           
            fCheck4 = False
            btn4.Text = "4. Нет"
        End If
    End Sub

    Private Sub btnType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnType.Click
        Dim frm As New aseApparatTypeSelect
        Dim row As GidrogasitelDataSet.ApparatTypeRow

        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            row = frm.ApparatTypeBindingSource.Current.row
            fType = row.ID

            RefreshField()
        End If
        frm.Dispose()
    End Sub

    Private Sub aseGasitel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "GidrogasitelDataSet1.ApparatType". При необходимости она может быть перемещена или удалена.
        Me.ApparatTypeTableAdapter.Fill(Me.GidrogasitelDataSet1.ApparatType)

    End Sub


    Private Sub btnPrep_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrep.Click
        Dim frm As New asePreparation

        frm.fAngle = fAngle
        frm.fProkachkaCheck = fProkachkaCheck
        frm.fProkachkaSpeed = fProkachkaSpeed
        frm.fProkachkaAmpl = fProkachkaAmpl
        frm.fProkachkaTime = fProkachkaTime

        frm.RefreshField()

        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fAngle = frm.fAngle
            fProkachkaCheck = frm.fProkachkaCheck
            fProkachkaAmpl = frm.fProkachkaAmpl
            fProkachkaSpeed = frm.fProkachkaSpeed
            fProkachkaTime = frm.fProkachkaTime

        End If
        frm.Dispose()

    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        Dim frm As New aseProverka


        frm.btnBack.Text = "Контрольная скорость № 1"
        frm.fCheck = fCheck1
        frm.fV = fV1
        frm.fAmpl = fAmpl1
        frm.fFs = fFs1
        frm.fDFs = fDFs1
        frm.fFr = fFr1
        frm.fDFr = fDFr1
        frm.fE = fE1
        frm.fDE = fDE1
        frm.fT = fT1
        frm.fReg = fReg1
        
        frm.RefreshField()

        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fCheck1 = frm.fCheck
            fV1 = frm.fV
            fAmpl1 = frm.fAmpl
            fFs1 = frm.fFs
            fDFs1 = frm.fDFs
            fFr1 = frm.fFr
            fDFr1 = frm.fDFr
            fE1 = frm.fE
            fDE1 = frm.fDE
            fT1 = frm.fT
            fReg1 = frm.fReg

            If fV1 < 0.075 And fV1 > 0.001 Then
                fBr1 = Math.Round(fFr1 / fV1)
                fBs1 = Math.Round(fFs1 / fV1)
                fBReg1 = 1
            End If
            If Math.Abs(fFr1 - fFs1) < 0.01 Then
                fS1 = 25
                fSReg1 = 1
            End If
            If Not fCheck2 And fE1 > 1 Then
                fEReg1 = 2
            End If

        End If

        RefreshField()

        frm.Dispose()

    End Sub

    Private Sub btn2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn2.Click
        Dim frm As New aseProverka


        frm.btnBack.Text = "Контрольная скорость № 2"
        frm.fCheck = fCheck2
        frm.fV = fV2
        frm.fAmpl = fAmpl2
        frm.fFs = fFs2
        frm.fDFs = fDFs2
        frm.fFr = fFr2
        frm.fDFr = fDFr2
        frm.fE = fE2
        frm.fDE = fDE2
        frm.fT = fT2
        frm.fReg = fReg2

        frm.RefreshField()

        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fCheck2 = frm.fCheck
            fV2 = frm.fV
            fAmpl2 = frm.fAmpl
            fFs2 = frm.fFs
            fDFs2 = frm.fDFs
            fFr2 = frm.fFr
            fDFr2 = frm.fDFr
            fE2 = frm.fE
            fDE2 = frm.fDE
            fT2 = frm.fT
            fReg2 = frm.fReg

            If fV2 < 0.075 And fV2 > 0.001 Then
                fBr2 = Math.Round(fFr2 / fV2)
                fBs2 = Math.Round(fFs2 / fV2)
                fBReg2 = 1
            End If
            If Math.Abs(fFr2 - fFs2) < 0.01 Then
                fS2 = 25
                fSReg2 = 1
            End If
            If Not fCheck3 And fE2 > 1 Then
                fEReg2 = 2
                fEReg1 = 0
            End If
        End If

        RefreshField()

        frm.Dispose()
    End Sub

    Private Sub btn3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn3.Click
        Dim frm As New aseProverka


        frm.btnBack.Text = "Контрольная скорость № 3"
        frm.fCheck = fCheck3
        frm.fV = fV3
        frm.fAmpl = fAmpl3
        frm.fFs = fFs3
        frm.fDFs = fDFs3
        frm.fFr = fFr3
        frm.fDFr = fDFr3
        frm.fE = fE3
        frm.fDE = fDE3
        frm.fT = fT3
        frm.fReg = fReg3

        frm.RefreshField()

        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fCheck3 = frm.fCheck
            fV3 = frm.fV
            fAmpl3 = frm.fAmpl
            fFs3 = frm.fFs
            fDFs3 = frm.fDFs
            fFr3 = frm.fFr
            fDFr3 = frm.fDFr
            fE3 = frm.fE
            fDE3 = frm.fDE
            fT3 = frm.fT
            fReg3 = frm.fReg

            If fV3 < 0.075 And fV3 > 0.001 Then
                fBr3 = Math.Round(fFr3 / fV3)
                fBs3 = Math.Round(fFs3 / fV3)
                fBReg3 = 1
            End If
            If Math.Abs(fFr3 - fFs3) < 0.01 Then
                fS3 = 25
                fSReg3 = 1
            End If
            If Not fCheck4 And fE3 > 1 Then
                fEReg3 = 2
                fEReg2 = 0
            End If
        End If

        RefreshField()

        frm.Dispose()
    End Sub

    Private Sub btn4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn4.Click
        Dim frm As New aseProverka


        frm.btnBack.Text = "Контрольная скорость № 4"
        frm.fCheck = fCheck4
        frm.fV = fV4
        frm.fAmpl = fAmpl4
        frm.fFs = fFs4
        frm.fDFs = fDFs4
        frm.fFr = fFr4
        frm.fDFr = fDFr4
        frm.fE = fE4
        frm.fDE = fDE4
        frm.fT = fT4
        frm.fReg = fReg4

        frm.RefreshField()

        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fCheck4 = frm.fCheck
            fV4 = frm.fV
            fAmpl4 = frm.fAmpl
            fFs4 = frm.fFs
            fDFs4 = frm.fDFs
            fFr4 = frm.fFr
            fDFr4 = frm.fDFr
            fE4 = frm.fE
            fDE4 = frm.fDE
            fT4 = frm.fT
            fReg4 = frm.fReg

            If fV4 < 0.075 And fV4 > 0.001 Then
                fBr4 = Math.Round(fFr4 / fV4)
                fBs4 = Math.Round(fFs4 / fV4)
                fBReg4 = 1
            End If
            If Math.Abs(fFr4 - fFs4) < 0.01 Then
                fS4 = 25
                fSReg4 = 1
            End If
            If fE4 > 1 Then
                fEReg4 = 2
                fEReg3 = 0
            End If
        End If

        RefreshField()

        frm.Dispose()
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        Dim frm As New aseObrabotka
        frm.fA0 = fProkachkaAmpl
        frm.fA1 = fAmpl1
        frm.fA2 = fAmpl2
        frm.fA3 = fAmpl3
        frm.fA4 = fAmpl4

        frm.fV0 = fProkachkaSpeed
        frm.fV1 = fV1
        frm.fV2 = fV2
        frm.fV3 = fV3
        frm.fV4 = fV4

        frm.fCheck0 = fProkachkaCheck
        frm.fCheck1 = fCheck1
        frm.fCheck2 = fCheck2
        frm.fCheck3 = fCheck3
        frm.fCheck4 = fCheck4

        frm.fBs1 = fBs1
        frm.fBs2 = fBs2
        frm.fBs3 = fBs3
        frm.fBs4 = fBs4

        frm.fBr1 = fBr1
        frm.fBr2 = fBr2
        frm.fBr3 = fBr3
        frm.fBr4 = fBr4

        frm.fBreg1 = fBReg1
        frm.fBreg2 = fBReg2
        frm.fBreg3 = fBReg3
        frm.fBreg4 = fBReg4

        frm.fE1 = fE1
        frm.fE2 = fE2
        frm.fE3 = fE3
        frm.fE4 = fE4

        frm.fDE1 = fDE1
        frm.fDE2 = fDE2
        frm.fDE3 = fDE3
        frm.fDE4 = fDE4

        frm.fEreg1 = fEReg1
        frm.fEreg2 = fEReg2
        frm.fEreg3 = fEReg3
        frm.fEreg4 = fEReg4

        frm.fS1 = fS1
        frm.fS2 = fS2
        frm.fS3 = fS3
        frm.fS4 = fS4

        frm.fSReg1 = fSReg1
        frm.fSReg2 = fSReg2
        frm.fSReg3 = fSReg3
        frm.fSReg4 = fSReg4

        frm.fGReg1 = fReg1
        frm.fGReg2 = fReg2
        frm.fGReg3 = fReg3
        frm.fGReg4 = fReg4

        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fProkachkaAmpl = frm.fA0
            fAmpl1 = frm.fA1
            fAmpl2 = frm.fA2
            fAmpl3 = frm.fA3
            fAmpl4 = frm.fA4

            fProkachkaSpeed = frm.fV0
            fV1 = frm.fV1
            fV2 = frm.fV2
            fV3 = frm.fV3
            fV4 = frm.fV4

            fProkachkaCheck = frm.fCheck0
            fCheck1 = frm.fCheck1
            fCheck2 = frm.fCheck2
            fCheck3 = frm.fCheck3
            fCheck4 = frm.fCheck4

            fBs1 = frm.fBs1
            fBs2 = frm.fBs2
            fBs3 = frm.fBs3
            fBs4 = frm.fBs4

            fBr1 = frm.fBr1
            fBr2 = frm.fBr2
            fBr3 = frm.fBr3
            fBr4 = frm.fBr4

            fBReg1 = frm.fBreg1
            fBReg2 = frm.fBreg2
            fBReg3 = frm.fBreg3
            fBReg4 = frm.fBreg4

            fE1 = frm.fE1
            fE2 = frm.fE2
            fE3 = frm.fE3
            fE4 = frm.fE4

            fDE1 = frm.fDE1
            fDE2 = frm.fDE2
            fDE3 = frm.fDE3
            fDE4 = frm.fDE4

            fEReg1 = frm.fEreg1
            fEReg2 = frm.fEreg2
            fEReg3 = frm.fEreg3
            fEReg4 = frm.fEreg4

            fS1 = frm.fS1
            fS2 = frm.fS2
            fS3 = frm.fS3
            fS4 = frm.fS4

            fSReg1 = frm.fSReg1
            fSReg2 = frm.fSReg2
            fSReg3 = frm.fSReg3
            fSReg4 = frm.fSReg4

            fReg1 = frm.fGReg1
            fReg2 = frm.fGReg2
            fReg3 = frm.fGReg3
            fReg4 = frm.fGReg4

        End If
        frm.Dispose()

    End Sub
End Class