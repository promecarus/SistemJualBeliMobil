Public Class FormJenisMobilHapus

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblJenisMobil.Text = FormJenisMobil.JenisMobil.jenisProperty

    End Sub

    Private Sub ButtonYes_Click(sender As Object, e As EventArgs) Handles BtnYes.Click
        FormJenisMobil.JenisMobil.Delete(FormJenisMobil.SelectedRowJenisMobil)

        MessageBox.Show("Data Jenis Mobil Dengan Nama " & FormJenisMobil.JenisMobil.jenisProperty & " Berhasil Dihapus.")

        Me.Hide()
    End Sub

    Private Sub ButtonNo_Click(sender As Object, e As EventArgs) Handles BtnNo.Click
        Me.Hide()
    End Sub

End Class