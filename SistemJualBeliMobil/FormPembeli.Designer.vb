<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPembeli
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
        Me.DataGridViewPembeli = New System.Windows.Forms.DataGridView()
        Me.BtnIndex = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SignoutBtn = New System.Windows.Forms.Button()
        Me.TransactionBtn = New System.Windows.Forms.Button()
        Me.ManageUserBtn = New System.Windows.Forms.Button()
        Me.manageCarBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.LblSearch = New System.Windows.Forms.Label()
        CType(Me.DataGridViewPembeli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewPembeli
        '
        Me.DataGridViewPembeli.AllowUserToAddRows = False
        Me.DataGridViewPembeli.AllowUserToDeleteRows = False
        Me.DataGridViewPembeli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewPembeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPembeli.Location = New System.Drawing.Point(13, 78)
        Me.DataGridViewPembeli.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridViewPembeli.Name = "DataGridViewPembeli"
        Me.DataGridViewPembeli.ReadOnly = True
        Me.DataGridViewPembeli.RowHeadersWidth = 51
        Me.DataGridViewPembeli.RowTemplate.Height = 29
        Me.DataGridViewPembeli.Size = New System.Drawing.Size(454, 284)
        Me.DataGridViewPembeli.TabIndex = 0
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
        Me.BtnIndex.Location = New System.Drawing.Point(13, 10)
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
        Me.Label5.Location = New System.Drawing.Point(127, 1)
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
        Me.SignoutBtn.Location = New System.Drawing.Point(863, 14)
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
        Me.TransactionBtn.Location = New System.Drawing.Point(733, 10)
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
        Me.ManageUserBtn.Location = New System.Drawing.Point(604, 10)
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
        Me.manageCarBtn.Location = New System.Drawing.Point(486, 10)
        Me.manageCarBtn.Name = "manageCarBtn"
        Me.manageCarBtn.Size = New System.Drawing.Size(124, 40)
        Me.manageCarBtn.TabIndex = 28
        Me.manageCarBtn.Text = "Manage Car"
        Me.manageCarBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SistemJualBeliMobil.My.Resources.Resources.putih
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(986, 60)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'ButtonTambah
        '
        Me.ButtonTambah.BackgroundImage = Global.SistemJualBeliMobil.My.Resources.Resources.bgbutton
        Me.ButtonTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonTambah.FlatAppearance.BorderSize = 0
        Me.ButtonTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTambah.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonTambah.ForeColor = System.Drawing.Color.White
        Me.ButtonTambah.Location = New System.Drawing.Point(486, 380)
        Me.ButtonTambah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(130, 36)
        Me.ButtonTambah.TabIndex = 34
        Me.ButtonTambah.Text = "Tambah User"
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.SistemJualBeliMobil.My.Resources.Resources.mobil
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(486, 78)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(482, 284)
        Me.PictureBox2.TabIndex = 35
        Me.PictureBox2.TabStop = False
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
        Me.ButtonEdit.Location = New System.Drawing.Point(846, 380)
        Me.ButtonEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(122, 36)
        Me.ButtonEdit.TabIndex = 37
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
        Me.ButtonHapus.Location = New System.Drawing.Point(846, 420)
        Me.ButtonHapus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(122, 36)
        Me.ButtonHapus.TabIndex = 36
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = False
        '
        'TxtSearch
        '
        Me.TxtSearch.Location = New System.Drawing.Point(13, 380)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(331, 23)
        Me.TxtSearch.TabIndex = 38
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(359, 380)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(108, 23)
        Me.BtnSearch.TabIndex = 39
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'LblSearch
        '
        Me.LblSearch.AutoSize = True
        Me.LblSearch.Location = New System.Drawing.Point(16, 384)
        Me.LblSearch.Name = "LblSearch"
        Me.LblSearch.Size = New System.Drawing.Size(81, 15)
        Me.LblSearch.TabIndex = 46
        Me.LblSearch.Text = "Search by ID..."
        '
        'FormPembeli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 623)
        Me.Controls.Add(Me.LblSearch)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ButtonTambah)
        Me.Controls.Add(Me.BtnIndex)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SignoutBtn)
        Me.Controls.Add(Me.TransactionBtn)
        Me.Controls.Add(Me.ManageUserBtn)
        Me.Controls.Add(Me.manageCarBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridViewPembeli)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimizeBox = False
        Me.Name = "FormPembeli"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pembeli"
        CType(Me.DataGridViewPembeli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewPembeli As DataGridView
    Friend WithEvents BtnIndex As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents SignoutBtn As Button
    Friend WithEvents TransactionBtn As Button
    Friend WithEvents ManageUserBtn As Button
    Friend WithEvents manageCarBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonTambah As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents ButtonHapus As Button
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents BtnSearch As Button
    Friend WithEvents LblSearch As Label
End Class
