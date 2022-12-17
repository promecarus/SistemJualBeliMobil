﻿Public Class FormBukuPenjualan
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

    Private Sub DataGridViewBukuPenjualan_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewBukuPenjualan.ColumnHeaderMouseClick
        DataGridViewBukuPenjualan.ClearSelection()
    End Sub

    Private Sub DataGridViewBukuPenjualan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewBukuPenjualan.CellClick
        Dim index As Integer = e.RowIndex

        If index > -1 Then
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridViewBukuPenjualan.Rows(index)

            selectedRowBukuPenjualan = selectedRow.Cells(0).Value
        End If
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        FormBukuPenjualanTambah.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        Try
            Dim selectedKoleksi As List(Of String) = dataBukuPenjualan.GetDataBukuPenjualanByIDDatabase(selectedRowBukuPenjualan)

            dataBukuPenjualan.idMobilProperty = selectedKoleksi(1)
            dataBukuPenjualan.idPembeliProperty = selectedKoleksi(2)
            dataBukuPenjualan.hargaTerjualProperty = selectedKoleksi(3)
            dataBukuPenjualan.tanggalPenjualanProperty = selectedKoleksi(4)

            Dim formEdit = New FormBukuPenjualanEdit()
            formEdit.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Pilih row terlebih dahulu!")
        End Try
    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        Try
            Dim selectedKoleksi As List(Of String) = dataBukuPenjualan.GetDataBukuPenjualanByIDDatabase(selectedRowBukuPenjualan)

            dataBukuPenjualan.idMobilProperty = selectedKoleksi(1)

            Dim formHapus = New FormBukuPenjualanHapus()
            formHapus.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Pilih row terlebih dahulu!")
        End Try
    End Sub

    Private Sub PictureBoxBack_Click(sender As Object, e As EventArgs) Handles PictureBoxBack.Click
        Me.Close()
        FormDashboard.Show()
    End Sub

    Private Sub FormBukuPenjualan_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormSignIn.Close()
    End Sub
End Class