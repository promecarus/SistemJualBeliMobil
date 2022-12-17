<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJenisMobilHapus
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
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.LblJenisMobil = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(353, 347)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(94, 29)
        Me.BtnHapus.TabIndex = 5
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'LblJenisMobil
        '
        Me.LblJenisMobil.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblJenisMobil.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblJenisMobil.ForeColor = System.Drawing.Color.Red
        Me.LblJenisMobil.Location = New System.Drawing.Point(12, 192)
        Me.LblJenisMobil.Name = "LblJenisMobil"
        Me.LblJenisMobil.Size = New System.Drawing.Size(776, 54)
        Me.LblJenisMobil.TabIndex = 4
        Me.LblJenisMobil.Text = "Jenis Mobil"
        Me.LblJenisMobil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(231, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(338, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Apakah Ingin Menghapus Jenis Mobil"
        '
        'FormJenisMobilHapus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.LblJenisMobil)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormJenisMobilHapus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hapus Jenis Mobil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnHapus As Button
    Friend WithEvents LblJenisMobil As Label
    Friend WithEvents Label1 As Label
End Class
