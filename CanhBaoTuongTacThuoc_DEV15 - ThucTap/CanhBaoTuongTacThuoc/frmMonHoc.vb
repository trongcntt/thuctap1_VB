Imports System.Data.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class frmMonHoc
    Private objFcDMMonHoc As New DMMonHocDA
    Private objEnMonHoc As New DMMonHocEntity
    Private State As Byte
    Public Event _NextMH()
    Private objListParam As List(Of ReturnSQLEntity)
    Private objSql As New ReturnSQLDA



    Sub New(ByVal StateinSert As Byte)
        InitializeComponent()
        State = StateinSert
    End Sub

    Sub New(ByVal StateUpdate As Byte, ByVal Obj As DMMonHocEntity)
        InitializeComponent()
        State = StateUpdate
        objEnMonHoc = Obj
        txtTenMonHoc.Text = Obj.TenMonHoc
        cbMaMonHoc.Text = Obj.MaMonHoc

    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If String.IsNullOrEmpty(cbMaMonHoc.Text) Then
            MsgBox("Mã môn học không được để trống!", MsgBoxStyle.Information, "Cảnh báo")
            cbMaMonHoc.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(txtTenMonHoc.Text) Then
            MsgBox("Tên môn học không được để trống!", MsgBoxStyle.Information, "Cảnh báo")
            txtTenMonHoc.Focus()
            Exit Sub
        End If

        objEnMonHoc.TenMonHoc = txtTenMonHoc.Text
        objEnMonHoc.MaMonHoc = cbMaMonHoc.Text
        Select Case State
            Case ADD_STATE
                If objFcDMMonHoc.DMMonHoc_SelectByID(objEnMonHoc) IsNot Nothing Then
                    MsgBox("Trùng dữ liệu!", MsgBoxStyle.Information, "Thông báo")
                    Exit Sub
                End If
                objFcDMMonHoc.DMMonHoc_Insert(objEnMonHoc)
                MsgBox("Thêm thành công!", MsgBoxStyle.Information, "Thông báo")
                ClearControl()
            Case UPDATE_STATE
                objFcDMMonHoc.DMMonHoc_Update(objEnMonHoc)
                MsgBox("Cập nhật thành công!", MsgBoxStyle.Information, "Thông báo")
                'btnLuu.Enabled = False
        End Select
        RaiseEvent _NextMH()
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

    Private Sub cbMaMonHoc_KeyDown(sender As Object, e As KeyEventArgs) Handles cbMaMonHoc.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Select Case DropDown
                Case 0
                    cbMaMonHoc.ClosePopup()
                    DropDown = 1
                    Exit Select
                Case 1
                    cbMaMonHoc.ShowPopup()
                    DropDown = 0
                    Exit Select
                Case Else
                    Exit Select
            End Select
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtTenMonHoc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTenMonHoc.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnLuu.PerformClick()
        End If
    End Sub

    Private Sub frmMonHoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ChuoiKetNoi As String = "Data Source=123.24.142.45,2019;Initial Catalog=NanoThucTap;Persist Security Info=True;User ID=his;Password=s@123456;Connection Timeout=3"
        Dim db As Database
        Dim objCmd As DbCommand
        Dim ds As DataSet = Nothing

        db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
        objCmd = db.GetSqlStringCommand("select MaMonHoc from DMMonHoc ")

        Using reader As IDataReader = db.ExecuteReader(objCmd)
            While reader.Read()
                cbMaMonHoc.Properties.Items.Add(reader("MaMonHoc").ToString())
            End While
        End Using
    End Sub

    Private Sub frmMonHoc_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.F2) Then
            btnLuu.PerformClick()
        End If
        If (e.KeyCode = Keys.Escape) Then
            btnDong.PerformClick()
        End If
    End Sub
End Class