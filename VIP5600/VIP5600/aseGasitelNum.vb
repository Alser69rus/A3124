Public Class aseGasitelNum
    Public fNum As String

    Private Sub aseGasitelNum_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim frm As New frmKeypad
        frm.Location = New Point(14, 190)
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fNum = frm.btnResult.Text
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
        frm.Dispose()
        Me.Close()

    End Sub
End Class