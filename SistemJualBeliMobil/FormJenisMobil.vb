﻿Public Class FormJenisMobil

    Public Shared JenisMobil As JenisMobil
    Public Shared SelectedTableJenisMobil
    Public Shared SelectedTableJenisMobilNama

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        JenisMobil = New JenisMobil()
        ReloadDataTableDatabase()

    End Sub

    'Private Sub ResetGrid()
    '    Dim index As Integer = 0
    '    Dim selectedRow As DataGridViewRow
    '    selectedRow = DataGridJenisMobil.Rows(index)
    '    SelectedTableJenisMobil = selectedRow.Cells(0).Value
    'End Sub

    Public Sub ReloadDataTableDatabase()
        DataGridJenisMobil.DataSource = JenisMobil.GetDataJenisMobilDatabase()
    End Sub

    Private Sub FormJenisMobil_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub FormJenisMobil_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'ResetGrid()
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
        Dim JenisMobilTambah = New FormJenisMobilTambah()
        JenisMobilTambah.Show()

        'ResetGrid()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim selectedJenisMobil As List(Of String) = JenisMobil.GetDataJenisMobilByIDDatabase(SelectedTableJenisMobil)

        JenisMobil.jenisProperty = selectedJenisMobil(1)

        'ResetGrid()

        Dim JenisMobilEdit = New FormJenisMobilEdit()
        JenisMobilEdit.Show()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        'ResetGrid()

        Dim JenisMobilHapus = New FormJenisMobilHapus()
        JenisMobilHapus.Show()
    End Sub

End Class