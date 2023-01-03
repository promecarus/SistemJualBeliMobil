Imports System.Text.RegularExpressions

Public Class FormSignUp
    Private Users As New Users
    Private drawingFont As New Font("Arial", 15)
    Private captchaImage As New Bitmap(140, 40)
    Private captchaGraf As Graphics = Graphics.FromImage(captchaImage)
    Private alphabet As String = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz"
    Private captchaString As String
    Private tickRandom As String
    Private processNumber As Integer

    Private Sub ButtonSignUp_Click(sender As Object, e As EventArgs) Handles SignupBtn.Click
        Dim regex As Regex = New Regex("^[^@\s]+@[^@\s]+\.[^@\s]+$")
        Dim valid As Boolean = regex.IsMatch(inputEmail.Text.Trim)

        If Users.AvailabilityUsername(inputUsername.Text) = True Then
            MessageBox.Show("Username Sudah Terdaftar !!")
        Else
            If Users.AvailabilityEmail(inputEmail.Text) = True Then
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
                                        If InputCaptcha.Text.Length > 0 Then
                                            If InputCaptcha.Text = captchaString Then
                                                Users.Add(inputUsername.Text, inputEmail.Text, inputPassword.Text)
                                                MessageBox.Show("Sign Up Berhasil !!")

                                                inputUsername.Text = ""
                                                inputEmail.Text = ""
                                                inputPassword.Text = ""
                                                InputConfirmPassword.Text = ""
                                                InputCaptcha.Clear()
                                                GenerateCaptcha()

                                                FormSignIn.Show()
                                                Me.Hide()
                                            Else
                                                MessageBox.Show("Data Captcha Tidak Sesuai !!")
                                                InputCaptcha.Clear()
                                            End If
                                        Else
                                            MessageBox.Show("Data Captcha Belum Terisi")
                                        End If
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

    Private Sub ButtonSignIn_Click(sender As Object, e As EventArgs) Handles SigninBtn.Click
        inputUsername.Text = ""
        inputEmail.Text = ""
        inputPassword.Text = ""
        InputConfirmPassword.Text = ""

        FormSignIn.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonRefreshCaptcha_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        GenerateCaptcha()
    End Sub

    Private Sub CheckBoxPassword_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPassword.CheckedChanged
        If ChkPassword.Checked = True Then
            inputPassword.UseSystemPasswordChar = False
        Else
            inputPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub CheckBoxPasswordConfirm_CheckedChanged(sender As Object, e As EventArgs) Handles ChkConfirmPassword.CheckedChanged
        If ChkConfirmPassword.Checked = True Then
            InputConfirmPassword.UseSystemPasswordChar = False
        Else
            InputConfirmPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub GenerateCaptcha()
        processNumber = My.Computer.Clock.LocalTime.Millisecond
        If processNumber < 521 Then
            processNumber = processNumber \ 10
            captchaString = alphabet.Substring(processNumber, 1)
        Else
            captchaString = CStr(My.Computer.Clock.LocalTime.Second \ 6)
        End If

        processNumber = My.Computer.Clock.LocalTime.Second
        If processNumber < 30 Then
            processNumber = Math.Abs(processNumber - 8)
            captchaString += alphabet.Substring(processNumber, 1)
        Else
            captchaString += CStr(My.Computer.Clock.LocalTime.Minute \ 6)
        End If

        processNumber = My.Computer.Clock.LocalTime.DayOfYear
        If processNumber Mod 2 = 0 Then
            processNumber = processNumber \ 8
            captchaString += alphabet.Substring(processNumber, 1)
        Else
            captchaString += CStr(processNumber \ 37)
        End If

        tickRandom = My.Computer.Clock.TickCount.ToString
        processNumber = Val(tickRandom.Substring(tickRandom.Length - 1, 1))
        If processNumber Mod 2 = 0 Then
            captchaString += CStr(processNumber)
        Else
            processNumber = Math.Abs(Int(Math.Cos(Val(tickRandom)) * 51))
            captchaString += alphabet.Substring(processNumber, 1)
        End If

        processNumber = My.Computer.Clock.LocalTime.Hour
        If processNumber Mod 2 = 0 Then
            processNumber = Math.Abs(Int(Math.Sin(Val(My.Computer.Clock.LocalTime.Year)) * 51))
            captchaString += alphabet.Substring(processNumber, 1)
        Else
            captchaString += CStr(processNumber \ 3)
        End If

        processNumber = My.Computer.Clock.LocalTime.Millisecond
        If processNumber > 521 Then
            processNumber = Math.Abs((processNumber \ 10) - 52)
            captchaString += alphabet.Substring(processNumber, 1)
        Else
            captchaString += CStr(My.Computer.Clock.LocalTime.Second \ 6)
        End If

        captchaGraf.Clear(Color.White)

        For hash As Integer = 0 To 5
            captchaGraf.DrawString(captchaString.Substring(hash, 1), drawingFont, Brushes.Black, hash * 20 + hash + processNumber \ 200, (hash Mod 3) * (processNumber \ 200))
        Next

        PictBoxCaptcha.Image = captchaImage
    End Sub

    Private Sub FormSignUp_Load(sender As Object, e As EventArgs) Handles Me.Load
        inputPassword.UseSystemPasswordChar = True
        InputConfirmPassword.UseSystemPasswordChar = True

        GenerateCaptcha()
    End Sub

    Private Sub FormSignUp_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormSignIn.Close()
    End Sub

End Class