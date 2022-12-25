Public Class FormSignIn
    Public Shared db As New Database

    Public Shared Users As Users
    Public Shared JenisMobil As JenisMobil
    Public Shared Mobil As Mobil
    Public Shared Pembeli As Pembeli
    Public Shared BukuPenjualan As BukuPenjualan

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
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
            FormDashboard.Show()
            Me.Hide()
        ElseIf inputUsername.Text = "" Then
            MessageBox.Show("Data Username Belum Terisi !!")
        ElseIf inputPassword.Text = "" Then
            MessageBox.Show("Data Password Belum Terisi !!")
        Else
            MessageBox.Show("Username atau Password Salah !!")
        End If
    End Sub

    Private Sub SignupBtn_Click(sender As Object, e As EventArgs) Handles SignupBtn.Click
        FormSignUp.Show()
        Me.Hide()
    End Sub

    Private Sub ChkPassword_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPassword.CheckedChanged
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