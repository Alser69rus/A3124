Public Class aseBD


    Public fDelCount As Integer = 0
    Public bdshow As Boolean = False


    Private Sub aseBD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "GidrogasitelDataSet.ApparatType". При необходимости она может быть перемещена или удалена.
        Me.ApparatTypeTableAdapter.Fill(Me.GidrogasitelDataSet.ApparatType)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "GidrogasitelDataSet.Rezult". При необходимости она может быть перемещена или удалена.
        Me.RezultTableAdapter.Fill(Me.GidrogasitelDataSet.Rezult)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "GidrogasitelDataSet.Appointment". При необходимости она может быть перемещена или удалена.
        Me.AppointmentTableAdapter.Fill(Me.GidrogasitelDataSet.Appointment)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "GidrogasitelDataSet.Remont". При необходимости она может быть перемещена или удалена.
        Me.RemontTableAdapter.Fill(Me.GidrogasitelDataSet.Remont)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "GidrogasitelDataSet.Apparats". При необходимости она может быть перемещена или удалена.
        Me.ApparatsTableAdapter.Fill(Me.GidrogasitelDataSet.Apparats)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "GidrogasitelDataSet.Operators". При необходимости она может быть перемещена или удалена.
        Me.OperatorsTableAdapter.Fill(Me.GidrogasitelDataSet.Operators)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "GidrogasitelDataSet.main". При необходимости она может быть перемещена или удалена.
        Me.MainTableAdapter.Fill(Me.GidrogasitelDataSet.main)




    End Sub

    Private Sub ListBox1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ListBox1.DrawItem
        If Not bdshow Then
            Return
        End If
        Dim Isp As GidrogasitelDataSet.mainRow
        Dim MyBrush As Brush
        Dim Promt As String
        Dim apparats As GidrogasitelDataSet.ApparatsRow

        Const tab As Integer = 245
        Const tab2 As Integer = 445

        Dim loc = e.Bounds.Location


        Isp = ListBox1.Items(e.Index).row
        apparats = GidrogasitelDataSet.Apparats.FindByID(Isp.Type)


        e.DrawBackground()


        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            MyBrush = SystemBrushes.HighlightText
        Else
            MyBrush = Brushes.Black
        End If

        Promt = Isp.ID & ".  " & apparats.Name
        If Promt.Length > 16 Then Promt = Promt.Substring(0, 16)

        e.Graphics.DrawString(Promt, e.Font, MyBrush, loc)


        Promt = "№ "
        If Isp.Num = "" Then
            Promt = Promt & "--                    "
        Else
            Promt = Promt & Isp.Num & "          "
        End If

        If Promt.Length > 12 Then Promt = Promt.Substring(0, 12)

        e.Graphics.DrawString(Promt, e.Font, MyBrush, loc.X + tab, loc.Y)


        Promt = String.Format("{0:dd.MM.yy}", Isp._DateTime)

        e.Graphics.DrawString(Promt, e.Font, MyBrush, loc.X + tab2, loc.Y)

    End Sub



    Private Sub btnPgUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPgUp.Click
        Dim i As Integer = ListBox1.SelectedIndex
        i = i - 10
        If i < 0 Then i = 0
        If ListBox1.Items.Count > 0 Then ListBox1.SelectedIndex = i
    End Sub

    Private Sub btnUp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUp.Click
        Dim i As Integer = ListBox1.SelectedIndex
        i = i - 1
        If i < 0 Then i = 0
        If ListBox1.Items.Count > 0 Then ListBox1.SelectedIndex = i
    End Sub

    Private Sub btnDown_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDown.Click
        Dim i As Integer = ListBox1.SelectedIndex
        i = i + 1
        If i > ListBox1.Items.Count - 1 Then i = ListBox1.Items.Count - 1
        If ListBox1.Items.Count > 0 Then ListBox1.SelectedIndex = i
    End Sub

    Private Sub btnPgDown_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPgDown.Click
        Dim i As Integer = ListBox1.SelectedIndex
        i = i + 10
        If i > ListBox1.Items.Count - 1 Then i = ListBox1.Items.Count - 1
        If ListBox1.Items.Count > 0 Then ListBox1.SelectedIndex = i
    End Sub

    Public Sub RefreshField()
        Dim g As Graphics = Panel1.CreateGraphics
        g.Clear(Color.SkyBlue)

        If ListBox1.Items.Count > 10 Then
            Dim i As Integer = Math.Truncate(350 * ListBox1.SelectedIndex / (ListBox1.Items.Count - 1))

            g.DrawLine(Pens.Black, 20, 5, 20, 355)
            g.FillEllipse(Brushes.Black, 15, i, 10, 10)
            g.FillEllipse(Brushes.SkyBlue, 18, i + 3, 4, 4)

        End If
        g.Dispose()
    End Sub

    Private Sub aseBD_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'ApparatTypeTableAdapter.Update(GidrogasitelDataSet.ApparatType)
        'ApparatsTableAdapter.Update(GidrogasitelDataSet.Apparats)
        'OperatorsTableAdapter.Update(GidrogasitelDataSet.Operators)
        'AppointmentTableAdapter.Update(GidrogasitelDataSet.Appointment)
        'RemontTableAdapter.Update(GidrogasitelDataSet.Remont)
        RezultTableAdapter.Update(GidrogasitelDataSet.Rezult)
        MainTableAdapter.Update(GidrogasitelDataSet.main)

        GidrogasitelDataSet.AcceptChanges()

        'Me.ApparatTypeTableAdapter.Fill(Me.GidrogasitelDataSet.ApparatType)
        Me.RezultTableAdapter.Fill(Me.GidrogasitelDataSet.Rezult)
        'Me.AppointmentTableAdapter.Fill(Me.GidrogasitelDataSet.Appointment)
        'Me.RemontTableAdapter.Fill(Me.GidrogasitelDataSet.Remont)
        'Me.ApparatsTableAdapter.Fill(Me.GidrogasitelDataSet.Apparats)
        'Me.OperatorsTableAdapter.Fill(Me.GidrogasitelDataSet.Operators)
        Me.MainTableAdapter.FillBy1(Me.GidrogasitelDataSet.main)

        bdshow = True

        RefreshField()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        RefreshField()
    End Sub

    Private Sub Panel1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseClick
        If e.X < 41 Then
            Dim i As Integer = e.Y - 5
            i = ListBox1.Items.Count * i / 350
            If i < 0 Then i = 0
            If i > ListBox1.Items.Count - 1 Then i = ListBox1.Items.Count - 1
            If ListBox1.Items.Count > 0 Then ListBox1.SelectedIndex = i
        End If
    End Sub


    Private Sub btnDel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Dim Isp As GidrogasitelDataSet.mainRow = ListBox1.SelectedItem.row
        If Isp IsNot Nothing Then
            bdshow = False
            'Dim rez1 As GidrogasitelDataSet.RezultRow = GidrogasitelDataSet.Rezult.FindByID(Isp.Rezult1)
            'Dim rez2 As GidrogasitelDataSet.RezultRow = GidrogasitelDataSet.Rezult.FindByID(Isp.Rezult2)
            'Dim rez3 As GidrogasitelDataSet.RezultRow = GidrogasitelDataSet.Rezult.FindByID(Isp.Rezult3)
            'Dim rez4 As GidrogasitelDataSet.RezultRow = GidrogasitelDataSet.Rezult.FindByID(Isp.Rezult4)
            'If rez1 IsNot Nothing Then
            'rez1.Delete()
            'RezultTableAdapter.Delete(rez1.ID)
            'End If
            'If rez2 IsNot Nothing Then
            'rez2.Delete()
            'RezultTableAdapter.Delete(rez2.ID)
            'End If
            'If rez3 IsNot Nothing Then
            'rez3.Delete()
            'RezultTableAdapter.Delete(rez3.ID)
            'End If
            'If rez4 IsNot Nothing Then
            'rez4.Delete()
            'RezultTableAdapter.Delete(rez4.ID)
            'End If
            'RezultTableAdapter.Update(GidrogasitelDataSet.Rezult)

            'MainTableAdapter.Delete(Isp.ID)
            Isp.IsDel = True
            MainTableAdapter.Update(GidrogasitelDataSet.main)
            GidrogasitelDataSet.AcceptChanges()

            'Me.RezultTableAdapter.Fill(Me.GidrogasitelDataSet.Rezult)
            Me.MainTableAdapter.FillBy1(Me.GidrogasitelDataSet.main)
            bdshow = True
            'If ListBox1.Items.Count = 1 Then ListBox1.DataSource = Nothing
            'Isp.Delete()

            'fDelCount = fDelCount + 1

        End If
    End Sub

    Private Sub btnShow_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Dim frm As New aseReport

        frm.fIsp = ListBox1.SelectedItem.row
        frm.fGasitel = GidrogasitelDataSet.Apparats.FindByID(frm.fIsp.Type)
        frm.fRemontType = GidrogasitelDataSet.Remont.FindByID(frm.fIsp.Remont)
        frm.fOperator = GidrogasitelDataSet.Operators.FindByID(frm.fIsp._Operator)
        frm.fAppointment = GidrogasitelDataSet.Appointment.FindByID(frm.fOperator.Appointment)
        frm.fRez1 = GidrogasitelDataSet.Rezult.FindByID(frm.fIsp.Rezult1)
        frm.fRez2 = GidrogasitelDataSet.Rezult.FindByID(frm.fIsp.Rezult2)
        frm.fRez3 = GidrogasitelDataSet.Rezult.FindByID(frm.fIsp.Rezult3)
        frm.fRez4 = GidrogasitelDataSet.Rezult.FindByID(frm.fIsp.Rezult4)
        frm.fApparatType = GidrogasitelDataSet.ApparatType.FindByID(frm.fGasitel.Type)
        frm.ShowDialog()
        frm.Dispose()

    End Sub

    Private Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        If fDelCount > 0 Then
            If MsgBox("Действительно удалить протоколы испытаний?", MsgBoxStyle.YesNo, "Подтверждение удаления " & fDelCount & " протоколов") = MsgBoxResult.Yes Then
                'RezultTableAdapter.Update(GidrogasitelDataSet.Rezult.GetChanges())
                MainTableAdapter.Update(GidrogasitelDataSet.main)
                GidrogasitelDataSet.AcceptChanges()
                Me.MainTableAdapter.Fill(Me.GidrogasitelDataSet.main)
            End If
        End If

    End Sub

    Private Sub btnFiltr_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFiltr.Click
        If fDelCount > 0 Then
            If MsgBox("Действительно удалить протоколы испытаний?", MsgBoxStyle.YesNo, "Подтверждение удаления " & fDelCount & " протоколов") = MsgBoxResult.Yes Then
                'RezultTableAdapter.Update(GidrogasitelDataSet.Rezult.GetChanges())
                MainTableAdapter.Update(GidrogasitelDataSet.main)
                GidrogasitelDataSet.AcceptChanges()
                fDelCount = 0
            End If
        End If

        Dim frm As New aseFiltr
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            ListBox1.DataSource = Nothing
            Me.MainTableAdapter.FillBy(Me.GidrogasitelDataSet.main, frm.fGasitel1, frm.fGasitel2, frm.fNum, frm.fDate1, frm.fDate2, frm.fRemont1, frm.fRemont2, frm.fOperator1, frm.fOperator2)
            ListBox1.DataSource = MainBindingSource
            ListBox1.DisplayMember = "ID"
        End If

    End Sub
End Class