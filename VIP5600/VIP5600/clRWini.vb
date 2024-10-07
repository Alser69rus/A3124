Imports System.IO
Imports System.Text
Imports System.Reflection

Public Class clRWini


    Private PresetPath As String

    'читает данные из ini файла
    Public Function ReadINIKey(ByVal Section As String, ByVal KeyName As String, ByVal FileName As String) As String

        Dim sr As StreamReader
        Dim line, ret As String
        Dim idx, idx2 As Int16

        sr = New StreamReader(FileName)


        line = sr.ReadToEnd

        sr.Close()


        sr.Dispose()
        sr = Nothing

        'find section
        idx = line.IndexOf("[" & Section & "]")


        If idx > 0 Then
            idx2 = line.IndexOf("[", idx + 1)
            If idx2 = -1 Then idx2 = line.Length - 1
            'find keyname
            idx = line.IndexOf(KeyName, idx + Section.Length, idx2 - idx - Section.Length)
            If idx > 0 Then
                idx2 = line.IndexOf(Chr(13), idx)
                If idx2 = -1 Then idx2 = line.Length - 1

                ret = line.Substring(idx + KeyName.Length + 1, idx2 - idx - KeyName.Length)
                Return ret.Trim
            End If
        End If

        Return Nothing
    End Function

    'записывает данные в ini файла
    Public Sub WriteINIKey(ByVal Section As String, ByVal KeyName As String, ByVal Parametr As String, ByVal FileName As String)


        Dim sr As StreamReader
        Dim line As String
        Dim idx, idx2 As Int16

        sr = New StreamReader(FileName)


        line = sr.ReadToEnd

        sr.Close()


        sr.Dispose()
        sr = Nothing

        'find section
        Dim pos As Int16

        idx = line.IndexOf("[" & Section & "]")
        pos = idx
        If idx > 0 Then
            idx2 = line.IndexOf("[", idx + 1)
            If idx2 = -1 Then idx2 = line.Length - 1
            'find keyname
            idx = line.IndexOf(KeyName, idx + Section.Length, idx2 - idx - Section.Length)
            If idx > 0 Then
                idx2 = line.IndexOf(Chr(13), idx)
                If idx2 = -1 Then
                    idx2 = line.Length - 1
                Else
                    idx2 -= 1
                End If


                line = line.Remove(idx + KeyName.Length + 1, idx2 - idx - KeyName.Length)
                line = line.Insert(idx + KeyName.Length + 1, Parametr)
            Else
                'нет ключа и нет значения - создаем
                line = line.Insert(idx2 + 1, vbCrLf & KeyName & "=" & Parametr)
            End If
        Else
            'нет секции и нет ключа и нет значения - создаем
            pos = line.Length
            If pos = 0 Then
                pos = 1
            End If
            line = line.Insert(pos - 1, vbCrLf & "[" & Section & "]" & vbCrLf & KeyName & "=" & Parametr)
        End If

        Dim sw As New StreamWriter(FileName)
        sw.Write(line)
        sw.Close()
        sw.Dispose()
        sw = Nothing

    End Sub


    Public Property RW(ByVal SectionName As String, ByVal KeyName As String) As String
        Get
            RW = ReadINIKey(SectionName, KeyName, PresetPath)
        End Get
        Set(ByVal Value As String)
            WriteINIKey(SectionName, KeyName, Value, PresetPath)
        End Set
    End Property


    'PORT
    Private _PORT As String
    Public Property PORT() As String
        Get
            Return _PORT
        End Get
        Set(ByVal value As String)
            _PORT = value
            RW("OPTION", "PORT1") = value
        End Set
    End Property


    'BAUDRATE
    Private _BAUDRATE As String
    Public Property BAUDRATE() As String
        Get
            Return _BAUDRATE
        End Get
        Set(ByVal value As String)
            _BAUDRATE = value
            RW("OPTION", "BAUDRATE") = value
        End Set
    End Property

    'DATABITS
    Private _DATABITS As String
    Public Property DATABITS() As String
        Get
            Return _DATABITS
        End Get
        Set(ByVal value As String)
            _DATABITS = value
            RW("OPTION", "DATABITS") = value
        End Set
    End Property

    'STOPBITS
    Private _STOPBITS As String
    Public Property STOPBITS() As String
        Get
            Return _STOPBITS
        End Get
        Set(ByVal value As String)
            _STOPBITS = value
            RW("OPTION", "STOPBITS") = value
        End Set
    End Property

    'PARITY
    Private _PARITY As String
    Public Property PARITY() As String
        Get
            Return _PARITY
        End Get
        Set(ByVal value As String)
            _PARITY = value
            RW("OPTION", "PARITY") = value
        End Set
    End Property

    'HANDSHAKE
    Private _HANDSHAKE As String
    Public Property HANDSHAKE() As String
        Get
            Return _HANDSHAKE
        End Get
        Set(ByVal value As String)
            _HANDSHAKE = value
            RW("OPTION", "HANDSHAKE") = value
        End Set
    End Property


    'ADRESS
    Private _ADRESS(30) As String
    Public Property ADRESS(ByVal idx As Integer) As String
        Get
            Return _ADRESS(idx)
        End Get
        Set(ByVal value As String)
            _ADRESS(idx) = value
            RW("OPTION", "ADRESS" & idx.ToString) = value
        End Set
    End Property


    'CHANEL
    Private _CHANEL(30) As String
    Public Property CHANEL(ByVal idx As Integer) As String
        Get
            Return _CHANEL(idx)
        End Get
        Set(ByVal value As String)
            _ADRESS(idx) = value
            RW("OPTION", "CHANEL" & idx.ToString) = value
        End Set
    End Property

    'KOEF
    Private _KOEF(30) As String
    Public Property KOEF(ByVal idx As Integer) As String
        Get
            Return _KOEF(idx)
        End Get
        Set(ByVal value As String)
            _KOEF(idx) = value
            RW("OPTION", "KOEF" & idx.ToString) = value
        End Set
    End Property

    'PROTOKOL_PATH
    Private _PROTOKOL_PATH As String
    Public Property PROTOKOL_PATH() As String
        Get
            Return _PROTOKOL_PATH
        End Get
        Set(ByVal value As String)
            _PROTOKOL_PATH = value
            RW("OPTION", "PROTOKOL_PATH") = value
        End Set
    End Property

    'ENABLE_LOG
    Private _ENABLE_LOG As String
    Public Property ENABLE_LOG() As String
        Get
            Return _ENABLE_LOG
        End Get
        Set(ByVal value As String)
            _ENABLE_LOG = value
            RW("OPTION", "ENABLE_LOG") = value
        End Set
    End Property


    'PORT2
    Private _PORT2 As String
    Public Property PORT2() As String
        Get
            Return _PORT2
        End Get
        Set(ByVal value As String)
            _PORT2 = value
            RW("OPTION", "PORT2") = value
        End Set
    End Property


    'Передаточное число редуктора угла наклона
    Private _PER_RED_ANGLE As String
    Public Property PER_RED_ANGLE() As String
        Get
            Return _PER_RED_ANGLE
        End Get
        Set(ByVal value As String)
            _PER_RED_ANGLE = value
            RW("OPTION", "PER_RED_ANGLE") = value
        End Set
    End Property

    'Угол наклона поворота (энкодера) датчика в вертикальном положении гасителя
    Private _BASE_ANGLE As String
    Public Property BASE_ANGLE() As String
        Get
            Return _BASE_ANGLE
        End Get
        Set(ByVal value As String)
            _BASE_ANGLE = value
            RW("OPTION", "BASE_ANGLE") = value
        End Set
    End Property

    'номинал резистора для однооборотного энкодера, Ом.
    Private _NUM_R_ENCODER As String
    Public Property NUM_R_ENCODER() As String
        Get
            Return _NUM_R_ENCODER
        End Get
        Set(ByVal value As String)
            _NUM_R_ENCODER = value
            RW("OPTION", "NUM_R_ENCODER") = value
        End Set
    End Property

    Private _U_MIN_ENCODER As String
    Public Property U_MIN_ENCODER() As String
        Get
            Return _U_MIN_ENCODER
        End Get
        Set(ByVal value As String)
            _U_MIN_ENCODER = value
            RW("OPTION", "U_MIN_ENCODER") = value
        End Set
    End Property

    Private _U_MAX_ENCODER As String
    Public Property U_MAX_ENCODER() As String
        Get
            Return _U_MAX_ENCODER
        End Get
        Set(ByVal value As String)
            _U_MAX_ENCODER = value
            RW("OPTION", "U_MAX_ENCODER") = value
        End Set
    End Property

    'Передаточное число редуктора изменения амлитуды хода штока
    Private _PER_RED_AMPL As String
    Public Property PER_RED_AMPL() As String
        Get
            Return _PER_RED_AMPL
        End Get
        Set(ByVal value As String)
            _PER_RED_AMPL = value
            RW("OPTION", "PER_RED_AMPL") = value
        End Set
    End Property

    'Базовый ход штока (концевик), мм
    Private _BASE_AMPL As String
    Public Property BASE_AMPL() As String
        Get
            Return _BASE_AMPL
        End Get
        Set(ByVal value As String)
            _BASE_AMPL = value
            RW("OPTION", "BASE_AMPL") = value
        End Set
    End Property

    'Число шагов на оборот (шаговый двигатель), шт.
    Private _NUM_STEP_STEP_MOTOR As String
    Public Property NUM_STEP_STEP_MOTOR() As String
        Get
            Return _NUM_STEP_STEP_MOTOR
        End Get
        Set(ByVal value As String)
            _NUM_STEP_STEP_MOTOR = value
            RW("OPTION", "NUM_STEP_STEP_MOTOR") = value
        End Set
    End Property

    'Длина датчика перемещения, мм
    Private _LEN_DATCHIK_DISTANCE As String
    Public Property LEN_DATCHIK_DISTANCE() As String
        Get
            Return _LEN_DATCHIK_DISTANCE
        End Get
        Set(ByVal value As String)
            _LEN_DATCHIK_DISTANCE = value
            RW("OPTION", "LEN_DATCHIK_DISTANCE") = value
        End Set
    End Property

    'номинал резистора датчика перемещения, Ом
    Private _R_DATCHIK_DISTANCE As String
    Public Property R_DATCHIK_DISTANCE() As String
        Get
            Return _R_DATCHIK_DISTANCE
        End Get
        Set(ByVal value As String)
            _R_DATCHIK_DISTANCE = value
            RW("OPTION", "R_DATCHIK_DISTANCE") = value
        End Set
    End Property

    'Предел измерения датчика силы, кН
    Private _LIM_POWER As String
    Public Property LIM_POWER() As String
        Get
            Return _LIM_POWER
        End Get
        Set(ByVal value As String)
            _LIM_POWER = value
            RW("OPTION", "LIM_POWER") = value
        End Set
    End Property

    'Выходное напряжение после нормализатора датчика силы, В
    Private _U_POWER As String
    Public Property U_POWER() As String
        Get
            Return _U_POWER
        End Get
        Set(ByVal value As String)
            _U_POWER = value
            RW("OPTION", "U_POWER") = value
        End Set
    End Property

    Private _U_IN_POWER As String
    Public Property U_IN_POWER() As String
        Get
            Return _U_IN_POWER
        End Get
        Set(ByVal value As String)
            _U_IN_POWER = value
            RW("OPTION", "U_IN_POWER") = value
        End Set
    End Property

    'Диапазон измерения температуры  окружающей среды, град. min
    Private _T_MIN_OKR_SREDY As String
    Public Property T_MIN_OKR_SREDY() As String
        Get
            Return _T_MIN_OKR_SREDY
        End Get
        Set(ByVal value As String)
            _T_MIN_OKR_SREDY = value
            RW("OPTION", "T_MIN_OKR_SREDY") = value
        End Set
    End Property

    'Диапазон измерения температуры  окружающей среды, град. max
    Private _T_MAX_OKR_SREDY As String
    Public Property T_MAX_OKR_SREDY() As String
        Get
            Return _T_MAX_OKR_SREDY
        End Get
        Set(ByVal value As String)
            _T_MAX_OKR_SREDY = value
            RW("OPTION", "T_MAX_OKR_SREDY") = value
        End Set
    End Property

    'Выходное напряжение после нормализатора температуры окружающей среды, В
    Private _U_T_OKR_SREDY As String
    Public Property U_T_OKR_SREDY() As String
        Get
            Return _U_T_OKR_SREDY
        End Get
        Set(ByVal value As String)
            _U_T_OKR_SREDY = value
            RW("OPTION", "U_OKR_SREDY") = value
        End Set
    End Property

    Private _U_MIN_OKR_SREDY As String
    Public Property U_MIN_OKR_SREDY As String
        Get
            Return _U_MIN_OKR_SREDY
        End Get
        Set(ByVal value As String)
            _U_MIN_OKR_SREDY = value
            RW("OPTION", "U_MIN_OKR_SREDY") = value
        End Set
    End Property


    'Диапазон измерения температуры  гидрогасителя, град. min
    Private _T_MIN_GIDRO As String
    Public Property T_MIN_GIDRO() As String
        Get
            Return _T_MIN_GIDRO
        End Get
        Set(ByVal value As String)
            _T_MIN_GIDRO = value
            RW("OPTION", "T_MIN_GIDRO") = value
        End Set
    End Property

    'Диапазон измерения температуры  гидрогасителя, град. max
    Private _T_MAX_GIDRO As String
    Public Property T_MAX_GIDRO() As String
        Get
            Return _T_MAX_GIDRO
        End Get
        Set(ByVal value As String)
            _T_MAX_GIDRO = value
            RW("OPTION", "T_MAX_GIDRO") = value
        End Set
    End Property

    'Выходное напряжение после нормализатора температуры гидрогасителя, В
    Private _U_T_GIDRO As String
    Public Property U_T_GIDRO() As String
        Get
            Return _U_T_GIDRO
        End Get
        Set(ByVal value As String)
            _U_T_GIDRO = value
            RW("OPTION", "U_T_GIDRO") = value
        End Set
    End Property

    Private _U_MIN_GIDRO As String
    Public Property U_MIN_GIDRO() As String
        Get
            Return _U_MIN_GIDRO
        End Get
        Set(ByVal value As String)
            _U_MIN_GIDRO = value
            RW("OPTION", "U_MIN_GIDRO") = value
        End Set
    End Property

    'Передаточное число привода хода штока
    Private _PER_SHTOK As String
    Public Property PER_SHTOK() As String
        Get
            Return _PER_SHTOK
        End Get
        Set(ByVal value As String)
            _PER_SHTOK = value
            RW("OPTION", "PER_SHTOK") = value
        End Set
    End Property

    'Номинальная скорость вращения приводного двигателя, об/мин.
    Private _N_NOM As String
    Public Property N_NOM() As String
        Get
            Return _N_NOM
        End Get
        Set(ByVal value As String)
            _N_NOM = value
            RW("OPTION", "N_NOM") = value
        End Set
    End Property

    'Номер канала сигнала с тензодатчика
    Private _NUM_CHANEL_TENZO As String
    Public Property NUM_CHANEL_TENZO() As String
        Get
            Return _NUM_CHANEL_TENZO
        End Get
        Set(ByVal value As String)
            _NUM_CHANEL_TENZO = value
            RW("OPTION", "NUM_CHANEL_TENZO") = value
        End Set
    End Property

    'Номер канала сигнала с датчика перемещения
    Private _NUM_CHANEL_DISTANCE As String
    Public Property NUM_CHANEL_DISTANCE() As String
        Get
            Return _NUM_CHANEL_DISTANCE
        End Get
        Set(ByVal value As String)
            _NUM_CHANEL_DISTANCE = value
            RW("OPTION", "NUM_CHANEL_DISTANCE") = value
        End Set
    End Property

    'Номер канала сигнала с датчика температуры окружающей среды
    Private _NUM_CHANEL_T_OKR_SRREDY As String
    Public Property NUM_CHANEL_T_OKR_SRREDY() As String
        Get
            Return _NUM_CHANEL_T_OKR_SRREDY
        End Get
        Set(ByVal value As String)
            _NUM_CHANEL_T_OKR_SRREDY = value
            RW("OPTION", "NUM_CHANEL_T_OKR_SRREDY") = value
        End Set
    End Property

    'Номер канала сигнала с датчика температуры гидрогасителя
    Private _NUM_CHANEL_T_GIDRO As String
    Public Property NUM_CHANEL_T_GIDRO() As String
        Get
            Return _NUM_CHANEL_T_GIDRO
        End Get
        Set(ByVal value As String)
            _NUM_CHANEL_T_GIDRO = value
            RW("OPTION", "NUM_CHANEL_T_GIDRO") = value
        End Set
    End Property

    'фильт - количество гармоник
    Private _NUM_GARMONIC As String
    Public Property NUM_GARMONIC() As String
        Get
            Return _NUM_GARMONIC
        End Get
        Set(ByVal value As String)
            _NUM_GARMONIC = value
            RW("OPTION", "NUM_GARMONIC") = value
        End Set
    End Property

    'выхоное напряжение с тензодатчика в мВ
    Private _U_OUT_TENZO As String
    Public Property U_OUT_TENZO() As String
        Get
            Return _U_OUT_TENZO
        End Get
        Set(ByVal value As String)
            _U_OUT_TENZO = value
            RW("OPTION", "U_OUT_TENZO") = value
        End Set
    End Property

    Private _COR_A_TENZO As String
    Public Property COR_A_TENZO() As String
        Get
            Return _COR_A_TENZO
        End Get
        Set(ByVal value As String)
            _COR_A_TENZO = value
            RW("OPTION", "COR_A_TENZO") = value
        End Set
    End Property

    Private _COR_B_TENZO As String
    Public Property COR_B_TENZO() As String
        Get
            Return _COR_B_TENZO
        End Get
        Set(ByVal value As String)
            _COR_B_TENZO = value
            RW("OPTION", "COR_B_TENZO") = value
        End Set
    End Property

    'пароль доступа к настройкам
    Private _PASSWORD As String
    Public Property PASSWORD() As String
        Get
            Return _PASSWORD
        End Get
        Set(ByVal value As String)
            _PASSWORD = value
            RW("OPTION", "PASSWORD") = value
        End Set
    End Property


    Private _SAFEMODE As String
    Public Property SAFEMODE() As String
        Get
            Return _SAFEMODE
        End Get
        Set(ByVal value As String)
            _SAFEMODE = value
            RW("OPTION", "SAFEMODE") = value
        End Set
    End Property

    Private _MIN_AMPL As String
    Public Property MIN_AMPL() As String
        Get
            Return _MIN_AMPL
        End Get
        Set(ByVal value As String)
            _MIN_AMPL = value
            RW("OPTION", "MIN_AMPL") = value
        End Set
    End Property

    Private _MAX_AMPL As String
    Public Property MAX_AMPL() As String
        Get
            Return _MAX_AMPL
        End Get
        Set(ByVal value As String)
            _MAX_AMPL = value
            RW("OPTION", "MAX_AMPL") = value
        End Set
    End Property

    Private _STEND_NUM As String
    Public Property STEND_NUM() As String
        Get
            Return _STEND_NUM
        End Get
        Set(ByVal value As String)
            _STEND_NUM = value
            RW("OPTION", "STEND_NUM") = value
        End Set
    End Property

    Private _STEP_STEP As String
    Public Property STEP_STEP() As String
        Get
            Return _STEP_STEP
        End Get
        Set(ByVal value As String)
            _STEP_STEP = value
            RW("OPTION", "STEP_STEPPERCYCLE") = value
        End Set
    End Property

    Private _STEP_OFF As String
    Public Property STEP_OFF() As String
        Get
            Return _STEP_OFF
        End Get
        Set(ByVal value As String)
            _STEP_OFF = value
            RW("OPTION", "STEP_OFF") = value
        End Set
    End Property

    Private _STEP_MUL As String
    Public Property STEP_MUL() As String
        Get
            Return _STEP_MUL
        End Get
        Set(ByVal value As String)
            _STEP_MUL = value
            RW("OPTION", "STEP_MUL") = value
        End Set
    End Property

    Private _STEP_SPEED As String
    Public Property STEP_SPEED() As String
        Get
            Return _STEP_SPEED
        End Get
        Set(ByVal value As String)
            _STEP_SPEED = value
            RW("OPTION", "STEP_SPEED") = value
        End Set
    End Property

    Private _DOPUSK_F As String
    Public Property DOPUSK_F() As String
        Get
            Return _DOPUSK_F
        End Get
        Set(ByVal value As String)
            _DOPUSK_F = value
            RW("OPTION", "STEP_MUL") = value
        End Set
    End Property

    Private _DOPUSK_S As String
    Public Property DOPUSK_S() As String
        Get
            Return _DOPUSK_S
        End Get
        Set(ByVal value As String)
            _DOPUSK_S = value
            RW("OPTION", "STEP_MUL") = value
        End Set
    End Property

    Private _DOPUSK_E As String
    Public Property DOPUSK_E() As String
        Get
            Return _DOPUSK_E
        End Get
        Set(ByVal value As String)
            _DOPUSK_E = value
            RW("OPTION", "STEP_MUL") = value
        End Set
    End Property


    Public Sub New()

        Dim mpath As String = My.Application.Info.DirectoryPath
        PresetPath = mpath & "\setting.ini"


        If System.IO.File.Exists(PresetPath) = False Then
            'PresetPath = "\StorageCard\setting.ini"
            'Else

            Dim fs As New FileStream(PresetPath, FileMode.Create)
            fs.Close()
            fs.Dispose()
            fs = Nothing

            'System.IO.File.Create("\StorageCard\setting.ini")
            'PresetPath = "\StorageCard\setting.ini"
        End If


        _PROTOKOL_PATH = RW("OPTION", "PROTOKOL_PATH")
        _HANDSHAKE = RW("OPTION", "HANDSHAKE")
        _PARITY = RW("OPTION", "PARITY")
        _STOPBITS = RW("OPTION", "STOPBITS")
        _DATABITS = RW("OPTION", "DATABITS")
        _BAUDRATE = RW("OPTION", "BAUDRATE")
        _PORT = RW("OPTION", "PORT1")
        _ENABLE_LOG = RW("OPTION", "ENABLE_LOG")
        _PORT2 = RW("OPTION", "PORT2")
        _NUM_GARMONIC = RW("OPTION", "NUM_GARMONIC")

        If _HANDSHAKE Is Nothing Then HANDSHAKE = System.IO.Ports.Handshake.None.ToString
        If _PARITY Is Nothing Then PARITY = System.IO.Ports.Parity.None.ToString
        If _STOPBITS Is Nothing Then STOPBITS = System.IO.Ports.StopBits.One.ToString
        If _DATABITS Is Nothing Then DATABITS = "8"
        If _BAUDRATE Is Nothing Then BAUDRATE = "115200"
        If _PORT Is Nothing Then PORT = "COM3"
        If _PROTOKOL_PATH Is Nothing Then PROTOKOL_PATH = "\ResidentFlash\"
        If _ENABLE_LOG Is Nothing Then ENABLE_LOG = "True"
        If _PORT2 Is Nothing Then PORT2 = "COM9"
        If _NUM_GARMONIC Is Nothing Then NUM_GARMONIC = "20"

        For i As Integer = 0 To _ADRESS.GetUpperBound(0)
            _ADRESS(i) = RW("OPTION", "ADRESS" & i.ToString)
            If _ADRESS(i) Is Nothing Then ADRESS(i) = 1
            _CHANEL(i) = RW("OPTION", "CHANEL" & i.ToString)
            If _CHANEL(i) Is Nothing Then CHANEL(i) = 0
            _KOEF(i) = RW("OPTION", "KOEF" & i.ToString)
            If _KOEF(i) Is Nothing Then KOEF(i) = 0
        Next


        _NUM_CHANEL_T_GIDRO = RW("OPTION", "NUM_CHANEL_T_GIDRO")
        If _NUM_CHANEL_T_GIDRO Is Nothing Then NUM_CHANEL_T_GIDRO = "0"

        _NUM_CHANEL_T_OKR_SRREDY = RW("OPTION", "NUM_CHANEL_T_OKR_SRREDY")
        If _NUM_CHANEL_T_OKR_SRREDY Is Nothing Then NUM_CHANEL_T_OKR_SRREDY = "1"

        _NUM_CHANEL_DISTANCE = RW("OPTION", "NUM_CHANEL_DISTANCE")
        If _NUM_CHANEL_DISTANCE Is Nothing Then NUM_CHANEL_DISTANCE = "2"

        _NUM_CHANEL_TENZO = RW("OPTION", "NUM_CHANEL_TENZO")
        If _NUM_CHANEL_TENZO Is Nothing Then NUM_CHANEL_TENZO = "3"

        _N_NOM = RW("OPTION", "N_NOM")
        If _N_NOM Is Nothing Then N_NOM = "1480"

        _PER_SHTOK = RW("OPTION", "PER_SHTOK")
        If _PER_SHTOK Is Nothing Then PER_SHTOK = "25"

        _U_T_GIDRO = RW("OPTION", "U_T_GIDRO")
        If _U_T_GIDRO Is Nothing Then U_T_GIDRO = "10"

        _U_MIN_GIDRO = RW("OPTION", "U_MIN_GIDRO")
        If _U_MIN_GIDRO Is Nothing Then U_MIN_GIDRO = "1"

        _T_MAX_GIDRO = RW("OPTION", "T_MAX_GIDRO")
        If _T_MAX_GIDRO Is Nothing Then T_MAX_GIDRO = "250"

        _T_MIN_GIDRO = RW("OPTION", "T_MIN_GIDRO")
        If _T_MIN_GIDRO Is Nothing Then T_MIN_GIDRO = "-50"

        _U_T_OKR_SREDY = RW("OPTION", "U_OKR_SREDY")
        If _U_T_OKR_SREDY Is Nothing Then U_T_OKR_SREDY = "10"
        _U_MIN_OKR_SREDY = RW("OPTION", "U_MIN_OKR_SREDY")
        If _U_MIN_OKR_SREDY Is Nothing Then U_MIN_OKR_SREDY = "0"


        _T_MAX_OKR_SREDY = RW("OPTION", "T_MAX_OKR_SREDY")
        If _T_MAX_OKR_SREDY Is Nothing Then T_MAX_OKR_SREDY = "250"

        _T_MIN_OKR_SREDY = RW("OPTION", "T_MIN_OKR_SREDY")
        If _T_MIN_OKR_SREDY Is Nothing Then T_MIN_OKR_SREDY = "-50"

        _U_POWER = RW("OPTION", "U_POWER")
        If _U_POWER Is Nothing Then U_POWER = "5"

        _U_IN_POWER = RW("OPTION", "U_IN_POWER")
        If _U_IN_POWER Is Nothing Then U_IN_POWER = "20"

        _LIM_POWER = RW("OPTION", "LIM_POWER")
        If _LIM_POWER Is Nothing Then LIM_POWER = "50000"

        _R_DATCHIK_DISTANCE = RW("OPTION", "R_DATCHIK_DISTANCE")
        If _R_DATCHIK_DISTANCE Is Nothing Then R_DATCHIK_DISTANCE = "5"

        _LEN_DATCHIK_DISTANCE = RW("OPTION", "LEN_DATCHIK_DISTANCE")
        If _LEN_DATCHIK_DISTANCE Is Nothing Then LEN_DATCHIK_DISTANCE = "75"

        _NUM_STEP_STEP_MOTOR = RW("OPTION", "NUM_STEP_STEP_MOTOR")
        If _NUM_STEP_STEP_MOTOR Is Nothing Then NUM_STEP_STEP_MOTOR = "200"

        _BASE_AMPL = RW("OPTION", "BASE_AMPL")
        If _BASE_AMPL Is Nothing Then BASE_AMPL = "30"

        _PER_RED_AMPL = RW("OPTION", "PER_RED_AMPL")
        If _PER_RED_AMPL Is Nothing Then PER_RED_AMPL = "400"

        _NUM_R_ENCODER = RW("OPTION", "NUM_R_ENCODER")
        If _NUM_R_ENCODER Is Nothing Then NUM_R_ENCODER = "1024"

        _U_MIN_ENCODER = RW("OPTION", "U_MIN_ENCODER")
        If _U_MIN_ENCODER Is Nothing Then U_MIN_ENCODER = "1"

        _U_MAX_ENCODER = RW("OPTION", "U_MAX_ENCODER")
        If _U_MAX_ENCODER Is Nothing Then U_MAX_ENCODER = "5"

        _BASE_ANGLE = RW("OPTION", "BASE_ANGLE")
        If _BASE_ANGLE Is Nothing Then BASE_ANGLE = "10"

        _PER_RED_ANGLE = RW("OPTION", "PER_RED_ANGLE")
        If _PER_RED_ANGLE Is Nothing Then PER_RED_ANGLE = "400"

        _U_OUT_TENZO = RW("OPTION", "U_OUT_TENZO")
        If _U_OUT_TENZO Is Nothing Then U_OUT_TENZO = "0"

        _COR_A_TENZO = RW("OPTION", "COR_A_TENZO")
        If _COR_A_TENZO Is Nothing Then COR_A_TENZO = "0"

        _COR_B_TENZO = RW("OPTION", "COR_B_TENZO")
        If _COR_B_TENZO Is Nothing Then COR_B_TENZO = "0"

        _PASSWORD = RW("OPTION", "PASSWORD")
        If _PASSWORD Is Nothing Then PASSWORD = ""

        _SAFEMODE = RW("OPTION", "SAFEMODE")
        If _SAFEMODE Is Nothing Then SAFEMODE = "False"

        _MIN_AMPL = RW("OPTION", "MIN_AMPL")
        If _MIN_AMPL Is Nothing Then MIN_AMPL = "20"

        _MAX_AMPL = RW("OPTION", "MAX_AMPL")
        If _MAX_AMPL Is Nothing Then MAX_AMPL = "40"

        _STEND_NUM = RW("OPTION", "STEND_NUM")
        If _STEND_NUM Is Nothing Then STEND_NUM = "Стенд: А3124 №6"

        _STEP_STEP = RW("OPTION", "STEP_STEPPERCYCLE")
        If _STEP_STEP Is Nothing Then STEP_STEP = "500"

        _STEP_OFF = RW("OPTION", "STEP_OFF")
        If _STEP_OFF Is Nothing Then STEP_OFF = "175"

        _STEP_MUL = RW("OPTION", "STEP_MUL")
        If _STEP_MUL Is Nothing Then STEP_MUL = "25"

        _STEP_SPEED = RW("OPTION", "STEP_SPEED")
        If _STEP_SPEED Is Nothing Then STEP_SPEED = "500"

        _DOPUSK_F = RW("OPTION", "DOPUSK_F")
        If _DOPUSK_F Is Nothing Then DOPUSK_F = "1"
        _DOPUSK_S = RW("OPTION", "DOPUSK_S")
        If _DOPUSK_S Is Nothing Then DOPUSK_S = "1,2"
        _DOPUSK_E = RW("OPTION", "DOPUSK_E")
        If _DOPUSK_E Is Nothing Then DOPUSK_E = "150"

        

    End Sub
End Class


