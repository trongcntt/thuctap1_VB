Public Class frmGiaoVienn

    Private objFcDMGiaoVien As New DMGiaoVienDA
    Private objEnGiaoVien As New DMGiaoVienEntity
    Private State As Byte
    Public Event _Next()
    Private objListParam As List(Of ReturnSQLEntity)
    Private objSql As New ReturnSQLDA



    Sub New(ByVal StateinSert As Byte)
        InitializeComponent()
        State = StateinSert
    End Sub

    Sub New(ByVal StateUpdate As Byte, ByVal Obj As DMGiaoVienEntity)
        InitializeComponent()
        State = StateUpdate
        objEnGiaoVien = Obj
        cbMaGV.Text = Obj.MaGiaoVien
        txtTenGV.Text = Obj.TenGiaoVien
        txtGhiChu.Text = Obj.GhiChu
    End Sub

    Private Sub frmGiaoVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If State = ADD_STATE Then

        Else
            cbMaGV.Text = objEnGiaoVien.MaGiaoVien
            txtTenGV.Text = objEnGiaoVien.TenGiaoVien
            txtGhiChu.Text = objEnGiaoVien.GhiChu
        End If
    End Sub


    Private Sub ClearControl()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is DevExpress.XtraEditors.LookUpEdit Then
                TryCast(ctrl, DevExpress.XtraEditors.LookUpEdit).Text = Nothing
            End If
            If TypeOf ctrl Is DevExpress.XtraEditors.MemoEdit Then
                ctrl.Text = ""
            End If
        Next
    End Sub

    Private Sub btnLuu_Click_1(sender As Object, e As EventArgs) Handles btnLuu.Click
        If String.IsNullOrEmpty(cbMaGV.Text) Then
            MsgBox("Mã giáo viên không được để trống!", MsgBoxStyle.Information, "Cảnh báo")
            cbMaGV.Focus()
            Exit Sub
        End If
        If txtTenGV.Text.ToString = "" Or txtTenGV.Text Is Nothing Then
            MsgBox("Tên giáo viên không được để trống!", MsgBoxStyle.Information, "Cảnh báo")
            txtTenGV.Focus()
            Exit Sub
        End If
        objEnGiaoVien.MaGiaoVien = cbMaGV.Text
        objEnGiaoVien.TenGiaoVien = txtTenGV.Text
        objEnGiaoVien.GhiChu = txtGhiChu.Text
        Select Case State
            Case ADD_STATE
                If objFcDMGiaoVien.DMGiaoVien_SelectByID(objEnGiaoVien) IsNot Nothing Then
                    MsgBox("Trùng dữ liệu!", MsgBoxStyle.Information, "Thông báo")
                    Exit Sub
                End If
                objFcDMGiaoVien.DMGiaoVien_Insert(objEnGiaoVien)
                MsgBox("Thêm thành công!", MsgBoxStyle.Information, "Thông báo")
                ClearControl()
            Case UPDATE_STATE
                objFcDMGiaoVien.DMGiaoVien_Update(objEnGiaoVien)
                MsgBox("Cập nhật thành công!", MsgBoxStyle.Information, "Thông báo")
                'btnLuu.Enabled = False
        End Select
        RaiseEvent _Next()
    End Sub

    Private Sub btnDong_Click_1(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

    Private Sub btnLuu_KeyDown(sender As Object, e As KeyEventArgs) Handles btnLuu.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnLuu.PerformClick()
        End If
    End Sub

    Private Sub btnDong_KeyDown(sender As Object, e As KeyEventArgs) Handles btnDong.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnDong.PerformClick()
        End If
    End Sub

    Private droppDown As Integer = 0

    Private Sub cbMaGV_KeyDown(sender As Object, e As KeyEventArgs) Handles cbMaGV.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Select Case droppDown
                Case 0
                    cbMaGV.DroppedDown = False
                    droppDown = 1
                    Exit Select
                Case 1
                    cbMaGV.DroppedDown = True
                    droppDown = 0
                    Exit Select
                Case Else
                    Exit Select
            End Select
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtGhiChu_KeyDown(sender As Object, e As KeyEventArgs) Handles txtGhiChu.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnLuu.PerformClick()
        End If
    End Sub

    Private Sub frmGiaoVienn_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.F2) Then
            btnLuu.PerformClick()
        End If
        If (e.KeyCode = Keys.Escape) Then
            btnDong.PerformClick()
        End If
    End Sub
End Class