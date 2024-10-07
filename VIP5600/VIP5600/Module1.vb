Imports System.Runtime.InteropServices


Module Module1

#Region "Константы LCARD"
    'разрядность ацп
    Public Const lDISCRETS As Integer = 4096
    Public Const lHALF_DISCRETS As Integer = (lDISCRETS / 2)
    'длинна временной выборки в отчетах АЦП
    Public Const lCOUNT_TIME_DISCRETS As Integer = 2048
    'количество опрашиваемых каналов
    Public Const lCOUNT_ADC_CHANELS As Integer = 8

#End Region



    ''' <summary>
    ''' показывает попало или нет значение в заданный предел с допустимым отклонением
    ''' </summary>
    ''' <param name="value">заданное значение</param>
    ''' <param name="lim">заданный предел</param>
    ''' <param name="delta">возможное отклонение от предела в процентах</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' 


    Public Function CheckLim(ByVal value As Single, ByVal lim As Single, ByVal delta As Single) As Boolean
        Dim min, max As Single
        min = lim * (100 - delta) / 100
        max = lim * (100 + delta) / 100
        If value < max And value > min Then Return True
        Return False
    End Function

    Public Function functVtoN(ByVal V As Single, ByVal A As Single) As Single
        If A = 0 Then A = 1
        Dim f As Single = 1000 * V * frmGMain.stend.rw.PER_SHTOK * 50 * 60 / (Math.PI * A * frmGMain.stend.rw.N_NOM)
        If f < 3 Then f = 3
        If f > 65 Then f = 65
        Return f

    End Function

    Public Function functAmin(ByVal V As Single) As Single
        Dim Nmax As Single = frmGMain.stend.rw.N_NOM * 65 / (50 * 60 * frmGMain.stend.rw.PER_SHTOK)
        Dim a As Single = 1000 * V / (Math.PI * Nmax)
        If a < frmGMain.stend.rw.MIN_AMPL Then a = frmGMain.stend.rw.MIN_AMPL
        If a > frmGMain.stend.rw.MAX_AMPL Then a = frmGMain.stend.rw.MAX_AMPL
        Return a
    End Function

    Public Function functAmax(ByVal V As Single) As Single
        Dim Nmin As Single = frmGMain.stend.rw.N_NOM * 3 / (50 * 60 * frmGMain.stend.rw.PER_SHTOK)
        Dim a As Single = 1000 * V / (Math.PI * Nmin)
        If a < frmGMain.stend.rw.MIN_AMPL Then a = frmGMain.stend.rw.MIN_AMPL
        If a > frmGMain.stend.rw.MAX_AMPL Then a = frmGMain.stend.rw.MAX_AMPL
        Return a
    End Function



    Public Sub analise_izmer(ByRef rezult As GidrogasitelDataSet.RezultRow, ByVal rw As clRWini)

        Dim str As String = ""
        Dim analise As clAnaliseFile
        Dim vals As clAnaliseFile.sRezultAnalise

        Dim min_distance As Short = lHALF_DISCRETS
        Dim max_distance As Short = -lHALF_DISCRETS

        Dim min_power As Short = lHALF_DISCRETS
        Dim max_power As Short = -lHALF_DISCRETS


        analise = New clAnaliseFile(rw)

        analise.GetDataFromFile(My.Application.Info.DirectoryPath & "\LOG\current.adc")

        analise.NextPeriod()

        vals = analise.GetRezult

        For i As Integer = 0 To vals.ValuesLen.GetUpperBound(0)

            If i = 0 Then
                str &= vals.ValuesLen(i).ToString("X4")
            Else
                str &= "," & vals.ValuesLen(i).ToString("X4")
            End If

            'find min max
            If vals.ValuesLen(i) < min_distance Then min_distance = vals.ValuesLen(i)
            If vals.ValuesLen(i) > max_distance Then max_distance = vals.ValuesLen(i)

        Next
        rezult.Values = str

        rezult.E = Math.Round((max_distance - min_distance) * 75 / lDISCRETS, 0)        'амплитуда хода поршня
        rezult.Speed = Math.Round(1 / (vals.ValuesLen.Count * (1 / lCOUNT_TIME_DISCRETS)), 2)           'частота в герцах

        str = ""

        Dim b_plus, b_mines As Double

        b_plus = 0
        b_mines = 0

        For i As Integer = 0 To vals.ValuesPower.GetUpperBound(0)

            If i = 0 Then
                str &= vals.ValuesPower(i).ToString("X4")
            Else
                str &= "," & vals.ValuesPower(i).ToString("X4")
            End If

            If vals.ValuesPower(i) < min_power Then min_power = vals.ValuesPower(i)
            If vals.ValuesPower(i) > max_power Then max_power = vals.ValuesPower(i)

            If vals.ValuesPower(i) > 0 Then b_plus += vals.ValuesPower(i)
            If vals.ValuesPower(i) < 0 Then b_mines += vals.ValuesPower(i)

        Next

        rezult.P_inc = Math.Round((30 / 8192) * max_power, 2)
        rezult.P_dec = Math.Round((30 / 8192) * min_power, 2)

        rezult.B_inc = Math.Round((30 / 8192) * (b_plus / vals.ValuesPower.Count) * (rezult.E / 100) / rezult.Speed, 2)
        rezult.B_dec = Math.Round((30 / 8192) * (b_mines / vals.ValuesPower.Count) * (rezult.E / 100) / rezult.Speed, 2)

        If rezult.B_inc <> 0 And rezult.B_dec <> 0 Then
            rezult.Symmetry = Math.Round((rezult.B_inc / rezult.B_dec), 2) * 100
        End If

        rezult.Values2 = str


        analise.Dispose()
        analise = Nothing

    End Sub

    Public Function CalculateArea(ByVal x As Double(), ByVal y As Double(), ByVal kx As Single, ByVal ky As Single) As Double
        Dim _x As Double = 0
        Dim _y As Double = 0

        ReDim Preserve x(x.Length)
        ReDim Preserve y(y.Length)

        x(x.GetUpperBound(0)) = x(0)
        y(y.GetUpperBound(0)) = y(0)

        For i = 0 To x.GetUpperBound(0) - 1
            _x += x(i) * y(i + 1) * ky * kx
            _y += y(i) * x(i + 1) * ky * kx
        Next

        _x = _x - _y
        If _x < 0 Then
            _x = -_x
        End If
        Return _x / 2

    End Function

    Public Function CalculateArea2(ByVal x As Single(), ByVal y As Single(), ByVal kx As Single, ByVal ky As Single) As Single
        Dim s As Single = 0


        ReDim Preserve x(x.Length)
        ReDim Preserve y(y.Length)

        x(x.GetUpperBound(0)) = x(0)
        y(y.GetUpperBound(0)) = y(0)

        For i = 0 To x.GetUpperBound(0) - 1
            s = s + (x(i) + x(i + 1)) * (y(i) - y(i + 1))
        Next
        s = Math.Abs(s * kx * ky / 2)

        Return s

    End Function

    ''' <summary>
    ''' дискретное быстрое преобразование фурье - прямое и обратное
    ''' </summary>
    ''' <remarks></remarks>
    Public Class bpf


        Dim n As Integer = 16
        Dim r As Integer = Math.Log(n) / Math.Log(2)
        Dim n1 As Integer = n >> 1
        Dim n2 As Integer = n1 + 1
        Dim nn As Double = 1 / n
        Dim dt As Integer = 1

        Dim a(n), b(n) As Double

        Dim _d As Integer = 1

        Public Sub New(ByVal val As Double(), ByVal len As Integer)
            ReDim a(len)
            ReDim b(len)
            ReDim direcvalues(len - 1)

            Dim idx As Integer = 1
            For Each vl As Double In val
                a(idx) = vl
                idx += 1
            Next

            _d = 1

            n = len
            r = Math.Log(n) / Math.Log(2)
            n1 = n >> 1
            n2 = n1 + 1
            nn = 1 / n

        End Sub



        Public Sub New(ByVal _a As Double(), ByVal _b As Double(), ByVal len As Integer, ByVal filtr_min As Integer, ByVal filtr_max As Integer)
            ReDim a(len)
            ReDim b(len)
            ReDim direcvalues(len)

            Dim idx As Integer = 1
            For i As Integer = 0 To len - 1
                If i <= filtr_min Then
                    a(idx) = _a(i)
                    b(idx) = _b(idx - 1)
                Else
                    If i < (len / 2) Then
                        a(idx) = 0
                        b(idx) = 0
                    End If

                End If

                If i >= filtr_max Then
                    a(idx) = _a(i)
                    b(idx) = _b(idx - 1)
                Else
                    If i > (len / 2) Then
                        a(idx) = 0
                        b(idx) = 0
                    End If

                End If

                'If i = filtr_min Or i = filtr_max Then
                '    a(idx) = _a(i)
                '    b(idx) = _b(idx - 1)
                'Else
                '    a(idx) = 0
                '    b(idx) = 0
                'End If

                idx += 1
            Next

            _d = -1

            n = len
            r = Math.Log(n) / Math.Log(2)
            n1 = n >> 1
            n2 = n1 + 1
            nn = 1 / n

        End Sub

        Public Sub filtring(ByVal filtr_min As Integer, ByVal filtr_max As Integer)

            Dim idx As Integer = 1

            For i As Integer = 0 To n - 1
                If i <= filtr_min Then

                Else
                    If i < (n / 2) Then
                        a(idx) = 0
                        b(idx) = 0
                    End If

                End If

                If i >= filtr_max Then

                Else
                    If i > (n / 2) Then
                        a(idx) = 0
                        b(idx) = 0
                    End If

                End If

                idx += 1
            Next

            _d = -1

        End Sub

        Public Sub calculate()
            Dim g, ni, j, k, i, L, m As Integer
            Dim x, y, z, e, c, ck, s, sk, u As Double

            r = Math.Round(Math.Log(n) / Math.Log(2), 0)
            ni = n1
            k = n2

            For i = 2 To n - 2
                If i < k Then
                    x = a(k)
                    y = b(k)
                    a(k) = a(i)
                    b(k) = b(i)
                    a(i) = x
                    b(i) = y
                End If
                L = ni
o:
                If L < k Then
                    k = k - L
                    L = L >> 1
                    GoTo o
                End If

                k = k + L

            Next

            m = 1
            L = n1

            For i = 1 To r
                x = -Math.PI * _d / m
                c = Math.Cos(x)
                s = Math.Sin(x)
                ck = 1
                sk = 0

                For j = 1 To m
                    For k = 1 To L
                        ni = j + 2 * (k - 1) * m
                        g = ni + m
                        z = a(g)
                        u = b(g)
                        x = z * ck + u * sk
                        y = u * ck - z * sk
                        z = a(ni)
                        u = b(ni)
                        a(ni) = z + x
                        b(ni) = u + y
                        a(g) = z - x
                        b(g) = u - y
                    Next
                    e = ck * c - sk * s
                    sk = sk * c + ck * s
                    ck = e
                Next
                m = m << 1
                L = L >> 1
            Next

            If _d = 1 Then
                For i = 1 To n
                    '_v = n1 - Math.Abs(n2 - i)
                    'If (f1 * n * dt <= _v) And (v <= f2 * n * dt) Then
                    a(i) = a(i) * nn
                    b(i) = b(i) * nn
                    'Else
                    'a(i) = 0
                    'b(i) = 0
                    'End If
                Next

            End If
        End Sub

        Public Structure sDirectValues
            Dim f As Double
            Dim a As Double
            Dim b As Double
            Dim Ak As Double
            Dim Ph As Double
        End Structure


        Private direcvalues As sDirectValues()

        Public ReadOnly Property GetDirect() As sDirectValues()
            Get
                For k As Integer = 0 To n - 1
                    direcvalues(k).a = a(k + 1)
                    direcvalues(k).b = b(k + 1)
                    direcvalues(k).f = (k) / (dt * n)
                    direcvalues(k).Ak = Math.Sqrt(a(k + 1) ^ 2 + b(k + 1) ^ 2)
                    direcvalues(k).Ph = Math.Atan2(a(k + 1), b(k + 1)) * 360 / (2 * Math.PI)
                    If direcvalues(k).Ph < 0 Then
                        direcvalues(k).Ph += 360
                    End If
                Next

                Return direcvalues
            End Get
        End Property

        Public ReadOnly Property GetBack() As Double()
            Get
                Dim _GetBack(n - 1) As Double

                For k As Integer = 1 To n
                    _GetBack(k - 1) = a(k)
                Next

                Return _GetBack
            End Get
        End Property





    End Class






    ''' <summary>
    ''' вычисляет частоту диcкретизации Лкард в зависимости от величины оборотов приводного вала
    ''' </summary>
    ''' <param name="N_nom">номинальные обороты приводного двигателя</param>
    ''' <param name="percent">фактический процент от номинальных оборотов - число от 0 до 1</param>
    ''' <param name="pered_red">передаточное число редуктора от двигателя к главному валу привода штока</param>
    ''' <param name="CountPeriods">число периодов сигнала в выборке</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CalculateFdiscrLcard(ByVal N_nom As Integer, ByVal percent As Single, ByVal pered_red As Single, Optional ByVal CountPeriods As Integer = 4) As Double

        Dim T As Single

        Dim n_fakt As Integer = 0

        Dim t_Fdiskr As Double = 0

        If percent > 0 Then
            n_fakt = N_nom * percent

            T = CountPeriods * 60 * pered_red / n_fakt

            t_Fdiskr = lCOUNT_ADC_CHANELS * lCOUNT_TIME_DISCRETS / T

            t_Fdiskr = Math.Round(t_Fdiskr, 1)

            t_Fdiskr -= 0.1

            t_Fdiskr /= 1000


        End If

        Debug.Print("nnom={0} n_fakt={1} t4={2} fdiskr={3}", N_nom, n_fakt, T, t_Fdiskr)

        Return t_Fdiskr

    End Function

    ''' <summary>
    ''' вычисление требуемой частоты привода в зависимости от амлитуды и скорости
    ''' </summary>
    ''' <param name="N_nom">номинальная скорость двигателя</param>
    ''' <param name="pered_red">передаточное число редуктора от двигателя к главному валу привода штока</param>
    ''' <param name="ampl">амплитуда хода поршня в мм</param>
    ''' <param name="speed">скорость перемещения поршня в м/c</param>
    ''' <returns>частота в Гц</returns>
    ''' <remarks></remarks>
    Public Function CalculateFprivod(ByVal N_nom As Integer, ByVal pered_red As Single, ByVal ampl As Integer, ByVal speed As Single) As Single

        Dim Fprivod As Single = speed

        Fprivod *= 50
        Fprivod *= 60
        Fprivod *= pered_red
        Fprivod /= Math.PI
        Fprivod /= (ampl / 1000)
        Fprivod /= N_nom

        Return Math.Round(Fprivod, 2)

    End Function

End Module




