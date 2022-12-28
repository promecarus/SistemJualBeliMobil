<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSignUp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.inputPassword = New System.Windows.Forms.TextBox()
        Me.SigninBtn = New System.Windows.Forms.Button()
        Me.SignupBtn = New System.Windows.Forms.Button()
        Me.inputUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.inputEmail = New System.Windows.Forms.TextBox()
        Me.ChkPassword = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ChkConfirmPassword = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.InputConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.InputCaptcha = New System.Windows.Forms.TextBox()
        Me.PictBoxCaptcha = New System.Windows.Forms.PictureBox()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictBoxCaptcha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(576, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 21)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(576, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 21)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Username"
        '
        'inputPassword
        '
        Me.inputPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.inputPassword.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.inputPassword.Location = New System.Drawing.Point(576, 269)
        Me.inputPassword.Name = "inputPassword"
        Me.inputPassword.Size = New System.Drawing.Size(346, 34)
        Me.inputPassword.TabIndex = 3
        '
        'SigninBtn
        '
        Me.SigninBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SigninBtn.BackColor = System.Drawing.Color.White
        Me.SigninBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SigninBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SigninBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SigninBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SigninBtn.Location = New System.Drawing.Point(576, 553)
        Me.SigninBtn.Name = "SigninBtn"
        Me.SigninBtn.Size = New System.Drawing.Size(346, 34)
        Me.SigninBtn.TabIndex = 7
        Me.SigninBtn.Text = "Sign in"
        Me.SigninBtn.UseVisualStyleBackColor = False
        '
        'SignupBtn
        '
        Me.SignupBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SignupBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SignupBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SignupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SignupBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SignupBtn.ForeColor = System.Drawing.Color.White
        Me.SignupBtn.Location = New System.Drawing.Point(576, 489)
        Me.SignupBtn.Name = "SignupBtn"
        Me.SignupBtn.Size = New System.Drawing.Size(346, 34)
        Me.SignupBtn.TabIndex = 6
        Me.SignupBtn.Text = "Sign up"
        Me.SignupBtn.UseVisualStyleBackColor = False
        '
        'inputUsername
        '
        Me.inputUsername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.inputUsername.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.inputUsername.Location = New System.Drawing.Point(576, 116)
        Me.inputUsername.Name = "inputUsername"
        Me.inputUsername.Size = New System.Drawing.Size(346, 34)
        Me.inputUsername.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(567, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 37)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Sign Up"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SistemJualBeliMobil.My.Resources.Resources.VEN_MY23_0052_V001_4x3
        Me.PictureBox1.Location = New System.Drawing.Point(-45, -62)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(551, 747)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(576, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 21)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Email"
        '
        'inputEmail
        '
        Me.inputEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.inputEmail.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.inputEmail.Location = New System.Drawing.Point(576, 193)
        Me.inputEmail.Name = "inputEmail"
        Me.inputEmail.Size = New System.Drawing.Size(346, 34)
        Me.inputEmail.TabIndex = 2
        '
        'ChkPassword
        '
        Me.ChkPassword.AutoSize = True
        Me.ChkPassword.Location = New System.Drawing.Point(898, 280)
        Me.ChkPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChkPassword.Name = "ChkPassword"
        Me.ChkPassword.Size = New System.Drawing.Size(15, 14)
        Me.ChkPassword.TabIndex = 20
        Me.ChkPassword.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(737, 526)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 21)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "or"
        '
        'ChkConfirmPassword
        '
        Me.ChkConfirmPassword.AutoSize = True
        Me.ChkConfirmPassword.Location = New System.Drawing.Point(898, 358)
        Me.ChkConfirmPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChkConfirmPassword.Name = "ChkConfirmPassword"
        Me.ChkConfirmPassword.Size = New System.Drawing.Size(15, 14)
        Me.ChkConfirmPassword.TabIndex = 24
        Me.ChkConfirmPassword.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(576, 319)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 21)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Confirm Password"
        '
        'InputConfirmPassword
        '
        Me.InputConfirmPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InputConfirmPassword.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.InputConfirmPassword.Location = New System.Drawing.Point(576, 347)
        Me.InputConfirmPassword.Name = "InputConfirmPassword"
        Me.InputConfirmPassword.Size = New System.Drawing.Size(346, 34)
        Me.InputConfirmPassword.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(576, 396)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 21)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Captcha"
        '
        'InputCaptcha
        '
        Me.InputCaptcha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InputCaptcha.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.InputCaptcha.Location = New System.Drawing.Point(576, 424)
        Me.InputCaptcha.Name = "InputCaptcha"
        Me.InputCaptcha.Size = New System.Drawing.Size(138, 34)
        Me.InputCaptcha.TabIndex = 5
        '
        'PictBoxCaptcha
        '
        Me.PictBoxCaptcha.Location = New System.Drawing.Point(737, 424)
        Me.PictBoxCaptcha.Name = "PictBoxCaptcha"
        Me.PictBoxCaptcha.Size = New System.Drawing.Size(130, 34)
        Me.PictBoxCaptcha.TabIndex = 27
        Me.PictBoxCaptcha.TabStop = False
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BackColor = System.Drawing.Color.White
        Me.BtnRefresh.BackgroundImage = Global.SistemJualBeliMobil.My.Resources.Resources.captchaLogo
        Me.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRefresh.FlatAppearance.BorderSize = 0
        Me.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRefresh.Location = New System.Drawing.Point(888, 424)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(34, 34)
        Me.BtnRefresh.TabIndex = 28
        Me.BtnRefresh.UseVisualStyleBackColor = False
        '
        'FormSignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 623)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.PictBoxCaptcha)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.InputCaptcha)
        Me.Controls.Add(Me.ChkConfirmPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.InputConfirmPassword)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ChkPassword)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.inputEmail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.inputPassword)
        Me.Controls.Add(Me.SigninBtn)
        Me.Controls.Add(Me.SignupBtn)
        Me.Controls.Add(Me.inputUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "FormSignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign Up"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictBoxCaptcha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents inputPassword As TextBox
    Friend WithEvents SigninBtn As Button
    Friend WithEvents SignupBtn As Button
    Friend WithEvents inputUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents inputEmail As TextBox
    Friend WithEvents ChkPassword As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LblErrorUsername As Label
    Friend WithEvents ChkConfirmPassword As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents InputConfirmPassword As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents InputCaptcha As TextBox
    Friend WithEvents PictBoxCaptcha As PictureBox
    Friend WithEvents BtnRefresh As Button
End Class
