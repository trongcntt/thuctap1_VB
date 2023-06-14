Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data
Imports System.Data.Common
Imports Microsoft.VisualBasic
Public Class DMLopHocDA
    Private objLog As New LogError.ShowError

    Public Function DMlopHoc_Insert(obj As DMLopHocEntity) As Boolean
        Dim db As Database
        Dim sp As String = "ThemLopHoc"
        Dim objCmd As DbCommand

        Try

            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)

            db.AddInParameter(objCmd, "@MaLop", System.Data.DbType.String, obj.MaLop)
            db.AddInParameter(objCmd, "@TenLop", System.Data.DbType.String, obj.TenLop)
            db.AddInParameter(objCmd, "@GhiChu", System.Data.DbType.String, obj.GhiChu)
            db.ExecuteNonQuery(objCmd)
            Return True
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return False
        End Try
    End Function
    Public Function DMLopHoc_Update(obj As DMLopHocEntity) As Boolean
        Dim db As Database
        Dim sp As String = "EditLopHoc"
        Dim objCmd As DbCommand

        Try

            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)
            db.AddInParameter(objCmd, "@id", System.Data.DbType.String, obj.ID)
            db.AddInParameter(objCmd, "@MaLop", System.Data.DbType.String, obj.MaLop)
            db.AddInParameter(objCmd, "@TenLop", System.Data.DbType.String, obj.TenLop)
            db.AddInParameter(objCmd, "@GhiChu", System.Data.DbType.String, obj.GhiChu)
            db.ExecuteNonQuery(objCmd)
            Return True
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return False
        End Try
    End Function

    Public Function DMLopHoc_DeleteByID(obj As DMLopHocEntity) As Boolean
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


    Public Function DMLopHoc_SelectByID(obj As DMLopHocEntity) As DMLopHocEntity
        Dim db As Database
        Dim sp As String = "laydataByid"
        Dim objCmd As DbCommand
        Dim ds As DataSet = Nothing
        Dim objCanhBaoThuoc As DMLopHocEntity = Nothing
        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)

            db.AddInParameter(objCmd, "@Id", System.Data.DbType.String, obj.ID)
            ds = db.ExecuteDataSet(objCmd)
            If ds IsNot Nothing And ds.Tables(0).Rows.Count > 0 Then
                objCanhBaoThuoc = New DMLopHocEntity
                For Each r As DataRow In ds.Tables(0).Rows
                    With objCanhBaoThuoc
                        .MaLop = IIf(IsDBNull(r.Item("MaLop")), "", r.Item("MaLop").ToString)
                        .TenLop = IIf(IsDBNull(r.Item("TenLop")), "", r.Item("TenLop").ToString)
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




    Public Function DMLopHoc_SelectAll() As List(Of DMLopHocEntity)
        Dim db As Database
        Dim sp As String = "laydsLopHoc"
        Dim objCmd As DbCommand
        Dim ds As DataSet = Nothing
        Dim listObjCanhBaoThuoc As List(Of DMLopHocEntity) = Nothing
        Dim i As Integer = 0
        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)
            ds = db.ExecuteDataSet(objCmd)
            If ds IsNot Nothing And ds.Tables(0).Rows.Count > 0 Then
                listObjCanhBaoThuoc = New List(Of DMLopHocEntity)
                For Each r As DataRow In ds.Tables(0).Rows
                    listObjCanhBaoThuoc.Add(New DMLopHocEntity)
                    With listObjCanhBaoThuoc(i)
                        .ID = IIf(IsDBNull(r.Item("ID")), "", r.Item("ID").ToString)
                        .MaLop = IIf(IsDBNull(r.Item("MaLop")), "", r.Item("MaLop").ToString)
                        .TenLop = IIf(IsDBNull(r.Item("TenLop")), "", r.Item("TenLop").ToString)
                        .GhiChu = IIf(IsDBNull(r.Item("GhiChu")), "", r.Item("GhiChu").ToString)
                    End With
                    i += 1
                Next
            End If
            Return listObjCanhBaoThuoc
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return Nothing
        End Try
    End Function


End Class

