Public Class frmNguoiDung
    Dim dsNguoiDung As DataTable
    Dim dsTaiKhoan As DataTable
    Private Sub frmNguoiDung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = "Select * from NguoiDung, TaiKhoan where tk_manguoidung = nd_ma and nd_xoa = false"
        dsNguoiDung = XLDuLieu.DocDuLieu(str)

        dgvDSNguoiDung.DataSource = dsNguoiDung
        dsTaiKhoan = XLDuLieu.DocCauTruc("Select * from TaiKhoan")

    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If String.IsNullOrEmpty(tbTenDangNhap.Text) Then
            MessageBox.Show("Ten dang nhap khong duoc rong", "Thong bao")
            Return
        Else
            Dim str As String = String.Format("Select * from TaiKhoan where tk_tendangnhap like '{0}'", tbTenDangNhap.Text)
            Dim dstk As DataTable = XLDuLieu.DocDuLieu(str)
            If dstk.Rows.Count > 0 Then
                MessageBox.Show("Ten dang nhap da ton tai", "Thong bao")
                Return
            End If
        End If

        Dim nguoi_dung As DataRow = dsNguoiDung.NewRow()
        nguoi_dung("nd_ten") = tbTen.Text
        nguoi_dung("nd_cmnd") = tbCMND.Text
        nguoi_dung("nd_dienthoai") = tbDienThoai.Text
        nguoi_dung("nd_ngaysinh") = dtpNgaySinh.Value
        nguoi_dung("nd_diachi") = tbDiaChi.Text
        nguoi_dung("nd_xoa") = False
        nguoi_dung("tk_tendangnhap") = tbTenDangNhap.Text
        nguoi_dung("tk_matkhau") = tbMatKhau.Text
        nguoi_dung("tk_xoa") = False

        dsNguoiDung.Rows.Add(nguoi_dung)
        XLDuLieu.GhiDuLieu("NguoiDung", dsNguoiDung)
        nguoi_dung("tk_manguoidung") = nguoi_dung("nd_ma")

        Dim tk As DataRow = dsTaiKhoan.NewRow()
        tk("tk_tendangnhap") = tbTenDangNhap.Text
        tk("tk_matkhau") = tbMatKhau.Text
        tk("tk_xoa") = False
        tk("tk_manguoidung") = nguoi_dung("nd_ma")
        dsTaiKhoan.Rows.Add(tk)
        XLDuLieu.GhiDuLieu("TaiKhoan", dsTaiKhoan)
        dsTaiKhoan.Rows.Remove(tk)
        nguoi_dung("tk_ma") = tk("tk_ma")
        dsTaiKhoan.Rows.Remove(tk)

    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        If dgvDSNguoiDung.SelectedCells.Count > 0 Then
            Dim ndv As DataRowView = dgvDSNguoiDung.Rows(dgvDSNguoiDung.SelectedCells(0).RowIndex).DataBoundItem
            Dim nguoi_dung As DataRow = ndv.Row
            nguoi_dung("nd_ten") = tbTen.Text
            nguoi_dung("nd_cmnd") = tbCMND.Text
            nguoi_dung("nd_dienthoai") = tbDienThoai.Text
            nguoi_dung("nd_ngaysinh") = dtpNgaySinh.Value
            nguoi_dung("nd_diachi") = tbDiaChi.Text
            nguoi_dung("tk_tendangnhap") = tbTenDangNhap.Text
            nguoi_dung("tk_matkhau") = tbMatKhau.Text

            XLDuLieu.GhiDuLieu("NguoiDung", dsNguoiDung)
            XLDuLieu.GhiDuLieu("TaiKhoan", dsTaiKhoan)
        End If
    End Sub

    Private Sub dgvDSNguoiDung_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDSNguoiDung.CellClick
        If dgvDSNguoiDung.SelectedCells.Count > 0 Then
            Dim ndv As DataRowView = dgvDSNguoiDung.Rows(dgvDSNguoiDung.SelectedCells(0).RowIndex).DataBoundItem
            Dim nguoi_dung As DataRow = ndv.Row
            tbTen.Text = nguoi_dung("nd_ten")
            tbCMND.Text = nguoi_dung("nd_cmnd")
            tbDienThoai.Text = nguoi_dung("nd_dienthoai")
            dtpNgaySinh.Value = nguoi_dung("nd_ngaysinh")
            tbDiaChi.Text = nguoi_dung("nd_diachi")
            tbTenDangNhap.Text = nguoi_dung("tk_tendangnhap")
            tbMatKhau.Text = nguoi_dung("tk_matkhau")
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If dgvDSNguoiDung.SelectedCells.Count > 0 Then
            Dim ndv As DataRowView = dgvDSNguoiDung.Rows(dgvDSNguoiDung.SelectedCells(0).RowIndex).DataBoundItem
            Dim nguoi_dung As DataRow = ndv.Row
            nguoi_dung("nd_xoa") = True

            XLDuLieu.GhiDuLieu("NguoiDung", dsNguoiDung)
            dsNguoiDung.Rows.Remove(nguoi_dung)
            XLDuLieu.GhiDuLieu("TaiKhoan", dsTaiKhoan)
        End If
    End Sub
End Class