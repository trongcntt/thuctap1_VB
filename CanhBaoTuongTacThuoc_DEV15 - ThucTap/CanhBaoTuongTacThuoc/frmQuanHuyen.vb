Public Class frmQuanHuyen

    Private objFcDMQuanHuyen As New DMQuanHuyenDA
    Private objEnQuanHuyen As New DMQuanHuyenEntity
    Private State As Byte
    Public Event _NextQH()
    Private objListParam As List(Of ReturnSQLEntity)
    Private objSql As New ReturnSQLDA

    Private Sub frmQuanHuyen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If State = ADD_STATE Then

        Else
            cbMaQH.Text = objEnQuanHuyen.MaQuanHuyen
            txtTenQH.Text = objEnQuanHuyen.TenQuanHuyen
            'cbMaQHBH.Text = objEnQuanHuyen.MaQuanHuyen_BH
            txtGhiChu.Text = objEnQuanHuyen.GhiChu
            cbMaTT.Text = objEnQuanHuyen.MaTinhThanh

        End If
    End Sub

    Sub New(ByVal StateinSert As Byte)
        InitializeComponent()
        State = StateinSert
    End Sub

    Sub New(ByVal StateUpdate As Byte, ByVal Obj As DMQuanHuyenEntity)
        InitializeComponent()
        State = StateUpdate
        objEnQuanHuyen = Obj
        cbMaQH.Text = Obj.MaQuanHuyen
        txtTenQH.Text = Obj.TenQuanHuyen
        txtGhiChu.Text = Obj.GhiChu
        cbMaTT.Text = Obj.MaTinhThanh
        'cbMaQHBH.Text = Obj.MaQuanHuyen_BH
    End Sub




    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

    Private Sub btnLuuQH_Click(sender As Object, e As EventArgs) Handles btnLuuQH.Click
        If String.IsNullOrEmpty(cbMaQH.Text) Then
            MsgBox("Mã quận huyện không được để trống!", MsgBoxStyle.Information, "Cảnh báo")
            cbMaQH.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(txtTenQH.Text) Then
            MsgBox("Tên quận huyện không được để trống!", MsgBoxStyle.Information, "Cảnh báo")
            txtTenQH.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(cbMaTT.Text) Then
            MsgBox("Mã tỉnh thành không được để trống!", MsgBoxStyle.Information, "Cảnh báo")
            cbMaTT.Focus()
            Exit Sub
        End If
        objEnQuanHuyen.MaQuanHuyen = cbMaQH.Text
        objEnQuanHuyen.TenQuanHuyen = txtTenQH.Text
        objEnQuanHuyen.MaTinhThanh = cbMaTT.Text
        objEnQuanHuyen.GhiChu = txtGhiChu.Text
        Select Case State
            Case ADD_STATE
                If objFcDMQuanHuyen.DMQuanHuyen_SelectByID(objEnQuanHuyen) IsNot Nothing Then
                    MsgBox("Trùng dữ liệu!", MsgBoxStyle.Information, "Thông báo")
                    Exit Sub
                End If
                objFcDMQuanHuyen.DMQuanHuyen_Insert(objEnQuanHuyen)
                MsgBox("Thêm thành công!", MsgBoxStyle.Information, "Thông báo")
                ClearControl()
            Case UPDATE_STATE
                objFcDMQuanHuyen.DMQuanHuyen_Update(objEnQuanHuyen)
                MsgBox("Cập nhật thành công!", MsgBoxStyle.Information, "Thông báo")
                'btnLuu.Enabled = False
        End Select
        RaiseEvent _NextQH()
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
    Private Sub cbMaQH_KeyDown(sender As Object, e As KeyEventArgs) Handles cbMaQH.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Select Case DropDown
                Case 0
                    cbMaQH.ClosePopup()
                    DropDown = 1
                    Exit Select
                Case 1
                    cbMaQH.ShowPopup()
                    DropDown = 0
                    Exit Select
                Case Else
                    Exit Select
            End Select
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

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

    Private Sub txtGhiChu_KeyDown(sender As Object, e As KeyEventArgs) Handles txtGhiChu.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnLuuQH.PerformClick()
        End If
    End Sub

    Private Sub btnLuuQH_KeyDown(sender As Object, e As KeyEventArgs) Handles btnLuuQH.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnLuuQH.PerformClick()
        End If
    End Sub

    Private Sub btnDong_KeyDown(sender As Object, e As KeyEventArgs) Handles btnDong.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnDong.PerformClick()
        End If
    End Sub

    Private Sub frmQuanHuyen_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.F2) Then
            btnLuuQH.PerformClick()
        End If
        If (e.KeyCode = Keys.Escape) Then
            btnDong.PerformClick()
        End If
    End Sub
End Class