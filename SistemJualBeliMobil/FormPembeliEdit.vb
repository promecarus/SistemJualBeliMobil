Public Class FormPembeliEdit
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TextBoxNik.Text = FormPembeli.dataPembeli.nikProperty
        TextBoxNama.Text = FormPembeli.dataPembeli.namaProperty
        RichTextBoxAlamat.Text = FormPembeli.dataPembeli.alamatProperty
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        If (Not TextBoxNik.Text = "") And (Not TextBoxNama.Text = "") And (Not RichTextBoxAlamat.Text = "") Then
            If IsNumeric(TextBoxNik.Text) Then
                FormPembeli.dataPembeli.UpdateDataPembeliByIDDatabase(
                    FormPembeli.selectedRowPembeli,
                    TextBoxNik.Text,
                    TextBoxNama.Text,
                    RichTextBoxAlamat.Text
                )

                MessageBox.Show("Data pembeli dengan ID " & FormPembeli.selectedRowPembeli & " berhasil diedit.")
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

    Private Sub PictureBoxBack_Click(sender As Object, e As EventArgs) Handles PictureBoxBack.Click
        Me.Hide()
    End Sub
End Class