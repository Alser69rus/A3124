Public Class clLoger
    Public Event WriteEvent(ByVal Value As String)

    Dim window As Form
    Public Sub New(ByVal frm As Form)
        window = frm
    End Sub

    Public Sub Write(ByVal value As String)
        oWriteEvent(value)
    End Sub

    Private Sub pUIWriteEvent(ByVal value As String)
        RaiseEvent WriteEvent(value)
    End Sub

    Private Delegate Sub delegateWriteEvent(ByVal value As String)

    Private Sub oWriteEvent(ByVal value As String)

        Dim UIUpdater As New delegateWriteEvent(AddressOf pUIWriteEvent)

        Try
            window.BeginInvoke(UIUpdater, value)
        Catch ex As Exception
            Beep()
        End Try
    End Sub

End Class
