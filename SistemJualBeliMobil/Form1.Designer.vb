<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ButtonFormSignInAdmin = New System.Windows.Forms.Button()
        Me.ButtonFormSignUpAdmin = New System.Windows.Forms.Button()
        Me.ButtonFormSignInUser = New System.Windows.Forms.Button()
        Me.ButtonFormSignUpUser = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonFormSignInAdmin
        '
        Me.ButtonFormSignInAdmin.Location = New System.Drawing.Point(12, 12)
        Me.ButtonFormSignInAdmin.Name = "ButtonFormSignInAdmin"
        Me.ButtonFormSignInAdmin.Size = New System.Drawing.Size(200, 29)
        Me.ButtonFormSignInAdmin.TabIndex = 0
        Me.ButtonFormSignInAdmin.Text = "Form Sign In Admin"
        Me.ButtonFormSignInAdmin.UseVisualStyleBackColor = True
        '
        'ButtonFormSignUpAdmin
        '
        Me.ButtonFormSignUpAdmin.Location = New System.Drawing.Point(218, 12)
        Me.ButtonFormSignUpAdmin.Name = "ButtonFormSignUpAdmin"
        Me.ButtonFormSignUpAdmin.Size = New System.Drawing.Size(200, 29)
        Me.ButtonFormSignUpAdmin.TabIndex = 0
        Me.ButtonFormSignUpAdmin.Text = "Form Sign Up Admin"
        Me.ButtonFormSignUpAdmin.UseVisualStyleBackColor = True
        '
        'ButtonFormSignInUser
        '
        Me.ButtonFormSignInUser.Location = New System.Drawing.Point(12, 47)
        Me.ButtonFormSignInUser.Name = "ButtonFormSignInUser"
        Me.ButtonFormSignInUser.Size = New System.Drawing.Size(200, 29)
        Me.ButtonFormSignInUser.TabIndex = 0
        Me.ButtonFormSignInUser.Text = "Form Sign In User"
        Me.ButtonFormSignInUser.UseVisualStyleBackColor = True
        '
        'ButtonFormSignUpUser
        '
        Me.ButtonFormSignUpUser.Location = New System.Drawing.Point(218, 47)
        Me.ButtonFormSignUpUser.Name = "ButtonFormSignUpUser"
        Me.ButtonFormSignUpUser.Size = New System.Drawing.Size(200, 29)
        Me.ButtonFormSignUpUser.TabIndex = 0
        Me.ButtonFormSignUpUser.Text = "Form Sign Up User"
        Me.ButtonFormSignUpUser.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonFormSignUpUser)
        Me.Controls.Add(Me.ButtonFormSignUpAdmin)
        Me.Controls.Add(Me.ButtonFormSignInUser)
        Me.Controls.Add(Me.ButtonFormSignInAdmin)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonFormSignInAdmin As Button
    Friend WithEvents ButtonFormSignUpAdmin As Button
    Friend WithEvents ButtonFormSignInUser As Button
    Friend WithEvents ButtonFormSignUpUser As Button
End Class
