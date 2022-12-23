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
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        Try
            Dim selectedPembeli As List(Of String) = dataPembeli.GetDataPembeliByIDDatabase(selectedRowPembeli)

            dataPembeli.nikProperty = selectedPembeli(1)
            dataPembeli.namaProperty = selectedPembeli(2)
            dataPembeli.alamatProperty = selectedPembeli(3)

            Dim formEdit = New FormPembeliEdit()
            formEdit.Show()
        Catch ex As Exception
            MessageBox.Show("Pilih row terlebih dahulu!")
        End Try
    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        Try
            Dim selectedPembeli As List(Of String) = dataPembeli.GetDataPembeliByIDDatabase(selectedRowPembeli)

            dataPembeli.namaProperty = selectedPembeli(2)

            Dim formHapus = New FormPembeliHapus()
            formHapus.Show()
        Catch ex As Exception
            MessageBox.Show("Pilih row terlebih dahulu!")
        End Try
    End Sub

    Private Sub manageCarBtn_Click(sender As Object, e As EventArgs) Handles manageCarBtn.Click
        FormMobil.Show()
        Me.Hide()
    End Sub

    Private Sub TransactionBtn_Click(sender As Object, e As EventArgs) Handles TransactionBtn.Click
        FormBukuPenjualan.Show()
        Me.Hide()
    End Sub
    Private Sub BtnIndex_Click(sender As Object, e As EventArgs)
        FormDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub BtnIndex_Click_1(sender As Object, e As EventArgs) Handles BtnIndex.Click
        FormDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        If Not TxtSearch.Text = "" Then
            DataGridViewPembeli.DataSource = Nothing
            DataGridViewPembeli.DataSource = dataPembeli.GetDataPembeliDatabaseSearch(TxtSearch.Text)
        Else
            DataGridViewPembeli.DataSource = Nothing
            DataGridViewPembeli.DataSource = dataPembeli.GetDataPembeliDatabase()
        End If
    End Sub

    Private Sub TxtSearch_Enter(sender As Object, e As EventArgs) Handles TxtSearch.Enter
        Label1.Text = ""
    End Sub

    Private Sub TxtSearch_Leave(sender As Object, e As EventArgs) Handles TxtSearch.Leave
        If TxtSearch.Text = "" Then
            Label1.Text = "Search by ID..."
        End If
    End Sub

    Private Sub FormPembeli_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormSignIn.Close()
    End Sub
End Class