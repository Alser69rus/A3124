Public Class frmNumpad

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim s As String
        Dim i As Double
        s = btnResult.Text
        s = s & "1"
        i = s
        s = i
        btnResult.Text = s
    End Sub

    Private Sub Button10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim s As String
        'Dim i As Double
        s = btnResult.Text
        If s <> "0" Then s = s & "0"
        'i = s
        's = i
        btnResult.Text = s
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim s As String
        Dim i As Double
        s = btnResult.Text
        s = s & "2"
        i = s
        s = i
        btnResult.Text = s
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim s As String
        Dim i As Double
        s = btnResult.Text
        s = s & "3"
        i = s
        s = i
        btnResult.Text = s
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim s As String
        Dim i As Double
        s = btnResult.Text
        s = s & "4"
        i = s
        s = i
        btnResult.Text = s
    End Sub

    Private Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim s As String
        Dim i As Double
        s = btnResult.Text
        s = s & "5"
        i = s
        s = i
        btnResult.Text = s
    End Sub

    Private Sub Button6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim s As String
        Dim i As Double
        s = btnResult.Text
        s = s & "6"
        i = s
        s = i
        btnResult.Text = s
    End Sub

    Private Sub Button7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim s As String
        Dim i As Double
        s = btnResult.Text
        s = s & "7"
        i = s
        s = i
        btnResult.Text = s
    End Sub

    Private Sub Button8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim s As String
        Dim i As Double
        s = btnResult.Text
        s = s & "8"
        i = s
        s = i
        btnResult.Text = s
    End Sub

    Private Sub Button9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim s As String
        Dim i As Double
        s = btnResult.Text
        s = s & "9"
        i = s
        s = i
        btnResult.Text = s
    End Sub

    Private Sub btnSign_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSign.Click
        Dim s As String
        Dim i As Double

        s = btnResult.Text

        i = s
        i = -i

        btnResult.Text = i
    End Sub

    Private Sub btnPoint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPoint.Click
        Dim s As String
        Dim i As Integer
        s = btnResult.Text
        i = s.IndexOf(",")
        If i = -1 Then
            s = s + ","
        End If
        btnResult.Text = s

    End Sub

    Private Sub btnDel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Dim s As String
        Dim i As Integer
        s = btnResult.Text
        i = s.Length
        If i > 1 Then
            s = s.Substring(0, s.Length - 1)
        ElseIf i = 1 Then
            s = "0"
        End If

        btnResult.Text = s
    End Sub
End Class