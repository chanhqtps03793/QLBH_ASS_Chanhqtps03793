<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKhachHang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKhachHang))
        Me.lblmakh = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lblsdt = New System.Windows.Forms.Label()
        Me.lbldiachi = New System.Windows.Forms.Label()
        Me.lbltenkh = New System.Windows.Forms.Label()
        Me.txtmakh = New System.Windows.Forms.TextBox()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.txtsdt = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txttenkh = New System.Windows.Forms.TextBox()
        Me.dgvKH = New System.Windows.Forms.DataGridView()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTimkiem = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvKH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblmakh
        '
        Me.lblmakh.AutoSize = True
        Me.lblmakh.BackColor = System.Drawing.Color.Transparent
        Me.lblmakh.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblmakh.Location = New System.Drawing.Point(13, 122)
        Me.lblmakh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblmakh.Name = "lblmakh"
        Me.lblmakh.Size = New System.Drawing.Size(61, 18)
        Me.lblmakh.TabIndex = 0
        Me.lblmakh.Text = "Mã KH:"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.BackColor = System.Drawing.Color.Transparent
        Me.lblemail.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblemail.Location = New System.Drawing.Point(13, 216)
        Me.lblemail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(53, 18)
        Me.lblemail.TabIndex = 1
        Me.lblemail.Text = "Email:"
        '
        'lblsdt
        '
        Me.lblsdt.AutoSize = True
        Me.lblsdt.BackColor = System.Drawing.Color.Transparent
        Me.lblsdt.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblsdt.Location = New System.Drawing.Point(13, 263)
        Me.lblsdt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsdt.Name = "lblsdt"
        Me.lblsdt.Size = New System.Drawing.Size(41, 18)
        Me.lblsdt.TabIndex = 2
        Me.lblsdt.Text = "SĐT:"
        '
        'lbldiachi
        '
        Me.lbldiachi.AutoSize = True
        Me.lbldiachi.BackColor = System.Drawing.Color.Transparent
        Me.lbldiachi.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbldiachi.Location = New System.Drawing.Point(13, 309)
        Me.lbldiachi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldiachi.Name = "lbldiachi"
        Me.lbldiachi.Size = New System.Drawing.Size(66, 18)
        Me.lbldiachi.TabIndex = 3
        Me.lbldiachi.Text = "Địa Chỉ:"
        '
        'lbltenkh
        '
        Me.lbltenkh.AutoSize = True
        Me.lbltenkh.BackColor = System.Drawing.Color.Transparent
        Me.lbltenkh.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbltenkh.Location = New System.Drawing.Point(13, 168)
        Me.lbltenkh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltenkh.Name = "lbltenkh"
        Me.lbltenkh.Size = New System.Drawing.Size(65, 18)
        Me.lbltenkh.TabIndex = 4
        Me.lbltenkh.Text = "Tên KH:"
        '
        'txtmakh
        '
        Me.txtmakh.Location = New System.Drawing.Point(162, 120)
        Me.txtmakh.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmakh.Name = "txtmakh"
        Me.txtmakh.Size = New System.Drawing.Size(154, 22)
        Me.txtmakh.TabIndex = 5
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(162, 307)
        Me.txtdiachi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(154, 22)
        Me.txtdiachi.TabIndex = 6
        '
        'txtsdt
        '
        Me.txtsdt.Location = New System.Drawing.Point(162, 261)
        Me.txtsdt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsdt.Name = "txtsdt"
        Me.txtsdt.Size = New System.Drawing.Size(154, 22)
        Me.txtsdt.TabIndex = 7
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(162, 214)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(154, 22)
        Me.txtemail.TabIndex = 8
        '
        'txttenkh
        '
        Me.txttenkh.Location = New System.Drawing.Point(162, 166)
        Me.txttenkh.Margin = New System.Windows.Forms.Padding(4)
        Me.txttenkh.Name = "txttenkh"
        Me.txttenkh.Size = New System.Drawing.Size(154, 22)
        Me.txttenkh.TabIndex = 9
        '
        'dgvKH
        '
        Me.dgvKH.AllowUserToAddRows = False
        Me.dgvKH.AllowUserToDeleteRows = False
        Me.dgvKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKH.Location = New System.Drawing.Point(349, 120)
        Me.dgvKH.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvKH.Name = "dgvKH"
        Me.dgvKH.ReadOnly = True
        Me.dgvKH.Size = New System.Drawing.Size(597, 212)
        Me.dgvKH.TabIndex = 10
        '
        'btnthem
        '
        Me.btnthem.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnthem.Location = New System.Drawing.Point(349, 355)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(91, 30)
        Me.btnthem.TabIndex = 11
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = False
        '
        'btnxoa
        '
        Me.btnxoa.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnxoa.Location = New System.Drawing.Point(633, 355)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(91, 30)
        Me.btnxoa.TabIndex = 12
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = False
        '
        'btnsua
        '
        Me.btnsua.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnsua.Location = New System.Drawing.Point(491, 355)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(91, 30)
        Me.btnsua.TabIndex = 13
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(206, 118)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(343, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 33)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Quản Lý Khách Hàng"
        '
        'txtTimkiem
        '
        Me.txtTimkiem.Location = New System.Drawing.Point(162, 352)
        Me.txtTimkiem.Name = "txtTimkiem"
        Me.txtTimkiem.Size = New System.Drawing.Size(154, 22)
        Me.txtTimkiem.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 355)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 19)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Tìm Kiếm(Mã KH):"
        '
        'frmKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(956, 405)
        Me.Controls.Add(Me.txtTimkiem)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.dgvKH)
        Me.Controls.Add(Me.txttenkh)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtsdt)
        Me.Controls.Add(Me.txtdiachi)
        Me.Controls.Add(Me.txtmakh)
        Me.Controls.Add(Me.lbltenkh)
        Me.Controls.Add(Me.lbldiachi)
        Me.Controls.Add(Me.lblsdt)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.lblmakh)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmKhachHang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản Lý Khách Hàng"
        CType(Me.dgvKH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblmakh As System.Windows.Forms.Label
    Friend WithEvents lblemail As System.Windows.Forms.Label
    Friend WithEvents lblsdt As System.Windows.Forms.Label
    Friend WithEvents lbldiachi As System.Windows.Forms.Label
    Friend WithEvents lbltenkh As System.Windows.Forms.Label
    Friend WithEvents txtmakh As System.Windows.Forms.TextBox
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents txtsdt As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txttenkh As System.Windows.Forms.TextBox
    Friend WithEvents dgvKH As System.Windows.Forms.DataGridView
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTimkiem As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
