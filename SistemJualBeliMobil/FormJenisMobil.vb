Public Class FormJenisMobil

    Public Shared JenisMobil As New JenisMobil
    Public Shared SelectedRowJenisMobil As Integer

    Private Sub FormJenisMobil_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        DataGridJenisMobil.DataSource = JenisMobil.Read()
        DataGridJenisMobil.ClearSelection()
    End Sub

    Private Sub DataGridViewJenisMobil_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridJenisMobil.ColumnHeaderMouseClick
        DataGridJenisMobil.ClearSelection()
    End Sub

    Private Sub DataGridViewJenisMobil_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridJenisMobil.CellClick
        If (e.RowIndex >= 0) Then
            Dim index As Integer = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridJenisMobil.Rows(index)

            SelectedRowJenisMobil = selectedRow.Cells(0).Value
        End If
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        FormJenisMobilTambah.Show()
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Try
            Dim selectedJenisMobil As List(Of String) = JenisMobil.DetailsById(SelectedRowJenisMobil)

            JenisMobil.jenisProperty = selectedJenisMobil(1)

            FormJenisMobilEdit.Show()
        Catch ex As Exception
            MessageBox.Show("Pilih Row Terlebih Dahulu !!")
        End Try
    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Try
            Dim selectedJenisMobil As List(Of String) = JenisMobil.DetailsById(SelectedRowJenisMobil)

            JenisMobil.jenisProperty = selectedJenisMobil(1)

            Dim JenisMobilHapus = New FormJenisMobilHapus()
            JenisMobilHapus.Show()
        Catch ex As Exception
            MessageBox.Show("Pilih Row Terlebih Dahulu !!")
        End Try
    End Sub

    Private Sub FormJenisMobil_Closed(sender As Object, e As EventArgs) Handles Me.Closed
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
                DataGridJenisMobil.DataSource = Nothing
                DataGridJenisMobil.DataSource = JenisMobil.SearchById(TxtSearch.Text)
            Else
                DataGridJenisMobil.DataSource = Nothing
                DataGridJenisMobil.DataSource = JenisMobil.Read
            End If
        Else
            MessageBox.Show("Data input search harus angka!")
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