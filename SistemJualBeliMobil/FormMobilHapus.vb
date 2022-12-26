Public Class FormMobilHapus

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblMobil.Text = FormMobil.SelectedTableMobil

    End Sub

    Private Sub BtnYes_Click(sender As Object, e As EventArgs) Handles BtnYes.Click
        FormMobil.Mobil.Delete(FormMobil.SelectedTableMobil)

        MessageBox.Show("Data Mobil dengan ID " & FormMobil.SelectedTableMobil & " Berhasil Dihapus.")

        Me.Hide()
    End Sub

    Private Sub BtnNo_Click(sender As Object, e As EventArgs) Handles BtnNo.Click
        Me.Hide()
    End Sub

End Class