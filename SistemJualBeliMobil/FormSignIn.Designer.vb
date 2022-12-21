<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSignIn
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inputUsername = New System.Windows.Forms.TextBox()
        Me.SigninBtn = New System.Windows.Forms.Button()
        Me.SignupBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.inputPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SistemJualBeliMobil.My.Resources.Resources.BannerSign
        Me.PictureBox1.Location = New System.Drawing.Point(-16, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(503, 643)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(558, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sign In"
        '
        'inputUsername
        '
        Me.inputUsername.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.inputUsername.Location = New System.Drawing.Point(563, 202)
        Me.inputUsername.Name = "inputUsername"
        Me.inputUsername.Size = New System.Drawing.Size(322, 34)
        Me.inputUsername.TabIndex = 1
        '
        'SigninBtn
        '
        Me.SigninBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SigninBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SigninBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SigninBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SigninBtn.ForeColor = System.Drawing.Color.White
        Me.SigninBtn.Location = New System.Drawing.Point(563, 341)
        Me.SigninBtn.Name = "SigninBtn"
        Me.SigninBtn.Size = New System.Drawing.Size(322, 37)
        Me.SigninBtn.TabIndex = 3
        Me.SigninBtn.Text = "Sign in"
        Me.SigninBtn.UseVisualStyleBackColor = False
        '
        'SignupBtn
        '
        Me.SignupBtn.BackColor = System.Drawing.Color.White
        Me.SignupBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SignupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SignupBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SignupBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SignupBtn.Location = New System.Drawing.Point(563, 405)
        Me.SignupBtn.Name = "SignupBtn"
        Me.SignupBtn.Size = New System.Drawing.Size(322, 37)
        Me.SignupBtn.TabIndex = 4
        Me.SignupBtn.Text = "Sign up"
        Me.SignupBtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(707, 378)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "or"
        '
        'inputPassword
        '
        Me.inputPassword.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.inputPassword.Location = New System.Drawing.Point(563, 275)
        Me.inputPassword.Name = "inputPassword"
        Me.inputPassword.Size = New System.Drawing.Size(322, 34)
        Me.inputPassword.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(558, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(558, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Password"
        '
        'FormSignIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 623)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.inputPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SignupBtn)
        Me.Controls.Add(Me.SigninBtn)
        Me.Controls.Add(Me.inputUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "FormSignIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign In"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents inputUsername As TextBox
    Friend WithEvents SigninBtn As Button
    Friend WithEvents SignupBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents inputPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
