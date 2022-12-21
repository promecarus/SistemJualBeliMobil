Public Class FormPembeliTambah
    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        If (Not TextBoxNik.Text = "") And (Not TextBoxNama.Text = "") And (Not RichTextBoxAlamat.Text = "") Then
            If IsNumeric(TextBoxNik.Text) Then
                FormPembeli.dataPembeli.AddDataPembeliDatabase(
                    TextBoxNik.Text,
                    TextBoxNama.Text,
                    RichTextBoxAlamat.Text
                )

                MessageBox.Show("Data pembeli baru berhasil ditambahkan.")
                Me.Hide()
            Else
                MessageBox.Show("Input NIK harus angka!")
            End If
        Else
            MessageBox.Show("Input tidak boleh kosong!")
        End If
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Hide()
    End Sub

End Class