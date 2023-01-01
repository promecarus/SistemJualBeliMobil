Public Class FormMobilTambah

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ComboBoxJenisMobil.DataSource = FormSignIn.JenisMobil.List
        ComboBoxJenisMobil.DisplayMember = "jenis"
        ComboBoxJenisMobil.ValueMember = "id_jenis"

    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click

        Dim tipe_mobil As String

        If RdManual.Checked Then
            tipe_mobil = "Manual"
        ElseIf RdMatic.Checked Then
            tipe_mobil = "Matic"
        End If

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

        If RdManual.Checked = False And RdMatic.Checked = False Then
            MessageBox.Show("Data Tipe Mobil Belum Terpilih !!")
        Else
            If Not TxtTahunPembuatan.Text = "" Then
                If IsNumeric(TxtTahunPembuatan.Text) Then
                    If Not TxtGaransi.Text = "" Then
                        If IsNumeric(TxtGaransi.Text) Then
                            If RdSangatBaik.Checked = False And RdBaik.Checked = False And RdSedang.Checked = False And RdBuruk.Checked = False And RdSangatBuruk.Checked = False Then
                                MessageBox.Show("Data Kondisi Belum Terpilih !!")
                            Else
                                If Not TxtHargaDefault.Text = "" Then
                                    If IsNumeric(TxtHargaDefault.Text) Then
                                        FormSignIn.Mobil.Add(ComboBoxJenisMobil.SelectedValue,
                                                 tipe_mobil,
                                                 Integer.Parse(TxtTahunPembuatan.Text),
                                                 kondisi,
                                                 Integer.Parse(TxtHargaDefault.Text),
                                                 Integer.Parse(TxtGaransi.Text),
                                                 Integer.Parse(TxtHargaDefault.Text))

                                        MessageBox.Show("Data Mobil Baru Berhasil Ditambahkan.")

                                        Me.Hide()

                                        TxtTahunPembuatan.Text = ""
                                        TxtHargaDefault.Text = ""
                                        TxtGaransi.Text = ""
                                        RdManual.Checked = False
                                        RdMatic.Checked = False
                                        RdSangatBaik.Checked = False
                                        RdBaik.Checked = False
                                        RdSedang.Checked = False
                                        RdBuruk.Checked = False
                                        RdSangatBuruk.Checked = False
                                    Else
                                        MessageBox.Show("Data Harga Default Harus Angka !!")
                                    End If
                                Else
                                    MessageBox.Show("Data Harga Default Belum Terisi !!")
                                End If
                            End If
                        Else
                            MessageBox.Show("Data Garansi Harus Angka !!")
                        End If
                    Else
                        MessageBox.Show("Data Garansi Belum Terisi !!")
                    End If
                Else
                    MessageBox.Show("Data Tahun Pembuatan Harus Angka !!")
                End If
            Else
                MessageBox.Show("Data Tahun Pembuatan Belum Terisi !!")
            End If
        End If

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Hide()

        TxtTahunPembuatan.Text = ""
        TxtHargaDefault.Text = ""
        TxtGaransi.Text = ""
        RdManual.Checked = False
        RdMatic.Checked = False
        RdSangatBaik.Checked = False
        RdBaik.Checked = False
        RdSedang.Checked = False
        RdBuruk.Checked = False
        RdSangatBuruk.Checked = False
    End Sub
End Class