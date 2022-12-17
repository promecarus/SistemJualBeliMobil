Public Class FormMobilEdit

    Dim kondisi As String
    Dim tipe_mobil As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ComboBoxJenisMobil.DataSource = Form1.JenisMobil.ListDataJenisMobil
        ComboBoxJenisMobil.DisplayMember() = "jenis"
        ComboBoxJenisMobil.ValueMember() = "id_jenis"

        ComboBoxJenisMobil.SelectedValue() = FormMobil.Mobil.idjenisMobillProperty

        If String.Compare(FormMobil.Mobil.tipeMobilProperty, "Manual") = 0 Then
            RdManual.Checked = True
            tipe_mobil = "Manual"
        ElseIf String.Compare(FormMobil.Mobil.tipeMobilProperty, "Matic") = 0 Then
            RdMatic.Checked = True
            tipe_mobil = "Matic"
        End If

        TxtTahunPembuatan.Text = FormMobil.Mobil.tahunPembuatanProperty
        TxtGaransi.Text = FormMobil.Mobil.garansiProperty

        If String.Compare(FormMobil.Mobil.kondisiProperty, "Sangat Baik") = 0 Then
            RdSangatBaik.Checked = True
            kondisi = "Sangat Baik"
        ElseIf String.Compare(FormMobil.Mobil.kondisiProperty, "Baik") = 0 Then
            RdBaik.Checked = True
            kondisi = "Baik"
        ElseIf String.Compare(FormMobil.Mobil.kondisiProperty, "Sedang") = 0 Then
            RdSedang.Checked = True
            kondisi = "Sedang"
        ElseIf String.Compare(FormMobil.Mobil.kondisiProperty, "Buruk") = 0 Then
            RdBuruk.Checked = True
            kondisi = "Buruk"
        ElseIf String.Compare(FormMobil.Mobil.kondisiProperty, "Sangat Buruk") = 0 Then
            RdSangatBuruk.Checked = True
            kondisi = "Sangat Buruk"
        End If

        TxtHargaDefault.Text = FormMobil.Mobil.hargaDefaultProperty
    End Sub

    Private Sub BtnEditMobil_Click(sender As Object, e As EventArgs) Handles BtnEditMobil.Click
        FormMobil.Mobil.UpdateDataMobilByIDDatabase(FormMobil.SelectedTableMobil,
                                                    ComboBoxJenisMobil.SelectedValue,
                                                    tipe_mobil,
                                                    Integer.Parse(TxtTahunPembuatan.Text),
                                                    kondisi,
                                                    Integer.Parse(TxtGaransi.Text),
                                                    Integer.Parse(TxtHargaDefault.Text))

        MessageBox.Show("Edit Data Mobil Dengan ID " & FormMobil.SelectedTableMobil & " Berhasil Diedit !!")
        Me.Close()
    End Sub
End Class