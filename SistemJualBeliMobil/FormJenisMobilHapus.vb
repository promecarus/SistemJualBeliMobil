Public Class FormJenisMobilHapus

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblJenisMobil.Text = FormJenisMobil.SelectedTableJenisMobilNama

    End Sub

    Private Sub BtnYes_Click(sender As Object, e As EventArgs) Handles BtnYes.Click
        FormJenisMobil.JenisMobil.Delete(FormJenisMobil.SelectedTableJenisMobil)

        MessageBox.Show("Data Jenis Mobil Dengan ID " & FormJenisMobil.SelectedTableJenisMobil & " Berhasil Dihapus.")

        Me.Hide()
    End Sub

    Private Sub BtnNo_Click(sender As Object, e As EventArgs) Handles BtnNo.Click
        Me.Hide()
    End Sub

End Class