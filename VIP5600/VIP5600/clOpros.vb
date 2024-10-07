Imports System.Globalization

Public Enum eProtokolType
    DCON
    ModbusRtu
End Enum
Public Structure s_command
    Dim rec As String
    Dim send As String
    Dim timeout As Integer
    Dim checksum As Boolean
    Dim count As Integer
    Dim SendVbCr As Boolean
    Dim removeCS As Boolean
    Dim PreviousDelay As Integer
    Dim [ParamArray] As String()
    Dim BaudRate As Integer
    Dim [StopBits] As Integer
    Dim Parity As Integer
    Dim DataLen As Integer
    Dim brec As Byte()
    Dim bsend As Byte()
    Dim protokol_type As eProtokolType

End Structure

Public Class clOpros

    Public log As New clLog
    

    Private _exit As Boolean
    Private _continue As Boolean
    Public WithEvents lcard As clLcardGidro

    'Dim i7053_1 As clContainerMeasurePribor
    Public WithEvents DigIN1 As clDeviceDigInput
    Public WithEvents DigIN2 As clDeviceDigInput

    Public WithEvents max_fp As clModbusPribor

    Public WithEvents Ip As clModbusPribor
    Public WithEvents Up As clModbusPribor
    Public WithEvents Ffp As clModbusPribor
    Public WithEvents Fzp As New clSimplePribor(0, 1)
    Public WithEvents Velocity As New clSimplePribor(0, 1, 0, 1)
    ' Public WithEvents dtt As New clSimplePribor(0, 1, 0, 1)

    Public WithEvents Ampl As clSimplePribor

    Public WithEvents AngleE As clSimplePribor

    Public WithEvents Brast_max As clSimplePribor
    Public WithEvents Bsjat_max As clSimplePribor

    'Private WithEvents Encoder1 As clDevicePribor

    Public WithEvents Tsredi As clSimplePribor
    Public WithEvents Tgidro As clSimplePribor

    'Public Angle As New clEncoder360(1024, 2147483647)

    Public WithEvents reg_Fzp As clDevicePCHV_OVEN

    Public K1 As New CKontaktor
    Public K2 As New CKontaktor
    Public K3 As New CKontaktor
    Public K4 As New CKontaktor
    Public K5 As New CKontaktor
    Public K6 As New CKontaktor
    Public K7 As New CKontaktor
    Public K8 As New CKontaktor
    Public KM1 As New CKontaktor

    Public KoncevikAmplitudeMin As New CKontaktor
    Public KoncevikAngle0 As New CKontaktor
    Public KoncevikAngle90 As New CKontaktor

    Public Event LcardDataEvalute()

    Public Event FinishOpros()

    Public Event ValueChange()

    Public PeriodCross0 As Integer
    Public PeriodLen As Integer
    Public PeriodCount As Integer



    Private pribors As ArrayList

    Private thread As Threading.Thread

    Public parent As clStend

    Private arraySendCommand As New ArrayList


    Public Sub SendComand(ByVal value As s_command)

        SyncLock arraySendCommand
            arraySendCommand.Add(value)
        End SyncLock

    End Sub

    Private _rw As clRWini
    Public Sub New(ByVal _parent As clStend, ByVal rw As clRWini, ByVal _lcard As clLcardGidro)


        lcard = _lcard

        _rw = rw

        parent = _parent

        pribors = New ArrayList

        Tsredi = New clSimplePribor(0, (CSng(rw.T_MAX_OKR_SREDY) - CSng(rw.T_MIN_OKR_SREDY)), CSng(rw.U_MIN_OKR_SREDY), CSng(rw.U_T_OKR_SREDY), , CSng(rw.T_MIN_OKR_SREDY))
        Tgidro = New clSimplePribor(0, (CSng(rw.T_MAX_GIDRO) - CSng(rw.T_MIN_GIDRO)), CSng(rw.U_MIN_GIDRO), CSng(rw.U_T_GIDRO), , CSng(rw.T_MIN_GIDRO))

        AngleE = New clSimplePribor(0, 360 / CSng(rw.PER_RED_ANGLE), CSng(rw.U_MIN_ENCODER), CSng(rw.U_MAX_ENCODER), , CSng(rw.BASE_ANGLE))

        Ampl = New clSimplePribor(0, CSng(rw.LEN_DATCHIK_DISTANCE), 0, CSng(_rw.R_DATCHIK_DISTANCE) * 0.016)

        Brast_max = New clSimplePribor(0, CSng(rw.LIM_POWER) * CSng(rw.U_IN_POWER) / CSng(rw.U_OUT_TENZO), 0, CSng(rw.U_POWER))
        Bsjat_max = New clSimplePribor(0, CSng(rw.LIM_POWER) * CSng(rw.U_IN_POWER) / CSng(rw.U_OUT_TENZO), 0, CSng(rw.U_POWER))

        DigIN1 = New clDeviceDigInput(clDevice.eDeviceType.i7053, rw.ADRESS(0), 1)
        DigIN2 = New clDeviceDigInput(clDevice.eDeviceType.i7053, 0, 1, , , , , , True)

        reg_Fzp = New clDevicePCHV_OVEN(clDevice.eDeviceType.FR252, Me, CInt(rw.ADRESS(1)))

        Up = New clModbusPribor(clDevice.eDeviceType.ModBusPribor, rw.ADRESS(2), rw.CHANEL(2), 1, rw.KOEF(2))
        Ffp = New clModbusPribor(clDevice.eDeviceType.ModBusPribor, rw.ADRESS(3), rw.CHANEL(3), 1, rw.KOEF(3))
        Ip = New clModbusPribor(clDevice.eDeviceType.ModBusPribor, rw.ADRESS(4), rw.CHANEL(4), 1, rw.KOEF(4))

        'max_fp = New clModbusPribor(clDevice.eDeviceType.ModBusPribor, 1, 3029, 2, 0.001)
        max_fp = New clModbusPribor(clDevice.eDeviceType.ModBusPribor, rw.ADRESS(5), rw.CHANEL(5), 2, rw.KOEF(5))
        max_fp.SetValue(65)


        'Encoder1 = New clDevicePribor(clDevice.eDeviceType.i7083, rw.ADRESS(6), rw.CHANEL(6), rw.KOEF(6))

        pribors.Add(DigIN1)
        pribors.Add(max_fp)
        pribors.Add(Up)
        pribors.Add(Ffp)
        pribors.Add(Ip)
        'pribors.Add(Encoder1)

        _exit = False
        _continue = True

        thread = New Threading.Thread(AddressOf Me.cikl)
        thread.Priority = Threading.ThreadPriority.Highest
        thread.Name = "opros"
        thread.Start()

    End Sub

    Public ReadOnly Property IsExit() As Boolean
        Get
            Return Not _exit
        End Get
    End Property

    Public Sub Ended()

        RemoveHandler lcard.ADC_Complete, AddressOf lcard_ADC_Complete

        _continue = False
    End Sub


    Public Sub cikl()

        'Dim rec As String = ""
        Dim pause As Integer = 50
        Dim begin As Integer
        Dim ending As Integer
        Dim cnt As Integer = 0
        ' Dim local_begin As Integer

        Dim period_T_Air As Date = Now

        If parent.comport IsNot Nothing Then
            If parent.comport.Port IsNot Nothing Then
                If parent.comport.Port.IsOpen = True Then

                    While (True)

                        If _continue = False Then
                            Exit While
                        End If
                        Debug.WriteLine("cikl")

                        begin = Environment.TickCount

                        pause = 10
                        cnt = 0

                        For Each pribor As clDevice In pribors
                            With pribor

                                If .Adress <> -1 Then

                                    If parent.comport.Port.BaudRate <> .command.BaudRate Then
                                        If parent.comport.Port.IsOpen = True Then
                                            parent.comport.Port.Close()
                                        End If

                                        parent.comport.Port.BaudRate = .command.BaudRate

                                        parent.comport.Port.Open()
                                    End If

                                    parent.comport.Port.DataBits = .command.DataLen
                                    parent.comport.Port.Parity = .command.Parity
                                    parent.comport.Port.StopBits = .command.StopBits


                                    Select Case .DeviceType
                                        Case clDevice.eDeviceType.I7080, clDevice.eDeviceType.i7017, clDevice.eDeviceType.i7053

                                            With .GetCmd
                                                'Threading.Thread.Sleep(100)
                                                If parent.comport.SendRec(pribor.command.rec, .send, .timeout, .checksum, .count, .SendVbCr, .removeCS, .PreviousDelay, .ParamArray) Then
                                                    pribor.SetValue()
                                                End If

                                            End With
                                        Case clDevice.eDeviceType.i7083
                                            With .GetCmd
                                                'Threading.Thread.Sleep(100)
                                                If parent.comport.SendRec(pribor.command.rec, .send, .timeout, .checksum, .count, .SendVbCr, .removeCS, .PreviousDelay, .ParamArray) Then
                                                    pribor.SetValue()
                                                End If

                                            End With
                                        Case clDevice.eDeviceType.ModBusPribor

                                            If KM1.Sostoyanie = True Then

                                                With .GetCmd
                                                    '        'Threading.Thread.Sleep(100)
                                                    If parent.comport.SendRec_ModbusRtu(pribor.command.brec, .bsend, .timeout, .count, .PreviousDelay) Then

                                                        If _continue = True Then
                                                            pribor.SetValue()
                                                        End If

                                                    End If

                                                End With
                                            End If


                                    End Select

                                End If


                                'Debug.Write(cnt.ToString & " - " & (Environment.TickCount - local_begin).ToString & " ")

                                cnt += 1

                                Dim cmds() As s_command

                                SyncLock arraySendCommand

                                    If arraySendCommand.Count > 0 Then

                                        ReDim cmds(arraySendCommand.Count - 1)
                                        arraySendCommand.CopyTo(cmds)

                                        arraySendCommand.Clear()
                                        pause = 10

                                    End If


                                End SyncLock


                                If cmds IsNot Nothing Then
                                    If cmds.Length > 0 Then
                                        For i As Integer = 0 To cmds.GetUpperBound(0)

                                            With CType(cmds(i), s_command)

                                                If parent.comport.Port.BaudRate <> .BaudRate Then
                                                    If parent.comport.Port.IsOpen = True Then
                                                        parent.comport.Port.Close()
                                                    End If

                                                    parent.comport.Port.BaudRate = .BaudRate

                                                    parent.comport.Port.Open()
                                                End If


                                                parent.comport.Port.DataBits = .DataLen
                                                parent.comport.Port.Parity = .Parity
                                                parent.comport.Port.StopBits = .StopBits

                                                Dim rec As String = ""
                                                Select Case .protokol_type
                                                    Case eProtokolType.DCON
                                                        If parent.comport.SendRec(rec, .send, .timeout, .checksum, .count, .SendVbCr, .removeCS, .PreviousDelay, .ParamArray) Then
                                                            Dim bb As Boolean = False
                                                            'здесь обработка специфичных команд!!!!!
                                                        End If
                                                    Case eProtokolType.ModbusRtu
                                                        If parent.comport.SendRec_ModbusRtu(.brec, .bsend, .timeout, .count, .PreviousDelay) Then
                                                            Dim bb As Boolean = False
                                                            'здесь обработка специфичных команд!!!!!
                                                        End If
                                                End Select


                                            End With

                                        Next
                                    End If

                                    cmds = Nothing
                                End If



                            End With

                        Next

                        If lcard.IsExistLCard Then
                            Dim val As UInt16
                            val = 254
                            lcard.GetIN(val)
                            'Debug.Print("lcard in - " & val)
                            DigIN2.SetValue(val, False)
                        End If

                        ending = Environment.TickCount

                        'Debug.WriteLine("tick - " & (ending - begin).ToString)

                        'parent.Rotation.DataRefreshEvents.Set()

                        'mSleep(pause)



                        'If log.EnableLog Then
                        '    log.Write(Ip.GetValue(0).ToString & vbTab & _
                        '    Up.GetValue(0).ToString & vbTab & _
                        '    Ffp.GetValue(0).ToString & vbTab & _
                        '    Fzp.GetValue(0).ToString & vbTab & _
                        '    Ampl.GetValue(0).ToString & vbTab & _
                        '    AngleE.GetValue(0).ToString & vbTab & _
                        '    Tsredi.GetValue(0).ToString & vbTab & _
                        '    Tgidro.GetValue(0).ToString)

                        'End If



                    End While


                    '


                End If
            End If
        End If


        _exit = True
        RaiseEvent FinishOpros()

    End Sub


    Private Function itoa(ByVal val As Integer) As String
        If val < 16 Then Return "0" & val.ToString("X")
        Return val.ToString("X")
    End Function

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub



    Private Sub ValuesChanges() Handles Ip.ValueChange, Up.ValueChange, Ffp.ValueChange, _
                                        Fzp.ValueChange, Tgidro.ValueChange, Tsredi.ValueChange, _
                                        Ampl.ValueChange, DigIN1.ValueChange, _
                                        max_fp.ValueChange, DigIN2.ValueChange ', Encoder1.ValueChange

        With Me.DigIN1.mValue
            K1.SetSostoyanie = .GetBit(0)
            K2.SetSostoyanie = .GetBit(1)
            K3.SetSostoyanie = .GetBit(2)
            K4.SetSostoyanie = .GetBit(3)
            K5.SetSostoyanie = .GetBit(4)
            K6.SetSostoyanie = .GetBit(5)
            K7.SetSostoyanie = .GetBit(6)
            K8.SetSostoyanie = .GetBit(7)
        End With


        With DigIN2.mValue
            KM1.SetSostoyanie = Not .GetBit(4)
            KoncevikAmplitudeMin.SetSostoyanie = .GetBit(1)
            KoncevikAngle0.SetSostoyanie = .GetBit(3)
            KoncevikAngle90.SetSostoyanie = .GetBit(2)
        End With

        'Angle.SetValue(Encoder1.GetValue(0))

        RaiseEvent ValueChange()
    End Sub

    Private Sub lcard_ADC_Complete(ByRef Ch0() As Short, ByRef Ch1() As Short, ByRef Ch2() As Short, ByRef Ch3() As Short, ByRef Ch4() As Short, ByRef Ch5() As Short, ByRef Ch6() As Short, ByRef Ch7() As Short) Handles lcard.ADC_Complete

        'Dim v_ch0(Ch3.GetUpperBound(0)) As Single
        ' Dim v_ch1(Ch3.GetUpperBound(0)) As Single
        Dim v_ch2(Ch3.GetUpperBound(0)) As Double
        Dim v_ch3(Ch3.GetUpperBound(0)) As Double
        ' Dim v_ch4(Ch3.GetUpperBound(0)) As Single


        If KM1.Sostoyanie Then

            'расчет амплитуды

            

            Dim i As Integer = 0

            For i = 0 To Ch3.GetUpperBound(0)
                v_ch3(i) = Ch3(i)
            Next

            'линейный фильтр
            'For i = 2 To Ch3.GetUpperBound(0) - 2
            '    ' v_ch0(i) = (0.25 * Ch0(i - 2) + 0.5 * Ch0(i - 1) + Ch0(i) + 0.5 * Ch0(i + 1) + 0.25 * Ch0(i + 2)) / 2.5
            '    ' v_ch1(i) = (0.25 * Ch1(i - 2) + 0.5 * Ch1(i - 1) + Ch1(i) + 0.5 * Ch1(i + 1) + 0.25 * Ch1(i + 2)) / 2.5
            '    v_ch2(i) = (0.25 * Ch2(i - 2) + 0.5 * Ch2(i - 1) + Ch2(i) + 0.5 * Ch2(i + 1) + 0.25 * Ch2(i + 2)) / 2.5
            '    v_ch3(i) = (0.25 * Ch3(i - 2) + 0.5 * Ch3(i - 1) + Ch3(i) + 0.5 * Ch3(i + 1) + 0.25 * Ch3(i + 2)) / 2.5
            '    ' v_ch4(i) = (0.25 * Ch4(i - 2) + 0.5 * Ch4(i - 1) + Ch4(i) + 0.5 * Ch0(i + 1) + 0.25 * Ch4(i + 2)) / 2.5
            'Next


            Dim f_ch3 As New bpf(v_ch3, Ch3.Length)
            f_ch3.calculate()
            Dim e_val_ch3(Ch3.GetUpperBound(0)) As Double
            f_ch3.filtring(32, Ch3.Length - 32)
            f_ch3.calculate()

            Dim j As Integer = 0

            For Each vl As Double In f_ch3.GetBack
                e_val_ch3(j) = vl
                'If j > 256 And j < (lHALF_DISCRETS - 256) Then
                'If min > vl Then min = vl
                '  If max < vl Then max = vl
                ' End If
                j += 1
            Next


            For i = 0 To Ch2.GetUpperBound(0)
                v_ch2(i) = Ch2(i)
            Next


            Dim f_ch2 As New bpf(v_ch2, Ch2.Length)
            f_ch2.calculate()


            Dim e_val_ch2(Ch2.GetUpperBound(0)) As Double


            f_ch2.filtring(32, Ch2.Length - 32)
            f_ch2.calculate()


            ' min = lHALF_DISCRETS
            ' max = -lHALF_DISCRETS

            j = 0
            For Each vl As Double In f_ch2.GetBack
                e_val_ch2(j) = vl
                ' If j > 256 And j < (lHALF_DISCRETS - 256) Then
                'If min > vl Then min = vl
                '   If max < vl Then max = vl
                '  End If
                j += 1
            Next
            '


            ' Dim min, max As Double
            ' min = lHALF_DISCRETS
            'max = 0
            j = 0

            Dim Avrg As Single = 0

            For i = 200 To e_val_ch3.GetUpperBound(0) - 200
                Avrg = Avrg + e_val_ch3(i)
            Next
            Avrg = Avrg / (Ch3.GetUpperBound(0) - 400)

            Dim cross0(2047) As Single

            j = 0
            Dim dx As Single = 0
            Dim count_cross As Integer = 0

            i = 200

            While (i < (Ch3.GetUpperBound(0) - 205))
                Dim y1, y2 As Single
                y1 = (e_val_ch3(i) + e_val_ch3(i + 1) + e_val_ch3(i + 2)) / 3
                y2 = (e_val_ch3(i + 3) + e_val_ch3(i + 4) + e_val_ch3(i + 5)) / 3

                dx = 5 * (Avrg - y1) / (y2 - y1)
                If dx >= 1 And dx < 4 Then
                    cross0(count_cross) = dx + i
                    count_cross = count_cross + 1
                    i = i + 4
                End If
                i = i + 1
            End While



            Dim dt As Single = 0
            If count_cross > 1 Then
                dt = (cross0(count_cross - 1) - cross0(0)) / (count_cross - 1)

            End If
            ' dtt.SetValue(dt, False)

            Dim maxA As Single = 0
            Dim minA As Single = 0
            Dim maxB As Single = 0
            Dim minB As Single = 0
            Dim count_per As Integer = Math.Truncate((count_cross - 1) / 2)

            PeriodCount = count_per
            PeriodLen = dt * 2
            PeriodCross0 = cross0(0)

            For i = 0 To count_per - 1
                Dim Amin As Single = 16384
                Dim Amax As Single = -16384
                Dim Bmin As Single = 0
                Dim Bmax As Single = 0

                For j = Math.Round(cross0(2 * i)) To Math.Round(cross0(2 * i + 2) - 1)
                    Amin = Math.Min(Amin, e_val_ch3(j))
                    Amax = Math.Max(Amax, e_val_ch3(j))
                    Bmin = Math.Min(Bmin, e_val_ch2(j))
                    Bmax = Math.Max(Bmax, e_val_ch2(j))

                Next
                maxA = maxA + Amax
                minA = minA + Amin
                minB = minB + Bmin
                maxB = maxB + Bmax

            Next

            If count_per > 0 Then
                minA = minA / count_per
                maxA = maxA / count_per
                minB = minB / count_per
                maxB = maxB / count_per

            End If





            Dim sampl As Single = (maxA - minA) * 5 / lHALF_DISCRETS


            Ampl.SetValue(sampl, False)


            If dt > 0 And Ampl.GetValue(1) > 15 Then
                Velocity.SetValue(Ampl.GetValue(1) * Math.PI * lcard.GetCurrentRate() / (16 * dt), True)
            Else
                Velocity.SetValue(0, True)
            End If






            '  Debug.Print("min={0} max={1} ampl={2} - {3}mm", min, max, (max - min).ToString("f0"), (CDec(_rw.LEN_DATCHIK_DISTANCE) * (max - min) / (lHALF_DISCRETS * 0.8)).ToString("f0"))

            'расчет сил сопротивления


            'Dim v_ch2(Ch2.GetUpperBound(0)) As Double





            Dim sampl_bmin As Single = minB * 5 / lHALF_DISCRETS
            Dim sampl_bmax As Single = maxB * 5 / lHALF_DISCRETS
            Dim cor As Single

            cor = _rw.COR_A_TENZO * Math.Cos(AngleE.GetValue(1, False) * Math.PI / 180) - _rw.COR_B_TENZO
            If cor > 0 Then
                sampl_bmin = sampl_bmin + cor
            Else
                sampl_bmax = sampl_bmax + cor
            End If


            If sampl_bmin < 0 Then
                sampl_bmin = -sampl_bmin
            Else
                sampl_bmin = 0
            End If

            If sampl_bmax < 0 Then
                sampl_bmax = 0
            End If




            Brast_max.SetValue(sampl_bmin)
            Bsjat_max.SetValue(sampl_bmax)

        Else
            Ampl.SetValue(CSng(0), False)
            Brast_max.SetValue(CSng(0), False)
            Bsjat_max.SetValue(CSng(0), False)
            Velocity.SetValue(0, False)
        End If


        Dim tg As Single = 0
        Dim tr As Single = 0
        Dim ang As Single = 0


        For i = 0 To Ch0.GetUpperBound(0)
            tg = tg + Ch0(i)
            tr = tr + Ch1(i)
            ang = ang + Ch4(i)
        Next

        tg = 5 * tg / (2048 * lHALF_DISCRETS)
        tr = 5 * tr / (2048 * lHALF_DISCRETS)
        ang = 5 * ang / (2048 * lHALF_DISCRETS)


        ' sval1 = (t1 / Ch0.Length) * CDec(_rw.U_T_GIDRO) / (lHALF_DISCRETS * CDec(_rw.U_T_GIDRO) / 5)



        ' sval2 = (t2 / Ch1.Length) * CDec(_rw.U_T_OKR_SREDY) / (lHALF_DISCRETS * CDec(_rw.U_T_OKR_SREDY) / 5)

        Tgidro.SetValue(tg, False)
        Tsredi.SetValue(tr, False)


        ' sangle = CDec(_rw.NUM_R_ENCODER) * 0.02 * sangle / lHALF_DISCRETS

        AngleE.SetValue(ang, True)

        Debug.Print("angle=" & AngleE.GetValue(1, False))

        RaiseEvent LcardDataEvalute()

    End Sub
End Class

Public Class CBitField16
    Private uintBitField As UInt16
    Public ReadOnly Property GetBit(ByVal Number As Integer) As Boolean
        Get
            If ((1 << Number) And uintBitField) > 0 Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property

    Public WriteOnly Property SetBit(ByVal Number As Integer) As Integer
        Set(ByVal value As Integer)
            If value = 0 Then
                uintBitField = Not ((Not uintBitField) Or (1 << Number))
            Else
                uintBitField = (1 << Number) Or uintBitField
            End If
        End Set
    End Property

    Public Property Value() As Int32
        Get
            Return uintBitField
        End Get
        Set(ByVal Value As Int32)
            If &HFFFF >= (Value And &HFFFF) Then
                uintBitField = (Value And &HFFFF)
            End If
        End Set
    End Property

    Public Property Value_Hex() As String
        Get
            Dim ord As String = Hex$(uintBitField)

            If ord.Length < 4 Then
                ord = New String("0", 4 - ord.Length) & ord
            End If

            Return ord
        End Get
        Set(ByVal Value As String)
            Try
                uintBitField = Convert.ToUInt16(Value, 16)
            Catch ex As System.FormatException
                Debug.Assert(False, "Не верная строка", "Не верная строка для преобразования в целое шестнадцатеричное число в функции Value_Hex")
            Catch ex As Exception
                Debug.Assert(False, "Не известная ошибка при преобразовании в целое шестнадцатеричное число в функции Value_Hex")
            End Try
        End Set
    End Property
End Class

Public Class CBitField32
    Private uintBitField As Int32
    Public ReadOnly Property GetBit(ByVal Number As Integer) As Boolean
        Get
            If ((1 << Number) And uintBitField) > 0 Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property

    Public WriteOnly Property SetBit(ByVal Number As Integer) As Integer
        Set(ByVal value As Integer)
            If value = 0 Then
                uintBitField = Not ((Not uintBitField) Or (1 << Number))
            Else
                uintBitField = (1 << Number) Or uintBitField
            End If
        End Set
    End Property

    Public Property Value() As Int32
        Get
            Return uintBitField
        End Get
        Set(ByVal Value As Int32)
            If &H100000000 > Value Then
                uintBitField = Value
            End If
        End Set
    End Property

    Public Property Value_Hex() As String
        Get
            Dim ord As String = Hex$(uintBitField)

            If ord.Length < 8 Then
                ord = New String("0", 8 - ord.Length) & ord
            End If

            Return ord
        End Get
        Set(ByVal Value As String)
            Try
                uintBitField = Convert.ToInt32(Value, 16)
            Catch ex As System.FormatException
                Beep()

                'Debug.Assert(False, "Не верная строка", "Не верная строка для преобразования в целое шестнадцатеричное число в функции Value_Hex")
            Catch ex As Exception
                'Debug.Assert(False, "Не известная ошибка при преобразовании в целое шестнадцатеричное число в функции Value_Hex")
                Beep()
            End Try
        End Set
    End Property
End Class

Public Class CKontaktor
    Private mSostoyanie As Boolean

    Public ReadOnly Property Sostoyanie() As Boolean
        Get
            Return mSostoyanie
        End Get
    End Property

    Friend WriteOnly Property SetSostoyanie() As Boolean
        Set(ByVal Value As Boolean)
            mSostoyanie = Value
        End Set
    End Property
End Class

<CLSCompliant(True)> _
Public MustInherit Class clDevice ' Проверка


    Public Chanel As Integer
    Public Adress As Integer
    Public Koef As Single


    Public command As s_command

    ''' <summary>
    ''' Происходит после изменения значения в устройстве
    ''' </summary>
    ''' <remarks></remarks>
    Public Event ValueChange(ByVal value As String)

    Public Enum eDeviceType
        Щ02
        ТРМ200
        i7017
        i7053
        FR252
        I7080
        DMK32
        PROKRUTKA
        ПЧВ_ОВЕН
        ModBusPribor
        i7083
    End Enum

    Private _devicetype As eDeviceType = eDeviceType.i7017
    Public ReadOnly Property DeviceType() As eDeviceType
        Get
            Return _devicetype
        End Get
    End Property


    Public Sub New(ByVal _type As eDeviceType, ByVal _Adress As Integer, ByVal _Chanel As Integer, Optional ByVal _Koef As Single = 1, _
                                                    Optional ByVal _baudrate As Integer = 9600, _
                                                    Optional ByVal _datalen As Integer = 8, _
                                                    Optional ByVal _stopbits As IO.Ports.StopBits = IO.Ports.StopBits.One, _
                                                    Optional ByVal _paryti As IO.Ports.Parity = IO.Ports.Parity.None)
        _devicetype = _type
        Chanel = _Chanel
        Adress = _Adress
        Koef = _Koef
        command.BaudRate = _baudrate
        command.StopBits = _stopbits
        command.Parity = _paryti
        command.DataLen = _datalen

    End Sub

    Public Overridable Overloads Function GetValue(ByVal round As Integer, Optional ByVal absolut As Boolean = True, Optional ByVal WithKoef As Boolean = True) As Double

    End Function

    Public Overridable Overloads Function GetValue() As Object

    End Function



    Public Overridable ReadOnly Property Acseleration(Optional ByVal WithKoef As Boolean = True) As Single
        Get

        End Get
    End Property


    Public Overridable Sub SetValue()
        RaiseEvent ValueChange("U" & Adress.ToString("X") & Chanel.ToString("X") & Me.GetValue.ToString())
    End Sub

    Public Overridable Sub SetValue(ByVal value As Object, Optional ByVal alway As Boolean = False)

    End Sub

    Public Overridable Function GetResetCmd() As String
        Return ""
    End Function


    Public MustOverride Function GetCmd() As s_command

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class

Public Class clDevicePribor
    Inherits clDevice

    Friend mValue As Double
    Friend mAcseleration As Single
    Friend mPrevTime As DateTime

    Public Sub New(ByVal _type As eDeviceType, ByVal _Adress As Integer, ByVal _Chanel As Integer, Optional ByVal _Koef As Single = 1, _
                                                Optional ByVal _baudrate As Integer = 9600, _
                                                Optional ByVal _datalen As Integer = 8, _
                                                Optional ByVal _stopbits As IO.Ports.StopBits = IO.Ports.StopBits.One, _
                                                Optional ByVal _paryti As IO.Ports.Parity = IO.Ports.Parity.None)
        MyBase.New(_type, _Adress, _Chanel, _Koef, _baudrate, _datalen, _stopbits, _paryti)
    End Sub



    Public Overrides Function GetResetCmd() As String
        Select Case DeviceType
            Case eDeviceType.i7083
                Return "$" & Adress.ToString("X2") & "6" & Chanel.ToString
        End Select
        Return MyBase.GetResetCmd
    End Function

    Public Overloads Overrides Sub SetValue()

        Dim val As Double

        Select Case DeviceType
            Case eDeviceType.I7080
                Dim ival As Integer = Convert.ToInt32(command.rec.Substring(1), 16)
                val = ival
            Case eDeviceType.i7083
                Dim ival As UInt32 = Convert.ToUInt32(command.rec.Substring(1), 16)
                val = ival
            Case Else
                val = Math.Abs(Convert.ToDouble(command.rec.Substring(1)))
        End Select


        If val <> mValue Then
            Dim ordCurTime As DateTime = Now
            If mPrevTime.Ticks > 0 Then
                mAcseleration = CSng(val - mValue) / ((ordCurTime - mPrevTime).TotalSeconds)
            End If
            mPrevTime = ordCurTime
            mValue = val
            MyBase.SetValue()
        Else

            mAcseleration = 0
        End If

    End Sub

    Public Overloads Sub SetValue(ByVal val As Single)

        If val <> mValue Then
            Dim ordCurTime As DateTime = Now
            If mPrevTime.Ticks > 0 Then
                mAcseleration = CSng(val - mValue) / ((ordCurTime - mPrevTime).TotalSeconds)
            End If
            mPrevTime = ordCurTime
            mValue = val
            MyBase.SetValue()
        Else

            mAcseleration = 0
        End If

    End Sub

    Public Overrides ReadOnly Property Acseleration(Optional ByVal WithKoef As Boolean = True) As Single
        Get
            If WithKoef = True Then mAcseleration = mAcseleration * Koef

            Return mAcseleration
        End Get
    End Property

    Public Overrides Function GetValue() As Object
        'Return MyBase.GetValue()
        SyncLock Me
            Return CSng(mValue)
        End SyncLock

    End Function
    Public Overrides Function GetValue(ByVal round As Integer, Optional ByVal absolut As Boolean = True, Optional ByVal WithKoef As Boolean = True) As Double
        Dim rez As Double

        SyncLock Me
            rez = mValue
        End SyncLock


        If WithKoef = True Then rez = rez * Koef
        If absolut = True Then rez = Math.Abs(rez)

        Return Math.Round(rez, round)
    End Function

    Public Overrides Function GetCmd() As s_command
        With command
            .rec = ""
            .send = "#" & Me.Adress.ToString("X2") & Me.Chanel.ToString
            .timeout = 300
            .checksum = True
            .count = 3
            .removeCS = True
            .PreviousDelay = 1
            .SendVbCr = True
            .ParamArray = New String() {">"}
            .protokol_type = eProtokolType.DCON
        End With

        Return command
    End Function

End Class

Public Class clDeviceDigInput
    Inherits clDevice

    Private Invert As Boolean = False

    Public mValue As New CBitField16

    Public Sub New(ByVal _type As eDeviceType, ByVal _Adress As Integer, ByVal _Chanel As Integer, Optional ByVal _Koef As Single = 1, _
                                                Optional ByVal _baudrate As Integer = 9600, _
                                                Optional ByVal _datalen As Integer = 8, _
                                                Optional ByVal _stopbits As IO.Ports.StopBits = IO.Ports.StopBits.One, _
                                                Optional ByVal _paryti As IO.Ports.Parity = IO.Ports.Parity.None, Optional ByVal _Invert As Boolean = False)

        MyBase.New(_type, _Adress, _Chanel, _Koef, _baudrate, _datalen, _stopbits, _paryti)

        Invert = _Invert

    End Sub

    Public Overrides Function GetCmd() As s_command

        With command
            .rec = ""
            .send = "@" & Me.Adress.ToString("X2")
            .timeout = 300
            .checksum = True
            .count = 3
            .removeCS = True
            .PreviousDelay = 1
            .SendVbCr = True
            .ParamArray = New String() {">"}
            .protokol_type = eProtokolType.DCON

        End With

        Return command
    End Function

    Public Overrides Sub SetValue()
        Dim val As UInt16 = Convert.ToUInt16(command.rec.Substring(1), 16)

        If Invert = True Then
            val = val Xor &HFFFF
        End If

        If val <> CType(mValue.Value, UInt16) Then
            mValue.Value = val
            MyBase.SetValue()
        End If
    End Sub

    Public Overrides Sub SetValue(ByVal value As Object, Optional ByVal alway As Boolean = False)

        Dim val As UInt16 = value

        If Invert = True Then
            val = val Xor &HFFFF
        End If

        If val <> CType(mValue.Value, UInt16) Then
            mValue.Value = val
            MyBase.SetValue()
        End If
    End Sub

    Public Overrides Function GetValue() As Object
        Return CType(mValue.Value, UInt16)
    End Function

End Class

Public Class clDevicePCHV_OVEN
    Inherits clDevice

    Dim mValue As Integer
    Dim mAcseleration As Single
    Dim mPrevTime As DateTime


    Dim MaxLim As Integer = 767

    Private parent As clOpros



    Public Sub New(ByVal _type As eDeviceType, ByVal _parent As clOpros, ByVal _Adress As Integer, Optional ByVal _MaxLim As Integer = 16383, _
                                                Optional ByVal _baudrate As Integer = 9600, _
                                                Optional ByVal _datalen As Integer = 8, _
                                                Optional ByVal _stopbits As IO.Ports.StopBits = IO.Ports.StopBits.One, _
                                                Optional ByVal _paryti As IO.Ports.Parity = IO.Ports.Parity.None)



        MyBase.New(_type, _Adress, 0, 1, _baudrate, _datalen, _stopbits, _paryti)

        MaxLim = _MaxLim
        parent = _parent

    End Sub

    Public Overrides Function GetValue() As Object
        Return mValue
    End Function


    Public Overrides ReadOnly Property Acseleration(Optional ByVal WithKoef As Boolean = True) As Single
        Get
            Return mAcseleration
        End Get
    End Property

    Public Sub Reset()

        With command
            .removeCS = True
            .timeout = 300
            .checksum = True
            .count = 3
            .PreviousDelay = 10
            .bsend = New Byte() {Adress, 6, &HC3, &H59, 0, 0}
            .protokol_type = eProtokolType.ModbusRtu
        End With


        parent.SendComand(command)

        mValue = 0

        [Stop]()

        MyBase.SetValue()


    End Sub

    Private Sub send_cmd(ByVal value As Object)
        
        Dim ival As Int16 = value

        With command
            .removeCS = True
            .timeout = 100
            .checksum = True
            .count = 3
            .PreviousDelay = 10
            .bsend = New Byte() {Adress, 6, &HC3, &H59, CByte(ival >> 8), CByte(&HFF And ival)}
            .protokol_type = eProtokolType.ModbusRtu
        End With

        parent.SendComand(command)

        'If ival = 0 Then
        '    [Stop]()
        'End If

        Dim ordCurTime As DateTime = Now
        If mPrevTime.Ticks > 0 Then
            mAcseleration = CSng(value - mValue) / ((ordCurTime - mPrevTime).TotalSeconds)
        End If
        mPrevTime = ordCurTime
        mValue = value

        MyBase.SetValue()

    End Sub

    Public Overrides Sub SetValue(ByVal value As Object, Optional ByVal alway As Boolean = False)

        If value > MaxLim Then value = MaxLim
        If value < 0 Then value = 0


        If alway = True Then
            send_cmd(value)
        Else
            If value <> mValue Then
                send_cmd(value)
            End If
        End If

    End Sub


    Public Overrides Sub SetValue()
        'сделать в фазике обратную связь - какой текущий угол в фазике и здесь ее реализовать
        'MyBase.SetValue()
    End Sub

    Public Sub IncrementValue(ByVal value As Integer, Optional ByVal fine As Boolean = True)
        If fine = True And value > 0 Then

            For i As Integer = mValue + 1 To mValue + value
                Me.SetValue(i, False)
            Next

        Else
            value += mValue
            Me.SetValue(value, False)
        End If


    End Sub

    Public Overrides Function GetCmd() As s_command
        


        With command
            .removeCS = True
            .timeout = 300
            .checksum = True
            .count = 3
            .PreviousDelay = 10
            .bsend = New Byte() {Adress, 6, &HC3, &H59, 0, 0}
            .protokol_type = eProtokolType.ModbusRtu
        End With



        Return command
    End Function

    Public Sub Start(Optional ByVal previusdeley As Integer = 10, Optional ByVal max_fp As Integer = 65)

        With command
            .removeCS = True
            .timeout = 300
            .checksum = True
            .count = 3
            .PreviousDelay = previusdeley
            .bsend = New Byte() {Adress, 6, &H4, &HCD, CByte(50 >> 8), CByte(&HFF And 50)}
            .protokol_type = eProtokolType.ModbusRtu
        End With

        parent.SendComand(command)

        max_fp *= 1000

        With command
            .removeCS = True
            .timeout = 300
            .checksum = True
            .count = 3
            .PreviousDelay = previusdeley
            .bsend = New Byte() {Adress, &H10, &HB, &HD5, &H0, &H2, &H4, CByte(max_fp >> 24), CByte(max_fp >> 16), CByte(max_fp >> 8), CByte(&HFF And max_fp)}
            .protokol_type = eProtokolType.ModbusRtu
        End With

        parent.SendComand(command)


        With command
            .removeCS = True
            .timeout = 300
            .checksum = True
            .count = 3
            .PreviousDelay = previusdeley
            .bsend = New Byte() {Adress, 6, &HC3, &H4F, &H4, &H7C}
            .protokol_type = eProtokolType.ModbusRtu
        End With

        parent.SendComand(command)
    End Sub

    Public Sub [Stop]()
        With command
            .removeCS = True
            .timeout = 300
            .checksum = True
            .count = 3
            .PreviousDelay = 10
            .bsend = New Byte() {Adress, 6, &HC3, &H4F, &H4, &H34}
            .protokol_type = eProtokolType.ModbusRtu
        End With

        parent.SendComand(command)
    End Sub

End Class

Public Class clModbusPribor
    Inherits clDevice

    Friend mValue As Double
    Friend mAcseleration As Single
    Friend mPrevTime As DateTime
    Private len As Integer
    Public Sub New(ByVal _type As eDeviceType, ByVal _Adress As Integer, ByVal _Registr As Integer, ByVal lenght As Integer, Optional ByVal _Koef As Single = 1, _
                                                Optional ByVal _baudrate As Integer = 9600, _
                                                Optional ByVal _datalen As Integer = 8, _
                                                Optional ByVal _stopbits As IO.Ports.StopBits = IO.Ports.StopBits.One, _
                                                Optional ByVal _paryti As IO.Ports.Parity = IO.Ports.Parity.None)
        MyBase.New(_type, _Adress, _Registr, _Koef, _baudrate, _datalen, _stopbits, _paryti)
        len = lenght
    End Sub



    Public Overloads Overrides Sub SetValue()

        Try
            Dim val As Double



            Dim lval As Long = 0

            Dim sdvig As Integer = 0
            For i As Integer = 3 + command.brec(2) - 1 To 3 Step -1
                lval += (CLng(command.brec(i)) << sdvig)
                sdvig += 8
            Next

            val = lval

            If val <> mValue Then
                Dim ordCurTime As DateTime = Now
                If mPrevTime.Ticks > 0 Then
                    mAcseleration = CSng(val - mValue) / ((ordCurTime - mPrevTime).TotalSeconds)
                End If
                mPrevTime = ordCurTime
                mValue = val
                MyBase.SetValue()
            Else

                mAcseleration = 0
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Public Overloads Sub SetValue(ByVal val As Single)

        If val <> mValue Then
            Dim ordCurTime As DateTime = Now
            If mPrevTime.Ticks > 0 Then
                mAcseleration = CSng(val - mValue) / ((ordCurTime - mPrevTime).TotalSeconds)
            End If
            mPrevTime = ordCurTime
            mValue = val
            MyBase.SetValue()
        Else

            mAcseleration = 0
        End If

    End Sub

    Public Overrides ReadOnly Property Acseleration(Optional ByVal WithKoef As Boolean = True) As Single
        Get
            If WithKoef = True Then mAcseleration = mAcseleration * Koef

            Return mAcseleration
        End Get
    End Property

    Public Overrides Function GetValue() As Object
        'Return MyBase.GetValue()
        SyncLock Me
            Return CSng(mValue)
        End SyncLock

    End Function
    Public Overrides Function GetValue(ByVal round As Integer, Optional ByVal absolut As Boolean = True, Optional ByVal WithKoef As Boolean = True) As Double
        Dim rez As Double

        SyncLock Me
            rez = mValue
        End SyncLock


        If WithKoef = True Then rez = rez * Koef
        If absolut = True Then rez = Math.Abs(rez)

        Return Math.Round(rez, round)
    End Function

    Public Overrides Function GetCmd() As s_command

        With command
            .removeCS = True
            .timeout = 100
            .checksum = True
            .count = 3
            .PreviousDelay = 10
            .bsend = New Byte() {Adress, 3, CByte(Chanel >> 8), CByte(Chanel And &HFF), 0, len}
            .protokol_type = eProtokolType.ModbusRtu
        End With


        Return command
    End Function

End Class

Public Class clDeviceLowato
    Inherits clDevice



    Friend mValue As Double
    Friend mAcseleration As Single
    Friend mPrevTime As DateTime

    'Dim StartAdress() As Integer = {&H1, &H9, &H11, &H29, &H2F, &H35, &H41}
    Dim StartAdress() As Integer = {&H1, &H9, &H11} ', &H29, &H2F, &H35, &H41}

    Private Const ValuesCount As Integer = 3

    Public commands() As s_command

    Dim mValues() As Double

    Public Sub New(ByVal _type As eDeviceType, ByVal _Adress As Integer, ByVal _Chanel As Integer, Optional ByVal _Koef As Single = 1, _
                                                Optional ByVal _baudrate As Integer = 9600, _
                                                Optional ByVal _datalen As Integer = 8, _
                                                Optional ByVal _stopbits As IO.Ports.StopBits = IO.Ports.StopBits.One, _
                                                Optional ByVal _paryti As IO.Ports.Parity = IO.Ports.Parity.None)
        MyBase.New(_type, _Adress, _Chanel, _Koef, _baudrate, _datalen, _stopbits, _paryti)

        ReDim commands(StartAdress.GetUpperBound(0))
        ReDim mValues(StartAdress.Length * ValuesCount)
    End Sub



    Public Overrides Sub SetValue()

        Dim val As Double

        If Me.DeviceType = eDeviceType.I7080 Then
            Dim ival As Integer = Convert.ToInt32(command.rec.Substring(1), 16)
            val = ival
        Else
            val = Math.Abs(Convert.ToDouble(command.rec.Substring(1)))
        End If

        If val <> mValue Then
            Dim ordCurTime As DateTime = Now
            If mPrevTime.Ticks > 0 Then
                mAcseleration = CSng(val - mValue) / ((ordCurTime - mPrevTime).TotalSeconds)
            End If
            mPrevTime = ordCurTime
            mValue = val
            MyBase.SetValue()
        Else

            mAcseleration = 0
        End If

    End Sub


    Private Function mToInt32(ByVal value As Byte(), ByVal start_idx As Integer) As Integer
        Dim bts(3) As Byte

        For i = 3 To 0 Step -1
            bts(i) = value(start_idx)
            start_idx += 1
        Next

        Dim ui As Int32 = BitConverter.ToInt32(bts, 0)



        ui = ui And &H9FFFFFFF

        If (ui And &H80000000) = &H80000000 Then
            ui = ui And &H1FFFFFFF
            Return -ui
        End If

        Return ui

    End Function

    Public Sub SetValues(ByVal idx As Integer)

        ' Dim ival As Integer

        If Me.DeviceType = eDeviceType.DMK32 Then

            mValues(0 + 3 * idx) = mToInt32(commands(idx).brec, 3)
            mValues(1 + 3 * idx) = mToInt32(commands(idx).brec, 7)
            mValues(2 + 3 * idx) = mToInt32(commands(idx).brec, 11)

        End If


        MyBase.SetValue()

    End Sub

    Public Overrides ReadOnly Property Acseleration(Optional ByVal WithKoef As Boolean = True) As Single
        Get
            If WithKoef = True Then mAcseleration = mAcseleration * Koef

            Return mAcseleration
        End Get
    End Property


    Public Function GetValues(ByVal idx As Integer) As Object
        'Return MyBase.GetValue()
        SyncLock Me
            Return CSng(mValues(idx))
        End SyncLock

    End Function

    Public Overrides Function GetValue() As Object
        'Return MyBase.GetValue()
        SyncLock Me
            Return CSng(mValue)
        End SyncLock

    End Function
    Public Overrides Function GetValue(ByVal round As Integer, Optional ByVal absolut As Boolean = True, Optional ByVal WithKoef As Boolean = True) As Double
        Dim rez As Double

        SyncLock Me
            rez = mValue
        End SyncLock


        If WithKoef = True Then rez = rez * Koef
        If absolut = True Then rez = Math.Abs(rez)

        Return Math.Round(rez, round)
    End Function


    Public Overrides Function GetCmd() As s_command
        With command
            .rec = ""
            .send = "#" & Me.Adress.ToString("X2") & Me.Chanel.ToString
            .timeout = 300
            .checksum = True
            .count = 1
            .removeCS = True
            .PreviousDelay = 5
            .SendVbCr = True
            .ParamArray = New String() {">"}
            .protokol_type = eProtokolType.DCON

            Dim al As New ArrayList

            al.Add(CByte(Adress))
            al.Add(CByte(4))
            al.Add(CByte(0))
            al.Add(CByte(1))
            al.Add(CByte(0))
            al.Add(CByte(ValuesCount * 2))


            .bsend = al.ToArray(GetType(Byte))
        End With

        Return command
    End Function


    Public Function GetCmds(ByVal idx As Integer) As s_command
        With commands(idx)
            .rec = ""
            .send = "#" & Me.Adress.ToString("X2") & Me.Chanel.ToString
            .timeout = 300
            .checksum = True
            .count = 3
            .removeCS = True
            .PreviousDelay = 5
            .SendVbCr = True
            .ParamArray = New String() {">"}
            .protokol_type = eProtokolType.DCON

            Dim al As New ArrayList

            al.Add(CByte(Adress))
            al.Add(CByte(4))
            al.Add(CByte(0))
            al.Add(CByte(StartAdress(idx)))
            al.Add(CByte(0))
            al.Add(CByte(ValuesCount * 2))


            .bsend = al.ToArray(GetType(Byte))
        End With

        Return commands(idx)
    End Function


    Public ReadOnly Property GetParametrsLen() As Integer
        Get
            Return StartAdress.Length * 3
        End Get
    End Property

    Public ReadOnly Property GetCommandCount() As Integer
        Get
            Return StartAdress.Length
        End Get
    End Property
End Class

Public Class clContainerMeasurePribor

    Dim provider As New NumberFormatInfo


    Public Adress As Integer

    Public command As s_command

    Public Enum eDeviceType
        i7017
        i7053
        I7080
    End Enum

    Private _devicetype As eDeviceType = eDeviceType.i7017

    Public ReadOnly Property DeviceType() As eDeviceType
        Get
            Return _devicetype
        End Get
    End Property


    Public Sub New(ByVal _type As eDeviceType, ByVal _Adress As Integer, _
                                                    Optional ByVal _baudrate As Integer = 9600, _
                                                    Optional ByVal _datalen As Integer = 8, _
                                                    Optional ByVal _stopbits As IO.Ports.StopBits = IO.Ports.StopBits.One, _
                                                    Optional ByVal _paryti As IO.Ports.Parity = IO.Ports.Parity.None)
        _devicetype = _type
        Adress = _Adress
        command.BaudRate = _baudrate
        command.StopBits = _stopbits
        command.Parity = _paryti
        command.DataLen = _datalen

        provider.NumberDecimalSeparator = "."

    End Sub

    Public Overridable Sub SetValue(ByVal value As Object, Optional ByVal alway As Boolean = False)

        Dim prbr As clSimplePribor
        Dim str As String = value

        Select Case _devicetype
            Case eDeviceType.i7017

                Dim arr As New ArrayList
                Dim val As String
                Dim idx As Integer = 0

                For i As Integer = 0 To str.Length - 8 Step 7
                    val = str.Substring(1 + i, 7)
                    prbr = pribors.Item(idx)

                    If prbr IsNot Nothing Then
                        prbr.SetValue(Convert.ToSingle(val, provider))
                    End If

                    idx += 1
                Next

            Case eDeviceType.I7080
                prbr = pribors.Item(0)
                prbr.SetValue(CSng(Convert.ToInt32(str.Substring(1), 16)))
            Case eDeviceType.i7053
                prbr = pribors.Item(0)
                prbr.SetValue(Convert.ToInt32(str.Substring(1), 16))

        End Select

    End Sub

    Sub WriteValue(ByVal idx As Integer, ByVal value As Single, Optional ByVal alway As Boolean = False)
        Dim prbr As clSimplePribor = pribors.Item(idx)
        prbr.SetValue(value)
    End Sub


    Public Function GetCmd() As s_command
        With command
            .timeout = 300
            .checksum = True
            .count = 3
            .removeCS = True
            .PreviousDelay = 1
            .SendVbCr = True
            .ParamArray = New String() {">"}
            .protokol_type = eProtokolType.DCON

            Select Case _devicetype

                Case eDeviceType.i7017
                    .rec = ""
                    .send = "#" & Me.Adress.ToString("X2")
                Case eDeviceType.I7080
                    .rec = ""
                    .send = "#" & Me.Adress.ToString("X2") & "0"
                Case eDeviceType.i7053
                    .rec = ""
                    .send = "@" & Me.Adress.ToString("X2")
            End Select

        End With

        Return command
    End Function

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Dim pribors As New Hashtable()

    Public Sub AddPribor(ByVal pribor As clSimplePribor)
        pribors.Add(pribor.GetChanel, pribor)
    End Sub


End Class

Public Class clSimplePribor

    Dim mValue As Double
    Dim mAcseleration As Single
    Dim mPrevTime As DateTime
    Dim mChanel As Integer
    Dim mKoef As Single
    Dim mChange As Boolean = False
    Public mDigitValue As New CBitField16
    Public Event ValueChange()

    Private mBaseLevel As Single
    Private mInvertDigitValue As Boolean
    Private mMinValue As Single

    Public Sub New(ByVal _Chanel As Integer, Optional ByVal _Koef As Single = 1, Optional ByVal BaseLevel As Single = 0, Optional ByVal MaxLevel As Single = 5, Optional ByVal Invert As Boolean = False, Optional ByVal MinValue As Single = 0)
        mChanel = _Chanel
        mKoef = _Koef / (MaxLevel - BaseLevel)
        mPrevTime = Now
        mBaseLevel = BaseLevel
        mInvertDigitValue = Invert
        mMinValue = MinValue

    End Sub


    Public Overloads Sub SetValue(ByVal val As Single, Optional ByVal always As Boolean = False)

        val -= mBaseLevel

        val *= mKoef

        val += mMinValue

        If val <> mValue Then
            Dim ordCurTime As DateTime = Now
            If mPrevTime.Ticks > 0 Then
                mAcseleration = CSng(val - mValue) / ((ordCurTime - mPrevTime).TotalSeconds)
            End If
            mPrevTime = ordCurTime
            mValue = val
            change()
        Else
            If always = True Then change()

            mAcseleration = 0
        End If

    End Sub

    Public Overloads Sub SetValue(ByVal val As Integer)

        If mInvertDigitValue = True Then
            val = val Xor &HFFFF
        End If

        If val <> mDigitValue.Value Then
            mDigitValue.Value = val
            change()
        End If

    End Sub


    Public ReadOnly Property GetAcseleration() As Single
        Get
            Return mAcseleration
        End Get
    End Property

    Public ReadOnly Property GetChanel() As Integer
        Get
            Return mChanel
        End Get
    End Property

    Public ReadOnly Property IsChange() As Boolean
        Get
            Return mChange
        End Get
    End Property

    Public Function GetValue(ByVal round As Integer, Optional ByVal absolut As Boolean = True) As Double


        Dim rez As Double

        SyncLock Me
            rez = mValue
        End SyncLock

        mChange = False

        If absolut = True Then rez = Math.Abs(rez)

        Return Math.Round(rez, round)
    End Function

    Sub change()
        mChange = True
        RaiseEvent ValueChange()

    End Sub
End Class

Public Class clEncoder360

    Dim mValue As Long
    Dim mAcseleration As Single
    Dim mPrevTime As DateTime
    Dim mKoef As Single


    Private mZeroValue As Long


    Public Sub New(ByVal _Koef As Single, ByVal _zerovalue As Long)

        mKoef = _Koef
        mPrevTime = Now
        mZeroValue = _zerovalue
        mValue = _zerovalue
    End Sub


    Public Sub SetZero()
        mZeroValue = mValue
    End Sub

    Public Overloads Sub SetValue(ByVal val As Long)


        If val <> mValue Then
            Dim ordCurTime As DateTime = Now
            If mPrevTime.Ticks > 0 Then


                mAcseleration = CSng(val - mValue) / ((ordCurTime - mPrevTime).TotalSeconds)
            End If
            mPrevTime = ordCurTime
            mValue = val
        Else
            mAcseleration = 0
        End If


    End Sub

    Public ReadOnly Property GetAcseleration() As Single
        Get
            Return mAcseleration
        End Get
    End Property


    Public Function GetValue(ByVal round As Integer) As Single


        Dim rez As Single

        SyncLock Me
            rez = (mValue - mZeroValue) / mKoef
            If rez < 0 Then
                rez = 360 + rez
            End If

        End SyncLock

        Return Math.Round(rez, round)
    End Function


End Class