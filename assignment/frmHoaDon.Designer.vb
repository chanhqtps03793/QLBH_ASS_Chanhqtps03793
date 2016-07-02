<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHoaDon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHoaDon))
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.dgvHoaDon = New System.Windows.Forms.DataGridView()
        Me.txtngayhd = New System.Windows.Forms.TextBox()
        Me.txtmakh = New System.Windows.Forms.TextBox()
        Me.txtmahd = New System.Windows.Forms.TextBox()
        Me.lbltenkh = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lblmakh = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtTimkiem = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvHoaDon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnsua
        '
        Me.btnsua.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnsua.Location = New System.Drawing.Point(590, 52)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(78, 36)
        Me.btnsua.TabIndex = 33
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = False
        '
        'btnxoa
        '
        Me.btnxoa.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnxoa.Location = New System.Drawing.Point(685, 52)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(78, 36)
        Me.btnxoa.TabIndex = 32
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = False
        '
        'btnthem
        '
        Me.btnthem.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnthem.Location = New System.Drawing.Point(497, 52)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(78, 36)
        Me.btnthem.TabIndex = 31
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = False
        '
        'dgvHoaDon
        '
        Me.dgvHoaDon.AllowUserToAddRows = False
        Me.dgvHoaDon.AllowUserToDeleteRows = False
        Me.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHoaDon.Location = New System.Drawing.Point(7, 171)
        Me.dgvHoaDon.Name = "dgvHoaDon"
        Me.dgvHoaDon.ReadOnly = True
        Me.dgvHoaDon.Size = New System.Drawing.Size(756, 179)
        Me.dgvHoaDon.TabIndex = 30
        '
        'txtngayhd
        '
        Me.txtngayhd.Location = New System.Drawing.Point(306, 93)
        Me.txtngayhd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtngayhd.Name = "txtngayhd"
        Me.txtngayhd.Size = New System.Drawing.Size(176, 20)
        Me.txtngayhd.TabIndex = 29
        '
        'txtmakh
        '
        Me.txtmakh.Location = New System.Drawing.Point(306, 52)
        Me.txtmakh.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmakh.Name = "txtmakh"
        Me.txtmakh.Size = New System.Drawing.Size(176, 20)
        Me.txtmakh.TabIndex = 28
        '
        'txtmahd
        '
        Me.txtmahd.Location = New System.Drawing.Point(306, 10)
        Me.txtmahd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmahd.Name = "txtmahd"
        Me.txtmahd.Size = New System.Drawing.Size(176, 20)
        Me.txtmahd.TabIndex = 27
        '
        'lbltenkh
        '
        Me.lbltenkh.AutoSize = True
        Me.lbltenkh.BackColor = System.Drawing.Color.Transparent
        Me.lbltenkh.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbltenkh.Location = New System.Drawing.Point(152, 93)
        Me.lbltenkh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltenkh.Name = "lbltenkh"
        Me.lbltenkh.Size = New System.Drawing.Size(75, 18)
        Me.lbltenkh.TabIndex = 26
        Me.lbltenkh.Text = "Ngày HD:"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.BackColor = System.Drawing.Color.Transparent
        Me.lblemail.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblemail.Location = New System.Drawing.Point(152, 52)
        Me.lblemail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(61, 18)
        Me.lblemail.TabIndex = 25
        Me.lblemail.Text = "Mã KH:"
        '
        'lblmakh
        '
        Me.lblmakh.AutoSize = True
        Me.lblmakh.BackColor = System.Drawing.Color.Transparent
        Me.lblmakh.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblmakh.Location = New System.Drawing.Point(152, 10)
        Me.lblmakh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblmakh.Name = "lblmakh"
        Me.lblmakh.Size = New System.Drawing.Size(62, 18)
        Me.lblmakh.TabIndex = 24
        Me.lblmakh.Text = "Mã HD:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'txtTimkiem
        '
        Me.txtTimkiem.Location = New System.Drawing.Point(306, 136)
        Me.txtTimkiem.Name = "txtTimkiem"
        Me.txtTimkiem.Size = New System.Drawing.Size(176, 20)
        Me.txtTimkiem.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.Location = New System.Drawing.Point(151, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 19)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Tìm Kiếm(Mã HD):"
        '
        'frmHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(772, 362)
        Me.Controls.Add(Me.txtTimkiem)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.dgvHoaDon)
        Me.Controls.Add(Me.txtngayhd)
        Me.Controls.Add(Me.txtmakh)
        Me.Controls.Add(Me.txtmahd)
        Me.Controls.Add(Me.lbltenkh)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.lblmakh)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHoaDon"
        Me.Text = "Hóa Đơn"
        CType(Me.dgvHoaDon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents dgvHoaDon As System.Windows.Forms.DataGridView
    Friend WithEvents txtngayhd As System.Windows.Forms.TextBox
    Friend WithEvents txtmakh As System.Windows.Forms.TextBox
    Friend WithEvents txtmahd As System.Windows.Forms.TextBox
    Friend WithEvents lbltenkh As System.Windows.Forms.Label
    Friend WithEvents lblemail As System.Windows.Forms.Label
    Friend WithEvents lblmakh As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtTimkiem As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
