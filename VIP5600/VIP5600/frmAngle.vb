Public Class frmAngle
    Dim a1 As Single
    Dim a2 As Single
    Dim u1 As Single
    Dim u2 As Single
    Dim u As Single
    Dim a As Single



    Private Sub btnOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOk.Click
        frmGMain.stend.rw.BASE_ANGLE = a1
        frmGMain.stend.rw.PER_RED_ANGLE = 360 / (a2 - a1)
        frmGMain.stend.rw.U_MIN_ENCODER = u1
        frmGMain.stend.rw.U_MAX_ENCODER = u2

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

        a1 = frmGMain.stend.rw.BASE_ANGLE
        a2 = 360 / frmGMain.stend.rw.PER_RED_ANGLE - frmGMain.stend.rw.BASE_ANGLE
        u1 = frmGMain.stend.rw.U_MIN_ENCODER
        u2 = frmGMain.stend.rw.U_MAX_ENCODER

        btnA1.Text = "Угол min=" & a1 & " °"
        btnA2.Text = "Угол max=" & a2 & " °"
        btnU1.Text = "U min=" & u1 & " В"
        btnU2.Text = "U max=" & u2 & " В"

    End Sub

    Private Sub btnT1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnA1.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = a1
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            a1 = frm.btnResult.Text
            btnA1.Text = "Угол min=" & a1 & " °"
        End If
        frm.Dispose()

    End Sub

    Private Sub btnT2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnA2.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = a2
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            a2 = frm.btnResult.Text
            btnA2.Text = "Угол max=" & a2 & " °"
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

    Public Sub refreshT(ByRef Ch0() As Short)
        u = 0
        For i = 0 To 2047
            u = u + Ch0(i)
        Next
        u = 5 * u / (2048 * lHALF_DISCRETS)
        a = frmGMain.opros.AngleE.GetValue(1, False)
        btnA.Text = "Угол=" & a & " °"
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