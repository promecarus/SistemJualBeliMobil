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
        Me.PictureBoxBack = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackgroundImage = Global.SistemJualBeliMobil.My.Resources.Resources.bgputihbtn
        Me.ButtonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonCancel.FlatAppearance.BorderSize = 0
        Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonCancel.Location = New System.Drawing.Point(562, 300)
        Me.ButtonCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(114, 30)
        Me.ButtonCancel.TabIndex = 11
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonEdit
        '
        Me.ButtonEdit.BackgroundImage = Global.SistemJualBeliMobil.My.Resources.Resources.bgbutton
        Me.ButtonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonEdit.FlatAppearance.BorderSize = 0
        Me.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEdit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonEdit.ForeColor = System.Drawing.Color.White
        Me.ButtonEdit.Location = New System.Drawing.Point(383, 300)
        Me.ButtonEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(115, 30)
        Me.ButtonEdit.TabIndex = 9
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'LabelAlamat
        '
        Me.LabelAlamat.AutoSize = True
        Me.LabelAlamat.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelAlamat.Location = New System.Drawing.Point(377, 177)
        Me.LabelAlamat.Name = "LabelAlamat"
        Me.LabelAlamat.Size = New System.Drawing.Size(65, 21)
        Me.LabelAlamat.TabIndex = 13
        Me.LabelAlamat.Text = "Alamat"
        '
        'LabelNama
        '
        Me.LabelNama.AutoSize = True
        Me.LabelNama.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelNama.Location = New System.Drawing.Point(377, 114)
        Me.LabelNama.Name = "LabelNama"
        Me.LabelNama.Size = New System.Drawing.Size(56, 21)
        Me.LabelNama.TabIndex = 12
        Me.LabelNama.Text = "Nama"
        '
        'LabelNik
        '
        Me.LabelNik.AutoSize = True
        Me.LabelNik.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelNik.Location = New System.Drawing.Point(377, 46)
        Me.LabelNik.Name = "LabelNik"
        Me.LabelNik.Size = New System.Drawing.Size(38, 21)
        Me.LabelNik.TabIndex = 10
        Me.LabelNik.Text = "NIK"
        '
        'RichTextBoxAlamat
        '
        Me.RichTextBoxAlamat.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RichTextBoxAlamat.Location = New System.Drawing.Point(377, 200)
        Me.RichTextBoxAlamat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RichTextBoxAlamat.Name = "RichTextBoxAlamat"
        Me.RichTextBoxAlamat.Size = New System.Drawing.Size(299, 81)
        Me.RichTextBoxAlamat.TabIndex = 8
        Me.RichTextBoxAlamat.Text = ""
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxNama.Location = New System.Drawing.Point(377, 137)
        Me.TextBoxNama.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(142, 29)
        Me.TextBoxNama.TabIndex = 7
        '
        'TextBoxNik
        '
        Me.TextBoxNik.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxNik.Location = New System.Drawing.Point(377, 69)
        Me.TextBoxNik.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxNik.Name = "TextBoxNik"
        Me.TextBoxNik.Size = New System.Drawing.Size(142, 29)
        Me.TextBoxNik.TabIndex = 6
        '
        'PictureBoxBack
        '
        Me.PictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxBack.Location = New System.Drawing.Point(377, 11)
        Me.PictureBoxBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBoxBack.Name = "PictureBoxBack"
        Me.PictureBoxBack.Size = New System.Drawing.Size(98, 33)
        Me.PictureBoxBack.TabIndex = 19
        Me.PictureBoxBack.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SistemJualBeliMobil.My.Resources.Resources.MobilBawah
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(-144, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(633, 351)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'FormPembeliEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(700, 338)
        Me.Controls.Add(Me.PictureBoxBack)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.LabelAlamat)
        Me.Controls.Add(Me.LabelNama)
        Me.Controls.Add(Me.LabelNik)
        Me.Controls.Add(Me.RichTextBoxAlamat)
        Me.Controls.Add(Me.TextBoxNama)
        Me.Controls.Add(Me.TextBoxNik)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormPembeliEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Pembeli"
        CType(Me.PictureBoxBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBoxBack As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
