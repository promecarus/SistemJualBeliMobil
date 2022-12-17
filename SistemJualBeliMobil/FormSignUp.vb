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
                            Me.Close()
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
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            inputPassword.UseSystemPasswordChar = False
        Else
            inputPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub FormSignUp_Load(sender As Object, e As EventArgs) Handles Me.Load
        inputPassword.UseSystemPasswordChar = True
    End Sub

End Class