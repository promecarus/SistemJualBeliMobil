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
        Me.ButtonFormSignIn = New System.Windows.Forms.Button()
        Me.ButtonFormSignUp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonFormSignIn
        '
        Me.ButtonFormSignIn.Location = New System.Drawing.Point(12, 12)
        Me.ButtonFormSignIn.Name = "ButtonFormSignIn"
        Me.ButtonFormSignIn.Size = New System.Drawing.Size(150, 29)
        Me.ButtonFormSignIn.TabIndex = 0
        Me.ButtonFormSignIn.Text = "Form Sign In"
        Me.ButtonFormSignIn.UseVisualStyleBackColor = True
        '
        'ButtonFormSignUp
        '
        Me.ButtonFormSignUp.Location = New System.Drawing.Point(168, 12)
        Me.ButtonFormSignUp.Name = "ButtonFormSignUp"
        Me.ButtonFormSignUp.Size = New System.Drawing.Size(150, 29)
        Me.ButtonFormSignUp.TabIndex = 0
        Me.ButtonFormSignUp.Text = "Form Sign Up"
        Me.ButtonFormSignUp.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonFormSignUp)
        Me.Controls.Add(Me.ButtonFormSignIn)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonFormSignIn As Button
    Friend WithEvents ButtonFormSignUp As Button
End Class
