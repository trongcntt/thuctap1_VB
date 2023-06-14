Imports System.Data.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class DMTinhThanhDA
    Private objLog As New LogError.ShowError

    Public Function DMTinhThanh_Insert(obj As DMTinhThanhEntity) As Boolean
        Dim db As Database
        Dim sp As String = "DMTinhThanh_insert"
        Dim objCmd As DbCommand

        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)
            db.AddInParameter(objCmd, "@MaTT", System.Data.DbType.String, obj.MaTinhThanh)
            db.AddInParameter(objCmd, "@TenTT", System.Data.DbType.String, obj.TenTinhThanh)
            db.AddInParameter(objCmd, "@GhiChu", System.Data.DbType.String, obj.GhiChu)
            db.AddInParameter(objCmd, "@MaQG", System.Data.DbType.String, obj.MaQuocGia)
            'db.AddInParameter(objCmd, "@MaqhBh", System.Data.DbType.String, obj.MaQuanHuyen_BH)
            db.ExecuteNonQuery(objCmd)
            Return True
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return False
        End Try
    End Function
    Public Function DMTinhThanh_Update(obj As DMTinhThanhEntity) As Boolean
        Dim db As Database
        Dim sp As String = "DMTinhThanh_update"
        Dim objCmd As DbCommand

        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)
            db.AddInParameter(objCmd, "@MaTT", System.Data.DbType.String, obj.MaTinhThanh)
            db.AddInParameter(objCmd, "@TenTT", System.Data.DbType.String, obj.TenTinhThanh)
            db.AddInParameter(objCmd, "@GhiChu", System.Data.DbType.String, obj.GhiChu)
            db.AddInParameter(objCmd, "@MaQG", System.Data.DbType.String, obj.MaQuocGia)
            ' db.AddInParameter(objCmd, "@MaqhBh", System.Data.DbType.String, obj.MaQuanHuyen_BH)
            db.ExecuteNonQuery(objCmd)
            Return True
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return False
        End Try
    End Function
    Public Function DMTinhThanh_DeleteByID(obj As DMTinhThanhEntity) As Boolean
        Dim db As Database
        Dim sp As String = "DMTinhThanh_deleteID"
        Dim objCmd As DbCommand

        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)
            db.AddInParameter(objCmd, "@Id", System.Data.DbType.String, obj.MaTinhThanh)
            db.ExecuteNonQuery(objCmd)
            Return True
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return False
        End Try
    End Function
    Public Function DMTinhThanh_SelectByID(obj As DMTinhThanhEntity) As DMTinhThanhEntity
        Dim db As Database
        Dim sp As String = "DMTinhThanh_SelectID"
        Dim objCmd As DbCommand
        Dim ds As DataSet = Nothing
        Dim objTinhThanh As DMTinhThanhEntity = Nothing
        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)

            db.AddInParameter(objCmd, "@Id", System.Data.DbType.String, obj.MaTinhThanh)
            ds = db.ExecuteDataSet(objCmd)
            If ds IsNot Nothing And ds.Tables(0).Rows.Count > 0 Then
                objTinhThanh = New DMTinhThanhEntity
                For Each r As DataRow In ds.Tables(0).Rows
                    With objTinhThanh
                        .MaTinhThanh = IIf(IsDBNull(r.Item("MaTinhThanh")), "", r.Item("MaTinhThanh").ToString)
                        .TenTinhThanh = IIf(IsDBNull(r.Item("TenTinhThanh")), "", r.Item("TenTinhThanh").ToString)
                        .GhiChu = IIf(IsDBNull(r.Item("GhiChu")), "", r.Item("GhiChu").ToString)
                        .MaQuocGia = IIf(IsDBNull(r.Item("MaQuocGia")), "", r.Item("MaQuocGia").ToString)
                        ' .MaQuanHuyen_BH = IIf(IsDBNull(r.Item("MaQuanHuyen_BH")), "", r.Item("MaQuanHuyen_BH").ToString)

                    End With
                Next
            End If
            Return objTinhThanh
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function DMTinhThanh_SelectAll() As List(Of DMTinhThanhEntity)
        Dim db As Database
        Dim sp As String = "DMTinhThanh_selectAll"
        Dim objCmd As DbCommand
        Dim ds As DataSet = Nothing
        Dim listObjTinhThanh As List(Of DMTinhThanhEntity) = Nothing
        Dim i As Integer = 0
        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)
            ds = db.ExecuteDataSet(objCmd)
            If ds IsNot Nothing And ds.Tables(0).Rows.Count > 0 Then
                listObjTinhThanh = New List(Of DMTinhThanhEntity)
                For Each r As DataRow In ds.Tables(0).Rows
                    listObjTinhThanh.Add(New DMTinhThanhEntity)
                    With listObjTinhThanh(i)
                        .MaTinhThanh = IIf(IsDBNull(r.Item("MaTinhThanh")), "", r.Item("MaTinhThanh").ToString)
                        .TenTinhThanh = IIf(IsDBNull(r.Item("TenTinhThanh")), "", r.Item("TenTinhThanh").ToString)
                        .GhiChu = IIf(IsDBNull(r.Item("GhiChu")), "", r.Item("GhiChu").ToString)
                        .MaQuocGia = IIf(IsDBNull(r.Item("MaQuocGia")), "", r.Item("MaQuocGia").ToString)
                        '.MaQuanHuyen_BH = IIf(IsDBNull(r.Item("MaQuanHuyen_BH")), "", r.Item("MaQuanHuyen_BH").ToString)

                    End With
                    i += 1
                Next
            End If
            Return listObjTinhThanh
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return Nothing
        End Try
    End Function
End Class
