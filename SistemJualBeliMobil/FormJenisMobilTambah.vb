Public Class FormJenisMobilTambah

    Public Shared JenisMobil As JenisMobil

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        JenisMobil = New JenisMobil()

    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        If TxtJenisMobil.Text = "" Then
            MessageBox.Show("Data Jenis Mobil Tidak Boleh Kosong !!")
        Else
            FormJenisMobil.JenisMobil.jenisProperty = TxtJenisMobil.Text.ToString()

            FormJenisMobil.JenisMobil.AddDataJenisMobilDatabase(FormJenisMobil.JenisMobil.jenisProperty)

            MessageBox.Show("Jenis Mobil Berhasil Ditambahkan !!")

            Me.Close()
        End If
    End Sub

    Private Sub TxtJenisMobil_TextChanged(sender As Object, e As EventArgs) Handles TxtJenisMobil.TextChanged

    End Sub

    'Private Sub FormJenisMobilTambah_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    '    Form1.Show()
    'End Sub
End Class