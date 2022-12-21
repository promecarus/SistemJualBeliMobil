<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPembeliHapus
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
        Me.LabelKonfirmasi = New System.Windows.Forms.Label()
        Me.LabelNamaPembeli = New System.Windows.Forms.Label()
        Me.ButtonYes = New System.Windows.Forms.Button()
        Me.ButtonNo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelKonfirmasi
        '
        Me.LabelKonfirmasi.AutoSize = True
        Me.LabelKonfirmasi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelKonfirmasi.Location = New System.Drawing.Point(13, 25)
        Me.LabelKonfirmasi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelKonfirmasi.Name = "LabelKonfirmasi"
        Me.LabelKonfirmasi.Size = New System.Drawing.Size(363, 21)
        Me.LabelKonfirmasi.TabIndex = 0
        Me.LabelKonfirmasi.Text = "Apakah Anda yakin ingin menghapus pembeli"
        '
        'LabelNamaPembeli
        '
        Me.LabelNamaPembeli.AutoSize = True
        Me.LabelNamaPembeli.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelNamaPembeli.ForeColor = System.Drawing.Color.Red
        Me.LabelNamaPembeli.Location = New System.Drawing.Point(140, 66)
        Me.LabelNamaPembeli.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNamaPembeli.Name = "LabelNamaPembeli"
        Me.LabelNamaPembeli.Size = New System.Drawing.Size(123, 21)
        Me.LabelNamaPembeli.TabIndex = 1
        Me.LabelNamaPembeli.Text = "Nama Pembeli"
        '
        'ButtonYes
        '
        Me.ButtonYes.BackgroundImage = Global.SistemJualBeliMobil.My.Resources.Resources.bgbutton
        Me.ButtonYes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonYes.FlatAppearance.BorderSize = 0
        Me.ButtonYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonYes.ForeColor = System.Drawing.Color.White
        Me.ButtonYes.Location = New System.Drawing.Point(73, 111)
        Me.ButtonYes.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonYes.Name = "ButtonYes"
        Me.ButtonYes.Size = New System.Drawing.Size(117, 31)
        Me.ButtonYes.TabIndex = 0
        Me.ButtonYes.Text = "Yes"
        Me.ButtonYes.UseVisualStyleBackColor = True
        '
        'ButtonNo
        '
        Me.ButtonNo.BackgroundImage = Global.SistemJualBeliMobil.My.Resources.Resources.bgputihbtn1
        Me.ButtonNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonNo.FlatAppearance.BorderSize = 0
        Me.ButtonNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNo.Location = New System.Drawing.Point(210, 111)
        Me.ButtonNo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonNo.Name = "ButtonNo"
        Me.ButtonNo.Size = New System.Drawing.Size(117, 31)
        Me.ButtonNo.TabIndex = 3
        Me.ButtonNo.Text = "No"
        Me.ButtonNo.UseVisualStyleBackColor = True
        '
        'FormPembeliHapus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(397, 188)
        Me.Controls.Add(Me.ButtonNo)
        Me.Controls.Add(Me.ButtonYes)
        Me.Controls.Add(Me.LabelNamaPembeli)
        Me.Controls.Add(Me.LabelKonfirmasi)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FormPembeliHapus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hapus Pembeli"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelKonfirmasi As Label
    Friend WithEvents LabelNamaPembeli As Label
    Friend WithEvents ButtonYes As Button
    Friend WithEvents ButtonNo As Button
End Class
