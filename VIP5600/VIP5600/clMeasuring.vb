Imports System.Math
Imports System.Globalization
Imports System.Threading
Imports clTreeView
Imports System.IO
Imports System.Text


Public Class clUstanovkaGidrogasitel

    Inherits CCheck

#Region "��������� ICheck"


    Public Overrides Sub Abort()
        mStatus = e_Status.e_Aborted
    End Sub

    Private parametr As GidrogasitelDataSet.ApparatsRow

    Dim WaitStatus As CWaiter.e_WaitStatus

    Private level As Single
    Private setting_angle As Integer
    Private v0 As Boolean
    Private base_angle As Single
    Private curr_angle As Single
    Private lcard_discret_frec As Double

    Protected Overrides Sub DoWork()

        Dim val As Integer = 4

        mStatus = e_Status.e_Execute

        '��������� ��� ���������� ����

        If stend.opros.KM1.Sostoyanie Then
            Me.stend.SetRazbor()

            mStatus = e_Status.e_Execute
            WaitStatus = Me.Waiter.Wait(20, , "������ �����", AddressOf CheckRazbor)


            If WaitStatus = CWaiter.e_WaitStatus.e_WaitCompleted Then
                Me.SetError("����� �� �����������!")
                GoTo err
            ElseIf Me.Status = e_Status.e_Error Then
                GoTo err
            ElseIf mStatus = e_Status.e_Aborted Then
                Me.SetError("���������� �������� ���� �������� �����������")
                GoTo err
            End If

            'Threading.Thread.Sleep(2000)
        End If


        Me.Waiter.Wait(60 * 10, , "��������� ��� ������������� ���������� � ������� ���������!", AddressOf CheckAbort)
        If WaitStatus = CWaiter.e_WaitStatus.e_WaitCompleted Then
            Me.SetError("������� ����� ��������! ��������� �������� ���������������!")
            GoTo err
        ElseIf Me.Status = e_Status.e_Error Then
            GoTo err
        ElseIf mStatus = e_Status.e_Aborted Then
            'Me.SetError("���������� �������� ���� �������� �����������")
            'GoTo err
        End If


        'If stend.opros.KoncevikAmplitudeMin.Sostoyanie = False Then
        '    stend.AmplitudeExcecute(clStend.eAction.FindZero)


        '    mStatus = e_Status.e_Execute
        '    WaitStatus = Me.Waiter.Wait(60 * 2, , "��������� ����������� �������� ��������� ������ �������������", AddressOf CheckSearchMinAmplitude)


        '    If WaitStatus = CWaiter.e_WaitStatus.e_WaitCompleted Then
        '        Me.SetError("����������� �������� ��������� �� �������!")
        '        GoTo err
        '    ElseIf Me.Status = e_Status.e_Error Then
        '        GoTo err
        '    ElseIf mStatus = e_Status.e_Aborted Then
        '        Me.SetError("���������� �������� ���� �������� �����������")
        '        GoTo err
        '    End If

        'End If

        Dim tmp_lcard_discret_frec As Double = stend.opros.lcard.GetCurrentRate

        lcard_discret_frec = 120.0

        stend.opros.lcard.ReInit(lcard_discret_frec)

        mStatus = e_Status.e_Execute
        Me.Waiter.Wait(30, True, "���������� ���������!", AddressOf CheckLcardInit)

        If WaitStatus = CWaiter.e_WaitStatus.e_WaitCompleted Then
            Me.SetError("��� �� �� ��� � �����! ���������� �������� ��������!")
            GoTo err
        ElseIf Me.Status = e_Status.e_Error Then
            GoTo err
        ElseIf mStatus = e_Status.e_Aborted Then
            Me.SetError("���������� �������� ���� �������� �����������")
            GoTo err
        End If


        ''������� ����������� ������� ���������
        'Dim base As Single = stend.opros.Ampl.GetValue(1)

        'level = base + parametr.S1_Ampl

        'stend.AmplitudeExcecute(clStend.eAction.Up)

        'mStatus = e_Status.e_Execute
        'WaitStatus = Me.Waiter.Wait(60 * 2, , "��������� �������� �������� �������� ��� ������� ���� ���������, �� -" & parametr.S1_Ampl, AddressOf CheckSetAmplitude)


        'If WaitStatus = CWaiter.e_WaitStatus.e_WaitCompleted Then
        '    Me.SetError("�� ������� ������  ��������� ������ ��������!")
        '    GoTo err
        'ElseIf Me.Status = e_Status.e_Error Then
        '    GoTo err
        'ElseIf mStatus = e_Status.e_Aborted Then
        '    Me.SetError("���������� �������� ���� �������� �����������")
        '    GoTo err
        'End If
        'stend.AmplitudeExcecute(clStend.eAction.Stop)

        'stend.opros.lcard.ReInit(8.0)

        '�� ���
        'If stend.opros.KoncevikAngle0.Sostoyanie = False Then
        'stend.AngleExcecute(clStend.eAction.FindZero)


        'mStatus = e_Status.e_Execute
        'WaitStatus = Me.Waiter.Wait(60 * 2, , "��������� ������������� � ������������ ���������", AddressOf CheckSearchVertical)

        'If WaitStatus = CWaiter.e_WaitStatus.e_WaitCompleted Then
        '  Me.SetError("������������  ��������� �� �������!")
        '   GoTo err
        'ElseIf Me.Status = e_Status.e_Error Then
        '   GoTo err
        'ElseIf mStatus = e_Status.e_Aborted Then
        '  Me.SetError("���������� �������� ���� �������� �����������")
        '   GoTo err
        'End If

        'End If
        'do sih
        stend.AngleExcecute(clStend.eAction.Stop)


        Me.Waiter.Wait(3, , "������� ������� �������", AddressOf CheckAbort)

        '������� - ������������ ���� ������� 
        curr_angle = stend.opros.AngleE.GetValue(1)
        base_angle = rw.BASE_ANGLE


        If v0 Then
            setting_angle = 0
        Else
            setting_angle = parametr.ProkachkaAngle
        End If

        ' Me.Waiter.Wait(5, , "Bl" & CStr(base_angle) & "SL" & CStr(setting_angle), AddressOf CheckAbort)

        If curr_angle < (setting_angle) Then
        stend.AngleExcecute(clStend.eAction.Down)
        ElseIf curr_angle > (setting_angle) Then
            stend.AngleExcecute(clStend.eAction.Up)
        End If



        'stend.AngleExcecute(clStend.eAction.Down)

        mStatus = e_Status.e_Execute
        WaitStatus = Me.Waiter.Wait(60 * 2, , "��������� �������� �������� ���� ������� ��� ������� ���� ���������, ���� -" & setting_angle.ToString, AddressOf CheckSetAngle)


        If WaitStatus = CWaiter.e_WaitStatus.e_WaitCompleted Then
            Me.SetError("�� ������� ������  ���� �������  ��������!")
            GoTo err
        ElseIf Me.Status = e_Status.e_Error Then
            GoTo err
        ElseIf mStatus = e_Status.e_Aborted Then
            Me.SetError("���������� �������� ���� �������� �����������")
            GoTo err
        End If

        stend.AngleExcecute(clStend.eAction.Stop)

        stend.SetRazbor()

        Me.Waiter.SetNewMessage("���������� �������� ������� ���������!")

        stend.opros.lcard.ReInit(tmp_lcard_discret_frec)

        Return
err:
        stend.SetRazbor()

        stend.opros.lcard.ReInit(tmp_lcard_discret_frec)

        Me.Waiter.SetNewMessage(ErrorMessage)

        'Me.Parent.Waiter.Wait(3600, , ErrorMessage, AddressOf CheckAbort)
        Return
    End Sub

    Public Function CheckAbort() As Boolean
        If mStatus = e_Status.e_Aborted Then
            Return False
        End If
        Return True
    End Function

    Public Function CheckLcardInit() As Boolean

        If mStatus = e_Status.e_Aborted Then
            Return False
        End If

        If stend.opros.lcard.GetCurrentRate = lcard_discret_frec Then
            Return False
        End If

        Return True
    End Function
    Public Function CheckRazbor() As Boolean
        If mStatus = e_Status.e_Aborted Then
            Return False
        End If

        If stend.GetRegim = 0 Then
            Return False
        End If
        Return True
    End Function

    Public Function CheckSearchVertical() As Boolean
        If mStatus = e_Status.e_Aborted Then
            Return False
        End If

        Return Not stend.opros.KoncevikAngle0.Sostoyanie


        Return True
    End Function

    Public Function CheckSearchMinAmplitude() As Boolean

        If mStatus = e_Status.e_Aborted Then
            Return False
        End If

        Return Not stend.opros.KoncevikAmplitudeMin.Sostoyanie

        Return True

    End Function

    Public Function CheckSetAmplitude() As Boolean

        If mStatus = e_Status.e_Aborted Then
            Return False
        End If

        If stend.opros.Ampl.GetValue(1) >= level Then
            Return False
        End If

        Return True
    End Function

    Public Function CheckSetAngle() As Boolean
        If mStatus = e_Status.e_Aborted Then
            Return False
        End If

        

        'If (stend.opros.AngleE.GetValue(1) - base_angle) >= (setting_angle) Then
        If Math.Abs(stend.opros.AngleE.GetValue(1) - setting_angle) <= 2 Then
            Return False
        End If

        Return Not stend.opros.KoncevikAngle90.Sostoyanie


        Return True
    End Function


    Public Sub [Stop]()

    End Sub

#End Region

    Private stend As clStend
    Private rw As clRWini

    Public Sub New(ByVal _Key As String, ByVal row As GidrogasitelDataSet.ApparatsRow, ByVal _stend As clStend, ByVal _rw As clRWini, Optional ByVal va As Boolean = False)
        MyBase.New(_Key)
        v0 = va
        parametr = row
        stend = _stend
        rw = _rw
    End Sub


End Class

Public Class clProkachkaGidrogasitel

    Inherits CCheck

#Region "��������� ICheck"


    Public Overrides Sub Abort()
        mStatus = e_Status.e_Aborted
    End Sub

    Private parametr As GidrogasitelDataSet.ApparatsRow

    Dim WaitStatus As CWaiter.e_WaitStatus

    Private temp_zad As Single

    Protected Overrides Sub DoWork()

        mStatus = e_Status.e_Execute

        temp_zad = 35

        '��������� ��� ���������� ����

        If stend.opros.KM1.Sostoyanie Then
            Me.stend.SetRazbor()

            mStatus = e_Status.e_Execute
            WaitStatus = Me.Waiter.Wait(20, , "������ �����", AddressOf CheckRazbor)


            If WaitStatus = CWaiter.e_WaitStatus.e_WaitCompleted Then
                Me.SetError("����� �� �����������!")
                GoTo err
            ElseIf Me.Status = e_Status.e_Error Then
                GoTo err
            ElseIf mStatus = e_Status.e_Aborted Then
                Me.SetError("���������� �������� ���� �������� �����������")
                GoTo err
            End If

        End If

        If stend.opros.Tgidro.GetValue(0) < 45 Then

            mStatus = e_Status.e_Execute
            WaitStatus = Me.Waiter.Wait(60 * 10, , "��������� ��� ������������� ���������� � ������� ���������!", AddressOf CheckAbort)
            If WaitStatus = CWaiter.e_WaitStatus.e_WaitCompleted Then
                Me.SetError("������� ����� ��������! ��������� �������� ���������������!")
                GoTo err
            ElseIf Me.Status = e_Status.e_Error Then
                GoTo err
            ElseIf mStatus = e_Status.e_Aborted Then
                'Me.SetError("���������� �������� ���� �������� �����������")
                'GoTo err
            End If


            If stend.opros.Tgidro.GetValue(0) > 35 Then
                temp_zad = 44
            End If

            Me.stend.SetSbor()

            mStatus = e_Status.e_Execute
            WaitStatus = Me.Waiter.Wait(20, , "���� �����", AddressOf CheckSbor)

            If WaitStatus = CWaiter.e_WaitStatus.e_WaitCompleted Then
                Me.SetError("����� �� ���������!")
                GoTo err
            ElseIf Me.Status = e_Status.e_Error Then
                GoTo err
            ElseIf mStatus = e_Status.e_Aborted Then
                Me.SetError("���������� �������� ���� �������� �����������")
                GoTo err
            End If


            Dim ival As Integer = 16383 * parametr.ProkachkaMotorSpeed / 50


            Me.stend.opros.reg_Fzp.SetValue(ival)


            mStatus = e_Status.e_Execute
            WaitStatus = Me.Waiter.Wait(parametr.ProkachkaTime, , "�������� �������� ������������� � ������� " & parametr.ProkachkaTime & " ���. � �������� " & parametr.ProkachkaSpeed.ToString & " �/c" & _
                                        " ��� �� ���������� ����������� �������� " & temp_zad & " ����.", AddressOf CheckTemp)


            If WaitStatus = CWaiter.e_WaitStatus.e_WaitCompleted Then
                'Me.SetError("����� �� ���������!")
                'GoTo err
            ElseIf Me.Status = e_Status.e_Error Then
                GoTo err
            ElseIf mStatus = e_Status.e_Aborted Then
                Me.SetError("���������� �������� ���� �������� �����������")
                GoTo err
            End If


            stend.SetRazbor()
            mStatus = e_Status.e_Execute
            WaitStatus = Me.Waiter.Wait(20, , "������ �����", AddressOf CheckRazbor)

            stend.opros.lcard.ReInit(120.0)

            If stend.opros.Tgidro.GetValue(0) < temp_zad Then
                Me.Waiter.SetNewMessage("���������� �������� ��������� �� �������!" & vbCrLf & "��������� ��������� ������ �������������.")
            Else
                Me.Waiter.SetNewMessage("���������� �������� ��������� �� ���������� �������� �����������!" & vbCrLf & "��������� ��������� ������ �������������.")
            End If

        Else
            Me.Waiter.SetNewMessage("������� ����������� �������� - " & stend.opros.Tgidro.GetValue(0).ToString & " ����. �������� �� ����� ���� ���������. ����� ��������� �������� ���� 35 ����.")

        End If

        Return
err:
        stend.SetRazbor()

        stend.opros.lcard.ReInit(120.0)

        Me.Waiter.SetNewMessage(ErrorMessage)

        'Me.Parent.Waiter.Wait(3600, , ErrorMessage, AddressOf CheckAbort)
        Return
    End Sub

    Public Function CheckAbort() As Boolean
        If mStatus = e_Status.e_Aborted Then
            Return False
        End If

        Return True
    End Function

    Public Function CheckRazbor() As Boolean
        If mStatus = e_Status.e_Aborted Then
            Return False
        End If

        If stend.GetRegim = 0 Then
            Return False
        End If

        Return True
    End Function

    Public Function CheckSbor() As Boolean
        If mStatus = e_Status.e_Aborted Then
            Return False
        End If

        If stend.GetRegim = 1 Then
            Return False
        End If

        Return True
    End Function

    Public Function CheckTemp() As Boolean
        If mStatus = e_Status.e_Aborted Then
            Return False
        End If

        If stend.opros.Tgidro.GetValue(0) > temp_zad Then
            Return False
        End If


        Return CheckAlarm()
    End Function

    Public Function CheckAlarm() As Boolean
        If stend.opros.Tgidro.GetValue(0) > 80 Then
            SetError("����������� �������� ��������� 80 ����., �������� ������������� �� ��������!")
            Return False
        End If
        If stend.opros.Brast_max.GetValue(0) > 35000 Then
            SetError("��������� ����������� ���������� ������ 35 �� �� ����������!")
            Return False
        End If
        If stend.opros.Bsjat_max.GetValue(0) > 35000 Then
            SetError("��������� ����������� ���������� ������ 35 �� �� ������!")
            Return False
        End If
        Return True
    End Function

    Public Function CheckSearchMinAngle() As Boolean
        If mStatus = e_Status.e_Aborted Then
            Return False
        End If

        Return Not stend.opros.KoncevikAngle0.Sostoyanie

        Return True
    End Function

    Public Function CheckSearchMinAmplitude() As Boolean
        If mStatus = e_Status.e_Aborted Then
            Return False
        End If

        Return Not stend.opros.KoncevikAmplitudeMin.Sostoyanie

        Return True
    End Function

    'Public Function CheckSetAmplitude() As Boolean
    '    If mStatus = e_Status.e_Aborted Then
    '        Return False
    '    End If

    '    If stend.opros.Ampl.GetValue(1) >= level Then
    '        Return False
    '    End If

    '    Return True
    'End Function

    Public Function CheckSetAngle() As Boolean
        If mStatus = e_Status.e_Aborted Then
            Return False
        End If

        If stend.opros.AngleE.GetValue(1) >= parametr.ProkachkaAngle Then
            Return False
        End If

        Return True
    End Function

    Private lcard_discret_frec As Double

    Public Function CheckLcardInit() As Boolean

        If mStatus = e_Status.e_Aborted Then
            Return False
        End If

        If stend.opros.lcard.GetCurrentRate = lcard_discret_frec Then
            Return False
        End If

        Return True
    End Function

    Public Sub [Stop]()

    End Sub

#End Region

    Private stend As clStend
    Private rw As clRWini


    Public Sub New(ByVal _Key As String, ByVal row As GidrogasitelDataSet.ApparatsRow, ByVal _stend As clStend, ByVal _rw As clRWini)
        MyBase.New(_Key)

        rw = _rw
        parametr = row
        stend = _stend

    End Sub


End Class

Public Class clMeasureGidrogasitel

    Inherits CCheck

#Region "��������� ICheck"


    Public Overrides Sub Abort()
        mStatus = e_Status.e_Aborted
    End Sub

    Private rezult As GidrogasitelDataSet.RezultRow
    Private parametr As GidrogasitelDataSet.ApparatsRow



    Dim WaitStatus As CWaiter.e_WaitStatus

    Private Sub analise_izmer(ByRef rezult As GidrogasitelDataSet.RezultRow)

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


        CalculateArea(vals.ValuesLen, vals.ValuesPower, 1000, 0.001)

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

        'rezult.E = Math.Round((max_distance - min_distance) * CInt(rw.LEN_DATCHIK_DISTANCE) / (lCOUNT_TIME_DISCRETS * 0.8), 0)    '��������� ���� ������
        'rezult.Speed = Math.Round(1 / (vals.ValuesLen.Count * (2 / lCOUNT_TIME_DISCRETS)), 2)           '������� � ������

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



        'rezult.P_inc = Math.Round(((CInt(rw.LIM_POWER) / lHALF_DISCRETS) / 1000) * max_power, 2)
        'rezult.P_dec = Math.Round(((CInt(rw.LIM_POWER) / lHALF_DISCRETS) / 1000) * min_power, 2)

        'rezult.B_inc = Math.Round(((CInt(rw.LIM_POWER) / lDISCRETS) / 1000) * (b_plus / vals.ValuesPower.Count) * (rezult.E / 100) / rezult.Speed, 2)
        'rezult.B_dec = Math.Round(((CInt(rw.LIM_POWER) / lDISCRETS) / 1000) * (b_mines / vals.ValuesPower.Count) * (rezult.E / 100) / rezult.Speed, 2)

        'If rezult.B_inc <> 0 And rezult.B_dec <> 0 Then
        'rezult.Symmetry = Math.Round((rezult.B_inc / rezult.B_dec), 2) * 100
        'End If

        rezult.Values2 = str


        analise.Dispose()
        analise = Nothing

    End Sub

    Private Function new_analise_izmer(ByRef rezult As GidrogasitelDataSet.RezultRow) As clAnaliseFile.sRezultAnalise

        Dim str As String = ""
        Dim analise As clAnaliseFile
        'Dim vals As clAnaliseFile.sRezultAnalise

        Dim min_distance As Short = lHALF_DISCRETS
        Dim max_distance As Short = -lHALF_DISCRETS

        Dim min_power As Short = lHALF_DISCRETS
        Dim max_power As Short = -lHALF_DISCRETS


        analise = New clAnaliseFile(rw)

        analise.GetDataFromFile(My.Application.Info.DirectoryPath & "\LOG\current.adc")

        analise.NextPeriod()

        analise.NextPeriod()

        'analise.NextPeriod()


        new_analise_izmer = analise.GetRezult

        Dim mFileName As String = "len_power_period.adc"
        Dim mPath As String = My.Application.Info.DirectoryPath & "\LOG\"

        Directory.CreateDirectory(mPath)
        Dim fs As FileStream = IO.File.Create(mPath & mFileName)
        fs.Close()
        fs = Nothing

        Dim mSW As StreamWriter = New StreamWriter(mPath & mFileName, True, Encoding.GetEncoding(1251))

        For i As Integer = 0 To (new_analise_izmer.Lenght - 1)
            mSW.Write(vbCrLf & new_analise_izmer.ValuesLen(i).ToString("f0") & vbTab & new_analise_izmer.ValuesPower(i).ToString("f0"))
        Next

        mSW.Close()

        str = ""

        For i As Integer = 0 To new_analise_izmer.ValuesLen.GetUpperBound(0)
            If i = 0 Then
                str &= CShort(new_analise_izmer.ValuesLen(i)).ToString("X4")
            Else
                str &= "," & CShort(new_analise_izmer.ValuesLen(i)).ToString("X4")
            End If
        Next
        rezult.Values = str


        str = ""

        For i As Integer = 0 To new_analise_izmer.ValuesPower.GetUpperBound(0)

            If i = 0 Then
                str &= CShort(new_analise_izmer.ValuesPower(i)).ToString("X4")
            Else
                str &= "," & CShort(new_analise_izmer.ValuesPower(i)).ToString("X4")
            End If
        Next


        rezult.Values2 = str


        analise.Dispose()
        analise = Nothing

    End Function


    Protected Overrides Sub DoWork()

        'new_analise_izmer(rezult)
        mStatus = e_Status.e_Execute

        '��������� ��� ���������� ����

        Dim time As Integer
        Dim amplitude As Integer
        Dim motor_speed As Single
        Dim angle As Integer
        Dim speed As Single

        With parametr
            Select Case num_speed
                Case 1
                    time = .S1_Time
                    amplitude = .S1_Ampl
                    motor_speed = .S1_MotorSpeed
                    angle = .S1_Angle
                    speed = .S1_Speed1
                Case 2
                    time = .S2_Time
                    amplitude = .S2_Ampl
                    motor_speed = .S2_MotorSpeed
                    angle = .S2_Angle
                    speed = .S2_Speed2
                Case 3
                    time = .S3_Time
                    amplitude = .S3_Ampl
                    motor_speed = .S3_MotorSpeed
                    angle = .S3_Angle
                    speed = .S3_Speed3
                Case 4
                    time = .S4_Time
                    amplitude = .S4_Ampl
                    motor_speed = .S4_MotorSpeed
                    angle = .S4_Angle
                    speed = .S4_Speed4
            End Select
        End With


        If stend.opros.KM1.Sostoyanie Then
            Me.stend.SetRazbor()

            mStatus = e_Status.e_Execute
            WaitStatus = Me.Waiter.Wait(20, , "������ �����", AddressOf CheckRazbor)


            If WaitStatus = CWaiter.e_WaitStatus.e_WaitCompleted Then
                Me.SetError("����� �� �����������!")
                GoTo err
            ElseIf Me.Status = e_Status.e_Error Then
                GoTo err
            ElseIf mStatus = e_Status.e_Aborted Then
                Me.SetError("���������� �������� ���� �������� �����������")
                GoTo err
            End If

        End If


        Me.Waiter.Wait(60 * 10, , "��������� ��� ������������� ���������� � ������� ���������!", AddressOf CheckAbort)
        If WaitStatus = CWaiter.e_WaitStatus.e_WaitCompleted Then
            Me.SetError("������� ����� ��������! ��������� �������� ���������������!")
            GoTo err
        ElseIf Me.Status = e_Status.e_Error Then
            GoTo err
        ElseIf mStatus = e_Status.e_Aborted Then
            'Me.SetError("���������� �������� ���� �������� �����������")
            'GoTo err
        End If


        Me.stend.SetSbor()

        mStatus = e_Status.e_Execute
        WaitStatus = Me.Waiter.Wait(20, , "���� �����", AddressOf CheckSbor)


        If WaitStatus = CWaiter.e_WaitStatus.e_WaitCompleted Then
            Me.SetError("����� �� ���������!")
            GoTo err
        ElseIf Me.Status = e_Status.e_Error Then
            GoTo err
        ElseIf mStatus = e_Status.e_Aborted Then
            Me.SetError("���������� �������� ���� �������� �����������")
            GoTo err
        End If


        Dim ival As Integer = 16383 * motor_speed / 65


        Me.stend.opros.reg_Fzp.SetValue(ival)


        mStatus = e_Status.e_Execute
        WaitStatus = Me.Waiter.Wait(time, , "��������� �������� ������ �������� - " & speed.ToString & " �/c", AddressOf CheckTemp)


        If WaitStatus = CWaiter.e_WaitStatus.e_WaitCompleted Then
            'Me.SetError("����� �� ���������!")
            'GoTo err
        ElseIf Me.Status = e_Status.e_Error Then
            GoTo err
        ElseIf mStatus = e_Status.e_Aborted Then
            Me.SetError("���������� �������� ���� �������� �����������")
            GoTo err
        End If


        '���������� ���������

        stend.opros.lcard.EnableWrite()
        Me.Waiter.Wait(60 * 5, True, "�������� ���������!", AddressOf CheckFinishIzmer)

        rezult.Speed = speed
        rezult.P_inc = Math.Round(stend.opros.Bsjat_max.GetValue(0) / 1000, 1)
        rezult.P_dec = Math.Round(stend.opros.Brast_max.GetValue(0) / 1000, 1)
        rezult.A = stend.opros.Ampl.GetValue(0)


        stend.SetRazbor()


        mStatus = e_Status.e_Execute
        WaitStatus = Me.Waiter.Wait(20, , "������ �����", AddressOf CheckRazbor)

        Dim vals As clAnaliseFile.sRezultAnalise = new_analise_izmer(rezult)

        Dim k_len As Single = (rw.LEN_DATCHIK_DISTANCE / 1000) / (lHALF_DISCRETS * 0.8)
        Dim k_power As Single = (rw.LIM_POWER) / lHALF_DISCRETS
        rezult.E = Math.Round((60 / rezult.A) * CalculateArea(vals.ValuesLen, vals.ValuesPower, k_len, k_power), 0)


        rezult.B_dec = Math.Round((rezult.P_dec) * 1000 / (2 * rezult.A * Math.PI * CDec(rw.N_NOM) * motor_speed / (CDec(rw.PER_SHTOK) * 60 * 50)), 0)
        rezult.B_inc = Math.Round((rezult.P_inc) * 1000 / (2 * rezult.A * Math.PI * CDec(rw.N_NOM) * motor_speed / (CDec(rw.PER_SHTOK) * 60 * 50)), 0)



        rezult.Symmetry = Math.Abs(Math.Round(100 * (rezult.B_inc - rezult.B_dec) / ((rezult.B_inc + rezult.B_dec) / 2), 1))

        stend.opros.lcard.ReInit(120.0)



        Me.Waiter.SetNewMessage("���������� �������� ������� ���������!")

        Return
err:
        stend.SetRazbor()
        stend.opros.lcard.ReInit(120.0)

        Me.Parent.Waiter.Wait(3600, , "�� ����� ���������� �������� �������� ������!", AddressOf CheckAbort)
        Return
    End Sub

    Public Function CheckTemp() As Boolean
        If mStatus = e_Status.e_Aborted Then
            Return False
        End If


        Return CheckAlarm()
    End Function

    Public Function CheckAlarm() As Boolean
        If stend.opros.Tgidro.GetValue(0) > 80 Then
            SetError("����������� �������� ��������� 80 ����., �������� ������������� �� ��������!")
            Return False
        End If
        If stend.opros.Brast_max.GetValue(0) > 35000 Then
            SetError("��������� ����������� ���������� ������ 35 �� �� ����������!")
            Return False
        End If
        If stend.opros.Bsjat_max.GetValue(0) > 35000 Then
            SetError("��������� ����������� ���������� ������ 35 �� �� ������!")
            Return False
        End If
        Return True
    End Function


    Public Function CheckRazbor() As Boolean
        If mStatus = e_Status.e_Aborted Then
            Return False
        End If

        If stend.GetRegim = 0 Then
            Return False
        End If
        Return True
    End Function

    Public Function CheckSbor() As Boolean
        If mStatus = e_Status.e_Aborted Then
            Return False
        End If

        If stend.GetRegim = 1 Then
            Return False
        End If
        Return True
    End Function

    Public Function CheckAbort() As Boolean
        If mStatus = e_Status.e_Aborted Then
            Return False
        End If
        Return True
    End Function


    Public Function CheckFinishIzmer() As Boolean
        If mStatus = e_Status.e_Aborted Then
            Return False
        End If

        Return stend.opros.lcard.GetWriteEnable

        If CheckAlarm() = False Then
            Return False
        End If

        Return True
    End Function

    Public Sub [Stop]()

    End Sub

#End Region

    Private stend As clStend
    Private rw As clRWini
    Private num_speed As Integer

    Public Sub New(ByVal _Key As String, ByVal row1 As GidrogasitelDataSet.ApparatsRow, ByVal row2 As GidrogasitelDataSet.RezultRow, ByVal _stend As clStend, ByVal _rw As clRWini, ByVal _num_speed As Integer)
        MyBase.New(_Key)
        num_speed = _num_speed
        parametr = row1
        rezult = row2
        stend = _stend
        rw = _rw
    End Sub


End Class

Public Class clUstanovkaAmplitude

    Inherits CCheck

#Region "��������� ICheck"


    Public Overrides Sub Abort()
        mStatus = e_Status.e_Aborted
    End Sub


    Private parametr As GidrogasitelDataSet.ApparatsRow

    Dim WaitStatus As CWaiter.e_WaitStatus

    Dim WithEvents opros As clOpros

    Private Sub analise_izmer(ByRef rezult As GidrogasitelDataSet.RezultRow)

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


        CalculateArea(vals.ValuesLen, vals.ValuesPower, 1000, 0.001)

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

        'rezult.E = Math.Round((max_distance - min_distance) * CInt(rw.LEN_DATCHIK_DISTANCE) / (lCOUNT_TIME_DISCRETS * 0.8), 0)    '��������� ���� ������
        'rezult.Speed = Math.Round(1 / (vals.ValuesLen.Count * (2 / lCOUNT_TIME_DISCRETS)), 2)           '������� � ������

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



        'rezult.P_inc = Math.Round(((CInt(rw.LIM_POWER) / lHALF_DISCRETS) / 1000) * max_power, 2)
        'rezult.P_dec = Math.Round(((CInt(rw.LIM_POWER) / lHALF_DISCRETS) / 1000) * min_power, 2)

        'rezult.B_inc = Math.Round(((CInt(rw.LIM_POWER) / lDISCRETS) / 1000) * (b_plus / vals.ValuesPower.Count) * (rezult.E / 100) / rezult.Speed, 2)
        'rezult.B_dec = Math.Round(((CInt(rw.LIM_POWER) / lDISCRETS) / 1000) * (b_mines / vals.ValuesPower.Count) * (rezult.E / 100) / rezult.Speed, 2)

        'If rezult.B_inc <> 0 And rezult.B_dec <> 0 Then
        'rezult.Symmetry = Math.Round((rezult.B_inc / rezult.B_dec), 2) * 100
        'End If

        rezult.Values2 = str


        analise.Dispose()
        analise = Nothing

    End Sub

    Private Function new_analise_izmer(ByRef rezult As GidrogasitelDataSet.RezultRow) As clAnaliseFile.sRezultAnalise

        Dim str As String = ""
        Dim analise As clAnaliseFile
        'Dim vals As clAnaliseFile.sRezultAnalise

        Dim min_distance As Short = lHALF_DISCRETS
        Dim max_distance As Short = -lHALF_DISCRETS

        Dim min_power As Short = lHALF_DISCRETS
        Dim max_power As Short = -lHALF_DISCRETS


        analise = New clAnaliseFile(rw)

        analise.GetDataFromFile(My.Application.Info.DirectoryPath & "\LOG\current.adc")

        analise.NextPeriod()

        analise.NextPeriod()

        'analise.NextPeriod()


        new_analise_izmer = analise.GetRezult

        Dim mFileName As String = "len_power_period.adc"
        Dim mPath As String = My.Application.Info.DirectoryPath & "\LOG\"

        Directory.CreateDirectory(mPath)
        Dim fs As FileStream = IO.File.Create(mPath & mFileName)
        fs.Close()
        fs = Nothing

        Dim mSW As StreamWriter = New StreamWriter(mPath & mFileName, True, Encoding.GetEncoding(1251))

        For i As Integer = 0 To (new_analise_izmer.Lenght - 1)
            mSW.Write(vbCrLf & new_analise_izmer.ValuesLen(i).ToString("f0") & vbTab & new_analise_izmer.ValuesPower(i).ToString("f0"))
        Next

        mSW.Close()

        str = ""

        For i As Integer = 0 To new_analise_izmer.ValuesLen.GetUpperBound(0)
            If i = 0 Then
                str &= CShort(new_analise_izmer.ValuesLen(i)).ToString("X4")
            Else
                str &= "," & CShort(new_analise_izmer.ValuesLen(i)).ToString("X4")
            End If
        Next
        rezult.Values = str


        str = ""

        For i As Integer = 0 To new_analise_izmer.ValuesPower.GetUpperBound(0)

            If i = 0 Then
                str &= CShort(new_analise_izmer.ValuesPower(i)).ToString("X4")
            Else
                str &= "," & CShort(new_analise_izmer.ValuesPower(i)).ToString("X4")
            End If
        Next


        rezult.Values2 = str


        analise.Dispose()
        analise = Nothing

    End Function


    Dim next_ampitude As Boolean

    Protected Overrides Sub DoWork()

        'new_analise_izmer(rezult)
        mStatus = e_Status.e_Execute

        '��������� ��� ���������� ����

        Dim time As Integer
        Dim amplitude As Integer
        Dim motor_speed As Single
        Dim angle As Integer
        Dim speed As Single

        With parametr
            Select Case num_speed
                Case 0
                    time = .ProkachkaTime
                    amplitude = .ProkackaAmpl
                    motor_speed = .ProkachkaMotorSpeed
                    angle = .ProkachkaAngle
                    speed = .ProkachkaSpeed
                Case 1
                    time = .S1_Time
                    amplitude = .S1_Ampl
                    motor_speed = .S1_MotorSpeed
                    angle = .S1_Angle
                    speed = .S1_Speed1
                Case 2
                    time = .S2_Time
                    amplitude = .S2_Ampl
                    motor_speed = .S1_MotorSpeed
                    angle = .S2_Angle
                    speed = .S1_Speed1
                Case 3
                    time = .S3_Time
                    amplitude = .S3_Ampl
                    motor_speed = .S1_MotorSpeed
                    angle = .S3_Angle
                    speed = .S1_Speed1
                Case 4
                    time = .S4_Time
                    amplitude = .S4_Ampl
                    motor_speed = .S1_MotorSpeed
                    angle = .S4_Angle
                    speed = .S1_Speed1
            End Select
        End With


        If stend.opros.KM1.Sostoyanie Then
            Me.stend.SetRazbor()

            mStatus = e_Status.e_Execute
            WaitStatus = Me.Waiter.Wait(20, , "������ �����", AddressOf CheckRazbor)


            If WaitStatus = CWaiter.e_WaitStatus.e_WaitCompleted Then
                Me.SetError("����� �� �����������!")
                GoTo err
            ElseIf Me.Status = e_Status.e_Error Then
                GoTo err
            ElseIf mStatus = e_Status.e_Aborted Then
                Me.SetError("���������� �������� ���� �������� �����������")
                GoTo err
            End If

        End If


        Me.Waiter.Wait(60 * 10, , "��������� ��� ������������� ���������� � ������� ���������!", AddressOf CheckAbort)
        If WaitStatus = CWaiter.e_WaitStatus.e_WaitCompleted Then
            Me.SetError("������� ����� ��������! ��������� �������� ���������������!")
            GoTo err
        ElseIf Me.Status = e_Status.e_Error Then
            GoTo err
        ElseIf mStatus = e_Status.e_Aborted Then
            'Me.SetError("���������� �������� ���� �������� �����������")
            'GoTo err
        End If


        Me.stend.SetSbor()

        mStatus = e_Status.e_Execute
        WaitStatus = Me.Waiter.Wait(20, , "���� �����", AddressOf CheckSbor)


        If WaitStatus = CWaiter.e_WaitStatus.e_WaitCompleted Then
            Me.SetError("����� �� ���������!")
            GoTo err
        ElseIf Me.Status = e_Status.e_Error Then
            GoTo err
        ElseIf mStatus = e_Status.e_Aborted Then
            Me.SetError("���������� �������� ���� �������� �����������")
            GoTo err
        End If


        Dim ival As Integer = 16383 * motor_speed / 50


        Me.stend.opros.reg_Fzp.SetValue(ival)



        mStatus = e_Status.e_Execute
        WaitStatus = Me.Waiter.Wait(5, , "��������� �������� ������ �������� - " & speed.ToString & " �/c", AddressOf CheckTemp)


        If WaitStatus = CWaiter.e_WaitStatus.e_WaitCompleted Then
            'Me.SetError("����� �� ���������!")
            'GoTo err
        ElseIf Me.Status = e_Status.e_Error Then
            GoTo err
        ElseIf mStatus = e_Status.e_Aborted Then
            Me.SetError("���������� �������� ���� �������� �����������")
            GoTo err
        End If


        '���������� ���������
        For i As Integer = 0 To 5
            Dim st_speed = rw.STEP_SPEED

            next_ampitude = False

            Me.Waiter.Wait(60 * 5, True, "�������� ���������!", AddressOf CheckFinishIzmer)

            Dim cur_ampl As Single = stend.opros.Ampl.GetValue(1)
            Dim delta As Single = amplitude - cur_ampl

            Dim steps As Integer = Abs(delta) * 500

            time = 1 + 1.5 * Abs(delta)

            Console.WriteLine("curampl-{0} zadampl-{1} delta-{2} steps-{3} time={4}", cur_ampl, amplitude, delta, steps, time)

            If delta > 1.5 Then

                stend.smds.SendComand(New String() {"DL*", "SD" & st_speed.ToString & "*", "EN*", "MV" & steps.ToString & "*"})

            ElseIf delta < -1.5 Then

                stend.smds.SendComand(New String() {"DR*", "SD" & st_speed.ToString & "*", "EN*", "MV" & steps.ToString & "*"})
            Else
                Exit For
            End If

            mStatus = e_Status.e_Execute
            WaitStatus = Me.Waiter.Wait(time, , "��������� �������� ���������", AddressOf CheckAbort)

            If WaitStatus = CWaiter.e_WaitStatus.e_WaitCompleted Then
                'Me.SetError("����� �� ���������!")
                'GoTo err
            ElseIf Me.Status = e_Status.e_Error Then
                GoTo err
            ElseIf mStatus = e_Status.e_Aborted Then
                Me.SetError("���������� �������� ���� �������� �����������")
                GoTo err
            End If

        Next






        stend.SetRazbor()


        mStatus = e_Status.e_Execute
        WaitStatus = Me.Waiter.Wait(20, , "������ �����", AddressOf CheckRazbor)


        stend.opros.lcard.ReInit(120.0)



        Me.Waiter.SetNewMessage("���������� �������� ������� ���������!")

        Return
err:
        stend.SetRazbor()
        stend.opros.lcard.ReInit(120.0)

        Me.Parent.Waiter.Wait(3600, , "�� ����� ���������� �������� �������� ������!", AddressOf CheckAbort)
        Return
    End Sub

    Public Function CheckTemp() As Boolean
        If mStatus = e_Status.e_Aborted Then
            Return False
        End If


        Return CheckAlarm()
    End Function

    Public Function CheckAlarm() As Boolean
        If stend.opros.Tgidro.GetValue(0) > 80 Then
            SetError("����������� �������� ��������� 80 ����., �������� ������������� �� ��������!")
            Return False
        End If
        If stend.opros.Brast_max.GetValue(0) > 35000 Then
            SetError("��������� ����������� ���������� ������ 35 �� �� ����������!")
            Return False
        End If
        If stend.opros.Bsjat_max.GetValue(0) > 35000 Then
            SetError("��������� ����������� ���������� ������ 35 �� �� ������!")
            Return False
        End If
        Return True
    End Function

    Public Function CheckRazbor() As Boolean
        If mStatus = e_Status.e_Aborted Then
            Return False
        End If

        If stend.GetRegim = 0 Then
            Return False
        End If
        Return True
    End Function

    Public Function CheckSbor() As Boolean
        If mStatus = e_Status.e_Aborted Then
            Return False
        End If

        If stend.GetRegim = 1 Then
            Return False
        End If
        Return True
    End Function

    Public Function CheckAbort() As Boolean
        If mStatus = e_Status.e_Aborted Then
            Return False
        End If
        Return True
    End Function

    Public Function CheckFinishIzmer() As Boolean
        If mStatus = e_Status.e_Aborted Then
            Return False
        End If

        Return Not next_ampitude

        If CheckAlarm() = False Then
            Return False
        End If

        Return True
    End Function

    Public Sub [Stop]()

    End Sub

#End Region

    Private stend As clStend
    Private rw As clRWini
    Private num_speed As Integer

    Public Sub New(ByVal _Key As String, ByVal row1 As GidrogasitelDataSet.ApparatsRow, ByVal _stend As clStend, ByVal _rw As clRWini, ByVal _num_speed As Integer)
        MyBase.New(_Key)
        num_speed = _num_speed
        parametr = row1
        stend = _stend
        rw = _rw
        opros = stend.opros

    End Sub


    Private Sub opros_LcardDataEvalute() Handles opros.LcardDataEvalute
        next_ampitude = True
    End Sub

End Class