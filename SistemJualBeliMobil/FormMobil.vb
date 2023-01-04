Public Class FormMobil
    Public Shared Mobil As New Mobil
    Public Shared JenisMobil As New JenisMobil
    Public Shared SelectedRowMobil As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        RdbNone.Checked = True
        BtnSearch.Enabled = False

    End Sub

    Private Sub FormMobil_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTable()
        DataGridMobil.ClearSelection()
    End Sub

    Private Sub ReloadDataTable()
        DataGridMobil.DataSource = Nothing
        DataGridMobil.DataSource = Mobil.Read()
    End Sub

    Private Sub ReloadDataTableSearchNone()
        DataGridMobil.DataSource = Nothing
        DataGridMobil.DataSource = Mobil.SearchNone(TxtSearch.Text)
    End Sub

    Private Sub ReloadDataTableSearchTerjual()
        DataGridMobil.DataSource = Nothing
        DataGridMobil.DataSource = Mobil.SearchTerjual(TxtSearch.Text)
    End Sub

    Private Sub ReloadDataTableSearchTerjualBelum()
        DataGridMobil.DataSource = Nothing
        DataGridMobil.DataSource = Mobil.SearchTerjualBelum(TxtSearch.Text)
    End Sub

    Private Sub ReloadDataTableTerjual()
        DataGridMobil.DataSource = Nothing
        DataGridMobil.DataSource = Mobil.ReadTerjual()
    End Sub

    Private Sub ReloadDataTableTerjualBelum()
        DataGridMobil.DataSource = Nothing
        DataGridMobil.DataSource = Mobil.ReadTerjualBelum()
    End Sub

    Private Sub DataGridViewMobil_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridMobil.ColumnHeaderMouseClick
        DataGridMobil.ClearSelection()
    End Sub

    Private Sub DataGridViewMobil_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridMobil.CellClick
        If (e.RowIndex >= 0) Then
            Dim index As Integer = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridMobil.Rows(index)

            SelectedRowMobil = selectedRow.Cells(0).Value
        End If
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim jumlahJenisMobil = JenisMobil.Read.Rows.Count

        If jumlahJenisMobil > 0 Then
            FormMobilTambah.Show()
        ElseIf jumlahJenisMobil = 0 Then
            MessageBox.Show("Data jenis mobil masih kosong, tambah data jenis mobil terlebih dahulu!")
        End If
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Try
            Dim selectedMobil As List(Of String) = Mobil.DetailsById(SelectedRowMobil)

            Mobil.idJenisMobilProperty = selectedMobil(1)
            Mobil.tipeMobilProperty = selectedMobil(2)
            Mobil.tahunPembuatanProperty = selectedMobil(3)
            Mobil.kondisiProperty = selectedMobil(4)
            Mobil.garansiProperty = selectedMobil(6)
            Mobil.hargaDefaultProperty = selectedMobil(8)

            FormMobilEdit.Show()
        Catch ex As Exception
            MessageBox.Show("Pilih row terlebih dahulu!")
        End Try
    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Try
            Dim selectedMobil As List(Of String) = Mobil.DetailsById(SelectedRowMobil)

            Mobil.idJenisMobilProperty = selectedMobil(1)

            Dim MobilHapus = New FormMobilHapus()
            MobilHapus.Show()
        Catch ex As Exception
            MessageBox.Show("Pilih row terlebih dahulu !!")
        End Try
    End Sub

    Private Sub FormMobil_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormSignIn.Close()
    End Sub

    Private Sub ButtonManageUser_Click(sender As Object, e As EventArgs) Handles ManageUserBtn.Click
        FormPembeli.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonDashboard_Click(sender As Object, e As EventArgs) Handles BtnIndex.Click
        FormDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonTransaction_Click(sender As Object, e As EventArgs) Handles TransactionBtn.Click
        FormBukuPenjualan.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonJenisMobil_Click(sender As Object, e As EventArgs) Handles BtnJenisMobil.Click
        FormJenisMobil.Show()
        Me.Hide()
    End Sub

    Private Sub RadioButtonNone_CheckedChanged(sender As Object, e As EventArgs) Handles RdbNone.CheckedChanged
        ReloadDataTable()
    End Sub

    Private Sub RadioButtonTerjual_CheckedChanged(sender As Object, e As EventArgs) Handles RdbTerjual.CheckedChanged
        ReloadDataTableTerjual()
    End Sub

    Private Sub RadioButtonTerjualBelum_CheckedChanged(sender As Object, e As EventArgs) Handles RdbBelumTerjual.CheckedChanged
        ReloadDataTableTerjualBelum()
    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        If IsNumeric(TxtSearch.Text) Then
            If Not TxtSearch.Text = "" And RdbNone.Checked Then
                ReloadDataTableSearchNone()
            ElseIf Not TxtSearch.Text = "" And RdbTerjual.Checked Then
                ReloadDataTableSearchTerjual()
            ElseIf Not TxtSearch.Text = "" And RdbBelumTerjual.Checked Then
                ReloadDataTableSearchTerjualBelum()
            Else
                ReloadDataTable()
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

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        BtnSearch.Enabled = True

        If TxtSearch.Text = "" Then
            BtnSearch.Enabled = False
        End If
    End Sub

    Private Sub ButtonSignOut_Click(sender As Object, e As EventArgs) Handles SignoutBtn.Click
        FormSignIn.Show()
        Me.Hide()
    End Sub

End Class