Public Class FormBukuPenjualan
    Public Shared BukuPenjualan As New BukuPenjualan
    Public Shared Mobil As New Mobil
    Public Shared Pembeli As New Pembeli
    Public Shared SelectedRowBukuPenjualan As Integer

    Private Sub FormBukuPenjualan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        DataGridViewBukuPenjualan.DataSource = BukuPenjualan.Read()
        DataGridViewBukuPenjualan.ClearSelection()
    End Sub

    Private Sub DataGridViewBukuPenjualan_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewBukuPenjualan.ColumnHeaderMouseClick
        DataGridViewBukuPenjualan.ClearSelection()
    End Sub

    Private Sub DataGridViewBukuPenjualan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewBukuPenjualan.CellClick
        Dim index As Integer = e.RowIndex

        If index > -1 Then
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridViewBukuPenjualan.Rows(index)

            SelectedRowBukuPenjualan = selectedRow.Cells(0).Value
        End If
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        Dim jumlahMobil = Mobil.ReadTerjualBelum.Rows.Count
        Dim jumlahPembeli = Pembeli.Read.Rows.Count

        If jumlahMobil + jumlahPembeli > 0 Then
            FormBukuPenjualanTambah.Show()
        ElseIf jumlahMobil = 0 Then
            MessageBox.Show("Data mobil yang dapat dijual masih kosong, tambah data mobil terlebih dahulu!")
        ElseIf jumlahPembeli = 0 Then
            MessageBox.Show("Data pembeli masih kosong, tambah data pembeli terlebih dahulu!")
        End If
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        Try
            Dim selectedBukuPenjualan As List(Of String) = BukuPenjualan.DetailsById(SelectedRowBukuPenjualan)

            BukuPenjualan.idMobilProperty = selectedBukuPenjualan(1)
            BukuPenjualan.idPembeliProperty = selectedBukuPenjualan(2)
            BukuPenjualan.hargaTerjualProperty = selectedBukuPenjualan(3)
            BukuPenjualan.tanggalPenjualanProperty = selectedBukuPenjualan(4)

            FormBukuPenjualanEdit.Show()
        Catch ex As Exception
            MessageBox.Show("Pilih row terlebih dahulu!")
        End Try
    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        Try
            Dim selectedBukuPenjualan As List(Of String) = BukuPenjualan.DetailsById(SelectedRowBukuPenjualan)

            BukuPenjualan.idMobilProperty = selectedBukuPenjualan(1)

            Dim formHapus = New FormBukuPenjualanHapus()
            formHapus.Show()
        Catch ex As Exception
            MessageBox.Show("Pilih row terlebih dahulu!")
        End Try
    End Sub

    Private Sub FormBukuPenjualan_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormSignIn.Close()
    End Sub

    Private Sub ButtonManageCar_Click(sender As Object, e As EventArgs) Handles manageCarBtn.Click
        FormMobil.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonManageUser_Click(sender As Object, e As EventArgs) Handles ManageUserBtn.Click
        FormPembeli.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonDashboard_Click(sender As Object, e As EventArgs) Handles BtnIndex.Click
        FormDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        If IsNumeric(TxtSearch.Text) Then
            If Not TxtSearch.Text = "" Then
                DataGridViewBukuPenjualan.DataSource = Nothing
                DataGridViewBukuPenjualan.DataSource = BukuPenjualan.SearchById(TxtSearch.Text)
            Else
                DataGridViewBukuPenjualan.DataSource = Nothing
                DataGridViewBukuPenjualan.DataSource = BukuPenjualan.Read()
            End If
        Else
            MessageBox.Show("Data Input Search Harus Angka !!")
        End If
    End Sub

    Private Sub TextBoxSearch_Enter(sender As Object, e As EventArgs) Handles TxtSearch.Enter
        LblSearch.Text = ""
    End Sub

    Private Sub TextBoxSearch_Leave(sender As Object, e As EventArgs) Handles TxtSearch.Leave
        If TxtSearch.Text = "" Then
            LblSearch.Text = "Search by ID..."
        End If
    End Sub

    Private Sub ButtonSignOut_Click(sender As Object, e As EventArgs) Handles SignoutBtn.Click
        FormSignIn.Show()
        Me.Hide()
    End Sub
End Class