Public Class FormPembeli
    Public Shared dataPembeli As Pembeli
    Public Shared selectedRowPembeli

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dataPembeli = New Pembeli
    End Sub

    Private Sub FormPembeli_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        DataGridViewPembeli.DataSource = dataPembeli.GetDataPembeliDatabase
        DataGridViewPembeli.ClearSelection()
    End Sub

    Private Sub DataGridViewPembeli_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewPembeli.ColumnHeaderMouseClick
        DataGridViewPembeli.ClearSelection()
    End Sub

    Private Sub DataGridViewPembeli_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPembeli.CellClick
        Dim index As Integer = e.RowIndex

        If index > -1 Then
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridViewPembeli.Rows(index)

            selectedRowPembeli = selectedRow.Cells(0).Value
        End If
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        FormPembeliTambah.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        Try
            Dim selectedKoleksi As List(Of String) = dataPembeli.GetDataPembeliByIDDatabase(selectedRowPembeli)

            dataPembeli.nikProperty = selectedKoleksi(1)
            dataPembeli.namaProperty = selectedKoleksi(2)
            dataPembeli.alamatProperty = selectedKoleksi(3)

            Dim formEdit = New FormPembeliEdit()
            formEdit.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Pilih row terlebih dahulu!")
        End Try
    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        Try
            Dim selectedKoleksi As List(Of String) = dataPembeli.GetDataPembeliByIDDatabase(selectedRowPembeli)

            dataPembeli.namaProperty = selectedKoleksi(2)

            Dim formHapus = New FormPembeliHapus()
            formHapus.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Pilih row terlebih dahulu!")
        End Try
    End Sub

    Private Sub FormPembeli_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormSignIn.Close()
    End Sub
End Class