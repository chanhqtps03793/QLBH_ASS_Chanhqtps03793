Public Class frmMain

    Private Sub QuảnLýSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýSảnPhẩmToolStripMenuItem.Click
        frmSanPham.ShowDialog()
    End Sub

    Private Sub XemSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XemSảnPhẩmToolStripMenuItem.Click
        frmXemsanpham.ShowDialog()
    End Sub

    Private Sub QuảnLýKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýKháchHàngToolStripMenuItem.Click
        frmKhachHang.ShowDialog()
    End Sub

    Private Sub QuảnLýHóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmHoaDon.ShowDialog()
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        frmHoaDon.ShowDialog()

    End Sub

    Private Sub ChiTiếtHóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmChiTietHD.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        frmChiTietHD.ShowDialog()
    End Sub

    Private Sub ThoátToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class