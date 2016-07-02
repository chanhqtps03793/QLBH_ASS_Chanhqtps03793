Imports System.Data.SqlClient
Imports System.Data.DataSet
Public Class frmXemsanpham
    Dim db As New DataTable
    Dim Taoketnoi As String = "Data Source=TUANANH_PC;Initial Catalog=Ass;Integrated Security=True"
    Dim con As SqlConnection = New SqlConnection(Taoketnoi)
    Private Sub btnXemall_Click(sender As Object, e As EventArgs) Handles btnXemall.Click
        Dim hienthi As New Class1
        dgvXemsp.DataSource = hienthi.Loadsanpham.Tables(0)
    End Sub

    Private Sub btnXem_Click(sender As Object, e As EventArgs) Handles btnXem.Click
        Dim con As SqlConnection = New SqlConnection(Taoketnoi)
        con.Open()
        Dim timkiem As SqlDataAdapter = New SqlDataAdapter("select SANPHAM.MASP as 'Mã sản phẩm',SANPHAM.TENSP as 'Tên sản phẩm', LOAISANPHAM.MALOAI as 'Mã Loại', LOAISANPHAM.TENLOAI as 'Tên Loại' from SANPHAM inner join LOAISANPHAM on SANPHAM.MALOAI = LOAISANPHAM.MALOAI where SANPHAM.MASP ='" & txtMASP.Text & "' ", con)
        Try
            If txtMASP.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sản phẩm", "Missed Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                db.Clear()
                dgvXemsp.DataSource = Nothing
                timkiem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvXemsp.DataSource = db.DefaultView
                    txtMASP.Text = Nothing
                Else
                    MessageBox.Show("Mã sản phẩm chưa chính xác", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtMASP.Text = Nothing
                End If
            End If
            con.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

    Private Sub frmXemsanpham_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class