﻿Public Class FormBukuPenjualanTambah
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ComboBoxIdMobil.DataSource = FormSignIn.Mobil.ListDataMobil
        ComboBoxIdMobil.DisplayMember = "id"
        ComboBoxIdMobil.ValueMember = "id"

        ComboBoxIdPembeli.DataSource = FormSignIn.Pembeli.ListDataPembeli
        ComboBoxIdPembeli.DisplayMember = "nama"
        ComboBoxIdPembeli.ValueMember = "id_pembeli"

        DateTimePickerTanggalPenjualan.Format = DateTimePickerFormat.Custom
        DateTimePickerTanggalPenjualan.CustomFormat = "yyyy/MM/dd"
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        If Not TextBoxHargaTerjual.Text = "" Then
            If IsNumeric(TextBoxHargaTerjual.Text) Then
                FormBukuPenjualan.dataBukuPenjualan.AddDataBukuPenjualanDatabase(
                    ComboBoxIdMobil.SelectedValue,
                    ComboBoxIdPembeli.SelectedValue,
                    TextBoxHargaTerjual.Text,
                    DateTimePickerTanggalPenjualan.Value.ToShortDateString()
                )

                MessageBox.Show("Data buku penjualan baru berhasil ditambahkan.")
                Me.Hide()
                FormBukuPenjualan.Show()
            Else
                MessageBox.Show("Input harga terjual harus angka!")
            End If
        Else
            MessageBox.Show("Input tidak boleh kosong!")
        End If
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Hide()
        FormBukuPenjualan.Show()
    End Sub

    Private Sub PictureBoxBack_Click(sender As Object, e As EventArgs) Handles PictureBoxBack.Click
        Me.Hide()
        FormBukuPenjualan.Show()
    End Sub

    Private Sub FormBukuPenjualanTambah_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormSignIn.Close()
    End Sub
End Class