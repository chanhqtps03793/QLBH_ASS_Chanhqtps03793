Imports System.Data
Imports System.Data.SqlClient
Public Class frmChiTietHD

    Dim con As New SqlConnection
    Public Sub Taoketnoi()
        Dim str As String = "Data Source=TUANANH_PC;Initial Catalog=Ass;Integrated Security=True"
        con.ConnectionString = str

    End Sub
    Public Function LayDulieu() As DataTable
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        da.SelectCommand = New SqlCommand("select * from CHITIETHD", con)
        da.Fill(dt)
        Return dt
    End Function
    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        If txtmasp.Text = "" Then
            MessageBox.Show("Chưa nhập mã sản phẩm", "Missed Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtmasp.Focus()
        ElseIf txtmahd.Text = "" Then
            MessageBox.Show("Chưa nhập mã hóa đơn", "Missed Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtmahd.Focus()
        ElseIf txtsoluong.Text = "" Then
            MessageBox.Show("Chưa nhập số lượng sản phẩm", "Missed Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        
        Else

            Dim sql As String = "INSERT INTO CHITIETHD(MASP, MAHD, SOLUONGSP) VALUES('" & txtmasp.Text & "',N'" & txtmahd.Text & "','" & txtsoluong.Text & "')"
            Dim cmd As New SqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()


            'Load du lieu
            Dim dt As New DataTable
            dt = LayDulieu()
            dgvChiTietHD.DataSource = dt
            txtmasp.DataBindings.Clear()
            txtmahd.DataBindings.Clear()
            txtsoluong.DataBindings.Clear()
        
            txtmasp.DataBindings.Add("text", dt, "MASP")
            txtmahd.DataBindings.Add("text", dt, "MAHD")
            txtsoluong.DataBindings.Add("text", dt, "SOLUONGSP")
        End If
    End Sub

    Private Sub frmChiTietHD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Taoketnoi()
        Dim dt As New DataTable
        dt = LayDulieu()
        dgvChiTietHD.DataSource = dt
        dt = LayDulieu()
        dgvChiTietHD.DataSource = dt
        txtmasp.DataBindings.Clear()
        txtmahd.DataBindings.Clear()
        txtsoluong.DataBindings.Clear()

        txtmasp.DataBindings.Add("text", dt, "MASP")
        txtmahd.DataBindings.Add("text", dt, "MAHD")
        txtsoluong.DataBindings.Add("text", dt, "SOLUONGSP")
       
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim MASP As String = txtmasp.Text
        Dim MAHD As String = txtmahd.Text
        Dim SOLUONGSP As String = txtsoluong.Text

        Dim sql As String = "update CHITIETHD set MAHD=N'" & MASP & "', SOLUONGSP=N'" & SOLUONGSP & "' where MASP='" & MASP & "'"
        Dim cmd As New SqlCommand(sql, con)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()


        MessageBox.Show("Sửa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtmasp.ReadOnly = False
        'LOAD DỮ LIỆU
        Dim dt As New DataTable
        dt = LayDulieu()
        dgvChiTietHD.DataSource = dt
        txtmasp.DataBindings.Clear()
        txtmahd.DataBindings.Clear()
        txtsoluong.DataBindings.Clear()

        txtmasp.DataBindings.Add("text", dt, "MASP")
        txtmahd.DataBindings.Add("text", dt, "MAHD")
        txtsoluong.DataBindings.Add("text", dt, "SOLUONGSP")
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        If txtmasp.Text = "" Then
            MessageBox.Show("Nhập mã sản phẩm cần xóa")
            txtmasp.Focus()
        Else
            Dim delquery As String = "delete from CHITIETHD  where MASP=@MASP"
            Dim delete As SqlCommand = New SqlCommand(delquery, con)
            Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resulft = Windows.Forms.DialogResult.Yes Then

                delete.Parameters.AddWithValue("@MASP", txtmasp.Text)
                con.Open()
                delete.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Xóa thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' LOAD DỮ LIỆU
                Dim dt As New DataTable
                dt = LayDulieu()
                dgvChiTietHD.DataSource = dt
              
                txtmasp.DataBindings.Clear()
                txtmahd.DataBindings.Clear()
                txtsoluong.DataBindings.Clear()

                txtmasp.DataBindings.Add("text", dt, "MASP")
                txtmahd.DataBindings.Add("text", dt, "MAHD")
                txtsoluong.DataBindings.Add("text", dt, "SOLUONGSP")
            End If
        End If
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtTimkiem.TextChanged
        Dim sql As String = "select * from CHITIETHD where MASP like  '%" & txtTimkiem.Text & "%'"

        'load du lieu
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        da.SelectCommand = New SqlCommand(sql, con)
        da.Fill(dt)
        dgvChiTietHD.DataSource = dt
        dgvChiTietHD.DataSource = dt
        txtmasp.DataBindings.Clear()
        txtmahd.DataBindings.Clear()
        txtsoluong.DataBindings.Clear()
        txtmasp.DataBindings.Add("text", dt, "MASP")
        txtmahd.DataBindings.Add("text", dt, "MAHD")
        txtsoluong.DataBindings.Add("text", dt, "SOLUONGSP")
    End Sub
End Class