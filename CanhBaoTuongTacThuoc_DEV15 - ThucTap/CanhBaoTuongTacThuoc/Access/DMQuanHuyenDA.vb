Imports System.Data.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class DMQuanHuyenDA
    Private objLog As New LogError.ShowError

    Public Function DMQuanHuyen_Insert(obj As DMQuanHuyenEntity) As Boolean
        Dim db As Database
        Dim sp As String = "DMQuanHuyen_insert"
        Dim objCmd As DbCommand

        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)
            db.AddInParameter(objCmd, "@Maqh", System.Data.DbType.String, obj.MaQuanHuyen)
            db.AddInParameter(objCmd, "@Tenqh", System.Data.DbType.String, obj.TenQuanHuyen)
            db.AddInParameter(objCmd, "@GhiChu", System.Data.DbType.String, obj.GhiChu)
            db.AddInParameter(objCmd, "@MaTT", System.Data.DbType.String, obj.MaTinhThanh)
            'db.AddInParameter(objCmd, "@MaqhBh", System.Data.DbType.String, obj.MaQuanHuyen_BH)
            db.ExecuteNonQuery(objCmd)
            Return True
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return False
        End Try
    End Function
    Public Function DMQuanHuyen_Update(obj As DMQuanHuyenEntity) As Boolean
        Dim db As Database
        Dim sp As String = "DMQuanHuyen_update"
        Dim objCmd As DbCommand

        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)
            db.AddInParameter(objCmd, "@Maqh", System.Data.DbType.String, obj.MaQuanHuyen)
            db.AddInParameter(objCmd, "@Tenqh", System.Data.DbType.String, obj.TenQuanHuyen)
            db.AddInParameter(objCmd, "@GhiChu", System.Data.DbType.String, obj.GhiChu)
            db.AddInParameter(objCmd, "@MaTT", System.Data.DbType.String, obj.MaTinhThanh)
            ' db.AddInParameter(objCmd, "@MaqhBh", System.Data.DbType.String, obj.MaQuanHuyen_BH)
            db.ExecuteNonQuery(objCmd)
            Return True
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return False
        End Try
    End Function
    Public Function DMQuanHuyen_DeleteByID(obj As DMQuanHuyenEntity) As Boolean
        Dim db As Database
        Dim sp As String = "DMQuanHuyen_DeleteID"
        Dim objCmd As DbCommand

        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)
            db.AddInParameter(objCmd, "@id", System.Data.DbType.String, obj.MaQuanHuyen)
            db.ExecuteNonQuery(objCmd)
            Return True
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return False
        End Try
    End Function
    Public Function DMQuanHuyen_SelectByID(obj As DMQuanHuyenEntity) As DMQuanHuyenEntity
        Dim db As Database
        Dim sp As String = "DMQuanHuyen_selectByID"
        Dim objCmd As DbCommand
        Dim ds As DataSet = Nothing
        Dim objQuanHuyen As DMQuanHuyenEntity = Nothing
        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)

            db.AddInParameter(objCmd, "@id", System.Data.DbType.String, obj.MaQuanHuyen)
            ds = db.ExecuteDataSet(objCmd)
            If ds IsNot Nothing And ds.Tables(0).Rows.Count > 0 Then
                objQuanHuyen = New DMQuanHuyenEntity
                For Each r As DataRow In ds.Tables(0).Rows
                    With objQuanHuyen
                        .MaQuanHuyen = IIf(IsDBNull(r.Item("MaQuanHuyen")), "", r.Item("MaQuanHuyen").ToString)
                        .TenQuanHuyen = IIf(IsDBNull(r.Item("TenQuanHuyen")), "", r.Item("TenQuanHuyen").ToString)
                        .GhiChu = IIf(IsDBNull(r.Item("GhiChu")), "", r.Item("GhiChu").ToString)
                        .MaTinhThanh = IIf(IsDBNull(r.Item("MaTinhThanh")), "", r.Item("MaTinhThanh").ToString)
                        ' .MaQuanHuyen_BH = IIf(IsDBNull(r.Item("MaQuanHuyen_BH")), "", r.Item("MaQuanHuyen_BH").ToString)

                    End With
                Next
            End If
            Return objQuanHuyen
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function DMQuanHuyen_SelectAll() As List(Of DMQuanHuyenEntity)
        Dim db As Database
        Dim sp As String = "DMQuanHuyen_selectAll"
        Dim objCmd As DbCommand
        Dim ds As DataSet = Nothing
        Dim listObjQuanHuyen As List(Of DMQuanHuyenEntity) = Nothing
        Dim i As Integer = 0
        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)
            ds = db.ExecuteDataSet(objCmd)
            If ds IsNot Nothing And ds.Tables(0).Rows.Count > 0 Then
                listObjQuanHuyen = New List(Of DMQuanHuyenEntity)
                For Each r As DataRow In ds.Tables(0).Rows
                    listObjQuanHuyen.Add(New DMQuanHuyenEntity)
                    With listObjQuanHuyen(i)
                        .MaQuanHuyen = IIf(IsDBNull(r.Item("MaQuanHuyen")), "", r.Item("MaQuanHuyen").ToString)
                        .TenQuanHuyen = IIf(IsDBNull(r.Item("TenQuanHuyen")), "", r.Item("TenQuanHuyen").ToString)
                        .GhiChu = IIf(IsDBNull(r.Item("GhiChu")), "", r.Item("GhiChu").ToString)
                        .MaTinhThanh = IIf(IsDBNull(r.Item("MaTinhThanh")), "", r.Item("MaTinhThanh").ToString)
                        '.MaQuanHuyen_BH = IIf(IsDBNull(r.Item("MaQuanHuyen_BH")), "", r.Item("MaQuanHuyen_BH").ToString)

                    End With
                    i += 1
                Next
            End If
            Return listObjQuanHuyen
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return Nothing
        End Try
    End Function

End Class
