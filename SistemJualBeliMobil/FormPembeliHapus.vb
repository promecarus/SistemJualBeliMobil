Public Class FormPembeliHapus
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LabelNamaPembeli.Text = FormPembeli.dataPembeli.namaProperty
    End Sub

    Private Sub ButtonYes_Click(sender As Object, e As EventArgs) Handles ButtonYes.Click
        FormPembeli.dataPembeli.DeleteDataPembeliByIDDatabase(FormPembeli.selectedRowPembeli)
        MessageBox.Show("Data pembeli dengan ID " & FormPembeli.selectedRowPembeli & " berhasil dihapus.")
        Me.Close()
        FormPembeli.Show()
    End Sub

    Private Sub ButtonNo_Click(sender As Object, e As EventArgs) Handles ButtonNo.Click
        Me.Close()
        FormPembeli.Show()
    End Sub

    Private Sub FormPembeliHapus_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub
End Class