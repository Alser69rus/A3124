﻿Imports System.IO
Imports System.Text

Public Class frmAnaliseDataGidrogasitel

    Dim buf1 As Short()
    Dim buf2 As Short()
    Dim rw As New clRWini
    Dim analise As New clAnaliseFile(rw)




    Private Sub btnOpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenFile.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim mSR As New StreamReader(OpenFileDialog1.FileName)

            Dim file As String = mSR.ReadToEnd()

            mSR.Close()

            mSR = Nothing

            Dim abuf1 As New ArrayList
            Dim abuf2 As New ArrayList

            Dim arr As Array = file.Split(vbCrLf)
            Dim b As Array
            For i As Integer = 2 To arr.GetUpperBound(0)
                b = CStr(arr(i)).Split(vbTab)
                abuf1.Add(CShort(b(0)))
                abuf2.Add(CShort(b(1)))
            Next

            buf1 = abuf1.ToArray(GetType(Short))
            buf2 = abuf2.ToArray(GetType(Short))

            abuf1.Clear()
            abuf2.Clear()

            abuf1 = Nothing
            abuf2 = Nothing


            arr = Nothing

            lblNumStrok.Text = buf1.Count




            'analise.SetArray(buf1, buf2)

            'Debug.Print("pos={0}", pos)
            'pos = analise.FindMaximum(pos, 5, 256)
            'Debug.Print("pos={0}", pos)
            'pos = analise.FindMaximum(pos, 5, 256)
            'Debug.Print("pos={0}", pos)
            'pos = analise.FindMaximum(pos, 5, 256)
            'Debug.Print("pos={0}", pos)
            'pos = analise.FindMaximum(pos, 5, 256)
            'Debug.Print("pos={0}", pos)
            'pos = analise.FindMaximum(pos, 5, 256)
            'Debug.Print("pos={0}", pos)
            'pos = analise.FindMaximum(pos, 5, 256)
            'Debug.Print("pos={0}", pos)
            'pos = analise.FindMaximum(pos, 5, 256)
            'Debug.Print("pos={0}", pos)
            'pos = analise.FindMaximum(pos, 5, 256)
            'Debug.Print("pos={0}", pos)

            analise.Filter(100)

            COscill1.Xmax = buf1.Length

            COscill1.AddCurve(analise.valuses1filtring, 1)
            COscill1.AddCurve(analise.valuses2filtring, 1)

            IsFirstPosition = True


            Dim mFileName As String = "filter.adc"
            Dim mPath As String = My.Application.Info.DirectoryPath & "\LOG\"

            Directory.CreateDirectory(mPath)
            Dim fs As FileStream = IO.File.Create(mPath & mFileName)
            fs.Close()
            fs = Nothing



            Dim mSW As StreamWriter = New StreamWriter(mPath & mFileName, True, Encoding.GetEncoding(1251))

            For i As Integer = 0 To analise.valuses1filtring.GetUpperBound(0)
                mSW.Write(vbCrLf & analise.valuses1filtring(i) & vbTab)
            Next
            
            mSW.Close()

        End If


    End Sub

    Dim pos As Integer = 0
    Dim IsFirstPosition As Boolean = True

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click

        Dim ext1, ext2, ext3 As Integer

        If IsFirstPosition = True Then
            IsFirstPosition = False

            pos = analise.FindExtremumMaximum(pos, 5, 256)
            ext1 = pos
            COscill1.AddMarkLine(pos, buf1(pos), 1, Color.Blue, pOscill.cOscill.eLineDirect.ГоризонтальноеВертикальное)

            pos = analise.FindExtremumMinimum(pos, 5, 256)
            ext2 = pos
            COscill1.AddMarkLine(pos, buf1(pos), 1, Color.Green, pOscill.cOscill.eLineDirect.ГоризонтальноеВертикальное)

            pos = analise.FindExtremumMaximum(pos, 5, 256)
            ext3 = pos
            COscill1.AddMarkLine(pos, buf1(pos), 1, Color.Blue, pOscill.cOscill.eLineDirect.ГоризонтальноеВертикальное)
        Else
            ext1 = pos

            pos = analise.FindExtremumMinimum(pos, 5, 256)
            ext2 = pos
            COscill1.AddMarkLine(pos, buf1(pos), 1, Color.Green, pOscill.cOscill.eLineDirect.ГоризонтальноеВертикальное)

            pos = analise.FindExtremumMaximum(pos, 5, 256)
            ext3 = pos
            COscill1.AddMarkLine(pos, buf1(pos), 1, Color.Blue, pOscill.cOscill.eLineDirect.ГоризонтальноеВертикальное)

        End If



        If ext3 <> 0 Then
            Dim len As Integer = ext3 - ext1

            COscill2.Xmax = len

            Dim tbuf1(len - 1) As Short
            Array.Copy(analise.valuses1filtring, ext1, tbuf1, 0, len)

            Dim tbuf2(len - 1) As Short
            Array.Copy(analise.valuses2filtring, ext1, tbuf2, 0, len)

            COscill2.AddCurve(tbuf1, 1)
            COscill2.AddCurve(tbuf2, 1)

            txtLen.Text = len.ToString
            txtMax1.Text = ext1.ToString
            txtMax2.Text = ext3.ToString
            txtMin.Text = ext2.ToString

            txtMax1Dist.Text = analise.valuses1filtring(ext1).ToString
            txtMax2Dist.Text = analise.valuses1filtring(ext3).ToString
            txtMin1Dist.Text = analise.valuses1filtring(ext2).ToString

            If ext1 > ext3 Then
                txtAmplDist.Text = Math.Round((analise.valuses1filtring(ext1) - analise.valuses1filtring(ext2)) * 0.01465, 0).ToString
            Else
                txtAmplDist.Text = Math.Round((analise.valuses1filtring(ext3) - analise.valuses1filtring(ext2)) * 0.01465, 0).ToString
            End If

            txtT.Text = Math.Round(len * 0.00048828125, 2)
            txtF.Text = Math.Round(1 / (len * 0.00048828125), 2)

            For i As Integer = 0 To tbuf1.GetUpperBound(0)
                tbuf1(i) = tbuf1(i) - 3000
            Next
            COscill3.UIDrawOscillXY(tbuf1, tbuf2, 1, 1)
        Else
            IsFirstPosition = True
            pos = 0
        End If

    End Sub


End Class


Public Class clAnaliseFile

    Implements IDisposable


    Public values_len(lCOUNT_TIME_DISCRETS - 1) As Double
    Public values_power(lCOUNT_TIME_DISCRETS - 1) As Double


    Dim pos As Integer = 0
    Dim IsFirstPosition As Boolean = True

    Private rw As clRWini

    Public Sub GetDataFromFile(ByVal filename As String)
        Dim mSR As New StreamReader(filename)

        Dim file As String = mSR.ReadToEnd()
        mSR.Close()
        mSR = Nothing

        Dim abuf1 As New ArrayList
        Dim abuf2 As New ArrayList

        Dim arr As Array = file.Split(vbCrLf)
        Dim b As Array
        Dim idx_len, idx_power As Integer

        idx_len = CInt(rw.NUM_CHANEL_DISTANCE)
        idx_power = CInt(rw.NUM_CHANEL_TENZO)

        For i As Integer = 2 To arr.GetUpperBound(0)
            b = CStr(arr(i)).Split(vbTab)
            abuf1.Add(CDbl(b(idx_len)))
            abuf2.Add(CDbl(b(idx_power)))
        Next

        Dim start_idx As Integer = abuf1.Count / 2
        start_idx -= (lCOUNT_TIME_DISCRETS / 2)
        For i As Integer = 0 To (lCOUNT_TIME_DISCRETS - 1)
            values_len(i) = CDbl(abuf1.Item(i + start_idx))
            values_power(i) = CDbl(abuf2.Item(i + start_idx))
        Next
        

        abuf1.Clear()
        abuf2.Clear()

        abuf1 = Nothing
        abuf2 = Nothing


        arr = Nothing


        Dim mFileName As String = "len_power_nonfilter.adc"
        Dim mPath As String = My.Application.Info.DirectoryPath & "\LOG\"

        Directory.CreateDirectory(mPath)
        Dim fs As FileStream = IO.File.Create(mPath & mFileName)
        fs.Close()
        fs = Nothing

        Dim mSW As StreamWriter = New StreamWriter(mPath & mFileName, True, Encoding.GetEncoding(1251))

        For i As Integer = 0 To (lCOUNT_TIME_DISCRETS - 1)
            mSW.Write(vbCrLf & values_len(i).ToString("f0") & vbTab & values_power(i).ToString("f0"))
        Next

       

        'For i As Integer = 0 To valuses1filtring.GetUpperBound(0)
        '    mSW.Write(vbCrLf & valuses1filtring(i) & vbTab & valuses2filtring(i))
        'Next

        mSW.Close()


        Dim bpf_filter As bpf

        bpf_filter = New bpf(values_len, values_len.Length)
        bpf_filter.calculate()
        bpf_filter.filtring(32, values_len.Length - 32)
        bpf_filter.calculate()

        Array.Copy(bpf_filter.GetBack, values_len, values_len.Length)


        bpf_filter = New bpf(values_power, values_power.Length)
        bpf_filter.calculate()
        bpf_filter.filtring(32, values_power.Length - 32)
        bpf_filter.calculate()

        Array.Copy(bpf_filter.GetBack, values_power, values_power.Length)

       


        mFileName = "len_power_filter.adc"
        mPath = My.Application.Info.DirectoryPath & "\LOG\"

        Directory.CreateDirectory(mPath)
        fs = IO.File.Create(mPath & mFileName)
        fs.Close()
        fs = Nothing

        mSW = New StreamWriter(mPath & mFileName, True, Encoding.GetEncoding(1251))

        For i As Integer = 0 To (lCOUNT_TIME_DISCRETS - 1)
            mSW.Write(vbCrLf & values_len(i).ToString("f0") & vbTab & values_power(i).ToString("f0"))
        Next

        For Each vl As Double In bpf_filter.GetBack

        Next

        'For i As Integer = 0 To valuses1filtring.GetUpperBound(0)
        '    mSW.Write(vbCrLf & valuses1filtring(i) & vbTab & valuses2filtring(i))
        'Next

        mSW.Close()


        'Init()

        'Debug.Print("pos={0}", pos)
        'pos = analise.FindMaximum(pos, 5, 256)
        'Debug.Print("pos={0}", pos)
        'pos = analise.FindMaximum(pos, 5, 256)
        'Debug.Print("pos={0}", pos)
        'pos = analise.FindMaximum(pos, 5, 256)
        'Debug.Print("pos={0}", pos)
        'pos = analise.FindMaximum(pos, 5, 256)
        'Debug.Print("pos={0}", pos)
        'pos = analise.FindMaximum(pos, 5, 256)
        'Debug.Print("pos={0}", pos)
        'pos = analise.FindMaximum(pos, 5, 256)
        'Debug.Print("pos={0}", pos)
        'pos = analise.FindMaximum(pos, 5, 256)
        'Debug.Print("pos={0}", pos)
        'pos = analise.FindMaximum(pos, 5, 256)
        'Debug.Print("pos={0}", pos)

        'Filter(100)

        'min_value = lHALF_DISCRETS
        'max_value1 = -lHALF_DISCRETS
        'max_value2 = -lHALF_DISCRETS
        'position_max_value1 = 0
        'position_max_value2 = 0
        'avg_value = 0
        'pos = 0
        'IsFirstPosition = True

        'Dim filter2 As New bpf(values_len, values_len.Length)
        'filter2.calculate()
        'filter2.filtring(32, values_len.Length - 32)
        'filter2.calculate()



        'mFileName = "len.adc"
        'mPath = My.Application.Info.DirectoryPath & "\LOG\"

        'Directory.CreateDirectory(mPath)
        'fs = IO.File.Create(mPath & mFileName)
        'fs.Close()
        'fs = Nothing



        'mSW = New StreamWriter(mPath & mFileName, True, Encoding.GetEncoding(1251))

        'For Each vl As Double In filter2.GetBack
        '    mSW.Write(vbCrLf & vl.ToString("f0"))
        'Next

        ''For i As Integer = 0 To valuses1filtring.GetUpperBound(0)
        ''    mSW.Write(vbCrLf & valuses1filtring(i) & vbTab & valuses2filtring(i))
        ''Next

        'mSW.Close()

        'mSW = Nothing
    End Sub


    Public Sub Init()
        min_value = lHALF_DISCRETS
        max_value1 = -lHALF_DISCRETS
        max_value2 = -lHALF_DISCRETS
        position_max_value1 = 0
        position_max_value2 = 0
        avg_value = 0
        pos = 0
        IsFirstPosition = True


    End Sub

    Private min_value As Short = lHALF_DISCRETS
    Private max_value1 As Short = -lHALF_DISCRETS
    Private max_value2 As Short = -lHALF_DISCRETS


    Private position_min_value As Integer
    Private position_max_value1 As Integer
    Private position_max_value2 As Integer

    Private avg_value As Integer




    Public Sub Filter(ByVal psets As Integer)

        ReDim valuses1filtring(values_len.GetUpperBound(0) - psets)
        ReDim valuses2filtring(values_power.GetUpperBound(0) - psets)

        Dim val1 As Integer
        Dim val2 As Integer

        For i As Integer = psets To values_len.GetUpperBound(0)

            val1 = 0
            val2 = 0

            For n As Integer = i To i - psets Step -1
                val1 += values_len(n)
                val2 += values_power(n)
            Next

            val1 /= psets
            val2 /= psets

            valuses1filtring(i - psets) = val1
            valuses2filtring(i - psets) = val2

        Next

    End Sub


    ''' <summary>
    ''' определяем тенденцию развития сигнала в заданной точке
    ''' </summary>
    ''' <returns> если больше 0 то идет увеличение сигнала если меньше 0 то уменьшение, около 0 гдето рядом экстремум</returns>
    ''' <remarks></remarks>
    Private Function Tendention(ByVal start_position As Integer, ByVal frame_len As Integer) As Single

        Dim count_increase As Integer = 0
        Dim count_decrease As Integer = 0

        Dim value_increase As Integer = 0
        Dim value_decrease As Integer = 0

        Dim d_sig As Integer = 0
        Dim b_sig As Integer = 0

        Dim start_frame As Integer
        Dim len As Integer = frame_len

        'ограничение с начала
        start_frame = start_position - frame_len / 2

        If start_frame < 0 Then
            len = len + start_frame
            start_frame = 0
        End If


        'ограничение с конца
        If start_position + len > values_len.Count Then
            len = values_len.Count - start_position
        End If

        For i As Integer = start_frame To start_frame + len - 1

            If i = 0 Then
                d_sig = 0
            Else
                d_sig = values_len(i - 1) - values_len(i)
            End If


            If d_sig > 0 Then
                value_decrease += d_sig
                count_decrease += 1
            End If

            If d_sig < 0 Then
                value_increase += d_sig
                count_increase += 1
            End If

        Next

        Dim srez1 As Single = Math.Round(Math.Abs(value_increase) / value_decrease, 3)
        Dim srez2 As Single = Math.Round(count_increase / count_decrease, 3)

        ' Debug.Print("pos={0} srez={1} rez={2}", start_position, srez1, srez2)

        Return srez1
    End Function


    Private Structure sRezultTrend
        Dim До As Single
        Dim после As Single
    End Structure

    ''' <summary>
    ''' определяем тенденцию развития сигнала в заданной точке
    ''' </summary>
    ''' <returns> если больше 0 то идет увеличение сигнала если меньше 0 то уменьшение, около 0 гдето рядом экстремум</returns>
    ''' <remarks></remarks>
    Private Function TendentionSimetrichno(ByVal start_position As Integer, ByVal frame_len As Integer) As sRezultTrend

        Dim value_increase1 As Integer = 0
        Dim value_decrease1 As Integer = 0

        Dim value_increase2 As Integer = 0
        Dim value_decrease2 As Integer = 0

        Dim d_sig As Integer = 0
        Dim b_sig As Integer = 0


        Dim start_frame As Integer
        Dim len As Integer = frame_len

        'ограничение с начала
        start_frame = start_position - frame_len / 2

        If start_frame < 0 Then
            len = len + start_frame
            start_frame = 0
        End If


        'ограничение с конца
        If start_position + len > valuses1filtring.Count Then
            len = valuses1filtring.Count - start_position
        End If

        For i As Integer = start_frame To start_frame + len

            If i < start_position Then
                If i = 0 Then
                    d_sig = 0
                Else
                    d_sig = valuses1filtring(i - 1) - valuses1filtring(i)
                End If


                If d_sig > 0 Then
                    value_decrease1 += 1 'd_sig
                End If

                If d_sig < 0 Then
                    value_increase1 += 1 'd_sig
                End If
            End If

            If i > start_position Then
                If i = 0 Then
                    d_sig = 0
                Else
                    d_sig = valuses1filtring(i - 1) - valuses1filtring(i)
                End If


                If d_sig > 0 Then
                    value_decrease2 += 1 'd_sig
                End If

                If d_sig < 0 Then
                    value_increase2 += 1 'd_sig
                End If
            End If


        Next

        Dim rez As New sRezultTrend

        'If value_decrease1 = 0 Then
        '    If value_increase1 = 0 Then
        '        rez.До = 0
        '    Else
        '        rez.До = 10000
        '    End If

        'Else
        rez.До = value_increase1 - value_decrease1 'Math.Round((value_increase1) / value_decrease1, 3)
        'End If

        'If value_decrease2 = 0 Then
        '    If value_increase2 = 0 Then
        '        rez.после = 0
        '    Else
        '        rez.после = 10000
        '    End If

        'Else
        rez.после = value_increase2 - value_decrease2 'Math.Round((value_increase2) / value_decrease2, 3)
        'End If


        'Debug.Print("pos={0} До={1} После={2}", start_position, rez.До, rez.после)

        Return rez

    End Function


    Public Function FindMaximum(ByVal start_position As Integer, ByVal percent As Integer, ByVal frame_len As Integer) As Integer
        Dim cnt_max As Integer = 0
        Dim cnt_min As Integer = 0
        Dim begin_max As Integer = 0
        Dim end_max As Integer = 0
        Dim max_idx As Integer
        Dim lim_max As Single = 1 + percent / 100
        Dim lim_min As Single = 1 - percent / 100

        Dim drebezg_count As Integer = 5

        Dim find_end_increase As Boolean = False

        For i As Integer = start_position To values_len.GetUpperBound(0)
            Dim sg As Single = Tendention(i, frame_len)

            If find_end_increase = False Then
                If sg > lim_min And sg < lim_max Then
                    cnt_max += 1

                    If cnt_max = 1 Then
                        begin_max = i
                    End If

                    If cnt_max > drebezg_count Then
                        'точка окончания роста найдена переходим на поиск точки начала снижения
                        find_end_increase = True
                    End If
                Else
                    cnt_max = 0
                End If
            Else

                If sg < lim_min Then
                    cnt_min += 1

                    If cnt_min = 1 Then
                        end_max = i
                    End If

                    If cnt_min > drebezg_count Then
                        'найдена равноудаленная точка снижения 
                        end_max = i

                        max_idx = (end_max + begin_max) / 2
                        Return max_idx
                    End If
                Else
                    cnt_min = 0
                End If
            End If

        Next

    End Function


    Public Function FindExtremumMaximum(ByVal start_position As Integer, ByVal percent As Integer, ByVal frame_len As Integer) As Integer
        Dim cnt_max As Integer = 0
        Dim cnt_min As Integer = 0
        Dim begin_max As Integer = 0
        Dim end_max As Integer = 0
        Dim max_idx As Integer


        Dim drebezg_count As Integer = frame_len / 4 '64

        Dim find_end_increase As Boolean = False

        For i As Integer = start_position To valuses1filtring.GetUpperBound(0)
            Dim sg As sRezultTrend = TendentionSimetrichno(i, frame_len)

            If find_end_increase = False Then
                If sg.До > 0 And sg.после < 0 And (sg.До + sg.после) <= 2 Then
                    'cnt_max += 1

                    'If cnt_max > drebezg_count Then
                    'точка окончания роста найдена переходим на поиск точки начала снижения
                    begin_max = i ' - drebezg_count
                    find_end_increase = True
                    'End If
                    'Else
                    '    cnt_max = 0
                    Return begin_max
                End If
                'Else

                '    If sg.До < 1 And sg.после < 1 Then
                '        cnt_min += 1

                '        If cnt_min > drebezg_count Then
                '            'найдена равноудаленная точка снижения 
                '            end_max = i - drebezg_count

                '            max_idx = (end_max + begin_max) / 2
                '            Return max_idx
                '        End If
                '    Else
                '        cnt_min = 0
                '    End If
            End If

        Next

    End Function


    Public Function FindExtremumMinimum(ByVal start_position As Integer, ByVal percent As Integer, ByVal frame_len As Integer) As Integer
        Dim cnt_max As Integer = 0
        Dim cnt_min As Integer = 0
        Dim begin_max As Integer = 0
        Dim end_max As Integer = 0
        Dim max_idx As Integer


        Dim drebezg_count As Integer = frame_len / 4 '64

        Dim find_end_increase As Boolean = False

        For i As Integer = start_position To valuses1filtring.GetUpperBound(0)
            Dim sg As sRezultTrend = TendentionSimetrichno(i, frame_len)

            If find_end_increase = False Then
                If sg.До < 0 And sg.после > 0 And (-sg.До - sg.после) <= 2 Then
                    '    cnt_max += 1

                    '    If cnt_max > drebezg_count Then
                    '        'точка окончания роста найдена переходим на поиск точки начала снижения
                    '        begin_max = i - drebezg_count
                    '        find_end_increase = True
                    '    End If
                    'Else
                    '    cnt_max = 0
                    Return i
                End If
                'Else

                'If sg.До > 1 And sg.после > 1 Then
                '    cnt_min += 1

                '    If cnt_min > drebezg_count Then
                '        'найдена равноудаленная точка снижения 
                '        end_max = i - drebezg_count

                '        max_idx = (end_max + begin_max) / 2
                '        Return max_idx
                '    End If
                'Else
                '    cnt_min = 0
                'End If
            End If

        Next

    End Function


    Dim ext1, ext2, ext3 As Integer

    Public Sub NextPeriod()


        If IsFirstPosition = True Then
            IsFirstPosition = False

            pos = FindExtremumMaximum(pos, 5, 256)
            ext1 = pos

            pos = FindExtremumMinimum(pos, 5, 256)
            ext2 = pos

            pos = FindExtremumMaximum(pos, 5, 256)
            ext3 = pos

        Else
            ext1 = pos

            pos = FindExtremumMinimum(pos, 5, 256)
            ext2 = pos

            pos = FindExtremumMaximum(pos, 5, 256)
            ext3 = pos

        End If



        If ext3 <> 0 Then

        Else
            IsFirstPosition = True
            pos = 0
        End If

    End Sub

    Public Structure sRezultAnalise
        Dim Lenght As Short
        Dim ValuesLen As Short()
        Dim ValuesPower As Short()
        Dim MaxLen1 As Short
        Dim MaxLen2 As Short
        Dim MinLen1 As Short
    End Structure


    Public ReadOnly Property GetRezult() As sRezultAnalise
        Get
            Dim rez As New sRezultAnalise

            With rez
                .Lenght = ext3 - ext1

                'find min abs value
                Dim min As Short = 16383
                For i As Integer = ext1 To ext3
                    If valuses1filtring(i) < min Then
                        min = valuses1filtring(i)
                    End If
                Next

                ReDim .ValuesLen(.Lenght - 1)
                Array.Copy(valuses1filtring, ext1, .ValuesLen, 0, .Lenght)

                For i As Integer = 0 To .ValuesLen.GetUpperBound(0)
                    .ValuesLen(i) = .ValuesLen(i) - min
                Next

                ReDim .ValuesPower(.Lenght - 1)



                Array.Copy(valuses2filtring, ext1, .ValuesPower, 0, .Lenght)

                For i As Integer = 0 To .ValuesPower.GetUpperBound(0)
                    .ValuesPower(i) = .ValuesPower(i) + CInt(rw.U_OUT_TENZO) 'здесь компенсация смещения датчика силы вниз
                Next

                .MaxLen1 = .ValuesLen(0)
                .MaxLen2 = .ValuesLen(.Lenght - 1)
                .MinLen1 = .ValuesLen(.Lenght / 2 - 1)

            End With

            Return rez
        End Get
    End Property

    Private disposedValue As Boolean = False        ' Чтобы обнаружить избыточные вызовы

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: освободить другие состояния (управляемые объекты).
            End If

            values_len = Nothing
            values_power = Nothing

            valuses1filtring = Nothing
            valuses2filtring = Nothing

            ' TODO: освободить собственные состояния (неуправляемые объекты).
            ' TODO: задать большие поля как null.
        End If

        Me.disposedValue = True
    End Sub

#Region " IDisposable Support "
    ' Этот код добавлен редактором Visual Basic для правильной реализации шаблона высвобождаемого класса.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Не изменяйте этот код. Разместите код очистки выше в Dispose(ByVal disposing As Boolean).
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

    Public Sub New(ByVal _rw As clRWini)
        rw = _rw
    End Sub


End Class
