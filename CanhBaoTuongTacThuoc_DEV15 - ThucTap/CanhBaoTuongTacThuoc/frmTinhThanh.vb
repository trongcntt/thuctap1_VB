Public Class frmTinhThanh
    Private objFcDMTinhThanh As New DMTinhThanhDA
    Private objEnTinhThanh As New DMTinhThanhEntity
    Private State As Byte
    Public Event _NextTT()
    Private objListParam As List(Of ReturnSQLEntity)
    Private objSql As New ReturnSQLDA



    Sub New(ByVal StateinSert As Byte)
        InitializeComponent()
        State = StateinSert
    End Sub

    Sub New(ByVal StateUpdate As Byte, ByVal Obj As DMTinhThanhEntity)
        InitializeComponent()
        State = StateUpdate
        objEnTinhThanh = Obj
        cbMaTT.Text = Obj.MaTinhThanh
        txtTenTT.Text = Obj.TenTinhThanh
        cbMaQuocGia.Text = Obj.MaQuocGia
        txtGhiChu.Text = Obj.GhiChu
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If String.IsNullOrEmpty(cbMaTT.Text) Then
            MsgBox("Mã tỉnh thành không được để trống!", MsgBoxStyle.Information, "Cảnh báo")
            cbMaTT.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(txtTenTT.Text) Then
            MsgBox("Tên tỉnh thành không được để trống!", MsgBoxStyle.Information, "Cảnh báo")
            txtTenTT.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(txtGhiChu.Text) Then
            MsgBox("Ghi Chú không được để trống!", MsgBoxStyle.Information, "Cảnh báo")
            txtGhiChu.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(cbMaQuocGia.Text) Then
            MsgBox("Mã quốc gia không được để trống!", MsgBoxStyle.Information, "Cảnh báo")
            cbMaQuocGia.Focus()
            Exit Sub
        End If
        objEnTinhThanh.MaTinhThanh = cbMaTT.Text
        objEnTinhThanh.TenTinhThanh = txtTenTT.Text
        objEnTinhThanh.GhiChu = txtGhiChu.Text
        objEnTinhThanh.MaQuocGia = cbMaQuocGia.Text
        Select Case State
            Case ADD_STATE
                If objFcDMTinhThanh.DMTinhThanh_SelectByID(objEnTinhThanh) IsNot Nothing Then
                    MsgBox("Trùng dữ liệu!", MsgBoxStyle.Information, "Thông báo")
                    Exit Sub
                End If
                objFcDMTinhThanh.DMTinhThanh_Insert(objEnTinhThanh)
                MsgBox("Thêm thành công!", MsgBoxStyle.Information, "Thông báo")
                ClearControl()
            Case UPDATE_STATE
                objFcDMTinhThanh.DMTinhThanh_Update(objEnTinhThanh)
                MsgBox("Cập nhật thành công!", MsgBoxStyle.Information, "Thông báo")
                'btnLuu.Enabled = False
        End Select
        RaiseEvent _NextTT()
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
    Private DropDown As Integer = 0
    Private Sub cbMaTT_KeyDown(sender As Object, e As KeyEventArgs) Handles cbMaTT.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Select Case DropDown
                Case 0
                    cbMaTT.ClosePopup()
                    DropDown = 1
                    Exit Select
                Case 1
                    cbMaTT.ShowPopup()
                    DropDown = 0
                    Exit Select
                Case Else
                    Exit Select
            End Select
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub cbMaQuocGia_KeyDown(sender As Object, e As KeyEventArgs) Handles cbMaQuocGia.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Select Case DropDown
                Case 0
                    cbMaQuocGia.ClosePopup()
                    DropDown = 1
                    Exit Select
                Case 1
                    cbMaQuocGia.ShowPopup()
                    DropDown = 0
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

    Private Sub frmTinhThanh_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.F2) Then
            btnLuu.PerformClick()
        End If
        If (e.KeyCode = Keys.Escape) Then
            btnDong.PerformClick()
        End If
    End Sub
End Class