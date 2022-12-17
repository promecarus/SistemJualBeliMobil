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
        Me.BtnTambahMobil = New System.Windows.Forms.Button()
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
        Me.GroupBoxTipeMobil.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxTipeMobil
        '
        Me.GroupBoxTipeMobil.Controls.Add(Me.RdMatic)
        Me.GroupBoxTipeMobil.Controls.Add(Me.RdManual)
        Me.GroupBoxTipeMobil.Location = New System.Drawing.Point(371, 132)
        Me.GroupBoxTipeMobil.Name = "GroupBoxTipeMobil"
        Me.GroupBoxTipeMobil.Size = New System.Drawing.Size(293, 100)
        Me.GroupBoxTipeMobil.TabIndex = 69
        Me.GroupBoxTipeMobil.TabStop = False
        Me.GroupBoxTipeMobil.Text = "Tipe Mobil"
        '
        'RdMatic
        '
        Me.RdMatic.AutoSize = True
        Me.RdMatic.Location = New System.Drawing.Point(16, 60)
        Me.RdMatic.Name = "RdMatic"
        Me.RdMatic.Size = New System.Drawing.Size(67, 24)
        Me.RdMatic.TabIndex = 24
        Me.RdMatic.TabStop = True
        Me.RdMatic.Text = "Matic"
        Me.RdMatic.UseVisualStyleBackColor = True
        '
        'RdManual
        '
        Me.RdManual.AutoSize = True
        Me.RdManual.Location = New System.Drawing.Point(16, 27)
        Me.RdManual.Name = "RdManual"
        Me.RdManual.Size = New System.Drawing.Size(79, 24)
        Me.RdManual.TabIndex = 23
        Me.RdManual.TabStop = True
        Me.RdManual.Text = "Manual"
        Me.RdManual.UseVisualStyleBackColor = True
        '
        'TxtHargaDefault
        '
        Me.TxtHargaDefault.Location = New System.Drawing.Point(371, 526)
        Me.TxtHargaDefault.Name = "TxtHargaDefault"
        Me.TxtHargaDefault.Size = New System.Drawing.Size(293, 27)
        Me.TxtHargaDefault.TabIndex = 68
        '
        'TxtTahunPembuatan
        '
        Me.TxtTahunPembuatan.Location = New System.Drawing.Point(371, 243)
        Me.TxtTahunPembuatan.Name = "TxtTahunPembuatan"
        Me.TxtTahunPembuatan.Size = New System.Drawing.Size(293, 27)
        Me.TxtTahunPembuatan.TabIndex = 65
        '
        'BtnTambahMobil
        '
        Me.BtnTambahMobil.Location = New System.Drawing.Point(134, 596)
        Me.BtnTambahMobil.Name = "BtnTambahMobil"
        Me.BtnTambahMobil.Size = New System.Drawing.Size(530, 29)
        Me.BtnTambahMobil.TabIndex = 60
        Me.BtnTambahMobil.Text = "Tambah Mobil"
        Me.BtnTambahMobil.UseVisualStyleBackColor = True
        '
        'LabelTipeMobil
        '
        Me.LabelTipeMobil.AutoSize = True
        Me.LabelTipeMobil.Location = New System.Drawing.Point(134, 136)
        Me.LabelTipeMobil.Name = "LabelTipeMobil"
        Me.LabelTipeMobil.Size = New System.Drawing.Size(81, 20)
        Me.LabelTipeMobil.TabIndex = 58
        Me.LabelTipeMobil.Text = "Tipe Mobil"
        '
        'LabelStock
        '
        Me.LabelStock.AutoSize = True
        Me.LabelStock.Location = New System.Drawing.Point(134, 529)
        Me.LabelStock.Name = "LabelStock"
        Me.LabelStock.Size = New System.Drawing.Size(103, 20)
        Me.LabelStock.TabIndex = 57
        Me.LabelStock.Text = "Harga Default"
        '
        'LabelTahunTerbit
        '
        Me.LabelTahunTerbit.AutoSize = True
        Me.LabelTahunTerbit.Location = New System.Drawing.Point(134, 246)
        Me.LabelTahunTerbit.Name = "LabelTahunTerbit"
        Me.LabelTahunTerbit.Size = New System.Drawing.Size(125, 20)
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
        Me.GroupBox1.Location = New System.Drawing.Point(371, 327)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(293, 187)
        Me.GroupBox1.TabIndex = 71
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kondisi"
        '
        'RdSangatBuruk
        '
        Me.RdSangatBuruk.AutoSize = True
        Me.RdSangatBuruk.Location = New System.Drawing.Point(16, 150)
        Me.RdSangatBuruk.Name = "RdSangatBuruk"
        Me.RdSangatBuruk.Size = New System.Drawing.Size(117, 24)
        Me.RdSangatBuruk.TabIndex = 27
        Me.RdSangatBuruk.TabStop = True
        Me.RdSangatBuruk.Text = "Sangat Buruk"
        Me.RdSangatBuruk.UseVisualStyleBackColor = True
        '
        'RdBuruk
        '
        Me.RdBuruk.AutoSize = True
        Me.RdBuruk.Location = New System.Drawing.Point(16, 120)
        Me.RdBuruk.Name = "RdBuruk"
        Me.RdBuruk.Size = New System.Drawing.Size(67, 24)
        Me.RdBuruk.TabIndex = 26
        Me.RdBuruk.TabStop = True
        Me.RdBuruk.Text = "Buruk"
        Me.RdBuruk.UseVisualStyleBackColor = True
        '
        'RdSedang
        '
        Me.RdSedang.AutoSize = True
        Me.RdSedang.Location = New System.Drawing.Point(16, 90)
        Me.RdSedang.Name = "RdSedang"
        Me.RdSedang.Size = New System.Drawing.Size(80, 24)
        Me.RdSedang.TabIndex = 25
        Me.RdSedang.TabStop = True
        Me.RdSedang.Text = "Sedang"
        Me.RdSedang.UseVisualStyleBackColor = True
        '
        'RdBaik
        '
        Me.RdBaik.AutoSize = True
        Me.RdBaik.Location = New System.Drawing.Point(16, 58)
        Me.RdBaik.Name = "RdBaik"
        Me.RdBaik.Size = New System.Drawing.Size(58, 24)
        Me.RdBaik.TabIndex = 24
        Me.RdBaik.TabStop = True
        Me.RdBaik.Text = "Baik"
        Me.RdBaik.UseVisualStyleBackColor = True
        '
        'RdSangatBaik
        '
        Me.RdSangatBaik.AutoSize = True
        Me.RdSangatBaik.Location = New System.Drawing.Point(16, 27)
        Me.RdSangatBaik.Name = "RdSangatBaik"
        Me.RdSangatBaik.Size = New System.Drawing.Size(108, 24)
        Me.RdSangatBaik.TabIndex = 23
        Me.RdSangatBaik.TabStop = True
        Me.RdSangatBaik.Text = "Sangat Baik"
        Me.RdSangatBaik.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 331)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Kondisi"
        '
        'ComboBoxJenisMobil
        '
        Me.ComboBoxJenisMobil.FormattingEnabled = True
        Me.ComboBoxJenisMobil.Location = New System.Drawing.Point(371, 94)
        Me.ComboBoxJenisMobil.Name = "ComboBoxJenisMobil"
        Me.ComboBoxJenisMobil.Size = New System.Drawing.Size(293, 28)
        Me.ComboBoxJenisMobil.TabIndex = 73
        '
        'LabelJenisKoleksi
        '
        Me.LabelJenisKoleksi.AutoSize = True
        Me.LabelJenisKoleksi.Location = New System.Drawing.Point(134, 97)
        Me.LabelJenisKoleksi.Name = "LabelJenisKoleksi"
        Me.LabelJenisKoleksi.Size = New System.Drawing.Size(83, 20)
        Me.LabelJenisKoleksi.TabIndex = 72
        Me.LabelJenisKoleksi.Text = "Jenis Mobil"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(337, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 20)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "TAMBAH MOBIL"
        '
        'LabelTanggalMasukKoleksi
        '
        Me.LabelTanggalMasukKoleksi.AutoSize = True
        Me.LabelTanggalMasukKoleksi.Location = New System.Drawing.Point(134, 289)
        Me.LabelTanggalMasukKoleksi.Name = "LabelTanggalMasukKoleksi"
        Me.LabelTanggalMasukKoleksi.Size = New System.Drawing.Size(58, 20)
        Me.LabelTanggalMasukKoleksi.TabIndex = 75
        Me.LabelTanggalMasukKoleksi.Text = "Garansi"
        '
        'TxtGaransi
        '
        Me.TxtGaransi.Location = New System.Drawing.Point(371, 289)
        Me.TxtGaransi.Name = "TxtGaransi"
        Me.TxtGaransi.Size = New System.Drawing.Size(250, 27)
        Me.TxtGaransi.TabIndex = 76
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(627, 292)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 20)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Hari"
        '
        'FormMobilTambah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 664)
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
        Me.Controls.Add(Me.BtnTambahMobil)
        Me.Controls.Add(Me.LabelTipeMobil)
        Me.Controls.Add(Me.LabelStock)
        Me.Controls.Add(Me.LabelTahunTerbit)
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
    Friend WithEvents BtnTambahMobil As Button
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
End Class
