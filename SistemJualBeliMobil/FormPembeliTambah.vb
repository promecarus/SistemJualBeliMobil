Public Class FormPembeliTambah
    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        FormPembeli.dataPembeli.AddDataPembeliDatabase(
            TextBoxNik.Text,
            TextBoxNama.Text,
            RichTextBoxAlamat.Text
        )

        MessageBox.Show("Data pembeli baru berhasil ditambahkan.")
        Me.Close()
        FormPembeli.Show()
    End Sub

    Private Sub FormPembeliTambah_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub
End Class