<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPembeliHapus
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
        Me.LabelKonfirmasi = New System.Windows.Forms.Label()
        Me.LabelNamaPembeli = New System.Windows.Forms.Label()
        Me.ButtonYes = New System.Windows.Forms.Button()
        Me.ButtonNo = New System.Windows.Forms.Button()
        Me.PictureBoxBack = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelKonfirmasi
        '
        Me.LabelKonfirmasi.AutoSize = True
        Me.LabelKonfirmasi.Location = New System.Drawing.Point(242, 92)
        Me.LabelKonfirmasi.Name = "LabelKonfirmasi"
        Me.LabelKonfirmasi.Size = New System.Drawing.Size(313, 20)
        Me.LabelKonfirmasi.TabIndex = 0
        Me.LabelKonfirmasi.Text = "Apakah Anda yakin ingin menghapus pembeli"
        '
        'LabelNamaPembeli
        '
        Me.LabelNamaPembeli.AutoSize = True
        Me.LabelNamaPembeli.Location = New System.Drawing.Point(350, 131)
        Me.LabelNamaPembeli.Name = "LabelNamaPembeli"
        Me.LabelNamaPembeli.Size = New System.Drawing.Size(106, 20)
        Me.LabelNamaPembeli.TabIndex = 1
        Me.LabelNamaPembeli.Text = "Nama Pembeli"
        '
        'ButtonYes
        '
        Me.ButtonYes.Location = New System.Drawing.Point(306, 186)
        Me.ButtonYes.Name = "ButtonYes"
        Me.ButtonYes.Size = New System.Drawing.Size(94, 29)
        Me.ButtonYes.TabIndex = 0
        Me.ButtonYes.Text = "Yes"
        Me.ButtonYes.UseVisualStyleBackColor = True
        '
        'ButtonNo
        '
        Me.ButtonNo.Location = New System.Drawing.Point(406, 186)
        Me.ButtonNo.Name = "ButtonNo"
        Me.ButtonNo.Size = New System.Drawing.Size(94, 29)
        Me.ButtonNo.TabIndex = 3
        Me.ButtonNo.Text = "No"
        Me.ButtonNo.UseVisualStyleBackColor = True
        '
        'PictureBoxBack
        '
        Me.PictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxBack.Location = New System.Drawing.Point(12, 12)
        Me.PictureBoxBack.Name = "PictureBoxBack"
        Me.PictureBoxBack.Size = New System.Drawing.Size(75, 37)
        Me.PictureBoxBack.TabIndex = 19
        Me.PictureBoxBack.TabStop = False
        '
        'FormPembeliHapus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBoxBack)
        Me.Controls.Add(Me.ButtonNo)
        Me.Controls.Add(Me.ButtonYes)
        Me.Controls.Add(Me.LabelNamaPembeli)
        Me.Controls.Add(Me.LabelKonfirmasi)
        Me.Name = "FormPembeliHapus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hapus Pembeli"
        CType(Me.PictureBoxBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelKonfirmasi As Label
    Friend WithEvents LabelNamaPembeli As Label
    Friend WithEvents ButtonYes As Button
    Friend WithEvents ButtonNo As Button
    Friend WithEvents PictureBoxBack As PictureBox
End Class
