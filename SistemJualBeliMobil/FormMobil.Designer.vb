<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMobil
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
        Me.DataGridMobil = New System.Windows.Forms.DataGridView()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnJenisMobil = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnIndex = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SignoutBtn = New System.Windows.Forms.Button()
        Me.TransactionBtn = New System.Windows.Forms.Button()
        Me.ManageUserBtn = New System.Windows.Forms.Button()
        Me.manageCarBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RdbBelumTerjual = New System.Windows.Forms.RadioButton()
        Me.RdbTerjual = New System.Windows.Forms.RadioButton()
        Me.RdbNone = New System.Windows.Forms.RadioButton()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.LblSearch = New System.Windows.Forms.Label()
        CType(Me.DataGridMobil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridMobil
        '
        Me.DataGridMobil.AllowUserToAddRows = False
        Me.DataGridMobil.AllowUserToDeleteRows = False
        Me.DataGridMobil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridMobil.Location = New System.Drawing.Point(17, 110)
        Me.DataGridMobil.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridMobil.Name = "DataGridMobil"
        Me.DataGridMobil.ReadOnly = True
        Me.DataGridMobil.RowHeadersWidth = 51
        Me.DataGridMobil.RowTemplate.Height = 29
        Me.DataGridMobil.Size = New System.Drawing.Size(955, 273)
        Me.DataGridMobil.TabIndex = 15
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.Transparent
        Me.BtnEdit.BackgroundImage = Global.SistemJualBeliMobil.My.Resources.Resources.bgbutton
        Me.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEdit.FlatAppearance.BorderSize = 0
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnEdit.ForeColor = System.Drawing.Color.White
        Me.BtnEdit.Location = New System.Drawing.Point(850, 515)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(122, 36)
        Me.BtnEdit.TabIndex = 14
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.Color.Transparent
        Me.BtnHapus.BackgroundImage = Global.SistemJualBeliMobil.My.Resources.Resources.bgputihbtn1
        Me.BtnHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHapus.FlatAppearance.BorderSize = 0
        Me.BtnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHapus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnHapus.Location = New System.Drawing.Point(850, 564)
        Me.BtnHapus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(122, 36)
        Me.BtnHapus.TabIndex = 13
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = False
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
        Me.BtnTambah.Location = New System.Drawing.Point(17, 564)
        Me.BtnTambah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(130, 36)
        Me.BtnTambah.TabIndex = 12
        Me.BtnTambah.Text = "Tambah Mobil"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'BtnJenisMobil
        '
        Me.BtnJenisMobil.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnJenisMobil.BackColor = System.Drawing.Color.Transparent
        Me.BtnJenisMobil.BackgroundImage = Global.SistemJualBeliMobil.My.Resources.Resources.bgputihbtn1
        Me.BtnJenisMobil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnJenisMobil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnJenisMobil.FlatAppearance.BorderSize = 0
        Me.BtnJenisMobil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnJenisMobil.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnJenisMobil.ForeColor = System.Drawing.Color.Black
        Me.BtnJenisMobil.Location = New System.Drawing.Point(266, 564)
        Me.BtnJenisMobil.Name = "BtnJenisMobil"
        Me.BtnJenisMobil.Size = New System.Drawing.Size(130, 36)
        Me.BtnJenisMobil.TabIndex = 23
        Me.BtnJenisMobil.Text = "Jenis Mobil"
        Me.BtnJenisMobil.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.SistemJualBeliMobil.My.Resources.Resources._3
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(413, 128)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(817, 674)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
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
        Me.BtnIndex.Location = New System.Drawing.Point(14, 9)
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
        Me.Label5.Location = New System.Drawing.Point(128, 0)
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
        Me.SignoutBtn.Location = New System.Drawing.Point(864, 13)
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
        Me.TransactionBtn.Location = New System.Drawing.Point(734, 9)
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
        Me.ManageUserBtn.Location = New System.Drawing.Point(605, 9)
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
        Me.manageCarBtn.Location = New System.Drawing.Point(487, 9)
        Me.manageCarBtn.Name = "manageCarBtn"
        Me.manageCarBtn.Size = New System.Drawing.Size(124, 40)
        Me.manageCarBtn.TabIndex = 28
        Me.manageCarBtn.Text = "Manage Car"
        Me.manageCarBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SistemJualBeliMobil.My.Resources.Resources.putih
        Me.PictureBox1.Location = New System.Drawing.Point(0, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(986, 60)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdbBelumTerjual)
        Me.GroupBox1.Controls.Add(Me.RdbTerjual)
        Me.GroupBox1.Controls.Add(Me.RdbNone)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 399)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(130, 107)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter Status Terjual"
        '
        'RdbBelumTerjual
        '
        Me.RdbBelumTerjual.AutoSize = True
        Me.RdbBelumTerjual.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RdbBelumTerjual.Location = New System.Drawing.Point(15, 72)
        Me.RdbBelumTerjual.Name = "RdbBelumTerjual"
        Me.RdbBelumTerjual.Size = New System.Drawing.Size(101, 19)
        Me.RdbBelumTerjual.TabIndex = 2
        Me.RdbBelumTerjual.TabStop = True
        Me.RdbBelumTerjual.Text = "Belum Terjual"
        Me.RdbBelumTerjual.UseVisualStyleBackColor = True
        '
        'RdbTerjual
        '
        Me.RdbTerjual.AutoSize = True
        Me.RdbTerjual.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RdbTerjual.Location = New System.Drawing.Point(15, 47)
        Me.RdbTerjual.Name = "RdbTerjual"
        Me.RdbTerjual.Size = New System.Drawing.Size(62, 19)
        Me.RdbTerjual.TabIndex = 1
        Me.RdbTerjual.TabStop = True
        Me.RdbTerjual.Text = "Terjual"
        Me.RdbTerjual.UseVisualStyleBackColor = True
        '
        'RdbNone
        '
        Me.RdbNone.AutoSize = True
        Me.RdbNone.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RdbNone.Location = New System.Drawing.Point(15, 22)
        Me.RdbNone.Name = "RdbNone"
        Me.RdbNone.Size = New System.Drawing.Size(55, 19)
        Me.RdbNone.TabIndex = 0
        Me.RdbNone.TabStop = True
        Me.RdbNone.Text = "None"
        Me.RdbNone.UseVisualStyleBackColor = True
        '
        'TxtSearch
        '
        Me.TxtSearch.BackColor = System.Drawing.SystemColors.Window
        Me.TxtSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TxtSearch.Location = New System.Drawing.Point(17, 72)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(200, 25)
        Me.TxtSearch.TabIndex = 35
        '
        'BtnSearch
        '
        Me.BtnSearch.BackgroundImage = Global.SistemJualBeliMobil.My.Resources.Resources.bgbutton
        Me.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSearch.FlatAppearance.BorderSize = 0
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnSearch.ForeColor = System.Drawing.Color.White
        Me.BtnSearch.Location = New System.Drawing.Point(223, 72)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(75, 25)
        Me.BtnSearch.TabIndex = 36
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'LblSearch
        '
        Me.LblSearch.AutoSize = True
        Me.LblSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblSearch.Location = New System.Drawing.Point(20, 76)
        Me.LblSearch.Name = "LblSearch"
        Me.LblSearch.Size = New System.Drawing.Size(95, 19)
        Me.LblSearch.TabIndex = 37
        Me.LblSearch.Text = "Search by ID..."
        '
        'FormMobil
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 623)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnIndex)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SignoutBtn)
        Me.Controls.Add(Me.TransactionBtn)
        Me.Controls.Add(Me.ManageUserBtn)
        Me.Controls.Add(Me.manageCarBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnJenisMobil)
        Me.Controls.Add(Me.DataGridMobil)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LblSearch)
        Me.Controls.Add(Me.TxtSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "FormMobil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mobil"
        CType(Me.DataGridMobil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridMobil As DataGridView
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnJenisMobil As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnIndex As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents SignoutBtn As Button
    Friend WithEvents TransactionBtn As Button
    Friend WithEvents ManageUserBtn As Button
    Friend WithEvents manageCarBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RdbNone As RadioButton
    Friend WithEvents RdbBelumTerjual As RadioButton
    Friend WithEvents RdbTerjual As RadioButton
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents BtnSearch As Button
    Friend WithEvents LblSearch As Label
End Class
