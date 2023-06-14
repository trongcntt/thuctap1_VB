Imports System.Data.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class frmSinhVien
    Private objFcSinhVien As New DMSinhVienDA
    Private objEnSinhVien As New DMSinhVienEntity
    Private State As Byte
    Public Event _Nextsv()
    Private objListParam As List(Of ReturnSQLEntity)
    Private objSql As New ReturnSQLDA

    Sub New(ByVal StateinSert As Byte)
        InitializeComponent()
        State = StateinSert
    End Sub

    Sub New(ByVal StateUpdate As Byte, ByVal Obj As DMSinhVienEntity)
        InitializeComponent()
        State = StateUpdate
        objEnSinhVien = Obj
        cbMaLop.Text = Obj.MaLop
        txtMaSV.Text = Obj.MaSinhVien
        txtTenSV.Text = Obj.TenSinhVien
        cbMaGV.Text = Obj.MaGiaoVien
        txtNamsinh.Text = Obj.NamSinh
        cbGioiTinh.Text = Obj.GioiTinh
        cbTT.Text = Obj.MaTinhThanh
        cbQH.Text = Obj.MaQuanHuyen
        cbXP.Text = Obj.MaXaPhuong
    End Sub

    Private Sub btnDongSV_Click(sender As Object, e As EventArgs) Handles btnDongSV.Click
        Me.Close()
    End Sub

    Private Sub btnLuuSV_Click(sender As Object, e As EventArgs) Handles btnLuuSV.Click
        If String.IsNullOrEmpty(txtMaSV.Text) Then
            MsgBox("Mã sinh viên không được để trống!", MsgBoxStyle.Information, "Cảnh báo")
            txtMaSV.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(cbMaGV.Text) Then
            MsgBox("Mã giáo viên không được để trống!", MsgBoxStyle.Information, "Cảnh báo")
            cbMaGV.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(cbMaLop.Text) Then
            MsgBox("Mã lớp không được để trống!", MsgBoxStyle.Information, "Cảnh báo")
            cbMaLop.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(cbQH.Text) Then
            MsgBox("quận huyện không được để trống!", MsgBoxStyle.Information, "Cảnh báo")
            cbQH.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(txtNamsinh.Text) Then
            MsgBox("năm sinh không được để trống!", MsgBoxStyle.Information, "Cảnh báo")
            txtNamsinh.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(cbTT.Text) Then
            MsgBox("Tỉnh thành không được để trống!", MsgBoxStyle.Information, "Cảnh báo")
            cbTT.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(cbXP.Text) Then
            MsgBox("năm sinh không được để trống!", MsgBoxStyle.Information, "Cảnh báo")
            cbXP.Focus()
            Exit Sub
        End If
        If txtTenSV.Text.ToString = "" Or txtTenSV.Text Is Nothing Then
            MsgBox("Tên sinh viên không được để trống!", MsgBoxStyle.Information, "Cảnh báo")
            txtTenSV.Focus()
            Exit Sub
        End If
        objEnSinhVien.MaLop = cbMaLop.Text
        objEnSinhVien.MaSinhVien = txtMaSV.Text
        objEnSinhVien.MaGiaoVien = cbMaGV.Text
        objEnSinhVien.TenSinhVien = txtTenSV.Text
        objEnSinhVien.NamSinh = txtNamsinh.Text
        objEnSinhVien.GioiTinh = cbGioiTinh.Text
        objEnSinhVien.MaTinhThanh = cbTT.Text
        objEnSinhVien.MaQuanHuyen = cbQH.Text
        objEnSinhVien.MaXaPhuong = cbXP.Text
        Select Case State
            Case ADD_STATE
                If objFcSinhVien.DMSinhVien_SelectByID(objEnSinhVien) IsNot Nothing Then
                    MsgBox("Trùng dữ liệu!", MsgBoxStyle.Information, "Thông báo")
                    Exit Sub
                End If
                objFcSinhVien.DMSinhVien_Insert(objEnSinhVien)
                MsgBox("Thêm thành công!", MsgBoxStyle.Information, "Thông báo")
                ClearControl()
            Case UPDATE_STATE
                objFcSinhVien.DMSinhVien_Update(objEnSinhVien)
                MsgBox("Cập nhật thành công!", MsgBoxStyle.Information, "Thông báo")
                'btnLuu.Enabled = False
        End Select
        RaiseEvent _Nextsv()
    End Sub
    Private Sub frmCapNhatDMCanhBaoThuoc_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'NanoThucTapDataSet.tinh' table. You can move, or remove it, as needed.
        Me.TinhTableAdapter.Fill(Me.NanoThucTapDataSet.tinh)
        loadTinh()
        If State = ADD_STATE Then

        Else
            objEnSinhVien.MaLop = cbMaLop.Text
            objEnSinhVien.MaSinhVien = txtMaSV.Text
            objEnSinhVien.MaGiaoVien = cbMaGV.Text
            objEnSinhVien.TenSinhVien = txtTenSV.Text
            objEnSinhVien.NamSinh = txtNamsinh.Text
            objEnSinhVien.GioiTinh = cbGioiTinh.Text
            objEnSinhVien.MaTinhThanh = cbTT.Text
            objEnSinhVien.MaQuanHuyen = cbQH.Text
            objEnSinhVien.MaXaPhuong = cbXP.Text
        End If

    End Sub

    Private Sub loadTinh()
        Dim ChuoiKetNoi As String = "Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=NanoThucTap;Integrated Security=True"
        Dim db As Database
        Dim objCmd As DbCommand
        Dim ds As DataSet = Nothing

        db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
        objCmd = db.GetSqlStringCommand("select TenTT from tinh")

        Using reader As IDataReader = db.ExecuteReader(objCmd)
            While reader.Read()
                cbTT.Items.Add(reader("TenTT").ToString())
            End While
        End Using

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

    Private Sub btnLuuSV_KeyDown(sender As Object, e As KeyEventArgs) Handles btnLuuSV.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnLuuSV.PerformClick()
        End If
    End Sub

    Private Sub btnDongSV_KeyDown(sender As Object, e As KeyEventArgs) Handles btnDongSV.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnDongSV.PerformClick()
        End If
    End Sub

    Private Sub cbXP_KeyDown(sender As Object, e As KeyEventArgs)
        If (e.KeyCode = Keys.Enter) Then
            btnLuuSV.PerformClick()
        End If
    End Sub
    Private DropDown As Integer = 0
    Private Sub cbMaLop_KeyDown(sender As Object, e As KeyEventArgs) Handles cbMaLop.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Select Case DropDown
                Case 0
                    cbMaLop.ClosePopup()
                    DropDown = 1
                    Exit Select
                Case 1
                    cbMaLop.ShowPopup()
                    DropDown = 0
                    Exit Select
                Case Else
                    Exit Select
            End Select
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub cbMaGV_KeyDown(sender As Object, e As KeyEventArgs) Handles cbMaGV.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Select Case DropDown
                Case 0
                    cbMaGV.ClosePopup()
                    DropDown = 1
                    Exit Select
                Case 1
                    cbMaGV.ShowPopup()
                    DropDown = 0
                    Exit Select
                Case Else
                    Exit Select
            End Select
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub cbGioiTinh_KeyDown(sender As Object, e As KeyEventArgs) Handles cbGioiTinh.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Select Case DropDown
                Case 0
                    cbGioiTinh.ClosePopup()
                    DropDown = 1
                    Exit Select
                Case 1
                    cbGioiTinh.ShowPopup()
                    DropDown = 0
                    Exit Select
                Case Else
                    Exit Select
            End Select
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub cbTT_KeyDown(sender As Object, e As KeyEventArgs) Handles cbTT.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Select Case DropDown
                Case 0
                    cbTT.DroppedDown = False
                    DropDown = 1
                    Exit Select
                Case 1
                    cbTT.DroppedDown = True
                    DropDown = 0
                    Exit Select
                Case Else
                    Exit Select
            End Select
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub cbXP_KeyDown_1(sender As Object, e As KeyEventArgs) Handles cbXP.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Select Case DropDown
                Case 0
                    cbXP.DroppedDown = False
                    DropDown = 1
                    Exit Select
                Case 1
                    cbXP.DroppedDown = True
                    DropDown = 0
                    Exit Select
                Case Else
                    Exit Select
            End Select
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub cbTT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTT.SelectedIndexChanged
        Dim ChuoiKetNoi As String = "Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=NanoThucTap;Integrated Security=True"
        Dim db As Database
        Dim objCmd As DbCommand
        Dim ds As DataSet = Nothing

        db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
        objCmd = db.GetStoredProcCommand("GetHuyenByTinh")
        db.AddInParameter(objCmd, "@TenTT", DbType.String, cbTT.Text)
        cbQH.Items.Clear() ' Xóa tất cả các item cũ trước khi thêm mới

        Using reader As IDataReader = db.ExecuteReader(objCmd)
            While reader.Read()
                cbQH.Items.Add(reader("TenQH").ToString())
            End While
        End Using

    End Sub

    Private Sub cbQH_KeyDown_1(sender As Object, e As KeyEventArgs) Handles cbQH.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Select Case DropDown
                Case 0
                    cbQH.DroppedDown = False
                    DropDown = 1
                    Exit Select
                Case 1
                    cbQH.DroppedDown = True
                    DropDown = 0
                    Exit Select
                Case Else
                    Exit Select
            End Select
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub cbQH_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbQH.SelectedIndexChanged
        Dim ChuoiKetNoi As String = "Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=NanoThucTap;Integrated Security=True"
        Dim db As Database
        Dim objCmd As DbCommand
        Dim ds As DataSet = Nothing

        db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
        objCmd = db.GetStoredProcCommand("GetXaByTinh")
        db.AddInParameter(objCmd, "@TenQH", DbType.String, cbQH.Text)
        cbXP.Items.Clear() ' Xóa tất cả các item cũ trước khi thêm mới

        Using reader As IDataReader = db.ExecuteReader(objCmd)
            While reader.Read()
                cbXP.Items.Add(reader("TenXa").ToString())
            End While
        End Using
    End Sub

    Private Sub frmSinhVien_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.F2) Then
            btnLuuSV.PerformClick()
        End If
        If (e.KeyCode = Keys.Escape) Then
            btnDongSV.PerformClick()
        End If
    End Sub
End Class