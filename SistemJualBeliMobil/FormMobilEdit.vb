Public Class FormMobilEdit

    Private kondisi As String
    Private tipe_mobil As String

    Private Sub FormMobilEdit_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ComboBoxJenisMobil.DataSource = FormMobil.JenisMobil.List
        ComboBoxJenisMobil.DisplayMember() = "jenis"
        ComboBoxJenisMobil.ValueMember() = "id_jenis"

        ComboBoxJenisMobil.SelectedValue() = FormMobil.Mobil.idJenisMobilProperty

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

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
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
                                FormMobil.Mobil.Update(FormMobil.SelectedRowMobil,
                                                    ComboBoxJenisMobil.SelectedValue,
                                                    tipe_mobil,
                                                    Integer.Parse(TxtTahunPembuatan.Text),
                                                    kondisi,
                                                    Integer.Parse(TxtGaransi.Text),
                                                    Integer.Parse(TxtHargaDefault.Text))

                                MessageBox.Show("Data mobil dengan id " & FormMobil.SelectedRowMobil & " Berhasil diedit")

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

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Hide()
    End Sub
End Class