Public Class frmChiNhanh
    Dim dsChiNhanh As DataTable
    Dim dsChiNhanhView As DataView

    Private Sub frmChiNhanh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsChiNhanh = XLDuLieu.DocDuLieu("Select * from ChiNhanh where cn_xoa = false")
        System.Console.WriteLine(dsChiNhanh)
        dsChiNhanhView = New DataView(dsChiNhanh)
        dgvDanhSach.DataSource = dsChiNhanhView

        dgvDanhSach.Columns(0).HeaderText = "Ma"
        dgvDanhSach.Columns(1).HeaderText = "Ten"
        dgvDanhSach.Columns(2).HeaderText = "Dia Chi"
        dgvDanhSach.Columns(3).Visible = False
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim chi_nhanh As DataRow = dsChiNhanh.NewRow()
        chi_nhanh("cn_ten") = tbTen.Text
        chi_nhanh("cn_diachi") = tbDiaChi.Text

        dsChiNhanh.Rows.Add(chi_nhanh)
        XLDuLieu.GhiDuLieu("ChiNhanh", dsChiNhanh)
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        If dgvDanhSach.SelectedCells.Count > 0 Then
            Dim cnv As DataRowView = dgvDanhSach.Rows(dgvDanhSach.SelectedCells(0).RowIndex).DataBoundItem
            Dim cn As DataRow = cnv.Row
            cn("cn_ten") = tbTen.Text
            cn("cn_diachi") = tbDiaChi.Text

            XLDuLieu.GhiDuLieu("ChiNhanh", dsChiNhanh)
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If dgvDanhSach.SelectedCells.Count > 0 Then
            Dim cnv As DataRowView = dgvDanhSach.Rows(dgvDanhSach.SelectedCells(0).RowIndex).DataBoundItem
            Dim cn As DataRow = cnv.Row
            cn("cn_xoa") = True

            XLDuLieu.GhiDuLieu("ChiNhanh", dsChiNhanh)
            dsChiNhanh.Rows.Remove(cn)
        End If
    End Sub

    Private Sub dgvDanhSach_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSach.CellClick
        If dgvDanhSach.SelectedCells.Count > 0 Then
            Dim cnv As DataRowView = dgvDanhSach.Rows(dgvDanhSach.SelectedCells(0).RowIndex).DataBoundItem
            Dim cn As DataRow = cnv.Row
            tbTen.Text = cn("cn_ten")
            tbDiaChi.Text = cn("cn_diachi")
        End If
    End Sub

    Private Sub tbTimKiem_TextChanged(sender As Object, e As EventArgs) Handles tbTimKiem.TextChanged
        If tbTimKiem.Text <> "" Then
            dsChiNhanhView.RowFilter = "cn_ten like '%" + tbTimKiem.Text + "%'"
        Else
            dsChiNhanhView.RowFilter = ""
        End If
    End Sub
End Class