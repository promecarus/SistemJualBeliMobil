Public Class FormJenisMobilTambah

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        If TxtJenisMobil.Text = "" Then
            MessageBox.Show("Data Jenis Mobil Tidak Boleh Kosong !!")
        Else
            FormJenisMobil.JenisMobil.Add(TxtJenisMobil.Text)

            MessageBox.Show("Data Jenis Mobil Baru Berhasil Ditambahkan.")

            Me.Hide()

            TxtJenisMobil.Text = ""
        End If
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Hide()

        TxtJenisMobil.Text = ""
    End Sub

End Class