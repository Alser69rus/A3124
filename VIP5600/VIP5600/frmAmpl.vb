Public Class frmAmpl
    Dim L As Single
    Dim R As Single
    Dim Amin As Single
    Dim Amax As Single


    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        frmDatchiki.Show()
        Me.Close()

    End Sub

    Private Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        frmDatchiki.Show()
        Me.Close()
    End Sub

    Public Sub New()

        ' Этот вызов является обязательным для конструктора.
        InitializeComponent()

        ' Добавьте все инициализирующие действия после вызова InitializeComponent().

        L = frmGMain.stend.rw.LEN_DATCHIK_DISTANCE
        R = frmGMain.stend.rw.R_DATCHIK_DISTANCE
        Amin = frmGMain.stend.rw.MIN_AMPL
        Amax = frmGMain.stend.rw.MAX_AMPL


        btnL.Text = "ΔL=" & L & " мм"
        btnU.Text = "ΔU=" & R * 0.016 & " В"
        btnMin.Text = "Минимальный ход " & Amin & " мм"
        btnMax.Text = "Максимальный ход " & Amax & " мм"

    End Sub

    Private Sub btnOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOk.Click
        frmGMain.stend.rw.LEN_DATCHIK_DISTANCE = L
        frmGMain.stend.rw.R_DATCHIK_DISTANCE = R
        frmGMain.stend.rw.MIN_AMPL = Amin
        frmGMain.stend.rw.MAX_AMPL = Amax

        frmDatchiki.Show()
        Me.Close()
    End Sub

    Private Sub btnL_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnL.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = L
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            L = frm.btnResult.Text
            btnL.Text = "ΔL=" & L & " мм"
        End If
        frm.Dispose()
    End Sub

    Private Sub btnU_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnU.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = 0.016 * R
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            R = frm.btnResult.Text / 0.016
            btnU.Text = "ΔU=" & R * 0.016 & " В"
        End If
        frm.Dispose()
    End Sub

    Private Sub btnMin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMin.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = Amin
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Amin = frm.btnResult.Text
            If Amin < 18 Then Amin = 18
            If Amin > 29 Then Amin = 29
            btnMin.Text = "Минимальный ход " & Amin & " мм"
        End If
        frm.Dispose()
    End Sub


    Private Sub btnMax_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMax.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = Amax
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Amax = frm.btnResult.Text
            If Amax > 42 Then Amax = 42
            If Amax < 31 Then Amax = 31
            btnMax.Text = "Максимальный ход " & Amax & " мм"
        End If
        frm.Dispose()
    End Sub
End Class