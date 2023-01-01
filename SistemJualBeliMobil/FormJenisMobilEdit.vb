Public Class FormJenisMobilEdit
    Private Sub FormJenisMobilEdit_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        TxtJenisMobil.Text = FormJenisMobil.JenisMobil.jenisProperty
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If TxtJenisMobil.Text = "" Then
            MessageBox.Show("Data Jenis Mobil Tidak Boleh Kosong !!")
        Else
            FormJenisMobil.JenisMobil.jenisProperty = TxtJenisMobil.Text.ToString()

            FormJenisMobil.JenisMobil.Update(
                FormJenisMobil.SelectedTableJenisMobil,
                FormJenisMobil.JenisMobil.jenisProperty
            )

            MessageBox.Show("Data Jenis Mobil dengan ID " & FormJenisMobil.SelectedTableJenisMobil & " Berhasil Diedit.")

            Me.Hide()
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Hide()
    End Sub

End Class