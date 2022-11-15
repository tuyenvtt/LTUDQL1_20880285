Public Class frmMenu
    Dim dsMenu As DataTable
    Dim dsMonAn As DataTable
    Dim ma_menu As Integer
    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DocDSMenu(cbHienThiXoa.Checked)
    End Sub

    Private Sub DocDSMenu(ByVal xoa As Boolean)
        Dim sql As String = String.Format("Select mn_ma, mn_ten, mn_mota, mn_xoa from Menu where mn_xoa = false")
        If xoa Then
            sql = String.Format("Select mn_ma, mn_ten, mn_mota, mn_xoa from Menu")
        End If
        dsMenu = XLDuLieu.DocDuLieu(sql)
        dgvDSMenu.DataSource = dsMenu

    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim menu As DataRow = dsMenu.NewRow()
        menu("mn_ten") = tbTen.Text
        menu("mn_mota") = tbMoTa.Text

        dsMenu.Rows.Add(menu)
        XLDuLieu.GhiDuLieu("Menu", dsMenu)
        DocDSMenu(cbHienThiXoa.Checked)
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        If dgvDSMenu.SelectedCells.Count > 0 Then
            Dim mnv As DataRowView = dgvDSMenu.Rows(dgvDSMenu.SelectedCells(0).RowIndex).DataBoundItem
            Dim mn As DataRow = mnv.Row
            mn("mn_ten") = tbTen.Text
            mn("mn_mota") = tbMoTa.Text

            XLDuLieu.GhiDuLieu("Menu", dsMenu)
            DocDSMenu(cbHienThiXoa.Checked)
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If dgvDSMenu.SelectedCells.Count > 0 Then
            Dim mnv As DataRowView = dgvDSMenu.Rows(dgvDSMenu.SelectedCells(0).RowIndex).DataBoundItem
            Dim mn As DataRow = mnv.Row
            mn("mn_xoa") = True

            XLDuLieu.GhiDuLieu("Menu", dsMenu)
            DocDSMenu(cbHienThiXoa.Checked)
        End If
    End Sub

    Private Sub cbHienThiXoa_CheckedChanged(sender As Object, e As EventArgs) Handles cbHienThiXoa.CheckedChanged
        DocDSMenu(cbHienThiXoa.Checked)

    End Sub

    Private Sub dgvDSMenu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDSMenu.CellClick
        If dgvDSMenu.SelectedCells.Count > 0 Then
            Dim menuview As DataRowView = dgvDSMenu.Rows(dgvDSMenu.SelectedCells(0).RowIndex).DataBoundItem
            Dim mn As DataRow = menuview.Row
            tbTen.Text = mn("mn_ten")
            tbMoTa.Text = ""
            If Not IsDBNull(mn("mn_mota")) Then
                tbMoTa.Text = mn("mn_mota")
            End If

            DocChiTietMenu(mn("mn_ma"))
        End If
    End Sub

    Private Sub DocChiTietMenu(ByVal ma_menu As Integer)
        Dim sql As String = String.Format("Select mct_ma, ma_ten, mct_gia, mct_mamenu, mct_mamonan from MenuChiTiet, MonAn where ma_ma = mct_mamonan and mct_mamenu = {0}", ma_menu)

        dsMonAn = XLDuLieu.DocDuLieu(sql)
        dgvDSMonAn.DataSource = dsMonAn
        dgvDSMonAn.Columns(0).Visible = False
        dgvDSMonAn.Columns(3).Visible = False
        dgvDSMonAn.Columns(4).Visible = False

    End Sub

    Private Sub btnXoaMonAn_Click(sender As Object, e As EventArgs) Handles btnXoaMonAn.Click
        If dgvDSMenu.SelectedCells.Count > 0 Then
            Dim mon_an_view As DataRowView = dgvDSMenu.Rows(dgvDSMenu.SelectedCells(0).RowIndex).DataBoundItem
            Dim mon_an As DataRow = mon_an_view.Row
            mon_an.Delete()
            XLDuLieu.GhiDuLieu("MenuChiTiet", dsMonAn)

        End If
    End Sub

    Private Sub btnThemMonAn_Click(sender As Object, e As EventArgs) Handles btnThemMonAn.Click
        Dim frm As frmMenuChiTietThem = New frmMenuChiTietThem()

        Dim dr As DialogResult = frm.ShowDialog()
        If dr = DialogResult.OK Then
            For Each mon_an In frm.dsMonAnDuocChon.Rows
                If KiemTraMonAnTonTai(mon_an("ma_ma")) Then
                    Dim chi_tiet As DataRow = dsMonAn.NewRow

                    chi_tiet("ma_ten") = mon_an("ma_ten")
                    chi_tiet("mct_gia") = mon_an("ma_gia")
                    chi_tiet("mct_mamenu") = ma_menu
                    chi_tiet("mct_mamonan") = mon_an("ma_ma")
                    dsMonAn.Rows.Add(chi_tiet)


                End If
            Next
            XLDuLieu.GhiDuLieu("MenuChiTiet", dsMonAn)

        Else
            MessageBox.Show("Cancel")

        End If

    End Sub

    Private Function KiemTraMonAnTonTai(ByVal ma_mon_an As Integer)
        Dim ket_qua As Boolean = True
        For Each mon_an In dsMonAn.Rows
            If mon_an("mct_mamonan") = ma_mon_an Then
                ket_qua = False
                Exit For
            End If
        Next
        Return ket_qua

    End Function


End Class