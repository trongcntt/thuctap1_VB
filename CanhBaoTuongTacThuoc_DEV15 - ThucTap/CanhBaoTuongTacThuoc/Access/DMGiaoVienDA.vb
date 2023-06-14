
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data
Imports System.Data.Common
Imports Microsoft.VisualBasic
Public Class DMGiaoVienDA
    Private objLog As New LogError.ShowError

    Public Function DMGiaoVien_Insert(obj As DMGiaoVienEntity) As Boolean
        Dim db As Database
        Dim sp As String = "Themgiaovien"
        Dim objCmd As DbCommand

        Try

            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)

            db.AddInParameter(objCmd, "@MaGV", System.Data.DbType.String, obj.MaGiaoVien)
            db.AddInParameter(objCmd, "@TenGV", System.Data.DbType.String, obj.TenGiaoVien)
            db.AddInParameter(objCmd, "@GhiChu", System.Data.DbType.String, obj.GhiChu)
            db.ExecuteNonQuery(objCmd)
            Return True
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return False
        End Try
    End Function

    Public Function DMGiaoVien_Update(obj As DMGiaoVienEntity) As Boolean
        Dim db As Database
        Dim sp As String = "updateGV"
        Dim objCmd As DbCommand

        Try

            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)
            db.AddInParameter(objCmd, "@id", System.Data.DbType.String, obj.ID)
            db.AddInParameter(objCmd, "@MaGV", System.Data.DbType.String, obj.MaGiaoVien)
            db.AddInParameter(objCmd, "@TenGV", System.Data.DbType.String, obj.TenGiaoVien)
            db.AddInParameter(objCmd, "@GhiChu", System.Data.DbType.String, obj.GhiChu)
            db.ExecuteNonQuery(objCmd)
            Return True
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return False
        End Try
    End Function
    Public Function DMGiaoVien_DeleteByID(obj As DMGiaoVienEntity) As Boolean
        Dim db As Database
        Dim sp As String = "DeleteLopHoc"
        Dim objCmd As DbCommand

        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)
            db.AddInParameter(objCmd, "@Id", System.Data.DbType.String, obj.ID)
            db.ExecuteNonQuery(objCmd)
            Return True
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return False
        End Try
    End Function
    Public Function DMGiaoVien_DeleteByMagv(obj As DMGiaoVienEntity) As Boolean
        Dim db As Database
        Dim sp As String = "XoaId"
        Dim objCmd As DbCommand

        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)

            db.AddInParameter(objCmd, "@Id", System.Data.DbType.String, obj.ID)

            db.ExecuteNonQuery(objCmd)
            Return True
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return False
        End Try
    End Function
    Public Function DMGiaoVien_SelectByID(obj As DMGiaoVienEntity) As DMGiaoVienEntity
        Dim db As Database
        Dim sp As String = "selectbyMaGV"
        Dim objCmd As DbCommand
        Dim ds As DataSet = Nothing
        Dim objCanhBaoThuoc As DMGiaoVienEntity = Nothing
        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)

            db.AddInParameter(objCmd, "@Magv", System.Data.DbType.String, obj.MaGiaoVien)
            ds = db.ExecuteDataSet(objCmd)
            If ds IsNot Nothing And ds.Tables(0).Rows.Count > 0 Then
                objCanhBaoThuoc = New DMGiaoVienEntity
                For Each r As DataRow In ds.Tables(0).Rows
                    With objCanhBaoThuoc
                        .MaGiaoVien = IIf(IsDBNull(r.Item("MaGiaoVien")), "", r.Item("MaGiaoVien").ToString)
                        .TenGiaoVien = IIf(IsDBNull(r.Item("TenGiaoVien")), "", r.Item("TenGiaoVien").ToString)
                        .GhiChu = IIf(IsDBNull(r.Item("GhiChu")), "", r.Item("GhiChu").ToString)

                    End With
                Next
            End If
            Return objCanhBaoThuoc
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function DMGiaoVien_SelectAll() As List(Of DMGiaoVienEntity)
        Dim db As Database
        Dim sp As String = "laydataGiaoVien"
        Dim objCmd As DbCommand
        Dim ds As DataSet = Nothing
        Dim listObGiaoVien As List(Of DMGiaoVienEntity) = Nothing
        Dim i As Integer = 0
        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)
            ds = db.ExecuteDataSet(objCmd)
            If ds IsNot Nothing And ds.Tables(0).Rows.Count > 0 Then
                listObGiaoVien = New List(Of DMGiaoVienEntity)
                For Each r As DataRow In ds.Tables(0).Rows
                    listObGiaoVien.Add(New DMGiaoVienEntity)
                    With listObGiaoVien(i)
                        .ID = IIf(IsDBNull(r.Item("ID")), "", r.Item("ID").ToString)
                        .MaGiaoVien = IIf(IsDBNull(r.Item("MaGiaoVien")), "", r.Item("MaGiaoVien").ToString)
                        .TenGiaoVien = IIf(IsDBNull(r.Item("TenGiaoVien")), "", r.Item("TenGiaoVien").ToString)
                        .GhiChu = IIf(IsDBNull(r.Item("GhiChu")), "", r.Item("GhiChu").ToString)

                    End With
                    i += 1
                Next
            End If
            Return listObGiaoVien
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return Nothing
        End Try
    End Function

End Class
