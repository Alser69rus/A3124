Public Class frmGIspitaniaData

    Dim ds As GidrogasitelDataSet
    Dim tam As GidrogasitelDataSetTableAdapters.TableAdapterManager
    Dim rw As clRWini

    Public Sub New(ByVal DataSet As GidrogasitelDataSet, ByVal _tam As GidrogasitelDataSetTableAdapters.TableAdapterManager, ByVal _rw As clRWini)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

        ds = DataSet
        tam = _tam
        rw = _rw

    End Sub


    Private Sub frmGIspitaniaData_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        With Me.cmbTypeTD
            .DataSource = ds.Apparats
            .DisplayMember = "Name"
            .DataBindings.Add("Tag", ds.Apparats, "ID")
        End With

        With Me.cmbAppointment
            .DataSource = ds.Appointment
            .DisplayMember = "Appointment"
            .DataBindings.Add("Tag", ds.Appointment, "ID")
        End With

        With Me.cmbOperator
            .DataSource = ds.Operators
            .DisplayMember = "Last"
            .DataBindings.Add("Tag", ds.Operators, "ID")
        End With

        With Me.cmbTypeRemonta
            .DataSource = ds.Remont
            .DisplayMember = "Remont"
            .DataBindings.Add("Tag", ds.Remont, "ID")
        End With
    End Sub

    Private Sub btnEditRemont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditRemont.Click
        Dim mValue As Object

        mValue = InputBox("Введите пароль:", , , , )

        If mValue = rw.PASSWORD Then

            tam.RemontTableAdapter.Fill(ds.Remont)
            Dim frmR As New frmRemont(ds)

            If frmR.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.cmbTypeRemonta.Text = frmR.Remont
                tam.RemontTableAdapter.Update(ds.Remont)
            Else
                tam.RemontTableAdapter.Fill(ds.Remont)
                With Me.cmbTypeRemonta
                    .DataSource = ds.Remont
                    .DisplayMember = "Remont"
                    '.DataBindings.Add("Tag", ds.Remont, "ID")
                End With
            End If

            frmR.Dispose()
            frmR = Nothing
        End If
        

    End Sub

    Private Sub btnEditEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditEmployee.Click

        Dim mValue As Object

        mValue = InputBox("Введите пароль:", , , , )

        If mValue = rw.PASSWORD Then
            tam.OperatorsTableAdapter.Fill(ds.Operators)
            Dim frmEE As New frmEmployee(ds)
            If frmEE.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.cmbOperator.Text = frmEE.LastName
                tam.OperatorsTableAdapter.Update(ds.Operators)
            Else
                tam.OperatorsTableAdapter.Fill(ds.Operators)
                With Me.cmbOperator
                    .DataSource = ds.Operators
                    .DisplayMember = "Last"
                    '.DataBindings.Add("Tag", ds.Operators, "ID")
                End With
            End If

            frmEE = Nothing
        End If
        
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

 
  
    Private Sub btnApparatEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApparatEdit.Click

        Dim mValue As Object

        mValue = InputBox("Введите пароль:", , , , )

        If mValue = rw.PASSWORD Then
            tam.ApparatsTableAdapter.Fill(ds.Apparats)
            Dim f As New frmApparats(ds, rw)
            If f.ShowDialog() = Windows.Forms.DialogResult.OK Then
                tam.ApparatsTableAdapter.Update(ds.Apparats)
            Else
                tam.ApparatsTableAdapter.Fill(ds.Apparats)
                With Me.cmbTypeTD
                    .DataSource = ds.Apparats
                    .DisplayMember = "Name"
                    '.DataBindings.Add("Tag", ds.Apparats, "ID")
                End With
            End If

            f.Dispose()
            f = Nothing
        End If

    End Sub

   
    Private Sub btnAppointment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAppointment.Click
        Dim mValue As Object

        mValue = InputBox("Введите пароль:", , , , )

        If mValue = rw.PASSWORD Then
            tam.AppointmentTableAdapter.Fill(ds.Appointment)
            Dim f As New frmAppointment(ds)
            If f.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.cmbAppointment.Text = f.txtAppointment.Text
                tam.AppointmentTableAdapter.Update(ds.Appointment)
            Else
                tam.AppointmentTableAdapter.Fill(ds.Appointment)
                With Me.cmbAppointment
                    .DataSource = ds.Appointment
                    .DisplayMember = "Appointment"
                    '.DataBindings.Add("Tag", ds.Appointment, "ID")
                End With
            End If

            f.Dispose()
            f = Nothing
        End If
    End Sub
End Class