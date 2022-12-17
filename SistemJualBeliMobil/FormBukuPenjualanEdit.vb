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
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
        FormBukuPenjualan.Show()
    End Sub

    Private Sub FormBukuPenjualanEdit_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormSignIn.Close()
    End Sub
End Class