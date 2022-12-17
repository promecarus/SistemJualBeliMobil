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
        FormPembeli.dataPembeli.UpdateDataPembeliByIDDatabase(
            FormPembeli.selectedRowPembeli,
            TextBoxNik.Text,
            TextBoxNama.Text,
            RichTextBoxAlamat.Text
        )

        MessageBox.Show("Data pembeli dengan ID " & FormPembeli.selectedRowPembeli & " berhasil diedit.")
        Me.Close()
        FormPembeli.Show()
    End Sub

    Private Sub FormPembeliEdit_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub
End Class