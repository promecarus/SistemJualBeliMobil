Public Class FormSignUp

    Private Sub SignupBtn_Click(sender As Object, e As EventArgs) Handles SignupBtn.Click
        If FormSignIn.Users.ValidateUser(inputUsername.Text) = True Then
            MessageBox.Show("Username Sudah Terdaftar !!")
        Else
            If FormSignIn.Users.ValidateEmail(inputEmail.Text) = True Then
                MessageBox.Show("Email Sudah Terdaftar !!")
            Else
                If inputUsername.Text.Length > 0 Then
                    If inputEmail.Text.Length > 0 Then
                        If inputPassword.Text.Length > 0 Then
                            FormSignIn.Users.AddUsersDatabase(inputUsername.Text, inputEmail.Text, inputPassword.Text)
                            MessageBox.Show("Sign Up Berhasil !!")
                            FormSignIn.Show()
                            Me.Hide()
                        Else
                            MessageBox.Show("Data Password Belum Terisi !!")
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

    Private Sub FormSignUp_Load(sender As Object, e As EventArgs) Handles Me.Load
        inputPassword.UseSystemPasswordChar = True
    End Sub

End Class