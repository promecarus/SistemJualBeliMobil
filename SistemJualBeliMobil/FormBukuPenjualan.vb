Public Class FormBukuPenjualan
    Public Shared dataBukuPenjualan As BukuPenjualan
    Public Shared selectedRowBukuPenjualan

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dataBukuPenjualan = New BukuPenjualan
    End Sub

    Private Sub FormBukuPenjualan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        DataGridViewBukuPenjualan.DataSource = dataBukuPenjualan.GetDataBukuPenjualanDatabase()
        DataGridViewBukuPenjualan.ClearSelection()
    End Sub

    Private Sub DataGridViewBukuPenjualan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewBukuPenjualan.CellClick
        Try
            Dim index As Integer = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridViewBukuPenjualan.Rows(index)

            selectedRowBukuPenjualan = selectedRow.Cells(0).Value
        Catch ex As Exception
            MessageBox.Show("Fitur sorting belum tersedia!")
        End Try
    End Sub

    Private Sub FormBukuPenjualan_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub
End Class