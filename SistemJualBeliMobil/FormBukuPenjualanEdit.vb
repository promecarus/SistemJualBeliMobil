Public Class FormBukuPenjualanEdit
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ComboBoxIdMobil.DataSource = Form1.Mobil.ListDataMobil
        ComboBoxIdMobil.DisplayMember = "id"
        ComboBoxIdMobil.ValueMember = "id"

        ComboBoxIdPembeli.DataSource = Form1.Pembeli.ListDataPembeli
        ComboBoxIdPembeli.DisplayMember = "nama"
        ComboBoxIdPembeli.ValueMember = "id_pembeli"

        DateTimePickerTanggalPenjualan.Format = DateTimePickerFormat.Custom
        DateTimePickerTanggalPenjualan.CustomFormat = "yyyy/MM/dd"

        ComboBoxIdMobil.SelectedValue() = FormBukuPenjualan.dataBukuPenjualan.idMobilProperty
        ComboBoxIdPembeli.SelectedValue() = FormBukuPenjualan.dataBukuPenjualan.idPembeliProperty
        TextBoxHargaTerjual.Text = FormBukuPenjualan.dataBukuPenjualan.hargaTerjualProperty
        DateTimePickerTanggalPenjualan.Value = FormBukuPenjualan.dataBukuPenjualan.tanggalPenjualanProperty
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        If Not TextBoxHargaTerjual.Text = "" Then
            If IsNumeric(TextBoxHargaTerjual.Text) Then
                FormBukuPenjualan.dataBukuPenjualan.UpdateDataBukuPenjualanByIDDatabase(
                    FormBukuPenjualan.selectedRowBukuPenjualan,
                    ComboBoxIdMobil.SelectedValue,
                    ComboBoxIdPembeli.SelectedValue,
                    TextBoxHargaTerjual.Text,
                    DateTimePickerTanggalPenjualan.Value.ToShortDateString()
                )

                MessageBox.Show("Data buku penjualan dengan ID " & FormBukuPenjualan.selectedRowBukuPenjualan & " berhasil diedit.")
                Me.Close()
                FormBukuPenjualan.Show()
            Else
                MessageBox.Show("Input harga terjual harus angka!")
            End If
        Else
            MessageBox.Show("Input tidak boleh kosong!")
        End If
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
        FormBukuPenjualan.Show()
    End Sub

    Private Sub PictureBoxBack_Click(sender As Object, e As EventArgs)
        Me.Close()
        FormBukuPenjualan.Show()
    End Sub

    Private Sub FormBukuPenjualanEdit_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormSignIn.Close()
    End Sub

    Private Sub LabelTanggalPenjualan_Click(sender As Object, e As EventArgs) Handles LabelTanggalPenjualan.Click

    End Sub

    Private Sub ComboBoxIdMobil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxIdMobil.SelectedIndexChanged

    End Sub

    Private Sub ComboBoxIdPembeli_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxIdPembeli.SelectedIndexChanged

    End Sub

    Private Sub TextBoxHargaTerjual_TextChanged(sender As Object, e As EventArgs) Handles TextBoxHargaTerjual.TextChanged

    End Sub
End Class