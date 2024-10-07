Option Explicit On


Imports System.Math
Imports System.Runtime.InteropServices
Imports System.Threading

Imports System.ComponentModel
Imports clTreeView


''' <summary>
''' Управляет состоянием двигателей создается при запуске программы 
''' </summary>
''' <remarks></remarks>
Public Class CRotationEx
    Implements IDisposable

    Public Nd As Single = 0
    Public Iovd As Single = 0

    Public Umvz As Single = 0
    Public Umvz_Max As Single = 600

    Public Iovtg As Single = 0
    Public Iovsn As Single = 0


    Public Id_Max As Integer = 200
    Public Ud_Max As Integer = 450
    Public Iovd_Max As Integer = 25
    Public Iovtg_Max As Integer = 200
    Public Iovsn_Max As Integer = 100

    Private dT_Iovd As New TimeSpan(0)
    Private dT_Nd As New TimeSpan(0)
    Private dT_Iovtg As New TimeSpan(0)
    Private dT_Iovsn As New TimeSpan(0)

    Public Ivg As Integer = 180
    Public Ivg_Max As Integer = 250
    Public Itg As Integer = 2400
    Public Itg_Max As Integer = 3600


    Private old_time As DateTime = Now


    Public Sub SetRegimParametrs(ByVal _Nd As Single, _
                                 ByVal _Iovd As Single, _
                                 ByVal _Iovtg As Single, _
                                 ByVal _Iovsn As Single, _
                                 Optional ByVal _Id_max As Integer = 200, _
                                 Optional ByVal _Ud_max As Integer = 450, _
                                 Optional ByVal _Iovd_max As Integer = 25, _
                                 Optional ByVal _Iovsn_max As Integer = 100, _
                                 Optional ByVal _Iovtg_max As Integer = 200, _
                                 Optional ByVal _Itg As Integer = 0, _
                                 Optional ByVal _Itg_max As Integer = 3600, _
                                 Optional ByVal _Ivg As Integer = 0, _
                                 Optional ByVal _Ivg_max As Integer = 250, _
                                 Optional ByVal _Umvz As Single = 0, _
                                 Optional ByVal _Umvz_Max As Single = 600)
        SyncLock Me

            Nd = _Nd
            Iovd = _Iovd
            Iovtg = _Iovtg
            Iovsn = _Iovsn

            Ivg = _Ivg
            Itg = _Itg
            Ivg_Max = _Ivg_max
            Itg_Max = _Itg_max


            Id_Max = _Id_max
            Ud_Max = _Ud_max
            Iovd_Max = _Iovd_max
            Iovtg_Max = _Iovtg_max
            Iovsn_Max = _Iovsn_max

            'calculateN = New clNnom(_Ud, _Iovd)

        End SyncLock


    End Sub

    'Public RotationEvents As New ManualResetEvent(True)

    ''' <summary>
    ''' Останавливает поток управления вращением после обработки
    ''' обновленных данных (Ud,Id,Nd,Ilp,Uvdp,Состояние контакторов) до их следующего
    ''' обновления
    ''' </summary>
    ''' <remarks>Данные обновляются в классе CStend в процедуре RefreshSostoyanieEX</remarks>
    Public DataRefreshEvents As New ManualResetEvent(True)

    ''' <summary>
    ''' Описывает состояние двигателей
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum eStatusRotation
        Разгон
        Остановка
        СвободноеВращение
    End Enum

    'Основной поток который создается при создании класса
    'когда двигатели остановлены и схема разобрана поток находится в состоянии Sleep
    'поток пробуждается при входе в режим автоматического управления вращением двигателей
    '
    Private ThreadRotation As Thread

    Public Sub New(ByVal _Stend As clStend)
        Stend = _Stend
        ThreadRotation = New Thread(AddressOf Me.ThreadRotationStart)
        ThreadRotation.Name = "ThreadRotation"
        mfExit = False
        Try
            ThreadRotation.Start()
        Catch ex As Exception
            Debug.Assert(ex.Message)
        End Try

    End Sub

    Private Stend As clStend


    ''' <summary>
    ''' Таймер контролирующий неуправляемое вращение когда он достигнет величины 30000 (30 секунд)
    ''' произойдет автоматическая остановка двигателя
    ''' чтобы этого не произошло управляющий поток должен скидывать этот таймер в 0
    ''' </summary>
    ''' <remarks></remarks>
    Private WatchDogTimer As New CWatchDogTimer

    Private mfExit As Boolean = False           'если TRUE то безусловно выходим из процедуры не дожидаясь остановки двигателя

    Public EnableAutoRotation As Boolean = True

    Private mCheckManager As CCheckManager


    'Public calculateN As New clNnom(1500, 480)

    Public Property CheckManager() As CCheckManager
        Get
            Return mCheckManager
        End Get
        Set(ByVal Value As CCheckManager)
            mCheckManager = Value
        End Set
    End Property




    Private old_StatusRotation As eStatusRotation = eStatusRotation.СвободноеВращение
    Public StatusRotation As eStatusRotation = eStatusRotation.СвободноеВращение

    Public Sub SetRegim(ByVal value As eStatusRotation)
        SyncLock Me
            dT_Iovd = New TimeSpan(0)
            dT_Nd = New TimeSpan(0)
            dT_Iovsn = New TimeSpan(0)
            dT_Iovtg = New TimeSpan(0)
            StatusRotation = value
        End SyncLock
    End Sub

    Public Enum eRegimMVZ
        Статор1 = 1
        Статор2 = 2
        Статор3 = 3
        Статор4 = 4
        Статор5 = 5
    End Enum

    Private AcselerationUmvz As Single = 1.0
    ''' <summary>
    '''предел темпа набора Uмвз генератора A/c
    ''' </summary>
    ''' <param name="value"></param>
    ''' <remarks></remarks>
    Public Sub SetAcselerationUmvz(ByVal value As Single)
        AcselerationUmvz = value
    End Sub

    Private temp_umvz As Single = 1.0
    ''' <summary>
    ''' постоянная времени набора напряжения мвз- в секундах (дискреты фазарегулятора в секунду)
    ''' </summary>
    ''' <param name="Value"></param>
    ''' <remarks></remarks>
    Public Sub SetTempUmvz(ByVal Value As Single)
        temp_umvz = Value
    End Sub


    Private regim_mvz As eRegimMVZ = eRegimMVZ.Статор1

    Public Property RegimMVZ() As eRegimMVZ
        Get
            Return regim_mvz
        End Get
        Set(ByVal value As eRegimMVZ)
            regim_mvz = value
        End Set
    End Property



    Private AcselerationItg As Single = 1.0
    ''' <summary>
    '''предел темпа набора тока тягового генератора A/c
    ''' </summary>
    ''' <param name="value"></param>
    ''' <remarks></remarks>
    Public Sub SetAcselerationItg(ByVal value As Single)
        AcselerationIvg = value
    End Sub

    Private temp_itg As Single = 1.0
    ''' <summary>
    ''' постоянная времени набора ока тягового генератоhа - в секундах (дискреты фазарегулятора в секунду)
    ''' </summary>
    ''' <param name="Value"></param>
    ''' <remarks></remarks>
    Public Sub SetTempItg(ByVal Value As Single)
        temp_itg = Value
    End Sub

    '++

    Private AcselerationIvg As Single = 1.0
    ''' <summary>
    '''предел темпа набора тока вспомогательного генератора A/c
    ''' </summary>
    ''' <param name="value"></param>
    ''' <remarks></remarks>
    Public Sub SetAcselerationIvg(ByVal value As Single)
        AcselerationIvg = value
    End Sub

    Private temp_ivg As Single = 1.0
    ''' <summary>
    ''' постоянная времени набора ока вспомогательного генератоhа - в секундах (дискреты фазарегулятора в секунду)
    ''' </summary>
    ''' <param name="Value"></param>
    ''' <remarks></remarks>
    Public Sub SetTempIvg(ByVal Value As Single)
        temp_ivg = Value
    End Sub



    Private AcselerationIovd As Single = 1.0
    ''' <summary>
    '''предел темпа набора тока двигателя A/c
    ''' </summary>
    ''' <param name="value"></param>
    ''' <remarks></remarks>
    Public Sub SetAcselerationIovd(ByVal value As Single)
        AcselerationIovd = value
    End Sub

    Private temp_iovd As Single = 1.0
    ''' <summary>
    ''' постоянная времени набора тока двигателя - в секундах (дискреты фазарегулятора в секунду)
    ''' </summary>
    ''' <param name="Value"></param>
    ''' <remarks></remarks>
    Public Sub SetTempIovd(ByVal Value As Single)
        temp_iovd = Value
    End Sub

    Private AcselerationUd As Single = 1.0
    ''' <summary>
    '''предел темпа набора напряжения двигателя В/c
    ''' </summary>
    ''' <param name="value"></param>
    ''' <remarks></remarks>
    Public Sub SetAcselerationUd(ByVal value As Single)
        AcselerationUd = value
    End Sub

    Private temp_ud As Single = 1.0
    ''' <summary>
    ''' постоянная времени набора напряжения двигателя - в секундах (дискреты фазарегулятора в секунду)
    ''' </summary>
    ''' <param name="Value"></param>
    ''' <remarks></remarks>
    Public Sub SetTempUd(ByVal Value As Single)
        temp_ud = Value
    End Sub

    '''''
    Private AcselerationNd As Single = 1.0
    ''' <summary>
    '''предел темпа набора напряжения двигателя В/c
    ''' </summary>
    ''' <param name="value"></param>
    ''' <remarks></remarks>
    Public Sub SetAcselerationNd(ByVal value As Single)
        AcselerationNd = value
    End Sub

    Private temp_nd As Single = 1.0
    ''' <summary>
    ''' постоянная времени набора напряжения двигателя - в секундах (дискреты фазарегулятора в секунду)
    ''' </summary>
    ''' <param name="Value"></param>
    ''' <remarks></remarks>
    Public Sub SetTempNd(ByVal Value As Single)
        temp_nd = Value
    End Sub

    'Массив результатов испытаний 

    Private Blocker As New CWatchDogTimer(5000) 'Таймер будет установлен через 5 секунд после сброса


    Private Sub ThreadRotationStart()

        Do Until mfExit
            'проверяем что никто не пытается остановить поток управления вращением
            'остановка потока происходит в том случае если двигатели не вращаются и 
            'схема разобрана

            Try
                If mfExit = True Then
                    Exit Do
                End If

                'проверяем что управляющий процесс контролирует вращение и если обнаруживаем что нет
                'снимаем напряжение и разбираем схему
                '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
                If WatchDogTimer.Status = True Then

                End If
                '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


                If Stend Is Nothing Then
                    Exit Do
                End If

                'останавливаем поток до тех пор пока данные не обновятся
                'обновление данных происходит в классе CStend в процедуре RefreshSostoyanieEX
                'если в течении 1000 миллисекунд данные не обновятся то разрешаем потоку
                'выполнить одну итерацию цикла, для опроса сторожевого таймера
                DataRefreshEvents.WaitOne(10000, False)
                If mfExit = True Then
                    Exit Do
                End If

                'Выполняем управление двигателями 

                'calculateN.Add(Stend.opros.Ud.GetValue(1), Stend.opros.Id.GetValue(1), Stend.opros.Nd.GetValue(0))

                If EnableAutoRotation Then
                    Select Case StatusRotation
                        Case eStatusRotation.Разгон
                            Разгон()
                        Case eStatusRotation.Остановка
                            Остановка()
                        Case eStatusRotation.СвободноеВращение
                            СвободноеВращение()
                    End Select
                End If


                DataRefreshEvents.Reset()


                If old_StatusRotation <> Me.StatusRotation Then
                    old_StatusRotation = Me.StatusRotation

                End If

                dT_Iovd = dT_Iovd.Add(Now.Subtract(old_time))
                dT_Nd = dT_Nd.Add(Now.Subtract(old_time))
                dT_Iovsn = dT_Iovsn.Add(Now.Subtract(old_time))
                dT_Iovtg = dT_Iovtg.Add(Now.Subtract(old_time))

                old_time = Now

            Catch ex As Exception
                'MessageBox.Show(ex.Message)
                Debug.Write(ex.Message)
            End Try



        Loop  '

    End Sub

    Private Sub Остановка()

        'If Stend.opros.Nd.GetValue(0) > 300 Then
        '    Stend.opros.reg_ud.SetValue(0, True)
        '    'Stend.opros.reg_iovd.IncrementValue(-2)
        '    Stend.opros.reg_iovtg.IncrementValue(-20)
        '    Stend.opros.reg_iovsn.IncrementValue(-2)
        'ElseIf Stend.opros.Nd.GetValue(0) > 0 Then

        '    Stend.opros.reg_ud.IncrementValue(-20)
        '    Stend.opros.reg_iovd.IncrementValue(-20)
        '    Stend.opros.reg_iovtg.IncrementValue(-20)
        '    Stend.opros.reg_iovsn.IncrementValue(-2)

        'End If

        'If Stend.opros.reg_ud.GetValue() = 0 And _
        '    Stend.opros.reg_iovd.GetValue() = 0 And _
        '    Stend.opros.reg_iovtg.GetValue() = 0 And _
        '    Stend.opros.reg_iovsn.GetValue() = 0 Then

        '    StatusRotation = eStatusRotation.СвободноеВращение

        'End If

        dT_Iovd = New TimeSpan(0)
        dT_Nd = New TimeSpan(0)
        dT_Iovsn = New TimeSpan(0)
        dT_Iovtg = New TimeSpan(0)

    End Sub

    Private Sub СвободноеВращение()
        dT_Iovd = New TimeSpan(0)
        dT_Nd = New TimeSpan(0)
        dT_Iovsn = New TimeSpan(0)
        dT_Iovtg = New TimeSpan(0)
    End Sub

    Private Sub Разгон()
        Dim val As Integer

        'If Iovd > 0 Then Stend.opros.reg_iovd.IncrementValue(РегуляторIovd)
        'If Nd > 0 Then
        '    val = РегуляторUd()
        '    Stend.opros.reg_ud.IncrementValue(val)
        'End If

        If Ivg > 0 Then
            'val = РегуляторОВ_If(Stend.opros.Ivg, Ivg, AcselerationIvg, temp_ivg, 20, dT_Iovsn)
            'Stend.opros.reg_iovsn.IncrementValue(val)
        ElseIf Umvz > 0 Then


            Select Case RegimMVZ
                Case eRegimMVZ.Статор1, eRegimMVZ.Статор2
                    Dim max As Integer = 5

                    'If Stend.opros.Iovtg.GetValue(1) > 3 Then
                    '    max = 1
                    'End If

                    'val = РегуляторОВ_If(Stend.opros.Umvz, Umvz, AcselerationUmvz, temp_umvz, max, dT_Iovsn)

                    'If CheckLim(Stend.opros.Nd.GetValue(0), Nd, 2) = True Then
                    '    Stend.opros.reg_iovtg.IncrementValue(val)
                    '    Debug.Write(" +")
                    'End If

                Case Else
                    'val = РегуляторОВ_If(Stend.opros.Umvz, Umvz, AcselerationUmvz, temp_umvz, 20, dT_Iovsn)
                    'Stend.opros.reg_iovsn.IncrementValue(val)
            End Select

        ElseIf Iovsn > 0 Then
            val = РегуляторОВВГ_Simple()
            'Stend.opros.reg_iovsn.IncrementValue(val)
        End If

        If Itg > 0 Then
            Dim max As Integer = 10

            'If Stend.opros.Iovtg.GetValue(1) > 90 Then
            '    max = 3
            'End If

            'val = РегуляторОВ_If(Stend.opros.Itg, Itg, AcselerationItg, temp_itg, max, dT_Iovtg)

            'Stend.opros.reg_iovtg.IncrementValue(val)
        ElseIf Iovtg > 0 Then

            Dim max As Integer = 10

            'If Stend.opros.Iovtg.GetValue(1) > 90 Then
            '    max = 3
            'End If

            'val = РегуляторОВ_If(Stend.opros.Iovtg, Iovtg, 1, 1, max, dT_Iovtg)

            'Stend.opros.reg_iovtg.IncrementValue(val)

        End If

    End Sub


    ''' <summary>
    ''' Возвращает приращение для фазарегулятора ОВД
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function РегуляторIovd() As Integer

        Dim _iovd As Single '= Stend.opros.Iovd.GetValue(1)
        Dim _iovd_accseleration As Single '= Stend.opros.Iovd.GetAcseleration
        Dim _dt As Single = dT_Iovd.TotalSeconds * temp_iovd
        Dim _dt1 As Single = dT_Iovd.TotalSeconds

        Dim itemp As Integer = 0
        Dim pset As Integer = 0



        If _iovd < (0.8 * Iovd) Then
            pset = 1
            'If dT_Id.TotalSeconds > 1 Then
            'If _iovd_accseleration < AcselerationIovd Then
            itemp = _dt '/ 2
            If itemp < 1 Then itemp = 1
            If itemp > 10 Then itemp = 10
            'End If
            dT_Iovd = New TimeSpan(0)
            'End If
        ElseIf _iovd < (0.9 * Iovd) Then
            pset = 2
            'If dT_Id.TotalSeconds > 1 Then
            'If _iovd_accseleration < AcselerationIovd Then
            itemp = _dt / 2
            'itemp = 1
            If itemp < 1 Then itemp = 1
            If itemp > 10 Then itemp = 10
            'End If
            dT_Iovd = New TimeSpan(0)
            'End If
        ElseIf _iovd < 0.97 * Iovd Then
            pset = 3

            If dT_Iovd.TotalSeconds >= 2 Then
                'If _iovd_accseleration < AcselerationIovd Then
                itemp = 1
                'Stend.opros.VDP.IncrementValue(itemp)
                'End If
                dT_Iovd = New TimeSpan(0)
            End If

        ElseIf _iovd < Iovd Then
            pset = 4

            If dT_Iovd.TotalSeconds >= 5 Then
                'If _iovd_accseleration < AcselerationIovd Then
                itemp = 1
                'Stend.opros.VDP.IncrementValue(itemp)
                'End If
                dT_Iovd = New TimeSpan(0)
            End If

        End If

        If _iovd > (Iovd * 1.2) Then
            pset = -1
            'If dT_Id.TotalSeconds > 1 Then
            'If _iovd_accseleration < AcselerationIovd Then
            itemp = _dt '/ 2
            If itemp < 1 Then itemp = 1
            If itemp > 10 Then itemp = 10
            'End If
            dT_Iovd = New TimeSpan(0)
            'End If

            itemp = (-itemp)

        ElseIf _iovd > (Iovd * 1.1) Then
            pset = -2
            'If dT_Id.TotalSeconds > 1 Then
            'If _iovd_accseleration < AcselerationIovd Then
            itemp = _dt / 2
            'itemp = 1
            If itemp < 1 Then itemp = 1
            If itemp > 10 Then itemp = 10
            'End If
            dT_Iovd = New TimeSpan(0)
            'End If
            itemp = (-itemp)
        ElseIf _iovd > Iovd * 1.03 Then
            pset = -3

            If dT_Iovd.TotalSeconds >= 2 Then
                'If _iovd_accseleration < AcselerationIovd Then
                itemp = -1
                'Stend.opros.VDP.IncrementValue(itemp)
                'End If
                dT_Iovd = New TimeSpan(0)
            End If


        ElseIf _iovd > Iovd Then
            pset = -4
            If dT_Iovd.TotalSeconds >= 5 Then
                'If _iovd_accseleration < AcselerationIovd Then
                itemp = -1
                'Stend.opros.VDP.IncrementValue(itemp)
                'End If
                dT_Iovd = New TimeSpan(0)
            End If
        End If


        Debug.Write("Iovd" & vbTab _
                    & "inc=" & itemp.ToString & vbTab _
                    & "a=" & _iovd_accseleration.ToString("f1") & vbTab _
                    & "Id=" & _iovd.ToString("f1") & vbTab _
                    & "dT=" & _dt1 & vbTab _
                    & "pset=" & pset.ToString & vbTab)

        Return itemp
    End Function

    ''' <summary>
    ''' Возвращает приращение для фазарегулятора Ud в зависимости от оборотов двигателя
    ''' с ограничением по току двигатея и напряжению двигателя
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function РегуляторUd() As Integer
        Dim _ud As Single ' = Stend.opros.Ud.GetValue(0)
        Dim _nd As Single '= Stend.opros.Nd.GetValue(0)
        Dim _nd_accseleration As Single '= Stend.opros.Nd.GetAcseleration()
        Dim _dt As Single = dT_Nd.TotalSeconds * temp_nd
        Dim _dt1 As Single = dT_Nd.TotalSeconds
        Dim _id As Single ' = Stend.opros.Id.GetValue(0)

        Dim inc_max As Integer = 10
        Dim dinc As Single ' = (Id_Max - _id)

        If dinc <= 0 Then
            dinc = 0.1
        Else
            dinc /= Id_Max
        End If

        inc_max = inc_max * dinc

        Dim itemp As Integer = 0
        Dim pset As Integer = 0

        If inc_max > 10 Then inc_max = 10

        'набор U

        If _nd < Nd Then

            If _id < Id_Max And _ud < Ud_Max Then

                If _nd < (0.6 * Nd) Then
                    'If dT_Ud.TotalSeconds > 1 Then
                    pset = 1

                    If _nd_accseleration <= AcselerationNd Then
                        itemp = _dt
                        If itemp < 1 Then itemp = 1
                        If itemp > inc_max Then itemp = inc_max

                        If _id > 0.9 * Id_Max Then
                            itemp = 1
                        End If
                    End If

                    dT_Nd = New TimeSpan(0)

                    'End If
                ElseIf _nd < (0.8 * Nd) Then
                    pset = 2
                    'If dT_Ud.TotalSeconds > 1 Then
                    If _nd_accseleration <= AcselerationNd Then
                        itemp = _dt / 2
                        If itemp < 1 Then itemp = 1
                        If itemp > inc_max Then itemp = inc_max
                        If _id > 0.9 * Id_Max Then
                            itemp = 1
                        End If
                    End If
                    dT_Nd = New TimeSpan(0)
                    'End If
                ElseIf _nd < (0.95 * Nd) Then
                    pset = 3

                    'If dT_Nd.TotalSeconds > 2 Then

                    If _nd_accseleration <= AcselerationNd Then
                        'itemp = _dt / 4
                        'If itemp < 1 Then itemp = 1
                        'If itemp > 10 Then itemp = 10
                        'If _id > 0.9 * Id_Max Then
                        itemp = 1
                        'End If
                        'End If

                        dT_Nd = New TimeSpan(0)

                    End If
                ElseIf _nd < (Nd * 0.99) Then
                    pset = 4

                    If dT_Nd.TotalSeconds >= 2 Then

                        If _nd_accseleration <= 0 Then
                            'itemp = _dt / 4
                            'If itemp < 1 Then itemp = 1
                            'If itemp > 10 Then itemp = 10
                            'If _id > 0.9 * Id_Max Then
                            itemp = 1
                            'End If
                        End If

                        dT_Nd = New TimeSpan(0)


                    End If

                ElseIf _nd < (Nd - 2) Then

                    pset = 5

                    If dT_Nd.TotalSeconds > 4 Then

                        If _nd_accseleration <= 0 Then
                            itemp = 1
                        End If

                        dT_Nd = New TimeSpan(0)
                    End If

                End If

            Else

                dT_Nd = New TimeSpan(0)

            End If

        End If


        If _nd > Nd Then

            If _nd > (1.2 * Nd) Then
                pset = -2
                'If dT_Ud.TotalSeconds > 1 Then
                'If _nd_accseleration > 0 Then
                itemp = _dt / 2
                If itemp < 1 Then itemp = 1
                If itemp > 10 Then itemp = 10

                itemp = (-itemp)
                'End If
                dT_Nd = New TimeSpan(0)
                'End If
            ElseIf _nd > (1.05 * Nd) Then
                pset = -3

                If dT_Nd.TotalSeconds > 2 Then

                    If _nd_accseleration >= 0 Then
                        'itemp = _dt / 4
                        'If itemp < 1 Then itemp = 1
                        'If itemp > 10 Then itemp = 10
                        'If _id > 0.9 * Id_Max Then
                        itemp = -1
                        'End If
                    End If

                    dT_Nd = New TimeSpan(0)

                End If

            ElseIf _nd > (Nd * 1.01) Then

                pset = -4

                If dT_Nd.TotalSeconds > 2 Then

                    If _nd_accseleration >= 0 Then
                        itemp = -1
                    End If

                    dT_Nd = New TimeSpan(0)
                End If

            ElseIf _nd > (Nd + 2) Then

                pset = -5

                If dT_Nd.TotalSeconds > 4 Then

                    If _nd_accseleration >= 0 Then
                        itemp = -1
                    End If

                    dT_Nd = New TimeSpan(0)
                End If

            End If


        End If



        Debug.Write("Ud" & vbTab _
                    & "inc=" & itemp.ToString & vbTab _
                    & "incmax=" & inc_max & vbTab _
                    & "a=" & _nd_accseleration.ToString() & vbTab _
                    & "Nd=" & _nd.ToString() & vbTab _
                    & "Id=" & _id.ToString() & vbTab _
                    & "Ud=" & _ud.ToString() & vbTab _
                    & "dT=" & _dt1 & vbTab _
                    & "pset=" & pset.ToString & vbTab & vbCrLf)

        Return itemp
    End Function
    ''' <summary>
    ''' Возвращает приращение для фазарегулятора ОВ вспомогательного генератора
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function РегуляторОВ_If(ByVal pribor As clSimplePribor, _
                                      ByVal par_zadan As Single, _
                                      ByVal par_acsel_zadan As Single, _
                                      ByVal par_temp As Single, ByVal inc_max As Integer, ByRef dT As TimeSpan) As Integer

        Dim _dt As Single = dT.TotalSeconds * par_temp
        Dim _dt1 As Single = dT.TotalSeconds
        Dim _id As Single '= Stend.opros.Id.GetValue(0)

        Dim first_incmax As Integer = inc_max


        Dim dinc As Single '= (Id_Max - _id)

        If dinc <= 0 Then
            dinc = 0.1
        Else
            dinc /= Id_Max
        End If

        inc_max = inc_max * dinc

        Dim itemp As Integer = 0
        Dim pset As Integer = 0

        If inc_max > first_incmax Then inc_max = first_incmax
        If inc_max < 1 Then inc_max = 1

        'набор Iovsn

        If pribor.GetValue(0) < par_zadan Then

            If _id < Id_Max Then

                If pribor.GetValue(0) < (0.6 * par_zadan) Then
                    'If dT_Ud.TotalSeconds > 1 Then
                    pset = 1

                    If pribor.GetAcseleration < par_acsel_zadan Then
                        itemp = _dt
                        If itemp < 1 Then itemp = 1
                        If itemp > inc_max Then itemp = inc_max

                        'If _id > 0.9 * Id_Max Then
                        '    itemp = 1
                        'End If
                    End If

                    dT = New TimeSpan(0)

                    'End If
                ElseIf pribor.GetValue(0) < (0.9 * par_zadan) Then
                    pset = 2
                    'If dT_Ud.TotalSeconds > 1 Then
                    If pribor.GetAcseleration < par_acsel_zadan Then
                        itemp = _dt / 2
                        If itemp < 1 Then itemp = 1
                        If itemp > inc_max Then itemp = inc_max
                        'If _id > 0.9 * Id_Max Then
                        '    itemp = 1
                        'End If
                    End If
                    dT = New TimeSpan(0)
                    'End If
                ElseIf pribor.GetValue(0) < (0.99 * par_zadan) Then
                    pset = 3

                    'If dT.TotalSeconds > 2 Then

                    'If par_acsel < 0 Then
                    'itemp = _dt / 4

                    itemp = 3

                    If itemp < 1 Then itemp = 1
                    If itemp > inc_max Then itemp = inc_max
                    'If _id > 0.9 * Id_Max Then
                    '    itemp = 1
                    'End If

                    'End If
                    'End If

                    dT = New TimeSpan(0)

                    'End If

                ElseIf pribor.GetValue(0) < (par_zadan - 1) Then

                    pset = 4
                    If dT.TotalSeconds > 2 Then

                        'If par_acsel < 0 Then
                        itemp = 1
                        'End If

                        dT = New TimeSpan(0)
                    End If

                End If

            Else

                dT = New TimeSpan(0)

            End If

        End If


        If pribor.GetValue(0) > par_zadan Then

            If pribor.GetValue(0) > (1.2 * par_zadan) Then
                pset = -2
                'If dT_Ud.TotalSeconds > 1 Then
                'If _nd_accseleration > 0 Then
                itemp = _dt / 2
                If itemp < 1 Then itemp = 1
                If itemp > inc_max Then itemp = inc_max

                itemp = (-itemp)
                'End If
                dT = New TimeSpan(0)
                'End If
            ElseIf pribor.GetValue(0) > (1.01 * par_zadan) Then
                pset = -3

                'If dT.TotalSeconds > 2 Then

                'If par_acsel > 0 Then
                'itemp = _dt / 4
                'If itemp < 1 Then itemp = 1
                'If itemp > 10 Then itemp = 10
                'If _id > 0.9 * Id_Max Then
                itemp = 3

                If itemp > inc_max Then itemp = inc_max
                itemp = (-itemp)

                'End If
                'End If

                dT = New TimeSpan(0)

                'End If

            ElseIf pribor.GetValue(0) > (par_zadan + 1) Then

                pset = -4

                If dT.TotalSeconds > 2 Then

                    'If par_acsel > 0 Then
                    itemp = -1
                    'End If

                    dT = New TimeSpan(0)
                End If

            End If


        End If



        Debug.Write("par_zadan" & vbTab _
                    & "inc=" & itemp.ToString & vbTab _
                    & "incmax=" & inc_max & vbTab _
                    & "a=" & pribor.GetAcseleration.ToString() & vbTab _
                    & "par_zadan=" & pribor.GetValue(0).ToString() & vbTab _
                    & "Id=" & _id.ToString() & vbTab _
                    & "dT=" & _dt1 & vbTab _
                    & "pset=" & pset.ToString & vbTab & vbCrLf)

        Return itemp
    End Function



    ''' <summary>
    ''' Возвращает приращение для фазарегулятора ОВ вспомогательного генератора
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function РегуляторОВВГ_Simple() As Integer

        Dim _Iovsn As Single '= Stend.opros.Iovsn.GetValue(0)

        'Dim _Ivsn_accseleration As Single '= Stend.opros.If3w.GetAcseleration()
        'Dim _dt As Single = dT_Iovsn.TotalSeconds * temp_iovsn
        Dim _dt1 As Single = dT_Iovsn.TotalSeconds
        Dim _id As Single '= Stend.opros.Id.GetValue(0)

        Dim inc_max As Integer = 20
        Dim dinc As Single = (Id_Max - _id)

        If dinc <= 0 Then
            dinc = 0.1
        Else
            dinc /= Id_Max
        End If

        inc_max = inc_max * dinc

        Dim itemp As Integer = 0
        Dim pset As Integer = 0

        If inc_max > 20 Then inc_max = 20

        'набор Iovsn

        If _Iovsn < Iovsn Then

            If _id < Id_Max Then

                If _Iovsn < (0.95 * Iovsn) Then

                    pset = 1

                    itemp = 10

                    If _id > 0.9 * Id_Max Then
                        itemp = 2
                    End If


                    dT_Iovsn = New TimeSpan(0)

                ElseIf _Iovsn < (Iovsn * 0.99) Then
                    pset = 2

                    itemp = 5
                    dT_Iovsn = New TimeSpan(0)
                ElseIf _Iovsn < Iovsn Then

                    pset = 3
                    itemp = 1
                    dT_Iovsn = New TimeSpan(0)

                End If

            Else

                dT_Iovsn = New TimeSpan(0)

            End If

        End If


        If _Iovsn > Iovsn Then

            If _id < Id_Max Then

                If _Iovsn > (1.05 * Iovsn) Then

                    pset = -1

                    itemp = -10

                    dT_Iovsn = New TimeSpan(0)

                ElseIf _Iovsn > (Iovsn * 1.01) Then
                    pset = -2

                    itemp = -5
                    dT_Iovsn = New TimeSpan(0)
                ElseIf _Iovsn > (Iovsn) Then
                    pset = -3

                    itemp = -1
                    dT_Iovsn = New TimeSpan(0)
                End If

            Else

                dT_Iovsn = New TimeSpan(0)

            End If

        End If




        Debug.Write("Ivg" & vbTab _
                    & "inc=" & itemp.ToString & vbTab _
                    & "incmax=" & inc_max & vbTab _
                    & "Id=" & _id.ToString() & vbTab _
                    & "dT=" & _dt1 & vbTab _
                    & "pset=" & pset.ToString & vbTab & vbCrLf)

        Return itemp
    End Function



    Private disposed As Boolean = False        ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        'If Not Me.disposed Then
        If disposing Then
            ' TODO: free unmanaged resources when explicitly called
        End If
        'Завершим поток управления вращением
        mfExit = True
        '    If ThreadRotation.ThreadState = ThreadState.WaitSleepJoin Then
        '        'если поток спит то разбудим его
        '        RotationEvents.Set()

        '        'ThreadRotation.Resume()
        '        'ThreadRotation.Abort()
        '        'Debug.Print(ThreadRotation.ThreadState.ToString)
        '        ThreadRotation = Nothing
        '    End If
        'End If
        Me.disposed = True
    End Sub

#Region " IDisposable Support "
    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub

    Protected Overrides Sub Finalize()
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(False)
        MyBase.Finalize()
    End Sub
#End Region

End Class

Public Class CWatchDogTimer

    Public Sub New()
        Me.New(30000)
    End Sub

    Public Sub New(ByVal _Interval As Int32)
        mInterval = _Interval
    End Sub

    Private mInterval As Int32 = 30000 '30 секунд
    Public Property Interval() As Int32
        Get
            Return mInterval
        End Get
        Set(ByVal Value As Int32)
            mInterval = Value
        End Set
    End Property

    Private dPrevMillisecond As DateTime = Now

    Public ReadOnly Property Status() As Boolean
        Get
            Return (Now - dPrevMillisecond).TotalMilliseconds > mInterval
        End Get
    End Property

    Public Sub Reset()
        dPrevMillisecond = Now
    End Sub
End Class

Public Class clNnom
    Private Unom, Inom, N As Single
    Private values As ArrayList

    Private Structure UIN
        Dim U As Single
        Dim I As Single
        Dim N As Single
    End Structure

    Public Sub New(ByVal _Unom As Single, ByVal _Inom As Single)
        Unom = _Unom
        Inom = _Inom
        values = New ArrayList
    End Sub


    Public Sub Add(ByVal _U As Single, ByVal _I As Single, ByVal _N As Single)
        If CheckLim(_U, Unom, 1) = True And CheckLim(_I, Inom, 1) Then
            values.Add(New UIN With {.U = _U, .I = _I, .N = _N})
            Debug.Write("u=" & _U & " i=" & _I & " n=" & _N & vbCrLf)
        End If
    End Sub

    Public Sub Clear()
        values.Clear()
    End Sub

    Public ReadOnly Property GetAvgN() As Single
        Get
            Dim navg As Single = 0

            SyncLock Me


                If values IsNot Nothing Then
                    If values.Count > 0 Then
                        For Each Val As UIN In values
                            navg += Val.N
                        Next

                        navg /= values.Count
                    End If
                End If


                Debug.Write("Navg=" & navg & vbCrLf)

            End SyncLock

            Return navg
        End Get
    End Property

    Public ReadOnly Property GetFormulaN() As Single
        Get
            Dim nformula As Single = 0

            SyncLock Me

                Dim pset1, pset2 As UIN

                pset1.U = 0
                pset2.U = 0

                If values IsNot Nothing Then
                    If values.Count > 1 Then
                        ' Dim k As Single
                        'поиск двух точек у которых u,i,n различаются
                        For Each Val As UIN In values
                            pset1 = Val
                            For Each val2 As UIN In values
                                If val2.U <> pset1.U And val2.I <> pset1.I And val2.N <> pset1.N Then
                                    pset2 = val2
                                    Exit For
                                End If
                            Next
                            If pset2.U <> 0 Then Exit For
                        Next
                        'проверка найденны ли две точки у которых  u,i,n различаются
                        If pset1.U <> pset2.U And pset1.I <> pset2.I And pset1.N <> pset2.N Then
                            If pset1.U <> 0 And pset2.U <> 0 Then
                                'выполним расчет
                                nformula = Unom * pset1.I * pset2.I * (pset1.N - pset2.N)
                                nformula -= Inom * (pset1.N * pset1.I * pset2.U - pset2.N * pset2.I * pset1.U)
                                nformula /= Inom * (pset1.U * pset2.I - pset2.U * pset1.I)
                                Return nformula
                            End If
                        End If


                        'поиск двух точек у которых u,n различаются
                        For Each Val As UIN In values
                            pset1 = Val
                            For Each val2 As UIN In values
                                If val2.U <> pset1.U And val2.N <> pset1.N Then
                                    pset2 = val2
                                    Exit For
                                End If
                            Next
                            If pset2.U <> 0 Then Exit For
                        Next
                        'проверка найденны ли две точки у которых  u,n различаются
                        If pset1.U <> pset2.U And pset1.N <> pset2.N Then
                            If pset1.U <> 0 And pset2.U <> 0 Then
                                'выполним расчет
                                nformula = Unom * pset1.I * (pset1.N - pset2.N)
                                nformula -= Inom * (pset1.N * pset2.U - pset2.N * pset1.U)
                                nformula /= Inom * (pset1.U - pset2.U)
                                Return nformula
                            End If
                        End If

                        'поиск двух точек у которых i,n различаются
                        For Each Val As UIN In values
                            pset1 = Val
                            For Each val2 As UIN In values
                                If val2.I <> pset1.I And val2.N <> pset1.N Then
                                    pset2 = val2
                                    Exit For
                                End If
                            Next
                            If pset2.U <> 0 Then Exit For
                        Next
                        'проверка найденны ли две точки у которых i,n различаются
                        If pset1.I <> pset2.I And pset1.N <> pset2.N Then
                            If pset1.U <> 0 And pset2.U <> 0 Then
                                'выполним расчет
                                nformula = Unom * pset1.I * pset2.I * (pset1.N - pset2.N)
                                nformula -= Inom * pset1.U * (pset1.N * pset1.I - pset2.N * pset2.I)
                                nformula /= Inom * pset1.U * (pset2.I - pset1.I)
                                Return nformula
                            End If
                        End If


                        Return pset1.N
                    Else
                        For Each Val As UIN In values
                            nformula = Val.N
                        Next
                    End If
                End If

            End SyncLock
            
            Return nformula
        End Get
    End Property

End Class



