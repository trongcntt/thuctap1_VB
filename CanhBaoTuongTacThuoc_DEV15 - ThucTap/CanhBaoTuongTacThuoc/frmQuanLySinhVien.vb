Imports System
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.IO
Imports System.Web.UI.WebControls
Imports System.Windows
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class frmQuanLySinhVien
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(strKetNoiCSDLParam As String)

        ' This call is required by the designer.
        InitializeComponent()

        '    ' Add any initialization after the InitializeComponent() call.
        If ChuoiKetNoi = String.Empty Then
            ChuoiKetNoi = strKetNoiCSDLParam
            'ChuoiKetNoi = "Data Source=113.190.233.83,2467;Initial Catalog=BV_QuangThanh;User ID=his;Password=s@123456;Connection Timeout=3"
        End If
    End Sub

    Public Sub New(strKetNoiCSDLParam As String, MaBenhVien As String)

        ' This call is required by the designer.
        InitializeComponent()

        '    ' Add any initialization after the InitializeComponent() call.
        If ChuoiKetNoi = String.Empty Then
            ChuoiKetNoi = strKetNoiCSDLParam
            'ChuoiKetNoi = "Data Source=113.190.233.83,2467;Initial Catalog=BV_QuangThanh;User ID=his;Password=s@123456;Connection Timeout=3"
        End If
        nMaBenhVien = MaBenhVien
    End Sub
    'điều hướng------------
    Private Sub btnDanhMuc_Click(sender As Object, e As EventArgs) Handles btnDanhMuc.Click
        searchPanel.Visible = False
        If grdCanhBaoDichVu.Visible = False Then
            grdCanhBaoDichVu.Visible = True
        Else
            grdCanhBaoDichVu.Visible = False
        End If
        grdCanhBaoDichVu.Location = New Point(0, 44)
        tabdiemdi.Visible = False
        'Me.BackgroundImage = Nothing
    End Sub

    Private Sub btnDiemThi_Click(sender As Object, e As EventArgs) Handles btnDiemThi.Click
        If searchPanel.Visible = False Then
            searchPanel.Visible = True
        End If
        If tabdiemdi.Visible = False Then
            tabdiemdi.Visible = True
        Else
            tabdiemdi.Visible = False
        End If
        tabdiemdi.Location = New Point(5, 54)
        grdCanhBaoDichVu.Visible = False
        'Me.BackgroundImage = Nothing

    End Sub
#Region "Giáo Viên"
    Private objFcDMCanhBaoThuoc As New DMGiaoVienDA
    Private objEnCanhBaoThuoc As New DMGiaoVienEntity

    Private WithEvents _ReSet As frmGiaoVienn = Nothing
    Private ObjColCheckgv As AddCheckboxInXtragrid


    Sub LoadDMDonVi() Handles _ReSet._Next
        grdGiaoVien.DataSource = objFcDMCanhBaoThuoc.DMGiaoVien_SelectAll()
        ObjColCheckgv = New AddCheckboxInXtragrid(grdGiaoVien, gvGiaoVien)
        ObjColCheckgv.AddCheckColumn_FieldName()

    End Sub

    Private Function GetData() As DMGiaoVienEntity
        Dim _data As New DMGiaoVienEntity
        Try
            If gvGiaoVien.RowCount > 0 Then
                _data = CType(gvGiaoVien.GetFocusedRow(), DMGiaoVienEntity)
            End If
        Catch ex As Exception

        End Try
        Return _data
    End Function

    Private Sub btnThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        _ReSet = New frmGiaoVienn(ADD_STATE)
        _ReSet.ShowDialog()
    End Sub

    Private Sub frmDMDonvi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NanoThucTapDataSet2.DMMonHoc' table. You can move, or remove it, as needed.
        Me.DMMonHocTableAdapter.Fill(Me.NanoThucTapDataSet2.DMMonHoc)
        'TODO: This line of code loads data into the 'NanoThucTapDataSet1.tbl_KetQuaHocTap' table. You can move, or remove it, as needed.
        Me.Tbl_KetQuaHocTapTableAdapter.Fill(Me.NanoThucTapDataSet1.tbl_KetQuaHocTap)
        ChuoiKetNoi = "Data Source=123.24.142.45,2019;Initial Catalog=NanoThucTap;Persist Security Info=True;User ID=his;Password=s@123456;Connection Timeout=3"
        ' ChuoiKetNoi = "Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=NanoThucTap;Integrated Security=True"
        LoadDMDonVi()
        LoadDMLopHoc()
        LoadDMSinhVien()
        LoadDMNguoiDung()
        LoadDMTinhThanh()
        LoadDMQuanHuyen()
        LoadDMXaPhuong()
        LoadDMMonHoc()
        LoadDMKetQua()
    End Sub

    Private Sub btnSua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua.Click
        If GetData() Is Nothing Then
            Exit Sub
        End If

        _ReSet = New frmGiaoVienn(UPDATE_STATE, GetData)
        _ReSet.ShowDialog()
    End Sub

    Private Sub GrvMainDMDonVi_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If GetData() Is Nothing Then
            Exit Sub
        End If

        _ReSet = New frmGiaoVienn(UPDATE_STATE, GetData)
        _ReSet.ShowDialog()
    End Sub

    Private Sub btnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click

        Try
            Dim Objects As New List(Of Object)
            Objects = ObjColCheckgv.objects
            If Objects.Count <= 0 Then
                MsgBox("Chọn bản ghi cần xóa!", MsgBoxStyle.Information, "Thông báo")
                Exit Sub
            End If
            For Each r As Object In Objects
                objEnCanhBaoThuoc = CType(r, DMGiaoVienEntity)
                objFcDMCanhBaoThuoc.DMGiaoVien_DeleteByMagv(objEnCanhBaoThuoc)
            Next
        Catch ex As Exception

        End Try
        LoadDMDonVi()

    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub btnXuatExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXuatExcel.Click
        XuatExcel(gvGiaoVien)
    End Sub
#End Region

    Private Sub XuatExcel(ByVal gvView As DevExpress.XtraGrid.Views.Grid.GridView)
        If gvView.RowCount <= 0 Then
            Exit Sub
        End If

        Dim fld As New SaveFileDialog()
        fld.Filter = "Excel file (*.xls;*.*)|*.xls;*.xlsx"
        fld.RestoreDirectory = True
        If fld.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If
        gvView.ExportToXls(fld.FileName)

    End Sub

    'Lớp Học ------------------------------
#Region "Lop hoc"
    Private objFcDMLopHoc As New DMLopHocDA
    Private objEnLopHoc As New DMLopHocEntity

    Private WithEvents _ReSetlh As frmLopHoc = Nothing
    Private ObjColChecklh As AddCheckboxInXtragrid


    Sub LoadDMLopHoc() Handles _ReSetlh._Nextlh
        grdLopHoc.DataSource = objFcDMLopHoc.DMLopHoc_SelectAll()
        ObjColChecklh = New AddCheckboxInXtragrid(grdLopHoc, gvLopHoc)
        ObjColChecklh.AddCheckColumn_FieldName()

    End Sub

    Private Function GetDatalh() As DMLopHocEntity
        Dim _data As New DMLopHocEntity
        Try
            If gvLopHoc.RowCount > 0 Then
                _data = CType(gvLopHoc.GetFocusedRow(), DMLopHocEntity)
            End If
        Catch ex As Exception

        End Try
        Return _data
    End Function

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        _ReSetlh = New frmLopHoc(ADD_STATE)
        _ReSetlh.ShowDialog()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        If GetDatalh() Is Nothing Then
            Exit Sub
        End If

        _ReSetlh = New frmLopHoc(UPDATE_STATE, GetDatalh)
        _ReSetlh.ShowDialog()
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click

        Try
            Dim Objectslh As New List(Of Object)
            Objectslh = ObjColChecklh.objects
            If Objectslh.Count <= 0 Then
                MsgBox("Chọn bản ghi cần xóa!", MsgBoxStyle.Information, "Thông báo")
                Exit Sub
            End If
            For Each r As Object In Objectslh
                objEnLopHoc = CType(r, DMLopHocEntity)
                objFcDMLopHoc.DMLopHoc_DeleteByID(objEnLopHoc)
            Next
        Catch ex As Exception

        End Try
        LoadDMLopHoc()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        XuatExcel(gvLopHoc)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub



#End Region
    'SINH VIÊN-----------------------------------
#Region "Sinh Viên"
    Private objFcDMSinhVien As New DMSinhVienDA
    Private objEnSinhVien As New DMSinhVienEntity
    Private WithEvents _ReSetsv As frmSinhVien = Nothing
    Private ObjColChecksv As AddCheckboxInXtragrid


    Sub LoadDMSinhVien() Handles _ReSetsv._Nextsv
        grdSinhVien.DataSource = objFcDMSinhVien.DMSinhVien_SelectAll()
        ObjColChecksv = New AddCheckboxInXtragrid(grdSinhVien, gvSinhVien)
        ObjColChecksv.AddCheckColumn_FieldName()

    End Sub

    Private Function GetDatasv() As DMSinhVienEntity
        Dim _data As New DMSinhVienEntity
        Try
            If gvSinhVien.RowCount > 0 Then
                _data = CType(gvSinhVien.GetFocusedRow(), DMSinhVienEntity)
            End If
        Catch ex As Exception

        End Try
        Return _data
    End Function

    Private Sub btnThemSV_Click(sender As Object, e As EventArgs) Handles btnThemSV.Click
        _ReSetsv = New frmSinhVien(ADD_STATE)
        _ReSetsv.ShowDialog()
    End Sub

    Private Sub btnSuaSv_Click(sender As Object, e As EventArgs) Handles btnSuaSv.Click
        If GetDatasv() Is Nothing Then
            Exit Sub
        End If

        _ReSetsv = New frmSinhVien(UPDATE_STATE, GetDatasv)
        _ReSetsv.ShowDialog()
    End Sub

    Private Sub btnXoaSV_Click(sender As Object, e As EventArgs) Handles btnXoaSV.Click

        Try
            Dim Objectssv As New List(Of Object)
            Objectssv = ObjColChecksv.objects
            If Objectssv.Count <= 0 Then
                MsgBox("Chọn bản ghi cần xóa!", MsgBoxStyle.Information, "Thông báo")
                Exit Sub
            End If
            For Each r As Object In Objectssv
                objEnSinhVien = CType(r, DMSinhVienEntity)
                objFcDMSinhVien.DMSinhVien_DeleteByID(objEnSinhVien)
            Next
        Catch ex As Exception

        End Try
        LoadDMSinhVien()

    End Sub

    Private Sub btnExcelSv_Click(sender As Object, e As EventArgs) Handles btnExcelSv.Click
        XuatExcel(gvLopHoc)
    End Sub

    Private Sub btnThoatSV_Click(sender As Object, e As EventArgs) Handles btnThoatSV.Click
        Me.Close()

    End Sub



#End Region
    'Người dùng--------------------------------
#Region "Nguoi Dung"
    Private objFcNguoiDung As New DMNguoiDungDA
    Private objEnNguoiDung As New DMNguoiDungEntity

    Private WithEvents _ReSetND As frmNguoiDung = Nothing
    Private ObjColChecknd As AddCheckboxInXtragrid


    Sub LoadDMNguoiDung() Handles _ReSetND._NextND
        GrdNguoiDung.DataSource = objFcNguoiDung.DMNguoiDung_SelectAll()
        ObjColChecknd = New AddCheckboxInXtragrid(GrdNguoiDung, grNguoiDung)
        ObjColChecknd.AddCheckColumn_FieldName()

    End Sub
    Private Function GetDatand() As DMNguoiDungEntity
        Dim _data As New DMNguoiDungEntity
        Try
            If grNguoiDung.RowCount > 0 Then
                _data = CType(grNguoiDung.GetFocusedRow(), DMNguoiDungEntity)
            End If
        Catch ex As Exception

        End Try
        Return _data
    End Function
    Private Sub btnThemND_Click(sender As Object, e As EventArgs) Handles btnThemND.Click
        _ReSetND = New frmNguoiDung(ADD_STATE)
        _ReSetND.ShowDialog()
    End Sub

    Private Sub btnSuaND_Click(sender As Object, e As EventArgs) Handles btnSuaND.Click
        If GetDatand() Is Nothing Then
            Exit Sub
        End If

        _ReSetND = New frmNguoiDung(UPDATE_STATE, GetDatand)
        _ReSetND.ShowDialog()
    End Sub

    Private Sub btnExcelND_Click(sender As Object, e As EventArgs) Handles btnExcelND.Click
        XuatExcel(grNguoiDung)
    End Sub

    Private Sub btnXoaND_Click(sender As Object, e As EventArgs) Handles btnXoaND.Click
        Try
            Dim Objectsnd As New List(Of Object)
            Objectsnd = ObjColChecknd.objects
            If Objectsnd.Count <= 0 Then
                MsgBox("Chọn bản ghi cần xóa!", MsgBoxStyle.Information, "Thông báo")
                Exit Sub
            End If
            For Each r As Object In Objectsnd
                objEnNguoiDung = CType(r, DMNguoiDungEntity)
                objFcNguoiDung.DMNguoiDung_DeleteByID(objEnNguoiDung)
            Next
        Catch ex As Exception

        End Try
        LoadDMNguoiDung()
    End Sub

    Private Sub btnThoatND_Click(sender As Object, e As EventArgs) Handles btnThoatND.Click
        Me.Close()
    End Sub

#End Region
    'Quận Huyện--------------------------
#Region "QuanHuyen"
    Private objFcQuanHuyen As New DMQuanHuyenDA
    Private objEnQuanHuyen As New DMQuanHuyenEntity

    Private WithEvents _ReSetQH As frmQuanHuyen = Nothing
    Private ObjColCheckQH As AddCheckboxInXtragrid


    Sub LoadDMQuanHuyen() Handles _ReSetQH._NextQH
        grdQuanHuyen.DataSource = objFcQuanHuyen.DMQuanHuyen_SelectAll()
        ObjColCheckQH = New AddCheckboxInXtragrid(grdQuanHuyen, gvQuanHuyen)
        ObjColCheckQH.AddCheckColumn_FieldName()

    End Sub
    Private Function GetDataQH() As DMQuanHuyenEntity
        Dim _data As New DMQuanHuyenEntity
        Try
            If gvQuanHuyen.RowCount > 0 Then
                _data = CType(gvQuanHuyen.GetFocusedRow(), DMQuanHuyenEntity)
            End If
        Catch ex As Exception

        End Try
        Return _data
    End Function
    Private Sub btnThemQH_Click(sender As Object, e As EventArgs) Handles btnThemQH.Click
        _ReSetQH = New frmQuanHuyen(ADD_STATE)
        _ReSetQH.ShowDialog()
    End Sub

    Private Sub btnSuaQH_Click(sender As Object, e As EventArgs) Handles btnSuaQH.Click
        If GetDataQH() Is Nothing Then
            Exit Sub
        End If

        _ReSetQH = New frmQuanHuyen(UPDATE_STATE, GetDataQH)
        _ReSetQH.ShowDialog()
    End Sub

    Private Sub btnXoaQH_Click(sender As Object, e As EventArgs) Handles btnXoaQH.Click
        Try
            Dim ObjectsQH As New List(Of Object)
            ObjectsQH = ObjColCheckQH.objects
            If ObjectsQH.Count <= 0 Then
                MsgBox("Chọn bản ghi cần xóa!", MsgBoxStyle.Information, "Thông báo")
                Exit Sub
            End If
            For Each r As Object In ObjectsQH
                objEnQuanHuyen = CType(r, DMQuanHuyenEntity)
                objFcQuanHuyen.DMQuanHuyen_DeleteByID(objEnQuanHuyen)
            Next
        Catch ex As Exception

        End Try
        LoadDMQuanHuyen()
    End Sub

    Private Sub btnExcelQH_Click(sender As Object, e As EventArgs) Handles btnExcelQH.Click
        XuatExcel(gvQuanHuyen)
    End Sub

    Private Sub btnThoatQH_Click(sender As Object, e As EventArgs) Handles btnThoatQH.Click
        Me.Close()
    End Sub


#End Region
    'Tỉnh thành-------------------------
#Region "TỈNH THÀNH"
    Private objFcTinhThanh As New DMTinhThanhDA
    Private objEnTinhThanh As New DMTinhThanhEntity

    Private WithEvents _ReSetTT As frmTinhThanh = Nothing
    Private ObjColCheckTT As AddCheckboxInXtragrid


    Sub LoadDMTinhThanh() Handles _ReSetTT._NextTT
        grdTinhThanh.DataSource = objFcTinhThanh.DMTinhThanh_SelectAll()
        ObjColCheckTT = New AddCheckboxInXtragrid(grdTinhThanh, gvTinhThanh)
        ObjColCheckTT.AddCheckColumn_FieldName()

    End Sub
    Private Function GetDataTT() As DMTinhThanhEntity
        Dim _data As New DMTinhThanhEntity
        Try
            If gvTinhThanh.RowCount > 0 Then
                _data = CType(gvTinhThanh.GetFocusedRow(), DMTinhThanhEntity)
            End If
        Catch ex As Exception

        End Try
        Return _data
    End Function
    Private Sub btnThemTT_Click(sender As Object, e As EventArgs) Handles btnThemTT.Click
        _ReSetTT = New frmTinhThanh(ADD_STATE)
        _ReSetTT.ShowDialog()
    End Sub
    Private Sub btnSuaTT_Click(sender As Object, e As EventArgs) Handles btnSuaTT.Click
        If GetDataTT() Is Nothing Then
            Exit Sub
        End If

        _ReSetTT = New frmTinhThanh(UPDATE_STATE, GetDataTT)
        _ReSetTT.ShowDialog()
    End Sub
    Private Sub btnXoaTT_Click(sender As Object, e As EventArgs) Handles btnXoaTT.Click
        Try
            Dim ObjectsTT As New List(Of Object)
            ObjectsTT = ObjColCheckTT.objects
            If ObjectsTT.Count <= 0 Then
                MsgBox("Chọn bản ghi cần xóa!", MsgBoxStyle.Information, "Thông báo")
                Exit Sub
            End If
            For Each r As Object In ObjectsTT
                objEnTinhThanh = CType(r, DMTinhThanhEntity)
                objFcTinhThanh.DMTinhThanh_DeleteByID(objEnTinhThanh)
            Next
        Catch ex As Exception

        End Try
        LoadDMTinhThanh()
    End Sub
    Private Sub btnExcelTT_Click(sender As Object, e As EventArgs) Handles btnExcelTT.Click
        XuatExcel(gvTinhThanh)
    End Sub

    Private Sub btnThoatTT_Click(sender As Object, e As EventArgs) Handles btnThoatTT.Click
        Me.Close()
    End Sub
#End Region
    'Xã Phường-----------------
#Region "Xã Phường"
    Private objFcXaPhuong As New DMXaPhuongDA
    Private objEnXaPhuong As New DMXaPhuongEntity

    Private WithEvents _ReSetXP As frmXaPhuong = Nothing
    Private ObjColCheckXP As AddCheckboxInXtragrid


    Sub LoadDMXaPhuong() Handles _ReSetXP._NextXP
        grdXaPhuong.DataSource = objFcXaPhuong.DMXaPhuong_SelectAll()
        ObjColCheckXP = New AddCheckboxInXtragrid(grdXaPhuong, gvXaPhuong)
        ObjColCheckXP.AddCheckColumn_FieldName()

    End Sub
    Private Function GetDataXP() As DMXaPhuongEntity
        Dim _data As New DMXaPhuongEntity
        Try
            If gvXaPhuong.RowCount > 0 Then
                _data = CType(gvXaPhuong.GetFocusedRow(), DMXaPhuongEntity)
            End If
        Catch ex As Exception

        End Try
        Return _data
    End Function

    Private Sub btnThemXP_Click(sender As Object, e As EventArgs) Handles btnThemXP.Click
        _ReSetXP = New frmXaPhuong(ADD_STATE)
        _ReSetXP.ShowDialog()
    End Sub

    Private Sub btnSuaXP_Click(sender As Object, e As EventArgs) Handles btnSuaXP.Click
        If GetDataXP() Is Nothing Then
            Exit Sub
        End If

        _ReSetXP = New frmXaPhuong(UPDATE_STATE, GetDataXP)
        _ReSetXP.ShowDialog()
    End Sub

    Private Sub btnXoaXP_Click(sender As Object, e As EventArgs) Handles btnXoaXP.Click
        Try
            Dim ObjectsXP As New List(Of Object)
            ObjectsXP = ObjColCheckXP.objects
            If ObjectsXP.Count <= 0 Then
                MsgBox("Chọn bản ghi cần xóa!", MsgBoxStyle.Information, "Thông báo")
                Exit Sub
            End If
            For Each r As Object In ObjectsXP
                objEnXaPhuong = CType(r, DMXaPhuongEntity)
                objFcXaPhuong.DMXaPhuong_DeleteByID(objEnXaPhuong)
            Next
        Catch ex As Exception

        End Try
        LoadDMXaPhuong()
    End Sub

    Private Sub btnExcelXP_Click(sender As Object, e As EventArgs) Handles btnExcelXP.Click
        XuatExcel(gvXaPhuong)
    End Sub

    Private Sub btnThoatXP_Click(sender As Object, e As EventArgs) Handles btnThoatXP.Click
        Me.Close()
    End Sub




#End Region
    'Môn Học
#Region "Môn học"
    Private objFcMonHoc As New DMMonHocDA
    Private objEnMonHoc As New DMMonHocEntity

    Private WithEvents _ReSetMH As frmMonHoc = Nothing
    Private ObjColCheckMH As AddCheckboxInXtragrid


    Sub LoadDMMonHoc() Handles _ReSetMH._NextMH
        grdMonHoc.DataSource = objFcMonHoc.DMMonHoc_SelectAll()
        ObjColCheckMH = New AddCheckboxInXtragrid(grdMonHoc, gvMonHoc)
        ObjColCheckMH.AddCheckColumn_FieldName()

    End Sub
    Private Function GetDataMH() As DMMonHocEntity
        Dim _data As New DMMonHocEntity
        Try
            If gvMonHoc.RowCount > 0 Then
                _data = CType(gvMonHoc.GetFocusedRow(), DMMonHocEntity)
            End If
        Catch ex As Exception

        End Try
        Return _data
    End Function
    Private Sub btnThemMH_Click(sender As Object, e As EventArgs) Handles btnThemMH.Click
        _ReSetMH = New frmMonHoc(ADD_STATE)
        _ReSetMH.ShowDialog()
    End Sub
    Private Sub btnSuaMH_Click(sender As Object, e As EventArgs) Handles btnSuaMH.Click
        If GetDataMH() Is Nothing Then
            Exit Sub
        End If

        _ReSetMH = New frmMonHoc(UPDATE_STATE, GetDataMH)
        _ReSetMH.ShowDialog()

    End Sub

    Private Sub btnXoaMH_Click(sender As Object, e As EventArgs) Handles btnXoaMH.Click
        Try
            Dim ObjectsMH As New List(Of Object)
            ObjectsMH = ObjColCheckMH.objects
            If ObjectsMH.Count <= 0 Then
                MsgBox("Chọn bản ghi cần xóa!", MsgBoxStyle.Information, "Thông báo")
                Exit Sub
            End If
            For Each r As Object In ObjectsMH
                objEnMonHoc = CType(r, DMMonHocEntity)
                objFcMonHoc.DMMonHoc_DeleteByID(objEnMonHoc)
            Next
        Catch ex As Exception

        End Try
        LoadDMMonHoc()
    End Sub

    Private Sub btnExcelMh_Click(sender As Object, e As EventArgs) Handles btnExcelMh.Click
        XuatExcel(gvMonHoc)
    End Sub
    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub




#End Region
    '--kết quả-----------
#Region "Kết quả"
    Private objFcKetQua As New DMKetQuaHocTapDA
    Private objEnKetQua As New DMKetQuaHocTapEntity

    Private WithEvents _ReSetKQ As frmKetQuaHocTap = Nothing
    Private ObjColCheckKQ As AddCheckboxInXtragrid

    Sub tinhcaothap()
        Dim ChuoiKetNoi As String = "Data Source=123.24.142.45,2019;Initial Catalog=NanoThucTap;Persist Security Info=True;User ID=his;Password=s@123456;Connection Timeout=3"
        Dim db As Database = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
        Dim objCmd As DbCommand = db.GetSqlStringCommand("SELECT MIN(DiemThi) AS DiemThapNhat, MAX(DiemThi) AS DiemCaoNhat FROM tbl_ketquahoctap")
        Dim ds As New DataSet()

        db.LoadDataSet(objCmd, ds, "KetQua")

        If ds.Tables("KetQua").Rows.Count > 0 Then
            Dim diemThapNhat As Double = Convert.ToDouble(ds.Tables("KetQua").Rows(0)("DiemThapNhat"))
            Dim diemCaoNhat As Double = Convert.ToDouble(ds.Tables("KetQua").Rows(0)("DiemCaoNhat"))

            lbKQthap.Text = "Điểm thấp nhất: " & diemThapNhat.ToString()
            lbKqCao.Text = "Điểm cao nhất: " & diemCaoNhat.ToString()
        Else
            lbKQthap.Text = "Không có dữ liệu"
            lbKqCao.Text = "Không có dữ liệu"
        End If

    End Sub
    Sub LoadDMKetQua() Handles _ReSetKQ._NextKQ
        grdKetQua.DataSource = objFcKetQua.DMkq_SelectAll()
        ObjColCheckKQ = New AddCheckboxInXtragrid(grdKetQua, gvKetQua)
        ObjColCheckKQ.AddCheckColumn_FieldName()
        tinhcaothap()
    End Sub
    Private Function GetDataKQ() As DMKetQuaHocTapEntity
        Dim _data As New DMKetQuaHocTapEntity
        Try
            If gvKetQua.RowCount > 0 Then
                _data = CType(gvKetQua.GetFocusedRow(), DMKetQuaHocTapEntity)
            End If
        Catch ex As Exception

        End Try
        Return _data
    End Function
    Private Sub btnThemKQ_Click(sender As Object, e As EventArgs) Handles btnThemKQ.Click
        _ReSetKQ = New frmKetQuaHocTap(ADD_STATE)
        _ReSetKQ.ShowDialog()
    End Sub
    Private Sub btnSuaKQ_Click(sender As Object, e As EventArgs) Handles btnSuaKQ.Click
        If GetDataKQ() Is Nothing Then
            Exit Sub
        End If

        _ReSetKQ = New frmKetQuaHocTap(UPDATE_STATE, GetDataKQ)
        _ReSetKQ.ShowDialog()
    End Sub
    Private Sub btnThoatKq_Click(sender As Object, e As EventArgs) Handles btnThoatKq.Click
        Me.Close()
    End Sub

    Private Sub btnExcelKQ_Click(sender As Object, e As EventArgs) Handles btnExcelKQ.Click
        XuatExcel(gvKetQua)
    End Sub

    Private Sub btnXoaKQ_Click(sender As Object, e As EventArgs) Handles btnXoaKQ.Click
        Try
            Dim ObjectsKQ As New List(Of Object)
            ObjectsKQ = ObjColCheckKQ.objects
            If ObjectsKQ.Count <= 0 Then
                MsgBox("Chọn bản ghi cần xóa!", MsgBoxStyle.Information, "Thông báo")
                Exit Sub
            End If
            For Each r As Object In ObjectsKQ
                objEnKetQua = CType(r, DMKetQuaHocTapEntity)
                objFcKetQua.DMKQ_DeleteByID(objEnKetQua)
            Next
        Catch ex As Exception

        End Try
        LoadDMKetQua()
    End Sub



#End Region
    '--HIỂN THỊ
#Region "Hiểnthi"

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim ChuoiKetNoi As String = "Data Source=123.24.142.45,2019;Initial Catalog=NanoThucTap;Persist Security Info=True;User ID=his;Password=s@123456;Connection Timeout=3"
        Dim db As Database
        Dim objCmd As DbCommand
        Dim ds As DataSet = Nothing
        db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
        objCmd = db.GetSqlStringCommand("SELECT * FROM tbl_KetQuaHocTap WHERE MaSinhVien = @MaSinhVien")
        db.AddInParameter(objCmd, "@MaSinhVien", DbType.String, txtKQtimkiem.Text)

        ds = New DataSet()
        db.LoadDataSet(objCmd, ds, "tbl_KetQuaHocTap")

        grdHienthi.DataSource = ds.Tables("tbl_KetQuaHocTap")
        grdHienthi.RefreshDataSource()
        Dim diemTrungBinh As Double = TinhDiemTrungBinh(txtKQtimkiem.Text)

        ' Hiển thị điểm trung bình lên lblDiemTrungBinh
        lbTB.Text = "Điểm trung bình: " & diemTrungBinh.ToString()
        tabdiemdi.SelectedTabPageIndex = 2
    End Sub
    Private Function TinhDiemTrungBinh(maSinhVien As String) As Double
        ' Thực hiện các thao tác để tính điểm trung bình của các môn cho mã sinh viên đã tìm được
        ' Lấy dữ liệu từ cơ sở dữ liệu hoặc từ grdHienthi (tùy vào cách bạn lưu trữ dữ liệu)

        ' Giả sử dữ liệu điểm các môn đã tìm được được lưu trữ trong DataTable "tbl_KetQuaHocTap"
        Dim dt As DataTable = CType(grdHienthi.DataSource, DataTable)

        ' Tính điểm trung bình của các môn
        Dim diemTong As Double = 0
        Dim soMon As Integer = 0
        Dim diemThapNhat As Double = Double.MaxValue
        Dim diemCaoNhat As Double = Double.MinValue
        For Each row As DataRow In dt.Rows
            If row("MaSinhVien").ToString() = maSinhVien Then
                Dim diem = Convert.ToDouble(row("DiemThi"))
                diemTong += diem
                soMon += 1
                If diem < diemThapNhat Then
                    diemThapNhat = diem
                End If

                ' Tìm điểm cao nhất
                If diem > diemCaoNhat Then
                    diemCaoNhat = diem
                End If
            End If
        Next

        If soMon > 0 Then
            Dim diemTrungBinh As Double = diemTong / soMon
            lbThap.Text = "Điểm thấp nhất: " & diemThapNhat.ToString()
            lbCao.Text = "Điểm cao nhất: " & diemCaoNhat.ToString()
            Return diemTrungBinh
        Else
            Return 0
        End If

    End Function

    '----------dùng 2 text box tra điểm từ đâu đến đâu
    Public Sub HienThiSinhVienTheoDiem1(diemMin As Double, diemMax As Double)
        ' Xóa dữ liệu hiển thị trên GridView
        grdHienthi.DataSource = Nothing
        grdHienthi.RefreshDataSource()

        ' Tạo chuỗi kết nối và câu truy vấn SQL
        Dim ChuoiKetNoi As String = "Data Source=123.24.142.45,2019;Initial Catalog=NanoThucTap;Persist Security Info=True;User ID=his;Password=s@123456;Connection Timeout=3"
        Dim sqlQuery As String = "SELECT * FROM tbl_KetQuaHocTap WHERE DiemThi >= @DiemMin AND DiemThi <= @DiemMax"

        ' Tạo đối tượng kết nối và truy vấn
        Dim db As Database = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
        Dim objCmd As DbCommand = db.GetSqlStringCommand(sqlQuery)
        db.AddInParameter(objCmd, "@DiemMin", DbType.Double, diemMin)
        db.AddInParameter(objCmd, "@DiemMax", DbType.Double, diemMax)

        ' Thực hiện truy vấn và hiển thị kết quả
        Dim ds As DataSet = New DataSet()
        db.LoadDataSet(objCmd, ds, "tbl_KetQuaHocTap")

        grdHienthi.DataSource = ds.Tables("tbl_KetQuaHocTap")
        grdHienthi.RefreshDataSource()
    End Sub


    Private Sub btnTra_Click(sender As Object, e As EventArgs) Handles btnTra.Click
        Dim diemMin As Double
        Dim diemMax As Double
        If Double.TryParse(txtTu.Text, diemMin) AndAlso Double.TryParse(txtDen.Text, diemMax) Then
            HienThiSinhVienTheoDiem1(diemMin, diemMax)
        Else
            MsgBox("Vui lòng nhập giá trị số hợp lệ cho cả hai TextBox.")
        End If
        tabdiemdi.SelectedTabPageIndex = 2

    End Sub
    '--tra theo điểm và các mã môn học
    Private Sub HienThidiem(diemMin As Double, diemMax As Double, selectedItems As List(Of String))
        ' Xóa dữ liệu hiển thị trên GridView
        grdHienthi.DataSource = Nothing
        grdHienthi.RefreshDataSource()
        ' Tạo chuỗi kết nối và câu truy vấn SQL
        Dim ChuoiKetNoi As String = "Data Source=123.24.142.45,2019;Initial Catalog=NanoThucTap;Persist Security Info=True;User ID=his;Password=s@123456;Connection Timeout=3"
        Dim sqlQuery As String = "EXEC SelectByIDs @IDs"

        ' Tạo đối tượng kết nối và truy vấn
        Dim connection As New SqlConnection(ChuoiKetNoi)
        Dim command As New SqlCommand(sqlQuery, connection)
        command.Parameters.AddWithValue("@IDs", String.Join(",", selectedItems))

        ' Mở kết nối và thực hiện truy vấn
        connection.Open()
        Dim adapter As New SqlDataAdapter(command)
        Dim ds As New DataSet()
        adapter.Fill(ds, "tbl_KetQuaHocTap")
        connection.Close()

        ' Hiển thị kết quả trên GridView
        grdHienthi.DataSource = ds.Tables("tbl_KetQuaHocTap")
        grdHienthi.RefreshDataSource()
    End Sub

    Private Sub btntratiep_Click(sender As Object, e As EventArgs) Handles btntratiep.Click
        If txtTu.Text = "" OrElse txtDen.Text = "" Then
            MsgBox("Chưa nhập đủ thông tin")
        Else
            Dim diemMin As Double
            Dim diemMax As Double
            Dim selectedItems As New List(Of String)()

            If Double.TryParse(txtTu.Text, diemMin) AndAlso Double.TryParse(txtDen.Text, diemMax) Then
                For Each item As String In ckbCbMaMH.Properties.GetItems.GetCheckedValues()
                    selectedItems.Add(item)
                Next

                If selectedItems.Count > 0 Then
                    HienThidiem(diemMin, diemMax, selectedItems)
                    HienThiSinhVienTheoDiem1(diemMin, diemMax)
                    tabdiemdi.SelectedTabPageIndex = 2

                    Dim dt As DataTable = CType(grdHienthi.DataSource, DataTable)
                    Dim diemThapNhat As Double = Double.MaxValue
                    Dim diemCaoNhat As Double = Double.MinValue

                    For Each row As DataRow In dt.Rows
                        Dim diem As Double = Convert.ToDouble(row("DiemThi"))

                        ' Tìm điểm thấp nhất
                        If diem < diemThapNhat Then
                            diemThapNhat = diem
                        End If

                        ' Tìm điểm cao nhất
                        If diem > diemCaoNhat Then
                            diemCaoNhat = diem
                        End If
                    Next

                    lbThap.Text = "Điểm thấp nhất: " & diemThapNhat.ToString()
                    lbCao.Text = "Điểm cao nhất: " & diemCaoNhat.ToString()
                Else
                    MsgBox("Chưa chọn mã môn học")
                End If
            Else
                MsgBox("Vui lòng nhập giá trị số hợp lệ cho cả hai TextBox.")
            End If
            ckbCbMaMH.Text = Nothing
            lbThap.Text = Nothing
            lbCao.Text = Nothing
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtTu.Text = ""
        txtDen.Text = ""
        ckbCbMaMH.EditValue = Nothing
    End Sub


#End Region
End Class