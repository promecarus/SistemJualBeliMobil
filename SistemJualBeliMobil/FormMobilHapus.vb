Public Class FormMobilHapus

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblMobil.Text = FormMobil.SelectedTableMobil

    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        FormMobil.Mobil.DeleteDataMobilByIDDatabase(FormMobil.SelectedTableMobil)

        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class