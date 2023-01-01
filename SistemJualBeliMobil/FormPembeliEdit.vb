Public Class FormPembeliEdit
    Private Sub FormPembeliEdit_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        TextBoxNik.Text = FormPembeli.Pembeli.nikProperty
        TextBoxNama.Text = FormPembeli.Pembeli.namaProperty
        RichTextBoxAlamat.Text = FormPembeli.Pembeli.alamatProperty
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        If (Not TextBoxNik.Text = "") And (Not TextBoxNama.Text = "") And (Not RichTextBoxAlamat.Text = "") Then
            If IsNumeric(TextBoxNik.Text) Then
                FormPembeli.Pembeli.Update(
                    FormPembeli.SelectedRowPembeli,
                    TextBoxNik.Text,
                    TextBoxNama.Text,
                    RichTextBoxAlamat.Text
                )

                MessageBox.Show("Data pembeli dengan ID " & FormPembeli.SelectedRowPembeli & " berhasil diedit.")
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