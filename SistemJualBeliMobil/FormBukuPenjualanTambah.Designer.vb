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
        Me.PictureBoxBack = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxIdMobil
        '
        Me.ComboBoxIdMobil.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ComboBoxIdMobil.FormattingEnabled = True
        Me.ComboBoxIdMobil.Location = New System.Drawing.Point(23, 73)
        Me.ComboBoxIdMobil.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxIdMobil.Name = "ComboBoxIdMobil"
        Me.ComboBoxIdMobil.Size = New System.Drawing.Size(218, 29)
        Me.ComboBoxIdMobil.TabIndex = 0
        '
        'ComboBoxIdPembeli
        '
        Me.ComboBoxIdPembeli.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ComboBoxIdPembeli.FormattingEnabled = True
        Me.ComboBoxIdPembeli.Location = New System.Drawing.Point(23, 133)
        Me.ComboBoxIdPembeli.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxIdPembeli.Name = "ComboBoxIdPembeli"
        Me.ComboBoxIdPembeli.Size = New System.Drawing.Size(218, 29)
        Me.ComboBoxIdPembeli.TabIndex = 1
        '
        'TextBoxHargaTerjual
        '
        Me.TextBoxHargaTerjual.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxHargaTerjual.Location = New System.Drawing.Point(22, 187)
        Me.TextBoxHargaTerjual.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxHargaTerjual.Name = "TextBoxHargaTerjual"
        Me.TextBoxHargaTerjual.Size = New System.Drawing.Size(219, 29)
        Me.TextBoxHargaTerjual.TabIndex = 2
        '
        'DateTimePickerTanggalPenjualan
        '
        Me.DateTimePickerTanggalPenjualan.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePickerTanggalPenjualan.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePickerTanggalPenjualan.Location = New System.Drawing.Point(22, 241)
        Me.DateTimePickerTanggalPenjualan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePickerTanggalPenjualan.Name = "DateTimePickerTanggalPenjualan"
        Me.DateTimePickerTanggalPenjualan.Size = New System.Drawing.Size(219, 29)
        Me.DateTimePickerTanggalPenjualan.TabIndex = 3
        '
        'LabelIdMobil
        '
        Me.LabelIdMobil.AutoSize = True
        Me.LabelIdMobil.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelIdMobil.Location = New System.Drawing.Point(22, 50)
        Me.LabelIdMobil.Name = "LabelIdMobil"
        Me.LabelIdMobil.Size = New System.Drawing.Size(76, 21)
        Me.LabelIdMobil.TabIndex = 4
        Me.LabelIdMobil.Text = "ID Mobil"
        '
        'LabelPembeli
        '
        Me.LabelPembeli.AutoSize = True
        Me.LabelPembeli.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelPembeli.Location = New System.Drawing.Point(22, 104)
        Me.LabelPembeli.Name = "LabelPembeli"
        Me.LabelPembeli.Size = New System.Drawing.Size(73, 21)
        Me.LabelPembeli.TabIndex = 5
        Me.LabelPembeli.Text = "Pembeli"
        '
        'LabelHargaTerjual
        '
        Me.LabelHargaTerjual.AutoSize = True
        Me.LabelHargaTerjual.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelHargaTerjual.Location = New System.Drawing.Point(23, 164)
        Me.LabelHargaTerjual.Name = "LabelHargaTerjual"
        Me.LabelHargaTerjual.Size = New System.Drawing.Size(112, 21)
        Me.LabelHargaTerjual.TabIndex = 6
        Me.LabelHargaTerjual.Text = "Harga Terjual"
        '
        'LabelTanggalPenjualan
        '
        Me.LabelTanggalPenjualan.AutoSize = True
        Me.LabelTanggalPenjualan.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelTanggalPenjualan.Location = New System.Drawing.Point(22, 218)
        Me.LabelTanggalPenjualan.Name = "LabelTanggalPenjualan"
        Me.LabelTanggalPenjualan.Size = New System.Drawing.Size(152, 21)
        Me.LabelTanggalPenjualan.TabIndex = 7
        Me.LabelTanggalPenjualan.Text = "Tanggal Penjualan"
        '
        'ButtonTambah
        '
        Me.ButtonTambah.BackgroundImage = Global.SistemJualBeliMobil.My.Resources.Resources.bgbutton
        Me.ButtonTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonTambah.FlatAppearance.BorderSize = 0
        Me.ButtonTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTambah.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonTambah.ForeColor = System.Drawing.Color.White
        Me.ButtonTambah.Location = New System.Drawing.Point(23, 293)
        Me.ButtonTambah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(82, 34)
        Me.ButtonTambah.TabIndex = 4
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackgroundImage = Global.SistemJualBeliMobil.My.Resources.Resources.bgputihbtn
        Me.ButtonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonCancel.FlatAppearance.BorderSize = 0
        Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonCancel.Location = New System.Drawing.Point(206, 293)
        Me.ButtonCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(82, 34)
        Me.ButtonCancel.TabIndex = 8
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'PictureBoxBack
        '
        Me.PictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxBack.Location = New System.Drawing.Point(23, 11)
        Me.PictureBoxBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBoxBack.Name = "PictureBoxBack"
        Me.PictureBoxBack.Size = New System.Drawing.Size(66, 28)
        Me.PictureBoxBack.TabIndex = 9
        Me.PictureBoxBack.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SistemJualBeliMobil.My.Resources.Resources._3
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(324, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(484, 242)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'FormBukuPenjualanTambah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(700, 338)
        Me.Controls.Add(Me.PictureBoxBack)
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
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormBukuPenjualanTambah"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Buku Penjualan"
        CType(Me.PictureBoxBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBoxBack As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
