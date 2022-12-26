Imports Org.BouncyCastle.Asn1.Cms

Public Class FormMobilEdit

    Dim kondisi As String
    Dim tipe_mobil As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ComboBoxJenisMobil.DataSource = FormSignIn.JenisMobil.ListDataJenisMobil
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

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If RdManual.Checked Then
            tipe_mobil = "Manual"
        ElseIf RdMatic.Checked Then
            tipe_mobil = "Matic"
        End If

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

        If Not TxtTahunPembuatan.Text = "" Then
            If IsNumeric(TxtTahunPembuatan.Text) Then
                If Not TxtGaransi.Text = "" Then
                    If IsNumeric(TxtGaransi.Text) Then
                        If Not TxtHargaDefault.Text = "" Then
                            If IsNumeric(TxtHargaDefault.Text) Then
                                FormMobil.Mobil.UpdateDataMobilByIDDatabase(FormMobil.SelectedTableMobil,
                                                    ComboBoxJenisMobil.SelectedValue,
                                                    tipe_mobil,
                                                    Integer.Parse(TxtTahunPembuatan.Text),
                                                    kondisi,
                                                    Integer.Parse(TxtGaransi.Text),
                                                    Integer.Parse(TxtHargaDefault.Text))

                                MessageBox.Show("Data Mobil Dengan ID " & FormMobil.SelectedTableMobil & " Berhasil Diedit")

                                Me.Hide()
                            Else
                                MessageBox.Show("Data Harga Default Harus Angka !!")
                            End If
                        Else
                            MessageBox.Show("Data Harga Default Belum Terisi !!")
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
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Hide()
    End Sub
End Class