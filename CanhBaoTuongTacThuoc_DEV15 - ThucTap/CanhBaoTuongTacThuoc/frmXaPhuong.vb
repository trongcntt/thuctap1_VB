Public Class frmXaPhuong
    Private objFcDMXaPhuong As New DMXaPhuongDA
    Private objEnXaPhuong As New DMXaPhuongEntity
    Private State As Byte
    Public Event _NextXP()
    Private objListParam As List(Of ReturnSQLEntity)
    Private objSql As New ReturnSQLDA



    Sub New(ByVal StateinSert As Byte)
        InitializeComponent()
        State = StateinSert
    End Sub

    Sub New(ByVal StateUpdate As Byte, ByVal Obj As DMXaPhuongEntity)
        InitializeComponent()
        State = StateUpdate
        objEnXaPhuong = Obj
        cbMaXa.Text = Obj.MaXa
        txtTenXa.Text = Obj.TenXa
        txtMoTa.Text = Obj.MoTaThonXa
        cbMaQH.Text = Obj.MaQuanHuyen
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If String.IsNullOrEmpty(cbMaXa.Text) Then
            MsgBox("Mã xã không được để trống!", MsgBoxStyle.Information, "Cảnh báo")
            cbMaXa.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(txtTenXa.Text) Then
            MsgBox("Tên xã dùng không được để trống!", MsgBoxStyle.Information, "Cảnh báo")
            txtTenXa.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(txtMoTa.Text) Then
            MsgBox("Mô tả không được để trống!", MsgBoxStyle.Information, "Cảnh báo")
            txtMoTa.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(cbMaQH.Text) Then
            MsgBox("Mã Quốc gia không được để trống!", MsgBoxStyle.Information, "Cảnh báo")
            cbMaQH.Focus()
            Exit Sub
        End If
        objEnXaPhuong.MaXa = cbMaXa.Text
        objEnXaPhuong.TenXa = txtTenXa.Text
        objEnXaPhuong.MaQuanHuyen = cbMaQH.Text
        objEnXaPhuong.MoTaThonXa = txtMoTa.Text
        Select Case State
            Case ADD_STATE
                If objFcDMXaPhuong.DMXaPhuong_SelectByID(objEnXaPhuong) IsNot Nothing Then
                    MsgBox("Trùng dữ liệu!", MsgBoxStyle.Information, "Thông báo")
                    Exit Sub
                End If
                objFcDMXaPhuong.DMXaPhuong_Insert(objEnXaPhuong)
                MsgBox("Thêm thành công!", MsgBoxStyle.Information, "Thông báo")
                ClearControl()
            Case UPDATE_STATE
                objFcDMXaPhuong.DMXaPhuong_Update(objEnXaPhuong)
                MsgBox("Cập nhật thành công!", MsgBoxStyle.Information, "Thông báo")
                'btnLuu.Enabled = False
        End Select
        RaiseEvent _NextXP()
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

    Private Sub txtMoTa_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMoTa.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnLuu.PerformClick()
        End If
    End Sub
    Private DropDown As Integer = 0
    Private Sub cbMaXa_KeyDown(sender As Object, e As KeyEventArgs) Handles cbMaXa.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Select Case DropDown
                Case 0
                    cbMaXa.ClosePopup()
                    DropDown = 1
                    Exit Select
                Case 1
                    cbMaXa.ShowPopup()
                    DropDown = 0
                    Exit Select
                Case Else
                    Exit Select
            End Select
        End If
        e.Handled = True
        e.SuppressKeyPress = True
    End Sub

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
        End If
        e.Handled = True
        e.SuppressKeyPress = True
    End Sub

    Private Sub frmXaPhuong_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            btnDong.PerformClick()
        End If
        If (e.KeyCode = Keys.F2) Then
            btnLuu.PerformClick()
        End If
    End Sub
End Class