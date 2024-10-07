Public Class aseReport

    Public fGasitel As GidrogasitelDataSet.ApparatsRow
    Public fIsp As GidrogasitelDataSet.mainRow
    Public fApparatType As GidrogasitelDataSet.ApparatTypeRow
    Public fRemontType As GidrogasitelDataSet.RemontRow
    Public fRez1 As GidrogasitelDataSet.RezultRow
    Public fRez2 As GidrogasitelDataSet.RezultRow
    Public fRez3 As GidrogasitelDataSet.RezultRow
    Public fRez4 As GidrogasitelDataSet.RezultRow
    Public fOperator As GidrogasitelDataSet.OperatorsRow
    Public fAppointment As GidrogasitelDataSet.AppointmentRow
    Public fRw As clRWini = frmGMain.stend.rw



    Private Sub Doc_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles Doc.PrintPage
        Dim FontTitle As Font = New Font("Segoe UI", 11, FontStyle.Bold)
        Dim FontTitle2 As Font = New Font("Segoe UI", 11, FontStyle.Regular)
        Dim FontText As Font = New Font("Segoe UI", 9, FontStyle.Regular)
        Dim pos As New Point
        Dim df As Single
        Dim de As Single
        Dim ds As Single

        df = CSng(fRw.DOPUSK_F)
        de = CSng(fRw.DOPUSK_E)
        ds = CSng(fRw.DOPUSK_S)

        pos.X = e.MarginBounds.Left
        pos.Y = e.MarginBounds.Top

        Dim g As Graphics = e.Graphics

        If fIsp IsNot Nothing Then
            If fIsp.Num = "" Then
                g.DrawString("Протокол испытания гидрогасителя № -- ", FontTitle, Brushes.Black, pos)
            Else
                g.DrawString("Протокол испытания гидрогасителя № " & fIsp.Num, FontTitle, Brushes.Black, pos)
            End If

            pos.Y = pos.Y + FontTitle.Height + 5
        End If

        If fGasitel IsNot Nothing Then
            g.DrawString("Серия гасителя: " & fGasitel.Name, FontText, Brushes.Black, pos)
        End If

        If fApparatType IsNot Nothing And fRemontType IsNot Nothing Then
            g.DrawString("Тип гасителя: " & fApparatType.Name, FontText, Brushes.Black, pos.X + 400, pos.Y)
            pos.Y = pos.Y + FontText.Height
            g.DrawString("Тип ремонта: " & fRemontType.Remont, FontText, Brushes.Black, pos.X + 400, pos.Y)
        End If

        g.DrawString(fRw.STEND_NUM, FontText, Brushes.Black, pos.X + 400, pos.Y + FontText.Height)

        If fIsp IsNot Nothing Then
            g.DrawString("Дата испытания: " & fIsp._DateTime.ToString("dd.MM.yy HH:mm"), FontText, Brushes.Black, pos)
            pos.Y = pos.Y + FontText.Height
        End If



        'Сетка
        Dim fm As Single = 0
        If fRez1 IsNot Nothing Then

            pos.Y = pos.Y + 40
            For i = -25 To 25 Step 5
                g.DrawLine(Pens.Gray, pos.X + i * 10 + 320, pos.Y, pos.X + i * 10 + 320, pos.Y + 300)
                g.DrawString((i + 0).ToString("f0"), FontText, Brushes.Black, pos.X + i * 10 + 312, pos.Y + 310)
            Next

            If fRez1 IsNot Nothing Then
                fm = Math.Max(fm, fRez1.P_inc)
                fm = Math.Max(fm, fRez1.P_dec)
            End If
            If fRez2 IsNot Nothing Then
                fm = Math.Max(fm, fRez2.P_inc)
                fm = Math.Max(fm, fRez2.P_dec)
            End If
            If fRez3 IsNot Nothing Then
                fm = Math.Max(fm, fRez3.P_inc)
                fm = Math.Max(fm, fRez3.P_dec)
            End If
            If fRez4 IsNot Nothing Then
                fm = Math.Max(fm, fRez4.P_inc)
                fm = Math.Max(fm, fRez4.P_dec)
            End If

            Select Case fm
                Case 0 To 7.5
                    fm = 20

                Case 7, 5 To 10
                    fm = 15
                Case 10 To 12.5
                    fm = 12
                Case 12.5 To 15
                    fm = 10
                Case 15 To 20
                    fm = 7.5
                Case 20 To 25
                    fm = 6
                Case Else

                    fm = 4

            End Select


            For i = 0 To 150 Step 30
                g.DrawLine(Pens.Gray, pos.X + 70, pos.Y - i + 150, pos.X + 570, pos.Y - i + 150)
                g.DrawString(String.Format("{0: #0.0;-#0.0}", (i / fm)), FontText, Brushes.Black, pos.X + 20, pos.Y + 140 - i)
                g.DrawLine(Pens.Gray, pos.X + 70, pos.Y + i + 150, pos.X + 570, pos.Y + i + 150)
                g.DrawString(String.Format("{0: #0.0;-#0.0}", (-i / fm)), FontText, Brushes.Black, pos.X + 20, pos.Y + 140 + i)
            Next

            g.DrawString("F, кН", FontText, Brushes.Black, pos.X + 20, pos.Y - 30)
            g.DrawString("L, мм", FontText, Brushes.Black, pos.X + 580, pos.Y + 290)


            If fRez1 IsNot Nothing Then
                Dim fPoint As PointF() = Unpack(fRez1.Values, fRez1.Values2, pos.X + 320, pos.Y + 150, 12, fm)
                If fPoint IsNot Nothing Then g.DrawClosedCurve(Pens.DarkBlue, fPoint)
            End If
            If fRez2 IsNot Nothing Then
                Dim fPoint As PointF() = Unpack(fRez2.Values, fRez2.Values2, pos.X + 320, pos.Y + 150, 12, fm)
                If fPoint IsNot Nothing Then g.DrawClosedCurve(Pens.DarkRed, fPoint)
            End If
            If fRez3 IsNot Nothing Then
                Dim fPoint As PointF() = Unpack(fRez3.Values, fRez3.Values2, pos.X + 320, pos.Y + 150, 12, fm)
                If fPoint IsNot Nothing Then g.DrawClosedCurve(Pens.DarkSeaGreen, fPoint)
            End If
            If fRez4 IsNot Nothing Then
                Dim fPoint As PointF() = Unpack(fRez4.Values, fRez4.Values2, pos.X + 320, pos.Y + 150, 12, fm)
                If fPoint IsNot Nothing Then g.DrawClosedCurve(Pens.DarkViolet, fPoint)
            End If
            pos.Y = pos.Y + 340
        End If

        Dim Ispraven As Boolean = True
        Dim tab As Single = 250
        Dim tab2 As Single = 75
        Dim tab3 As Single = 75

        If fRez1 IsNot Nothing And fGasitel.Check_s1 <> 0 Then


            g.DrawString("Скорость, м/с", FontText, Brushes.Black, pos.X, pos.Y)
            g.DrawString(String.Format("{0:F3}", fRez1.Speed), FontText, Brushes.Black, pos.X + tab, pos.Y)
            pos.Y = pos.Y + FontText.Height

            Dim Vmin As Single = fGasitel.P_dec_s1 - fGasitel.DP_dec_s1
            Dim Vmax As Single = fGasitel.P_dec_s1 + fGasitel.DP_dec_s1
            Dim value As Single = fRez1.P_dec

            If (Vmin - value) < df And (Vmin - value) > 0 Then value = Vmin
            If (value - Vmax) < df And (value - Vmax) > 0 Then value = Vmax

            g.DrawString("Усилие растяжения, кН", FontText, Brushes.Black, pos.X, pos.Y)
            g.DrawString(String.Format("{0:F1}", value), FontText, Brushes.Black, pos.X + tab, pos.Y)
            g.DrawString(String.Format("({0:F1}-{1:F1})", Vmin, Vmax), FontText, Brushes.Black, pos.X + tab + tab2, pos.Y)
            If value < Vmin Or value > Vmax Then
                Ispraven = False
                g.DrawString("Отклоняется от нормы", FontText, Brushes.Black, pos.X + tab + tab2 + tab3, pos.Y)
            End If
            pos.Y = pos.Y + FontText.Height

            Vmin = fGasitel.P_inc_s1 - fGasitel.DP_inc_s1
            Vmax = fGasitel.P_inc_s1 + fGasitel.DP_inc_s1
            value = fRez1.P_inc

            If (Vmin - value) < df And (Vmin - value) > 0 Then value = Vmin
            If (value - Vmax) < df And (value - Vmax) > 0 Then value = Vmax

            g.DrawString("Усилие сжатия, кН", FontText, Brushes.Black, pos.X, pos.Y)
            g.DrawString(String.Format("{0:F1}", value), FontText, Brushes.Black, pos.X + tab, pos.Y)
            g.DrawString(String.Format("({0:F1}-{1:F1})", Vmin, Vmax), FontText, Brushes.Black, pos.X + tab + tab2, pos.Y)
            If value < Vmin Or value > Vmax Then
                Ispraven = False
                g.DrawString("Отклоняется от нормы", FontText, Brushes.Black, pos.X + tab + tab2 + tab3, pos.Y)
            End If
            pos.Y = pos.Y + FontText.Height

            If fGasitel.Sreg_s1 = 1 Then
                Vmin = 0
                Vmax = fGasitel.Symmetry_s1
                value = fRez1.Symmetry
                If (value / Vmax) > 1.0 And (value / Vmax) < ds Then value = Vmax

                g.DrawString("Асимметричность усилий, %", FontText, Brushes.Black, pos.X, pos.Y)
                g.DrawString(String.Format("{0:F0}", value), FontText, Brushes.Black, pos.X + tab, pos.Y)
                g.DrawString(String.Format("(≤{0:F0})", Vmax), FontText, Brushes.Black, pos.X + tab + tab2, pos.Y)

                If value > Vmax Then
                    Ispraven = False
                    g.DrawString("Отклоняется от нормы", FontText, Brushes.Black, pos.X + tab + tab2 + tab3, pos.Y)
                End If
                pos.Y = pos.Y + FontText.Height
            End If

            If fGasitel.Breg_s1 <> 0 Then
                Vmin = fGasitel.B_dec_s1 * 0.75
                Vmax = fGasitel.B_dec_s1 * 1.25
                value = fRez1.B_dec

                g.DrawString("Сопротивление раст., кН*с/м", FontText, Brushes.Black, pos.X, pos.Y)
                g.DrawString(String.Format("{0:F0}", value), FontText, Brushes.Black, pos.X + tab, pos.Y)

                If fGasitel.Breg_s1 = 2 Then
                    g.DrawString(String.Format("({0:F0}-{1:F0})", Vmin, Vmax), FontText, Brushes.Black, pos.X + tab + tab2, pos.Y)
                    If value < Vmin Or value > Vmax Then
                        Ispraven = False
                        g.DrawString("Отклоняется от нормы", FontText, Brushes.Black, pos.X + tab + tab2 + tab3, pos.Y)
                    End If
                End If

                pos.Y = pos.Y + FontText.Height

                Vmin = fGasitel.B_inc_s1 * 0.75
                Vmax = fGasitel.B_inc_s1 * 1.25
                value = fRez1.B_inc

                g.DrawString("Сопротивление сжат., кН*с/м", FontText, Brushes.Black, pos.X, pos.Y)
                g.DrawString(String.Format("{0:F0}", value), FontText, Brushes.Black, pos.X + tab, pos.Y)

                If fGasitel.Breg_s1 = 2 Then
                    g.DrawString(String.Format("({0:F0}-{1:F0})", Vmin, Vmax), FontText, Brushes.Black, pos.X + tab + tab2, pos.Y)
                    If value < Vmin Or value > Vmax Then
                        Ispraven = False
                        g.DrawString("Отклоняется от нормы", FontText, Brushes.Black, pos.X + tab + tab2 + tab3, pos.Y)
                    End If
                End If

                pos.Y = pos.Y + FontText.Height

            End If

            If fGasitel.Ereg_s1 <> 0 Then
                Vmin = fGasitel.E_s1 - fGasitel.DE_s1
                Vmax = fGasitel.E_s1 + fGasitel.DE_s1
                value = fRez1.E

                If (Vmin - value) < de And (Vmin - value) > 0 Then value = Vmin
                If (value - Vmax) < de And (value - Vmax) > 0 Then value = Vmax

                g.DrawString("Энергоемкость, Дж", FontText, Brushes.Black, pos.X, pos.Y)
                g.DrawString(String.Format("{0:F0}", value), FontText, Brushes.Black, pos.X + tab, pos.Y)

                If fGasitel.Ereg_s1 = 2 Then
                    g.DrawString(String.Format("({0:F0}-{1:F0})", Vmin, Vmax), FontText, Brushes.Black, pos.X + tab + tab2, pos.Y)
                    If value < Vmin Or value > Vmax Then
                        Ispraven = False
                        g.DrawString("Отклоняется от нормы", FontText, Brushes.Black, pos.X + tab + tab2 + tab3, pos.Y)
                    End If
                End If
                pos.Y = pos.Y + FontText.Height
            End If

            g.DrawLine(Pens.Black, pos.X, pos.Y + 5, pos.X + 600, pos.Y + 5)
            pos.Y = pos.Y + FontText.Height

        End If

        If fRez2 IsNot Nothing And fGasitel.Check_s2 <> 0 Then

            g.DrawString("Скорость, м/с", FontText, Brushes.Black, pos.X, pos.Y)
            g.DrawString(String.Format("{0:F3}", fRez2.Speed), FontText, Brushes.Black, pos.X + tab, pos.Y)
            pos.Y = pos.Y + FontText.Height

            Dim Vmin As Single = fGasitel.P_dec_s2 - fGasitel.DP_dec_s2
            Dim Vmax As Single = fGasitel.P_dec_s2 + fGasitel.DP_dec_s2
            Dim value As Single = fRez2.P_dec

            If (Vmin - value) < df And (Vmin - value) > 0 Then value = Vmin
            If (value - Vmax) < df And (value - Vmax) > 0 Then value = Vmax

            g.DrawString("Усилие растяжения, кН", FontText, Brushes.Black, pos.X, pos.Y)
            g.DrawString(String.Format("{0:F1}", value), FontText, Brushes.Black, pos.X + tab, pos.Y)
            g.DrawString(String.Format("({0:F1}-{1:F1})", Vmin, Vmax), FontText, Brushes.Black, pos.X + tab + tab2, pos.Y)
            If value < Vmin Or value > Vmax Then
                Ispraven = False
                g.DrawString("Отклоняется от нормы", FontText, Brushes.Black, pos.X + tab + tab2 + tab3, pos.Y)
            End If
            pos.Y = pos.Y + FontText.Height

            Vmin = fGasitel.P_inc_s2 - fGasitel.DP_inc_s2
            Vmax = fGasitel.P_inc_s2 + fGasitel.DP_inc_s2
            value = fRez2.P_inc

            If (Vmin - value) < df And (Vmin - value) > 0 Then value = Vmin
            If (value - Vmax) < df And (value - Vmax) > 0 Then value = Vmax

            g.DrawString("Усилие сжатия, кН", FontText, Brushes.Black, pos.X, pos.Y)
            g.DrawString(String.Format("{0:F1}", value), FontText, Brushes.Black, pos.X + tab, pos.Y)
            g.DrawString(String.Format("({0:F1}-{1:F1})", Vmin, Vmax), FontText, Brushes.Black, pos.X + tab + tab2, pos.Y)
            If value < Vmin Or value > Vmax Then
                Ispraven = False
                g.DrawString("Отклоняется от нормы", FontText, Brushes.Black, pos.X + tab + tab2 + tab3, pos.Y)
            End If
            pos.Y = pos.Y + FontText.Height

            If fGasitel.Sreg_s2 = 1 Then
                Vmin = 0
                Vmax = fGasitel.Symmetry_s2
                value = fRez2.Symmetry
                If (value / Vmax) > 1.0 And (value / Vmax) < ds Then value = Vmax

                g.DrawString("Асимметричность усилий, %", FontText, Brushes.Black, pos.X, pos.Y)
                g.DrawString(String.Format("{0:F0}", value), FontText, Brushes.Black, pos.X + tab, pos.Y)
                g.DrawString(String.Format("(≤{0:F0})", Vmax), FontText, Brushes.Black, pos.X + tab + tab2, pos.Y)

                If value > Vmax Then
                    Ispraven = False
                    g.DrawString("Отклоняется от нормы", FontText, Brushes.Black, pos.X + tab + tab2 + tab3, pos.Y)
                End If
                pos.Y = pos.Y + FontText.Height
            End If

            If fGasitel.Breg_s2 <> 0 Then
                Vmin = fGasitel.B_dec_s2 * 0.75
                Vmax = fGasitel.B_dec_s2 * 1.25
                value = fRez2.B_dec

                g.DrawString("Сопротивление раст., кН*с/м", FontText, Brushes.Black, pos.X, pos.Y)
                g.DrawString(String.Format("{0:F0}", value), FontText, Brushes.Black, pos.X + tab, pos.Y)

                If fGasitel.Breg_s2 = 2 Then
                    g.DrawString(String.Format("({0:F0}-{1:F0})", Vmin, Vmax), FontText, Brushes.Black, pos.X + tab + tab2, pos.Y)
                    If value < Vmin Or value > Vmax Then
                        Ispraven = False
                        g.DrawString("Отклоняется от нормы", FontText, Brushes.Black, pos.X + tab + tab2 + tab3, pos.Y)
                    End If
                End If

                pos.Y = pos.Y + FontText.Height

                Vmin = fGasitel.B_inc_s2 * 0.75
                Vmax = fGasitel.B_inc_s2 * 1.25
                value = fRez2.B_inc

                g.DrawString("Сопротивление сжат., кН*с/м", FontText, Brushes.Black, pos.X, pos.Y)
                g.DrawString(String.Format("{0:F0}", value), FontText, Brushes.Black, pos.X + tab, pos.Y)

                If fGasitel.Breg_s2 = 2 Then
                    g.DrawString(String.Format("({0:F0}-{1:F0})", Vmin, Vmax), FontText, Brushes.Black, pos.X + tab + tab2, pos.Y)
                    If value < Vmin Or value > Vmax Then
                        Ispraven = False
                        g.DrawString("Отклоняется от нормы", FontText, Brushes.Black, pos.X + tab + tab2 + tab3, pos.Y)
                    End If
                End If

                pos.Y = pos.Y + FontText.Height

            End If

            If fGasitel.Ereg_s2 <> 0 Then
                Vmin = fGasitel.E_s2 - fGasitel.DE_s2
                Vmax = fGasitel.E_s2 + fGasitel.DE_s2
                value = fRez2.E

                If (Vmin - value) < de And (Vmin - value) > 0 Then value = Vmin
                If (value - Vmax) < de And (value - Vmax) > 0 Then value = Vmax

                g.DrawString("Энергоемкость, Дж", FontText, Brushes.Black, pos.X, pos.Y)
                g.DrawString(String.Format("{0:F0}", value), FontText, Brushes.Black, pos.X + tab, pos.Y)

                If fGasitel.Ereg_s2 = 2 Then
                    g.DrawString(String.Format("({0:F0}-{1:F0})", Vmin, Vmax), FontText, Brushes.Black, pos.X + tab + tab2, pos.Y)
                    If value < Vmin Or value > Vmax Then
                        Ispraven = False
                        g.DrawString("Отклоняется от нормы", FontText, Brushes.Black, pos.X + tab + tab2 + tab3, pos.Y)
                    End If
                End If
                pos.Y = pos.Y + FontText.Height
            End If

            g.DrawLine(Pens.Black, pos.X, pos.Y + 5, pos.X + 600, pos.Y + 5)
            pos.Y = pos.Y + FontText.Height

        End If

        If fRez3 IsNot Nothing And fGasitel.Check_s3 <> 0 Then

            g.DrawString("Скорость, м/с", FontText, Brushes.Black, pos.X, pos.Y)
            g.DrawString(String.Format("{0:F3}", fRez3.Speed), FontText, Brushes.Black, pos.X + tab, pos.Y)
            pos.Y = pos.Y + FontText.Height

            Dim Vmin As Single = fGasitel.P_dec_s3 - fGasitel.DP_dec_s3
            Dim Vmax As Single = fGasitel.P_dec_s3 + fGasitel.DP_dec_s3
            Dim value As Single = fRez3.P_dec

            If (Vmin - value) < df And (Vmin - value) > 0 Then value = Vmin
            If (value - Vmax) < df And (value - Vmax) > 0 Then value = Vmax

            g.DrawString("Усилие растяжения, кН", FontText, Brushes.Black, pos.X, pos.Y)
            g.DrawString(String.Format("{0:F1}", value), FontText, Brushes.Black, pos.X + tab, pos.Y)
            g.DrawString(String.Format("({0:F1}-{1:F1})", Vmin, Vmax), FontText, Brushes.Black, pos.X + tab + tab2, pos.Y)
            If value < Vmin Or value > Vmax Then
                Ispraven = False
                g.DrawString("Отклоняется от нормы", FontText, Brushes.Black, pos.X + tab + tab2 + tab3, pos.Y)
            End If
            pos.Y = pos.Y + FontText.Height

            Vmin = fGasitel.P_inc_s3 - fGasitel.DP_inc_s3
            Vmax = fGasitel.P_inc_s3 + fGasitel.DP_inc_s3
            value = fRez3.P_inc

            If (Vmin - value) < df And (Vmin - value) > 0 Then value = Vmin
            If (value - Vmax) < df And (value - Vmax) > 0 Then value = Vmax

            g.DrawString("Усилие сжатия, кН", FontText, Brushes.Black, pos.X, pos.Y)
            g.DrawString(String.Format("{0:F1}", value), FontText, Brushes.Black, pos.X + tab, pos.Y)
            g.DrawString(String.Format("({0:F1}-{1:F1})", Vmin, Vmax), FontText, Brushes.Black, pos.X + tab + tab2, pos.Y)
            If value < Vmin Or value > Vmax Then
                Ispraven = False
                g.DrawString("Отклоняется от нормы", FontText, Brushes.Black, pos.X + tab + tab2 + tab3, pos.Y)
            End If
            pos.Y = pos.Y + FontText.Height

            If fGasitel.Sreg_s3 = 1 Then
                Vmin = 0
                Vmax = fGasitel.Symmetry_s3
                value = fRez3.Symmetry
                If (value / Vmax) > 1.0 And (value / Vmax) < ds Then value = Vmax

                g.DrawString("Асимметичность усилий, %", FontText, Brushes.Black, pos.X, pos.Y)
                g.DrawString(String.Format("{0:F0}", value), FontText, Brushes.Black, pos.X + tab, pos.Y)
                g.DrawString(String.Format("(≤{0:F0})", Vmax), FontText, Brushes.Black, pos.X + tab + tab2, pos.Y)

                If value > Vmax Then
                    Ispraven = False
                    g.DrawString("Отклоняется от нормы", FontText, Brushes.Black, pos.X + tab + tab2 + tab3, pos.Y)
                End If
                pos.Y = pos.Y + FontText.Height
            End If

            If fGasitel.Breg_s3 <> 0 Then
                Vmin = fGasitel.B_dec_s3 * 0.75
                Vmax = fGasitel.B_dec_s3 * 1.25
                value = fRez3.B_dec

                g.DrawString("Сопротивление раст., кН*с/м", FontText, Brushes.Black, pos.X, pos.Y)
                g.DrawString(String.Format("{0:F0}", value), FontText, Brushes.Black, pos.X + tab, pos.Y)

                If fGasitel.Breg_s3 = 2 Then
                    g.DrawString(String.Format("({0:F0}-{1:F0})", Vmin, Vmax), FontText, Brushes.Black, pos.X + tab + tab2, pos.Y)
                    If value < Vmin Or value > Vmax Then
                        Ispraven = False
                        g.DrawString("Отклоняется от нормы", FontText, Brushes.Black, pos.X + tab + tab2 + tab3, pos.Y)
                    End If
                End If

                pos.Y = pos.Y + FontText.Height

                Vmin = fGasitel.B_inc_s3 * 0.75
                Vmax = fGasitel.B_inc_s3 * 1.25
                value = fRez3.B_inc

                g.DrawString("Сопротивление сжат., кН*с/м", FontText, Brushes.Black, pos.X, pos.Y)
                g.DrawString(String.Format("{0:F0}", value), FontText, Brushes.Black, pos.X + tab, pos.Y)

                If fGasitel.Breg_s3 = 2 Then
                    g.DrawString(String.Format("({0:F0}-{1:F0})", Vmin, Vmax), FontText, Brushes.Black, pos.X + tab + tab2, pos.Y)
                    If value < Vmin Or value > Vmax Then
                        Ispraven = False
                        g.DrawString("Отклоняется от нормы", FontText, Brushes.Black, pos.X + tab + tab2 + tab3, pos.Y)
                    End If
                End If

                pos.Y = pos.Y + FontText.Height

            End If

            If fGasitel.Ereg_s3 <> 0 Then
                Vmin = fGasitel.E_s3 - fGasitel.DE_s3
                Vmax = fGasitel.E_s3 + fGasitel.DE_s3
                value = fRez3.E

                If (Vmin - value) < de And (Vmin - value) > 0 Then value = Vmin
                If (value - Vmax) < de And (value - Vmax) > 0 Then value = Vmax

                g.DrawString("Энергоемкость, Дж", FontText, Brushes.Black, pos.X, pos.Y)
                g.DrawString(String.Format("{0:F0}", value), FontText, Brushes.Black, pos.X + tab, pos.Y)

                If fGasitel.Ereg_s3 = 2 Then
                    g.DrawString(String.Format("({0:F0}-{1:F0})", Vmin, Vmax), FontText, Brushes.Black, pos.X + tab + tab2, pos.Y)
                    If value < Vmin Or value > Vmax Then
                        Ispraven = False
                        g.DrawString("Отклоняется от нормы", FontText, Brushes.Black, pos.X + tab + tab2 + tab3, pos.Y)
                    End If
                End If
                pos.Y = pos.Y + FontText.Height
            End If

            g.DrawLine(Pens.Black, pos.X, pos.Y + 5, pos.X + 600, pos.Y + 5)
            pos.Y = pos.Y + FontText.Height

        End If

        If fRez4 IsNot Nothing And fGasitel.Check_s4 <> 0 Then

            g.DrawString("Скорость, м/с", FontText, Brushes.Black, pos.X, pos.Y)
            g.DrawString(String.Format("{0:F3}", fRez3.Speed), FontText, Brushes.Black, pos.X + tab, pos.Y)
            pos.Y = pos.Y + FontText.Height

            Dim Vmin As Single = fGasitel.P_dec_s4 - fGasitel.DP_dec_s4
            Dim Vmax As Single = fGasitel.P_dec_s4 + fGasitel.DP_dec_s4
            Dim value As Single = fRez4.P_dec

            If (Vmin - value) < df And (Vmin - value) > 0 Then value = Vmin
            If (value - Vmax) < df And (value - Vmax) > 0 Then value = Vmax

            g.DrawString("Усилие растяжения, кН", FontText, Brushes.Black, pos.X, pos.Y)
            g.DrawString(String.Format("{0:F1}", value), FontText, Brushes.Black, pos.X + tab, pos.Y)
            g.DrawString(String.Format("({0:F1}-{1:F1})", Vmin, Vmax), FontText, Brushes.Black, pos.X + tab + tab2, pos.Y)
            If value < Vmin Or value > Vmax Then
                Ispraven = False
                g.DrawString("Отклоняется от нормы", FontText, Brushes.Black, pos.X + tab + tab2 + tab3, pos.Y)
            End If
            pos.Y = pos.Y + FontText.Height

            Vmin = fGasitel.P_inc_s4 - fGasitel.DP_inc_s4
            Vmax = fGasitel.P_inc_s4 + fGasitel.DP_inc_s4
            value = fRez4.P_inc

            If (Vmin - value) < df And (Vmin - value) > 0 Then value = Vmin
            If (value - Vmax) < df And (value - Vmax) > 0 Then value = Vmax

            g.DrawString("Усилие сжатия, кН", FontText, Brushes.Black, pos.X, pos.Y)
            g.DrawString(String.Format("{0:F1}", value), FontText, Brushes.Black, pos.X + tab, pos.Y)
            g.DrawString(String.Format("({0:F1}-{1:F1})", Vmin, Vmax), FontText, Brushes.Black, pos.X + tab + tab2, pos.Y)
            If value < Vmin Or value > Vmax Then
                Ispraven = False
                g.DrawString("Отклоняется от нормы", FontText, Brushes.Black, pos.X + tab + tab2 + tab3, pos.Y)
            End If
            pos.Y = pos.Y + FontText.Height

            If fGasitel.Sreg_s4 = 1 Then
                Vmin = 0
                Vmax = fGasitel.Symmetry_s4
                value = fRez4.Symmetry
                If (value / Vmax) > 1.0 And (value / Vmax) < ds Then value = Vmax

                g.DrawString("Асимметричность усилий, %", FontText, Brushes.Black, pos.X, pos.Y)
                g.DrawString(String.Format("{0:F0}", value), FontText, Brushes.Black, pos.X + tab, pos.Y)
                g.DrawString(String.Format("(≤{0:F0})", Vmax), FontText, Brushes.Black, pos.X + tab + tab2, pos.Y)

                If value > Vmax Then
                    Ispraven = False
                    g.DrawString("Отклоняется от нормы", FontText, Brushes.Black, pos.X + tab + tab2 + tab3, pos.Y)
                End If
                pos.Y = pos.Y + FontText.Height
            End If

            If fGasitel.Breg_s4 <> 0 Then
                Vmin = fGasitel.B_dec_s4 * 0.75
                Vmax = fGasitel.B_dec_s4 * 1.25
                value = fRez4.B_dec

                g.DrawString("Сопротивление раст., кН*с/м", FontText, Brushes.Black, pos.X, pos.Y)
                g.DrawString(String.Format("{0:F0}", value), FontText, Brushes.Black, pos.X + tab, pos.Y)

                If fGasitel.Breg_s4 = 2 Then
                    g.DrawString(String.Format("({0:F0}-{1:F0})", Vmin, Vmax), FontText, Brushes.Black, pos.X + tab + tab2, pos.Y)
                    If value < Vmin Or value > Vmax Then
                        Ispraven = False
                        g.DrawString("Отклоняется от нормы", FontText, Brushes.Black, pos.X + tab + tab2 + tab3, pos.Y)
                    End If
                End If

                pos.Y = pos.Y + FontText.Height

                Vmin = fGasitel.B_inc_s4 * 0.75
                Vmax = fGasitel.B_inc_s4 * 1.25
                value = fRez4.B_inc

                If (Vmin - value) < de And (Vmin - value) > 0 Then value = Vmin
                If (value - Vmax) < de And (value - Vmax) > 0 Then value = Vmax

                g.DrawString("Сопротивление сжат., кН*с/м", FontText, Brushes.Black, pos.X, pos.Y)
                g.DrawString(String.Format("{0:F0}", value), FontText, Brushes.Black, pos.X + tab, pos.Y)

                If fGasitel.Breg_s4 = 2 Then
                    g.DrawString(String.Format("({0:F0}-{1:F0})", Vmin, Vmax), FontText, Brushes.Black, pos.X + tab + tab2, pos.Y)
                    If value < Vmin Or value > Vmax Then
                        Ispraven = False
                        g.DrawString("Отклоняется от нормы", FontText, Brushes.Black, pos.X + tab + tab2 + tab3, pos.Y)
                    End If
                End If

                pos.Y = pos.Y + FontText.Height

            End If

            If fGasitel.Ereg_s4 <> 0 Then
                Vmin = fGasitel.E_s4 - fGasitel.DE_s4
                Vmax = fGasitel.E_s4 + fGasitel.DE_s4
                value = fRez4.E

                g.DrawString("Энергоемкость, Дж", FontText, Brushes.Black, pos.X, pos.Y)
                g.DrawString(String.Format("{0:F0}", value), FontText, Brushes.Black, pos.X + tab, pos.Y)

                If fGasitel.Ereg_s4 = 2 Then
                    g.DrawString(String.Format("({0:F0}-{1:F0})", Vmin, Vmax), FontText, Brushes.Black, pos.X + tab + tab2, pos.Y)
                    If value < Vmin Or value > Vmax Then
                        Ispraven = False
                        g.DrawString("Отклоняется от нормы", FontText, Brushes.Black, pos.X + tab + tab2 + tab3, pos.Y)
                    End If
                End If
                pos.Y = pos.Y + FontText.Height
            End If

            g.DrawLine(Pens.Black, pos.X, pos.Y + 5, pos.X + 600, pos.Y + 5)
            pos.Y = pos.Y + FontText.Height

        End If

        If fRez1 IsNot Nothing Then
            If Ispraven Then
                g.DrawString("Результат испытания: Характеристики гасителя соответствуют ТУ", FontTitle, Brushes.Black, pos)
            Else
                g.DrawString("Результат испытания: Характеристики гасителя отклоняются от нормы", FontTitle, Brushes.Black, pos)
            End If

            pos.Y = pos.Y + FontTitle.Height

            Dim AllDone As Boolean = True
            If fGasitel.Check_s1 <> 0 And fRez1 Is Nothing Then
                AllDone = False
            End If
            If fGasitel.Check_s2 <> 0 And fRez2 Is Nothing Then
                AllDone = False
            End If
            If fGasitel.Check_s3 <> 0 And fRez3 Is Nothing Then
                AllDone = False
            End If
            If fGasitel.Check_s4 <> 0 And fRez4 Is Nothing Then
                AllDone = False
            End If

            If Not AllDone Then
                g.DrawString("Испытания проведены не в полном объеме", FontText, Brushes.Black, pos)
                pos.Y = pos.Y + FontText.Height
            End If


            Dim PdecSmall = False
            Dim PdecBig = False
            Dim PIncSmall = False
            Dim PincBig = False
            Dim PNone = False
            Dim PClin = False
            Dim Sdif = False
            Dim Edif = False

            If fRez1 IsNot Nothing And fGasitel.Check_s1 Then

                If fRez1.P_dec < fGasitel.P_dec_s1 - fGasitel.DP_dec_s1 Then
                    PdecSmall = True
                End If
                If fRez1.P_dec > fGasitel.P_dec_s1 + fGasitel.DP_dec_s1 Then
                    PdecBig = True
                End If
                If fRez1.P_inc < fGasitel.P_inc_s1 - fGasitel.DP_inc_s1 Then
                    PIncSmall = True
                End If
                If fRez1.P_inc > fGasitel.P_inc_s1 + fGasitel.DP_inc_s1 Then
                    PincBig = True
                End If
                If fRez1.Symmetry > fGasitel.Symmetry_s1 And fGasitel.Sreg_s1 <> 0 Then
                    Sdif = True
                End If
                If fRez1.E < fGasitel.E_s1 - fGasitel.DE_s1 Or fRez1.E > fGasitel.E_s1 + fGasitel.DE_s1 Then
                    If fGasitel.Ereg_s1 = 2 Then Edif = True
                End If
                If fRez1.P_dec < 1 And fRez1.P_inc < 1 Then PNone = True
                If fRez1.P_dec > 35 Or fRez1.P_inc > 35 Then PClin = True

            End If


            If fRez2 IsNot Nothing And fGasitel.Check_s2 Then

                If fRez2.P_dec < fGasitel.P_dec_s2 - fGasitel.DP_dec_s2 Then
                    PdecSmall = True
                End If
                If fRez2.P_dec > fGasitel.P_dec_s2 + fGasitel.DP_dec_s2 Then
                    PdecBig = True
                End If
                If fRez2.P_inc < fGasitel.P_inc_s2 - fGasitel.DP_inc_s2 Then
                    PIncSmall = True
                End If
                If fRez2.P_inc > fGasitel.P_inc_s2 + fGasitel.DP_inc_s2 Then
                    PincBig = True
                End If
                If fRez2.Symmetry > fGasitel.Symmetry_s2 And fGasitel.Sreg_s2 <> 0 Then
                    Sdif = True
                End If
                If fRez2.E < fGasitel.E_s2 - fGasitel.DE_s2 Or fRez2.E > fGasitel.E_s2 + fGasitel.DE_s2 Then
                    If fGasitel.Ereg_s2 = 2 Then Edif = True
                End If
                If fRez2.P_dec < 1 And fRez2.P_inc < 1 Then PNone = True
                If fRez2.P_dec > 35 Or fRez2.P_inc > 35 Then PClin = True

            End If


            If fRez3 IsNot Nothing And fGasitel.Check_s3 Then

                If fRez3.P_dec < fGasitel.P_dec_s3 - fGasitel.DP_dec_s3 Then
                    PdecSmall = True
                End If
                If fRez3.P_dec > fGasitel.P_dec_s3 + fGasitel.DP_dec_s3 Then
                    PdecBig = True
                End If
                If fRez3.P_inc < fGasitel.P_inc_s3 - fGasitel.DP_inc_s3 Then
                    PIncSmall = True
                End If
                If fRez3.P_inc > fGasitel.P_inc_s3 + fGasitel.DP_inc_s3 Then
                    PincBig = True
                End If
                If fRez3.Symmetry > fGasitel.Symmetry_s3 And fGasitel.Sreg_s3 <> 0 Then
                    Sdif = True
                End If
                If fRez3.E < fGasitel.E_s3 - fGasitel.DE_s3 Or fRez3.E > fGasitel.E_s3 + fGasitel.DE_s3 Then
                    If fGasitel.Ereg_s3 = 2 Then Edif = True
                End If
                If fRez3.P_dec < 1 And fRez3.P_inc < 1 Then PNone = True
                If fRez3.P_dec > 35 Or fRez3.P_inc > 35 Then PClin = True

            End If


            If fRez4 IsNot Nothing And fGasitel.Check_s4 Then

                If fRez4.P_dec < fGasitel.P_dec_s4 - fGasitel.DP_dec_s4 Then
                    PdecSmall = True
                End If
                If fRez4.P_dec > fGasitel.P_dec_s4 + fGasitel.DP_dec_s4 Then
                    PdecBig = True
                End If
                If fRez4.P_inc < fGasitel.P_inc_s4 - fGasitel.DP_inc_s4 Then
                    PIncSmall = True
                End If
                If fRez4.P_inc > fGasitel.P_inc_s4 + fGasitel.DP_inc_s4 Then
                    PincBig = True
                End If
                If fRez4.Symmetry > fGasitel.Symmetry_s4 And fGasitel.Sreg_s4 <> 0 Then
                    Sdif = True
                End If
                If fRez4.E < fGasitel.E_s4 - fGasitel.DE_s4 Or fRez4.E > fGasitel.E_s4 + fGasitel.DE_s4 Then
                    If fGasitel.Ereg_s4 = 2 Then Edif = True
                End If
                If fRez4.P_dec < 1 And fRez4.P_inc < 1 Then PNone = True
                If fRez4.P_dec > 35 Or fRez4.P_inc > 35 Then PClin = True

            End If

            If Ispraven Then
                PdecSmall = False
                PdecBig = False
                PIncSmall = False
                PincBig = False
                PNone = False
                PClin = False
                Sdif = False
                Edif = False
            End If

            If PClin Then
                g.DrawString("Усилия сжатия или растяжения слишком велики. Вероятно заклинивание гасителя", FontText, Brushes.Black, pos)
                pos.Y = pos.Y + FontText.Height
            ElseIf PNone Then
                g.DrawString("Нет сопротивления сжатию и растяжению. Вероятно отсутствие рабочей жидкости, самоотвинчивание", FontText, Brushes.Black, pos)
                pos.Y = pos.Y + FontText.Height
                g.DrawString("поршня, засорение клапана в днище или неплотности переливных трубок", FontText, Brushes.Black, pos)
                pos.Y = pos.Y + FontText.Height
            ElseIf PdecSmall And PIncSmall Then
                g.DrawString("Малы усилия на ходах сжатия и растяжения. Вероятно самоотвинчивание дроссельной иглы или", FontText, Brushes.Black, pos)
                pos.Y = pos.Y + FontText.Height
                g.DrawString("шарикового клапана, износ поршневых колец, цилиндра, штока или уплотнительных колец поршня.", FontText, Brushes.Black, pos)
                pos.Y = pos.Y + FontText.Height
            ElseIf PdecBig And PincBig Then
                g.DrawString("Повышенное сопротивление при сжатии и растяжени. Вероятна повышенная вязкость рабочей ", FontText, Brushes.Black, pos)
                pos.Y = pos.Y + FontText.Height
                g.DrawString("жидкости или неисправности клапанов, а также перекос штока.", FontText, Brushes.Black, pos)
                pos.Y = pos.Y + FontText.Height
            ElseIf PdecSmall Then
                g.DrawString("Мало сопротивление при растяжении . Вероятно засорение или неисправность клапанов в поршне.", FontText, Brushes.Black, pos)
                pos.Y = pos.Y + FontText.Height
            ElseIf PIncSmall Then
                g.DrawString("Мало сопротивление при сжатии . Вероятно засорение или неисправность клапанов в днище или", FontText, Brushes.Black, pos)
                pos.Y = pos.Y + FontText.Height
                g.DrawString("недостаток рабочей жидкости.", FontText, Brushes.Black, pos)
                pos.Y = pos.Y + FontText.Height
            ElseIf PdecBig Then
                g.DrawString("Велико сопротивление при растяжении . Вероятно засорение или неисправность клапанов.", FontText, Brushes.Black, pos)
                pos.Y = pos.Y + FontText.Height
            ElseIf PincBig Then
                g.DrawString("Велико сопротивление при сжатии . Вероятно засорение или неисправность клапанов.", FontText, Brushes.Black, pos)
                pos.Y = pos.Y + FontText.Height
            End If

            If Sdif Then
                g.DrawString("Нарушена симметричность усилий на ходах сжатия и растяжения. Требуется регулировка клапанов", FontText, Brushes.Black, pos)
                pos.Y = pos.Y + FontText.Height
            End If

            If Edif Then
                g.DrawString("Энергоемкость гидрогасителя не соответствует ТУ. Вероятно требуется регулировка клапанов и дросселей,", FontText, Brushes.Black, pos)
                pos.Y = pos.Y + FontText.Height
                g.DrawString("замена рабочей жидкости, проверка амортизирующих втулок и подшипников, проверка крепления элементов.", FontText, Brushes.Black, pos)
                pos.Y = pos.Y + FontText.Height
            End If

            pos.Y = pos.Y + 10
            g.DrawString("Заключение______________________________________________________________________________", FontTitle2, Brushes.Black, pos)
            pos.Y = pos.Y + FontTitle2.Height + 10

            If fIsp._Operator > 0 Then
                g.DrawString("Испытание проводил " & fOperator.Last & " " & fOperator.First & " " & fOperator.Second & "__________________________________", FontTitle2, Brushes.Black, pos)
            End If


        Else
            pos.Y = pos.Y + FontText.Height
            g.DrawString("Испытание гасителя не проводилось или оно было завершено некорректно", FontTitle, Brushes.Black, pos)
        End If




    End Sub

    Private Sub aseReport_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Doc.DefaultPageSettings.Margins.Top = 50
        btnM.SelectedIndex = 2
        Doc.DocumentName = String.Format("{0:D} {1} {2:yyyy-MM-dd}", fIsp.Num, fGasitel.Name, fIsp._DateTime)
        PrintPreviewControl1.InvalidatePreview()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Doc.Print()
    End Sub

    Public Function Unpack(ByVal strL As String, ByVal strF As String, Optional ByVal OffsetX As Single = 0, Optional ByVal OffsetY As Single = 0, Optional ByVal MX As Single = 1, Optional ByVal MY As Single = 1) As PointF()
        Dim L As String() = strL.Split(",")
        Dim F As String() = strF.Split(",")
        Dim Res(L.GetUpperBound(0)) As PointF
        Dim KL As Single = (10 / 12) * 5 * fRw.LEN_DATCHIK_DISTANCE / (CSng(fRw.R_DATCHIK_DISTANCE) * 0.016 * lHALF_DISCRETS)
        Dim KF As Single = 5 * CSng(fRw.LIM_POWER) * CSng(fRw.U_IN_POWER) / (1000 * CSng(fRw.U_OUT_TENZO) * CSng(fRw.U_POWER) * lHALF_DISCRETS)

        If strL = "" Or strF = "" Then
            Return Nothing
        End If

        Dim Lmin As Single = 1000
        Dim Lmax As Single = -1000

        For i = 0 To L.GetUpperBound(0)
            Res(i).X = Convert.ToInt16(L(i), 16) * KL
            Res(i).Y = Convert.ToInt16(F(i), 16) * KF
            Lmin = Math.Min(Lmin, Res(i).X)
            Lmax = Math.Max(Lmax, Res(i).X)
        Next

        Dim Avrg As Single = (Lmin + Lmax) / 2
        For i = 0 To L.GetUpperBound(0)
            Res(i).X = Res(i).X - Avrg
            Res(i).X = Res(i).X * MX + OffsetX
            Res(i).Y = Res(i).Y * MY + OffsetY
        Next

        Return Res
    End Function

    Private Sub btnM_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnM.SelectedIndexChanged
        PrintPreviewControl1.Zoom = btnM.SelectedItem.ToString / 100
    End Sub

    Private Sub btnSelectPrinter_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSelectPrinter.Click
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Doc.PrinterSettings = PrintDialog1.PrinterSettings
            Doc.Print()
        End If
    End Sub
End Class