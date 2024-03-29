﻿Imports MySql.Data.MySqlClient

Public Class FormSignIn
    Private Users As New Users

    Private Sub ButtonSignIn_Click(sender As Object, e As EventArgs) Handles SigninBtn.Click
        Dim plainUsername As String = inputUsername.Text
        Dim plainPassword As String = inputPassword.Text

        Dim data_users As List(Of String) = Users.Authentication(plainUsername, plainPassword)

        Dim connection As New MySqlConnection("server=localhost;user id=root;password=;database=db_sistem_jual_beli_mobil")
        Try
            connection.Open()
        Catch ex As Exception
        End Try

        If connection.State = ConnectionState.Open Then
            If data_users.Count > 0 Then
                Users.usernameProperty = data_users(1)
                MessageBox.Show("Sign in berhasil, selamat datang di JualMobil!")

                inputUsername.Text = ""
                inputPassword.Text = ""

                FormDashboard.Show()
                Me.Hide()
            ElseIf inputUsername.Text = "" Then
                MessageBox.Show("Data username belum terisi!")
            ElseIf inputPassword.Text = "" Then
                MessageBox.Show("Data password belum terisi!")
            Else
                MessageBox.Show("Username atau password salah!")
            End If
        Else
            MessageBox.Show("Database belum dinyalakan, nyalakan terlebih dahulu!")
        End If
        connection.Close()
    End Sub

    Private Sub ButtonSignUp_Click(sender As Object, e As EventArgs) Handles SignupBtn.Click
        inputUsername.Text = ""
        inputPassword.Text = ""

        FormSignUp.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBoxPassword_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPassword.CheckedChanged
        If ChkPassword.Checked = True Then
            inputPassword.UseSystemPasswordChar = False
        Else
            inputPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub FormSignIn_Load(sender As Object, e As EventArgs) Handles Me.Load
        inputPassword.UseSystemPasswordChar = True
    End Sub

End Class