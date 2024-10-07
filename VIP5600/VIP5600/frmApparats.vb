Public Class frmApparats


    Dim rw As clRWini

    Public Sub New(ByVal _ds As GidrogasitelDataSet, ByVal _rw As clRWini)

        ' Этот вызов необходим конструктору форм Windows.
        InitializeComponent()

        ' Добавьте все инициализирующие действия после вызова InitializeComponent().
        rw = _rw
        ds = _ds

        AsBSource.DataSource = ds
        AsBSource.DataMember = "Apparats"

        ApparatTypeBindingSource.DataSource = ds
        ApparatTypeBindingSource.DataMember = "ApparatType"

        Dim pos As Integer

        Dim row As DataRowView = AsBSource.Current

        Dim id As Integer = row.Item("Type")

        pos = ApparatTypeBindingSource.Find("ID", id)
        ApparatTypeBindingSource.Position = pos

    End Sub

    

    

    Private Sub ch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chSpeed1.CheckedChanged, _
                                                                                                        chSpeed2.CheckedChanged, _
                                                                                                        chSpeed3.CheckedChanged, _
                                                                                                        chSpeed4.CheckedChanged, _
                                                                                                        chProkachka.CheckedChanged
        pnlProkachka.Enabled = chProkachka.Checked
        pnlSpeed1.Enabled = chSpeed1.Checked
        pnlSpeed2.Enabled = chSpeed2.Checked
        pnlSpeed3.Enabled = chSpeed3.Checked
        pnlSpeed4.Enabled = chSpeed4.Checked

    End Sub

  
   
    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If ds.Apparats.Count > 1 Then
            AsBSource.RemoveCurrent()
        Else
            MessageBox.Show("Вы не можете удалить последнюю запись!", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

   
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim row As GidrogasitelDataSet.ApparatsRow

        row = ds.Apparats.NewApparatsRow()

        ds.Apparats.AddApparatsRow(row)


        AsBSource.MoveLast()


    End Sub


    Private Function CheckValuesAndCalculateFprivod() As Boolean


        Dim f As Single
        If chSpeed1.Checked = True Then
            f = CalculateFprivod(CInt(rw.N_NOM), CSng(rw.PER_SHTOK), CInt(nudA1.Value), nudS1.Value)

            If f < 3 Then
                MessageBox.Show("Расчетная частота работы двигателя на 1-ой скорости ниже допустимой. Увеличьте скорость или уменьшите амплитуду работы гидрогасителя!", _
                                My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            If f > 65 Then
                MessageBox.Show("Расчетная частота работы двигателя на 1-ой скорости выше допустимой. Уменьшите скорость или увеличьте амплитуду работы гидрогасителя!", _
                                My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            nudF1.Value = f
            nudFmax1.Value = 65
        End If
       
        If chSpeed2.Checked = True Then
            f = CalculateFprivod(CInt(rw.N_NOM), CSng(rw.PER_SHTOK), CInt(nudA2.Value), nudS2.Value)

            If f < 3 Then
                MessageBox.Show("Расчетная частота работы двигателя на 2-ой скорости ниже допустимой. Увеличьте скорость или уменьшите амплитуду работы гидрогасителя!", _
                                My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            If f > 65 Then
                MessageBox.Show("Расчетная частота работы двигателя на 2-ой скорости выше допустимой. Уменьшите скорость или увеличьте амплитуду работы гидрогасителя!", _
                                My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            nudF2.Value = f
            nudFmax2.Value = 65
        End If

        If chSpeed3.Checked = True Then
            f = CalculateFprivod(CInt(rw.N_NOM), CSng(rw.PER_SHTOK), CInt(nudA3.Value), nudS3.Value)

            If f < 3 Then
                MessageBox.Show("Расчетная частота работы двигателя на 3-ой скорости ниже допустимой. Увеличьте скорость или уменьшите амплитуду работы гидрогасителя!", _
                                My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            If f > 65 Then
                MessageBox.Show("Расчетная частота работы двигателя на 3-ой скорости выше допустимой. Уменьшите скорость или увеличьте амплитуду работы гидрогасителя!", _
                                My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            nudF3.Value = f
            nudFmax3.Value = 65
        End If

        If chSpeed4.Checked = True Then
            f = CalculateFprivod(CInt(rw.N_NOM), CSng(rw.PER_SHTOK), CInt(nudA4.Value), nudS4.Value)

            If f < 3 Then
                MessageBox.Show("Расчетная частота работы двигателя на 4-ой скорости ниже допустимой. Увеличьте скорость или уменьшите амплитуду работы гидрогасителя!", _
                                My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            If f > 65 Then
                MessageBox.Show("Расчетная частота работы двигателя на 4-ой скорости выше допустимой. Уменьшите скорость или увеличьте амплитуду работы гидрогасителя!", _
                                My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            nudF4.Value = f
            nudFmax4.Value = 65
        End If

        If chProkachka.Checked = True Then
            f = CalculateFprivod(CInt(rw.N_NOM), CSng(rw.PER_SHTOK), CInt(nudAmplitudeProkachka.Value), nudSpeedProkachka.Value)

            If f < 3 Then
                MessageBox.Show("Расчетная частота работы двигателя в режиме ""Прокачки"" ниже допустимой. Увеличьте скорость или уменьшите амплитуду работы гидрогасителя!", _
                                My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            If f > 65 Then
                MessageBox.Show("Расчетная частота работы двигателя в режиме ""Прокачки"" выше допустимой. Уменьшите скорость или увеличьте амплитуду работы гидрогасителя!", _
                                My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            nudFprivod.Value = f
            nudFmaxProkachka.Value = 65
        End If

        Return True
    End Function

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        Dim bapply As Boolean = True
        If AsBSource IsNot Nothing Then
            If AsBSource.Count > 0 Then
                Dim row As DataRowView = AsBSource.Current
                row.Item("Type") = cmbType.Tag
                row.Item("ProkachkaSpeed") = nudSpeedProkachka.Value
                row.Item("S1_Speed1") = nudS1.Value
                row.Item("S2_Speed2") = nudS2.Value
                row.Item("S3_Speed3") = nudS3.Value
                row.Item("S4_Speed4") = nudS4.Value
                'AsBSource.ResetBindings(False)
                bapply = CheckValuesAndCalculateFprivod()

            End If
        End If
        
        AsBSource.EndEdit()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        btnApply_Click(Nothing, Nothing)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        AsBSource.CancelEdit()
        Me.Close()
    End Sub

    
    Private Sub AsBSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AsBSource.CurrentChanged

        If ApparatTypeBindingSource IsNot Nothing Then
            If ApparatTypeBindingSource.Count > 0 Then
                Dim id As Long
                Dim name As String
                Dim pos As Integer

                Dim row As DataRowView = AsBSource.Current
                If row IsNot Nothing Then
                    id = row.Item("Type")
                    name = row.Item("Name")

                    Debug.Print("Type={0} Name={1}", id, name)

                    pos = ApparatTypeBindingSource.Find("ID", id)
                    ApparatTypeBindingSource.Position = pos
                End If
                
            End If
        End If
        

    End Sub

    Private Sub btnEditNameGasitel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditNameGasitel.Click
        Dim str As String
        Dim row As DataRowView = AsBSource.Current



        str = InputBox("Введите название гидрогасителя:", "Измените название гасителя", row.Item("Name"), , )

        If str.Length > 30 Then
            str = str.Substring(30)
        End If

        row.Item("Name") = str

        AsBSource.ResetBindings(False)


    End Sub

   
    Private Sub nudA2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudA2.ValueChanged

    End Sub

    Private Sub Label54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label54.Click

    End Sub
End Class