<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBukuPenjualanHapus
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
        Me.ButtonNo = New System.Windows.Forms.Button()
        Me.ButtonYes = New System.Windows.Forms.Button()
        Me.LabelIdPenjualan = New System.Windows.Forms.Label()
        Me.LabelKonfirmasi = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonNo
        '
        Me.ButtonNo.Location = New System.Drawing.Point(408, 258)
        Me.ButtonNo.Name = "ButtonNo"
        Me.ButtonNo.Size = New System.Drawing.Size(94, 29)
        Me.ButtonNo.TabIndex = 7
        Me.ButtonNo.Text = "No"
        Me.ButtonNo.UseVisualStyleBackColor = True
        '
        'ButtonYes
        '
        Me.ButtonYes.Location = New System.Drawing.Point(308, 258)
        Me.ButtonYes.Name = "ButtonYes"
        Me.ButtonYes.Size = New System.Drawing.Size(94, 29)
        Me.ButtonYes.TabIndex = 4
        Me.ButtonYes.Text = "Yes"
        Me.ButtonYes.UseVisualStyleBackColor = True
        '
        'LabelIdPenjualan
        '
        Me.LabelIdPenjualan.AutoSize = True
        Me.LabelIdPenjualan.Location = New System.Drawing.Point(341, 206)
        Me.LabelIdPenjualan.Name = "LabelIdPenjualan"
        Me.LabelIdPenjualan.Size = New System.Drawing.Size(127, 20)
        Me.LabelIdPenjualan.TabIndex = 6
        Me.LabelIdPenjualan.Text = "ID Buku Penjualan"
        '
        'LabelKonfirmasi
        '
        Me.LabelKonfirmasi.AutoSize = True
        Me.LabelKonfirmasi.Location = New System.Drawing.Point(156, 159)
        Me.LabelKonfirmasi.Name = "LabelKonfirmasi"
        Me.LabelKonfirmasi.Size = New System.Drawing.Size(466, 20)
        Me.LabelKonfirmasi.TabIndex = 5
        Me.LabelKonfirmasi.Text = "Apakah Anda yakin ingin menghapus data buku penjualan dengan ID"
        '
        'FormBukuPenjualanHapus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonNo)
        Me.Controls.Add(Me.ButtonYes)
        Me.Controls.Add(Me.LabelIdPenjualan)
        Me.Controls.Add(Me.LabelKonfirmasi)
        Me.Name = "FormBukuPenjualanHapus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hapus Buku Penjualan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonNo As Button
    Friend WithEvents ButtonYes As Button
    Friend WithEvents LabelIdPenjualan As Label
    Friend WithEvents LabelKonfirmasi As Label
End Class
