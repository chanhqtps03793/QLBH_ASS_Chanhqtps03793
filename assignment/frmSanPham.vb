Imports System.Data
Imports System.Data.SqlClient

Public Class frmSanPham
    Dim con As New SqlConnection
    Public Sub Taoketnoi()
        Dim str As String = "Data Source=TUANANH_PC;Initial Catalog=Ass;Integrated Security=True"
        con.ConnectionString = str


    End Sub
    Public Function LayDulieu() As DataTable
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        da.SelectCommand = New SqlCommand("select * from SANPHAM", con)
        da.Fill(dt)
        Return dt
    End Function
    Private Sub frmSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Taoketnoi()
        Dim dt As New DataTable
        dt = LayDulieu()
        DataGridView1.DataSource = dt
        dt = LayDulieu()
        DataGridView1.DataSource = dt
        txtMaSP.DataBindings.Clear()
        txtTenSP.DataBindings.Clear()
        txtDongia.DataBindings.Clear()
        txtMaloai.DataBindings.Clear()
        txtMaSP.DataBindings.Add("text", dt, "MASP")
        txtTenSP.DataBindings.Add("text", dt, "TENSP")
        txtDongia.DataBindings.Add("text", dt, "DONGIA")
        txtMaloai.DataBindings.Add("text", dt, "MALOAI")
    End Sub

  

   

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim MASP As String = txtMaSP.Text
        Dim TENSP As String = txtTenSP.Text
        Dim DONGIA As String = txtDongia.Text
        Dim MALOAI As String = txtMaloai.Text
        Dim sql As String = "update SANPHAM set TENSP=N'" & TENSP & "', DONGIA=N'" & DONGIA & "', MALOAI='" & MALOAI & "' where MASP='" & MASP & "'"
        Dim cmd As New SqlCommand(sql, con)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()


        
        MessageBox.Show("Sửa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtMaSP.ReadOnly = False

        'load du lieu
        Dim dt As New DataTable
        dt = LayDulieu()
        DataGridView1.DataSource = dt
        txtMaSP.DataBindings.Clear()
        txtTenSP.DataBindings.Clear()
        txtDongia.DataBindings.Clear()
        txtMaloai.DataBindings.Clear()
        txtMaSP.DataBindings.Add("text", dt, "MASP")
        txtTenSP.DataBindings.Add("text", dt, "TENSP")
        txtDongia.DataBindings.Add("text", dt, "DONGIA")
        txtMaloai.DataBindings.Add("text", dt, "MALOAI")

    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If txtMaSP.Text = "" Then
            MessageBox.Show("Chưa nhập mã sản phẩm", "Missed Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtMaSP.Focus()
        ElseIf txtTenSP.Text = "" Then
            MessageBox.Show("Chưa nhập tên sản phẩm", "Missed Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTenSP.Focus()
        ElseIf txtDongia.Text = "" Then
            MessageBox.Show("Chưa nhập đơn giá", "Missed Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDongia.Focus()
        ElseIf txtMaloai.Text = "" Then
            MessageBox.Show("Chưa nhập mã loại", "Missed Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            Dim sql As String = "INSERT INTO SANPHAM(MASP, TENSP, DONGIA,MALOAI) VALUES('" & txtMaSP.Text & "',N'" & txtTenSP.Text & "',N'" & txtDongia.Text & "','" & txtMaloai.Text & "')"
            Dim cmd As New SqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            'Load du lieu
            Dim dt As New DataTable
            dt = LayDulieu()
            DataGridView1.DataSource = dt
            txtMaSP.DataBindings.Clear()
            txtTenSP.DataBindings.Clear()
            txtDongia.DataBindings.Clear()
            txtMaloai.DataBindings.Clear()
            txtMaSP.DataBindings.Add("text", dt, "MASP")
            txtTenSP.DataBindings.Add("text", dt, "TENSP")
            txtDongia.DataBindings.Add("text", dt, "DONGIA")
            txtMaloai.DataBindings.Add("text", dt, "MALOAI")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtTimkiem.TextChanged
        Dim sql As String = "select * from SANPHAM where TENSP like  '%" & txtTimkiem.Text & "%'"

        'load du lieu
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        da.SelectCommand = New SqlCommand(sql, con)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        DataGridView1.DataSource = dt
        txtMaSP.DataBindings.Clear()
        txtTenSP.DataBindings.Clear()
        txtDongia.DataBindings.Clear()
        txtMaloai.DataBindings.Clear()
        txtMaSP.DataBindings.Add("text", dt, "MASP")
        txtTenSP.DataBindings.Add("text", dt, "TENSP")
        txtDongia.DataBindings.Add("text", dt, "DONGIA")
        txtMaloai.DataBindings.Add("text", dt, "MALOAI")
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
      If txtMaSP.Text = "" Then
            MessageBox.Show("Nhập mã sản phẩm cần xóa")
            txtMaSP.Focus()
        Else
            Dim delquery As String = "delete from SANPHAM  where MASP=@MASP"
            Dim delete As SqlCommand = New SqlCommand(delquery, con)
            Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resulft = Windows.Forms.DialogResult.Yes Then

                delete.Parameters.AddWithValue("@MASP", txtMaSP.Text)
                con.Open()
                delete.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Xóa thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim dt As New DataTable
                dt = LayDulieu()
                DataGridView1.DataSource = dt
                txtMaSP.DataBindings.Clear()
                txtTenSP.DataBindings.Clear()
                txtDongia.DataBindings.Clear()
                txtMaloai.DataBindings.Clear()
                txtMaSP.DataBindings.Add("text", dt, "MASP")
                txtTenSP.DataBindings.Add("text", dt, "TENSP")
                txtDongia.DataBindings.Add("text", dt, "DONGIA")
                txtMaloai.DataBindings.Add("text", dt, "MALOAI")
            End If
        End If

    End Sub



    Private Sub btnRefesh_Click(sender As Object, e As EventArgs) Handles btnRefesh.Click

        Dim dt As New DataTable
        dt = LayDulieu()
        DataGridView1.DataSource = dt
        txtMaSP.DataBindings.Clear()
        txtTenSP.DataBindings.Clear()
        txtDongia.DataBindings.Clear()
        txtMaloai.DataBindings.Clear()
        txtMaSP.DataBindings.Add("text", dt, "MASP")
        txtTenSP.DataBindings.Add("text", dt, "TENSP")
        txtDongia.DataBindings.Add("text", dt, "DONGIA")
        txtMaloai.DataBindings.Add("text", dt, "MALOAI")
        txtMaSP.Text = ""
        txtTenSP.Text = ""
        txtDongia.Text = ""
        txtMaloai.Text = ""




    End Sub
  



    

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        frmXemsanpham.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value

        Dim i As Integer
        Dim j As Integer

        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")

        For i = 0 To DataGridView1.RowCount - 1
            For j = 0 To DataGridView1.ColumnCount - 1
                For k As Integer = 1 To DataGridView1.Columns.Count
                    xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()

                Next
            Next
        Next
        xlWorkSheet.SaveAs("E:\dataexcel.xlsx")
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        MsgBox("Bạn có thể tìm dữ liệu theo thư mục E:\dataexcel.xlsx", MessageBoxButtons.OK)
        Dim res As MsgBoxResult
        res = MsgBox("Tiến trình xuất dữ liệu đã hoàn tất, Bạn có muốn mở file excel này không?", MsgBoxStyle.YesNo)
        If (res = MsgBoxResult.Yes) Then
            Process.Start("E:\dataexcel.xlsx")
        End If


    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class