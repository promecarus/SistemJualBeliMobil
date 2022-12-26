Imports System.Configuration
Imports System.Globalization
Imports System.IO

Public Class FormJenisMobilEdit

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TxtJenisMobil.Text = FormJenisMobil.JenisMobil.jenisProperty

    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If TxtJenisMobil.Text = "" Then
            MessageBox.Show("Data Jenis Mobil Tidak Boleh Kosong !!")
        Else
            FormJenisMobil.JenisMobil.jenisProperty = TxtJenisMobil.Text.ToString()

            FormJenisMobil.JenisMobil.UpdateDataJenisMobilByIDDatabase(FormJenisMobil.SelectedTableJenisMobil,
                                                                       FormJenisMobil.JenisMobil.jenisProperty)

            MessageBox.Show("Data Jenis Mobil dengan ID " & FormJenisMobil.SelectedTableJenisMobil & " Berhasil Diedit.")

            Me.Hide()
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Hide()
    End Sub

End Class