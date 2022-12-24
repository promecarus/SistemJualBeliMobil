<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMobilTambah
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
        Me.GroupBoxTipeMobil = New System.Windows.Forms.GroupBox()
        Me.RdMatic = New System.Windows.Forms.RadioButton()
        Me.RdManual = New System.Windows.Forms.RadioButton()
        Me.TxtHargaDefault = New System.Windows.Forms.TextBox()
        Me.TxtTahunPembuatan = New System.Windows.Forms.TextBox()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.LabelTipeMobil = New System.Windows.Forms.Label()
        Me.LabelStock = New System.Windows.Forms.Label()
        Me.LabelTahunTerbit = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RdSangatBuruk = New System.Windows.Forms.RadioButton()
        Me.RdBuruk = New System.Windows.Forms.RadioButton()
        Me.RdSedang = New System.Windows.Forms.RadioButton()
        Me.RdBaik = New System.Windows.Forms.RadioButton()
        Me.RdSangatBaik = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxJenisMobil = New System.Windows.Forms.ComboBox()
        Me.LabelJenisKoleksi = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelTanggalMasukKoleksi = New System.Windows.Forms.Label()
        Me.TxtGaransi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.GroupBoxTipeMobil.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxTipeMobil
        '
        Me.GroupBoxTipeMobil.Controls.Add(Me.RdMatic)
        Me.GroupBoxTipeMobil.Controls.Add(Me.RdManual)
        Me.GroupBoxTipeMobil.Location = New System.Drawing.Point(325, 99)
        Me.GroupBoxTipeMobil.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBoxTipeMobil.Name = "GroupBoxTipeMobil"
        Me.GroupBoxTipeMobil.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBoxTipeMobil.Size = New System.Drawing.Size(256, 75)
        Me.GroupBoxTipeMobil.TabIndex = 69
        Me.GroupBoxTipeMobil.TabStop = False
        Me.GroupBoxTipeMobil.Text = "Tipe Mobil"
        '
        'RdMatic
        '
        Me.RdMatic.AutoSize = True
        Me.RdMatic.Location = New System.Drawing.Point(14, 45)
        Me.RdMatic.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RdMatic.Name = "RdMatic"
        Me.RdMatic.Size = New System.Drawing.Size(55, 19)
        Me.RdMatic.TabIndex = 24
        Me.RdMatic.TabStop = True
        Me.RdMatic.Text = "Matic"
        Me.RdMatic.UseVisualStyleBackColor = True
        '
        'RdManual
        '
        Me.RdManual.AutoSize = True
        Me.RdManual.Location = New System.Drawing.Point(14, 20)
        Me.RdManual.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RdManual.Name = "RdManual"
        Me.RdManual.Size = New System.Drawing.Size(65, 19)
        Me.RdManual.TabIndex = 23
        Me.RdManual.TabStop = True
        Me.RdManual.Text = "Manual"
        Me.RdManual.UseVisualStyleBackColor = True
        '
        'TxtHargaDefault
        '
        Me.TxtHargaDefault.Location = New System.Drawing.Point(325, 394)
        Me.TxtHargaDefault.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtHargaDefault.Name = "TxtHargaDefault"
        Me.TxtHargaDefault.Size = New System.Drawing.Size(257, 23)
        Me.TxtHargaDefault.TabIndex = 68
        '
        'TxtTahunPembuatan
        '
        Me.TxtTahunPembuatan.Location = New System.Drawing.Point(325, 182)
        Me.TxtTahunPembuatan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtTahunPembuatan.Name = "TxtTahunPembuatan"
        Me.TxtTahunPembuatan.Size = New System.Drawing.Size(257, 23)
        Me.TxtTahunPembuatan.TabIndex = 65
        '
        'BtnTambah
        '
        Me.BtnTambah.BackgroundImage = Global.SistemJualBeliMobil.My.Resources.Resources.bgbutton
        Me.BtnTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTambah.FlatAppearance.BorderSize = 0
        Me.BtnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambah.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnTambah.ForeColor = System.Drawing.Color.White
        Me.BtnTambah.Location = New System.Drawing.Point(207, 438)
        Me.BtnTambah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(139, 40)
        Me.BtnTambah.TabIndex = 60
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'LabelTipeMobil
        '
        Me.LabelTipeMobil.AutoSize = True
        Me.LabelTipeMobil.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelTipeMobil.Location = New System.Drawing.Point(117, 102)
        Me.LabelTipeMobil.Name = "LabelTipeMobil"
        Me.LabelTipeMobil.Size = New System.Drawing.Size(65, 15)
        Me.LabelTipeMobil.TabIndex = 58
        Me.LabelTipeMobil.Text = "Tipe Mobil"
        '
        'LabelStock
        '
        Me.LabelStock.AutoSize = True
        Me.LabelStock.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelStock.Location = New System.Drawing.Point(117, 397)
        Me.LabelStock.Name = "LabelStock"
        Me.LabelStock.Size = New System.Drawing.Size(85, 15)
        Me.LabelStock.TabIndex = 57
        Me.LabelStock.Text = "Harga Default"
        '
        'LabelTahunTerbit
        '
        Me.LabelTahunTerbit.AutoSize = True
        Me.LabelTahunTerbit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelTahunTerbit.Location = New System.Drawing.Point(117, 184)
        Me.LabelTahunTerbit.Name = "LabelTahunTerbit"
        Me.LabelTahunTerbit.Size = New System.Drawing.Size(106, 15)
        Me.LabelTahunTerbit.TabIndex = 54
        Me.LabelTahunTerbit.Text = "Tahun Pembuatan"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdSangatBuruk)
        Me.GroupBox1.Controls.Add(Me.RdBuruk)
        Me.GroupBox1.Controls.Add(Me.RdSedang)
        Me.GroupBox1.Controls.Add(Me.RdBaik)
        Me.GroupBox1.Controls.Add(Me.RdSangatBaik)
        Me.GroupBox1.Location = New System.Drawing.Point(325, 245)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(256, 140)
        Me.GroupBox1.TabIndex = 71
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kondisi"
        '
        'RdSangatBuruk
        '
        Me.RdSangatBuruk.AutoSize = True
        Me.RdSangatBuruk.Location = New System.Drawing.Point(14, 112)
        Me.RdSangatBuruk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RdSangatBuruk.Name = "RdSangatBuruk"
        Me.RdSangatBuruk.Size = New System.Drawing.Size(95, 19)
        Me.RdSangatBuruk.TabIndex = 27
        Me.RdSangatBuruk.TabStop = True
        Me.RdSangatBuruk.Text = "Sangat Buruk"
        Me.RdSangatBuruk.UseVisualStyleBackColor = True
        '
        'RdBuruk
        '
        Me.RdBuruk.AutoSize = True
        Me.RdBuruk.Location = New System.Drawing.Point(14, 90)
        Me.RdBuruk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RdBuruk.Name = "RdBuruk"
        Me.RdBuruk.Size = New System.Drawing.Size(56, 19)
        Me.RdBuruk.TabIndex = 26
        Me.RdBuruk.TabStop = True
        Me.RdBuruk.Text = "Buruk"
        Me.RdBuruk.UseVisualStyleBackColor = True
        '
        'RdSedang
        '
        Me.RdSedang.AutoSize = True
        Me.RdSedang.Location = New System.Drawing.Point(14, 68)
        Me.RdSedang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RdSedang.Name = "RdSedang"
        Me.RdSedang.Size = New System.Drawing.Size(64, 19)
        Me.RdSedang.TabIndex = 25
        Me.RdSedang.TabStop = True
        Me.RdSedang.Text = "Sedang"
        Me.RdSedang.UseVisualStyleBackColor = True
        '
        'RdBaik
        '
        Me.RdBaik.AutoSize = True
        Me.RdBaik.Location = New System.Drawing.Point(14, 44)
        Me.RdBaik.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RdBaik.Name = "RdBaik"
        Me.RdBaik.Size = New System.Drawing.Size(47, 19)
        Me.RdBaik.TabIndex = 24
        Me.RdBaik.TabStop = True
        Me.RdBaik.Text = "Baik"
        Me.RdBaik.UseVisualStyleBackColor = True
        '
        'RdSangatBaik
        '
        Me.RdSangatBaik.AutoSize = True
        Me.RdSangatBaik.Location = New System.Drawing.Point(14, 20)
        Me.RdSangatBaik.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RdSangatBaik.Name = "RdSangatBaik"
        Me.RdSangatBaik.Size = New System.Drawing.Size(86, 19)
        Me.RdSangatBaik.TabIndex = 23
        Me.RdSangatBaik.TabStop = True
        Me.RdSangatBaik.Text = "Sangat Baik"
        Me.RdSangatBaik.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(117, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Kondisi"
        '
        'ComboBoxJenisMobil
        '
        Me.ComboBoxJenisMobil.FormattingEnabled = True
        Me.ComboBoxJenisMobil.Location = New System.Drawing.Point(325, 70)
        Me.ComboBoxJenisMobil.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxJenisMobil.Name = "ComboBoxJenisMobil"
        Me.ComboBoxJenisMobil.Size = New System.Drawing.Size(257, 23)
        Me.ComboBoxJenisMobil.TabIndex = 73
        '
        'LabelJenisKoleksi
        '
        Me.LabelJenisKoleksi.AutoSize = True
        Me.LabelJenisKoleksi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelJenisKoleksi.Location = New System.Drawing.Point(117, 73)
        Me.LabelJenisKoleksi.Name = "LabelJenisKoleksi"
        Me.LabelJenisKoleksi.Size = New System.Drawing.Size(68, 15)
        Me.LabelJenisKoleksi.TabIndex = 72
        Me.LabelJenisKoleksi.Text = "Jenis Mobil"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(260, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 30)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "TAMBAH MOBIL"
        '
        'LabelTanggalMasukKoleksi
        '
        Me.LabelTanggalMasukKoleksi.AutoSize = True
        Me.LabelTanggalMasukKoleksi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelTanggalMasukKoleksi.Location = New System.Drawing.Point(117, 217)
        Me.LabelTanggalMasukKoleksi.Name = "LabelTanggalMasukKoleksi"
        Me.LabelTanggalMasukKoleksi.Size = New System.Drawing.Size(48, 15)
        Me.LabelTanggalMasukKoleksi.TabIndex = 75
        Me.LabelTanggalMasukKoleksi.Text = "Garansi"
        '
        'TxtGaransi
        '
        Me.TxtGaransi.Location = New System.Drawing.Point(325, 217)
        Me.TxtGaransi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtGaransi.Name = "TxtGaransi"
        Me.TxtGaransi.Size = New System.Drawing.Size(219, 23)
        Me.TxtGaransi.TabIndex = 76
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(549, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 15)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Hari"
        '
        'BtnCancel
        '
        Me.BtnCancel.BackgroundImage = Global.SistemJualBeliMobil.My.Resources.Resources.bgputihbtn
        Me.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.FlatAppearance.BorderSize = 0
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnCancel.Location = New System.Drawing.Point(354, 438)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(139, 40)
        Me.BtnCancel.TabIndex = 78
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'FormMobilTambah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(700, 498)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtGaransi)
        Me.Controls.Add(Me.LabelTanggalMasukKoleksi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBoxJenisMobil)
        Me.Controls.Add(Me.LabelJenisKoleksi)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBoxTipeMobil)
        Me.Controls.Add(Me.TxtHargaDefault)
        Me.Controls.Add(Me.TxtTahunPembuatan)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.LabelTipeMobil)
        Me.Controls.Add(Me.LabelStock)
        Me.Controls.Add(Me.LabelTahunTerbit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "FormMobilTambah"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Mobil"
        Me.GroupBoxTipeMobil.ResumeLayout(False)
        Me.GroupBoxTipeMobil.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBoxTipeMobil As GroupBox
    Friend WithEvents RdMatic As RadioButton
    Friend WithEvents RdManual As RadioButton
    Friend WithEvents TxtHargaDefault As TextBox
    Friend WithEvents TxtTahunPembuatan As TextBox
    Friend WithEvents BtnTambah As Button
    Friend WithEvents LabelTipeMobil As Label
    Friend WithEvents LabelStock As Label
    Friend WithEvents LabelTahunTerbit As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RdSangatBuruk As RadioButton
    Friend WithEvents RdBuruk As RadioButton
    Friend WithEvents RdSedang As RadioButton
    Friend WithEvents RdBaik As RadioButton
    Friend WithEvents RdSangatBaik As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxJenisMobil As ComboBox
    Friend WithEvents LabelJenisKoleksi As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelTanggalMasukKoleksi As Label
    Friend WithEvents TxtGaransi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnCancel As Button
End Class
