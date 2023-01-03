Public Class FormPembeli
    Public Shared Pembeli As New Pembeli
    Public Shared SelectedRowPembeli As Integer

    Private Sub FormPembeli_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        DataGridViewPembeli.DataSource = Pembeli.Read
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

            SelectedRowPembeli = selectedRow.Cells(0).Value
        End If
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        FormPembeliTambah.Show()
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        Try
            Dim selectedPembeli As List(Of String) = Pembeli.DetailsById(SelectedRowPembeli)

            Pembeli.nikProperty = selectedPembeli(1)
            Pembeli.namaProperty = selectedPembeli(2)
            Pembeli.alamatProperty = selectedPembeli(3)

            Dim formEdit = New FormPembeliEdit()
            formEdit.Show()
        Catch ex As Exception
            MessageBox.Show("Pilih row terlebih dahulu!")
        End Try
    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        Try
            Dim selectedPembeli As List(Of String) = Pembeli.DetailsById(SelectedRowPembeli)

            Pembeli.namaProperty = selectedPembeli(2)

            Dim formHapus = New FormPembeliHapus()
            formHapus.Show()
        Catch ex As Exception
            MessageBox.Show("Pilih row terlebih dahulu!")
        End Try
    End Sub

    Private Sub ButtonManageCar_Click(sender As Object, e As EventArgs) Handles manageCarBtn.Click
        FormMobil.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonTransaction_Click(sender As Object, e As EventArgs) Handles TransactionBtn.Click
        FormBukuPenjualan.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonDashboard_Click(sender As Object, e As EventArgs) Handles BtnIndex.Click
        FormDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        If IsNumeric(TxtSearch.Text) Then
            If Not TxtSearch.Text = "" Then
                DataGridViewPembeli.DataSource = Nothing
                DataGridViewPembeli.DataSource = Pembeli.SearchById(TxtSearch.Text)
            Else
                DataGridViewPembeli.DataSource = Nothing
                DataGridViewPembeli.DataSource = Pembeli.Read()
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

    Private Sub FormPembeli_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormSignIn.Close()
    End Sub

    Private Sub ButtonSignOut_Click(sender As Object, e As EventArgs) Handles SignoutBtn.Click
        FormSignIn.Show()
        Me.Hide()
    End Sub
End Class