Public Class FormJenisMobilTambah

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        If TxtJenisMobil.Text = "" Then
            MessageBox.Show("Data Jenis Mobil Tidak Boleh Kosong !!")
        Else
            FormJenisMobil.JenisMobil.jenisProperty = TxtJenisMobil.Text.ToString()

            FormJenisMobil.JenisMobil.AddDataJenisMobilDatabase(FormJenisMobil.JenisMobil.jenisProperty)

            MessageBox.Show("Data Jenis Mobil Baru Berhasil Ditambahkan.")

            Me.Hide()
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Hide()
    End Sub

End Class