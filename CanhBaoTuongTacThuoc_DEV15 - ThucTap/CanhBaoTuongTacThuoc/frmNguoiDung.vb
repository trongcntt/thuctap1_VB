Public Class frmNguoiDung
    Private objFcDMNguoiDung As New DMNguoiDungDA
    Private objEnNguoiDung As New DMNguoiDungEntity
    Private State As Byte
    Public Event _NextND()
    Private objListParam As List(Of ReturnSQLEntity)
    Private objSql As New ReturnSQLDA



    Sub New(ByVal StateinSert As Byte)
        InitializeComponent()
        State = StateinSert
    End Sub

    Sub New(ByVal StateUpdate As Byte, ByVal Obj As DMNguoiDungEntity)
        InitializeComponent()
        State = StateUpdate
        objEnNguoiDung = Obj
        txtMaND.Text = Obj.MaNguoiDung
        txtTenND.Text = Obj.TenNguoiDung
        txtMatKhau.Text = Obj.MatKhau
    End Sub

    Private Sub frmNguoiDung_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If State = ADD_STATE Then

        Else
            txtMaND.Text = objEnNguoiDung.MaNguoiDung
            txtTenND.Text = objEnNguoiDung.TenNguoiDung
            txtMatKhau.Text = objEnNguoiDung.MatKhau
        End If
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If String.IsNullOrEmpty(txtMaND.Text) Then
            MsgBox("Mã Người dùng không được để trống!", MsgBoxStyle.Information, "Cảnh báo")
            txtMaND.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(txtTenND.Text) Then
            MsgBox("Tên Người dùng không được để trống!", MsgBoxStyle.Information, "Cảnh báo")
            txtTenND.Focus()
            Exit Sub
        End If
        If txtMatKhau.Text.ToString = "" Or txtMatKhau.Text Is Nothing Then
            MsgBox("Mật khẩu không được để trống!", MsgBoxStyle.Information, "Cảnh báo")
            txtMatKhau.Focus()
            Exit Sub
        End If
        objEnNguoiDung.MaNguoiDung = txtMaND.Text
        objEnNguoiDung.TenNguoiDung = txtTenND.Text
        objEnNguoiDung.MatKhau = txtMatKhau.Text
        Select Case State
            Case ADD_STATE
                If objFcDMNguoiDung.DMNguoiDung_SelectByID(objEnNguoiDung) IsNot Nothing Then
                    MsgBox("Trùng dữ liệu!", MsgBoxStyle.Information, "Thông báo")
                    Exit Sub
                End If
                objFcDMNguoiDung.DMNguoiDung_Insert(objEnNguoiDung)
                MsgBox("Thêm thành công!", MsgBoxStyle.Information, "Thông báo")
                ClearControl()
            Case UPDATE_STATE
                objFcDMNguoiDung.DMNguoiDung_Update(objEnNguoiDung)
                MsgBox("Cập nhật thành công!", MsgBoxStyle.Information, "Thông báo")
                'btnLuu.Enabled = False
        End Select
        RaiseEvent _NextND()
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub
    '  Private Sub frmCapNhatDMCanhBaoThuoc_Load(sender As Object, e As EventArgs) Handles Me.Load

    '  If State = ADD_STATE Then

    'Else
    '       txtMaND.Text = objEnNguoiDung.MaNguoiDung
    '       txtTenND.Text = objEnNguoiDung.TenNguoiDung
    '      txtMatKhau.Text = objEnNguoiDung.MatKhau
    'End If
    ' End Sub
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

    Private Sub txtMatKhau_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMatKhau.KeyDown
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

    Private Sub frmNguoiDung_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.F2) Then
            btnLuu.PerformClick()
        End If
        If (e.KeyCode = Keys.Escape) Then
            btnDong.PerformClick()
        End If
    End Sub
End Class