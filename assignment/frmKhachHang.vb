Imports System.Data
Imports System.Data.SqlClient
Public Class frmKhachHang
    Dim con As New SqlConnection
    Public Sub Taoketnoi()
        Dim str As String = "Data Source=TUANANH_PC;Initial Catalog=Ass;Integrated Security=True"
        con.ConnectionString = str

    End Sub
    Public Function LayDulieu() As DataTable
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        da.SelectCommand = New SqlCommand("select * from KHACHHANG", con)
        da.Fill(dt)
        Return dt
    End Function

    Private Sub frmKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Taoketnoi()
        Dim dt As New DataTable
        dt = LayDulieu()
        dgvKH.DataSource = dt
        dt = LayDulieu()
        dgvKH.DataSource = dt
        txtmakh.DataBindings.Clear()
        txttenkh.DataBindings.Clear()
        txtemail.DataBindings.Clear()
        txtsdt.DataBindings.Clear()
        txtdiachi.DataBindings.Clear()
        txtmakh.DataBindings.Add("text", dt, "MAKH")
        txttenkh.DataBindings.Add("text", dt, "TENKH")
        txtemail.DataBindings.Add("text", dt, "EMAIL")
        txtsdt.DataBindings.Add("text", dt, "SDT")
        txtdiachi.DataBindings.Add("text", dt, "DIACHI")


    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        If txtmakh.Text = "" Then
            MessageBox.Show("Chưa nhập mã khách hàng", "Missed Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtmakh.Focus()
        ElseIf txttenkh.Text = "" Then
            MessageBox.Show("Chưa nhập tên khách hàng", "Missed Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txttenkh.Focus()
        ElseIf txtemail.Text = "" Then
            MessageBox.Show("Chưa nhập email", "Missed Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtemail.Focus()
        ElseIf txtsdt.Text = "" Then
            MessageBox.Show("Chưa nhập số điện thoại", "Missed Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtsdt.Focus()
        ElseIf txtdiachi.Text = "" Then
            MessageBox.Show("Chưa nhập địa chỉ", "Missed Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
           
            Dim sql As String = "INSERT INTO KHACHHANG(MAKH, TENKH, EMAIL,SDT, DIACHI) VALUES('" & txtmakh.Text & "',N'" & txttenkh.Text & "',N'" & txtemail.Text & "','" & txtsdt.Text & "', N'" & txtdiachi.Text & "')"
            Dim cmd As New SqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

           
            'Load du lieu
            Dim dt As New DataTable
            dt = LayDulieu()
            dgvKH.DataSource = dt
            txtmakh.DataBindings.Clear()
            txttenkh.DataBindings.Clear()
            txtemail.DataBindings.Clear()
            txtsdt.DataBindings.Clear()
            txtdiachi.DataBindings.Clear()
            txtmakh.DataBindings.Add("text", dt, "MAKH")
            txttenkh.DataBindings.Add("text", dt, "TENKH")
            txtemail.DataBindings.Add("text", dt, "EMAIL")
            txtsdt.DataBindings.Add("text", dt, "SDT")
            txtdiachi.DataBindings.Add("text", dt, "DIACHI")
        End If

    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim MAKH As String = txtmakh.Text
        Dim TENKH As String = txttenkh.Text
        Dim EMAIL As String = txtemail.Text
        Dim SDT As String = txtsdt.Text
        Dim DIACHI As String = txtdiachi.Text
        Dim sql As String = "update KHACHHANG set TENKH=N'" & TENKH & "', EMAIL=N'" & EMAIL & "', SDT='" & SDT & "', DIACHI=N'" & DIACHI & "' where MAKH='" & MAKH & "'"
        Dim cmd As New SqlCommand(sql, con)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()


        MessageBox.Show("Sửa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtmakh.ReadOnly = False
        'LOAD DỮ LIỆU
        Dim dt As New DataTable
        dt = LayDulieu()
        dgvKH.DataSource = dt
        txtmakh.DataBindings.Clear()
        txttenkh.DataBindings.Clear()
        txtemail.DataBindings.Clear()
        txtsdt.DataBindings.Clear()
        txtdiachi.DataBindings.Clear()
        txtmakh.DataBindings.Add("text", dt, "MAKH")
        txttenkh.DataBindings.Add("text", dt, "TENKH")
        txtemail.DataBindings.Add("text", dt, "EMAIL")
        txtsdt.DataBindings.Add("text", dt, "SDT")
        txtdiachi.DataBindings.Add("text", dt, "DIACHI")
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        If txtmakh.Text = "" Then
            MessageBox.Show("Nhập mã khách hàng cần xóa")
            txtmakh.Focus()
        Else
            Dim delquery As String = "delete from KHACHHANG  where MAKH=@MAKH"
            Dim delete As SqlCommand = New SqlCommand(delquery, con)
            Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resulft = Windows.Forms.DialogResult.Yes Then

                delete.Parameters.AddWithValue("@MAKH", txtmakh.Text)
                con.Open()
                delete.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Xóa thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim dt As New DataTable
                dt = LayDulieu()
                dgvKH.DataSource = dt
                txtmakh.DataBindings.Clear()
                txttenkh.DataBindings.Clear()
                txtemail.DataBindings.Clear()
                txtsdt.DataBindings.Clear()
                txtdiachi.DataBindings.Clear()
                txtmakh.DataBindings.Add("text", dt, "MAKH")
                txttenkh.DataBindings.Add("text", dt, "TENKH")
                txtemail.DataBindings.Add("text", dt, "EMAIL")
                txtsdt.DataBindings.Add("text", dt, "SDT")
                txtdiachi.DataBindings.Add("text", dt, "DIACHI")
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtTimkiem.TextChanged
        Dim sql As String = "select * from KHACHHANG where MAKH like  '%" & txtTimkiem.Text & "%'"

        'load du lieu
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        da.SelectCommand = New SqlCommand(sql, con)
        da.Fill(dt)
        dgvKH.DataSource = dt
        dgvKH.DataSource = dt
        txtmakh.DataBindings.Clear()
        txttenkh.DataBindings.Clear()
        txtemail.DataBindings.Clear()
        txtsdt.DataBindings.Clear()
        txtdiachi.DataBindings.Clear()
        txtmakh.DataBindings.Add("text", dt, "MAKH")
        txttenkh.DataBindings.Add("text", dt, "TENKH")
        txtemail.DataBindings.Add("text", dt, "EMAIL")
        txtsdt.DataBindings.Add("text", dt, "SDT")
        txtdiachi.DataBindings.Add("text", dt, "DIACHI")
    End Sub
End Class