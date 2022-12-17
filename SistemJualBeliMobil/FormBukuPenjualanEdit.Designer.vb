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
        CType(Me.PictureBoxBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelTanggalPenjualan
        '
        Me.LabelTanggalPenjualan.AutoSize = True
        Me.LabelTanggalPenjualan.Location = New System.Drawing.Point(12, 213)
        Me.LabelTanggalPenjualan.Name = "LabelTanggalPenjualan"
        Me.LabelTanggalPenjualan.Size = New System.Drawing.Size(128, 20)
        Me.LabelTanggalPenjualan.TabIndex = 15
        Me.LabelTanggalPenjualan.Text = "Tanggal Penjualan"
        '
        'LabelHargaTerjual
        '
        Me.LabelHargaTerjual.AutoSize = True
        Me.LabelHargaTerjual.Location = New System.Drawing.Point(12, 160)
        Me.LabelHargaTerjual.Name = "LabelHargaTerjual"
        Me.LabelHargaTerjual.Size = New System.Drawing.Size(98, 20)
        Me.LabelHargaTerjual.TabIndex = 14
        Me.LabelHargaTerjual.Text = "Harga Terjual"
        '
        'LabelPembeli
        '
        Me.LabelPembeli.AutoSize = True
        Me.LabelPembeli.Location = New System.Drawing.Point(12, 106)
        Me.LabelPembeli.Name = "LabelPembeli"
        Me.LabelPembeli.Size = New System.Drawing.Size(62, 20)
        Me.LabelPembeli.TabIndex = 13
        Me.LabelPembeli.Text = "Pembeli"
        '
        'LabelIdMobil
        '
        Me.LabelIdMobil.AutoSize = True
        Me.LabelIdMobil.Location = New System.Drawing.Point(12, 52)
        Me.LabelIdMobil.Name = "LabelIdMobil"
        Me.LabelIdMobil.Size = New System.Drawing.Size(67, 20)
        Me.LabelIdMobil.TabIndex = 12
        Me.LabelIdMobil.Text = "ID Mobil"
        '
        'DateTimePickerTanggalPenjualan
        '
        Me.DateTimePickerTanggalPenjualan.Location = New System.Drawing.Point(12, 236)
        Me.DateTimePickerTanggalPenjualan.Name = "DateTimePickerTanggalPenjualan"
        Me.DateTimePickerTanggalPenjualan.Size = New System.Drawing.Size(250, 27)
        Me.DateTimePickerTanggalPenjualan.TabIndex = 11
        '
        'TextBoxHargaTerjual
        '
        Me.TextBoxHargaTerjual.Location = New System.Drawing.Point(12, 183)
        Me.TextBoxHargaTerjual.Name = "TextBoxHargaTerjual"
        Me.TextBoxHargaTerjual.Size = New System.Drawing.Size(125, 27)
        Me.TextBoxHargaTerjual.TabIndex = 10
        '
        'ComboBoxIdPembeli
        '
        Me.ComboBoxIdPembeli.FormattingEnabled = True
        Me.ComboBoxIdPembeli.Location = New System.Drawing.Point(12, 129)
        Me.ComboBoxIdPembeli.Name = "ComboBoxIdPembeli"
        Me.ComboBoxIdPembeli.Size = New System.Drawing.Size(151, 28)
        Me.ComboBoxIdPembeli.TabIndex = 9
        '
        'ComboBoxIdMobil
        '
        Me.ComboBoxIdMobil.FormattingEnabled = True
        Me.ComboBoxIdMobil.Location = New System.Drawing.Point(12, 75)
        Me.ComboBoxIdMobil.Name = "ComboBoxIdMobil"
        Me.ComboBoxIdMobil.Size = New System.Drawing.Size(151, 28)
        Me.ComboBoxIdMobil.TabIndex = 8
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(112, 269)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(94, 29)
        Me.ButtonCancel.TabIndex = 17
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Location = New System.Drawing.Point(12, 269)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(94, 29)
        Me.ButtonEdit.TabIndex = 16
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'PictureBoxBack
        '
        Me.PictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxBack.Location = New System.Drawing.Point(12, 12)
        Me.PictureBoxBack.Name = "PictureBoxBack"
        Me.PictureBoxBack.Size = New System.Drawing.Size(75, 37)
        Me.PictureBoxBack.TabIndex = 18
        Me.PictureBoxBack.TabStop = False
        '
        'FormBukuPenjualanEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
        Me.Name = "FormBukuPenjualanEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Buku Penjualan"
        CType(Me.PictureBoxBack, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
