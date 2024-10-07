Public Class aseOptimA

    Public fV0 As Single = 0.3
    Public fV1 As Single = 0.02
    Public fV2 As Single = 0.15
    Public fV3 As Single = 0.3
    Public fV4 As Single = 0.6

    Public fA0 As Single = 40
    Public fA1 As Single = 40
    Public fA2 As Single = 40
    Public fA3 As Single = 40
    Public fA4 As Single = 40

    Public fCheck0 As Boolean = True
    Public fCheck1 As Boolean = True
    Public fCheck2 As Boolean = True
    Public fCheck3 As Boolean = True
    Public fCheck4 As Boolean = True


    Public Sub RefreshField()
        btnA0.Text = "А0=" & fA0.ToString("f1") & " мм"
        btnA1.Text = "А1=" & fA1.ToString("f1") & " мм"
        btnA2.Text = "А2=" & fA2.ToString("f1") & " мм"
        btnA3.Text = "А3=" & fA3.ToString("f1") & " мм"
        btnA4.Text = "А4=" & fA4.ToString("f1") & " мм"

        btnV0.Text = "V0=" & fV0.ToString("f3") & " м/с"
        btnV1.Text = "V1=" & fV1.ToString("f3") & " м/с"
        btnV2.Text = "V2=" & fV2.ToString("f3") & " м/с"
        btnV3.Text = "V3=" & fV3.ToString("f3") & " м/с"
        btnV4.Text = "V4=" & fV4.ToString("f3") & " м/с"

        If fCheck0 Then
            btnA0.Visible = True
            btnV0.Visible = True
            btnOpt.Visible = True
        Else
            btnA0.Visible = False
            btnV0.Visible = False
            btnOpt.Visible = False
        End If
        If fCheck1 Then
            btnA1.Visible = True
            btnV1.Visible = True
            btnOpt.Visible = True
        Else
            btnA1.Visible = False
            btnV1.Visible = False
            btnOpt.Visible = False
        End If
        If fCheck2 Then
            btnA2.Visible = True
            btnV2.Visible = True
        Else
            btnA2.Visible = False
            btnV2.Visible = False
        End If
        If fCheck3 Then
            btnA3.Visible = True
            btnV3.Visible = True
        Else
            btnA3.Visible = False
            btnV3.Visible = False
        End If
        If fCheck4 Then
            btnA4.Visible = True
            btnV4.Visible = True
        Else
            btnA4.Visible = False
            btnV4.Visible = False
        End If
    End Sub

    Private Sub btnA0_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnA0.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = Math.Round(fA0, 1)
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fA0 = frm.btnResult.Text
            If fA0 < functAmin(fV0) Then fA0 = functAmin(fV0)
            If fA0 > functAmax(fV0) Then fA0 = functAmax(fV0)
            RefreshField()

        End If

        frm.Dispose()

    End Sub

    Private Sub btnA1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnA1.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = Math.Round(fA1, 1)
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fA1 = frm.btnResult.Text
            If fA1 < functAmin(fV1) Then fA1 = functAmin(fV1)
            If fA1 > functAmax(fV1) Then fA1 = functAmax(fV1)
            RefreshField()

        End If

        frm.Dispose()
    End Sub

    Private Sub btnA2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnA2.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = Math.Round(fA2, 1)
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fA2 = frm.btnResult.Text
            If fA2 < functAmin(fV2) Then fA2 = functAmin(fV2)
            If fA2 > functAmax(fV2) Then fA2 = functAmax(fV2)
            RefreshField()

        End If

        frm.Dispose()
    End Sub

    Private Sub btnA3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnA3.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = Math.Round(fA3, 1)
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fA3 = frm.btnResult.Text
            If fA3 < functAmin(fV3) Then fA3 = functAmin(fV3)
            If fA3 > functAmax(fV3) Then fA3 = functAmax(fV3)
            RefreshField()

        End If

        frm.Dispose()
    End Sub

    Private Sub btnA4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnA4.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = Math.Round(fA4, 1)
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fA4 = frm.btnResult.Text
            If fA4 < functAmin(fV4) Then fA4 = functAmin(fV4)
            If fA4 > functAmax(fV4) Then fA4 = functAmax(fV4)
            RefreshField()

        End If

        frm.Dispose()
    End Sub

    Private Sub btnOpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpt.Click

        Dim A As Single = functAmin(fV0)
        Dim B As Single = functAmax(fV0)
        Dim C As Integer = 0

        If Cross(A, B, fV1) Then
            A = Amin(A, fV1)
            B = Amax(B, fV1)
            If Cross(A, B, fV2) Then
                A = Amin(A, fV2)
                B = Amax(B, fV2)
                If Cross(A, B, fV3) Then
                    A = Amin(A, fV3)
                    B = Amax(B, fV3)
                    If Cross(A, B, fV4) Then
                        A = Amin(A, fV4)
                        B = Amax(B, fV4)
                        fA0 = Math.Round((A + B) / 2, 1)
                        fA1 = fA0
                        fA2 = fA0
                        fA3 = fA0
                        fA4 = fA0
                    Else
                        fA0 = Math.Round((A + B) / 2, 1)
                        fA1 = fA0
                        fA2 = fA0
                        fA3 = fA0
                        A = functAmin(fV4)
                        B = functAmax(fV4)
                        fA4 = Math.Round((A + B) / 2, 1)
                    End If
                Else
                    C = 3
                    fA0 = Math.Round((A + B) / 2, 1)
                    fA1 = fA0
                    fA2 = fA0
                    A = functAmin(fV3)
                    B = functAmax(fV3)
                    If Cross(A, B, fV4) Then
                        A = Amin(A, fV4)
                        B = Amax(B, fV4)
                        fA3 = Math.Round((A + B) / 2, 1)
                        fA4 = fA3
                    Else
                        fA3 = Math.Round((A + B) / 2, 1)
                        A = functAmin(fV4)
                        B = functAmax(fV4)
                        fA4 = Math.Round((A + B) / 2, 1)
                    End If
                End If
            Else
                C = 2
                fA0 = Math.Round((A + B) / 2, 1)
                fA1 = fA0
                A = functAmin(fV2)
                B = functAmax(fV2)
                If Cross(A, B, fV3) Then
                    A = Amin(A, fV3)
                    B = Amax(B, fV3)
                    If Cross(A, B, fV4) Then
                        A = Amin(A, fV4)
                        B = Amax(B, fV4)
                        fA2 = Math.Round((A + B) / 2, 1)
                        fA3 = fA2
                        fA4 = fA2
                    Else
                        fA2 = Math.Round((A + B) / 2, 1)
                        fA3 = fA2
                        A = functAmin(fV4)
                        B = functAmax(fV4)
                        fA4 = Math.Round((A + B) / 2, 1)
                    End If
                Else
                    C = 3
                    fA2 = Math.Round((A + B) / 2, 1)
                    A = functAmin(fV3)
                    B = functAmax(fV3)
                    If Cross(A, B, fV4) Then
                        A = Amin(A, fV4)
                        B = Amax(B, fV4)
                        fA3 = Math.Round((A + B) / 2, 1)
                        fA4 = fA3
                    Else
                        fA3 = Math.Round((A + B) / 2, 1)
                        A = functAmin(fV4)
                        B = functAmax(fV4)
                        fA4 = Math.Round((A + B) / 2, 1)
                    End If
                End If
            End If
        Else
            C = 1
            fA0 = Math.Round((A + B) / 2, 1)
            A = functAmin(fV1)
            B = functAmax(fV1)
            If Cross(A, B, fV2) Then
                A = Amin(A, fV2)
                B = Amax(B, fV2)
                If Cross(A, B, fV3) Then
                    A = Amin(A, fV3)
                    B = Amax(B, fV3)
                    If Cross(A, B, fV4) Then
                        A = Amin(A, fV4)
                        B = Amax(B, fV4)
                        fA1 = Math.Round((A + B) / 2, 1)
                        fA2 = fA1
                        fA3 = fA1
                        fA4 = fA1
                    Else
                        fA1 = Math.Round((A + B) / 2, 1)
                        fA2 = fA1
                        fA3 = fA1
                        A = functAmin(fV4)
                        B = functAmax(fV4)
                        fA4 = Math.Round((A + B) / 2, 1)
                    End If
                Else
                    C = 3
                    fA1 = Math.Round((A + B) / 2, 1)
                    fA2 = fA1
                    A = functAmin(fV3)
                    B = functAmax(fV3)
                    If Cross(A, B, fV4) Then
                        A = Amin(A, fV4)
                        B = Amax(B, fV4)
                        fA3 = Math.Round((A + B) / 2, 1)
                        fA4 = fA3
                    Else
                        fA3 = Math.Round((A + B) / 2, 1)
                        A = functAmin(fV4)
                        B = functAmax(fV4)
                        fA4 = Math.Round((A + B) / 2, 1)
                    End If
                End If
            Else
                C = 2
                fA1 = Math.Round((A + B) / 2, 1)
                A = functAmin(fV2)
                B = functAmax(fV2)
                If Cross(A, B, fV3) Then
                    A = Amin(A, fV3)
                    B = Amax(B, fV3)
                    If Cross(A, B, fV4) Then
                        A = Amin(A, fV4)
                        B = Amax(B, fV4)
                        fA2 = Math.Round((A + B) / 2, 1)
                        fA3 = fA2
                        fA4 = fA2
                    Else
                        fA2 = Math.Round((A + B) / 2, 1)
                        fA3 = fA2
                        A = functAmin(fV4)
                        B = functAmax(fV4)
                        fA4 = Math.Round((A + B) / 2, 1)
                    End If
                Else
                    C = 3
                    fA2 = Math.Round((A + B) / 2, 1)
                    A = functAmin(fV3)
                    B = functAmax(fV3)
                    If Cross(A, B, fV4) Then
                        A = Amin(A, fV4)
                        B = Amax(B, fV4)
                        fA3 = Math.Round((A + B) / 2, 1)
                        fA4 = fA3
                    Else
                        fA3 = Math.Round((A + B) / 2, 1)
                        A = functAmin(fV4)
                        B = functAmax(fV4)
                        fA4 = Math.Round((A + B) / 2, 1)
                    End If
                End If
            End If
        End If

        RefreshField()

    End Sub


    Private Function Amin(ByVal A As Single, ByVal V As Single) As Single
        Dim A0 As Single = functAmin(V)
        A0 = Math.Max(A0, A)
        Return A0
    End Function

    Private Function Amax(ByVal B As Single, ByVal V As Single) As Single
        Dim B0 As Single = functAmax(V)
        B0 = Math.Min(B0, B)
        Return B0
    End Function

    Private Function Cross(ByVal A As Single, ByVal B As Single, ByVal V As Single) As Boolean
        A = Amin(A, V)
        B = Amax(B, V)
        If A > B Then
            Return False
        Else
            Return True
        End If
    End Function
End Class