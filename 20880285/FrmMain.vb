Public Class FrmMain
    Dim tai_khoan As DataRow
    Dim dsChiNhanh As DataTable
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True
        Dim frm As FrmDangNhap = New FrmDangNhap()
        Dim dr As DialogResult = frm.ShowDialog()
        If dr = DialogResult.Yes Then
            tai_khoan = frm.tai_khoan
            dsChiNhanh = frm.dsChiNhanh


        Else
            Me.Close()
        End If

    End Sub

    Private Sub ChiNhanhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiNhanhToolStripMenuItem.Click
        Dim frm As frmChiNhanh = New frmChiNhanh()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        Dim frm As frmMenu = New frmMenu()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub LoaiMonAnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoaiMonAnToolStripMenuItem.Click
        Dim frm As frmLoaiMonAn = New frmLoaiMonAn()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub NguoiDungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NguoiDungToolStripMenuItem.Click
        Dim frm As frmNguoiDung = New frmNguoiDung()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub


End Class
