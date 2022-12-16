<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBukuPenjualanTambah
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
        Me.ComboBoxIdMobil = New System.Windows.Forms.ComboBox()
        Me.ComboBoxIdPembeli = New System.Windows.Forms.ComboBox()
        Me.TextBoxHargaTerjual = New System.Windows.Forms.TextBox()
        Me.DateTimePickerTanggalPenjualan = New System.Windows.Forms.DateTimePicker()
        Me.LabelIdMobil = New System.Windows.Forms.Label()
        Me.LabelPembeli = New System.Windows.Forms.Label()
        Me.LabelHargaTerjual = New System.Windows.Forms.Label()
        Me.LabelTanggalPenjualan = New System.Windows.Forms.Label()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBoxIdMobil
        '
        Me.ComboBoxIdMobil.FormattingEnabled = True
        Me.ComboBoxIdMobil.Location = New System.Drawing.Point(12, 32)
        Me.ComboBoxIdMobil.Name = "ComboBoxIdMobil"
        Me.ComboBoxIdMobil.Size = New System.Drawing.Size(151, 28)
        Me.ComboBoxIdMobil.TabIndex = 0
        '
        'ComboBoxIdPembeli
        '
        Me.ComboBoxIdPembeli.FormattingEnabled = True
        Me.ComboBoxIdPembeli.Location = New System.Drawing.Point(12, 86)
        Me.ComboBoxIdPembeli.Name = "ComboBoxIdPembeli"
        Me.ComboBoxIdPembeli.Size = New System.Drawing.Size(151, 28)
        Me.ComboBoxIdPembeli.TabIndex = 1
        '
        'TextBoxHargaTerjual
        '
        Me.TextBoxHargaTerjual.Location = New System.Drawing.Point(12, 140)
        Me.TextBoxHargaTerjual.Name = "TextBoxHargaTerjual"
        Me.TextBoxHargaTerjual.Size = New System.Drawing.Size(125, 27)
        Me.TextBoxHargaTerjual.TabIndex = 2
        '
        'DateTimePickerTanggalPenjualan
        '
        Me.DateTimePickerTanggalPenjualan.Location = New System.Drawing.Point(12, 193)
        Me.DateTimePickerTanggalPenjualan.Name = "DateTimePickerTanggalPenjualan"
        Me.DateTimePickerTanggalPenjualan.Size = New System.Drawing.Size(250, 27)
        Me.DateTimePickerTanggalPenjualan.TabIndex = 3
        '
        'LabelIdMobil
        '
        Me.LabelIdMobil.AutoSize = True
        Me.LabelIdMobil.Location = New System.Drawing.Point(12, 9)
        Me.LabelIdMobil.Name = "LabelIdMobil"
        Me.LabelIdMobil.Size = New System.Drawing.Size(67, 20)
        Me.LabelIdMobil.TabIndex = 4
        Me.LabelIdMobil.Text = "ID Mobil"
        '
        'LabelPembeli
        '
        Me.LabelPembeli.AutoSize = True
        Me.LabelPembeli.Location = New System.Drawing.Point(12, 63)
        Me.LabelPembeli.Name = "LabelPembeli"
        Me.LabelPembeli.Size = New System.Drawing.Size(62, 20)
        Me.LabelPembeli.TabIndex = 5
        Me.LabelPembeli.Text = "Pembeli"
        '
        'LabelHargaTerjual
        '
        Me.LabelHargaTerjual.AutoSize = True
        Me.LabelHargaTerjual.Location = New System.Drawing.Point(12, 117)
        Me.LabelHargaTerjual.Name = "LabelHargaTerjual"
        Me.LabelHargaTerjual.Size = New System.Drawing.Size(98, 20)
        Me.LabelHargaTerjual.TabIndex = 6
        Me.LabelHargaTerjual.Text = "Harga Terjual"
        '
        'LabelTanggalPenjualan
        '
        Me.LabelTanggalPenjualan.AutoSize = True
        Me.LabelTanggalPenjualan.Location = New System.Drawing.Point(12, 170)
        Me.LabelTanggalPenjualan.Name = "LabelTanggalPenjualan"
        Me.LabelTanggalPenjualan.Size = New System.Drawing.Size(128, 20)
        Me.LabelTanggalPenjualan.TabIndex = 7
        Me.LabelTanggalPenjualan.Text = "Tanggal Penjualan"
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Location = New System.Drawing.Point(12, 226)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(94, 29)
        Me.ButtonTambah.TabIndex = 4
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(112, 226)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(94, 29)
        Me.ButtonCancel.TabIndex = 8
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'FormBukuPenjualanTambah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonTambah)
        Me.Controls.Add(Me.LabelTanggalPenjualan)
        Me.Controls.Add(Me.LabelHargaTerjual)
        Me.Controls.Add(Me.LabelPembeli)
        Me.Controls.Add(Me.LabelIdMobil)
        Me.Controls.Add(Me.DateTimePickerTanggalPenjualan)
        Me.Controls.Add(Me.TextBoxHargaTerjual)
        Me.Controls.Add(Me.ComboBoxIdPembeli)
        Me.Controls.Add(Me.ComboBoxIdMobil)
        Me.Name = "FormBukuPenjualanTambah"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Buku Penjualan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxIdMobil As ComboBox
    Friend WithEvents ComboBoxIdPembeli As ComboBox
    Friend WithEvents TextBoxHargaTerjual As TextBox
    Friend WithEvents DateTimePickerTanggalPenjualan As DateTimePicker
    Friend WithEvents LabelIdMobil As Label
    Friend WithEvents LabelPembeli As Label
    Friend WithEvents LabelHargaTerjual As Label
    Friend WithEvents LabelTanggalPenjualan As Label
    Friend WithEvents ButtonTambah As Button
    Friend WithEvents ButtonCancel As Button
End Class
