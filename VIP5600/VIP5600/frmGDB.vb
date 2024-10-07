Public Class frmGDB

    Dim Protokol As clDrawingProtokol
    Dim WithEvents PrintDocument As New MyPrintDocument
    Dim rw As New clRWini
    Dim idx As Integer
    Public Sub New(ByVal dataset As GidrogasitelDataSet, ByVal _idx As Integer)


        ' Этот вызов необходим конструктору форм Windows.
        InitializeComponent()

        ' Добавьте все инициализирующие действия после вызова InitializeComponent().
        ds = dataset
        idx = _idx

    End Sub


    Private Sub frmGDB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        

      

        tbtnZoom.SelectedIndex = 2
        PrintDocument.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(100, 50, 50, 50)
        PrintView.Show()

        Protokol = New clDrawingProtokol(PrintDocument, ds, rw)

        RefreshProtokol(idx)
    End Sub


    Private Sub sbtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbtnPrint.Click
        PrintDocument.Print()
    End Sub

    Private Sub sbtnSelPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbtnSelPrint.Click
        PrintDialog.PrinterSettings = New System.Drawing.Printing.PrinterSettings()

        If PrintDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PrintDocument.PrinterSettings = PrintDialog.PrinterSettings
            PrintDocument.Print()
        End If
    End Sub

    Private Sub sbtnSelPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbtnSelPage.Click
        With PageSetupDialog
            .EnableMetric = True
            .PageSettings = PrintDocument.DefaultPageSettings
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                PrintDocument.DefaultPageSettings = .PageSettings
                PrintView.InvalidatePreview()
            End If
        End With
    End Sub

    Private Sub RefreshProtokol(ByVal _idx As Integer)
        Protokol.SetIndexDataSet(_idx)
        PrintView.Document = PrintDocument()
        PrintView.InvalidatePreview()
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        'Static oldind As Integer

        'Dim ind As Integer = DataGridView1.CurrentRow.Cells.Item(0).Value
        'If ind <> oldind Then
        '    'обновление протокола доделать
        '    RefreshProtokol(ind)
        'End If
    End Sub


    Private Sub tbtnZoom_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbtnZoom.SelectedIndexChanged
        Select Case tbtnZoom.SelectedIndex
            Case 0
                PrintView.AutoZoom = True
            Case 1
                PrintView.AutoZoom = False
                PrintView.Zoom = 1
            Case 2
                PrintView.AutoZoom = False
                PrintView.Zoom = 0.75
            Case 3
                PrintView.AutoZoom = False
                PrintView.Zoom = 0.5
            Case 4
                PrintView.AutoZoom = False
                PrintView.Zoom = 0.25
        End Select
    End Sub


End Class



Public Class MyPrintDocument
    Inherits Printing.PrintDocument

    Private _PageNumber As Integer = 0
    Public Property PageNumber() As Integer
        Get
            Return _PageNumber
        End Get
        Set(ByVal value As Integer)
            _PageNumber = value
        End Set
    End Property

End Class

Public Class clDrawingProtokol

    Private WithEvents mPDoc As MyPrintDocument
    Private ds As GidrogasitelDataSet
    Private main_row As GidrogasitelDataSet.mainRow


    Dim Lmargin, Rmargin, Tmargin, Bmargin As Integer
    Dim PrintWight, PrintHight, PageWight, PageHight As Integer

    Private rw As clRWini

    Public ReadOnly Property Document() As Printing.PrintDocument
        Get
            Return mPDoc
        End Get
    End Property

    Private mFont As Font
    Public Property FontDefault() As Font
        Get
            Return mFont
        End Get
        Set(ByVal value As Font)
            mFont = value
        End Set
    End Property

    Public Sub New(ByVal _document As MyPrintDocument, ByRef _dataset As GidrogasitelDataSet, ByVal _rw As clRWini)

        rw = _rw
        mPDoc = _document
        ds = _dataset

        'prtcl = New clProtokol(ds, rw)

        mFont = New Font("Times New Roman", 10, FontStyle.Regular)


        With mPDoc.DefaultPageSettings.Margins
            Lmargin = .Left
            Rmargin = .Right
            Tmargin = .Top
            Bmargin = .Bottom
        End With

        If mPDoc.DefaultPageSettings.Landscape = True Then
            With mPDoc.DefaultPageSettings.PaperSize
                PrintWight = .Height - Tmargin - Bmargin
                PrintHight = .Width - Lmargin - Rmargin
                PageHight = .Width
                PageWight = .Height
            End With
        Else
            With mPDoc.DefaultPageSettings.PaperSize
                PrintWight = .Width - Lmargin - Rmargin
                PrintHight = .Height - Tmargin - Bmargin
                PageWight = .Width
                PageHight = .Height
            End With
        End If


    End Sub

    ''' <summary>
    ''' длина оси Х в мм
    ''' </summary>
    ''' <remarks></remarks>
    Const cLenGraph As Integer = 40

    ''' <summary>
    ''' сила по оси у в кН
    ''' </summary>
    ''' <remarks></remarks>
    Const cPowerGraph As Integer = 20

    Private Sub mPDoc_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles mPDoc.PrintPage
        Dim y As Single = 0
        Dim t As Single = 0
        Dim y1 As Single

        mPDoc.PageNumber += 1
        If mPDoc.PageNumber = 1 Then

            If main_row IsNot Nothing Then


                y = DrawStringInWidthPage(e.Graphics, y, _
                       String.Format("Протокол испытания гидрогасителя {0} от {1}  стенд А3124 {4}Вид ремонта - {2}   {4}Номер гидрогаcителя - {3}", ds.Apparats.FindByID(main_row.Type).Name, _
                           main_row._DateTime.ToShortDateString, ds.Remont.FindByID(main_row.Remont).Remont, main_row.Num, vbCrLf), FontDefault, StringFormatFlags.NoClip, StringAlignment.Center, 2)

                Dim strvals As String()
                Dim dblvals As Double()
                Dim dblvals2 As Double()

                Dim minv As Double
                Dim maxv As Double
                Dim curv As Double
                Dim resv As Boolean
                Dim resE As Boolean

                resE = True
                resv = True
                minv = 0
                maxv = 0
                curv = 0


                Dim rezult As GidrogasitelDataSet.RezultRow

                rezult = ds.Rezult.FindByID(main_row.Rezult1)

                y += 20

                If rezult.Values <> "" Then

                    Try


                        y += DrawStringInWidthPage(e.Graphics, y, "График рабочей диаграммы на первой скорости:", FontDefault, StringFormatFlags.NoClip, StringAlignment.Near)
                        y += 10
                        y1 = y
                        t = y
                        t += DrawGrid(e.Graphics, 0, y, 300, 150)

                        minv = Math.Round(main_row.ApparatsRow.P_dec_s1 * 0.8, 1)
                        maxv = Math.Round(main_row.ApparatsRow.P_dec_s1 * 1.2, 1)
                        curv = Math.Round(rezult.P_inc, 1)
                        If curv < minv Or curv > maxv Then resv = False
                        y1 += DrawString(e.Graphics, y1, 320, String.Format("Наибольшее усилие при сжатии, кН - {0}, норма - ({1}-{2});", curv, minv, maxv), _
                                                                            FontDefault, StringFormatFlags.NoClip, StringAlignment.Near)

                        minv = Math.Round(main_row.ApparatsRow.P_inc_s1 * 0.8, 1)
                        maxv = Math.Round(main_row.ApparatsRow.P_inc_s1 * 1.2, 1)
                        curv = Math.Round(rezult.P_dec, 1)
                        If curv < minv Or curv > maxv Then resv = False
                        y1 += DrawString(e.Graphics, y1, 320, String.Format("Наибольшее усилие при растяжении, кН - {0} норма - ({1}-{2});", curv, minv, maxv), _
                                                                            FontDefault, StringFormatFlags.NoClip, StringAlignment.Near)

                        y1 += DrawString(e.Graphics, y1, 320, String.Format("Ход поршня, мм - {0};", rezult.A), FontDefault, StringFormatFlags.NoClip, StringAlignment.Near)
                        y1 += DrawString(e.Graphics, y1, 320, String.Format("максимальная скорость поршня, м/c - {0};", rezult.Speed), FontDefault, StringFormatFlags.NoClip, StringAlignment.Near)
                        y1 += DrawString(e.Graphics, y1, 320, String.Format("Параметр сопротивления при сжатии, кН/(м/c) - {0};", rezult.B_inc), FontDefault, StringFormatFlags.NoClip, StringAlignment.Near)
                        y1 += DrawString(e.Graphics, y1, 320, String.Format("Параметр сопротивления при растяжении, кН/(м/c) - {0};", rezult.B_dec), FontDefault, StringFormatFlags.NoClip, StringAlignment.Near)

                        maxv = Math.Round(20, 0)
                        curv = Math.Round(rezult.Symmetry, 1)
                        If curv > maxv Then resv = False
                        y1 += DrawString(e.Graphics, y1, 320, String.Format("Симметричность параметра сопротивления - {0} %,{2} норма < {1}%;", curv, maxv, vbCrLf), FontDefault, StringFormatFlags.NoClip, StringAlignment.Near)


                        strvals = rezult.Values.Split(",")

                        ReDim dblvals(strvals.GetUpperBound(0))

                        For i As Integer = 0 To dblvals.GetUpperBound(0)
                            Dim shval As Short = Convert.ToInt16(strvals(i), 16)
                            dblvals(i) = shval * CInt(rw.LEN_DATCHIK_DISTANCE) / (lCOUNT_TIME_DISCRETS * 0.8)
                        Next

                        strvals = rezult.Values2.Split(",")

                        ReDim dblvals2(strvals.GetUpperBound(0))

                        For i As Integer = 0 To dblvals.GetUpperBound(0)
                            Dim shval As Short = Convert.ToInt16(strvals(i), 16)
                            dblvals2(i) = shval * (CInt(rw.LIM_POWER) / 1000) / lHALF_DISCRETS
                        Next

                        minv = Math.Round(main_row.ApparatsRow.E_s1 * 0.8, 1)
                        maxv = Math.Round(main_row.ApparatsRow.E_s1 * 1.2, 1)
                        curv = Math.Round(rezult.E, 1)
                        If curv < minv Or curv > maxv Then resE = False Else resE = True
                        y1 += DrawString(e.Graphics, y1, 320, String.Format("Энергоемкость, Дж - {0} , норма - ({1}-{2}).", curv, minv, maxv), FontDefault, StringFormatFlags.NoClip, StringAlignment.Near)

                        DrawCurveXY(e.Graphics, 0, y, 300, 150, dblvals2, dblvals, Color.Red, False)

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try

                End If


                'Dim strvals As String() = ds.Rezult.FindByID(main_row.Rezult1).Values.Split(",")

                'Dim singvals(strvals.GetUpperBound(0)) As Single

                'For i As Integer = 0 To singvals.GetUpperBound(0)
                '    Dim shval As Short = Convert.ToInt16(strvals(i), 16)
                '    singvals(i) = shval * 0.018310546875
                'Next

                'DrawCurve(e.Graphics, 0, y, 300, 150, singvals, Color.Red, False)


                'strvals = ds.Rezult.FindByID(main_row.Rezult1).Values2.Split(",")

                'Dim singvals2(strvals.GetUpperBound(0)) As Single

                'For i As Integer = 0 To singvals.GetUpperBound(0)
                '    Dim shval As Short = Convert.ToInt16(strvals(i), 16)
                '    singvals2(i) = shval * 0.003662109375
                'Next

                'DrawCurve(e.Graphics, 0, y, 300, 150, singvals2, Color.Blue, False)

                rezult = ds.Rezult.FindByID(main_row.Rezult2)


                If rezult.Values <> "" Then
                    Try

                        y = t
                        y += 20


                        y += DrawStringInWidthPage(e.Graphics, y, "График рабочей диаграммы на второй скорости:", FontDefault, StringFormatFlags.NoClip, StringAlignment.Near)
                        y += 10
                        t = y
                        t += DrawGrid(e.Graphics, 0, y, 300, 150)

                        y1 = y

                        minv = Math.Round(main_row.ApparatsRow.P_dec_s2 * 0.8, 1)
                        maxv = Math.Round(main_row.ApparatsRow.P_dec_s2 * 1.2, 1)
                        curv = Math.Round(rezult.P_inc, 1)
                        If curv < minv Or curv > maxv Then resv = False
                        y1 += DrawString(e.Graphics, y1, 320, String.Format("Наибольшее усилие при сжатии, кН - {0}, норма - ({1}-{2});", curv, minv, maxv), _
                                                                            FontDefault, StringFormatFlags.NoClip, StringAlignment.Near)

                        minv = Math.Round(main_row.ApparatsRow.P_inc_s2 * 0.8, 1)
                        maxv = Math.Round(main_row.ApparatsRow.P_inc_s2 * 1.2, 1)
                        curv = Math.Round(rezult.P_dec, 1)
                        If curv < minv Or curv > maxv Then resv = False
                        y1 += DrawString(e.Graphics, y1, 320, String.Format("Наибольшее усилие при растяжении, кН - {0}, норма - ({1}-{2});", curv, minv, maxv), _
                                                                            FontDefault, StringFormatFlags.NoClip, StringAlignment.Near)
                        y1 += DrawString(e.Graphics, y1, 320, String.Format("Ход поршня, мм - {0};", rezult.A), FontDefault, StringFormatFlags.NoClip, StringAlignment.Near)
                        y1 += DrawString(e.Graphics, y1, 320, String.Format("максимальная скорость поршня, м/c - {0};", rezult.Speed), FontDefault, StringFormatFlags.NoClip, StringAlignment.Near)
                        y1 += DrawString(e.Graphics, y1, 320, String.Format("Параметр сопротивления при сжатии, кН/(м/c) - {0};", rezult.B_inc), FontDefault, StringFormatFlags.NoClip, StringAlignment.Near)
                        y1 += DrawString(e.Graphics, y1, 320, String.Format("Параметр сопротивления при растяжении, кН/(м/c) - {0};", rezult.B_dec), FontDefault, StringFormatFlags.NoClip, StringAlignment.Near)

                        maxv = Math.Round(20, 0)
                        curv = Math.Round(rezult.Symmetry, 1)
                        If curv > maxv Then resv = False
                        y1 += DrawString(e.Graphics, y1, 320, String.Format("Симметричность параметра сопротивления - {0} %, {2}норма < {1}%;", curv, maxv, vbCrLf), FontDefault, StringFormatFlags.NoClip, StringAlignment.Near)


                        strvals = rezult.Values.Split(",")

                        ReDim dblvals(strvals.GetUpperBound(0))

                        For i As Integer = 0 To dblvals.GetUpperBound(0)
                            Dim shval As Short = Convert.ToInt16(strvals(i), 16)
                            dblvals(i) = shval * CInt(rw.LEN_DATCHIK_DISTANCE) / (lCOUNT_TIME_DISCRETS * 0.8)
                        Next

                        strvals = rezult.Values2.Split(",")

                        ReDim dblvals2(strvals.GetUpperBound(0))

                        For i As Integer = 0 To dblvals.GetUpperBound(0)
                            Dim shval As Short = Convert.ToInt16(strvals(i), 16)
                            dblvals2(i) = shval * (CInt(rw.LIM_POWER) / 1000) / lHALF_DISCRETS
                        Next


                        minv = Math.Round(main_row.ApparatsRow.E_s2 * 0.8, 1)
                        maxv = Math.Round(main_row.ApparatsRow.E_s2 * 1.2, 1)
                        curv = Math.Round(rezult.E, 1)
                        If curv < minv Or curv > maxv Then resE = False Else resE = True
                        y1 += DrawString(e.Graphics, y1, 320, String.Format("Энергоемкость, Дж - {0} , норма - ({1}-{2}).", curv, minv, maxv), FontDefault, StringFormatFlags.NoClip, StringAlignment.Near)

                        DrawCurveXY(e.Graphics, 0, y, 300, 150, dblvals2, dblvals, Color.Red, False)

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try

                End If


                rezult = ds.Rezult.FindByID(main_row.Rezult3)

                If rezult.Values <> "" Then
                    Try

                        y = t

                        y += 20
                        y += DrawStringInWidthPage(e.Graphics, y, "График рабочей диаграммы на третьей скорости:", FontDefault, StringFormatFlags.NoClip, StringAlignment.Near)
                        y += 10
                        t = y
                        t += DrawGrid(e.Graphics, 0, y, 300, 150)
                        y1 = y

                        minv = Math.Round(main_row.ApparatsRow.P_dec_s3 * 0.8, 1)
                        maxv = Math.Round(main_row.ApparatsRow.P_dec_s3 * 1.2, 1)
                        curv = Math.Round(rezult.P_inc, 1)
                        If curv < minv Or curv > maxv Then resv = False
                        y1 += DrawString(e.Graphics, y1, 320, String.Format("Наибольшее усилие при сжатии, кН - {0}, норма - ({1}-{2});", curv, minv, maxv), _
                                                                            FontDefault, StringFormatFlags.NoClip, StringAlignment.Near)

                        minv = Math.Round(main_row.ApparatsRow.P_inc_s3 * 0.8, 1)
                        maxv = Math.Round(main_row.ApparatsRow.P_inc_s3 * 1.2, 1)
                        curv = Math.Round(rezult.P_dec, 1)
                        If curv < minv Or curv > maxv Then resv = False
                        y1 += DrawString(e.Graphics, y1, 320, String.Format("Наибольшее усилие при растяжении, кН - {0} норма - ({1}-{2});", curv, minv, maxv), _
                                                                            FontDefault, StringFormatFlags.NoClip, StringAlignment.Near)
                        y1 += DrawString(e.Graphics, y1, 320, String.Format("Ход поршня, мм - {0};", rezult.A), FontDefault, StringFormatFlags.NoClip, StringAlignment.Near)
                        y1 += DrawString(e.Graphics, y1, 320, String.Format("максимальная скорость поршня, м/c - {0};", rezult.Speed), FontDefault, StringFormatFlags.NoClip, StringAlignment.Near)
                        y1 += DrawString(e.Graphics, y1, 320, String.Format("Параметр сопротивления при сжатии, кН/(м/c) - {0};", rezult.B_inc), FontDefault, StringFormatFlags.NoClip, StringAlignment.Near)
                        y1 += DrawString(e.Graphics, y1, 320, String.Format("Параметр сопротивления при растяжении, кН/(м/c) - {0};", rezult.B_dec), FontDefault, StringFormatFlags.NoClip, StringAlignment.Near)

                        maxv = Math.Round(20, 0)
                        curv = Math.Round(rezult.Symmetry, 1)
                        If curv > maxv Then resv = False
                        y1 += DrawString(e.Graphics, y1, 320, String.Format("Симметричность параметра сопротивления - {0} %, {2}норма < {1}%;", curv, maxv, vbCrLf), FontDefault, StringFormatFlags.NoClip, StringAlignment.Near)


                        strvals = rezult.Values.Split(",")

                        ReDim dblvals(strvals.GetUpperBound(0))

                        For i As Integer = 0 To dblvals.GetUpperBound(0)
                            Dim shval As Short = Convert.ToInt16(strvals(i), 16)
                            dblvals(i) = shval * CInt(rw.LEN_DATCHIK_DISTANCE) / (lCOUNT_TIME_DISCRETS * 0.8)
                        Next

                        strvals = rezult.Values2.Split(",")

                        ReDim dblvals2(strvals.GetUpperBound(0))

                        For i As Integer = 0 To dblvals.GetUpperBound(0)
                            Dim shval As Short = Convert.ToInt16(strvals(i), 16)
                            dblvals2(i) = shval * (CInt(rw.LIM_POWER) / 1000) / lHALF_DISCRETS
                        Next

                        minv = Math.Round(main_row.ApparatsRow.E_s3 * 0.8, 1)
                        maxv = Math.Round(main_row.ApparatsRow.E_s3 * 1.2, 1)
                        curv = Math.Round(rezult.E, 1)
                        If curv < minv Or curv > maxv Then resE = False Else resE = True
                        y1 += DrawString(e.Graphics, y1, 320, String.Format("Энергоемкость, Дж - {0} , норма - ({1}-{2}).", curv, minv, maxv), FontDefault, StringFormatFlags.NoClip, StringAlignment.Near)

                        DrawCurveXY(e.Graphics, 0, y, 300, 150, dblvals2, dblvals, Color.Red, False)

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try

                End If

                y = t

                y += 30

                resv = resv And resE
                If resv Then
                    y += DrawStringInWidthPage(e.Graphics, y, String.Format("Вывод: Гидрогаситель соответствует ТУ", main_row.OperatorsRow.Last, main_row.OperatorsRow.First, main_row.OperatorsRow.Second), FontDefault, StringFormatFlags.NoClip, StringAlignment.Near)
                Else
                    y += DrawStringInWidthPage(e.Graphics, y, String.Format("Вывод: Параметры гидрогасителя отклоняются от нормы", main_row.OperatorsRow.Last, main_row.OperatorsRow.First, main_row.OperatorsRow.Second), FontDefault, StringFormatFlags.NoClip, StringAlignment.Near)
                End If

                y += 25
                y += DrawStringInWidthPage(e.Graphics, y, String.Format("Выполнил: {0} {1} {2}    ________________________", main_row.OperatorsRow.Last, main_row.OperatorsRow.First, main_row.OperatorsRow.Second), FontDefault, StringFormatFlags.NoClip, StringAlignment.Near)


                y += 25
                y += DrawStringInWidthPage(e.Graphics, y, String.Format("Заключение    _______________________________________________", main_row.OperatorsRow.Last, main_row.OperatorsRow.First, main_row.OperatorsRow.Second), FontDefault, StringFormatFlags.NoClip, StringAlignment.Near)



                mPDoc.PageNumber = 0
                e.HasMorePages = False

            End If

        End If

    End Sub


#Region "Drawing"

    Private Function DrawStringInWidthPage(ByRef _g As Graphics, ByVal _y As Single, ByVal _string As String, ByVal _font As Font, ByVal _format As StringFormatFlags, Optional ByVal _align As StringAlignment = StringAlignment.Center, Optional ByVal cnt_string As Integer = 1) As Single

        Dim width_string As Single = _g.MeasureString(_string, _font).Width
        Dim height_string As Single = _g.MeasureString(_string, _font).Height * cnt_string

        Dim y As Single = _y + Tmargin
        Dim x As Single = Lmargin

        Dim LayoutRectangle As New RectangleF(x, y, PrintWight, height_string)

        '_g.DrawRectangle(Pens.LightGray, x, y, PrintWight, height_string)

        Dim format As New StringFormat(_format)
        format.Alignment = _align
        _g.DrawString(_string, _font, Brushes.Black, LayoutRectangle, format)
        Return height_string
    End Function

    Private Function DrawString(ByRef _g As Graphics, ByVal _y As Single, ByVal _x As Single, ByVal _string As String, ByVal _font As Font, ByVal _format As StringFormatFlags, Optional ByVal _align As StringAlignment = StringAlignment.Center, Optional ByVal cnt_string As Integer = 1) As Single

        Dim width_string As Single = _g.MeasureString(_string, _font).Width
        Dim height_string As Single = _g.MeasureString(_string, _font).Height * cnt_string

        Dim y As Single = _y + Tmargin
        Dim x As Single = Lmargin

        Dim LayoutRectangle As New RectangleF(x + _x, y, PrintWight, height_string)

        '_g.DrawRectangle(Pens.LightGray, x, y, PrintWight, height_string)

        Dim format As New StringFormat(_format)
        format.Alignment = _align
        _g.DrawString(_string, _font, Brushes.Black, LayoutRectangle, format)
        Return height_string
    End Function

    Private Function DrawGrid(ByRef _g As Graphics, ByVal _x As Single, ByVal _y As Single, ByVal _wight As Single, ByVal _height As Single) As Single

        _y = _y + Tmargin + _height
        _x = _x + Lmargin

        'grid x
        Dim mXmin, mStepX, mXmax As Single

        mXmin = 0
        mXmax = cLenGraph
        mStepX = 10

        For i As Single = mXmin + mStepX To mXmax Step mStepX
            Dim delta As Single = _wight / (mXmax - mXmin)
            _g.DrawLine(New Pen(Color.LightGray, 1), _x + i * delta, _y, _x + i * delta, _y - _height)
        Next i

        'grid y
        Dim mYmin, mstepY, mYmax As Single

        mYmin = -cPowerGraph
        mYmax = cPowerGraph
        mstepY = mYmax / 5

        'For i As Single = mYmin + mstepY To mYmax Step mstepY
        '    Dim delta As Single = _height / (mYmax - mYmin)
        '    _g.DrawLine(New Pen(Color.LightGray, 1), _x, _y - i * delta, _x + _wight, _y - i * delta)
        'Next i

        For i As Single = 0 To mYmax - mYmin Step mstepY
            Dim delta As Single = _height / (mYmax - mYmin)
            _g.DrawLine(New Pen(Color.LightGray, 1), _x, _y - i * delta, _x + _wight, _y - i * delta)
        Next i

        'point axise x
        Dim mPointHight As Single = 6
        For i As Single = mXmin + mStepX To mXmax Step mStepX
            Dim delta As Single = _wight / (mXmax - mXmin)
            _g.DrawLine(Pens.Black, _x + i * delta, _y + mPointHight / 2, _x + i * delta, _y - mPointHight / 2)
        Next i

        'point axise y
        'For i As Single = mYmin + mstepY To mYmax Step mstepY
        '    Dim delta As Single = _height / (mYmax - mYmin)
        '    _g.DrawLine(Pens.Black, _x + mPointHight, _y - i * delta, _x, _y - i * delta)
        'Next i
        For i As Single = 0 To mYmax - mYmin Step mstepY
            Dim delta As Single = _height / (mYmax - mYmin)
            _g.DrawLine(Pens.Black, _x + mPointHight / 2 + 1, _y - i * delta, _x, _y - i * delta)
        Next i

        'text point axise x
        Dim mFontPoint As Font = FontDefault

        Dim drawFormat As New StringFormat
        drawFormat.LineAlignment = StringAlignment.Near
        drawFormat.Alignment = StringAlignment.Center

        For i As Single = mXmin + mStepX To mXmax Step mStepX
            Dim delta As Single = _wight / (mXmax - mXmin)
            _g.DrawString(i.ToString, mFontPoint, Brushes.Black, _x + i * delta, _y + mPointHight / 2, drawFormat)

        Next i

        'text point axise y
        Dim lenght As Single

        drawFormat.LineAlignment = StringAlignment.Center
        drawFormat.Alignment = StringAlignment.Far


        'For i As Single = mYmin + mstepY To mYmax Step mstepY
        '    Dim delta As Single = _height / (mYmax - mYmin)
        '    _g.DrawString(i.ToString, mFontPoint, Brushes.Black, _x - mPointHight / 2, _y - i * delta, drawFormat)
        '    lenght = _g.MeasureString(i.ToString, mFontPoint).Width
        'Next i
        For i As Single = 0 To mYmax - mYmin Step mstepY
            Dim delta As Single = _height / (mYmax - mYmin)
            _g.DrawString((i + mYmin).ToString, mFontPoint, Brushes.Black, _x - mPointHight / 2, _y - i * delta, drawFormat)
            lenght = _g.MeasureString(i.ToString, mFontPoint).Width
        Next
        Dim mMaxWightTextY As Single = lenght

        'text axise x
        Dim mFontAxis As Font = FontDefault
        Dim mTextAxisXoffset As Single = 1

        Dim rect As New System.Drawing.Rectangle(_x, _y + (mPointHight / 2) + mFontPoint.Height + mTextAxisXoffset, _wight, mFontAxis.Height)

        drawFormat.LineAlignment = StringAlignment.Center
        drawFormat.Alignment = StringAlignment.Center
        _g.DrawString("Перемещение, мм", mFontAxis, Brushes.Black, rect, drawFormat)

        'text axise y
        Dim mTop As Single = _y - _height

        rect = New System.Drawing.Rectangle(_x - mFontAxis.Height, mTop, mFontAxis.Height, _height)

        drawFormat.LineAlignment = StringAlignment.Center
        drawFormat.Alignment = StringAlignment.Center
        drawFormat.FormatFlags = StringFormatFlags.DirectionVertical
        _g.TranslateTransform(_x - mMaxWightTextY - mTextAxisXoffset - mFontAxis.Height / 2, mTop + _height / 2)
        _g.RotateTransform(180)
        _g.DrawString("Усилие, кН", mFontAxis, Brushes.Black, 0, 0, drawFormat)

        _g.ResetTransform()
        'ax Y
        _g.DrawLine(New Pen(Color.Black, 2), _x - 1, mTop + 0, _x - 1, mTop + _height + 1)
        'ax X
        _g.DrawLine(New Pen(Color.Black, 2), _x - 1, _y + 1 - _height / 2, _x + _wight, _y + 1 - _height / 2)

        Return _height + rect.Width + (mPointHight / 2) + mFontPoint.Height + mTextAxisXoffset
    End Function


    Private Sub DrawCurve(ByRef _g As Graphics, ByVal _x As Single, ByVal _y As Single, ByVal _wight As Single, _
            ByVal _height As Single, ByVal values As Single(), ByVal _color As Color, ByVal _smooth As Boolean)

        If values Is Nothing Then Exit Sub
        If values.Length = 0 Then Exit Sub

        Dim sX, sY As Single
        Dim PointSize As Single = 2

        _g.ResetTransform()

        _y = _y + Tmargin + _height
        _x = _x + Lmargin

        Dim points(values.GetUpperBound(0)) As Point

        Dim X0 As Single
        Dim Y0 As Single

        X0 = _x
        Y0 = _y - _height / 2

        Dim dx, dy As Single

        dx = _wight / values.GetUpperBound(0)
        sX = X0

        dy = (_height / 2) / 30
        sY = Y0

        For i As Integer = 0 To values.GetUpperBound(0)
            sX += dx
            sY = Y0 - values(i) * dy
            points(i) = New Point(sX, sY)
        Next

        If _smooth = True Then
            _g.DrawCurve(New Pen(_color, 1), points, 0.5)
        Else
            _g.DrawLines(New Pen(_color, 1), points)
        End If

        'For i As Integer = 0 To points.GetUpperBound(0)
        '    ' points(i) = New Point(sX, sY)
        '    Dim rect_draw As New System.Drawing.Rectangle(points(i).X - PointSize - 1, points(i).Y - PointSize - 1, (PointSize + 1) << 1, (PointSize + 1) << 1)
        '    _g.FillRectangle(New System.Drawing.SolidBrush(_color), rect_draw)
        '    _g.DrawRectangle(New Pen(_color, 1), rect_draw)
        'Next

    End Sub


    Private Sub DrawCurveXY(ByRef _g As Graphics, ByVal _x As Single, ByVal _y As Single, ByVal _wight As Single, _
            ByVal _height As Single, ByVal values1 As Double(), ByVal values2 As Double(), ByVal _color As Color, ByVal _smooth As Boolean)

        If values1 Is Nothing Then Exit Sub
        If values1.Length = 0 Then Exit Sub

        Dim sX, sY As Single
        Dim PointSize As Single = 2

        _g.ResetTransform()

        _y = _y + Tmargin + _height
        _x = _x + Lmargin

        Dim points(values1.GetUpperBound(0)) As Point

        Dim X0 As Single
        Dim Y0 As Single

        X0 = _x
        Y0 = _y - _height / 2

        Dim dx, dy As Single

        dx = _wight / cLenGraph  'values1.GetUpperBound(0)
        sX = X0

        dy = (_height / 2) / (cPowerGraph)
        sY = Y0

        For i As Integer = 0 To values1.GetUpperBound(0)
            sX = X0 + values2(i) * dx
            sY = Y0 - values1(i) * dy
            points(i) = New Point(sX, sY)
        Next

        If _smooth = True Then
            _g.DrawCurve(New Pen(_color, 1), points, 0.5)
        Else
            _g.DrawLines(New Pen(_color, 1), points)
        End If

        'For i As Integer = 0 To points.GetUpperBound(0)
        '    ' points(i) = New Point(sX, sY)
        '    Dim rect_draw As New System.Drawing.Rectangle(points(i).X - PointSize - 1, points(i).Y - PointSize - 1, (PointSize + 1) << 1, (PointSize + 1) << 1)
        '    _g.FillRectangle(New System.Drawing.SolidBrush(_color), rect_draw)
        '    _g.DrawRectangle(New Pen(_color, 1), rect_draw)
        'Next

    End Sub


#End Region

    Public Sub SetIndexDataSet(ByVal _idx As Integer)
        main_row = ds.main.FindByID(_idx)
    End Sub

End Class
