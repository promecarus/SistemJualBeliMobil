﻿Public Class FormSignIn

    Public Shared Dashboard As FormDashboard
    Public Shared SignUp As FormSignUp
    Public Shared Users As Users
    Public Shared JenisMobil As JenisMobil
    Public Shared Mobil As Mobil
    Public Shared Pembeli As Pembeli
    Public Shared BukuPenjualan As BukuPenjualan

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dashboard = New FormDashboard()
        SignUp = New FormSignUp()
        Users = New Users()
        JenisMobil = New JenisMobil()
        Mobil = New Mobil()
        Pembeli = New Pembeli()
        BukuPenjualan = New BukuPenjualan()
    End Sub

    Private Sub SigninBtn_Click(sender As Object, e As EventArgs) Handles SigninBtn.Click
        Dim plainUsername As String = inputUsername.Text
        Dim PlainPassword As String = inputPassword.Text

        Dim data_users As List(Of String) = Users.CheckAuthenticationDatabase(plainUsername, PlainPassword)

        If data_users.Count > 0 Then
            Users.usernameProperty = data_users(1)
            MessageBox.Show("Sign In Berhasil, Selamat Datang di JualMobil !!")
            Form1.Show()
            Me.Close()
        ElseIf inputUsername.Text = "" Then
            MessageBox.Show("Data Username Belum Terisi !!")
        ElseIf inputPassword.Text = "" Then
            MessageBox.Show("Data Password Belum Terisi !!")
        Else
            MessageBox.Show("Username atau Password Salah !!")
        End If
    End Sub

    Private Sub SignupBtn_Click(sender As Object, e As EventArgs) Handles SignupBtn.Click
        SignUp.Show()
        Me.Close()
    End Sub

End Class