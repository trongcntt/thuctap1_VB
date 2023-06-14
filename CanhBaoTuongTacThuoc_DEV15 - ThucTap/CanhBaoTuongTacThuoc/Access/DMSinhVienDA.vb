Imports System.Data.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class DMSinhVienDA
    Private objLog As New LogError.ShowError

    Public Function DMSinhVien_Insert(obj As DMSinhVienEntity) As Boolean
        Dim db As Database
        Dim sp As String = "InsertSV"
        Dim objCmd As DbCommand

        Try

            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)

            db.AddInParameter(objCmd, "@MaSV", System.Data.DbType.String, obj.MaSinhVien)
            db.AddInParameter(objCmd, "@MaLop", System.Data.DbType.String, obj.MaLop)
            db.AddInParameter(objCmd, "@MaGV", System.Data.DbType.String, obj.MaGiaoVien)
            db.AddInParameter(objCmd, "@TenSV", System.Data.DbType.String, obj.TenSinhVien)
            db.AddInParameter(objCmd, "@NamSinh", System.Data.DbType.String, obj.NamSinh)
            db.AddInParameter(objCmd, "@GioiTinh", System.Data.DbType.String, obj.GioiTinh)
            db.AddInParameter(objCmd, "@MaTT", System.Data.DbType.String, obj.MaTinhThanh)
            db.AddInParameter(objCmd, "@MaQH", System.Data.DbType.String, obj.MaQuanHuyen)
            db.AddInParameter(objCmd, "@MaXP", System.Data.DbType.String, obj.MaXaPhuong)
            db.ExecuteNonQuery(objCmd)
            Return True
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return False
        End Try
    End Function
    Public Function DMSinhVien_Update(obj As DMSinhVienEntity) As Boolean
        Dim db As Database
        Dim sp As String = "UpdateSV"
        Dim objCmd As DbCommand

        Try

            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)
            db.AddInParameter(objCmd, "@id", System.Data.DbType.String, obj.ID)
            db.AddInParameter(objCmd, "@MaSV", System.Data.DbType.String, obj.MaSinhVien)
            db.AddInParameter(objCmd, "@MaLop", System.Data.DbType.String, obj.MaLop)
            db.AddInParameter(objCmd, "@MaGV", System.Data.DbType.String, obj.MaGiaoVien)
            db.AddInParameter(objCmd, "@TenSV", System.Data.DbType.String, obj.TenSinhVien)
            db.AddInParameter(objCmd, "@NamSinh", System.Data.DbType.String, obj.NamSinh)
            db.AddInParameter(objCmd, "@GioiTinh", System.Data.DbType.String, obj.GioiTinh)
            db.AddInParameter(objCmd, "@MaTT", System.Data.DbType.String, obj.MaTinhThanh)
            db.AddInParameter(objCmd, "@MaQH", System.Data.DbType.String, obj.MaQuanHuyen)
            db.AddInParameter(objCmd, "@MaXP", System.Data.DbType.String, obj.MaXaPhuong)
            db.ExecuteNonQuery(objCmd)
            Return True
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return False
        End Try
    End Function
    Public Function DMSinhVien_DeleteByID(obj As DMSinhVienEntity) As Boolean
        Dim db As Database
        Dim sp As String = "DeleteID"
        Dim objCmd As DbCommand

        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)
            db.AddInParameter(objCmd, "@id", System.Data.DbType.String, obj.ID)
            db.ExecuteNonQuery(objCmd)
            Return True
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return False
        End Try
    End Function
    Public Function DMSinhVien_SelectByID(obj As DMSinhVienEntity) As DMSinhVienEntity
        Dim db As Database
        Dim sp As String = "selectID"
        Dim objCmd As DbCommand
        Dim ds As DataSet = Nothing
        Dim objSinhVien As DMSinhVienEntity = Nothing
        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)

            db.AddInParameter(objCmd, "@id", System.Data.DbType.String, obj.ID)
            ds = db.ExecuteDataSet(objCmd)
            If ds IsNot Nothing And ds.Tables(0).Rows.Count > 0 Then
                objSinhVien = New DMSinhVienEntity
                For Each r As DataRow In ds.Tables(0).Rows
                    With objSinhVien
                        .MaSinhVien = IIf(IsDBNull(r.Item("MaSinhVien")), "", r.Item("MaSinhVien").ToString)
                        .MaLop = IIf(IsDBNull(r.Item("MaLop")), "", r.Item("MaLop").ToString)
                        .MaGiaoVien = IIf(IsDBNull(r.Item("MaGiaoVien")), "", r.Item("MaGiaoVien").ToString)
                        .TenSinhVien = IIf(IsDBNull(r.Item("TenSinhVien")), "", r.Item("TenSinhVien").ToString)
                        .NamSinh = IIf(IsDBNull(r.Item("NamSinh")), "", r.Item("NamSinh").ToString)
                        .GioiTinh = IIf(IsDBNull(r.Item("GioiTinh")), "", r.Item("GioiTinh").ToString)
                        .MaTinhThanh = IIf(IsDBNull(r.Item("MaTinhThanh")), "", r.Item("MaTinhThanh").ToString)
                        .MaQuanHuyen = IIf(IsDBNull(r.Item("MaQuanHuyen")), "", r.Item("MaQuanHuyen").ToString)
                        .MaXaPhuong = IIf(IsDBNull(r.Item("MaXaPhuong")), "", r.Item("MaXaPhuong").ToString)

                    End With
                Next
            End If
            Return objSinhVien
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function DMSinhVien_SelectAll() As List(Of DMSinhVienEntity)
        Dim db As Database
        Dim sp As String = "SelectSV"
        Dim objCmd As DbCommand
        Dim ds As DataSet = Nothing
        Dim listObjSinhVien As List(Of DMSinhVienEntity) = Nothing
        Dim i As Integer = 0
        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)
            ds = db.ExecuteDataSet(objCmd)
            If ds IsNot Nothing And ds.Tables(0).Rows.Count > 0 Then
                listObjSinhVien = New List(Of DMSinhVienEntity)
                For Each r As DataRow In ds.Tables(0).Rows
                    listObjSinhVien.Add(New DMSinhVienEntity)
                    With listObjSinhVien(i)
                        .ID = IIf(IsDBNull(r.Item("ID")), "", r.Item("ID").ToString)
                        .MaSinhVien = IIf(IsDBNull(r.Item("MaSinhVien")), "", r.Item("MaSinhVien").ToString)
                        .MaLop = IIf(IsDBNull(r.Item("MaLop")), "", r.Item("MaLop").ToString)
                        .MaGiaoVien = IIf(IsDBNull(r.Item("MaGiaoVien")), "", r.Item("MaGiaoVien").ToString)
                        .TenSinhVien = IIf(IsDBNull(r.Item("TenSinhVien")), "", r.Item("TenSinhVien").ToString)
                        .NamSinh = IIf(IsDBNull(r.Item("NamSinh")), "", r.Item("NamSinh").ToString)
                        .GioiTinh = IIf(IsDBNull(r.Item("GioiTinh")), "", r.Item("GioiTinh").ToString)
                        .MaTinhThanh = IIf(IsDBNull(r.Item("MaTinhThanh")), "", r.Item("MaTinhThanh").ToString)
                        .MaQuanHuyen = IIf(IsDBNull(r.Item("MaQuanHuyen")), "", r.Item("MaQuanHuyen").ToString)
                        .MaXaPhuong = IIf(IsDBNull(r.Item("MaXaPhuong")), "", r.Item("MaXaPhuong").ToString)
                    End With
                    i += 1
                Next
            End If
            Return listObjSinhVien
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return Nothing
        End Try
    End Function

End Class
