<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBukuPenjualanEdit
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
        Me.LabelTanggalPenjualan = New System.Windows.Forms.Label()
        Me.LabelHargaTerjual = New System.Windows.Forms.Label()
        Me.LabelPembeli = New System.Windows.Forms.Label()
        Me.LabelIdMobil = New System.Windows.Forms.Label()
        Me.DateTimePickerTanggalPenjualan = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxHargaTerjual = New System.Windows.Forms.TextBox()
        Me.ComboBoxIdPembeli = New System.Windows.Forms.ComboBox()
        Me.ComboBoxIdMobil = New System.Windows.Forms.ComboBox()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.PictureBoxBack = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelTanggalPenjualan
        '
        Me.LabelTanggalPenjualan.AutoSize = True
        Me.LabelTanggalPenjualan.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelTanggalPenjualan.Location = New System.Drawing.Point(386, 221)
        Me.LabelTanggalPenjualan.Name = "LabelTanggalPenjualan"
        Me.LabelTanggalPenjualan.Size = New System.Drawing.Size(152, 21)
        Me.LabelTanggalPenjualan.TabIndex = 15
        Me.LabelTanggalPenjualan.Text = "Tanggal Penjualan"
        '
        'LabelHargaTerjual
        '
        Me.LabelHargaTerjual.AutoSize = True
        Me.LabelHargaTerjual.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelHargaTerjual.Location = New System.Drawing.Point(384, 167)
        Me.LabelHargaTerjual.Name = "LabelHargaTerjual"
        Me.LabelHargaTerjual.Size = New System.Drawing.Size(112, 21)
        Me.LabelHargaTerjual.TabIndex = 14
        Me.LabelHargaTerjual.Text = "Harga Terjual"
        '
        'LabelPembeli
        '
        Me.LabelPembeli.AutoSize = True
        Me.LabelPembeli.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelPembeli.Location = New System.Drawing.Point(386, 110)
        Me.LabelPembeli.Name = "LabelPembeli"
        Me.LabelPembeli.Size = New System.Drawing.Size(73, 21)
        Me.LabelPembeli.TabIndex = 13
        Me.LabelPembeli.Text = "Pembeli"
        '
        'LabelIdMobil
        '
        Me.LabelIdMobil.AutoSize = True
        Me.LabelIdMobil.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelIdMobil.Location = New System.Drawing.Point(386, 56)
        Me.LabelIdMobil.Name = "LabelIdMobil"
        Me.LabelIdMobil.Size = New System.Drawing.Size(76, 21)
        Me.LabelIdMobil.TabIndex = 12
        Me.LabelIdMobil.Text = "ID Mobil"
        '
        'DateTimePickerTanggalPenjualan
        '
        Me.DateTimePickerTanggalPenjualan.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePickerTanggalPenjualan.Location = New System.Drawing.Point(386, 244)
        Me.DateTimePickerTanggalPenjualan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePickerTanggalPenjualan.Name = "DateTimePickerTanggalPenjualan"
        Me.DateTimePickerTanggalPenjualan.Size = New System.Drawing.Size(219, 29)
        Me.DateTimePickerTanggalPenjualan.TabIndex = 11
        '
        'TextBoxHargaTerjual
        '
        Me.TextBoxHargaTerjual.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxHargaTerjual.Location = New System.Drawing.Point(386, 190)
        Me.TextBoxHargaTerjual.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxHargaTerjual.Name = "TextBoxHargaTerjual"
        Me.TextBoxHargaTerjual.Size = New System.Drawing.Size(110, 29)
        Me.TextBoxHargaTerjual.TabIndex = 10
        '
        'ComboBoxIdPembeli
        '
        Me.ComboBoxIdPembeli.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ComboBoxIdPembeli.FormattingEnabled = True
        Me.ComboBoxIdPembeli.Location = New System.Drawing.Point(384, 136)
        Me.ComboBoxIdPembeli.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxIdPembeli.Name = "ComboBoxIdPembeli"
        Me.ComboBoxIdPembeli.Size = New System.Drawing.Size(219, 29)
        Me.ComboBoxIdPembeli.TabIndex = 9
        '
        'ComboBoxIdMobil
        '
        Me.ComboBoxIdMobil.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ComboBoxIdMobil.FormattingEnabled = True
        Me.ComboBoxIdMobil.Location = New System.Drawing.Point(386, 79)
        Me.ComboBoxIdMobil.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxIdMobil.Name = "ComboBoxIdMobil"
        Me.ComboBoxIdMobil.Size = New System.Drawing.Size(219, 29)
        Me.ComboBoxIdMobil.TabIndex = 8
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackgroundImage = Global.SistemJualBeliMobil.My.Resources.Resources.bgputihbtn
        Me.ButtonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonCancel.FlatAppearance.BorderSize = 0
        Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonCancel.Location = New System.Drawing.Point(597, 295)
        Me.ButtonCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(82, 32)
        Me.ButtonCancel.TabIndex = 17
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
        Me.ButtonEdit.Location = New System.Drawing.Point(386, 295)
        Me.ButtonEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(82, 32)
        Me.ButtonEdit.TabIndex = 16
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'PictureBoxBack
        '
        Me.PictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxBack.Location = New System.Drawing.Point(386, 11)
        Me.PictureBoxBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBoxBack.Name = "PictureBoxBack"
        Me.PictureBoxBack.Size = New System.Drawing.Size(66, 28)
        Me.PictureBoxBack.TabIndex = 18
        Me.PictureBoxBack.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SistemJualBeliMobil.My.Resources.Resources.MobilBawah
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(-148, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(633, 351)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'FormBukuPenjualanEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(700, 338)
        Me.Controls.Add(Me.PictureBoxBack)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonEdit)
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
        Me.Name = "FormBukuPenjualanEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Buku Penjualan"
        CType(Me.PictureBoxBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTanggalPenjualan As Label
    Friend WithEvents LabelHargaTerjual As Label
    Friend WithEvents LabelPembeli As Label
    Friend WithEvents LabelIdMobil As Label
    Friend WithEvents DateTimePickerTanggalPenjualan As DateTimePicker
    Friend WithEvents TextBoxHargaTerjual As TextBox
    Friend WithEvents ComboBoxIdPembeli As ComboBox
    Friend WithEvents ComboBoxIdMobil As ComboBox
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents PictureBoxBack As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
