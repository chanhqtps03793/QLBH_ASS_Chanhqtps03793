<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChiTietHD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChiTietHD))
        Me.txtmahd = New System.Windows.Forms.TextBox()
        Me.txtsoluong = New System.Windows.Forms.TextBox()
        Me.txtmasp = New System.Windows.Forms.TextBox()
        Me.lbltenkh = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lblmakh = New System.Windows.Forms.Label()
        Me.dgvChiTietHD = New System.Windows.Forms.DataGridView()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtTimkiem = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvChiTietHD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtmahd
        '
        Me.txtmahd.Location = New System.Drawing.Point(337, 61)
        Me.txtmahd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmahd.Name = "txtmahd"
        Me.txtmahd.Size = New System.Drawing.Size(176, 20)
        Me.txtmahd.TabIndex = 19
        '
        'txtsoluong
        '
        Me.txtsoluong.Location = New System.Drawing.Point(337, 105)
        Me.txtsoluong.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsoluong.Name = "txtsoluong"
        Me.txtsoluong.Size = New System.Drawing.Size(176, 20)
        Me.txtsoluong.TabIndex = 18
        '
        'txtmasp
        '
        Me.txtmasp.Location = New System.Drawing.Point(337, 17)
        Me.txtmasp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmasp.Name = "txtmasp"
        Me.txtmasp.Size = New System.Drawing.Size(176, 20)
        Me.txtmasp.TabIndex = 15
        '
        'lbltenkh
        '
        Me.lbltenkh.AutoSize = True
        Me.lbltenkh.BackColor = System.Drawing.Color.Transparent
        Me.lbltenkh.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbltenkh.Location = New System.Drawing.Point(183, 61)
        Me.lbltenkh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltenkh.Name = "lbltenkh"
        Me.lbltenkh.Size = New System.Drawing.Size(62, 18)
        Me.lbltenkh.TabIndex = 14
        Me.lbltenkh.Text = "Mã HD:"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.BackColor = System.Drawing.Color.Transparent
        Me.lblemail.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblemail.Location = New System.Drawing.Point(183, 105)
        Me.lblemail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(82, 18)
        Me.lblemail.TabIndex = 11
        Me.lblemail.Text = "Số Lượng:"
        '
        'lblmakh
        '
        Me.lblmakh.AutoSize = True
        Me.lblmakh.BackColor = System.Drawing.Color.Transparent
        Me.lblmakh.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblmakh.Location = New System.Drawing.Point(183, 17)
        Me.lblmakh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblmakh.Name = "lblmakh"
        Me.lblmakh.Size = New System.Drawing.Size(56, 18)
        Me.lblmakh.TabIndex = 10
        Me.lblmakh.Text = "Mã SP:"
        '
        'dgvChiTietHD
        '
        Me.dgvChiTietHD.AllowUserToAddRows = False
        Me.dgvChiTietHD.AllowUserToDeleteRows = False
        Me.dgvChiTietHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChiTietHD.Location = New System.Drawing.Point(12, 194)
        Me.dgvChiTietHD.Name = "dgvChiTietHD"
        Me.dgvChiTietHD.Size = New System.Drawing.Size(765, 179)
        Me.dgvChiTietHD.TabIndex = 20
        '
        'btnsua
        '
        Me.btnsua.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnsua.Location = New System.Drawing.Point(615, 61)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(78, 38)
        Me.btnsua.TabIndex = 23
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = False
        '
        'btnxoa
        '
        Me.btnxoa.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnxoa.Location = New System.Drawing.Point(699, 61)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(78, 38)
        Me.btnxoa.TabIndex = 22
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = False
        '
        'btnthem
        '
        Me.btnthem.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnthem.Location = New System.Drawing.Point(531, 61)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(78, 38)
        Me.btnthem.TabIndex = 21
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 161)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'txtTimkiem
        '
        Me.txtTimkiem.Location = New System.Drawing.Point(337, 148)
        Me.txtTimkiem.Name = "txtTimkiem"
        Me.txtTimkiem.Size = New System.Drawing.Size(176, 20)
        Me.txtTimkiem.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.Location = New System.Drawing.Point(181, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 19)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Tìm Kiếm(Mã SP):"
        '
        'frmChiTietHD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(788, 385)
        Me.Controls.Add(Me.txtTimkiem)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.dgvChiTietHD)
        Me.Controls.Add(Me.txtmahd)
        Me.Controls.Add(Me.txtsoluong)
        Me.Controls.Add(Me.txtmasp)
        Me.Controls.Add(Me.lbltenkh)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.lblmakh)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmChiTietHD"
        Me.Text = "Chi Tiết Hóa Đơn"
        CType(Me.dgvChiTietHD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtmahd As System.Windows.Forms.TextBox
    Friend WithEvents txtsoluong As System.Windows.Forms.TextBox
    Friend WithEvents txtmasp As System.Windows.Forms.TextBox
    Friend WithEvents lbltenkh As System.Windows.Forms.Label
    Friend WithEvents lblemail As System.Windows.Forms.Label
    Friend WithEvents lblmakh As System.Windows.Forms.Label
    Friend WithEvents dgvChiTietHD As System.Windows.Forms.DataGridView
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtTimkiem As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
