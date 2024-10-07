Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports System.Reflection

Public Class clLog
    Implements IDisposable

    Private mFileName As String
    Private mPath As String
    Private mSW As StreamWriter
    Private mLogEnable As Boolean = False
    Private num As Integer = 0



    Public Sub New()
        mLogEnable = False
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="filename"> имя файла без расширения</param>
    ''' <remarks></remarks>
    Public Sub Open(ByVal filename As String, ByVal title As String)
        SyncLock Me
            'создаем новый файл Log 
            mFileName = filename & ".log"
            mPath = My.Application.Info.DirectoryPath & "\LOG\"
            mLogEnable = True

            Directory.CreateDirectory(mPath)

            'Try
            '    Dim files As String() = Directory.GetFiles(mPath, "*.log")
            '    For Each file As String In files
            '        IO.File.Delete(file)
            '    Next
            '    files = Nothing
            'Catch ex As Exception
            '    'Debug.Assert(True, ex.Message)
            'End Try


            Dim fs As FileStream = File.Create(mPath & mFileName)
            fs.Close()
            fs.Dispose()
            fs = Nothing

            mSW = New StreamWriter(mPath & mFileName, True)
            mSW.WriteLine(title)
            num = 0
        End SyncLock

    End Sub

    Public Sub Close()
        SyncLock Me
            EnableLog = False
            mSW.Close()
            mSW.Dispose()
            mSW = Nothing

        End SyncLock

    End Sub
    Public Property EnableLog() As Boolean
        Get
            Return mLogEnable
        End Get
        Set(ByVal value As Boolean)
            mLogEnable = value
        End Set
    End Property

    Public Sub Write(ByVal message As String, Optional ByVal AddCrlf As Boolean = True)
        SyncLock Me
            Try
                'Dim mSW As StreamWriter
                'mSW = New StreamWriter(mPath & mFileName, True)
                If mSW IsNot Nothing Then

                    If mLogEnable Then
                        If AddCrlf Then

                            mSW.WriteLine(num.ToString & vbTab & message)
                        Else
                            mSW.Write(num.ToString & vbTab & message)
                        End If
                        num += 1
                    End If
                End If





                'mSW.Close()
                'mSW.Dispose()
                'mSW = Nothing
            Catch ex As Exception
                'Debug.Assert(True, ex.Message)
            End Try
        End SyncLock

    End Sub



    Private disposedValue As Boolean = False        ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                '' TODO: free unmanaged resources when explicitly called

                mFileName = Nothing
                mPath = Nothing
            End If

            ' TODO: free shared unmanaged resources
        End If
        Me.disposedValue = True

    End Sub


#Region " IDisposable Support "
    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.

        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region


End Class
