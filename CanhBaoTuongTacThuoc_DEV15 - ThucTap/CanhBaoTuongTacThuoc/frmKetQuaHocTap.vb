Imports System.Data.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class frmKetQuaHocTap
    Private objFcDMKetQua As New DMKetQuaHocTapDA
    Private objEnKetQua As New DMKetQuaHocTapEntity
    Private State As Byte
    Public Event _NextKQ()
    Private objListParam As List(Of ReturnSQLEntity)
    Private objSql As New ReturnSQLDA



    Sub New(ByVal StateinSert As Byte)
        InitializeComponent()
        State = StateinSert
    End Sub

    Sub New(ByVal StateUpdate As Byte, ByVal Obj As DMKetQuaHocTapEntity)
        InitializeComponent()
        State = StateUpdate
        objEnKetQua = Obj
        txtID.Text = Obj.ID
        cbMaGV.Text = Obj.MaGiaoVien
        cbMaLop.Text = Obj.MaLopHoc
        cbMaSV.Text = Obj.MaSinhVien
        cbMaMH.Text = Obj.MaMonHoc
        txtDiemThi.Text = Obj.DiemThi
        dateNgayThi.DateTime = Obj.NgayThi
    End Sub

    Private Sub frmKetQua_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadMaGV()
        loadMaLopHoc()
        loadMaMonHoc()
        loadMaSV()
        If State = ADD_STATE Then

        Else
            txtID.Text = objEnKetQua.ID
            cbMaGV.Text = objEnKetQua.MaGiaoVien
            cbMaLop.Text = objEnKetQua.MaLopHoc
            cbMaSV.Text = objEnKetQua.MaSinhVien
            cbMaMH.Text = objEnKetQua.MaMonHoc
            txtDiemThi.Text = objEnKetQua.DiemThi
            dateNgayThi.DateTime = objEnKetQua.NgayThi
        End If
    End Sub
    Private Sub btnDongKQ_Click(sender As Object, e As EventArgs) Handles btnDongKQ.Click
        Me.Close()
    End Sub

    Private Sub btnLuuKQ_Click(sender As Object, e As EventArgs) Handles btnLuuKQ.Click
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
        If String.IsNullOrEmpty(cbMaSV.Text) Then
            MsgBox("Mã sinh vien không được để trống!", MsgBoxStyle.Information, "Cảnh báo")
            cbMaSV.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(cbMaMH.Text) Then
            MsgBox("Mã môn học không được để trống!", MsgBoxStyle.Information, "Cảnh báo")
            cbMaMH.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(txtDiemThi.Text) Then
            MsgBox("Điểm thi không được để trống!", MsgBoxStyle.Information, "Cảnh báo")
            txtDiemThi.Focus()
            Exit Sub
        End If
        objEnKetQua.MaGiaoVien = cbMaGV.Text
        objEnKetQua.MaLopHoc = cbMaLop.Text
        objEnKetQua.MaSinhVien = cbMaSV.Text
        objEnKetQua.MaMonHoc = cbMaMH.Text
        objEnKetQua.DiemThi = txtDiemThi.Text
        objEnKetQua.NgayThi = dateNgayThi.DateTime
        Select Case State
            Case ADD_STATE
                If objFcDMKetQua.DMKQ_SelectByID(objEnKetQua) IsNot Nothing Then
                    MsgBox("Trùng dữ liệu!", MsgBoxStyle.Information, "Thông báo")
                    Exit Sub
                End If
                objFcDMKetQua.DMKQ_Insert(objEnKetQua)
                MsgBox("Thêm thành công!", MsgBoxStyle.Information, "Thông báo")
                ClearControl()
            Case UPDATE_STATE
                objFcDMKetQua.DMKQ_Update(objEnKetQua)
                MsgBox("Cập nhật thành công!", MsgBoxStyle.Information, "Thông báo")
                'btnLuu.Enabled = False
        End Select
        RaiseEvent _NextKQ()
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
    Private Sub loadMaGV()
        Dim ChuoiKetNoi As String = "Data Source=123.24.142.45,2019;Initial Catalog=NanoThucTap;Persist Security Info=True;User ID=his;Password=s@123456;Connection Timeout=3"
        Dim db As Database
        Dim objCmd As DbCommand
        Dim ds As DataSet = Nothing

        db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
        objCmd = db.GetSqlStringCommand("select MaGiaoVien from DM_GiaoVien")

        Using reader As IDataReader = db.ExecuteReader(objCmd)
            While reader.Read()
                cbMaGV.Properties.Items.Add(reader("MaGiaoVien").ToString())
            End While
        End Using
    End Sub
    Private Sub loadMaLopHoc()
        Dim ChuoiKetNoi As String = "Data Source=123.24.142.45,2019;Initial Catalog=NanoThucTap;Persist Security Info=True;User ID=his;Password=s@123456;Connection Timeout=3"
        Dim db As Database
        Dim objCmd As DbCommand
        Dim ds As DataSet = Nothing

        db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
        objCmd = db.GetSqlStringCommand("select MaLop from DM_LopHoc")

        Using reader As IDataReader = db.ExecuteReader(objCmd)
            While reader.Read()
                cbMaLop.Properties.Items.Add(reader("MaLop").ToString())
            End While
        End Using
    End Sub
    Private Sub loadMaSV()
        Dim ChuoiKetNoi As String = "Data Source=123.24.142.45,2019;Initial Catalog=NanoThucTap;Persist Security Info=True;User ID=his;Password=s@123456;Connection Timeout=3"
        Dim db As Database
        Dim objCmd As DbCommand
        Dim ds As DataSet = Nothing

        db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
        objCmd = db.GetSqlStringCommand("select MaSinhVien from DMSinhVien")

        Using reader As IDataReader = db.ExecuteReader(objCmd)
            While reader.Read()
                cbMaSV.Properties.Items.Add(reader("MaSinhVien").ToString())
            End While
        End Using
    End Sub
    Private Sub loadMaMonHoc()
        Dim ChuoiKetNoi As String = "Data Source=123.24.142.45,2019;Initial Catalog=NanoThucTap;Persist Security Info=True;User ID=his;Password=s@123456;Connection Timeout=3"
        Dim db As Database
        Dim objCmd As DbCommand
        Dim ds As DataSet = Nothing

        db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
        objCmd = db.GetSqlStringCommand("select MaMonHoc from DMMonHoc")

        Using reader As IDataReader = db.ExecuteReader(objCmd)
            While reader.Read()
                cbMaMH.Properties.Items.Add(reader("MaMonHoc").ToString())
            End While
        End Using
    End Sub
    Private DropDown As Integer = 0
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

    Private Sub cbMaSV_KeyDown(sender As Object, e As KeyEventArgs) Handles cbMaSV.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Select Case DropDown
                Case 0
                    cbMaSV.ClosePopup()
                    DropDown = 1
                    Exit Select
                Case 1
                    cbMaSV.ShowPopup()
                    DropDown = 0
                    Exit Select
                Case Else
                    Exit Select
            End Select
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub dateNgayThi_KeyDown(sender As Object, e As KeyEventArgs) Handles dateNgayThi.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnLuuKQ.PerformClick()
        End If
    End Sub

    Private Sub btnLuuKQ_KeyDown(sender As Object, e As KeyEventArgs) Handles btnLuuKQ.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnLuuKQ.PerformClick()
        End If
    End Sub

    Private Sub btnDongKQ_KeyDown(sender As Object, e As KeyEventArgs) Handles btnDongKQ.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnDongKQ.PerformClick()
        End If
    End Sub

    Private Sub cbMaMH_KeyDown(sender As Object, e As KeyEventArgs) Handles cbMaMH.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Select Case DropDown
                Case 0
                    cbMaMH.ClosePopup()
                    DropDown = 1
                    Exit Select
                Case 1
                    cbMaMH.ShowPopup()
                    DropDown = 0
                    Exit Select
                Case Else
                    Exit Select
            End Select
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub frmKetQuaHocTap_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.F2) Then
            btnLuuKQ.PerformClick()
        End If
        If (e.KeyCode = Keys.Escape) Then
            btnDongKQ.PerformClick()
        End If
    End Sub
End Class