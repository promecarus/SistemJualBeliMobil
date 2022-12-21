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
                Me.Close()
                FormPembeli.Show()
            Else
                MessageBox.Show("Input NIK harus angka!")
            End If
        Else
            MessageBox.Show("Input tidak boleh kosong!")
        End If
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
        FormPembeli.Show()
    End Sub

    Private Sub PictureBoxBack_Click(sender As Object, e As EventArgs) Handles PictureBoxBack.Click
        Me.Close()
        FormPembeli.Show()
    End Sub

    Private Sub FormPembeliEdit_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormSignIn.Close()
    End Sub

    Private Sub TextBoxNik_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNik.TextChanged

    End Sub

    Private Sub LabelAlamat_Click(sender As Object, e As EventArgs) Handles LabelAlamat.Click

    End Sub
End Class