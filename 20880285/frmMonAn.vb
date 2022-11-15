Public Class frmMonAn
    Dim dsMonAn As DataTable
    Dim dsMonAnView As DataView

    Dim dsLoai As DataTable
    Private Sub frmMonAn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = "Select * from LoaiMonAn where lma_xoa = false"
        dsLoai = XLDuLieu.DocDuLieu(sql)
        cbLoai.DataSource = dsLoai
        cbLoai.DisplayMember = "lma_ten"
        cbLoai.ValueMember = "lma_ma"

        DocDSMonAn()
    End Sub

    Private Sub DocDSMonAn()
        Dim sql As String = "Select * from MonAn, LoaiMonAn where ma_xoa = false and lma_ma = ma_loaimonan"
        dsMonAn = XLDuLieu.DocDuLieu(sql)
        dsMonAnView = New DataView(dsMonAn)
        dgvDanhSach.DataSource = dsMonAnView
        dgvDanhSach.Columns(4).Visible = False
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim mon_an As DataRow = dsMonAn.NewRow()
        mon_an("ma_ten") = tbTen.Text
        mon_an("ma_loaimonan") = cbLoai.SelectedItem("lma_ma")
        mon_an("lma_ten") = cbLoai.SelectedItem("lma_ten")
        mon_an("ma_gia") = nudGia.Value
        mon_an("ma_xoa") = False

        dsMonAn.Rows.Add(mon_an)
        XLDuLieu.GhiDuLieu("MonAn", dsMonAn)
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        If dgvDanhSach.SelectedCells.Count > 0 Then
            Dim mav As DataRowView = dgvDanhSach.Rows(dgvDanhSach.SelectedCells(0).RowIndex).DataBoundItem
            Dim mon_an As DataRow = mav.Row
            mon_an("ma_ten") = tbTen.Text
            mon_an("ma_loaimonan") = cbLoai.SelectedItem("lma_ma")
            mon_an("lma_ten") = cbLoai.SelectedItem("lma_ten")
            mon_an("ma_gia") = nudGia.Value

            XLDuLieu.GhiDuLieu("MonAn", dsMonAn)
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If dgvDanhSach.SelectedCells.Count > 0 Then
            Dim mav As DataRowView = dgvDanhSach.Rows(dgvDanhSach.SelectedCells(0).RowIndex).DataBoundItem
            Dim mon_an As DataRow = mav.Row
            mon_an("ma_xoa") = False

            XLDuLieu.GhiDuLieu("MonAn", dsMonAn)
            dsMonAn.Rows.Remove(mon_an)
        End If
    End Sub

    Private Sub dgvDanhSach_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhSach.SelectionChanged
        If dgvDanhSach.SelectedCells.Count > 0 Then
            Dim mav As DataRowView = dgvDanhSach.Rows(dgvDanhSach.SelectedCells(0).RowIndex).DataBoundItem
            Dim mon_an As DataRow = mav.Row
            tbTen.Text = mon_an("ma_ten")
            cbLoai.SelectedItem("lma_ma") = mon_an("ma_loaimonan")
            nudGia.Value = mon_an("ma_gia")
        End If
    End Sub
End Class