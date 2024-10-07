Public Class frmKeypad
    Dim Shift As eShift = eShift.Up

    Enum eShift
        Caps
        Up
        Down
    End Enum

    Private Sub btnShift_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnShift.Click

        Select Case Shift
            Case eShift.Down
                Shift = eShift.Up
            Case eShift.Up
                Shift = eShift.Caps
            Case eShift.Caps
                Shift = eShift.Down
        End Select

        KeyUpdate()

    End Sub
    Private Sub KeyUpdate()

        Select Case Shift
            Case eShift.Up
                btnShift.ForeColor = Color.Green
            Case eShift.Caps
                btnShift.ForeColor = Color.Red
            Case eShift.Down
                btnShift.ForeColor = Color.Black
        End Select

        Select Case Shift
            Case eShift.Down
                btn11.Text = "й"
                btn12.Text = "ц"
                btn13.Text = "у"
                btn14.Text = "к"
                btn15.Text = "е"
                btn16.Text = "н"
                btn17.Text = "г"
                btn18.Text = "ш"
                btn19.Text = "щ"
                btn110.Text = "з"
                btn111.Text = "х"
                btn112.Text = "ъ"

                btn21.Text = "ф"
                btn22.Text = "ы"
                btn23.Text = "в"
                btn24.Text = "а"
                btn25.Text = "п"
                btn26.Text = "р"
                btn27.Text = "о"
                btn28.Text = "л"
                btn29.Text = "д"
                btn210.Text = "ж"
                btn211.Text = "э"

                btn31.Text = "я"
                btn32.Text = "ч"
                btn33.Text = "с"
                btn34.Text = "м"
                btn35.Text = "и"
                btn36.Text = "т"
                btn37.Text = "ь"
                btn38.Text = "б"
                btn39.Text = "ю"
                btn310.Text = "ё"
            Case Else
                btn11.Text = "Й"
                btn12.Text = "Ц"
                btn13.Text = "У"
                btn14.Text = "К"
                btn15.Text = "Е"
                btn16.Text = "Н"
                btn17.Text = "Г"
                btn18.Text = "Ш"
                btn19.Text = "Щ"
                btn110.Text = "З"
                btn111.Text = "Х"
                btn112.Text = "Ъ"

                btn21.Text = "Ф"
                btn22.Text = "Ы"
                btn23.Text = "В"
                btn24.Text = "А"
                btn25.Text = "П"
                btn26.Text = "Р"
                btn27.Text = "О"
                btn28.Text = "Л"
                btn29.Text = "Д"
                btn210.Text = "Ж"
                btn211.Text = "Э"

                btn31.Text = "Я"
                btn32.Text = "Ч"
                btn33.Text = "С"
                btn34.Text = "М"
                btn35.Text = "И"
                btn36.Text = "Т"
                btn37.Text = "Ь"
                btn38.Text = "Б"
                btn39.Text = "Ю"
                btn310.Text = "Ё"
        End Select
    End Sub

    Private Sub btn11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn11.Click
        btnResult.Text = btnResult.Text & btn11.Text

        If Shift = eShift.Up Then
            Shift = eShift.Down
            KeyUpdate()
        End If
    End Sub

    Private Sub btn12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn12.Click
        btnResult.Text = btnResult.Text & btn12.Text

        If Shift = eShift.Up Then
            Shift = eShift.Down
            KeyUpdate()
        End If
    End Sub

    Private Sub btn13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn13.Click
        btnResult.Text = btnResult.Text & btn13.Text

        If Shift = eShift.Up Then
            Shift = eShift.Down
            KeyUpdate()
        End If
    End Sub

    Private Sub btn14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn14.Click
        btnResult.Text = btnResult.Text & btn14.Text

        If Shift = eShift.Up Then
            Shift = eShift.Down
            KeyUpdate()
        End If
    End Sub

    Private Sub btn15_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn15.Click
        btnResult.Text = btnResult.Text & btn15.Text

        If Shift = eShift.Up Then
            Shift = eShift.Down
            KeyUpdate()
        End If
    End Sub

    Private Sub btn16_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn16.Click
        btnResult.Text = btnResult.Text & btn16.Text

        If Shift = eShift.Up Then
            Shift = eShift.Down
            KeyUpdate()
        End If
    End Sub

    Private Sub btn17_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn17.Click
        btnResult.Text = btnResult.Text & btn17.Text

        If Shift = eShift.Up Then
            Shift = eShift.Down
            KeyUpdate()
        End If
    End Sub

    Private Sub btn18_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn18.Click
        btnResult.Text = btnResult.Text & btn18.Text

        If Shift = eShift.Up Then
            Shift = eShift.Down
            KeyUpdate()
        End If
    End Sub

    Private Sub btn19_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn19.Click
        btnResult.Text = btnResult.Text & btn19.Text

        If Shift = eShift.Up Then
            Shift = eShift.Down
            KeyUpdate()
        End If
    End Sub

    Private Sub btn110_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn110.Click
        btnResult.Text = btnResult.Text & btn110.Text

        If Shift = eShift.Up Then
            Shift = eShift.Down
            KeyUpdate()
        End If
    End Sub

    Private Sub btn111_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn111.Click
        btnResult.Text = btnResult.Text & btn111.Text

        If Shift = eShift.Up Then
            Shift = eShift.Down
            KeyUpdate()
        End If
    End Sub

    Private Sub btn112_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn112.Click
        btnResult.Text = btnResult.Text & btn112.Text

        If Shift = eShift.Up Then
            Shift = eShift.Down
            KeyUpdate()
        End If
    End Sub

    Private Sub btn21_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn21.Click
        btnResult.Text = btnResult.Text & btn21.Text

        If Shift = eShift.Up Then
            Shift = eShift.Down
            KeyUpdate()
        End If
    End Sub

    Private Sub btn22_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn22.Click
        btnResult.Text = btnResult.Text & btn22.Text

        If Shift = eShift.Up Then
            Shift = eShift.Down
            KeyUpdate()
        End If
    End Sub

    Private Sub btn23_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn23.Click
        btnResult.Text = btnResult.Text & btn23.Text

        If Shift = eShift.Up Then
            Shift = eShift.Down
            KeyUpdate()
        End If
    End Sub

    Private Sub btn24_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn24.Click
        btnResult.Text = btnResult.Text & btn24.Text

        If Shift = eShift.Up Then
            Shift = eShift.Down
            KeyUpdate()
        End If
    End Sub

    Private Sub btn25_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn25.Click
        btnResult.Text = btnResult.Text & btn25.Text

        If Shift = eShift.Up Then
            Shift = eShift.Down
            KeyUpdate()
        End If
    End Sub

    Private Sub btn26_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn26.Click
        btnResult.Text = btnResult.Text & btn26.Text

        If Shift = eShift.Up Then
            Shift = eShift.Down
            KeyUpdate()
        End If
    End Sub

    Private Sub btn27_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn27.Click
        btnResult.Text = btnResult.Text & btn27.Text

        If Shift = eShift.Up Then
            Shift = eShift.Down
            KeyUpdate()
        End If
    End Sub

    Private Sub btn28_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn28.Click
        btnResult.Text = btnResult.Text & btn28.Text

        If Shift = eShift.Up Then
            Shift = eShift.Down
            KeyUpdate()
        End If
    End Sub

    Private Sub btn29_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn29.Click
        btnResult.Text = btnResult.Text & btn29.Text

        If Shift = eShift.Up Then
            Shift = eShift.Down
            KeyUpdate()
        End If
    End Sub

    Private Sub btn210_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn210.Click
        btnResult.Text = btnResult.Text & btn210.Text

        If Shift = eShift.Up Then
            Shift = eShift.Down
            KeyUpdate()
        End If
    End Sub

    Private Sub btn211_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn211.Click
        btnResult.Text = btnResult.Text & btn211.Text

        If Shift = eShift.Up Then
            Shift = eShift.Down
            KeyUpdate()
        End If
    End Sub

    Private Sub btn31_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn31.Click
        btnResult.Text = btnResult.Text & btn31.Text

        If Shift = eShift.Up Then
            Shift = eShift.Down
            KeyUpdate()
        End If
    End Sub

    Private Sub btn32_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn32.Click
        btnResult.Text = btnResult.Text & btn32.Text

        If Shift = eShift.Up Then
            Shift = eShift.Down
            KeyUpdate()
        End If
    End Sub

    Private Sub btn33_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn33.Click
        btnResult.Text = btnResult.Text & btn33.Text

        If Shift = eShift.Up Then
            Shift = eShift.Down
            KeyUpdate()
        End If
    End Sub

    Private Sub btn34_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn34.Click
        btnResult.Text = btnResult.Text & btn34.Text

        If Shift = eShift.Up Then
            Shift = eShift.Down
            KeyUpdate()
        End If
    End Sub

    Private Sub btn35_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn35.Click
        btnResult.Text = btnResult.Text & btn35.Text

        If Shift = eShift.Up Then
            Shift = eShift.Down
            KeyUpdate()
        End If
    End Sub

    Private Sub btn36_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn36.Click
        btnResult.Text = btnResult.Text & btn36.Text

        If Shift = eShift.Up Then
            Shift = eShift.Down
            KeyUpdate()
        End If
    End Sub

    Private Sub btn37_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn37.Click
        btnResult.Text = btnResult.Text & btn37.Text

        If Shift = eShift.Up Then
            Shift = eShift.Down
            KeyUpdate()
        End If
    End Sub

    Private Sub btn38_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn38.Click
        btnResult.Text = btnResult.Text & btn38.Text

        If Shift = eShift.Up Then
            Shift = eShift.Down
            KeyUpdate()
        End If
    End Sub

    Private Sub btn39_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn39.Click
        btnResult.Text = btnResult.Text & btn39.Text

        If Shift = eShift.Up Then
            Shift = eShift.Down
            KeyUpdate()
        End If
    End Sub

    Private Sub btn310_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn310.Click
        btnResult.Text = btnResult.Text & btn310.Text

        If Shift = eShift.Up Then
            Shift = eShift.Down
            KeyUpdate()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        btnResult.Text = btnResult.Text & "1"

    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        btnResult.Text = btnResult.Text & "2"
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        btnResult.Text = btnResult.Text & "3"
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        btnResult.Text = btnResult.Text & "4"
    End Sub

    Private Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click
        btnResult.Text = btnResult.Text & "5"
    End Sub

    Private Sub Button6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.Click
        btnResult.Text = btnResult.Text & "6"
    End Sub

    Private Sub Button7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.Click
        btnResult.Text = btnResult.Text & "7"
    End Sub

    Private Sub Button8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button8.Click
        btnResult.Text = btnResult.Text & "8"
    End Sub

    Private Sub Button9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button9.Click
        btnResult.Text = btnResult.Text & "9"
    End Sub

    Private Sub Button10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button10.Click
        btnResult.Text = btnResult.Text & "0"
    End Sub

    Private Sub btnSpace_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSpace.Click
        btnResult.Text = btnResult.Text & " "
    End Sub

    Private Sub BtnSlash_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSlash.Click
        btnResult.Text = btnResult.Text & "/"
    End Sub

    Private Sub btnZap_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnZap.Click
        btnResult.Text = btnResult.Text & ","
    End Sub

    Private Sub btnSk1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSk1.Click
        btnResult.Text = btnResult.Text & "("
    End Sub

    Private Sub BtnSk2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSk2.Click
        btnResult.Text = btnResult.Text & ")"
    End Sub

    Private Sub btnPoint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPoint.Click
        btnResult.Text = btnResult.Text & "."
    End Sub

    Private Sub btnPlus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPlus.Click
        btnResult.Text = btnResult.Text & "+"
    End Sub

    Private Sub btnMinus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMinus.Click
        btnResult.Text = btnResult.Text & "-"
    End Sub

    Private Sub btnDel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If btnResult.Text.Length > 0 Then
            btnResult.Text = btnResult.Text.Substring(0, btnResult.Text.Length - 1)
        End If
    End Sub
End Class