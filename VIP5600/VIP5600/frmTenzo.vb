Public Class frmTenzo
    Dim lim As Integer
    Dim UOut As Single
    Dim UPow As Single
    Dim UIn As Single
    Dim CorA As Single
    Dim CorB As Single


    Dim avr(19) As Single
    Dim avs(19) As Single
    Dim cur As Integer = 0


    Private Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        frmDatchiki.Show()
        If frmGMain.opros.KM1.Sostoyanie Then
            frmGMain.stend.SetRazbor()
        End If
        Me.Close()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        frmDatchiki.Show()
        If frmGMain.opros.KM1.Sostoyanie Then
            frmGMain.stend.SetRazbor()
        End If
        Me.Close()

    End Sub

    Public Sub New()

        ' Этот вызов является обязательным для конструктора.
        InitializeComponent()

        ' Добавьте все инициализирующие действия после вызова InitializeComponent().

        lim = frmGMain.stend.rw.LIM_POWER
        UOut = frmGMain.stend.rw.U_OUT_TENZO
        UPow = frmGMain.stend.rw.U_POWER
        UIn = frmGMain.stend.rw.U_IN_POWER
        CorA = frmGMain.stend.rw.COR_A_TENZO
        CorB = frmGMain.stend.rw.COR_B_TENZO


        btnLim.Text = "Номинал тензодатчика " & lim & " Н"
        btnUOut.Text = "Напряжение тензодатчика " & UOut & " мВ"
        btnUPow.Text = "Выход преобразователя " & UPow & " В"
        btnUIn.Text = "Вход преобразователя " & UIn & " мВ"
        btnCorA.Text = "A=" & CorA & " В"
        btnCorB.Text = "B=" & CorB & " В"


    End Sub

    Private Sub btnOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOk.Click
        frmGMain.stend.rw.LIM_POWER = lim
        frmGMain.stend.rw.U_OUT_TENZO = UOut
        frmGMain.stend.rw.U_POWER = UPow
        frmGMain.stend.rw.COR_A_TENZO = CorA
        frmGMain.stend.rw.COR_B_TENZO = CorB


        frmDatchiki.Show()
        If frmGMain.opros.KM1.Sostoyanie Then
            frmGMain.stend.SetRazbor()
        End If
        Me.Close()

    End Sub

    Private Sub btnLim_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLim.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = lim
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            lim = frm.btnResult.Text
            btnLim.Text = "Номинал тензодатчика " & lim & " Н"
        End If
        frm.Dispose()

    End Sub

    Private Sub btnUOut_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUOut.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = UOut
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            UOut = frm.btnResult.Text
            btnUOut.Text = "Напряжение тензодатчика " & UOut & " мВ"
        End If
        frm.Dispose()
    End Sub

    Private Sub btnUPow_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUPow.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = UPow
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            UPow = frm.btnResult.Text
            btnUPow.Text = "Выход преобразователя " & UPow & " В"
        End If
        frm.Dispose()
    End Sub

    Public Sub RefreshDig()
        btnReg.ImageIndex = frmGMain.stend.GetRegim
    End Sub

    Public Sub RefreshOsc()
        Dim r, s As Single
        r = frmGMain.opros.Brast_max.GetValue(6)
        s = frmGMain.opros.Bsjat_max.GetValue(6)

        avs(cur) = s
        avr(cur) = r

        cur = cur + 1
        If cur > 19 Then cur = 0

        For i = 0 To 19
            s = s + avs(i)
            r = r + avr(i)
        Next

        s = s / 20
        r = r / 20


        btnD.Text = "R-S=" & (r - s)

       

    End Sub

    Private Sub btnReg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReg.Click
        If frmGMain.opros.KM1.Sostoyanie Then
            frmGMain.stend.SetRazbor()
        Else
            frmGMain.stend.SetSbor()

        End If
    End Sub

    Private Sub btnUIn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUIn.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = UIn
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            UIn = frm.btnResult.Text
            btnUIn.Text = "Вход преобразователя " & UIn & " мВ"
        End If
        frm.Dispose()
    End Sub

   
    Private Sub btnCorA_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCorA.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = CorA
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            CorA = frm.btnResult.Text
            btnCorA.Text = "A=" & CorA & " В"
        End If
        frm.Dispose()
    End Sub

    Private Sub btnCorB_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCorB.Click
        Dim frm As New frmNumpad
        frm.btnResult.Text = CorB
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            CorB = frm.btnResult.Text
            btnCorB.Text = "B=" & CorB & " В"
        End If
        frm.Dispose()
    End Sub
End Class