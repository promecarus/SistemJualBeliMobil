<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBukuPenjualan
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
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.DataGridViewBukuPenjualan = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridViewBukuPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Location = New System.Drawing.Point(538, 410)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(251, 29)
        Me.ButtonHapus.TabIndex = 7
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Location = New System.Drawing.Point(275, 410)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(251, 29)
        Me.ButtonEdit.TabIndex = 6
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Location = New System.Drawing.Point(12, 410)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(251, 29)
        Me.ButtonTambah.TabIndex = 5
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'DataGridViewBukuPenjualan
        '
        Me.DataGridViewBukuPenjualan.AllowUserToAddRows = False
        Me.DataGridViewBukuPenjualan.AllowUserToDeleteRows = False
        Me.DataGridViewBukuPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBukuPenjualan.Location = New System.Drawing.Point(13, 12)
        Me.DataGridViewBukuPenjualan.Name = "DataGridViewBukuPenjualan"
        Me.DataGridViewBukuPenjualan.ReadOnly = True
        Me.DataGridViewBukuPenjualan.RowHeadersWidth = 51
        Me.DataGridViewBukuPenjualan.RowTemplate.Height = 29
        Me.DataGridViewBukuPenjualan.Size = New System.Drawing.Size(776, 387)
        Me.DataGridViewBukuPenjualan.TabIndex = 4
        '
        'FormBukuPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.ButtonTambah)
        Me.Controls.Add(Me.DataGridViewBukuPenjualan)
        Me.Name = "FormBukuPenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buku Penjualan"
        CType(Me.DataGridViewBukuPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonHapus As Button
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents ButtonTambah As Button
    Friend WithEvents DataGridViewBukuPenjualan As DataGridView
End Class
