Imports System.Text.RegularExpressions
Imports System.Text
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
Imports System.Security
Imports System.Security.Policy

Public Class FormSignUp

    Dim drawingFont As New Font("Arial", 15)
    Dim captchaImage As New Bitmap(140, 40)
    Dim captchaGraf As Graphics = Graphics.FromImage(captchaImage)
    Dim alphabet As String = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz"
    Dim captchaString, tickRandom As String
    Dim processNumber As Integer

    Private Sub SignupBtn_Click(sender As Object, e As EventArgs) Handles SignupBtn.Click
        Dim regex As Regex = New Regex("^[^@\s]+@[^@\s]+\.[^@\s]+$")
        Dim valid As Boolean = regex.IsMatch(inputEmail.Text.Trim)

        If FormSignIn.Users.ValidateUser(inputUsername.Text) = True Then
            MessageBox.Show("Username Sudah Terdaftar !!")
        Else
            If FormSignIn.Users.ValidateEmail(inputEmail.Text) = True Then
                MessageBox.Show("Email Sudah Terdaftar !!")
            Else
                If inputUsername.Text.Length > 0 Then
                    If inputEmail.Text.Length > 0 Then
                        If Not valid Then
                            MessageBox.Show("Data Email Tidak Valid !!")
                        Else
                            If inputPassword.Text.Length > 0 Then
                                If InputConfirmPassword.Text.Length > 0 Then
                                    If String.Compare(inputPassword.Text, InputConfirmPassword.Text) = 0 Then
                                        FormSignIn.Users.AddUsersDatabase(inputUsername.Text, inputEmail.Text, inputPassword.Text)
                                        MessageBox.Show("Sign Up Berhasil !!")

                                        inputUsername.Text = ""
                                        inputEmail.Text = ""
                                        inputPassword.Text = ""
                                        InputConfirmPassword.Text = ""

                                        FormSignIn.Show()
                                        Me.Hide()
                                    Else
                                        MessageBox.Show("Data Confirm Password Tidak Sama dengan Data Password !!")
                                    End If
                                Else
                                    MessageBox.Show("Data Confirm Password Belum Terisi !!")
                                End If
                            Else
                                MessageBox.Show("Data Password Belum Terisi !!")
                            End If
                        End If
                    Else
                        MessageBox.Show("Data Email Belum Terisi !!")
                    End If
                Else
                    MessageBox.Show("Data Username Belum Terisi !!")
                End If
            End If
        End If
    End Sub

    Private Sub SigninBtn_Click(sender As Object, e As EventArgs) Handles SigninBtn.Click
        inputUsername.Text = ""
        inputEmail.Text = ""
        inputPassword.Text = ""
        InputConfirmPassword.Text = ""

        FormSignIn.Show()
        Me.Hide()
    End Sub

    Private Sub ChkPassword_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPassword.CheckedChanged
        If ChkPassword.Checked = True Then
            inputPassword.UseSystemPasswordChar = False
        Else
            inputPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub ChkConfirmPassword_CheckedChanged(sender As Object, e As EventArgs) Handles ChkConfirmPassword.CheckedChanged
        If ChkConfirmPassword.Checked = True Then
            InputConfirmPassword.UseSystemPasswordChar = False
        Else
            InputConfirmPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub FormSignUp_Load(sender As Object, e As EventArgs) Handles Me.Load
        inputPassword.UseSystemPasswordChar = True
        InputConfirmPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub FormSignUp_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormSignIn.Close()
    End Sub

End Class