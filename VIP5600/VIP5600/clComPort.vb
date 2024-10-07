Imports System.Windows.Forms
Imports System
Imports System.IO
Imports System.IO.Ports

Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Globalization

'Imports SmartDeviceProject1


Public Class clComPort

    Implements IDisposable

    'Public log As clLog
    Public WithEvents Port As SerialPort


    Public Sub New(ByVal _SerialPort As SerialPort, ByVal enable_log As Boolean)

        MyBase.New()

        Port = _SerialPort
        'log = New clLog
        'log.EnableLog = enable_log

    End Sub

    Public Enum eProtokol
        ASCII
        BIN
    End Enum

    Private _Protokol As eProtokol = eProtokol.BIN
    ''' <summary>
    ''' выбор режима работы ASCII или BIN
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Protokol() As eProtokol
        Get
            Return _Protokol
        End Get
        Set(ByVal value As eProtokol)
            _Protokol = value
        End Set
    End Property

    ''' <summary>
    ''' разрешает запрещает обработку события на прием данных с СОМ порта
    ''' </summary>
    ''' <remarks></remarks>
    Public EnableEventReceived As Boolean = False

    ''' <summary>
    ''' ответы устройств которые понимаются как ошибочные
    ''' </summary>
    ''' <remarks></remarks>
    Private ErrorAnswers() As String = { _
                            "RING", _
                            "NO CARRIER", _
                            "ERROR", _
                            "NO DIALTONE", _
                            "BUSY", _
                            "NO ANSWER"}


    ''' <summary>
    ''' проверка контрольной суммы строки
    ''' </summary>
    ''' <param name="val"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CheckCRC(ByRef val As String, Optional ByVal RemoveCS As Boolean = False) As Boolean

        CheckCRC = False
        Try
            If val.Length > 2 Then
                Dim iCRC1 As Integer = 0
                Dim iCRC2 As Integer = Convert.ToInt32(val.Substring(val.Length - 2), 16)

                For i As Integer = 0 To val.Length - 3
                    iCRC1 += Asc(val.Substring(i, 1))
                Next

                If (iCRC1 And 255) = iCRC2 Then
                    CheckCRC = True

                    If RemoveCS = True Then
                        Dim len As Integer = val.Length
                        val = val.Remove(len - 2, 2)
                    End If

                End If


            End If
        Catch ex As Exception

        End Try

    End Function

    ''' <summary>
    ''' добовляет контрольную сумму к строке
    ''' </summary>
    ''' <param name="val"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function AddCRC(ByVal val As String) As String
        Dim cs As Long = 0
        For Each ch As Char In val
            cs += Asc(ch)
        Next

        cs = cs And 255

        Return val & dtohc(cs)
    End Function


    ''' <summary>
    ''' преобразует в HEX формат с одним лидирующим нулем
    '''  val - не более 255
    ''' </summary>
    ''' <param name="val"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function dtohc(ByVal val As Integer)
        val = val And 255
        If val < 16 Then Return "0" & val.ToString("X")
        Return val.ToString("X")
    End Function

    ''' <summary>
    ''' отправка строки в СОМ порт
    ''' </summary>
    ''' <param name="send"></param>
    ''' <param name="CheckSum"></param>
    ''' <param name="SendVbCR"></param>
    ''' <remarks></remarks>
    Public Sub Write(ByVal send As String, ByVal CheckSum As Boolean, ByVal SendVbCR As Boolean)
        EnableEventReceived = True
        If Port IsNot Nothing Then
            If Port.IsOpen Then

                'log.WriteLine("->" & vbTab & send)
                'log.WriteLine("<-" & vbTab)

                'Port.Encoding = System.Text.Encoding.GetEncoding(1251)
                Port.DiscardOutBuffer()
                Port.DiscardInBuffer()

                If CheckSum = True Then send = AddCRC(send)
                If SendVbCR Then send &= ControlChars.Cr


                Port.Write(send)


                Do While Port.BytesToWrite > 0
                Loop

            End If
        End If
    End Sub

    ''' <summary>
    ''' чтение строки символов из ком порта
    ''' возвращает true - строка принята
    ''' false - строка не принята
    ''' </summary>
    ''' <param name="Rec"></param>
    ''' <param name="TimeOut"></param>
    ''' <param name="CheckSum"></param>
    ''' <param name="RemoveCS"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ReadLine(ByRef Rec As String, _
                                ByRef TimeOut As Integer, _
                                ByVal CheckSum As Boolean, _
                                ByVal RemoveCS As Boolean) As Boolean

        EnableEventReceived = False

        If Port IsNot Nothing Then
            If Port.IsOpen Then

                ReadLine = False

                Dim TimeStart As DateTime = Now

                'Port.Encoding = System.Text.Encoding.GetEncoding(1251)

                If Port.IsOpen = True Then

                    'log.WriteLine("<-" & vbTab, False)

                    TimeStart = Now
                    Rec = ""

                    'reception
                    Do While Now.Subtract(TimeStart).TotalMilliseconds < TimeOut
                        If Port.BytesToRead <> Nothing Then
                            If Port.BytesToRead > 0 Then

                                Dim ich As Integer = Port.ReadChar
                                Dim recchar As Char = ChrW(ich)
                                'log.Write(recchar)

                                If (recchar = ControlChars.Cr) Then
                                    'пришел CRLF проверяем на наличие ответа

                                    If CheckSum = True Then

                                        If Rec.Length > 2 Then
                                            If CheckCRC(Rec, RemoveCS) Then
                                                Return True
                                            End If
                                        End If

                                    Else
                                        Return True
                                    End If

                                Else
                                    Rec &= recchar
                                End If

                            End If
                        End If
                    Loop
                    'reception
                End If

                Return False
            Else
                Return False
            End If
        Else
            Return False
        End If

    End Function


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
    ''' <param name="CheckSum"></param>
    ''' <param name="Count"></param>
    ''' <param name="SendVbCR"></param>
    ''' <param name="Contain"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function SendRec(ByRef Rec As String, _
                                ByVal Send As String, _
                                ByRef TimeOut As Integer, _
                                ByVal CheckSum As Boolean, _
                                ByVal Count As Integer, _
                                ByVal SendVbCR As Boolean, _
                                ByVal RemoveCS As Boolean, _
                                ByVal PreviusDelay As Integer, _
                                ByVal ParamArray Contain() As String) As Boolean

        EnableEventReceived = False

        If Port IsNot Nothing Then
            If Port.IsOpen Then
                Dim cnt As Integer = Count

                SendRec = False

                Dim TimeStart As Integer = Environment.TickCount


                If CheckSum = True Then Send = AddCRC(Send)

                'Port.Encoding = System.Text.Encoding.GetEncoding(1251)

                While (cnt > 0)

                    If Port.IsOpen = True Then



                        'Debug.Write("->" & vbTab & Send & vbTab & cnt & vbCrLf & "<-" & vbTab)

                        'log.WriteLine("->" & vbTab & Send & vbTab & cnt)
                        'log.WriteLine("<-" & vbTab, False)



                        Port.DiscardOutBuffer()
                        Port.DiscardInBuffer()

                        If SendVbCR Then
                            Send = Send & ControlChars.Cr
                        End If



                        Threading.Thread.Sleep(PreviusDelay)
                        'mSleep(PreviusDelay)
                        Port.Write(Send)



                        Do While Port.BytesToWrite > 0
                        Loop

                        TimeStart = Environment.TickCount

                        Rec = ""

                        'reception


                        Do While (Environment.TickCount - TimeStart) < TimeOut
                            If Port.BytesToRead <> Nothing Then
                                If Port.BytesToRead > 0 Then
                                    Dim ich As Integer = Port.ReadChar
                                    Dim recchar As Char = ChrW(ich)
                                    'log.Write(recchar)
                                    'Debug.Write(recchar)
                                    If (recchar = ControlChars.Cr) Then
                                        'пришел CRLF проверяем на наличие ответа
                                        If Rec.Length > 2 Then

                                            If CheckSum = True Then

                                                If CheckCRC(Rec, RemoveCS) Then
                                                    For Each vl As String In Contain

                                                        If Rec.IndexOf(vl) <> -1 Then
                                                            'Dim tce As Integer = Environment.TickCount
                                                            'Debug.WriteLine("TimeOut - " & (Environment.TickCount - TimeStart).ToString)
                                                            Return True
                                                        End If
                                                    Next
                                                End If

                                            Else

                                                For Each vl As String In Contain
                                                    If Rec.IndexOf(vl) <> -1 Then
                                                        'Debug.WriteLine("TimeOut - " & (Environment.TickCount - TimeStart).ToString)
                                                        Return True
                                                    End If
                                                Next

                                                For Each vl As String In ErrorAnswers
                                                    If Rec.IndexOf(vl) <> -1 Then
                                                        Exit Do
                                                    End If
                                                Next

                                            End If


                                        Else
                                            'log.WriteLine("error rec")
                                            Debug.Write("else")
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
                    cnt -= 1

                End While

                Return False
            Else
                Return False
            End If
        Else
            Return False
        End If

    End Function


    Public Function crc16(ByVal modbusframe As Byte()) As Integer


        Dim j, i As Integer

        Dim reg_crc As Integer = &HFFFF

        For i = 0 To modbusframe.GetUpperBound(0)
            reg_crc = reg_crc Xor modbusframe(i)
            For j = 0 To 7
                If (reg_crc And &H1) Then
                    reg_crc = (reg_crc >> 1) Xor &HA001
                Else
                    reg_crc = reg_crc >> 1
                End If
            Next
        Next

        Return reg_crc


    End Function

    Public Overloads Function SendRec_ModbusRtu(ByRef data_rec As Byte(), ByVal command As Byte(), ByVal timeout As Integer, ByVal count As Integer, ByVal PreviusDelay As Integer) As Boolean

        EnableEventReceived = False


        If Port IsNot Nothing Then

            If Port.IsOpen Then

                'формируем команду
                Dim al As New ArrayList
                Dim bytes As Byte()
                Dim adr As Byte = command(0)

                For Each dt As Byte In command
                    al.Add(dt) 'command
                Next

                Dim crc As Byte() = BitConverter.GetBytes(Convert.ToInt32(crc16(al.ToArray(GetType(Byte)))))

                al.Add(crc(0))
                al.Add(crc(1))


                bytes = al.ToArray(GetType(Byte))

                'Port.Encoding = System.Text.Encoding.GetEncoding(1251)

                Dim TimeStart As Integer

                While (count > 0)

                    Port.DiscardOutBuffer()
                    Port.DiscardInBuffer()

                    Threading.Thread.Sleep(PreviusDelay)

                    Port.Write(bytes, 0, bytes.Length)

                    Do While Port.BytesToWrite > 0
                    Loop

                    TimeStart = Environment.TickCount

                    al.Clear()

                    'reception


                    Do While (Environment.TickCount - TimeStart) < timeout



                        If Port.BytesToRead <> Nothing Then

                            While Port.BytesToRead
                                Dim bt As Byte = Port.ReadByte

                                Select Case al.Count
                                    Case 0 'find prefix
                                        If bt = adr Then
                                            al.Add(bt)
                                        End If
                                    Case Else
                                        al.Add(bt)
                                End Select


                            End While



                        End If

                        If al.Count > 2 Then
                            Select Case al.Item(1)
                                Case 3
                                    If al.Count = (al.Item(2) + 5) Then
                                        data_rec = al.ToArray(GetType(Byte))
                                        Dim crc_rec As Integer = data_rec(data_rec.GetUpperBound(0))
                                        crc_rec <<= 8
                                        crc_rec += data_rec(data_rec.GetUpperBound(0) - 1)

                                        Dim t_data_rec(data_rec.Length - 3) As Byte
                                        Array.Copy(data_rec, 0, t_data_rec, 0, t_data_rec.Length)
                                        Dim crc_16 As Integer = crc16(t_data_rec)
                                        If crc_16 = crc_rec Then

                                            'Debug.Write("true")
                                            Return True
                                        Else
                                            Exit Do
                                        End If
                                    End If
                                Case 6
                                    If al.Count = bytes.Length Then
                                        data_rec = al.ToArray(GetType(Byte))
                                        Dim crc_rec As Integer = data_rec(data_rec.GetUpperBound(0))
                                        crc_rec <<= 8
                                        crc_rec += data_rec(data_rec.GetUpperBound(0) - 1)

                                        Dim t_data_rec(data_rec.Length - 3) As Byte
                                        Array.Copy(data_rec, 0, t_data_rec, 0, t_data_rec.Length)
                                        Dim crc_16 As Integer = crc16(t_data_rec)
                                        If crc_16 = crc_rec Then

                                            'Debug.Write("true")
                                            Return True
                                        Else
                                            Exit Do
                                        End If
                                    End If
                                Case &H10
                                    If al.Count = 8 Then
                                        data_rec = al.ToArray(GetType(Byte))
                                        Dim crc_rec As Integer = data_rec(data_rec.GetUpperBound(0))
                                        crc_rec <<= 8
                                        crc_rec += data_rec(data_rec.GetUpperBound(0) - 1)

                                        Dim t_data_rec(data_rec.Length - 3) As Byte
                                        Array.Copy(data_rec, 0, t_data_rec, 0, t_data_rec.Length)
                                        Dim crc_16 As Integer = crc16(t_data_rec)
                                        If crc_16 = crc_rec Then

                                            'Debug.Write("true")
                                            Return True
                                        Else
                                            Exit Do
                                        End If
                                    End If
                            End Select

                        End If

                    Loop

                    count -= 1
                    Debug.WriteLine("TimeOut - " & (Environment.TickCount - TimeStart).ToString & " count -" & count)
                    'log.Write(vbCrLf)
                End While

            End If

        End If

        Return False
    End Function


    Public Event ReceiveChar(ByVal value As Char)

    Private sCommand As String = vbNullString

    Dim _al As New ArrayList
    Dim _rec_len As Integer = 5
    Dim _data_rec As Byte()

    Private Sub Port_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles Port.DataReceived
        If EnableEventReceived = False Then Exit Sub

        If _Protokol = eProtokol.ASCII Then

            Dim iPnt As Int32, Buffer() As Byte = {0, 13, 16}

            Dim oEnc As System.Text.Encoding = System.Text.Encoding.GetEncoding("ASCII") '1252)
            '-------------------------------------------------------------
            If e.EventType = IO.Ports.SerialData.Chars Then

                Try
                    If CType(sender, IO.Ports.SerialPort).BytesToRead > 0 Then
                        ReDim Buffer(CType(sender, IO.Ports.SerialPort).BytesToRead - 1)
                        CType(sender, IO.Ports.SerialPort).Read(Buffer, 0, CType(sender, IO.Ports.SerialPort).BytesToRead)
                    End If
                Catch
                    'Debug.Print("-1")
                End Try
                Dim ch As Char
                For iPnt = 0 To Buffer.Length - 1


                    ch = oEnc.GetString(Buffer, iPnt, 1)

                    If ch = vbCr Then

                        'log.WriteLine("-1 " & sCommand)

                        ReceiveStr(sCommand)
                        sCommand = vbNullString
                    Else
                        sCommand &= ch
                    End If

                    RaiseEvent ReceiveChar(ch)

                Next
            End If
        Else
            If Port.BytesToRead <> Nothing Then
                If Port.BytesToRead > 0 Then

                    Do
                        Dim bt As Byte = Port.ReadByte
                        'log.Write("0x" & dtohc(bt) & ";")

                        Select Case _al.Count
                            Case 0 'find prefix
                                If bt = &H39 Then
                                    _al.Add(bt)
                                End If

                            Case 3  'data len
                                _rec_len += bt

                                _al.Add(bt)
                                If bt > 0 Then
                                    ReDim _data_rec(bt - 1)
                                End If

                            Case _rec_len - 1 'check crc
                                Dim rec_crc As Byte = bt
                                Dim evalute_crc As Byte = CalculateCRC8(_al.ToArray(GetType(Byte)))
                                If rec_crc = evalute_crc Then

                                    'adress = CByte(_al.Item(1))
                                    _al.CopyTo(4, _data_rec, 0, _data_rec.Length)
                                    'log.Write(vbCrLf)
                                    _al.Clear()
                                    _rec_len = 5

                                    RaiseEvent ReceiveBinThread(_data_rec)

                                End If
                            Case Else
                                _al.Add(bt)
                        End Select
                    Loop While (Port.BytesToRead > 0)

                End If
            End If

        End If

    End Sub

    Public Event ReceiveBinThread(ByVal values As Byte())

    Public Event ReceiveComand(ByVal value As String)


    Private Sub ReceiveStr(ByRef Cmd As String)

        'log.WriteLine("<-" & vbTab & Cmd)

        If CheckCRC(Cmd, True) = True And Cmd.Substring(0, 1) = ">" Then
            'If Cmd.Substring(0, 1) = "!"  Then
            'log.WriteLine("-2 " & Cmd)

            RaiseEvent ReceiveComand(Cmd)

        Else
            'Debug.Print("Err CheckSum " & Cmd)
        End If

    End Sub


#Region "BIN протокол"
    Public Overloads Function SendRec_OM(ByRef adress As Byte, ByRef data_rec As Byte(), ByVal command As Byte, ByVal data As Byte(), ByVal timeout As Integer, ByVal count As Integer) As Boolean
        EnableEventReceived = False

        If _Protokol = eProtokol.BIN Then

            If Port IsNot Nothing Then

                If Port.IsOpen Then

                    'формируем команду
                    Dim al As New ArrayList
                    Dim bytes As Byte()

                    al.Add(CByte(&H31)) 'prefix
                    al.Add(adress)      'adress for all
                    al.Add(command)     'command
                    If data IsNot Nothing Then
                        If data.Length > 0 Then

                            For Each dt As Byte In data
                                al.Add(dt) 'data
                            Next

                        End If
                    Else
                        al.Add(CByte(0))
                    End If
                    al.Add(CalculateCRC8(al.ToArray(GetType(Byte)))) 'crc

                    bytes = al.ToArray(GetType(Byte))

                    Port.Encoding = System.Text.Encoding.GetEncoding(1251)

                    Dim TimeStart As DateTime

                    While (count > 0)
                        Dim str As String = "->" & vbTab
                        For Each dt As Byte In bytes
                            str &= "0x" & dtohc(dt) & ";"
                        Next

                        'log.WriteLine(str & vbTab & count)
                        'log.WriteLine("<-" & vbTab, False)

                        Port.DiscardOutBuffer()
                        Port.DiscardInBuffer()

                        Port.Write(bytes, 0, bytes.Length)

                        Do While Port.BytesToWrite > 0
                        Loop

                        TimeStart = Now

                        al.Clear()

                        'reception
                        Dim rec_len As Integer = 5  'min len message
                        ReDim data_rec(0)

                        Do While Now.Subtract(TimeStart).TotalMilliseconds < timeout
                            If Port.BytesToRead <> Nothing Then

                                If Port.BytesToRead > 0 Then

                                    Dim bt As Byte = Port.ReadByte
                                    'log.Write("0x" & dtohc(bt) & ";")

                                    Select Case al.Count
                                        Case 0 'find prefix
                                            If bt = &H3E Then
                                                al.Add(bt)
                                            End If

                                            'Case 3  'data len
                                            '    rec_len += bt

                                            '    al.Add(bt)
                                            '    If bt > 0 Then
                                            '        ReDim data_rec(bt - 1)
                                            '    End If

                                        Case rec_len - 1 'check crc
                                            Dim rec_crc As Byte = bt
                                            Dim evalute_crc As Byte = CalculateCRC8(al.ToArray(GetType(Byte)))
                                            If rec_crc = evalute_crc Then

                                                adress = CByte(al.Item(1))
                                                al.CopyTo(3, data_rec, 0, data_rec.Length)
                                                'log.Write(vbCrLf)
                                                Return True

                                            End If
                                        Case Else
                                            al.Add(bt)
                                    End Select

                                End If

                            End If
                        Loop

                        count -= 1
                        'log.Write(vbCrLf)
                    End While

                End If

            End If
        End If

        Return False
    End Function

    Public Overloads Function SendRec(ByVal prefix_send As Byte, ByVal prefix_rec As Byte, ByRef data_rec As Byte(), ByVal command As Byte, ByVal data As Byte(), ByVal timeout As Integer, ByVal count As Integer) As Boolean
        EnableEventReceived = False

        If _Protokol = eProtokol.BIN Then

            If Port IsNot Nothing Then

                If Port.IsOpen Then

                    'формируем команду
                    Dim al As New ArrayList
                    Dim bytes As Byte()

                    al.Add(prefix_send) 'prefix
                    al.Add(command)     'command

                    If data IsNot Nothing Then
                        al.Add(CByte(data.Length))  'data len
                        If data.Length > 0 Then

                            For Each dt As Byte In data
                                al.Add(dt) 'data
                            Next

                        End If
                    Else
                        al.Add(CByte(0))
                    End If

                    al.Add(CalculateCRC8(al.ToArray(GetType(Byte)))) 'crc

                    bytes = al.ToArray(GetType(Byte))

                    Port.Encoding = System.Text.Encoding.GetEncoding(1251)

                    Dim TimeStart As DateTime

                    While (count > 0)
                        Dim str As String = "->" & vbTab
                        For Each dt As Byte In bytes
                            str &= "0x" & dtohc(dt) & ";"
                        Next

                        'log.WriteLine(str & vbTab & count)
                        'log.WriteLine("<-" & vbTab, False)

                        Port.DiscardOutBuffer()
                        Port.DiscardInBuffer()

                        Port.Write(bytes, 0, bytes.Length)

                        Do While Port.BytesToWrite > 0
                        Loop

                        TimeStart = Now

                        al.Clear()

                        'reception
                        Dim rec_len As Integer = 4  'min len message

                        Do While Now.Subtract(TimeStart).TotalMilliseconds < timeout
                            If Port.BytesToRead <> Nothing Then

                                If Port.BytesToRead > 0 Then

                                    Dim bt As Byte = Port.ReadByte
                                    'log.Write("0x" & dtohc(bt) & ";")

                                    Select Case al.Count
                                        Case 0 'find prefix
                                            If bt = prefix_rec Then
                                                al.Add(bt)
                                            End If

                                        Case 2  'data len
                                            rec_len += bt

                                            al.Add(bt)
                                            If bt > 0 Then
                                                ReDim data_rec(bt - 1)
                                            End If

                                        Case rec_len - 1 'check crc
                                            Dim rec_crc As Byte = bt
                                            Dim evalute_crc As Byte = CalculateCRC8(al.ToArray(GetType(Byte)))
                                            If rec_crc = evalute_crc Then

                                                al.CopyTo(3, data_rec, 0, data_rec.Length)
                                                'log.Write(vbCrLf)
                                                Return True

                                            End If
                                        Case Else
                                            al.Add(bt)
                                    End Select

                                End If

                            End If
                        Loop

                        count -= 1
                        'log.Write(vbCrLf)
                    End While

                End If

            End If
        End If

        Return False
    End Function


    Public Overloads Function SendRec(ByRef adress As Byte, ByRef data_rec As Byte(), ByVal command As Byte, ByVal data As Byte(), ByVal timeout As Integer, ByVal count As Integer, Optional ByVal SetFF As Boolean = True) As Boolean
        EnableEventReceived = False
        If SetFF Then adress = &HFF

        If _Protokol = eProtokol.BIN Then

            If Port IsNot Nothing Then

                If Port.IsOpen Then

                    'формируем команду
                    Dim al As New ArrayList
                    Dim bytes As Byte()

                    al.Add(CByte(&H37)) 'prefix
                    al.Add(adress)      'adress for all
                    al.Add(command)     'command

                    If data IsNot Nothing Then
                        al.Add(CByte(data.Length))  'data len
                        If data.Length > 0 Then

                            For Each dt As Byte In data
                                al.Add(dt) 'data
                            Next

                        End If
                    Else
                        al.Add(CByte(0))
                    End If

                    al.Add(CalculateCRC8(al.ToArray(GetType(Byte)))) 'crc

                    bytes = al.ToArray(GetType(Byte))

                    Port.Encoding = System.Text.Encoding.GetEncoding(1251)

                    Dim TimeStart As DateTime

                    While (count > 0)
                        Dim str As String = "->" & vbTab
                        For Each dt As Byte In bytes
                            str &= "0x" & dtohc(dt) & ";"
                        Next

                        'log.WriteLine(str & vbTab & count)
                        'log.WriteLine("<-" & vbTab, False)

                        Port.DiscardOutBuffer()
                        Port.DiscardInBuffer()

                        Port.Write(bytes, 0, bytes.Length)

                        Do While Port.BytesToWrite > 0
                        Loop

                        TimeStart = Now

                        al.Clear()

                        'reception
                        Dim rec_len As Integer = 5  'min len message

                        Do While Now.Subtract(TimeStart).TotalMilliseconds < timeout
                            If Port.BytesToRead <> Nothing Then

                                If Port.BytesToRead > 0 Then

                                    Dim bt As Byte = Port.ReadByte
                                    'log.Write("0x" & dtohc(bt) & ";")

                                    Select Case al.Count
                                        Case 0 'find prefix
                                            If bt = &H39 Then
                                                al.Add(bt)
                                            End If

                                        Case 3  'data len
                                            rec_len += bt

                                            al.Add(bt)
                                            If bt > 0 Then
                                                ReDim data_rec(bt - 1)
                                            End If

                                        Case rec_len - 1 'check crc
                                            Dim rec_crc As Byte = bt
                                            Dim evalute_crc As Byte = CalculateCRC8(al.ToArray(GetType(Byte)))
                                            If rec_crc = evalute_crc Then

                                                adress = CByte(al.Item(1))
                                                al.CopyTo(4, data_rec, 0, data_rec.Length)
                                                'log.Write(vbCrLf)
                                                Return True

                                            End If
                                        Case Else
                                            al.Add(bt)
                                    End Select

                                End If

                            End If
                        Loop

                        count -= 1
                        'log.Write(vbCrLf)
                    End While

                End If

            End If
        End If

        Return False
    End Function


    Private Function CRC8(ByVal _data As Byte, ByVal _crc As Byte) As Byte

        Dim i As Byte = _data Xor _crc
        _crc = 0
        If (i And &H1) Then _crc = _crc Xor &H5E
        If (i And &H2) Then _crc = _crc Xor &HBC
        If (i And &H4) Then _crc = _crc Xor &H61
        If (i And &H8) Then _crc = _crc Xor &HC2
        If (i And &H10) Then _crc = _crc Xor &H9D
        If (i And &H20) Then _crc = _crc Xor &H23
        If (i And &H40) Then _crc = _crc Xor &H46
        If (i And &H80) Then _crc = _crc Xor &H8C

        Return _crc
    End Function

    Private Function CalculateCRC8(ByVal vals As Byte()) As Byte
        Dim i As Byte = 0
        Dim crc As Byte = 0

        For Each bt As Byte In vals
            crc = CRC8(bt, crc)
        Next

        Return crc
    End Function

    Private Function CheckCRC8(ByVal value As Byte()) As Boolean
        CheckCRC8 = False
        If value.Length > 2 Then
            Dim rec_crc As Byte = value(value.GetUpperBound(0))
            ReDim Preserve value(value.GetUpperBound(0) - 1)
            Dim evalute_crc As Byte = CalculateCRC8(value)
            If rec_crc = evalute_crc Then
                CheckCRC8 = True
            End If
        End If
    End Function
#End Region

    Private disposedValue As Boolean = False        ' Чтобы обнаружить избыточные вызовы

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: освободить другие состояния (управляемые объекты).
                If Port.IsOpen Then Me.Port.Close()
                Me.Port.Dispose()

                'log.Dispose()

            End If

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

End Class


