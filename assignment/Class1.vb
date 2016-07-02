Imports System.Data.SqlClient
Imports System.Data
Public Class Class1
    Public Function Loadkhachang() As DataSet
        Dim chuoiketnoi As String = "Data Source=TUANANH_PC;Initial Catalog=Ass;Integrated Security=True"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadKH As New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', SDT as 'SĐT', EMAIL from KHACHANG", conn)
        Dim db As New DataSet
        conn.Open()
        LoadKH.Fill(db)
        conn.Close()
        Return db
    End Function
    Public Function Loadsanpham() As DataSet
        Dim Taoketnoi As String = "Data Source=TUANANH_PC;Initial Catalog=Ass;Integrated Security=True"
        Dim con As SqlConnection = New SqlConnection(Taoketnoi)
        Dim LoadSP As New SqlDataAdapter("select SANPHAM.MASP as 'Mã SP',SANPHAM.TENSP as 'Tên SP', LOAISANPHAM.MALOAI as 'Mã Loại', LOAISANPHAM.TENLOAI as 'Tên Loại' from SANPHAM inner join LOAISANPHAM on SANPHAM.MALOAI = LOAISANPHAM.MALOAI", con)
        Dim db As New DataSet
        con.Open()
        LoadSP.Fill(db)
        con.Close()
        Return db
    End Function
End Class
