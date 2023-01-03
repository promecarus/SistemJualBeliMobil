Public Class FormPembeliTambah
    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        If (Not TextBoxNik.Text = "") And (Not TextBoxNama.Text = "") And (Not RichTextBoxAlamat.Text = "") Then
            If IsNumeric(TextBoxNik.Text) And TextBoxNik.Text.Length = 16 And Not FormPembeli.Pembeli.AvailabilityNik(TextBoxNik.Text) Then
                FormPembeli.Pembeli.Add(
                    TextBoxNik.Text,
                    TextBoxNama.Text,
                    RichTextBoxAlamat.Text
                )

                MessageBox.Show("Data pembeli baru berhasil ditambahkan.")
                Me.Hide()

                TextBoxNik.Text = ""
                TextBoxNama.Text = ""
                RichTextBoxAlamat.Text = ""
            ElseIf FormPembeli.Pembeli.AvailabilityNik(TextBoxNik.Text) Then
                MessageBox.Show("NIK sudah terdaftar!")
                TextBoxNik.Text = ""
            ElseIf Not IsNumeric(TextBoxNik.Text) Then
                MessageBox.Show("Input NIK harus angka!")
            ElseIf Not TextBoxNik.Text.Length = 16 Then
                MessageBox.Show("Input NIK harus 16 digit!")
            End If
        Else
            MessageBox.Show("Input tidak boleh kosong!")
        End If
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Hide()

        TextBoxNik.Text = ""
        TextBoxNama.Text = ""
        RichTextBoxAlamat.Text = ""
    End Sub
End Class