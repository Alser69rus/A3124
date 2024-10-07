Imports System.Threading

Public Class clSMSD42

    Private WithEvents port As IO.Ports.SerialPort

    Public Event FinishThread()

    Private _continue As Boolean

    Private DataRefreshEvents As New ManualResetEvent(True)

    Public Structure smsd_command
        Dim rec As String
        Dim send As String
        Dim timeout As Integer
        Dim PreviousDelay As Integer
        Dim endchar As Char
        Dim [ParamArray] As String()
    End Structure

    Private arraySendCommand As New ArrayList

    Public Sub SendComand(ByVal value As String())

        SyncLock arraySendCommand

            Dim rec As String
            For Each Val As String In value
                arraySendCommand.Add(New smsd_command With {.endchar = "*", .ParamArray = New String() {"E10"}, .PreviousDelay = 25, _
                                      .send = Val, .timeout = 300, .rec = rec})


            Next

            DataRefreshEvents.Set()

        End SyncLock

    End Sub

    Dim thread As Thread

    Public Sub New(ByVal portname As String)
        port = New System.IO.Ports.SerialPort(portname)

        Try

            With port
                .BaudRate = 9600
                .DataBits = 8
                .Parity = IO.Ports.Parity.Even
                .StopBits = 1
                .Handshake = IO.Ports.Handshake.None
            End With

            port.ReadBufferSize = 1000
            port.ReceivedBytesThreshold = 1


            port.Open()

            _continue = True

            thread = New Threading.Thread(AddressOf thread_sendrec_cmd)
            Thread.Priority = Threading.ThreadPriority.Lowest
            Thread.Name = "opros"
            Thread.Start()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub Ended()
        _continue = False
        DataRefreshEvents.Set()
    End Sub

    Private Sub thread_sendrec_cmd()


        'Dim rec As String = ""
        Dim pause As Integer = 50
        'Dim begin As Integer
        'Dim ending As Integer
        Dim cnt As Integer = 0
        'Dim local_begin As Integer

        Dim period_T_Air As Date = Now


        If port IsNot Nothing Then
            If port.IsOpen = True Then

                While (_continue)

                    
                    pause = 10

                    DataRefreshEvents.Reset()
                    DataRefreshEvents.WaitOne()



                    Dim cmds() As smsd_command



                    If arraySendCommand.Count > 0 Then

                        SyncLock arraySendCommand
                            ReDim cmds(arraySendCommand.Count - 1)
                            arraySendCommand.CopyTo(cmds)

                            arraySendCommand.Clear()
                            pause = 10
                        End SyncLock


                        If cmds IsNot Nothing Then
                            If cmds.Length > 0 Then
                                For i As Integer = 0 To cmds.GetUpperBound(0)

                                    With CType(cmds(i), smsd_command)



                                        Dim rec As String = ""

                                        If SendRec(rec, .send, .timeout, .PreviousDelay, .endchar, .ParamArray) Then
                                            Dim bb As Boolean = False
                                            'здесь обработка специфичных команд!!!!!
                                        End If

                                    End With

                                Next
                            End If

                            cmds = Nothing
                        End If

                    End If



                    'mSleep(pause)



                        'If log.EnableLog Then
                        '    log.Write(Ip.GetValue(0).ToString & vbTab & _
                        '    Up.GetValue(0).ToString & vbTab & _
                        '    Ffp.GetValue(0).ToString & vbTab & _
                        '    Fzp.GetValue(0).ToString & vbTab & _
                        '    Ampl.GetValue(0).ToString & vbTab & _
                        '    Angle.GetValue(0).ToString & vbTab & _
                        '    Tsredi.GetValue(0).ToString & vbTab & _
                        '    Tgidro.GetValue(0).ToString)

                        'End If

                End While

            End If
        End If


        RaiseEvent FinishThread()


    End Sub



    ''' <summary>
    ''' процедура чтения записи по последовательному порту
    ''' Rec - принятая строка
    ''' Send - отправляемая строка
    ''' TimeOut - тайм аут на прием
    ''' CheckSum - контрольная сумма
    ''' Count - количество попыток посылок
    ''' SendVBCr - отправлять ли VbCr
    ''' Contain - список допустимых ответов на запрос
    ''' </summary>
    ''' <param name="Rec"></param>
    ''' <param name="Send"></param>
    ''' <param name="TimeOut"></param>
    ''' <param name="Contain"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Overloads Function SendRec(ByRef Rec As String, _
                                ByVal Send As String, _
                                ByRef TimeOut As Integer, _
                                ByVal PreviusDelay As Integer, _
                                ByVal EndChar As Char, _
                                ByVal ParamArray Contain() As String) As Boolean



        If port IsNot Nothing Then
            If port.IsOpen Then


                SendRec = False

                Dim TimeStart As Integer = Environment.TickCount


                'Port.Encoding = System.Text.Encoding.GetEncoding(1251)


                If port.IsOpen = True Then




                    port.DiscardOutBuffer()
                    port.DiscardInBuffer()


                    Threading.Thread.Sleep(PreviusDelay)
                    port.Write(Send)



                    Do While port.BytesToWrite > 0
                    Loop

                    TimeStart = Environment.TickCount

                    Rec = ""

                    'reception
                    Do While (Environment.TickCount - TimeStart) < TimeOut
                        If port.BytesToRead <> Nothing Then
                            If port.BytesToRead > 0 Then
                                Dim ich As Integer = port.ReadChar
                                Dim recchar As Char = ChrW(ich)
                                'log.Write(recchar)
                                'Debug.Write(recchar)
                                If (recchar = EndChar) Then
                                    'пришел CRLF проверяем на наличие ответа
                                    If Rec.Length > 2 Then

                                        For Each vl As String In Contain
                                            If Rec.IndexOf(vl) <> -1 Then
                                                'Debug.WriteLine("TimeOut - " & (Environment.TickCount - TimeStart).ToString)
                                                Return True
                                            End If
                                        Next

                                    End If
                                Else
                                    Rec &= recchar
                                End If

                            End If
                        End If
                    Loop
                    'reception
                End If

                Debug.WriteLine("TimeOut - " & (Environment.TickCount - TimeStart).ToString & " " & Send)


                Return False
            Else
                Return False
            End If
        Else
            Return False
        End If

    End Function

End Class
