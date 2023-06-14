Public Class frmLopHoc
    Private objFcDMLopHoc As New DMLopHocDA
    Private objEnLopHoc As New DMLopHocEntity
    Private State As Byte
    Public Event _Nextlh()
    Private objListParam As List(Of ReturnSQLEntity)
    Private objSql As New ReturnSQLDA



    Sub New(ByVal StateinSert As Byte)
        InitializeComponent()
        State = StateinSert
    End Sub

    Sub New(ByVal StateUpdate As Byte, ByVal Obj As DMLopHocEntity)
        InitializeComponent()
        State = StateUpdate
        objEnLopHoc = Obj
        cbMaLop.Text = Obj.MaLop
        txtTenLop.Text = Obj.TenLop
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If String.IsNullOrEmpty(txtTenLop.Text) Then
            MsgBox("Mã lớp không được để trống!", MsgBoxStyle.Information, "Cảnh báo")
            cbMaLop.Focus()
            Exit Sub
        End If
        If txtTenLop.Text.ToString = "" Or txtTenLop.Text Is Nothing Then
            MsgBox("Tên Lớp không được để trống!", MsgBoxStyle.Information, "Cảnh báo")
            txtTenLop.Focus()
            Exit Sub
        End If
        objEnLopHoc.MaLop = cbMaLop.Text
        objEnLopHoc.TenLop = txtTenLop.Text
        objEnLopHoc.GhiChu = txtGhiChu.Text
        Select Case State
            Case ADD_STATE
                If objFcDMLopHoc.DMLopHoc_SelectByID(objEnLopHoc) IsNot Nothing Then
                    MsgBox("Trùng dữ liệu!", MsgBoxStyle.Information, "Thông báo")
                    Exit Sub
                End If
                objFcDMLopHoc.DMlopHoc_Insert(objEnLopHoc)
                MsgBox("Thêm thành công!", MsgBoxStyle.Information, "Thông báo")
                ClearControl()
            Case UPDATE_STATE
                objFcDMLopHoc.DMLopHoc_Update(objEnLopHoc)
                MsgBox("Cập nhật thành công!", MsgBoxStyle.Information, "Thông báo")
                'btnLuu.Enabled = False
        End Select
        RaiseEvent _Nextlh()

    End Sub


    Private Sub frmCapNhatDMCanhBaoThuoc_Load(sender As Object, e As EventArgs) Handles Me.Load

        If State = ADD_STATE Then

        Else
            cbMaLop.Text = objEnLopHoc.MaLop
            txtTenLop.Text = objEnLopHoc.TenLop
            txtGhiChu.Text = objEnLopHoc.GhiChu
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
    Private DropDown As Integer
    Private Sub cbMaLop_KeyDown(sender As Object, e As KeyEventArgs) Handles cbMaLop.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Select Case DropDown
                Case 0
                    cbMaLop.DroppedDown = False
                    DropDown = 1
                    Exit Select
                Case 1
                    cbMaLop.DroppedDown = True
                    DropDown = 0
                    Exit Select
                Case Else
                    Exit Select
            End Select
            e.Handled = True
            e.SuppressKeyPress = True
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

    Private Sub txtGhiChu_KeyDown(sender As Object, e As KeyEventArgs) Handles txtGhiChu.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnLuu.PerformClick()
        End If
    End Sub

    Private Sub frmLopHoc_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.F2) Then
            btnLuu.PerformClick()
        End If
        If (e.KeyCode = Keys.Escape) Then
            btnLuu.PerformClick()
        End If
    End Sub
End Class