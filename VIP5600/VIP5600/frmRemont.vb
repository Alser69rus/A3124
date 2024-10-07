Public Class frmRemont

    Dim ds As GidrogasitelDataSet

    Public Sub New(ByVal DataSet As GidrogasitelDataSet)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ds = DataSet
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Me.ds.Remont.AddRemontRow("<Ремонт>")
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Dim row As GidrogasitelDataSet.RemontRow = ds.Remont.FindByID(Me.txtRemont.Tag)
        Me.ds.Remont.RemoveRemontRow(row)

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim row As GidrogasitelDataSet.RemontRow = ds.Remont.FindByID(Me.txtRemont.Tag)
        row.Remont = Me.txtRemont.Text
    End Sub

    Public Remont As String
    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Dim row As GidrogasitelDataSet.RemontRow = ds.Remont.FindByID(Me.txtRemont.Tag)
        Remont = row.Remont
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub frmRemont_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        With Me.lstRemont
            .DataSource = ds.Remont
            .DisplayMember = "Remont"
        End With

        Me.txtRemont.DataBindings.Add("Text", ds.Remont, "Remont")
        Me.txtRemont.DataBindings.Add("Tag", ds.Remont, "ID")
    End Sub



End Class