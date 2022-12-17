Public Class FormBukuPenjualanTambah
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
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        FormBukuPenjualan.dataBukuPenjualan.idMobilProperty = ComboBoxIdMobil.SelectedValue
        FormBukuPenjualan.dataBukuPenjualan.idPembeliProperty = ComboBoxIdPembeli.SelectedValue
        FormBukuPenjualan.dataBukuPenjualan.hargaTerjualProperty = TextBoxHargaTerjual.Text
        FormBukuPenjualan.dataBukuPenjualan.tanggalPenjualanProperty = DateTimePickerTanggalPenjualan.Value.ToShortDateString

        FormBukuPenjualan.dataBukuPenjualan.AddDataBukuPenjualanDatabase(
            FormBukuPenjualan.dataBukuPenjualan.idMobilProperty,
            FormBukuPenjualan.dataBukuPenjualan.idPembeliProperty,
            FormBukuPenjualan.dataBukuPenjualan.hargaTerjualProperty,
            FormBukuPenjualan.dataBukuPenjualan.tanggalPenjualanProperty
        )

        MessageBox.Show("Data buku penjualan baru berhasil ditambahkan.")
        Me.Close()
        FormBukuPenjualan.Show()
    End Sub

    Private Sub FormBukuPenjualanTambah_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub
End Class