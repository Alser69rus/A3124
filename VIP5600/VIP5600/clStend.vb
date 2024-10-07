Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Globalization
Imports System.IO
Imports System.Windows.Forms

'<CLSCompliant(True)> _
Public Class clStend

    Implements IDisposable


    Public Event Err(ByVal code As Integer)

    Public WithEvents serial As System.IO.Ports.SerialPort
    Public WithEvents comport As clComPort



    Public rw As clRWini


    'Public Rotation As CRotationEx

    Public parent As System.Windows.Forms.Form

    Public WithEvents opros As clOpros



    Public smds As clSMSD42

    Private fAngle As Single = 0
    Private fAmpl As Single = 0
    Private fVelocity As Single = 0
    Public StAngle As eAngle = eAngle.Stop
    Public StAmpl As eAmpl = eAmpl.Stop
    Public StV As eVelocity = eVelocity.Stop
    Public tick As Integer = 0
    Public StendErr As eErr = eErr.None
    Public iter As Integer = 0
    Dim direction As Integer = 0
    Dim delta As Single
    Dim steps As Integer




    Public Enum eErr As Integer
        None
        Razbor
        Sbor
        Lcard
        Angle
        Angle0
        Angle90
        StopVelocity
        SetVelocity
        Tmax
        SetAmpl
        Phase
    End Enum
    Public Enum eAngle
        [Stop]
        Wait
        WaitAmpl
        WaitAmpl2
        WaitVelocity
        Reset
        WaitReset
        LCardInit
        WaitLCardInit
        WaitBeforeMesasure
        Measure
        AngleUp
        AngleDown
        AngleDrebezg
        AngleDrebezg2
        Phase
    End Enum
    Public Enum eAmpl
        [Stop]
        Wait
        SetV1
        WaitSbor
        SetV2
        WaitRazbor
        WaitVelocity
        Measure
        SetA
        Check
        Reset
    End Enum
    Public Enum eVelocity
        [Stop]
        Wait
        Sbor
        WaitSbor
        SetV
        Check
        Correction
        WaitCorrection
        Work
        Slow
        Razbor
    End Enum



    Public Property Angle As Single
        Get
            Return fAngle
        End Get
        Set(ByVal value As Single)
            StAngle = eAngle.Wait
            fAngle = value
            If StAmpl <> eAmpl.Stop Then
                StAmpl = eAmpl.Wait
            End If
            If StV <> eVelocity.Stop Then
                StV = eVelocity.Wait
            End If
        End Set
    End Property
    Public Property Ampl As Single
        Get
            Return fAmpl
        End Get
        Set(ByVal value As Single)
            fAmpl = value
            If fAmpl < rw.MIN_AMPL Then
                fAmpl = rw.MIN_AMPL
            End If
            If fAmpl > rw.MAX_AMPL Then
                fAmpl = rw.MAX_AMPL
            End If
            StAmpl = eAmpl.Wait
            If StV <> eVelocity.Stop Then
                StV = eVelocity.Wait
            End If
        End Set
    End Property
    Public Property Velocity As Single
        Get
            Return fVelocity
        End Get
        Set(ByVal value As Single)
            fVelocity = value
            StV = eVelocity.Wait
        End Set
    End Property



    Public Sub DoWork()
        If StendErr <> eErr.None Then
            Return
        End If
        If StAngle <> eAngle.Stop Then
            SetAngle()

        ElseIf StAmpl <> eAmpl.Stop Then
            SetAmpl()

        ElseIf StV <> eVelocity.Stop Then
            SetVelocity()

        End If
    End Sub



    Public Sub SetAngle()
        Dim curr_angle As Single
        Dim delta As Single


        Select Case StAngle
            Case eAngle.Stop
                Debug.Print("угол стоп")
                StAngle = eAngle.Stop

            Case eAngle.Wait
                Debug.Print("угол подготовка")
                If StendErr = eErr.None Then
                    StAngle = eAngle.WaitAmpl
                End If

            Case eAngle.WaitAmpl
                If StAmpl = eAmpl.Stop Or StAmpl = eAmpl.Wait Then
                    StAngle = eAngle.WaitVelocity
                End If
                SetRazbor()
                tick = 0
                StAngle = eAngle.WaitAmpl2
                If StAmpl <> eAmpl.Stop Then StAmpl = eAmpl.Wait
                If StV <> eVelocity.Stop Then StV = eVelocity.Wait

            Case eAngle.WaitAmpl2
                tick = tick + 1
                If tick > 50 Then
                    StendErr = eErr.Razbor
                    StAngle = eAngle.Stop
                End If
                If Not opros.KM1.Sostoyanie Then
                    StAngle = eAngle.WaitReset
                    tick = 0
                End If

            Case eAngle.WaitVelocity
                tick = tick + 1
                If opros.Ffp.GetValue(0) > 16 Then
                    opros.reg_Fzp.SetValue(500)
                End If

                If opros.Ffp.GetValue(1) < 10 Then
                    StAngle = eAngle.Reset
                End If
                If tick > 200 Then
                    StendErr = eErr.StopVelocity
                    StAngle = eAngle.Stop
                End If

            Case eAngle.Reset
                Debug.Print("угол сброс")
                If opros.KM1.Sostoyanie Then SetRazbor()
                tick = 0
                StAngle = eAngle.WaitReset
                If StAmpl <> eAmpl.Stop Then StAmpl = eAmpl.Wait
                If StV <> eVelocity.Stop Then StV = eVelocity.Wait

            Case eAngle.WaitReset
                tick = tick + 1
                Debug.Print("угол сброс" & tick)
                If opros.KM1.Sostoyanie = False Then
                    StAngle = eAngle.LCardInit

                End If
                If tick > 50 Then
                    Debug.Print("угол сброс время")
                    StendErr = eErr.Razbor
                    SetRazbor()
                    StAngle = eAngle.Stop
                    StAmpl = eAmpl.Stop
                    StV = eVelocity.Stop
                End If

            Case eAngle.LCardInit
                Debug.Print("угол лкард")
                frmGMain.Fdiskr = 120.0
                ' opros.lcard.ReInit(120.0)
                tick = 0
                StAngle = eAngle.WaitLCardInit

            Case eAngle.WaitLCardInit
                tick = tick + 1
                Debug.Print("угол лкард" & tick)
                If opros.lcard.GetCurrentRate = 120.0 Then
                    StAngle = eAngle.WaitBeforeMesasure
                    tick = 0
                End If

                If tick > 100 Then
                    Debug.Print("угол лкард время")
                    StendErr = eErr.Lcard
                    SetRazbor()
                    StAngle = eAngle.Stop
                    ' StAmpl = eAmpl.Stop
                    ' StV = eVelocity.Stop
                End If

            Case eAngle.WaitBeforeMesasure
                tick = tick + 1
                Debug.Print("ждем угла" & tick)
                If tick > 10 Then
                    iter = 0
                    StAngle = eAngle.Measure
                End If

            Case eAngle.Measure
                Debug.Print("измеряем угол")
                curr_angle = opros.AngleE.GetValue(1)
                delta = Angle - curr_angle
                If Math.Abs(delta) < 2 Then
                    StAngle = eAngle.Stop
                    fAngle = curr_angle
                ElseIf delta > 0 Then
                    StAngle = eAngle.AngleDown
                    AngleExcecute(eAction.Down)
                ElseIf delta < 0 Then
                    StAngle = eAngle.AngleUp
                    AngleExcecute(eAction.Up)
                End If
                tick = 0

            Case eAngle.AngleUp
                tick = tick + 1
                curr_angle = opros.AngleE.GetValue(1)
                delta = curr_angle - Angle
                Debug.Print("угол вверх" & curr_angle)
                If delta < 2 Then
                    fAngle = curr_angle
                    StAngle = eAngle.Stop
                    AngleExcecute(eAction.Stop)
                End If
                If tick > 300 Then
                    Debug.Print("угол вверх время")
                    StendErr = eErr.Angle
                    SetRazbor()
                    StAngle = eAngle.Stop
                    StAmpl = eAmpl.Stop
                    StV = eVelocity.Stop
                End If
                If curr_angle < -2 Then
                    Debug.Print("угол вверх 0 град")
                    'StendErr = eErr.Angle0
                    'SetRazbor()
                    StAngle = eAngle.AngleDrebezg
                    tick = 0
                    'StAmpl = eAmpl.Stop
                    'StV = eVelocity.Stop
                End If
                If curr_angle > 92 Then
                    Debug.Print("угол вверх 90 град")
                    'StendErr = eErr.Angle90
                    'SetRazbor()
                    StAngle = eAngle.AngleDrebezg
                    tick = 0
                    'StAmpl = eAmpl.Stop
                    'StV = eVelocity.Stop
                End If
                ' If opros.AngleE.GetAcseleration > 0.5 Then
                ' StendErr = eErr.Phase
                'SetRazbor()
                'StAngle = eAngle.Stop
                'StAmpl = eAmpl.Stop
                'StV = eVelocity.Stop
                'End If
            Case eAngle.AngleDown
                tick = tick + 1
                curr_angle = opros.AngleE.GetValue(1)
                delta = fAngle - curr_angle
                Debug.Print("угол вверх" & curr_angle)
                If delta < 2 Then
                    StAngle = eAngle.Stop
                    fAngle = curr_angle
                    AngleExcecute(eAction.Stop)
                End If
                If tick > 300 Then
                    Debug.Print("угол вверх время")
                    StendErr = eErr.Angle
                    SetRazbor()
                    StAngle = eAngle.Stop
                    StAmpl = eAmpl.Stop
                    StV = eVelocity.Stop
                End If
                If curr_angle < -2 Then
                    Debug.Print("угол вверх 0 град")
                    'StendErr = eErr.Angle0
                    'SetRazbor()
                    StAngle = eAngle.AngleDrebezg
                    tick = 0
                    'StAmpl = eAmpl.Stop
                    'StV = eVelocity.Stop
                End If
                If curr_angle > 92 Then
                    Debug.Print("угол вверх 90 град")
                    'StendErr = eErr.Angle90
                    'SetRazbor()
                    StAngle = eAngle.AngleDrebezg
                    tick = 0
                    'StAmpl = eAmpl.Stop
                    'StV = eVelocity.Stop
                End If
                'If opros.AngleE.GetAcseleration < -0.5 Then
                'StendErr = eErr.Phase
                'SetRazbor()
                ' StAngle = eAngle.Stop
                ' StAmpl = eAmpl.Stop
                ' StV = eVelocity.Stop
                'End If
            Case eAngle.AngleDrebezg
                tick = tick + 1
                If tick > 50 Then StAngle = eAngle.AngleDrebezg2

            Case eAngle.AngleDrebezg2
                tick = 0
                iter = iter + 1
                If opros.KoncevikAngle0.Sostoyanie And opros.AngleE.GetValue(1) > 0 Then
                    StAngle = eAngle.AngleDrebezg
                ElseIf opros.KoncevikAngle90.Sostoyanie And opros.AngleE.GetValue(1) < 90 Then
                    StAngle = eAngle.AngleDrebezg
                ElseIf iter > 20 Then
                    StendErr = eErr.Angle
                    StAngle = eAngle.Stop
                    StAmpl = eAmpl.Stop
                    StV = eVelocity.Stop
                ElseIf opros.AngleE.GetValue(1) < -2 Or opros.KoncevikAngle0.Sostoyanie Then
                    StendErr = eErr.Angle0
                    StAngle = eAngle.Stop
                    StAmpl = eAmpl.Stop
                    StV = eVelocity.Stop
                ElseIf opros.AngleE.GetValue(1) > 92 Or opros.KoncevikAngle90.Sostoyanie Then
                    StendErr = eErr.Angle90
                    StAngle = eAngle.Stop
                    StAmpl = eAmpl.Stop
                    StV = eVelocity.Stop
                Else
                    StAngle = eAngle.Measure
                End If
        End Select
    End Sub
    Public Sub SetAmpl()
       

        Select Case StAmpl
            Case eAmpl.Stop
                Debug.Print("Ампл стоп")
                StAmpl = eAmpl.Stop

            Case eAmpl.Wait

                If StendErr = eErr.None Then
                    If StV = eVelocity.Check Or StV = eVelocity.Correction Or StV = eVelocity.Work Or StV = eVelocity.SetV Or StV = eVelocity.WaitCorrection Then
                        StAmpl = eAmpl.SetV2
                    ElseIf opros.KM1.Sostoyanie Then
                        StAmpl = eAmpl.SetV2
                    Else
                        StAmpl = eAmpl.SetV1
                    End If
                End If
                If opros.Tgidro.GetValue(1, False) > 85 Then
                    SetRazbor()
                    StendErr = eErr.Tmax
                    StV = eVelocity.Stop
                    StAmpl = eAmpl.Stop
                End If

            Case eAmpl.SetV1
                SetSbor()
                tick = 0
                StAmpl = eAmpl.WaitSbor

            Case eAmpl.WaitSbor
                tick = tick + 1
                If tick > 250 Then
                    StendErr = eErr.Sbor
                End If
                If opros.KM1.Sostoyanie And tick > 100 Then
                    opros.reg_Fzp.SetValue(2500)
                    tick = 0
                    StAmpl = eAmpl.WaitVelocity
                End If

            Case eAmpl.SetV2

                    opros.reg_Fzp.SetValue(2500)
                    'StV = eVelocity.Wait
                    StAmpl = eAmpl.WaitVelocity
                    tick = 0



            Case eAmpl.WaitRazbor
                    tick = tick + 1
                If tick > 150 Then
                    StendErr = eErr.Razbor
                End If
                If tick > 50 And opros.KM1.Sostoyanie = False Then
                    StAmpl = eAmpl.Wait
                End If

            Case eAmpl.WaitVelocity
                    tick = tick + 1
                    If tick > 300 Then
                        StendErr = eErr.SetVelocity
                        StAmpl = eAmpl.Stop
                        StV = eVelocity.Stop
                        StAngle = eAngle.Stop
                        SetRazbor()
                    End If

                    If opros.Tgidro.GetValue(1, False) > 85 Then
                        SetRazbor()
                        StendErr = eErr.Tmax
                        StV = eVelocity.Stop
                        StAmpl = eAmpl.Stop
                    End If

                If opros.Velocity.GetAcseleration < 0.003 And opros.Velocity.GetValue(3) > 0.007 And tick > 100 Then
                    StAmpl = eAmpl.Measure
                    tick = 0
                    iter = 0
                End If

            Case eAmpl.Measure
                Dim speed = rw.STEP_SPEED
                iter = iter + 1
                If iter > 10 Then
                    StendErr = eErr.SetAmpl
                    StAmpl = eAmpl.Stop
                    SetRazbor()
                End If
                delta = fAmpl - opros.Ampl.GetValue(1)
                If Math.Abs(delta) < 1 Then
                    StAmpl = eAmpl.Reset
                ElseIf delta > 0 Then
                    StAmpl = eAmpl.Check
                    steps = rw.STEP_STEP * delta
                    tick = rw.STEP_OFF + rw.STEP_MUL * delta

                    smds.SendComand(New String() {"DL*", "SD" & speed.ToString & "*", "EN*", "MV" & steps.ToString & "*"})
                Else
                    StAmpl = eAmpl.Check
                    steps = -rw.STEP_STEP * delta
                    tick = rw.STEP_OFF - rw.STEP_MUL * delta
                    smds.SendComand(New String() {"DR*", "SD" & speed.ToString & "*", "EN*", "MV" & steps.ToString & "*"})
                End If


            Case eAmpl.Check
                    tick = tick - 1
                    If opros.Tgidro.GetValue(1, False) > 85 Then
                        StendErr = eErr.Tmax
                        SetRazbor()
                        StAmpl = eAmpl.Stop
                        StV = eVelocity.Stop
                    End If


                    Dim v As Single = opros.Ampl.GetValue(1)

                    If delta > 0 Then
                        If v > rw.MAX_AMPL Then
                            StAmpl = eAmpl.Reset
                        ElseIf v > fAmpl Then
                            smds.SendComand(New String() {"DS*"})
                        End If

                    ElseIf delta < 0 Then

                        If v < rw.MIN_AMPL Then
                            StAmpl = eAmpl.Reset
                        ElseIf v < fAmpl Then
                            smds.SendComand(New String() {"DS*"})
                        End If
                    Else

                    End If

                    If tick < 0 Then
                        StAmpl = eAmpl.Measure
                    End If

            Case eAmpl.Reset
                    StAmpl = eAmpl.Stop
                    fAmpl = opros.Ampl.GetValue(1)
                    If StV = eVelocity.Stop Then
                        SetRazbor()
                    Else
                        smds.SendComand(New String() {"DS*"})
                    End If

        End Select
    End Sub
    Public Sub SetVelocity()
        Select Case StV
            Case eVelocity.Stop
                StV = eVelocity.Stop

            Case eVelocity.Wait
                If StendErr = eErr.None Then

                    If opros.KM1.Sostoyanie Then
                        StV = eVelocity.SetV
                    Else
                        StV = eVelocity.WaitSbor
                        tick = 0
                        SetSbor()
                    End If
                End If

            Case eVelocity.WaitSbor
                tick = tick + 1
                If tick > 250 Then
                    StendErr = eErr.Sbor
                    StV = eVelocity.Stop
                    StAmpl = eAmpl.Stop
                End If
                If tick > 50 And opros.KM1.Sostoyanie Then
                    StV = eVelocity.SetV
                End If

            Case eVelocity.SetV
                Dim f As Integer = 16383 * fVelocity / 0.6
                If fAmpl > 18 Then
                    f = f * 37.7 / fAmpl
                End If
                If f > 16383 Then f = 16383
                If f < 0 Then f = 0

                opros.reg_Fzp.SetValue(f)
                StV = eVelocity.Check
                iter = 0
                If fVelocity > 0.01 Then
                    tick = 21 / fVelocity 'время на завершение разгона
                Else
                    tick = 50
                End If


            Case eVelocity.Check
                tick = tick - 1
                If iter > 10 Then
                    StendErr = eErr.SetVelocity
                    StV = eVelocity.Stop
                    SetRazbor()
                End If
                If opros.Tgidro.GetValue(1, False) > 85 Then
                    SetRazbor()
                    StV = eVelocity.Stop
                    StAmpl = eAmpl.Stop
                    StendErr = eErr.Tmax
                End If
                If Math.Abs(opros.Velocity.GetAcseleration) < 0.003 And tick < 0 Then
                    If Math.Abs(opros.Velocity.GetValue(3) - fVelocity) < (fVelocity / 50) Then
                        StV = eVelocity.Work
                    ElseIf opros.Velocity.GetValue(3) > 0.01 Then
                        StV = eVelocity.Correction
                    Else
                        tick = 50
                        If fVelocity > 0.01 Then iter = iter + 1
                    End If
                End If

            Case eVelocity.Correction
                Dim f As Integer = opros.reg_Fzp.GetValue
                Dim currentV As Single = opros.Velocity.GetValue(3)
                iter = iter + 1
                If currentV > 0.015 Then
                    f = f * fVelocity / currentV
                Else
                    f = 0
                End If
                If f < 0 Then f = 0
                If f > 16383 Then f = 16383
                opros.reg_Fzp.SetValue(f)

                If fVelocity > 0.019 Then
                    tick = 21 / fVelocity
                Else
                    tick = 600
                End If
                StV = eVelocity.WaitCorrection

            Case eVelocity.WaitCorrection
                tick = tick - 1
                If opros.Tgidro.GetValue(1, False) > 85 Then
                    SetRazbor()
                    StV = eVelocity.Stop
                    StAmpl = eAmpl.Stop
                    StendErr = eErr.Tmax
                End If
                If tick < 0 Then StV = eVelocity.Check

            Case eVelocity.Work
                If opros.Tgidro.GetValue(1, False) > 85 Then
                    SetRazbor()
                    StV = eVelocity.Stop
                    StAmpl = eAmpl.Stop
                    StendErr = eErr.Tmax
                End If

            Case eVelocity.Slow
                opros.reg_Fzp.SetValue(1000)
                StV = eVelocity.Razbor

            Case eVelocity.Razbor
                If opros.Ffp.GetValue(0) < 20 Then
                    StV = eVelocity.Stop
                    SetRazbor()
                End If


        End Select
    End Sub


    Public Sub New(ByVal _parent As Windows.Forms.Form, ByVal _lcard As clLcardGidro)

        MyBase.New()



        parent = _parent

        rw = New clRWini
        serial = New System.IO.Ports.SerialPort("COM" & rw.PORT)

        Try

            With serial
                .BaudRate = CInt(rw.BAUDRATE)
                .DataBits = CInt(rw.DATABITS)
                .Parity = [Enum].Parse(GetType(System.IO.Ports.Parity), rw.PARITY, True)
                .StopBits = [Enum].Parse(GetType(System.IO.Ports.StopBits), rw.STOPBITS, True)
                .Handshake = [Enum].Parse(GetType(System.IO.Ports.Handshake), rw.HANDSHAKE, True)
            End With

            serial.ReadBufferSize = 1000
            serial.ReceivedBytesThreshold = 1
            comport = New clComPort(serial, CBool(rw.ENABLE_LOG))
            comport.Protokol = clComPort.eProtokol.ASCII
            comport.EnableEventReceived = True

            serial.Open()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'Rotation = New CRotationEx(Me)

        opros = New clOpros(Me, rw, _lcard)

        smds = New clSMSD42("COM" & rw.PORT2)

    End Sub

    Public Sub Dispose() Implements System.IDisposable.Dispose

        opros.Ended()
        While opros.IsExit = False
            Threading.Thread.Sleep(500)
            'mSleep(500)
        End While

        smds.Ended()

        comport.Dispose()

        'Rotation.Dispose()

    End Sub


    ''' <summary>
    ''' формирует строку для установки-сброса одного бита модуля цифрового выхода
    ''' </summary>
    ''' <param name="adress">адрес</param>
    ''' <param name="OutNum">номер выхода</param>
    ''' <param name="value">установка-1,сброс-0</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DIO_OneOut_Cmd(ByVal adress As Byte, ByVal OutNum As Byte, ByVal value As Byte) As String
        Return "#" & adress.ToString("X2") & "1" & OutNum.ToString & "0" & value.ToString
    End Function
    ''' <summary>
    ''' формирует строку для установки-сброса всех битов модуля цифрового выхода
    ''' </summary>
    ''' <param name="adress">адрес</param>
    ''' <param name="value"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DIO_AllOut_Cmd(ByVal adress As Byte, ByVal value As Int16) As String
        Return "@" & adress.ToString("X2") & value.ToString("X4")
    End Function


    ''' <summary>
    ''' команда разбора схемы
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SetRazbor()

        AmplitudeExcecute(eAction.Stop)
        

        opros.reg_Fzp.Reset()

        opros.SendComand(New s_command With {.rec = "", _
                                                  .send = DIO_AllOut_Cmd(rw.ADRESS(0), 0), _
                                                  .removeCS = True, _
                                                  .timeout = 300, _
                                                  .checksum = True, _
                                                  .count = 3, _
                                                  .PreviousDelay = 10, _
                                                  .SendVbCr = True, _
                                                  .ParamArray = New String() {">"}, _
                                                  .BaudRate = 9600, _
                                                  .StopBits = IO.Ports.StopBits.One, _
                                                  .Parity = IO.Ports.Parity.None, _
                                                  .DataLen = 8, _
                                                  .protokol_type = eProtokolType.DCON})



        opros.SendComand(New s_command With {.rec = "", _
                                                  .send = DIO_OneOut_Cmd(rw.ADRESS(0), 1, 1), _
                                                  .removeCS = True, _
                                                  .timeout = 300, _
                                                  .checksum = True, _
                                                  .count = 3, _
                                                  .PreviousDelay = 100, _
                                                  .SendVbCr = True, _
                                                  .ParamArray = New String() {">"}, _
                                                  .BaudRate = 9600, _
                                                  .StopBits = IO.Ports.StopBits.One, _
                                                  .Parity = IO.Ports.Parity.None, _
                                                  .DataLen = 8, _
                                                  .protokol_type = eProtokolType.DCON})

        opros.SendComand(New s_command With {.rec = "", _
                                                  .send = DIO_OneOut_Cmd(rw.ADRESS(0), 1, 0), _
                                                  .removeCS = True, _
                                                  .timeout = 300, _
                                                  .checksum = True, _
                                                  .count = 3, _
                                                  .PreviousDelay = 1000, _
                                                  .SendVbCr = True, _
                                                  .ParamArray = New String() {">"}, _
                                                  .BaudRate = 9600, _
                                                  .StopBits = IO.Ports.StopBits.One, _
                                                  .Parity = IO.Ports.Parity.None, _
                                                  .DataLen = 8, _
                                                  .protokol_type = eProtokolType.DCON})
        opros.SendComand(New s_command With {.rec = "", _
                                                  .send = DIO_OneOut_Cmd(rw.ADRESS(0), 2, 0), _
                                                  .removeCS = True, _
                                                  .timeout = 300, _
                                                  .checksum = True, _
                                                  .count = 3, _
                                                  .PreviousDelay = 1000, _
                                                  .SendVbCr = True, _
                                                  .ParamArray = New String() {">"}, _
                                                  .BaudRate = 9600, _
                                                  .StopBits = IO.Ports.StopBits.One, _
                                                  .Parity = IO.Ports.Parity.None, _
                                                  .DataLen = 8, _
                                                  .protokol_type = eProtokolType.DCON})
        opros.SendComand(New s_command With {.rec = "", _
                                                  .send = DIO_OneOut_Cmd(rw.ADRESS(0), 3, 0), _
                                                  .removeCS = True, _
                                                  .timeout = 300, _
                                                  .checksum = True, _
                                                  .count = 3, _
                                                  .PreviousDelay = 1000, _
                                                  .SendVbCr = True, _
                                                  .ParamArray = New String() {">"}, _
                                                  .BaudRate = 9600, _
                                                  .StopBits = IO.Ports.StopBits.One, _
                                                  .Parity = IO.Ports.Parity.None, _
                                                  .DataLen = 8, _
                                                  .protokol_type = eProtokolType.DCON})
        smds.SendComand(New String() {"DS*"})



    End Sub



    ''' <summary>
    ''' </summary>      
    ''' 
    ''' <returns> 0 - все контакторы отключены , 
    ''' 1 - собран режим</returns>
    ''' <remarks></remarks>
    Public Function GetRegim() As Integer
        Dim val As UInt16 = opros.DigIN2.mValue.Value


        'val = val And &H1F7

        If (val And 16) = 0 Then
            Return 1
        End If
        Return 0


    End Function

    Public Enum eAction
        Up = 1
        Down = 2
        [Stop] = 0
        FindZero = 3
    End Enum


    Public Sub SetSbor(Optional ByVal fmax As Integer = 65)
        AmplitudeExcecute(eAction.Stop)

        opros.SendComand(New s_command With {.rec = "", _
                                                  .send = DIO_AllOut_Cmd(rw.ADRESS(0), 0), _
                                                  .removeCS = True, _
                                                  .timeout = 300, _
                                                  .checksum = True, _
                                                  .count = 3, _
                                                  .PreviousDelay = 10, _
                                                  .SendVbCr = True, _
                                                  .ParamArray = New String() {">"}, _
                                                  .BaudRate = 9600, _
                                                  .StopBits = IO.Ports.StopBits.One, _
                                                  .Parity = IO.Ports.Parity.None, _
                                                  .DataLen = 8, _
                                                  .protokol_type = eProtokolType.DCON})



        opros.SendComand(New s_command With {.rec = "", _
                                                  .send = DIO_OneOut_Cmd(rw.ADRESS(0), 0, 1), _
                                                  .removeCS = True, _
                                                  .timeout = 300, _
                                                  .checksum = True, _
                                                  .count = 3, _
                                                  .PreviousDelay = 100, _
                                                  .SendVbCr = True, _
                                                  .ParamArray = New String() {">"}, _
                                                  .BaudRate = 9600, _
                                                  .StopBits = IO.Ports.StopBits.One, _
                                                  .Parity = IO.Ports.Parity.None, _
                                                  .DataLen = 8, _
                                                  .protokol_type = eProtokolType.DCON})



        opros.SendComand(New s_command With {.rec = "", _
                                                  .send = DIO_OneOut_Cmd(rw.ADRESS(0), 0, 0), _
                                                  .removeCS = True, _
                                                  .timeout = 300, _
                                                  .checksum = True, _
                                                  .count = 3, _
                                                  .PreviousDelay = 1000, _
                                                  .SendVbCr = True, _
                                                  .ParamArray = New String() {">"}, _
                                                  .BaudRate = 9600, _
                                                  .StopBits = IO.Ports.StopBits.One, _
                                                  .Parity = IO.Ports.Parity.None, _
                                                  .DataLen = 8, _
                                                 .protokol_type = eProtokolType.DCON})

        opros.reg_Fzp.Reset()
        opros.reg_Fzp.Start(2000, fmax)

    End Sub

    Public Sub AmplitudeExcecute(ByVal action As eAction)
        Dim speed = rw.STEP_SPEED

        Select Case action
            Case eAction.Stop
                Debug.Print("amplitude stop")
                smds.SendComand(New String() {"DS*"})

            Case eAction.Up
                Debug.Print("amplitude up")
                smds.SendComand(New String() {"DL*", "SD" & speed.ToString & "*", "EN*", "MV*"})

            Case eAction.Down
                Debug.Print("amplitude down")
                smds.SendComand(New String() {"DR*", "SD" & speed.ToString & "*", "EN*", "MV*"})
            Case eAction.FindZero
                Debug.Print("amplitude findzero")
                smds.SendComand(New String() {"DR*", "EN*", "HM*"})
        End Select

    End Sub

    Public Sub AngleExcecute(ByVal action As eAction)
        Select Case action
            Case eAction.Stop
                Debug.Print("angle stop")
                opros.SendComand(New s_command With {.rec = "", _
                                                  .send = DIO_OneOut_Cmd(rw.ADRESS(0), 2, 0), _
                                                  .removeCS = True, _
                                                  .timeout = 300, _
                                                  .checksum = True, _
                                                  .count = 3, _
                                                  .PreviousDelay = 10, _
                                                  .SendVbCr = True, _
                                                  .ParamArray = New String() {">"}, _
                                                  .BaudRate = 9600, _
                                                  .StopBits = IO.Ports.StopBits.One, _
                                                  .Parity = IO.Ports.Parity.None, _
                                                  .DataLen = 8, _
                                                  .protokol_type = eProtokolType.DCON})

                opros.SendComand(New s_command With {.rec = "", _
                                                  .send = DIO_OneOut_Cmd(rw.ADRESS(0), 3, 0), _
                                                  .removeCS = True, _
                                                  .timeout = 300, _
                                                  .checksum = True, _
                                                  .count = 3, _
                                                  .PreviousDelay = 10, _
                                                  .SendVbCr = True, _
                                                  .ParamArray = New String() {">"}, _
                                                  .BaudRate = 9600, _
                                                  .StopBits = IO.Ports.StopBits.One, _
                                                  .Parity = IO.Ports.Parity.None, _
                                                  .DataLen = 8, _
                                                  .protokol_type = eProtokolType.DCON})
            Case eAction.Up, eAction.FindZero
                Debug.Print("angle up")
                opros.SendComand(New s_command With {.rec = "", _
                                                 .send = DIO_OneOut_Cmd(rw.ADRESS(0), 3, 0), _
                                                 .removeCS = True, _
                                                 .timeout = 300, _
                                                 .checksum = True, _
                                                 .count = 3, _
                                                 .PreviousDelay = 10, _
                                                 .SendVbCr = True, _
                                                 .ParamArray = New String() {">"}, _
                                                 .BaudRate = 9600, _
                                                 .StopBits = IO.Ports.StopBits.One, _
                                                 .Parity = IO.Ports.Parity.None, _
                                                 .DataLen = 8, _
                                                  .protokol_type = eProtokolType.DCON})

                opros.SendComand(New s_command With {.rec = "", _
                                                  .send = DIO_OneOut_Cmd(rw.ADRESS(0), 2, 1), _
                                                  .removeCS = True, _
                                                  .timeout = 300, _
                                                  .checksum = True, _
                                                  .count = 3, _
                                                  .PreviousDelay = 1, _
                                                  .SendVbCr = True, _
                                                  .ParamArray = New String() {">"}, _
                                                  .BaudRate = 9600, _
                                                  .StopBits = IO.Ports.StopBits.One, _
                                                  .Parity = IO.Ports.Parity.None, _
                                                  .DataLen = 8, _
                                                  .protokol_type = eProtokolType.DCON})



            Case eAction.Down
                Debug.Print("angle down")
                opros.SendComand(New s_command With {.rec = "", _
                                                 .send = DIO_OneOut_Cmd(rw.ADRESS(0), 2, 0), _
                                                 .removeCS = True, _
                                                 .timeout = 300, _
                                                 .checksum = True, _
                                                 .count = 3, _
                                                 .PreviousDelay = 10, _
                                                 .SendVbCr = True, _
                                                 .ParamArray = New String() {">"}, _
                                                 .BaudRate = 9600, _
                                                 .StopBits = IO.Ports.StopBits.One, _
                                                 .Parity = IO.Ports.Parity.None, _
                                                 .DataLen = 8, _
                                                  .protokol_type = eProtokolType.DCON})

                opros.SendComand(New s_command With {.rec = "", _
                                                  .send = DIO_OneOut_Cmd(rw.ADRESS(0), 3, 1), _
                                                  .removeCS = True, _
                                                  .timeout = 300, _
                                                  .checksum = True, _
                                                  .count = 3, _
                                                  .PreviousDelay = 1, _
                                                  .SendVbCr = True, _
                                                  .ParamArray = New String() {">"}, _
                                                  .BaudRate = 9600, _
                                                  .StopBits = IO.Ports.StopBits.One, _
                                                  .Parity = IO.Ports.Parity.None, _
                                                  .DataLen = 8, _
                                                  .protokol_type = eProtokolType.DCON})
        End Select

    End Sub


    Public Sub PowerOn()
        opros.SendComand(New s_command With {.rec = "", _
                                                       .send = DIO_OneOut_Cmd(rw.ADRESS(0), 4, 0), _
                                                       .removeCS = True, _
                                                       .timeout = 300, _
                                                       .checksum = True, _
                                                       .count = 3, _
                                                       .PreviousDelay = 10, _
                                                       .SendVbCr = True, _
                                                       .ParamArray = New String() {">"}, _
                                                       .BaudRate = 9600, _
                                                       .StopBits = IO.Ports.StopBits.One, _
                                                       .Parity = IO.Ports.Parity.None, _
                                                       .DataLen = 8, _
                                                        .protokol_type = eProtokolType.DCON})

    End Sub
    Public Sub PowerOff()

        opros.SendComand(New s_command With {.rec = "", _
                                                 .send = DIO_OneOut_Cmd(rw.ADRESS(0), 4, 1), _
                                                 .removeCS = True, _
                                                 .timeout = 300, _
                                                 .checksum = True, _
                                                 .count = 3, _
                                                 .PreviousDelay = 10, _
                                                 .SendVbCr = True, _
                                                 .ParamArray = New String() {">"}, _
                                                 .BaudRate = 9600, _
                                                 .StopBits = IO.Ports.StopBits.One, _
                                                 .Parity = IO.Ports.Parity.None, _
                                                 .DataLen = 8, _
                                                  .protokol_type = eProtokolType.DCON})
    End Sub

End Class






