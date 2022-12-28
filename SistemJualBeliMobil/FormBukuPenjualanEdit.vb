Public Class FormBukuPenjualanEdit
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DateTimePickerTanggalPenjualan.Format = DateTimePickerFormat.Custom
        DateTimePickerTanggalPenjualan.CustomFormat = "yyyy/MM/dd"
    End Sub

    Private Sub FormBukuPenjualanEdit_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ComboBoxIdMobil.DataSource = FormSignIn.Mobil.ListEdit(FormBukuPenjualan.dataBukuPenjualan.idMobilProperty)
        ComboBoxIdMobil.DisplayMember = "id"
        ComboBoxIdMobil.ValueMember = "id"

        ComboBoxIdPembeli.DataSource = FormSignIn.Pembeli.List
        ComboBoxIdPembeli.DisplayMember = "nama"
        ComboBoxIdPembeli.ValueMember = "id_pembeli"

        ComboBoxIdMobil.SelectedValue() = FormBukuPenjualan.dataBukuPenjualan.idMobilProperty
        ComboBoxIdPembeli.SelectedValue() = FormBukuPenjualan.dataBukuPenjualan.idPembeliProperty
        TextBoxHargaTerjual.Text = FormBukuPenjualan.dataBukuPenjualan.hargaTerjualProperty
        DateTimePickerTanggalPenjualan.Value = FormBukuPenjualan.dataBukuPenjualan.tanggalPenjualanProperty
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        If Not TextBoxHargaTerjual.Text = "" Then
            If IsNumeric(TextBoxHargaTerjual.Text) Then
                FormBukuPenjualan.dataBukuPenjualan.Update(
                    FormBukuPenjualan.selectedRowBukuPenjualan,
                    ComboBoxIdMobil.SelectedValue,
                    ComboBoxIdPembeli.SelectedValue,
                    TextBoxHargaTerjual.Text,
                    DateTimePickerTanggalPenjualan.Value.ToShortDateString()
                )

                MessageBox.Show("Data buku penjualan dengan ID " & FormBukuPenjualan.selectedRowBukuPenjualan & " berhasil diedit.")
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