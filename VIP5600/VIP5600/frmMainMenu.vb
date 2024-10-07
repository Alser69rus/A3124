Public Class frmMainMenu





    Private Sub btnOption_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOption.Click
        Dim frm As New frmNumpad
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            If frmGMain.stend.rw.PASSWORD = "" Or frm.btnResult.Text = frmGMain.stend.rw.PASSWORD Then
                frmMenuOption.Show()
                Me.Close()
            End If
        End If


    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim objWMIService, objComputer As Object

        If Not CBool(frmGMain.stend.rw.SAFEMODE) Then
            objWMIService = GetObject("Winmgmts:{impersonationLevel=impersonate,(Debug,Shutdown)}")


            For Each objComputer In objWMIService.InstancesOf("Win32_OperatingSystem")

                objComputer.Win32shutdown(12, 0) '12 - выключить компьютер, 2 - перезагрузить
            Next


            frmGMain.stend.PowerOff()
            frmGMain.Close()
            Me.Close()
        Else
            frmGMain.Show()
            Me.Close()
        End If

    End Sub

    Private Sub btnManual_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnManual.Click
        frmManual.Show()
        Me.Close()

    End Sub

    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNew.Click
        aseIspNew.Show()
        Me.Close()
    End Sub

    Private Sub btnProtokol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProtokol.Click
        Dim frm As New aseBD
        frm.ShowDialog()

        frm.Dispose()

    End Sub
End Class