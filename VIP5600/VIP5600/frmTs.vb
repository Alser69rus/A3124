Public Class frmTs

    Dim t1 As Single
    Dim t2 As Single
    Dim u1 As Single
    Dim u2 As Single
    Dim u As Single
    Dim t As Single



    Private Sub btnOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOk.Click
        frmGMain.stend.rw.T_MIN_OKR_SREDY = t1
        frmGMain.stend.rw.T_MAX_OKR_SREDY = t2
        frmGMain.stend.rw.U_MIN_OKR_SREDY = u1
        frmGMain.stend.rw.U_T_OKR_SREDY = u2

        frmDatchiki.Show()
        Me.Close()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        frmDatchiki.Show()
        Me.Close()
    End Sub

    Public Sub New()

        ' Этот вызов является обязательным для конструктора.
        InitializeComponent()

        t1 = frmGMain.stend.rw.T_MIN_OKR_SREDY
        t2 = frmGMain.stend.rw.T_MAX_OKR_SREDY
        u1 = frmGMain.stend.rw.U_MIN_OKR_SREDY
        u2 = frmGMain.stend.rw.U_T_OKR_SREDY

        btnT1.Text = "t min=" & t1 & " °C"
        btnT2.Text = "t max=" & t2 & " °C"
        btnU1.Text = "U min=" & u1 & " В"
        btnU2.Text = "U max=" & u2 & " В"

    End Sub

    Private Sub btnT1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnT1.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = t1
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            t1 = frm.btnResult.Text
            btnT1.Text = "t min=" & t1 & " °C"
        End If
        frm.Dispose()

    End Sub

    Private Sub btnT2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnT2.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = t2
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            t2 = frm.btnResult.Text
            btnT2.Text = "t max=" & t2 & " °C"
        End If
        frm.Dispose()
    End Sub

    Private Sub btnU1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnU1.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = u1
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            u1 = frm.btnResult.Text
            btnU1.Text = "U min=" & u1 & " В"
        End If
        frm.Dispose()
    End Sub

    Private Sub btnU2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnU2.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = u2
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            u2 = frm.btnResult.Text
            btnU2.Text = "U max=" & u2 & " В"
        End If
        frm.Dispose()
    End Sub

    Public Sub refreshT(ByRef Ch1() As Short)
        u = 0
        For i = 0 To 2047
            u = u + Ch1(i)
        Next
        u = 5 * u / (2048 * lHALF_DISCRETS)
        t = frmGMain.opros.Tsredi.GetValue(1, False)
        btnT.Text = "t=" & t & " °C"
        btnU.Text = "U=" & u & " В"

    End Sub

    Private Sub btnSetU1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSetU1.Click
        u1 = u
        btnU1.Text = "U min=" & u1 & " В"
    End Sub

    Private Sub btnSetU2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSetU2.Click
        u2 = u
        btnU2.Text = "U min=" & u2 & " В"
    End Sub

    Private Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        frmDatchiki.Show()
        Me.Close()

    End Sub
End Class