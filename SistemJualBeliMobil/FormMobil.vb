﻿Public Class FormMobil

    Public Shared Mobil As Mobil
    Public Shared SelectedTableMobil
    Public Shared SelectedTableMobilNama

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Mobil = New Mobil()
        RdbNone.Checked = True
        BtnSearch.Enabled = False

    End Sub

    Private Sub FormMobil_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
        DataGridMobil.ClearSelection()
    End Sub

    Public Sub ReloadDataTableDatabase()
        DataGridMobil.DataSource = Nothing
        DataGridMobil.DataSource = Mobil.Read()
    End Sub

    Public Sub ReloadDataTableDatabaseSearchNone()
        DataGridMobil.DataSource = Nothing
        DataGridMobil.DataSource = Mobil.SearchNone(TxtSearch.Text)
    End Sub

    Public Sub ReloadDataTableDatabaseSearchTerjual()
        DataGridMobil.DataSource = Nothing
        DataGridMobil.DataSource = Mobil.SearchTerjual(TxtSearch.Text)
    End Sub

    Public Sub ReloadDataTableDatabaseSearchBelumTerjual()
        DataGridMobil.DataSource = Nothing
        DataGridMobil.DataSource = Mobil.SearchTerjualBelum(TxtSearch.Text)
    End Sub

    Public Sub ReloadDataTableDatabaseTerjual()
        DataGridMobil.DataSource = Nothing
        DataGridMobil.DataSource = Mobil.ReadTerjual()
    End Sub

    Public Sub ReloadDataTableDatabaseBelumTerjual()
        DataGridMobil.DataSource = Nothing
        DataGridMobil.DataSource = Mobil.ReadTerjualBelum()
    End Sub

    Private Sub DataGridMobil_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridMobil.ColumnHeaderMouseClick
        DataGridMobil.ClearSelection()
    End Sub

    Private Sub DataGridMobil_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridMobil.CellClick
        If (e.RowIndex >= 0) Then
            Dim index As Integer = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridMobil.Rows(index)

            SelectedTableMobil = selectedRow.Cells(0).Value
            SelectedTableMobilNama = selectedRow.Cells(1).Value
        End If
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        FormMobilTambah.Show()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Try
            Dim selectedMobil As List(Of String) = Mobil.DetailsById(SelectedTableMobil)

            Mobil.idJenisMobilProperty = selectedMobil(1)
            Mobil.tipeMobilProperty = selectedMobil(2)
            Mobil.tahunPembuatanProperty = selectedMobil(3)
            Mobil.kondisiProperty = selectedMobil(4)
            Mobil.garansiProperty = selectedMobil(6)
            Mobil.hargaDefaultProperty = selectedMobil(8)

            Dim MobilEdit = New FormMobilEdit()
            MobilEdit.Show()
        Catch ex As Exception
            MessageBox.Show("Pilih Row Terlebih Dahulu !!")
        End Try
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Try
            Dim selectedMobil As List(Of String) = Mobil.DetailsById(SelectedTableMobil)

            Mobil.idJenisMobilProperty = selectedMobil(1)

            Dim MobilHapus = New FormMobilHapus()
            MobilHapus.Show()
        Catch ex As Exception
            MessageBox.Show("Pilih Row Terlebih Dahulu !!")
        End Try
    End Sub

    Private Sub FormMobil_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormSignIn.Close()
    End Sub

    Private Sub TransactionBtn_Click(sender As Object, e As EventArgs)
        FormBukuPenjualan.Show()
        Me.Hide()
    End Sub

    Private Sub BtnIndex_Click(sender As Object, e As EventArgs)
        FormDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub ManageUserBtn_Click(sender As Object, e As EventArgs) Handles ManageUserBtn.Click
        FormPembeli.Show()
        Me.Hide()
    End Sub

    Private Sub BtnIndex_Click_1(sender As Object, e As EventArgs) Handles BtnIndex.Click
        FormDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub TransactionBtn_Click_1(sender As Object, e As EventArgs) Handles TransactionBtn.Click
        FormBukuPenjualan.Show()
        Me.Hide()
    End Sub

    Private Sub BtnJenisMobil_Click(sender As Object, e As EventArgs) Handles BtnJenisMobil.Click
        FormJenisMobil.Show()
        Me.Hide()
    End Sub

    Private Sub RdbNone_CheckedChanged(sender As Object, e As EventArgs) Handles RdbNone.CheckedChanged
        ReloadDataTableDatabase()
    End Sub

    Private Sub RdbTerjual_CheckedChanged(sender As Object, e As EventArgs) Handles RdbTerjual.CheckedChanged
        ReloadDataTableDatabaseTerjual()
    End Sub

    Private Sub RdbBelumTerjual_CheckedChanged(sender As Object, e As EventArgs) Handles RdbBelumTerjual.CheckedChanged
        ReloadDataTableDatabaseBelumTerjual()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        If Not TxtSearch.Text = "" And RdbNone.Checked Then
            ReloadDataTableDatabaseSearchNone()
        ElseIf Not TxtSearch.Text = "" And RdbTerjual.Checked Then
            ReloadDataTableDatabaseSearchTerjual()
        ElseIf Not TxtSearch.Text = "" And RdbBelumTerjual.Checked Then
            ReloadDataTableDatabaseSearchBelumTerjual()
        Else
            ReloadDataTableDatabase()
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

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        BtnSearch.Enabled = True

        If TxtSearch.Text = "" Then
            BtnSearch.Enabled = False
        End If
    End Sub

    Private Sub SignoutBtn_Click(sender As Object, e As EventArgs) Handles SignoutBtn.Click
        FormSignIn.Show()
        Me.Hide()
    End Sub

End Class