Public Class FormMobilTambah

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ComboBoxJenisMobil.DataSource = Form1.JenisMobil.ListDataJenisMobil
        ComboBoxJenisMobil.DisplayMember = "jenis"
        ComboBoxJenisMobil.ValueMember = "id_jenis"

    End Sub

    Private Sub BtnTambahMobil_Click(sender As Object, e As EventArgs) Handles BtnTambahMobil.Click
        'FormMobil.Mobil.idjenisMobillProperty = ComboBoxJenisMobil.SelectedValue.ToString()

        Dim tipe_mobil As String

        If RdManual.Checked Then
            tipe_mobil = "Manual"
        ElseIf RdMatic.Checked Then
            tipe_mobil = "Matic"
        End If

        'FormMobil.Mobil.tahunPembuatanProperty = Integer.Parse(TxtTahunPembuatan.Text)

        Dim kondisi As String

        If RdSangatBaik.Checked Then
            kondisi = "Sangat Baik"
        ElseIf RdBaik.Checked Then
            kondisi = "Baik"
        ElseIf RdSedang.Checked Then
            kondisi = "Sedang"
        ElseIf RdBuruk.Checked Then
            kondisi = "Buruk"
        ElseIf RdSangatBuruk.Checked Then
            kondisi = "Sangat Buruk"
        End If

        'FormMobil.Mobil.hargaProperty = Integer.Parse(TxtHargaDefault.Text)
        'FormMobil.Mobil.garansiProperty = Integer.Parse(TxtGaransi.Text)
        'FormMobil.Mobil.hargaDefaultProperty = Integer.Parse(TxtHargaDefault.Text)

        Form1.Mobil.AddDataMobilDatabase(ComboBoxJenisMobil.SelectedValue,
                                         tipe_mobil,
                                         Integer.Parse(TxtTahunPembuatan.Text),
                                         kondisi,
                                         Integer.Parse(TxtHargaDefault.Text),
                                         Integer.Parse(TxtGaransi.Text),
                                         Integer.Parse(TxtHargaDefault.Text))

        MessageBox.Show("Data Mobil Berhasil Ditambahkan !!")

        Me.Close()
    End Sub
End Class