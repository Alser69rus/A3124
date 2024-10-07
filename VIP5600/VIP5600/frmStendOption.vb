Public Class frmStendOption
    Dim Port1 As Integer
    Dim port2 As Integer
    Dim Baudrate As Integer
    Dim Databits As Integer
    Dim Stopbits As String
    Dim Parity As String
    Dim Handshake As String
    Dim Path As String
    Dim Log As Boolean
    Dim Safe As Boolean



    Public Sub New()

        ' Этот вызов является обязательным для конструктора.
        InitializeComponent()

        ' Добавьте все инициализирующие действия после вызова InitializeComponent().
        Port1 = frmGMain.stend.rw.PORT
        port2 = frmGMain.stend.rw.PORT2
        Baudrate = frmGMain.stend.rw.BAUDRATE
        Databits = frmGMain.stend.rw.DATABITS
        Stopbits = frmGMain.stend.rw.STOPBITS
        Parity = frmGMain.stend.rw.PARITY
        Handshake = frmGMain.stend.rw.HANDSHAKE
        Path = frmGMain.stend.rw.PROTOKOL_PATH
        Log = frmGMain.stend.rw.ENABLE_LOG
        Safe = frmGMain.stend.rw.SAFEMODE

        btnPort1.Text = "Port1: COM" & Port1
        btnPort2.Text = "Port2: COM" & port2
        btnBaudrate.Text = "Baudrate " & Baudrate
        btnDatabits.Text = "Databits " & Databits
        btnStopbits.Text = "Stopbits " & Stopbits
        btnParity.Text = "Parity " & Parity
        btnHandshake.Text = "Handshake " & Handshake
        btnPath.Text = "Path: " & Path
        If Log Then
            btnLog.Text = "Лог вкл."
        Else
            btnLog.Text = "Лог откл."
        End If
        If Safe Then
            btnSafe.Text = "Отладка"
        Else
            btnSafe.Text = "Рабочий режим"
        End If




    End Sub

    Private Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        frmMenuOption.Show()
        Me.Close()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        frmMenuOption.Show()
        Me.Close()

    End Sub

    Private Sub btnOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOk.Click
        frmGMain.stend.rw.PORT = Port1
        frmGMain.stend.rw.PORT2 = port2
        frmGMain.stend.rw.BAUDRATE = Baudrate
        frmGMain.stend.rw.DATABITS = Databits
        frmGMain.stend.rw.STOPBITS = Stopbits
        frmGMain.stend.rw.PARITY = Parity
        frmGMain.stend.rw.HANDSHAKE = Handshake
        frmGMain.stend.rw.PROTOKOL_PATH = Path
        frmGMain.stend.rw.ENABLE_LOG = Log
        frmGMain.stend.rw.SAFEMODE = Safe
        frmMenuOption.Show()
        Me.Close()

    End Sub

    Private Sub btnPort1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPort1.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = Port1
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Port1 = frm.btnResult.Text
            btnPort1.Text = "Port1: COM" & Port1
        End If
        frm.Dispose()

    End Sub

    Private Sub btnPort2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPort2.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = port2
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            port2 = frm.btnResult.Text
            btnPort2.Text = "Port12: COM" & port2
        End If
        frm.Dispose()
    End Sub

    Private Sub btnBaudrate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBaudrate.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = Baudrate
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Baudrate = frm.btnResult.Text
            btnBaudrate.Text = "Baudrate " & Baudrate
        End If
        frm.Dispose()
    End Sub

    Private Sub btnDatabits_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDatabits.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = Databits
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Databits = frm.btnResult.Text
            btnDatabits.Text = "Databits " & Databits
        End If
        frm.Dispose()
    End Sub

    Private Sub btnStopbits_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStopbits.Click
        Dim frm As New frmKeypad
        frm.btnResult.Text = Stopbits
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Stopbits = frm.btnResult.Text
            btnStopbits.Text = "Stopbits " & Stopbits
        End If
        frm.Dispose()

    End Sub

    Private Sub btnParity_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnParity.Click
        Dim frm As New frmKeypad
        frm.btnResult.Text = Parity
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Parity = frm.btnResult.Text
            btnParity.Text = "Parity " & Parity
        End If
        frm.Dispose()
    End Sub

    Private Sub btnHandshake_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHandshake.Click
        Dim frm As New frmKeypad
        frm.btnResult.Text = Handshake
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Handshake = frm.btnResult.Text
            btnHandshake.Text = "Handshake " & Handshake
        End If
        frm.Dispose()
    End Sub

    Private Sub btnPath_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPath.Click
        Dim frm As New frmKeypad
        frm.btnResult.Text = Path
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Path = frm.btnResult.Text
            btnPath.Text = "Path: " & Path
        End If
        frm.Dispose()
    End Sub

    Private Sub btnLog_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLog.Click
        Log = Not Log
        If Log Then
            btnLog.Text = "Лог вкл."
        Else
            btnLog.Text = "Лог откл."
        End If
    End Sub

    Private Sub btnSafe_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSafe.Click
        Safe = Not Safe

        If Safe Then
            btnSafe.Text = "Отладка"
        Else
            btnSafe.Text = "Рабочий режим"
        End If
    End Sub
End Class