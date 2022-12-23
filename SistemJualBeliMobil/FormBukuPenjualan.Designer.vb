<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBukuPenjualan
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
        Me.DataGridViewBukuPenjualan = New System.Windows.Forms.DataGridView()
        Me.BtnIndex = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SignoutBtn = New System.Windows.Forms.Button()
        Me.TransactionBtn = New System.Windows.Forms.Button()
        Me.ManageUserBtn = New System.Windows.Forms.Button()
        Me.manageCarBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewBukuPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewBukuPenjualan
        '
        Me.DataGridViewBukuPenjualan.AllowUserToAddRows = False
        Me.DataGridViewBukuPenjualan.AllowUserToDeleteRows = False
        Me.DataGridViewBukuPenjualan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewBukuPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBukuPenjualan.Location = New System.Drawing.Point(41, 87)
        Me.DataGridViewBukuPenjualan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridViewBukuPenjualan.Name = "DataGridViewBukuPenjualan"
        Me.DataGridViewBukuPenjualan.ReadOnly = True
        Me.DataGridViewBukuPenjualan.RowHeadersWidth = 51
        Me.DataGridViewBukuPenjualan.RowTemplate.Height = 29
        Me.DataGridViewBukuPenjualan.Size = New System.Drawing.Size(571, 258)
        Me.DataGridViewBukuPenjualan.TabIndex = 4
        '
        'BtnIndex
        '
        Me.BtnIndex.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnIndex.BackColor = System.Drawing.Color.White
        Me.BtnIndex.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIndex.FlatAppearance.BorderSize = 0
        Me.BtnIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIndex.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnIndex.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnIndex.Location = New System.Drawing.Point(15, 11)
        Me.BtnIndex.Name = "BtnIndex"
        Me.BtnIndex.Size = New System.Drawing.Size(117, 40)
        Me.BtnIndex.TabIndex = 33
        Me.BtnIndex.Text = "JualMobil"
        Me.BtnIndex.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(129, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 46)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "."
        '
        'SignoutBtn
        '
        Me.SignoutBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SignoutBtn.BackColor = System.Drawing.Color.Transparent
        Me.SignoutBtn.BackgroundImage = Global.SistemJualBeliMobil.My.Resources.Resources.bgbutton
        Me.SignoutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SignoutBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SignoutBtn.FlatAppearance.BorderSize = 0
        Me.SignoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SignoutBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SignoutBtn.ForeColor = System.Drawing.Color.White
        Me.SignoutBtn.Location = New System.Drawing.Point(865, 15)
        Me.SignoutBtn.Name = "SignoutBtn"
        Me.SignoutBtn.Size = New System.Drawing.Size(105, 33)
        Me.SignoutBtn.TabIndex = 31
        Me.SignoutBtn.Text = "Sign out"
        Me.SignoutBtn.UseVisualStyleBackColor = False
        '
        'TransactionBtn
        '
        Me.TransactionBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TransactionBtn.BackColor = System.Drawing.Color.White
        Me.TransactionBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TransactionBtn.FlatAppearance.BorderSize = 0
        Me.TransactionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TransactionBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TransactionBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TransactionBtn.Location = New System.Drawing.Point(735, 11)
        Me.TransactionBtn.Name = "TransactionBtn"
        Me.TransactionBtn.Size = New System.Drawing.Size(124, 40)
        Me.TransactionBtn.TabIndex = 30
        Me.TransactionBtn.Text = "Transaction"
        Me.TransactionBtn.UseVisualStyleBackColor = False
        '
        'ManageUserBtn
        '
        Me.ManageUserBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ManageUserBtn.BackColor = System.Drawing.Color.White
        Me.ManageUserBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ManageUserBtn.FlatAppearance.BorderSize = 0
        Me.ManageUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ManageUserBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ManageUserBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ManageUserBtn.Location = New System.Drawing.Point(606, 11)
        Me.ManageUserBtn.Name = "ManageUserBtn"
        Me.ManageUserBtn.Size = New System.Drawing.Size(136, 40)
        Me.ManageUserBtn.TabIndex = 29
        Me.ManageUserBtn.Text = "Manage User"
        Me.ManageUserBtn.UseVisualStyleBackColor = False
        '
        'manageCarBtn
        '
        Me.manageCarBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.manageCarBtn.BackColor = System.Drawing.Color.White
        Me.manageCarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.manageCarBtn.FlatAppearance.BorderSize = 0
        Me.manageCarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.manageCarBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.manageCarBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.manageCarBtn.Location = New System.Drawing.Point(488, 11)
        Me.manageCarBtn.Name = "manageCarBtn"
        Me.manageCarBtn.Size = New System.Drawing.Size(124, 40)
        Me.manageCarBtn.TabIndex = 28
        Me.manageCarBtn.Text = "Manage Car"
        Me.manageCarBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SistemJualBeliMobil.My.Resources.Resources.putih
        Me.PictureBox1.Location = New System.Drawing.Point(1, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(986, 60)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'ButtonEdit
        '
        Me.ButtonEdit.BackColor = System.Drawing.Color.Transparent
        Me.ButtonEdit.BackgroundImage = Global.SistemJualBeliMobil.My.Resources.Resources.bgbutton
        Me.ButtonEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEdit.FlatAppearance.BorderSize = 0
        Me.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEdit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonEdit.ForeColor = System.Drawing.Color.White
        Me.ButtonEdit.Location = New System.Drawing.Point(623, 87)
        Me.ButtonEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(122, 36)
        Me.ButtonEdit.TabIndex = 39
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = False
        '
        'ButtonHapus
        '
        Me.ButtonHapus.BackColor = System.Drawing.Color.Transparent
        Me.ButtonHapus.BackgroundImage = Global.SistemJualBeliMobil.My.Resources.Resources.bgputihbtn1
        Me.ButtonHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonHapus.FlatAppearance.BorderSize = 0
        Me.ButtonHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonHapus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonHapus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(122, 36)
        Me.ButtonHapus.TabIndex = 38
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = False
        '
        'ButtonTambah
        '
        Me.ButtonTambah.BackColor = System.Drawing.Color.Transparent
        Me.ButtonTambah.BackgroundImage = Global.SistemJualBeliMobil.My.Resources.Resources.bgbutton
        Me.ButtonTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonTambah.FlatAppearance.BorderSize = 0
        Me.ButtonTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTambah.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonTambah.ForeColor = System.Drawing.Color.White
        Me.ButtonTambah.Location = New System.Drawing.Point(41, 358)
        Me.ButtonTambah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(160, 36)
        Me.ButtonTambah.TabIndex = 40
        Me.ButtonTambah.Text = "Tambah Penjualan"
        Me.ButtonTambah.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.SistemJualBeliMobil.My.Resources.Resources.mobil1
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(416, 237)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(590, 496)
        Me.PictureBox2.TabIndex = 41
        Me.PictureBox2.TabStop = False
        '
        'TxtSearch
        '
        Me.TxtSearch.Location = New System.Drawing.Point(41, 490)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(160, 23)
        Me.TxtSearch.TabIndex = 42
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(207, 490)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(75, 23)
        Me.BtnSearch.TabIndex = 43
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 494)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 15)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Search by ID..."
        '
        'FormBukuPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 623)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.ButtonTambah)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.BtnIndex)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SignoutBtn)
        Me.Controls.Add(Me.TransactionBtn)
        Me.Controls.Add(Me.ManageUserBtn)
        Me.Controls.Add(Me.manageCarBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridViewBukuPenjualan)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "FormBukuPenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buku Penjualan"
        CType(Me.DataGridViewBukuPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewBukuPenjualan As DataGridView
    Friend WithEvents BtnIndex As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents SignoutBtn As Button
    Friend WithEvents TransactionBtn As Button
    Friend WithEvents ManageUserBtn As Button
    Friend WithEvents manageCarBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents ButtonHapus As Button
    Friend WithEvents ButtonTambah As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents BtnSearch As Button
    Friend WithEvents Label1 As Label
End Class
