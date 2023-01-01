Public Class FormBukuPenjualanTambah
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DateTimePickerTanggalPenjualan.Format = DateTimePickerFormat.Custom
        DateTimePickerTanggalPenjualan.CustomFormat = "yyyy/MM/dd"
    End Sub

    Private Sub FormBukuPenjualanTambah_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ComboBoxIdMobil.DataSource = FormSignIn.Mobil.ListAdd
        ComboBoxIdMobil.DisplayMember = "id"
        ComboBoxIdMobil.ValueMember = "id"

        ComboBoxIdPembeli.DataSource = FormSignIn.Pembeli.List
        ComboBoxIdPembeli.DisplayMember = "nama"
        ComboBoxIdPembeli.ValueMember = "id_pembeli"
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        If Not TextBoxHargaTerjual.Text = "" And ComboBoxIdMobil.SelectedValue IsNot Nothing And ComboBoxIdPembeli.SelectedValue IsNot Nothing Then
            If IsNumeric(TextBoxHargaTerjual.Text) Then
                FormBukuPenjualan.BukuPenjualan.Add(
                    ComboBoxIdMobil.SelectedValue,
                    ComboBoxIdPembeli.SelectedValue,
                    TextBoxHargaTerjual.Text,
                    DateTimePickerTanggalPenjualan.Value.ToShortDateString()
                )

                MessageBox.Show("Data buku penjualan baru berhasil ditambahkan.")
                Me.Hide()
            Else
                MessageBox.Show("Input harga terjual harus angka!")
            End If
        Else
            MessageBox.Show("Input tidak boleh kosong!")
        End If
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Hide()
    End Sub
End Class