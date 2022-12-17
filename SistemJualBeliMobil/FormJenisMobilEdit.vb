Imports System.Configuration
Imports System.Globalization
Imports System.IO

Public Class FormJenisMobilEdit

    Public Shared JenisMobil As JenisMobil

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TxtJenisMobil.Text = FormJenisMobil.JenisMobil.jenisProperty

    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        FormJenisMobil.JenisMobil.jenisProperty = TxtJenisMobil.Text.ToString()

        FormJenisMobil.JenisMobil.UpdateDataJenisMobilByIDDatabase(FormJenisMobil.SelectedTableJenisMobil,
                                                                   FormJenisMobil.JenisMobil.jenisProperty)

        Me.Close()
    End Sub

    'Private Sub FormJenisMobilEdit_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    '    Form1.Show()
    'End Sub
End Class