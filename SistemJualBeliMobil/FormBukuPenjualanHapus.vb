Public Class FormBukuPenjualanHapus
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LabelIdPenjualan.Text = FormBukuPenjualan.SelectedRowBukuPenjualan
    End Sub

    Private Sub ButtonYes_Click(sender As Object, e As EventArgs) Handles ButtonYes.Click
        FormBukuPenjualan.BukuPenjualan.Delete(FormBukuPenjualan.SelectedRowBukuPenjualan)
        MessageBox.Show("Data buku penjualan dengan ID " & FormBukuPenjualan.SelectedRowBukuPenjualan & " berhasil dihapus.")
        Me.Hide()
    End Sub

    Private Sub ButtonNo_Click(sender As Object, e As EventArgs) Handles ButtonNo.Click
        Me.Hide()
    End Sub
End Class