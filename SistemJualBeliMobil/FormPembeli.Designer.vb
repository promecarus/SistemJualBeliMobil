<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPembeli
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
        Me.DataGridViewPembeli = New System.Windows.Forms.DataGridView()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.PictureBoxBack = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridViewPembeli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewPembeli
        '
        Me.DataGridViewPembeli.AllowUserToAddRows = False
        Me.DataGridViewPembeli.AllowUserToDeleteRows = False
        Me.DataGridViewPembeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPembeli.Location = New System.Drawing.Point(12, 55)
        Me.DataGridViewPembeli.Name = "DataGridViewPembeli"
        Me.DataGridViewPembeli.ReadOnly = True
        Me.DataGridViewPembeli.RowHeadersWidth = 51
        Me.DataGridViewPembeli.RowTemplate.Height = 29
        Me.DataGridViewPembeli.Size = New System.Drawing.Size(776, 344)
        Me.DataGridViewPembeli.TabIndex = 0
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Location = New System.Drawing.Point(11, 410)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(251, 29)
        Me.ButtonTambah.TabIndex = 1
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Location = New System.Drawing.Point(274, 410)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(251, 29)
        Me.ButtonEdit.TabIndex = 2
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Location = New System.Drawing.Point(537, 410)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(251, 29)
        Me.ButtonHapus.TabIndex = 3
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'PictureBoxBack
        '
        Me.PictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxBack.Location = New System.Drawing.Point(12, 12)
        Me.PictureBoxBack.Name = "PictureBoxBack"
        Me.PictureBoxBack.Size = New System.Drawing.Size(75, 37)
        Me.PictureBoxBack.TabIndex = 4
        Me.PictureBoxBack.TabStop = False
        '
        'FormPembeli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBoxBack)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.ButtonTambah)
        Me.Controls.Add(Me.DataGridViewPembeli)
        Me.Name = "FormPembeli"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pembeli"
        CType(Me.DataGridViewPembeli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewPembeli As DataGridView
    Friend WithEvents ButtonTambah As Button
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents ButtonHapus As Button
    Friend WithEvents PictureBoxBack As PictureBox
End Class
