Public Class MenuQLsv

    Private Sub btnQlsv_Click(sender As Object, e As EventArgs) Handles btnQlsv.Click
        ' Tạo đối tượng của Form khác

        If PanelControl1.Visible = False Then
            PanelControl1.Visible = True
        Else
            PanelControl1.Visible = False
        End If
    End Sub

    Private Sub btnGV_Click(sender As Object, e As EventArgs) Handles btnGV.Click
        Dim frm As New frmQuanLySinhVien()
        frm.grdCanhBaoDichVu.SelectedTabPageIndex = 0
        frm.Show()
    End Sub

    Private Sub btnLophoc_Click(sender As Object, e As EventArgs) Handles btnLophoc.Click
        Dim frm As New frmQuanLySinhVien()
        frm.grdCanhBaoDichVu.SelectedTabPageIndex = 1
        frm.Show()
    End Sub

    Private Sub btnSinhVien_Click(sender As Object, e As EventArgs) Handles btnSinhVien.Click
        Dim frm As New frmQuanLySinhVien()
        frm.grdCanhBaoDichVu.SelectedTabPageIndex = 2
        frm.Show()
    End Sub

    Private Sub btnNguoiDung_Click(sender As Object, e As EventArgs) Handles btnNguoiDung.Click
        Dim frm As New frmQuanLySinhVien()
        frm.grdCanhBaoDichVu.SelectedTabPageIndex = 3
        frm.Show()
    End Sub

    Private Sub btnTinhThanh_Click(sender As Object, e As EventArgs) Handles btnTinhThanh.Click
        Dim frm As New frmQuanLySinhVien()
        frm.grdCanhBaoDichVu.SelectedTabPageIndex = 4
        frm.Show()
    End Sub

    Private Sub btnQuanHuyen_Click(sender As Object, e As EventArgs) Handles btnQuanHuyen.Click
        Dim frm As New frmQuanLySinhVien()
        frm.grdCanhBaoDichVu.SelectedTabPageIndex = 5
        frm.Show()
    End Sub

    Private Sub btnXaPhuong_Click(sender As Object, e As EventArgs) Handles btnXaPhuong.Click
        Dim frm As New frmQuanLySinhVien()
        frm.grdCanhBaoDichVu.SelectedTabPageIndex = 6
        frm.Show()
    End Sub
End Class