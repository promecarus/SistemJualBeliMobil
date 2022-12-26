Public Class FormJenisMobil

    Public Shared JenisMobil As JenisMobil
    Public Shared SelectedTableJenisMobil
    Public Shared SelectedTableJenisMobilNama

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        JenisMobil = New JenisMobil()

    End Sub

    Private Sub FormJenisMobil_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        DataGridJenisMobil.DataSource = JenisMobil.GetDataJenisMobilDatabase()
        DataGridJenisMobil.ClearSelection()
    End Sub

    Private Sub DataGridJenisMobil_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridJenisMobil.ColumnHeaderMouseClick
        DataGridJenisMobil.ClearSelection()
    End Sub

    Private Sub DataGridJenisMobil_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridJenisMobil.CellClick
        If (e.RowIndex >= 0) Then
            Dim index As Integer = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridJenisMobil.Rows(index)

            SelectedTableJenisMobil = selectedRow.Cells(0).Value
            SelectedTableJenisMobilNama = selectedRow.Cells(1).Value
        End If
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        FormJenisMobilTambah.Show()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Try
            Dim selectedJenisMobil As List(Of String) = JenisMobil.GetDataJenisMobilByIDDatabase(SelectedTableJenisMobil)

            JenisMobil.jenisProperty = selectedJenisMobil(1)

            Dim JenisMobilEdit = New FormJenisMobilEdit()
            JenisMobilEdit.Show()
        Catch ex As Exception
            MessageBox.Show("Pilih Row Terlebih Dahulu !!")
        End Try
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Try
            Dim selectedJenisMobil As List(Of String) = JenisMobil.GetDataJenisMobilByIDDatabase(SelectedTableJenisMobil)

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

    Private Sub manageCarBtn_Click(sender As Object, e As EventArgs) Handles manageCarBtn.Click
        FormMobil.Show()
        Me.Hide()
    End Sub

    Private Sub ManageUserBtn_Click(sender As Object, e As EventArgs) Handles ManageUserBtn.Click
        FormPembeli.Show()
        Me.Hide()
    End Sub

    Private Sub TransactionBtn_Click(sender As Object, e As EventArgs) Handles TransactionBtn.Click
        FormBukuPenjualan.Show()
        Me.Hide()
    End Sub

    Private Sub BtnIndex_Click(sender As Object, e As EventArgs) Handles BtnIndex.Click
        FormDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        If Not TxtSearch.Text = "" Then
            DataGridJenisMobil.DataSource = Nothing
            DataGridJenisMobil.DataSource = JenisMobil.GetDataJenisMobilDatabaseSearch(TxtSearch.Text)
        Else
            DataGridJenisMobil.DataSource = Nothing
            DataGridJenisMobil.DataSource = JenisMobil.GetDataJenisMobilDatabase
        End If
    End Sub

    Private Sub TxtSearch_Enter(sender As Object, e As EventArgs) Handles TxtSearch.Enter
        LblSearch.Text = ""
    End Sub

    Private Sub TxtSearch_Leave(sender As Object, e As EventArgs) Handles TxtSearch.Leave
        If TxtSearch.Text = "" Then
            LblSearch.Text = "Search by ID..."
        End If
    End Sub

    Private Sub SignoutBtn_Click(sender As Object, e As EventArgs) Handles SignoutBtn.Click
        FormSignIn.Show()
        Me.Hide()
    End Sub

End Class