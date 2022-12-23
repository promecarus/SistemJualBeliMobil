<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDashboard
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.manageCarBtn = New System.Windows.Forms.Button()
        Me.ManageUserBtn = New System.Windows.Forms.Button()
        Me.TransactionBtn = New System.Windows.Forms.Button()
        Me.SignoutBtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnIndex = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.SistemJualBeliMobil.My.Resources.Resources.BannerHome1
        Me.PictureBox2.Location = New System.Drawing.Point(-16, -87)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1000, 739)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SistemJualBeliMobil.My.Resources.Resources.putih
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(986, 60)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(54, 366)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(533, 62)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = " Welcome to JualMobil"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(77, 428)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(249, 28)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cari mobil sesuai dengan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(77, 456)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(224, 28)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Kebutuhan anda disini"
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
        Me.manageCarBtn.Location = New System.Drawing.Point(485, 5)
        Me.manageCarBtn.Name = "manageCarBtn"
        Me.manageCarBtn.Size = New System.Drawing.Size(124, 40)
        Me.manageCarBtn.TabIndex = 7
        Me.manageCarBtn.Text = "Manage Car"
        Me.manageCarBtn.UseVisualStyleBackColor = False
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
        Me.ManageUserBtn.Location = New System.Drawing.Point(603, 5)
        Me.ManageUserBtn.Name = "ManageUserBtn"
        Me.ManageUserBtn.Size = New System.Drawing.Size(136, 40)
        Me.ManageUserBtn.TabIndex = 8
        Me.ManageUserBtn.Text = "Manage User"
        Me.ManageUserBtn.UseVisualStyleBackColor = False
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
        Me.TransactionBtn.Location = New System.Drawing.Point(732, 5)
        Me.TransactionBtn.Name = "TransactionBtn"
        Me.TransactionBtn.Size = New System.Drawing.Size(124, 40)
        Me.TransactionBtn.TabIndex = 9
        Me.TransactionBtn.Text = "Transaction"
        Me.TransactionBtn.UseVisualStyleBackColor = False
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
        Me.SignoutBtn.Location = New System.Drawing.Point(862, 9)
        Me.SignoutBtn.Name = "SignoutBtn"
        Me.SignoutBtn.Size = New System.Drawing.Size(105, 33)
        Me.SignoutBtn.TabIndex = 10
        Me.SignoutBtn.Text = "Sign out"
        Me.SignoutBtn.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(126, -4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 46)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "."
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
        Me.BtnIndex.Location = New System.Drawing.Point(12, 5)
        Me.BtnIndex.Name = "BtnIndex"
        Me.BtnIndex.Size = New System.Drawing.Size(117, 40)
        Me.BtnIndex.TabIndex = 26
        Me.BtnIndex.Text = "JualMobil"
        Me.BtnIndex.UseVisualStyleBackColor = False
        '
        'FormDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 631)
        Me.Controls.Add(Me.BtnIndex)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SignoutBtn)
        Me.Controls.Add(Me.TransactionBtn)
        Me.Controls.Add(Me.ManageUserBtn)
        Me.Controls.Add(Me.manageCarBtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "FormDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents manageCarBtn As Button
    Friend WithEvents ManageUserBtn As Button
    Friend WithEvents TransactionBtn As Button
    Friend WithEvents SignoutBtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnIndex As Button
End Class
