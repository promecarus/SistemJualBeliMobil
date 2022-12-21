Public Class FormBukuPenjualanHapus
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LabelIdPenjualan.Text = FormBukuPenjualan.selectedRowBukuPenjualan
    End Sub

    Private Sub ButtonYes_Click(sender As Object, e As EventArgs) Handles ButtonYes.Click
        FormBukuPenjualan.dataBukuPenjualan.DeleteDataBukuPenjualanByIDDatabase(FormBukuPenjualan.selectedRowBukuPenjualan)
        MessageBox.Show("Data buku penjualan dengan ID " & FormBukuPenjualan.selectedRowBukuPenjualan & " berhasil dihapus.")
        Me.Hide()
    End Sub

    Private Sub ButtonNo_Click(sender As Object, e As EventArgs) Handles ButtonNo.Click
        Me.Hide()
    End Sub

    Private Sub PictureBoxBack_Click(sender As Object, e As EventArgs) Handles PictureBoxBack.Click
        Me.Hide()
    End Sub
End Class