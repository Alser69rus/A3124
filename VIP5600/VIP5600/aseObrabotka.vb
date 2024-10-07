Public Class aseObrabotka

    Public fV0 As Single = 0.3
    Public fV1 As Single = 0.075
    Public fV2 As Single = 0.15
    Public fV3 As Single = 0.3
    Public fV4 As Single = 0.6

    Public fA0 As Single = 40
    Public fA1 As Single = 40
    Public fA2 As Single = 40
    Public fA3 As Single = 40
    Public fA4 As Single = 40

    Public fCheck0 As Boolean = False
    Public fCheck1 As Boolean = False
    Public fCheck2 As Boolean = False
    Public fCheck3 As Boolean = False
    Public fCheck4 As Boolean = False

    Public fBs1 As Single = 100
    Public fBs2 As Single = 100
    Public fBs3 As Single = 100
    Public fBs4 As Single = 100

    Public fBr1 As Single = 100
    Public fBr2 As Single = 100
    Public fBr3 As Single = 100
    Public fBr4 As Single = 100

    Public fBreg1 As Integer = 0
    Public fBreg2 As Integer = 0
    Public fBreg3 As Integer = 0
    Public fBreg4 As Integer = 0

    Public fE1 As Single = 1440
    Public fE2 As Single = 1440
    Public fE3 As Single = 1440
    Public fE4 As Single = 1440

    Public fDE1 As Single = 360
    Public fDE2 As Single = 360
    Public fDE3 As Single = 360
    Public fDE4 As Single = 360

    Public fEreg1 As Integer = 0
    Public fEreg2 As Integer = 0
    Public fEreg3 As Integer = 0
    Public fEreg4 As Integer = 0

    Public fS1 As Single = 25
    Public fS2 As Single = 25
    Public fS3 As Single = 25
    Public fS4 As Single = 25

    Public fSReg1 As Integer = 0
    Public fSReg2 As Integer = 0
    Public fSReg3 As Integer = 0
    Public fSReg4 As Integer = 0

    Public fGReg1 As Integer = 0
    Public fGReg2 As Integer = 0
    Public fGReg3 As Integer = 0
    Public fGReg4 As Integer = 0


    Private Sub btnOptim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOptim.Click
        Dim frm As New aseOptimA

        frm.fV0 = fV0
        frm.fV1 = fV1
        frm.fV2 = fV2
        frm.fV3 = fV3
        frm.fV4 = fV4

        frm.fA0 = fA0
        frm.fA1 = fA1
        frm.fA2 = fA2
        frm.fA3 = fA3
        frm.fA4 = fA4

        frm.fCheck0 = fCheck0
        frm.fCheck1 = fCheck1
        frm.fCheck2 = fCheck2
        frm.fCheck3 = fCheck3
        frm.fCheck4 = fCheck4

        frm.RefreshField()

        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

            fA0 = frm.fA0
            fA1 = frm.fA1
            fA2 = frm.fA2
            fA3 = frm.fA3
            fA4 = frm.fA4
        End If
        frm.Dispose()

    End Sub

    Private Sub btnB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnB.Click
        Dim frm As New aseOptimB
        frm.fBs1 = fBs1
        frm.fBs2 = fBs2
        frm.fBs3 = fBs3
        frm.fBs4 = fBs4

        frm.fBr1 = fBr1
        frm.fBr2 = fBr2
        frm.fBr3 = fBr3
        frm.fBr4 = fBr4

        frm.fBreg1 = fBreg1
        frm.fBreg2 = fBreg2
        frm.fBreg3 = fBreg3
        frm.fBreg4 = fBreg4

        frm.fCheck1 = fCheck1
        frm.fCheck2 = fCheck2
        frm.fCheck3 = fCheck3
        frm.fCheck4 = fCheck4

        frm.RefreshField()
        If frm.ShowDialog Then
            fBs1 = frm.fBs1
            fBs2 = frm.fBs2
            fBs3 = frm.fBs3
            fBs4 = frm.fBs4

            fBr1 = frm.fBr1
            fBr2 = frm.fBr2
            fBr3 = frm.fBr3
            fBr4 = frm.fBr4

            fBreg1 = frm.fBreg1
            fBreg2 = frm.fBreg2
            fBreg3 = frm.fBreg3
            fBreg4 = frm.fBreg4

        End If
        frm.Dispose()

    End Sub

    Private Sub btnE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnE.Click
        Dim frm As New aseOptimE
        frm.fE1 = fE1
        frm.fE2 = fE2
        frm.fE3 = fE3
        frm.fE4 = fE4

        frm.fDE1 = fDE1
        frm.fDE2 = fDE2
        frm.fDE3 = fDE3
        frm.fDE4 = fDE4

        frm.fReg1 = fEreg1
        frm.fReg2 = fEreg2
        frm.fReg3 = fEreg3
        frm.fReg4 = fEreg4

        frm.fCheck1 = fCheck1
        frm.fCheck2 = fCheck2
        frm.fCheck3 = fCheck3
        frm.fCheck4 = fCheck4

        frm.RefreshField()
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fE1 = frm.fE1
            fE2 = frm.fE2
            fE3 = frm.fE3
            fE4 = frm.fE4

            fDE1 = frm.fDE1
            fDE2 = frm.fDE2
            fDE3 = frm.fDE3
            fDE4 = frm.fDE4

            fEreg1 = frm.fReg1
            fEreg2 = frm.fReg2
            fEreg3 = frm.fReg3
            fEreg4 = frm.fReg4

        End If
        frm.Dispose()
    End Sub

    Private Sub btnS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnS.Click
        Dim frm As New aseOptimS
        frm.fS1 = fS1
        frm.fS2 = fS2
        frm.fS3 = fS3
        frm.fS4 = fS4

        frm.fReg1 = fSReg1
        frm.fReg2 = fSReg2
        frm.fReg3 = fSReg3
        frm.fReg4 = fSReg4

        frm.fCheck1 = fCheck1
        frm.fCheck2 = fCheck2
        frm.fCheck3 = fCheck3
        frm.fCheck4 = fCheck4

        frm.RefreshField()
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fS1 = frm.fS1
            fS2 = frm.fS2
            fS3 = frm.fS3
            fS4 = frm.fS4

            fSReg1 = frm.fReg1
            fSReg2 = frm.fReg2
            fSReg3 = frm.fReg3
            fSReg4 = frm.fReg4

        End If
        frm.Dispose()

    End Sub

    Private Sub btnG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnG.Click
        Dim frm As New aseOptimG
        frm.fReg1 = fGReg1
        frm.fReg2 = fGReg2
        frm.fReg3 = fGReg3
        frm.fReg4 = fGReg4

        frm.fV1 = fV1
        frm.fV2 = fV2
        frm.fV3 = fV3
        frm.fV4 = fV4

        frm.fCheck1 = fCheck1
        frm.fCheck2 = fCheck2
        frm.fCheck3 = fCheck3
        frm.fCheck4 = fCheck4

        frm.RefreshField()
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fGReg1 = frm.fReg1
            fGReg2 = frm.fReg2
            fGReg3 = frm.fReg3
            fGReg4 = frm.fReg4

        End If
        frm.Dispose()
    End Sub
End Class