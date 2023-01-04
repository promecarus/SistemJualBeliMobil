Public Class FormJenisMobilEdit
    Private Sub FormJenisMobilEdit_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        TxtJenisMobil.Text = FormJenisMobil.JenisMobil.jenisProperty
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If TxtJenisMobil.Text = "" Then
            MessageBox.Show("Data jenis mobil tidak boleh kosong!")
        Else
            FormJenisMobil.JenisMobil.jenisProperty = TxtJenisMobil.Text.ToString()

            FormJenisMobil.JenisMobil.Update(
                FormJenisMobil.SelectedRowJenisMobil,
                FormJenisMobil.JenisMobil.jenisProperty
            )

            MessageBox.Show("Data jenis mobil dengan id " & FormJenisMobil.SelectedRowJenisMobil & " Berhasil Diedit.")

            Me.Hide()
        End If
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Hide()
    End Sub

End Class