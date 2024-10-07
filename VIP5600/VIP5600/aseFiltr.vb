Public Class aseFiltr
    Const Int64Maximum = 9223372036854775807


    Public fGasitel1 As Long = 0
    Public fGasitel2 As Long = Int64Maximum
    Public fNum As String = "%"
    Public fDate1 As Date = New System.DateTime(1900, 1, 1, 0, 0, 0)
    Public fDate2 As Date = New System.DateTime(2900, 1, 1, 0, 0, 0)
    Public fOperator1 As Long = 0
    Public fOperator2 As Long = Int64Maximum
    Public fRemont1 As Long = 0
    Public fRemont2 As Long = Int64Maximum


    Private Sub btnType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnType.Click
        Dim frm As New aseGasitelSelect
        frm.btnBack.Text = "Тип гидрогасителя"
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim row As GidrogasitelDataSet.ApparatsRow
            row = frm.ListBox1.SelectedItem.row
            fGasitel1 = row.ID
            fGasitel2 = row.ID
            btnType.Text = "Тип гидрогасителя " & row.Name
        Else
            fGasitel1 = 0
            fGasitel2 = Int64Maximum
            btnType.Text = "Тип гидрогасителя "
        End If
        frm.Dispose()

    End Sub

    Private Sub btnNum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNum.Click
        Dim frm As New frmKeypad
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            fNum = frm.btnResult.Text
            btnNum.Text = "Номер " & fNum
        Else
            fNum = "%"
            btnNum.Text = "Номер "
        End If

        frm.Dispose()

    End Sub

    Private Sub btnDate1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDate1.Click
        Dim frm As New aseCalendar
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            fDate1 = New System.DateTime(frm.dtp1.Value.Year, frm.dtp1.Value.Month, frm.dtp1.Value.Day, 0, 0, 0)
            btnDate1.Text = "Не раньше " & fDate1
        Else
            fDate1 = New System.DateTime(1900, 1, 1, 0, 0, 0)
            btnDate1.Text = "Не раньше "
        End If

        frm.Dispose()

    End Sub

    Private Sub btnDate2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDate2.Click
        Dim frm As New aseCalendar
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            fDate2 = New System.DateTime(frm.dtp1.Value.Year, frm.dtp1.Value.Month, frm.dtp1.Value.Day, 23, 59, 59)
            btnDate2.Text = "Не позднее " & String.Format("{0:dd.MM.yyyy}", fDate2)
        Else
            fDate1 = New System.DateTime(2900, 1, 1, 0, 0, 0)
            btnDate2.Text = "Не позднее "
        End If

        frm.Dispose()
    End Sub

    Private Sub btnOperator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOperator.Click
        Dim frm As New aseOperatorSelect
        frm.btnBack.Text = "Выбор оператора"
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim row As GidrogasitelDataSet.OperatorsRow
            row = frm.ListBox1.SelectedItem.row
            fOperator1 = row.ID
            fOperator2 = row.ID
            btnOperator.Text = "Оператор " & row.Last & " " & row.First & " " & row.Second
        Else
            fOperator1 = 0
            fOperator2 = Int64Maximum
            btnOperator.Text = "Оператор "
        End If
        frm.Dispose()
    End Sub

    Private Sub btnRemont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemont.Click
        Dim frm As New aseRemontSelect
        frm.btnBack.Text = "Выбор вида ремонта"
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim row As GidrogasitelDataSet.RemontRow
            row = frm.ListBox1.SelectedItem.row
            fRemont1 = row.ID
            fRemont2 = row.ID
            btnRemont.Text = "Вид ремонта " & row.Remont
        Else
            fRemont1 = 0
            fRemont2 = Int64Maximum
            btnRemont.Text = "Вид ремонта "
        End If
        frm.Dispose()

    End Sub
End Class