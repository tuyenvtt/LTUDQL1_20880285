Public Class FrmDangNhap
    Dim so_lan As Integer
    Public tai_khoan As DataRow
    Public dsChiNhanh As DataTable

    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        Dim str As String = "Select * from TaiKhoan where tk_xoa = false"
        Dim dstk As DataTable = XLDuLieu.DocDuLieu(str)
        If dstk.Rows.Count > 0 Then
            If dstk.Rows(0)("tk_matkhau") = tbMatKhau.Text Then
                str = "Select tk_tendangnhap, tk_ma, nd_ma, nd_ten from TaiKhoan, NguoiDung where tk_manguoidung = nd_ma and tk_tendangnhap like '" + tbTenDangNhap.Text + "'"
                dstk = XLDuLieu.DocDuLieu(str)

                tai_khoan = dstk.Rows(0)
                str = "Select ChiNhanh.*, ndcn_ngayapdung from NguoiDungChiNhanh, ChiNhanh where ndcn_machinhanh = cn_ma and ndcn_xoa = false"
                dsChiNhanh = XLDuLieu.DocDuLieu(str)

                btnDangNhap.DialogResult = DialogResult.Yes
                Return
            End If

            so_lan = so_lan + 1
            MessageBox.Show("Sai ten/mat khau")
            If so_lan = 5 Then
                Me.Close()
            End If
        End If
    End Sub
End Class