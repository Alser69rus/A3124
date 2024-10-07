Imports System
Imports System.IO
Imports System.Text
Imports System.Threading
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Runtime.InteropServices

Public Class clLcardGidro

#Region "Declare"
    Const path_wlcomp As String = "wlcomp.dll"


    <DllImport(path_wlcomp, SetlastError:=True, CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function LoadAPIDLL(ByVal dllname As String) As UInt32
    End Function

    <DllImport(path_wlcomp, SetlastError:=True, CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function CallCreateInstance(ByRef hDll As UInt32, ByVal Slot As UInt32, ByRef Err As UInt32) As UInt32
    End Function

    <DllImport(path_wlcomp, SetlastError:=True, CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function OpenLDevice(ByRef hObj As UInt32) As UInt32
    End Function

    <DllImport(path_wlcomp, SetlastError:=True, CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function CloseLDevice(ByRef hObj As UInt32) As UInt32
    End Function

    <DllImport(path_wlcomp, SetlastError:=True, CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function FreeAPIDLL(ByRef hDll As UInt32) As UInt32
    End Function

    <DllImport(path_wlcomp, SetlastError:=True, CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function LoadBios(ByRef hObj As UInt32, ByVal BiosName As String) As UInt32
    End Function

    <DllImport(path_wlcomp, SetlastError:=True, CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function PlataTest(ByRef hObj As UInt32) As UInt32
    End Function

    <DllImport(path_wlcomp, SetlastError:=True, CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function ReadPlataDescr(ByRef hObj As UInt32, ByVal Parametr As Byte()) As UInt32
    End Function

    <DllImport(path_wlcomp, SetlastError:=True, CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function GetSlotParam(ByRef hObj As UInt32, ByRef Parametr As SLOT_PARAM) As UInt32
    End Function

    <DllImport(path_wlcomp, SetlastError:=True, CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function IoAsync(ByRef hObj As UInt32, ByVal Parametr As Byte()) As UInt32
        'Private Shared Function IoAsync(ByRef hObj As UInt32, ByVal Parametr As Byte()) As UInt32
    End Function

    <DllImport(path_wlcomp, SetlastError:=True, CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function RequestBufferStream(ByRef hObj As UInt32, ByRef Size As UInt32, ByVal StreamId As UInt32) As UInt32
    End Function

    'Private Shared Function FillDAQparameters(ByRef hObj As UInt32, ByVal Parametr As W_ADC_PARAM_U_0, ByVal sp_type As UInt32) As UInt32

    <DllImport(path_wlcomp, SetlastError:=True, CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function FillDAQparameters(ByRef hObj As UInt32, ByVal Parametr As Byte(), ByVal sp_type As UInt32) As UInt32
    End Function

    'Private Shared Function SetParametersStream(ByRef hObj As UInt32, ByVal Parametr As W_ADC_PARAM_U_0, ByVal sp_type As UInt32, ByRef Size As UInt32, ByRef Data As UInt32, ByRef Sync As UInt32, ByVal StreamId As UInt32) As UInt32
    <DllImport(path_wlcomp, SetlastError:=True, CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function SetParametersStream(ByRef hObj As UInt32, ByVal Parametr As Byte(), ByVal sp_type As UInt32, ByRef Size As UInt32, ByRef Data As UInt32, ByRef Sync As UInt32, ByVal StreamId As UInt32) As UInt32
    End Function

    <DllImport(path_wlcomp, SetlastError:=True, CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function EnableCorrection(ByRef hObj As UInt32, ByVal Parametr As UInt16) As UInt32
    End Function

    <DllImport(path_wlcomp, SetlastError:=True, CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function InitStartLDevice(ByRef hObj As UInt32) As UInt32
    End Function

    <DllImport(path_wlcomp, SetlastError:=True, CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function StartLDevice(ByRef hObj As UInt32) As UInt32
    End Function

    <DllImport(path_wlcomp, SetlastError:=True, CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function StopLDevice(ByRef hObj As UInt32) As UInt32
    End Function

    <DllImport(path_wlcomp, SetlastError:=True, CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function GetSyncData(ByRef hObj As UInt32, ByVal SyncPtr As UInt32, ByVal Offset As UInt32, ByRef Sync As UInt32) As UInt32
    End Function

    <DllImport(path_wlcomp, SetlastError:=True, CallingConvention:=CallingConvention.Cdecl)> _
    Private Shared Function GetDataFromBuffer(ByRef hObj As UInt32, ByVal DataPtr As UInt32, ByVal DataArray As Byte(), ByVal size As UInt32, ByVal mask As UInt32) As UInt32
    End Function

    'DllExport(ULONG) GetDataFromBuffer(PULONG hIfc, ULONG DataPtr, LPVOID DataArray, ULONG size, ULONG mask);

    'GetDataFromBuffer(&hIfc, (ULONG)tmp1, tmp, halfbuffer*sizeof(USHORT),0);

#End Region

#Region "Structure"

    Public Const L_ADC_PARAM As UInt16 = 1
    Public Const L_DAC_PARAM As UInt16 = 2

    Public Enum eErrLcomp
        L_SUCCESS = 0           'функция выполнена успешно; 
        L_NOTSUPPORTED = 1      'функция не поддерживается этой платой; 
        L_ERROR = 2             'ошибка при выполнении функции; 
        L_ERROR_NOBOARD = 3     'нет платы в запрашиваемом слоте; 
        L_ERROR_INUSE = 4       'плата в запрашиваемом слоте уже используется
    End Enum

    Public Enum eIoAsync As UShort
        L_ADC_PARAM = 1         'трактовать DAQ_PAR как ADC_PAR при передаче в FillDAQparameters; 
        L_DAC_PARAM = 2         'трактовать DAQ_PAR как DAC_PAR при передаче в FillDAQparameters; 
        L_ASYNC_ADC_CFG = 3     'ASYNC_PAR содержит запрос на конфигурирование АЦП; 
        L_ASYNC_TTL_CFG = 4     'ASYNC_PAR содержит запрос на конфигурирование цифровых линий; 
        L_ASYNC_DAC_CFG = 5     'ASYNC_PAR содержит запрос на конфигурирование ЦАП; 
        L_ASYNC_ADC_INP = 6     'ASYNC_PAR содержит запрос на ввод данных с АЦП; 
        L_ASYNC_TTL_INP = 7     'ASYNC_PAR содержит запрос на ввод данных с цифровых линий; 
        L_ASYNC_TTL_OUT = 8     'ASYNC_PAR содержит запрос на вывод данных на цифровые линии; 
        L_ASYNC_DAC_OUT = 9     'ASYNC_PAR содержит запрос на вывод данных на ЦАП; 
    End Enum

    Public Enum eStream As UShort
        L_STREAM_ADC = 1
        L_STREAM_DAC = 2
        L_STREAM_TTLIN = 3
        L_STREAM_TTLOUT = 4
    End Enum

    '<StructLayout(LayoutKind.Auto, size:=256, pack:=1)> _
    'Structure PLATA_DESCR_E440
    '    <VBFixedArray(8), FieldOffset(0)> Dim SerNum() As Byte
    '    <VBFixedArray(6), FieldOffset(9)> Dim BrdName() As Byte
    '    <FieldOffset(15)> Dim Rev As Byte
    '    <VBFixedArray(4), FieldOffset(16)> Dim DspType() As Byte
    '    <FieldOffset(21)> Dim IsDacPresent As Byte
    '    <FieldOffset(22)> Dim Quartz As Integer
    '    <VBFixedArray(12), FieldOffset(26)> Dim Reserv2() As Byte
    '    <VBFixedArray(7), FieldOffset(39)> Dim KoefADC() As UShort
    '    <VBFixedArray(3), FieldOffset(55)> Dim KoefDAC() As UShort
    '    <VBFixedArray(31), FieldOffset(63)> Dim Custom() As UShort

    'Public Sub init()
    '    ReDim SerNum(8)
    '    ReDim BrdName(6)
    '    ReDim DspType(4)
    '    ReDim Reserv2(12)
    '    ReDim KoefADC(7)
    '    ReDim KoefDAC(3)
    '    ReDim Custom(31)
    'End Sub
    'End Structure



    Public Structure SLOT_PARAM
        Public Base As UInteger
        Public BaseL As UInteger
        Public Base1 As UInteger
        Public BaseL1 As UInteger
        Public Mem As UInteger
        Public MemL As UInteger
        Public Mem1 As UInteger
        Public MemL1 As UInteger
        Public Irq As UInteger
        Public BoardType As UInteger
        Public DSPType As UInteger
        Public Dma As UInteger
        Public DmaDac As UInteger
        Public DTA_REG As UInteger
        Public IDMA_REG As UInteger
        Public CMD_REG As UInteger
        Public IRQ_RST As UInteger
        Public DTA_ARRAY As UInteger
        Public RDY_REG As UInteger
        Public CFG_REG As UInteger
    End Structure

    Public Class clW_ADC_PARAM_U_0

        Public data(2047) As Byte

        Public Property s_Type() As UInt32
            Get
                Return BitConverter.ToInt32(data, 0)
            End Get
            Set(ByVal value As UInt32)
                Dim bts As Byte() = BitConverter.GetBytes(value)
                Array.Copy(bts, 0, data, 0, 4)
            End Set
        End Property

        Public Property FIFO() As UInt32
            Get
                Return BitConverter.ToInt32(data, 4)
            End Get
            Set(ByVal value As UInt32)
                Dim bts As Byte() = BitConverter.GetBytes(value)
                Array.Copy(bts, 0, data, 4, 4)
            End Set
        End Property

        Public Property IrqStep() As UInt32
            Get
                Return BitConverter.ToInt32(data, 8)
            End Get
            Set(ByVal value As UInt32)
                Dim bts As Byte() = BitConverter.GetBytes(value)
                Array.Copy(bts, 0, data, 8, 4)
            End Set
        End Property

        Public Property Pages() As UInt32
            Get
                Return BitConverter.ToInt32(data, 12)
            End Get
            Set(ByVal value As UInt32)
                Dim bts As Byte() = BitConverter.GetBytes(value)
                Array.Copy(bts, 0, data, 12, 4)
            End Set
        End Property

        Public Property AutoInit() As UInt32
            Get
                Return BitConverter.ToInt32(data, 16)
            End Get
            Set(ByVal value As UInt32)
                Dim bts As Byte() = BitConverter.GetBytes(value)
                Array.Copy(bts, 0, data, 16, 4)
            End Set
        End Property

        Public Property dRate() As Double
            Get
                Return BitConverter.ToDouble(data, 20)
            End Get
            Set(ByVal value As Double)
                Dim bts As Byte() = BitConverter.GetBytes(value)
                Array.Copy(bts, 0, data, 20, 8)
            End Set
        End Property

        Public Property dKadr() As Double
            Get
                Return BitConverter.ToDouble(data, 28)
            End Get
            Set(ByVal value As Double)
                Dim bts As Byte() = BitConverter.GetBytes(value)
                Array.Copy(bts, 0, data, 28, 8)
            End Set
        End Property

        Public Property dScale() As Double
            Get
                Return BitConverter.ToDouble(data, 36)
            End Get
            Set(ByVal value As Double)
                Dim bts As Byte() = BitConverter.GetBytes(value)
                Array.Copy(bts, 0, data, 36, 8)
            End Set
        End Property

        Public Property Rate() As UInt32
            Get
                Return BitConverter.ToUInt32(data, 44)
            End Get
            Set(ByVal value As UInt32)
                Dim bts As Byte() = BitConverter.GetBytes(value)
                Array.Copy(bts, 0, data, 44, 4)
            End Set
        End Property

        Public Property Kadr() As UInt32
            Get
                Return BitConverter.ToInt32(data, 48)
            End Get
            Set(ByVal value As UInt32)
                Dim bts As Byte() = BitConverter.GetBytes(value)
                Array.Copy(bts, 0, data, 48, 4)
            End Set
        End Property

        Public Property Scale() As UInt32
            Get
                Return BitConverter.ToInt32(data, 52)
            End Get
            Set(ByVal value As UInt32)
                Dim bts As Byte() = BitConverter.GetBytes(value)
                Array.Copy(bts, 0, data, 52, 4)
            End Set
        End Property

        Public Property FPDelay() As UInt32
            Get
                Return BitConverter.ToInt32(data, 56)
            End Get
            Set(ByVal value As UInt32)
                Dim bts As Byte() = BitConverter.GetBytes(value)
                Array.Copy(bts, 0, data, 56, 4)
            End Set
        End Property

        Public Property SynchroType() As UInt32
            Get
                Return BitConverter.ToInt32(data, 60)
            End Get
            Set(ByVal value As UInt32)
                Dim bts As Byte() = BitConverter.GetBytes(value)
                Array.Copy(bts, 0, data, 60, 4)
            End Set
        End Property

        Public Property SynchroSensitivity() As UInt32
            Get
                Return BitConverter.ToInt32(data, 64)
            End Get
            Set(ByVal value As UInt32)
                Dim bts As Byte() = BitConverter.GetBytes(value)
                Array.Copy(bts, 0, data, 64, 4)
            End Set
        End Property

        Public Property SynchroMode() As UInt32
            Get
                Return BitConverter.ToInt32(data, 68)
            End Get
            Set(ByVal value As UInt32)
                Dim bts As Byte() = BitConverter.GetBytes(value)
                Array.Copy(bts, 0, data, 68, 4)
            End Set
        End Property

        Public Property AdChannel() As UInt32
            Get
                Return BitConverter.ToInt32(data, 72)
            End Get
            Set(ByVal value As UInt32)
                Dim bts As Byte() = BitConverter.GetBytes(value)
                Array.Copy(bts, 0, data, 72, 4)
            End Set
        End Property

        Public Property AdPorog() As UInt32
            Get
                Return BitConverter.ToInt16(data, 76)
            End Get
            Set(ByVal value As UInt32)
                Dim bts As Byte() = BitConverter.GetBytes(value)
                Array.Copy(bts, 0, data, 76, 4)
            End Set
        End Property

        Public Property NCh() As UInt32
            Get
                Return BitConverter.ToInt32(data, 80)
            End Get
            Set(ByVal value As UInt32)
                Dim bts As Byte() = BitConverter.GetBytes(value)
                Array.Copy(bts, 0, data, 80, 4)
            End Set
        End Property

        Public Property Chn() As UInt32()
            Get
                Dim arr(127) As UInt32
                For i As Integer = 0 To 127
                    arr(i) = BitConverter.ToInt16(data, 84 + i * 4)
                Next
                Return arr
            End Get
            Set(ByVal value As UInt32())

                For i As Integer = 0 To 127
                    Array.Copy(BitConverter.GetBytes(value(i)), 0, data, 84 + i * 4, 4)
                Next

            End Set
        End Property

        Public Property IrqEna() As UInt32
            Get
                Return BitConverter.ToInt32(data, 596)
            End Get
            Set(ByVal value As UInt32)
                Dim bts As Byte() = BitConverter.GetBytes(value)
                Array.Copy(bts, 0, data, 596, 4)
            End Set
        End Property

        Public Property AdcEna() As UInt32
            Get
                Return BitConverter.ToInt32(data, 600)
            End Get
            Set(ByVal value As UInt32)
                Dim bts As Byte() = BitConverter.GetBytes(value)
                Array.Copy(bts, 0, data, 600, 4)
            End Set
        End Property

    End Class

    'Structure W_ADC_PARAM_U_0
    '    Dim s_Type As UInt32

    '    Dim FIFO As UInt32

    '    Dim IrqStep As UInt32
    '    Dim Pages As UInt32

    '    Dim AutoInit As UInt32

    '    Dim dRate As Double
    '    Dim dKadr As Double
    '    Dim dScale As Double
    '    Dim Rate As UInt32
    '    Dim Kadr As UInt32
    '    Dim Scale As UInt32
    '    Dim FPDelay As UInt32

    '    Dim SynchroType As UInt32
    '    Dim SynchroSensitivity As UInt32
    '    Dim SynchroMode As UInt32
    '    Dim AdChannel As UInt32
    '    Dim AdPorog As UInt32
    '    Dim NCh As UInt32
    '    Dim Chn() As UInt32
    '    Dim IrqEna As UInt32
    '    Dim AdcEna As UInt32

    'End Structure

    '    typedef struct __PLATA_DESCR_E154
    '{
    '   char SerNum[9];
    '   char BrdName[11];
    '   char Rev;
    '   char DspType[11];
    '   char IsDacPresent;
    '   long Quartz;
    '   char Reserv2[3];
    '   float KoefADC[8];
    '   float KoefDAC[4];
    '   USHORT Custom[20];
    '} PLATA_DESCR_E154 , *PPLATA_DESCR_E154;
    'Параметры:

    'char SerNum[9] - серийный номер платы; 
    'char BrdName[11] - название платы; 
    'char Rev - ревизия платы; 
    'char DspType[11] - тип DSP; 
    'long Quartz - частота кварца; 
    'char IsDacPresent - наличие ЦАПа; 
    'char Reserv2[3] - зарезервировано; 
    'float KoefADC[8] - калибровочные коэффициенты АЦП; 
    'float KoefDAC[4] - калибровочные коэффициенты ЦАП; 
    'USHORT Custom[20] - пользовательское место; 

    Public Class clPLATA_DESCR_E440
        Public data(255) As Byte

        Public Property SerNum() As Char()
            Get
                Return System.Text.Encoding.UTF8.GetString(data, 0, 9).ToCharArray
            End Get
            Set(ByVal value As Char())
                For i As Integer = 0 To value.GetUpperBound(0)
                    data(i) = Convert.ToByte(value(i))
                Next
            End Set
        End Property

        Public Property BrdName() As Char()
            Get
                Return System.Text.Encoding.UTF8.GetString(data, 9, 7).ToCharArray
            End Get
            Set(ByVal value As Char())
                For i As Integer = 0 To value.GetUpperBound(0)
                    data(9 + i) = Convert.ToByte(value(i))
                Next
            End Set
        End Property

        Public Property Rev() As Char
            Get
                Return Convert.ToChar(data(16))
            End Get
            Set(ByVal value As Char)
                data(16) = Convert.ToByte(value)
            End Set
        End Property

        Public Property DspType() As Char()
            Get
                Return System.Text.Encoding.UTF8.GetString(data, 17, 5).ToCharArray
            End Get
            Set(ByVal value As Char())
                For i As Integer = 0 To value.GetUpperBound(0)
                    data(17 + i) = Convert.ToByte(value(i))
                Next
            End Set
        End Property

        Public Property IsDacPresent() As Byte
            Get
                Return data(22)
            End Get
            Set(ByVal value As Byte)
                data(22) = value
            End Set
        End Property

        Public Property Quartz() As Integer
            Get
                Return BitConverter.ToInt32(data, 23)
            End Get
            Set(ByVal value As Integer)
                Dim bts As Byte() = BitConverter.GetBytes(value)
                Array.Copy(bts, 0, data, 23, 4)
            End Set
        End Property

        Public Property Reserv2() As Byte()
            Get
                Dim bts(12) As Byte
                Array.Copy(data, 27, bts, 0, 13)
                Return bts
            End Get
            Set(ByVal value As Byte())
                Array.Copy(value, 0, data, 27, 13)
            End Set
        End Property

        Public Property KoefADC() As UInt16()
            Get

                Dim idx As Integer = 40
                Dim k(7) As UInt16

                For i As Integer = 0 To 7
                    k(i) = BitConverter.ToUInt16(data, idx)
                    idx += 2
                Next
                Return k

            End Get
            Set(ByVal value As UInt16())
                For i As Integer = 0 To 7
                    Array.Copy(BitConverter.GetBytes(value(i)), 0, data, 40 + i * 2, 2)
                Next
            End Set
        End Property

        Public Property KoefDAC() As UInt16()
            Get

                Dim idx As Integer = 56
                Dim k(3) As UInt16

                For i As Integer = 0 To 3
                    k(i) = BitConverter.ToUInt16(data, idx)
                    idx += 2
                Next
                Return k

            End Get
            Set(ByVal value As UInt16())
                For i As Integer = 0 To 3
                    Array.Copy(BitConverter.GetBytes(value(i)), 0, data, 56 + i * 2, 2)
                Next
            End Set
        End Property

        Public Property Custom() As UInt16()
            Get

                Dim idx As Integer = 64
                Dim k(31) As UInt16

                For i As Integer = 0 To 31
                    k(i) = BitConverter.ToUInt16(data, idx)
                    idx += 2
                Next
                Return k

            End Get
            Set(ByVal value As UInt16())
                For i As Integer = 0 To 31
                    Array.Copy(BitConverter.GetBytes(value(i)), 0, data, 64 + i * 2, 2)
                Next
            End Set
        End Property

    End Class

    Public Class clPLATA_DESCR_E154
        Public data(255) As Byte

        Public Property SerNum() As Char()
            Get
                Return System.Text.Encoding.UTF8.GetString(data, 0, 9).ToCharArray
            End Get
            Set(ByVal value As Char())
                For i As Integer = 0 To value.GetUpperBound(0)
                    data(i) = Convert.ToByte(value(i))
                Next
            End Set
        End Property

        Public Property BrdName() As Char()
            Get
                Return System.Text.Encoding.UTF8.GetString(data, 9, 11).ToCharArray
            End Get
            Set(ByVal value As Char())
                For i As Integer = 0 To value.GetUpperBound(0)
                    data(9 + i) = Convert.ToByte(value(i))
                Next
            End Set
        End Property

        Public Property Rev() As Char
            Get
                Return Convert.ToChar(data(20))
            End Get
            Set(ByVal value As Char)
                data(20) = Convert.ToByte(value)
            End Set
        End Property

        Public Property DspType() As Char()
            Get
                Return System.Text.Encoding.UTF8.GetString(data, 21, 11).ToCharArray
            End Get
            Set(ByVal value As Char())
                For i As Integer = 0 To value.GetUpperBound(0)
                    data(21 + i) = Convert.ToByte(value(i))
                Next
            End Set
        End Property

        Public Property IsDacPresent() As Byte
            Get
                Return data(32)
            End Get
            Set(ByVal value As Byte)
                data(32) = value
            End Set
        End Property

        Public Property Quartz() As Integer
            Get
                Return BitConverter.ToInt32(data, 33)
            End Get
            Set(ByVal value As Integer)
                Dim bts As Byte() = BitConverter.GetBytes(value)
                Array.Copy(bts, 0, data, 33, 4)
            End Set
        End Property

        Public Property Reserv2() As Byte()
            Get
                Dim bts(2) As Byte
                Array.Copy(data, 37, bts, 0, 3)
                Return bts
            End Get
            Set(ByVal value As Byte())
                Array.Copy(value, 0, data, 37, 3)
            End Set
        End Property

        Public Property KoefADC() As Single()
            Get

                Dim idx As Integer = 40
                Dim k(7) As Single

                For i As Integer = 0 To 7
                    k(i) = BitConverter.ToSingle(data, idx)
                    idx += 4
                Next
                Return k

            End Get
            Set(ByVal value As Single())
                For i As Integer = 0 To 7
                    Array.Copy(BitConverter.GetBytes(value(i)), 0, data, 40 + i * 4, 4)
                Next
            End Set
        End Property

        Public Property KoefDAC() As Single()
            Get

                Dim idx As Integer = 72
                Dim k(3) As Single

                For i As Integer = 0 To 3
                    k(i) = BitConverter.ToSingle(data, idx)
                    idx += 2
                Next
                Return k

            End Get
            Set(ByVal value As Single())
                For i As Integer = 0 To 3
                    Array.Copy(BitConverter.GetBytes(value(i)), 0, data, 72 + i * 4, 4)
                Next
            End Set
        End Property

        Public Property Custom() As UInt16()
            Get

                Dim idx As Integer = 88
                Dim k(19) As UInt16

                For i As Integer = 0 To 19
                    k(i) = BitConverter.ToUInt16(data, idx)
                    idx += 2
                Next
                Return k

            End Get
            Set(ByVal value As UInt16())
                For i As Integer = 0 To 19
                    Array.Copy(BitConverter.GetBytes(value(i)), 0, data, 88 + i * 2, 2)
                Next
            End Set
        End Property

    End Class

    Public Structure DAQ_PAR
        Dim s_Type As UInt32
        Dim FIFO As UInt32
        Dim IrqStep As UInt32
        Dim Pages As UInt32
    End Structure

    Public Class ASYNC_PAR
        Public data(2047) As Byte

        Public Property s_Type() As Integer
            Get
                Return BitConverter.ToInt32(data, 0)
            End Get
            Set(ByVal value As Integer)
                Dim bts As Byte() = BitConverter.GetBytes(value)
                Array.Copy(bts, 0, data, 0, 4)
            End Set
        End Property

        Public Property FIFO() As Integer
            Get
                Return BitConverter.ToInt32(data, 4)
            End Get
            Set(ByVal value As Integer)
                Dim bts As Byte() = BitConverter.GetBytes(value)
                Array.Copy(bts, 0, data, 4, 4)
            End Set
        End Property

        Public Property IrqStep() As Integer
            Get
                Return BitConverter.ToInt32(data, 8)
            End Get
            Set(ByVal value As Integer)
                Dim bts As Byte() = BitConverter.GetBytes(value)
                Array.Copy(bts, 0, data, 8, 4)
            End Set
        End Property

        Public Property Pages() As Integer
            Get
                Return BitConverter.ToInt32(data, 12)
            End Get
            Set(ByVal value As Integer)
                Dim bts As Byte() = BitConverter.GetBytes(value)
                Array.Copy(bts, 0, data, 12, 4)
            End Set
        End Property

        Public Property dRate() As Double
            Get
                Return BitConverter.ToDouble(data, 16)
            End Get
            Set(ByVal value As Double)
                Dim bts As Byte() = BitConverter.GetBytes(value)
                Array.Copy(bts, 0, data, 16, 8)
            End Set
        End Property

        Public Property Rate() As Integer
            Get
                Return BitConverter.ToInt32(data, 24)
            End Get
            Set(ByVal value As Integer)
                Dim bts As Byte() = BitConverter.GetBytes(value)
                Array.Copy(bts, 0, data, 24, 4)
            End Set
        End Property

        Public Property NCh() As Integer
            Get
                Return BitConverter.ToInt32(data, 28)
            End Get
            Set(ByVal value As Integer)
                Dim bts As Byte() = BitConverter.GetBytes(value)
                Array.Copy(bts, 0, data, 28, 4)
            End Set
        End Property

        Public Property Chn() As Integer()
            Get

                Dim idx As Integer = 32
                Dim k(127) As Integer

                For i As Integer = 0 To 127
                    k(i) = BitConverter.ToInt16(data, idx)
                    idx += 4
                Next
                Return k

            End Get
            Set(ByVal value As Integer())
                For i As Integer = 0 To 127
                    Array.Copy(BitConverter.GetBytes(value(i)), 0, data, 32 + i * 4, 4)
                Next
            End Set
        End Property

        Public Property _Data() As Integer()
            Get

                Dim idx As Integer = 544
                Dim k(127) As Integer

                For i As Integer = 0 To 127
                    k(i) = BitConverter.ToInt16(data, idx)
                    idx += 4
                Next
                Return k

            End Get
            Set(ByVal value As Integer())
                For i As Integer = 0 To 127
                    Array.Copy(BitConverter.GetBytes(value(i)), 0, data, 544 + i * 4, 4)
                Next
            End Set
        End Property

        Public Property Mode() As Integer
            Get
                Return BitConverter.ToInt32(data, 1056)
            End Get
            Set(ByVal value As Integer)
                Dim bts As Byte() = BitConverter.GetBytes(value)
                Array.Copy(bts, 0, data, 1056, 4)
            End Set
        End Property

    End Class
#End Region

#Region "Converting Lcard to VB"
    Private hDll As UInt32
    Private hObj As UInt32

    Private ptr_data As UInt32
    Private ptr_sync As UInt32

    Private idx_data As UInt32

    Private IrqStep As UInt16
    Private pages As UInt16


    Public Function Initialize(ByVal Slot As UInt32, ByVal CardName As String) As Boolean

        Try
            Dim Err As UInt32
            hDll = LoadAPIDLL("lcomp.dll")

            hObj = CallCreateInstance(hDll, Slot, Err)
            If Err <> eErrLcomp.L_SUCCESS Then Return False

            Err = OpenLDevice(hObj)
            If Err = 0 Then Return False

            'Err = LoadBios(hObj, CardName)
            If CardName.Contains("E154") = False Then
                Err = LoadBios(hObj, CardName)
                If Err <> eErrLcomp.L_SUCCESS Then Return False
            End If
           

            Err = PlataTest(hObj)
            If Err <> eErrLcomp.L_SUCCESS Then Return False



            Return True
        Catch ex As Exception
            MessageBox.Show("Init L-Card Error" & vbCrLf & ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function

    Public Function GetSlotParam(ByRef Parametr As SLOT_PARAM) As Boolean
        Try
            Dim err As Integer = GetSlotParam(hObj, Parametr)

            If err = eErrLcomp.L_ERROR Then Return False
            Return True

        Catch ex As Exception
            MessageBox.Show("GetSlotParam L-Card Error" & vbCrLf & ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function

    Public Function GetADC(ByVal Canal As Byte, ByRef Rezult As Integer) As Boolean
        Try
            Dim err As Integer
            Dim pp As New ASYNC_PAR

            'pp.s_Type = eIoAsync.L_ASYNC_ADC_CFG
            'pp.Mode = 1

            'err = IoAsync(hObj, pp.data)
            'If err = eErrLcomp.L_ERROR Then Return False

            pp.s_Type = eIoAsync.L_ASYNC_ADC_INP

            Dim dt(127) As Integer
            dt(0) = Canal

            pp.Chn = dt



            err = IoAsync(hObj, pp.data)

            If err = eErrLcomp.L_ERROR Then Return False

            Rezult = pp._Data(0)
            Return True

        Catch ex As Exception
            MessageBox.Show("GetADC L-Card Error" & vbCrLf & ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function

    Public Function GetIN(ByRef Rezult As Integer) As Boolean
        Try
            Dim err As Integer
            Dim pp As New ASYNC_PAR

            pp.s_Type = eIoAsync.L_ASYNC_TTL_CFG
            pp.Mode = 1

            err = IoAsync(hObj, pp.data)
            If err = eErrLcomp.L_ERROR Then Return False

            pp.s_Type = eIoAsync.L_ASYNC_TTL_INP

            err = IoAsync(hObj, pp.data)
            If err = eErrLcomp.L_ERROR Then Return False



            Rezult = pp._Data(0)

            Return True

        Catch ex As Exception
            MessageBox.Show("GetADC L-Card Error" & vbCrLf & ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function


    Public Function SetOUT(ByVal Value As Integer) As Boolean
        Try
            Dim err As Integer
            Dim pp As New ASYNC_PAR

            pp.s_Type = eIoAsync.L_ASYNC_TTL_CFG
            pp.Mode = 1

            err = IoAsync(hObj, pp.data)
            If err = eErrLcomp.L_ERROR Then Return False

            pp.s_Type = eIoAsync.L_ASYNC_TTL_OUT

            Dim dt(127) As Integer
            dt(0) = Value

            pp._Data = dt

            err = IoAsync(hObj, pp.data)

            If err = eErrLcomp.L_ERROR Then Return False

            Return True

        Catch ex As Exception
            MessageBox.Show("GetADC L-Card Error" & vbCrLf & ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function

    Public Function ReadPlataDescr(ByRef Parametr As clPLATA_DESCR_E440) As Boolean

        Try
            'Dim bt(112) As Byte
            'Dim err As Integer = ReadPlataDescr(hObj, bt)

            Dim err As Integer = ReadPlataDescr(hObj, Parametr.data)

            If err = eErrLcomp.L_ERROR Then Return False

            Return True
        Catch ex As Exception
            MessageBox.Show("ReadPlataDescr L-Card Error" & vbCrLf & ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function

    Public Function ReadPlataDescr(ByRef Parametr As clPLATA_DESCR_E154) As Boolean

        Try
            'Dim bt(112) As Byte
            'Dim err As Integer = ReadPlataDescr(hObj, bt)

            Dim err As Integer = ReadPlataDescr(hObj, Parametr.data)

            If err = eErrLcomp.L_ERROR Then Return False

            Return True
        Catch ex As Exception
            MessageBox.Show("ReadPlataDescr L-Card Error" & vbCrLf & ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function

    Public Function RequestBufferStream(ByRef BufferSize As UInt32) As Boolean
        Try

            Dim Err As Int32 = RequestBufferStream(hObj, BufferSize, eStream.L_STREAM_ADC)

            If Err = eErrLcomp.L_ERROR Then Return False

            Return True
        Catch ex As Exception
            MessageBox.Show("RequestBufferStream L-Card Error" & vbCrLf & ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function

    Public Function FillDAQparameters(ByRef Parametr As clW_ADC_PARAM_U_0) As Boolean
        'Public Function FillDAQparameters(ByRef Parametr As W_ADC_PARAM_U_0) As Boolean
        Try

            Dim Err As Int32 = FillDAQparameters(hObj, Parametr.data, 2)
            'Dim Err As Int32 = FillDAQparameters(hObj, Parametr, 2)

            If Err = eErrLcomp.L_SUCCESS Then Return True
            Return False

        Catch ex As Exception
            MessageBox.Show("FillDAQparameters L-Card Error" & vbCrLf & ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function SetParametersStream(ByRef Parametr As clW_ADC_PARAM_U_0, ByRef BufferSize As UInt32) As Boolean
        'Public Function SetParametersStream(ByRef Parametr As W_ADC_PARAM_U_0, ByRef BufferSize As UInt32) As Boolean
        Try

            Dim Err As Int32 = SetParametersStream(hObj, Parametr.data, 2, BufferSize, ptr_data, ptr_sync, eStream.L_STREAM_ADC)
            'Dim Err As Int32 = SetParametersStream(hObj, Parametr, 2, BufferSize, ptr_data, ptr_sync, eStream.L_STREAM_ADC)

            IrqStep = Parametr.IrqStep
            pages = Parametr.Pages

            If Err = eErrLcomp.L_SUCCESS Then Return True
            Return False

        Catch ex As Exception
            MessageBox.Show("SetParametersStream L-Card Error" & vbCrLf & ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function GetSyncData(ByRef BufferCount As UInt32) As Boolean
        Try

            Dim Err As Int32 = GetSyncData(hObj, ptr_sync, 0, idx_data)

            BufferCount = idx_data

            If Err = eErrLcomp.L_SUCCESS Then Return True

            Return False
        Catch ex As Exception
            MessageBox.Show("GetSyncData L-Card Error" & vbCrLf & ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Debug.Print("GetSyncData L-Card Error")
            Return False
        End Try
    End Function

    Public Function GetDataFromBuffer(ByVal PtrData As UInt32, ByVal Data As Byte(), ByVal SizeData As UInt32) As Boolean
        Try
            Dim Err As Int32 = GetDataFromBuffer(hObj, ptr_data + PtrData, Data, SizeData, 0)
            If Err = eErrLcomp.L_SUCCESS Then Return True

            Return False
        Catch ex As Exception
            'MessageBox.Show("GetDataFromBuffer L-Card Error" & vbCrLf & ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Debug.Print("GetDataFromBuffer L-Card Error")
            Return False
        End Try
    End Function

    Public Function EnableCorrection(ByVal value As Boolean) As Boolean
        Try

            Dim parametr As UInt16 = 0

            If value = True Then parametr = 1

            Dim Err As Int32 = EnableCorrection(hObj, value)

            If Err = eErrLcomp.L_SUCCESS Then Return True
            Return False

        Catch ex As Exception
            MessageBox.Show("EnableCorrection L-Card Error" & vbCrLf & ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function InitStartLDevice() As Boolean
        Try

            Dim Err As Int32 = InitStartLDevice(hObj)

            If Err = eErrLcomp.L_SUCCESS Then Return True
            Return False

        Catch ex As Exception
            MessageBox.Show("InitStartLDevice L-Card Error" & vbCrLf & ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function StartLDevice() As Boolean
        Try

            Dim Err As Int32 = StartLDevice(hObj)

            If Err = eErrLcomp.L_SUCCESS Then Return True
            Return False

        Catch ex As Exception
            MessageBox.Show("StartLDevice L-Card Error" & vbCrLf & ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function StopLDevice() As Boolean
        Try

            Dim Err As Int32 = StopLDevice(hObj)

            If Err = eErrLcomp.L_SUCCESS Then Return True
            Return False

        Catch ex As Exception
            MessageBox.Show("StopLDevice L-Card Error" & vbCrLf & ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

#End Region


    Private mSinhroChanel As UInteger = 0
    Public Property SinhroChanel() As UInteger
        Get
            Return mSinhroChanel
        End Get
        Set(ByVal value As UInteger)
            mSinhroChanel = value
        End Set
    End Property

    Private mSinhroLevel As UShort = 100
    Public Property SinhroLevel() As UShort
        Get
            Return mSinhroLevel
        End Get
        Set(ByVal value As UShort)
            mSinhroLevel = value
        End Set
    End Property

    Private bRun As Boolean = True

    Public Sub Stoping()
        bRun = False

        'While (mThread IsNot Nothing)
        '    Threading.Thread.Sleep(100)
        'End While

    End Sub

    Const mChanels As Integer = 8

    Const BufSize As Integer = 2048 * mChanels

    Private mBuf0(BufSize / mChanels - 1) As Short
    Private mBuf1(BufSize / mChanels - 1) As Short
    Private mBuf2(BufSize / mChanels - 1) As Short
    Private mBuf3(BufSize / mChanels - 1) As Short
    Private mBuf4(BufSize / mChanels - 1) As Short
    Private mBuf5(BufSize / mChanels - 1) As Short
    Private mBuf6(BufSize / mChanels - 1) As Short
    Private mBuf7(BufSize / mChanels - 1) As Short
    'Private mBuf8(BufSize / 10 - 1) As Short
    'Private mBuf9(BufSize / 10 - 1) As Short
    'Private mBuf10(BufSize / 10 - 1) As Short
    'Private mBuf11(BufSize / 10 - 1) As Short
    'Private mBuf12(BufSize / 10 - 1) As Short
    'Private mBuf13(BufSize / 10 - 1) As Short
    'Private mBuf14(BufSize / 10 - 1) As Short
    'Private mBuf15(BufSize / 10 - 1) As Short

    Private mRecBuf(BufSize * 2 - 1) As Byte
    Private mRecHalfBuf1(BufSize - 1) As Byte
    Private mRecHalfBuf2(BufSize - 1) As Byte

    Private mCancel As Boolean

    ''' <summary>
    ''' перезапуск Лкар с новыми праметрами частоты дискретизации в кГц
    ''' </summary>
    ''' <param name="Rate">частотс дискретизации в кГц</param>
    ''' <remarks></remarks>
    Public Sub ReInit(ByVal Rate As Double)

        bRun = False

        While (isexist)
            Thread.Sleep(100)
        End While

        mCancel = True
        bRun = True
        mThread = New Thread(AddressOf [Loop])
        mThread.Name = "mThread"
        'mThread = New Thread(AddressOf Thread_GetADC)
        mThread.Priority = ThreadPriority.Highest
        mThread.Start(Rate)
        isexist = True

    End Sub


    Private _Rate As Double = 0


    ''' <summary>
    ''' возвращает текущую рабочую частоту дискретизации
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property GetCurrentRate() As Double
        Get
            Return _Rate
        End Get
        
    End Property

    Private Sub [Loop](ByVal val As Object)



        bRun = True

        Dim RealBufSize As UInt32 = BufSize - 1

        ReadPlataDescr(New clPLATA_DESCR_E154)
        RequestBufferStream(RealBufSize)


        SetOUT(0)

        Dim parametr As New clLcardGidro.clW_ADC_PARAM_U_0


        Dim cnl(127) As UInt32

        With parametr



            .s_Type = clLcardGidro.L_ADC_PARAM
            .AutoInit = 1
            '.dRate = 80.0
            .dRate = CDbl(val)
            .dKadr = 0.0
            .dScale = 0
            .SynchroType = 0
            .SynchroSensitivity = 0
            .SynchroMode = 0
            .AdChannel = 0
            .AdPorog = 0
            .NCh = 8
            '.Kadr = 0

            cnl(0) = &H0
            cnl(1) = &H1
            cnl(2) = &H2
            cnl(3) = &H3
            cnl(4) = &H4
            cnl(5) = &H5
            cnl(6) = &H6
            cnl(7) = &H7
            cnl(8) = &H8
            'cnl(9) = &H9

            .Chn = cnl

            .FIFO = 4096
            .IrqStep = 4096
            .Pages = 32
            .IrqEna = 1
            .AdcEna = 1

            .IrqEna = 1
            .AdcEna = 1

        End With


        FillDAQparameters(parametr)

        'cnl(0) = 0
        'parametr.Chn = cnl

        SetParametersStream(parametr, RealBufSize)

        EnableCorrection(True)

        InitStartLDevice()
        StartLDevice()


        ''Dim halfbuffer As UInteger = (parametr.IrqStep / 2) * parametr.Pages               'Собираем половинками кольцевого буфера
        Dim halfbuffer As UInteger = BufSize / 2

        Dim syncd As UInteger

        GetSyncData(syncd)

        Dim fl2, fl1 As UInteger

        fl2 = IIf((syncd <= halfbuffer), 0, 1)                        'Настроили флаги
        fl1 = fl2

        While (mCancel And bRun)



            ReDim mRecBuf(BufSize * 2 - 1)
            ReDim mRecHalfBuf1(BufSize - 1)
            ReDim mRecHalfBuf2(BufSize - 1)

            For i As Integer = 0 To 1
                While (fl2 = fl1)
                    mCancel = GetSyncData(syncd)
                    fl2 = IIf((syncd <= halfbuffer), 0, 1)                          'Ждем заполнения половинки буфера
                    If mCancel = False Then Exit For
                End While
                'Настраиваем указатель в кольцевом буфере
                If fl1 = 0 Then
                    mCancel = GetDataFromBuffer(halfbuffer * fl1 * 2, mRecHalfBuf1, BufSize)
                    'Debug.Print("syncd-{0}", syncd)
                Else
                    mCancel = GetDataFromBuffer(halfbuffer * fl1 * 2, mRecHalfBuf2, BufSize)
                    'Debug.Print("syncd-{0}", syncd)
                End If

                mCancel = GetSyncData(syncd)
                fl1 = IIf((syncd <= halfbuffer), 0, 1)                                 'Обновляем флаг

            Next

            'копируем данные в буферы для каждого из 16 каналов АЦП
            Array.Copy(mRecHalfBuf1, 0, mRecBuf, 0, BufSize)
            Array.Copy(mRecHalfBuf2, 0, mRecBuf, BufSize, BufSize)
            'ArrayConvert(mRecBuf, mBuf0)
            '
            SecventChanal()

            'Select Case mSinhroChanel
            '    Case 0
            '        Sinhro(mBuf0, mSinhroLevel, 500)
            '    Case 1
            '        Sinhro(mBuf1, mSinhroLevel, 500)
            '    Case 2
            '        Sinhro(mBuf2, mSinhroLevel, 500)
            '    Case 3
            '        Sinhro(mBuf3, mSinhroLevel, 500)
            '    Case 4
            '        Sinhro(mBuf4, mSinhroLevel, 500)
            '        'Case 5
            '        '    Sinhro(mBuf5, mSinhroLevel, 500)
            '        'Case 6
            '        '    Sinhro(mBuf6, mSinhroLevel, 500)
            '        'Case 7
            '        '    Sinhro(mBuf7, mSinhroLevel, 500)
            '        'Case 8
            '        '    Sinhro(mBuf8, mSinhroLevel, 500)
            '        'Case 9
            '        '    Sinhro(mBuf9, mSinhroLevel, 500)
            'End Select

            If mCancel Then
                oADC_Complete(mBuf0, mBuf1, mBuf2, mBuf3, mBuf4, mBuf5, mBuf6, mBuf7)

                'обновляет текщую частоту дисретизации для внешеного опроса
                _Rate = parametr.dRate

                If WriteEnable = True Then

                    If WriteCount > 0 Then
                        WriteCount -= 1
                        For i As Integer = 0 To mBuf0.GetUpperBound(0)
                            mSW.Write(vbCrLf & mBuf0(i) & vbTab)
                            mSW.Write(mBuf1(i) & vbTab)
                            mSW.Write(mBuf2(i) & vbTab)
                            mSW.Write(mBuf3(i) & vbTab)
                            mSW.Write(mBuf4(i) & vbTab)
                            mSW.Write(mBuf5(i) & vbTab)
                            mSW.Write(mBuf6(i) & vbTab)
                            mSW.Write(mBuf7(i))
                        Next
                        Debug.Print("lcard write - " & WriteCount)

                    Else
                        mSW.Close()
                        mSW = Nothing
                        WriteEnable = False
                        Debug.Print("lcard write  end ")

                    End If

                End If

            End If




            'Threading.Thread.Sleep(100)                               'Обновляем флаг

            'mCancel = False
        End While

        StopLDevice()

        mThread = Nothing

        If mSW IsNot Nothing Then
            'If mSW.
        End If

        WriteEnable = False

        isexist = False

    End Sub


    Private WriteEnable As Boolean = False
    Private WriteCount As Integer = 4
    Dim mFileName As String
    Dim mPath As String
    Dim mSW As StreamWriter

    Public Sub EnableWrite()

        mFileName = "current.adc"
        mPath = My.Application.Info.DirectoryPath & "\LOG\"

        Directory.CreateDirectory(mPath)

        File.Delete(mPath & mFileName)

        Dim fs As FileStream = File.Create(mPath & mFileName)
        fs.Close()
        fs = Nothing

        mSW = New StreamWriter(mPath & mFileName, True, Encoding.GetEncoding(1251))

        WriteCount = 4

        WriteEnable = True
    End Sub

    Public ReadOnly Property GetWriteEnable() As Boolean
        Get
            Return WriteEnable
        End Get
    End Property


    Private Sub SecventChanal()
        Dim i As Integer = 0

        ReDim mBuf0(BufSize / mChanels - 1)
        ReDim mBuf1(BufSize / mChanels - 1)
        ReDim mBuf2(BufSize / mChanels - 1)
        ReDim mBuf3(BufSize / mChanels - 1)
        ReDim mBuf4(BufSize / mChanels - 1)
        ReDim mBuf5(BufSize / mChanels - 1)
        ReDim mBuf6(BufSize / mChanels - 1)
        ReDim mBuf7(BufSize / mChanels - 1)
        'ReDim mBuf8(BufSize / 10 - 1)
        'ReDim mBuf9(BufSize / 10 - 1)
        'ReDim mBuf10(BufSize / 10 - 1)
        'ReDim mBuf11(BufSize / 10 - 1)
        'ReDim mBuf12(BufSize / 10 - 1)
        'ReDim mBuf13(BufSize / 10 - 1)
        'ReDim mBuf14(BufSize / 10 - 1)
        'ReDim mBuf15(BufSize / 10 - 1)

        For n As ULong = 0 To mRecBuf.GetUpperBound(0) Step (mChanels * 2)
            mBuf0(i) = BitConverter.ToInt16(mRecBuf, n)
            mBuf1(i) = BitConverter.ToInt16(mRecBuf, n + 2)
            mBuf2(i) = BitConverter.ToInt16(mRecBuf, n + 4)
            mBuf3(i) = BitConverter.ToInt16(mRecBuf, n + 6)
            mBuf4(i) = BitConverter.ToInt16(mRecBuf, n + 8)
            mBuf5(i) = BitConverter.ToInt16(mRecBuf, n + 10)
            mBuf6(i) = BitConverter.ToInt16(mRecBuf, n + 12)
            mBuf7(i) = BitConverter.ToInt16(mRecBuf, n + 14)
            'mBuf8(i) = BitConverter.ToInt16(mRecBuf, n + 16)
            'mBuf9(i) = BitConverter.ToInt16(mRecBuf, n + 18)
            i += 1
        Next

    End Sub


    Private Sub ReSizeArrays(ByVal idx As UInteger, ByVal Count As UInteger)

        For i As UInteger = 0 To Count - 1
            mBuf0(i) = mBuf0(i + idx)
            mBuf1(i) = mBuf1(i + idx)
            mBuf2(i) = mBuf2(i + idx)
            mBuf3(i) = mBuf3(i + idx)
            mBuf4(i) = mBuf4(i + idx)
            mBuf5(i) = mBuf5(i + idx)
            mBuf6(i) = mBuf6(i + idx)
            mBuf7(i) = mBuf7(i + idx)
            'mBuf8(i) = mBuf8(i + idx)
            'mBuf9(i) = mBuf9(i + idx)
        Next

        ReDim Preserve mBuf0(Count - 1)
        ReDim Preserve mBuf1(Count - 1)
        ReDim Preserve mBuf2(Count - 1)
        ReDim Preserve mBuf3(Count - 1)
        ReDim Preserve mBuf4(Count - 1)
        ReDim Preserve mBuf5(Count - 1)
        ReDim Preserve mBuf6(Count - 1)
        ReDim Preserve mBuf7(Count - 1)
        'ReDim Preserve mBuf8(Count - 1)
        'ReDim Preserve mBuf9(Count - 1)

    End Sub

    Private Sub Sinhro(ByVal Buf As Short(), ByVal Level As UShort, ByVal Count As UInteger)
        'find raise front

        Dim old_el As Short = Buf(0)
        Dim idx As UInteger = 0
        Dim perehod As Boolean = False

        For Each el As Short In Buf
            'check perehod to null
            If old_el <= 0 And el >= 0 Then perehod = True
            '
            If perehod = True Then
                If el > old_el And el >= Level Then
                    If (Buf.GetUpperBound(0) - idx) < Count Then
                        'найдена точка синхронизации в конце масива данных
                        'копируем первые Count елементов масива
                        'нет синхронизации
                        ReSizeArrays(0, Count)
                        Exit For
                    Else
                        'найдена точка синхронизации в допустимом месте массива
                        'копируем  Count елементов масива начиная с idx
                        ReSizeArrays(idx, Count)
                        Exit For
                    End If
                End If
            End If

            old_el = el
            idx += 1
        Next
    End Sub

    Private mParent As Form
    Private mThread As Thread


    Public Sub New(ByVal Parent As Form)

        mParent = Parent

        If Me.Initialize(0, "E154") Then

            mCancel = True
            bRun = True
            mThread = New Thread(AddressOf [Loop])
            'mThread = New Thread(AddressOf Thread_GetADC)
            mThread.Name = "Lcardnew"
            mThread.Priority = ThreadPriority.Highest
            mThread.Start(8.0)
            isexist = True
        Else
            isexist = False
            MessageBox.Show("Плата АЦП Е154 не найдена!", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private isexist As Boolean

    Public ReadOnly Property IsExistLCard() As Boolean
        Get
            Return isexist
        End Get
    End Property
    Private Sub ArrayConvert(ByRef source As Byte(), ByRef dest As Short())
        Dim i As Integer = 0
        For n As Integer = 0 To source.GetUpperBound(0) Step 2
            dest(i) = BitConverter.ToInt16(source, n)
            i += 1
        Next
    End Sub


    Public Event ADC_Complete(ByRef Ch0 As Short(), ByRef Ch1 As Short(), ByRef Ch2 As Short(), ByRef Ch3 As Short(), ByRef Ch4 As Short(), ByRef Ch5 As Short(), ByRef Ch6 As Short(), ByRef Ch7 As Short())

    Private Delegate Sub delegate_ADC_Complete(ByRef Ch0 As Short(), ByRef Ch1 As Short(), ByRef Ch2 As Short(), ByRef Ch3 As Short(), ByRef Ch4 As Short(), ByRef Ch5 As Short(), ByRef Ch6 As Short(), ByRef Ch7 As Short())

    Private Sub pUI_ADC_Complete(ByRef Ch0 As Short(), ByRef Ch1 As Short(), ByRef Ch2 As Short(), ByRef Ch3 As Short(), ByRef Ch4 As Short(), ByRef Ch5 As Short(), ByRef Ch6 As Short(), ByRef Ch7 As Short())
        RaiseEvent ADC_Complete(Ch0, Ch1, Ch2, Ch3, Ch4, Ch5, Ch6, Ch7)
    End Sub

    Private Sub oADC_Complete(ByRef Ch0 As Short(), ByRef Ch1 As Short(), ByRef Ch2 As Short(), ByRef Ch3 As Short(), ByRef Ch4 As Short(), ByRef Ch5 As Short(), ByRef Ch6 As Short(), ByRef Ch7 As Short())

        Dim UIUpdater As New delegate_ADC_Complete(AddressOf pUI_ADC_Complete)

        Try
            mParent.Invoke(UIUpdater, Ch0, Ch1, Ch2, Ch3, Ch4, Ch5, Ch6, Ch7)
        Catch ex As Exception
            Beep()
        End Try

    End Sub
End Class
