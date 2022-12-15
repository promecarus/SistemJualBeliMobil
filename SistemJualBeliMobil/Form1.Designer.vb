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
        Me.ButtonFormJenisMobil = New System.Windows.Forms.Button()
        Me.ButtonFormTambahJenisMobil = New System.Windows.Forms.Button()
        Me.ButtonFormEditJenisMobil = New System.Windows.Forms.Button()
        Me.ButtonFormHapusJenisMobil = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonFormSignIn
        '
        Me.ButtonFormSignIn.Location = New System.Drawing.Point(12, 12)
        Me.ButtonFormSignIn.Name = "ButtonFormSignIn"
        Me.ButtonFormSignIn.Size = New System.Drawing.Size(200, 29)
        Me.ButtonFormSignIn.TabIndex = 0
        Me.ButtonFormSignIn.Text = "Form Sign In"
        Me.ButtonFormSignIn.UseVisualStyleBackColor = True
        '
        'ButtonFormSignUp
        '
        Me.ButtonFormSignUp.Location = New System.Drawing.Point(218, 12)
        Me.ButtonFormSignUp.Name = "ButtonFormSignUp"
        Me.ButtonFormSignUp.Size = New System.Drawing.Size(200, 29)
        Me.ButtonFormSignUp.TabIndex = 0
        Me.ButtonFormSignUp.Text = "Form Sign Up"
        Me.ButtonFormSignUp.UseVisualStyleBackColor = True
        '
        'ButtonFormJenisMobil
        '
        Me.ButtonFormJenisMobil.Location = New System.Drawing.Point(12, 47)
        Me.ButtonFormJenisMobil.Name = "ButtonFormJenisMobil"
        Me.ButtonFormJenisMobil.Size = New System.Drawing.Size(200, 29)
        Me.ButtonFormJenisMobil.TabIndex = 0
        Me.ButtonFormJenisMobil.Text = "Form Jenis Mobil"
        Me.ButtonFormJenisMobil.UseVisualStyleBackColor = True
        '
        'ButtonFormTambahJenisMobil
        '
        Me.ButtonFormTambahJenisMobil.Location = New System.Drawing.Point(218, 47)
        Me.ButtonFormTambahJenisMobil.Name = "ButtonFormTambahJenisMobil"
        Me.ButtonFormTambahJenisMobil.Size = New System.Drawing.Size(200, 29)
        Me.ButtonFormTambahJenisMobil.TabIndex = 0
        Me.ButtonFormTambahJenisMobil.Text = "Form Tambah Jenis Mobil"
        Me.ButtonFormTambahJenisMobil.UseVisualStyleBackColor = True
        '
        'ButtonFormEditJenisMobil
        '
        Me.ButtonFormEditJenisMobil.Location = New System.Drawing.Point(424, 47)
        Me.ButtonFormEditJenisMobil.Name = "ButtonFormEditJenisMobil"
        Me.ButtonFormEditJenisMobil.Size = New System.Drawing.Size(200, 29)
        Me.ButtonFormEditJenisMobil.TabIndex = 0
        Me.ButtonFormEditJenisMobil.Text = "Form Edit Jenis Mobil"
        Me.ButtonFormEditJenisMobil.UseVisualStyleBackColor = True
        '
        'ButtonFormHapusJenisMobil
        '
        Me.ButtonFormHapusJenisMobil.Location = New System.Drawing.Point(630, 47)
        Me.ButtonFormHapusJenisMobil.Name = "ButtonFormHapusJenisMobil"
        Me.ButtonFormHapusJenisMobil.Size = New System.Drawing.Size(200, 29)
        Me.ButtonFormHapusJenisMobil.TabIndex = 0
        Me.ButtonFormHapusJenisMobil.Text = "Form Hapus Jenis Mobil"
        Me.ButtonFormHapusJenisMobil.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 450)
        Me.Controls.Add(Me.ButtonFormSignUp)
        Me.Controls.Add(Me.ButtonFormHapusJenisMobil)
        Me.Controls.Add(Me.ButtonFormEditJenisMobil)
        Me.Controls.Add(Me.ButtonFormTambahJenisMobil)
        Me.Controls.Add(Me.ButtonFormJenisMobil)
        Me.Controls.Add(Me.ButtonFormSignIn)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonFormSignIn As Button
    Friend WithEvents ButtonFormSignUp As Button
    Friend WithEvents ButtonFormJenisMobil As Button
    Friend WithEvents ButtonFormTambahJenisMobil As Button
    Friend WithEvents ButtonFormEditJenisMobil As Button
    Friend WithEvents ButtonFormHapusJenisMobil As Button
End Class
