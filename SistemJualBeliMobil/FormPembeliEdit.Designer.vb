<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPembeliEdit
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
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.LabelAlamat = New System.Windows.Forms.Label()
        Me.LabelNama = New System.Windows.Forms.Label()
        Me.LabelNik = New System.Windows.Forms.Label()
        Me.RichTextBoxAlamat = New System.Windows.Forms.RichTextBox()
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.TextBoxNik = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(112, 264)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(94, 29)
        Me.ButtonCancel.TabIndex = 11
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Location = New System.Drawing.Point(12, 264)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(94, 29)
        Me.ButtonEdit.TabIndex = 9
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'LabelAlamat
        '
        Me.LabelAlamat.AutoSize = True
        Me.LabelAlamat.Location = New System.Drawing.Point(12, 115)
        Me.LabelAlamat.Name = "LabelAlamat"
        Me.LabelAlamat.Size = New System.Drawing.Size(57, 20)
        Me.LabelAlamat.TabIndex = 13
        Me.LabelAlamat.Text = "Alamat"
        '
        'LabelNama
        '
        Me.LabelNama.AutoSize = True
        Me.LabelNama.Location = New System.Drawing.Point(12, 62)
        Me.LabelNama.Name = "LabelNama"
        Me.LabelNama.Size = New System.Drawing.Size(49, 20)
        Me.LabelNama.TabIndex = 12
        Me.LabelNama.Text = "Nama"
        '
        'LabelNik
        '
        Me.LabelNik.AutoSize = True
        Me.LabelNik.Location = New System.Drawing.Point(12, 9)
        Me.LabelNik.Name = "LabelNik"
        Me.LabelNik.Size = New System.Drawing.Size(33, 20)
        Me.LabelNik.TabIndex = 10
        Me.LabelNik.Text = "NIK"
        '
        'RichTextBoxAlamat
        '
        Me.RichTextBoxAlamat.Location = New System.Drawing.Point(12, 138)
        Me.RichTextBoxAlamat.Name = "RichTextBoxAlamat"
        Me.RichTextBoxAlamat.Size = New System.Drawing.Size(125, 120)
        Me.RichTextBoxAlamat.TabIndex = 8
        Me.RichTextBoxAlamat.Text = ""
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Location = New System.Drawing.Point(12, 85)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(125, 27)
        Me.TextBoxNama.TabIndex = 7
        '
        'TextBoxNik
        '
        Me.TextBoxNik.Location = New System.Drawing.Point(12, 32)
        Me.TextBoxNik.Name = "TextBoxNik"
        Me.TextBoxNik.Size = New System.Drawing.Size(125, 27)
        Me.TextBoxNik.TabIndex = 6
        '
        'FormPembeliEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.LabelAlamat)
        Me.Controls.Add(Me.LabelNama)
        Me.Controls.Add(Me.LabelNik)
        Me.Controls.Add(Me.RichTextBoxAlamat)
        Me.Controls.Add(Me.TextBoxNama)
        Me.Controls.Add(Me.TextBoxNik)
        Me.Name = "FormPembeliEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Pembeli"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents LabelAlamat As Label
    Friend WithEvents LabelNama As Label
    Friend WithEvents LabelNik As Label
    Friend WithEvents RichTextBoxAlamat As RichTextBox
    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents TextBoxNik As TextBox
End Class
