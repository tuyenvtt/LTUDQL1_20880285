Public Class frmLoaiMonAn
    Dim dsLoaiMonAn As DataTable
    Private Sub frmLoaiMonAn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbHienThiXoa.Checked = False
        DocDSLoaiMonAn(cbHienThiXoa.Checked)
    End Sub

    Private Sub DocDSLoaiMonAn(ByVal xoa As Boolean)
        Dim sql As String = String.Format("Select * from LoaiMonAn where lma_xoa = false order by lma_ten")
        If xoa Then
            sql = String.Format("Select * from LoaiMonAn order by lma_ten")
        End If
        dsLoaiMonAn = XLDuLieu.DocDuLieu(sql)
        lbDanhSach.Items.Clear()

        For Each lma In dsLoaiMonAn.Rows
            If lma("lma_xoa") Then
                lbDanhSach.Items.Add(lma("lma_ten") + "- xoa")
            Else
                lbDanhSach.Items.Add(lma("lma_ten"))
            End If
        Next
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim loai_mon_an As DataRow = dsLoaiMonAn.NewRow()
        loai_mon_an("lma_ten") = tbTen.Text

        dsLoaiMonAn.Rows.Add(loai_mon_an)
        XLDuLieu.GhiDuLieu("LoaiMonAn", dsLoaiMonAn)

        DocDSLoaiMonAn(cbHienThiXoa.Checked)
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        If lbDanhSach.SelectedIndex >= 0 Then
            Dim loai_mon_an As DataRow = dsLoaiMonAn.Rows(lbDanhSach.SelectedIndex)
            loai_mon_an("lma_ten") = tbTen.Text
            XLDuLieu.GhiDuLieu("LoaiMonAn", dsLoaiMonAn)

            'lbDanhSach.Items(lbDanhSach.SelectedIndex) = tbTen.Text
            DocDSLoaiMonAn(cbHienThiXoa.Checked)

        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If lbDanhSach.SelectedIndex >= 0 Then
            Dim loai_mon_an As DataRow = dsLoaiMonAn.Rows(lbDanhSach.SelectedIndex)
            loai_mon_an("lma_xoa") = True
            XLDuLieu.GhiDuLieu("LoaiMonAn", dsLoaiMonAn)

            'dsLoaiMonAn.Rows.RemoveAt(lbDanhSach.SelectedIndex)
            'lbDanhSach.Items.RemoveAt(lbDanhSach.SelectedIndex)
            DocDSLoaiMonAn(cbHienThiXoa.Checked)

        End If
    End Sub

    Private Sub lbDanhSach_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbDanhSach.SelectedIndexChanged
        If lbDanhSach.SelectedIndex >= 0 Then
            Dim loai_mon_an As DataRow = dsLoaiMonAn.Rows(lbDanhSach.SelectedIndex)
            tbTen.Text = loai_mon_an("lma_ten")
            If loai_mon_an("lma_xoa") Then
                btnKhoiPhuc.Enabled = True
            Else
                btnKhoiPhuc.Enabled = False
            End If
        End If
    End Sub

    Private Sub cbHienThiXoa_CheckedChanged(sender As Object, e As EventArgs) Handles cbHienThiXoa.CheckedChanged
        DocDSLoaiMonAn(cbHienThiXoa.Checked)

    End Sub

    Private Sub btnKhoiPhuc_Click(sender As Object, e As EventArgs) Handles btnKhoiPhuc.Click
        If lbDanhSach.SelectedIndex >= 0 Then
            Dim loai_mon_an As DataRow = dsLoaiMonAn.Rows(lbDanhSach.SelectedIndex)
            loai_mon_an("lma_xoa") = False
            XLDuLieu.GhiDuLieu("LoaiMonAn", dsLoaiMonAn)

            'dsLoaiMonAn.Rows.RemoveAt(lbDanhSach.SelectedIndex)
            'lbDanhSach.Items.RemoveAt(lbDanhSach.SelectedIndex)
            DocDSLoaiMonAn(cbHienThiXoa.Checked)

        End If
    End Sub
End Class