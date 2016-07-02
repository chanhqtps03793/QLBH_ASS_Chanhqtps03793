Imports System.Data
Imports System.Data.SqlClient
Public Class frmHoaDon

    Dim con As New SqlConnection
    Public Sub Taoketnoi()
        Dim str As String = "Data Source=TUANANH_PC;Initial Catalog=Ass;Integrated Security=True"
        con.ConnectionString = str

    End Sub
    Public Function LayDulieu() As DataTable
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        da.SelectCommand = New SqlCommand("select * from HOADON", con)
        da.Fill(dt)
        Return dt
    End Function
    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        If txtmahd.Text = "" Then
            MessageBox.Show("Chưa nhập mã hóa đơn", "Missed Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtmahd.Focus()

        ElseIf txtmakh.Text = "" Then
            MessageBox.Show("Chưa nhập số lượng sản phẩm", "Missed Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtmakh.Focus()
        ElseIf txtngayhd.Text = "" Then
            MessageBox.Show("Chưa nhập ngày hóa đơn", "Missed Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            Dim sql As String = "INSERT INTO HOADON(MAHD, MAKH, NGAYHD) VALUES('" & txtmahd.Text & "','" & txtmakh.Text & "','" & txtngayhd.Text & "')"
            Dim cmd As New SqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()


            'Load du lieu
            Dim dt As New DataTable
            dt = LayDulieu()
            dgvHoaDon.DataSource = dt
            txtmahd.DataBindings.Clear()
            txtmakh.DataBindings.Clear()
            txtngayhd.DataBindings.Clear()

            txtmahd.DataBindings.Add("text", dt, "MAHD")
            txtmakh.DataBindings.Add("text", dt, "MAKH")
            txtngayhd.DataBindings.Add("text", dt, "NGAYHD")
        End If
    End Sub

    Private Sub frmHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Taoketnoi()
        Dim dt As New DataTable
        dt = LayDulieu()
        dgvHoaDon.DataSource = dt
        dt = LayDulieu()
        dgvHoaDon.DataSource = dt
        txtmahd.DataBindings.Clear()
        txtmakh.DataBindings.Clear()
        txtngayhd.DataBindings.Clear()
        txtmahd.DataBindings.Add("text", dt, "MAHD")
        txtmakh.DataBindings.Add("text", dt, "MAKH")
        txtngayhd.DataBindings.Add("text", dt, "NGAYHD")

    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim MAHD As String = txtmahd.Text
        Dim MAKH As String = txtmakh.Text
        Dim NGAYHD As String = txtngayhd.Text

        Dim sql As String = "update HOADON set MAKH='" & MAKH & "', NGAYHD='" & NGAYHD & "' where MAHD='" & MAHD & "'"
        Dim cmd As New SqlCommand(sql, con)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()


        MessageBox.Show("Sửa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtmahd.ReadOnly = False
        'LOAD DỮ LIỆU
        Dim dt As New DataTable
        dt = LayDulieu()
        dgvHoaDon.DataSource = dt
        dgvHoaDon.DataSource = dt
        txtmahd.DataBindings.Clear()
        txtngayhd.DataBindings.Clear()
        txtmakh.DataBindings.Clear()

        txtmahd.DataBindings.Add("text", dt, "MAHD")
        txtngayhd.DataBindings.Add("text", dt, "NGAYHD")
        txtmakh.DataBindings.Add("text", dt, "MAKH")
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        If txtmahd.Text = "" Then
            MessageBox.Show("Nhập mã sản phẩm cần xóa")
            txtmahd.Focus()
        Else
            Dim delquery As String = "delete from HOADON  where MAHD=@MAHD"
            Dim delete As SqlCommand = New SqlCommand(delquery, con)
            Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resulft = Windows.Forms.DialogResult.Yes Then

                delete.Parameters.AddWithValue("@MAHD", txtmahd.Text)
                con.Open()
                delete.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Xóa thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' LOAD DỮ LIỆU
                Dim dt As New DataTable
                dt = LayDulieu()
                dgvHoaDon.DataSource = dt

                txtmahd.DataBindings.Clear()
                txtngayhd.DataBindings.Clear()
                txtmakh.DataBindings.Clear()

                txtmahd.DataBindings.Add("text", dt, "MAHD")
                txtngayhd.DataBindings.Add("text", dt, "NGAYHD")
                txtmakh.DataBindings.Add("text", dt, "MAKH")
            End If
        End If
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtTimkiem.TextChanged
        Dim sql As String = "select * from HOADON where MAHD like  '%" & txtTimkiem.Text & "%'"

        'load du lieu
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        da.SelectCommand = New SqlCommand(sql, con)
        da.Fill(dt)
        dgvHoaDon.DataSource = dt
        dgvHoaDon.DataSource = dt
        txtmakh.DataBindings.Clear()
         txtmahd.DataBindings.Clear()
        txtngayhd.DataBindings.Clear()
        txtmakh.DataBindings.Clear()
        txtmahd.DataBindings.Add("text", dt, "MAHD")
        txtngayhd.DataBindings.Add("text", dt, "NGAYHD")
        txtmakh.DataBindings.Add("text", dt, "MAKH")
    End Sub
End Class