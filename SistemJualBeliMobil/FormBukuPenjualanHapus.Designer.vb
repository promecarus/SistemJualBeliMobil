﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.PictureBoxBack = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBoxBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonNo
        '
        Me.ButtonNo.BackgroundImage = Global.SistemJualBeliMobil.My.Resources.Resources.bgputihbtn
        Me.ButtonNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonNo.FlatAppearance.BorderSize = 0
        Me.ButtonNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonNo.Location = New System.Drawing.Point(203, 169)
        Me.ButtonNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonNo.Name = "ButtonNo"
        Me.ButtonNo.Size = New System.Drawing.Size(82, 31)
        Me.ButtonNo.TabIndex = 7
        Me.ButtonNo.Text = "No"
        Me.ButtonNo.UseVisualStyleBackColor = True
        '
        'ButtonYes
        '
        Me.ButtonYes.BackgroundImage = Global.SistemJualBeliMobil.My.Resources.Resources.bgbutton
        Me.ButtonYes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonYes.FlatAppearance.BorderSize = 0
        Me.ButtonYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonYes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonYes.ForeColor = System.Drawing.Color.White
        Me.ButtonYes.Location = New System.Drawing.Point(116, 169)
        Me.ButtonYes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonYes.Name = "ButtonYes"
        Me.ButtonYes.Size = New System.Drawing.Size(82, 31)
        Me.ButtonYes.TabIndex = 4
        Me.ButtonYes.Text = "Yes"
        Me.ButtonYes.UseVisualStyleBackColor = True
        '
        'LabelIdPenjualan
        '
        Me.LabelIdPenjualan.AutoSize = True
        Me.LabelIdPenjualan.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelIdPenjualan.ForeColor = System.Drawing.Color.Red
        Me.LabelIdPenjualan.Location = New System.Drawing.Point(114, 121)
        Me.LabelIdPenjualan.Name = "LabelIdPenjualan"
        Me.LabelIdPenjualan.Size = New System.Drawing.Size(151, 21)
        Me.LabelIdPenjualan.TabIndex = 6
        Me.LabelIdPenjualan.Text = "ID Buku Penjualan"
        '
        'LabelKonfirmasi
        '
        Me.LabelKonfirmasi.AutoSize = True
        Me.LabelKonfirmasi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelKonfirmasi.Location = New System.Drawing.Point(54, 58)
        Me.LabelKonfirmasi.Name = "LabelKonfirmasi"
        Me.LabelKonfirmasi.Size = New System.Drawing.Size(300, 21)
        Me.LabelKonfirmasi.TabIndex = 5
        Me.LabelKonfirmasi.Text = "Apakah Anda yakin ingin menghapus "
        '
        'PictureBoxBack
        '
        Me.PictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxBack.Location = New System.Drawing.Point(10, 9)
        Me.PictureBoxBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBoxBack.Name = "PictureBoxBack"
        Me.PictureBoxBack.Size = New System.Drawing.Size(66, 28)
        Me.PictureBoxBack.TabIndex = 8
        Me.PictureBoxBack.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(73, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 21)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "data buku penjualan dengan ID"
        '
        'FormBukuPenjualanHapus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(390, 241)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBoxBack)
        Me.Controls.Add(Me.ButtonNo)
        Me.Controls.Add(Me.ButtonYes)
        Me.Controls.Add(Me.LabelIdPenjualan)
        Me.Controls.Add(Me.LabelKonfirmasi)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormBukuPenjualanHapus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hapus Buku Penjualan"
        CType(Me.PictureBoxBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonNo As Button
    Friend WithEvents ButtonYes As Button
    Friend WithEvents LabelIdPenjualan As Label
    Friend WithEvents LabelKonfirmasi As Label
    Friend WithEvents PictureBoxBack As PictureBox
    Friend WithEvents Label1 As Label
End Class
