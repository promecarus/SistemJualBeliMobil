<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJenisMobilHapus
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
        Me.BtnYes = New System.Windows.Forms.Button()
        Me.LblJenisMobil = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnNo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnYes
        '
        Me.BtnYes.BackgroundImage = Global.SistemJualBeliMobil.My.Resources.Resources.bgbutton
        Me.BtnYes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnYes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnYes.FlatAppearance.BorderSize = 0
        Me.BtnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnYes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnYes.ForeColor = System.Drawing.Color.White
        Me.BtnYes.Location = New System.Drawing.Point(83, 144)
        Me.BtnYes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnYes.Name = "BtnYes"
        Me.BtnYes.Size = New System.Drawing.Size(82, 29)
        Me.BtnYes.TabIndex = 5
        Me.BtnYes.Text = "Yes"
        Me.BtnYes.UseVisualStyleBackColor = True
        '
        'LblJenisMobil
        '
        Me.LblJenisMobil.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblJenisMobil.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblJenisMobil.ForeColor = System.Drawing.Color.Red
        Me.LblJenisMobil.Location = New System.Drawing.Point(55, 73)
        Me.LblJenisMobil.Name = "LblJenisMobil"
        Me.LblJenisMobil.Size = New System.Drawing.Size(234, 40)
        Me.LblJenisMobil.TabIndex = 4
        Me.LblJenisMobil.Text = "Jenis Mobil"
        Me.LblJenisMobil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(25, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Apakah Ingin Menghapus Jenis Mobil"
        '
        'BtnNo
        '
        Me.BtnNo.BackgroundImage = Global.SistemJualBeliMobil.My.Resources.Resources.bgputihbtn
        Me.BtnNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNo.FlatAppearance.BorderSize = 0
        Me.BtnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnNo.Location = New System.Drawing.Point(171, 142)
        Me.BtnNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnNo.Name = "BtnNo"
        Me.BtnNo.Size = New System.Drawing.Size(82, 31)
        Me.BtnNo.TabIndex = 8
        Me.BtnNo.Text = "No"
        Me.BtnNo.UseVisualStyleBackColor = True
        '
        'FormJenisMobilHapus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(336, 201)
        Me.Controls.Add(Me.BtnNo)
        Me.Controls.Add(Me.LblJenisMobil)
        Me.Controls.Add(Me.BtnYes)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "FormJenisMobilHapus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hapus Jenis Mobil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnYes As Button
    Friend WithEvents LblJenisMobil As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnNo As Button
End Class
