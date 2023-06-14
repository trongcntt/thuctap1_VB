Imports System.Data.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class DMMonHocDA
    Private objLog As New LogError.ShowError

    Public Function DMMonHoc_Insert(obj As DMMonHocEntity) As Boolean
        Dim db As Database
        Dim sp As String = "DMMonHoc_insert"
        Dim objCmd As DbCommand

        Try

            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)
            db.AddInParameter(objCmd, "MaMH", System.Data.DbType.String, obj.MaMonHoc)
            db.AddInParameter(objCmd, "@TenMH", System.Data.DbType.String, obj.TenMonHoc)
            db.ExecuteNonQuery(objCmd)
            Return True
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return False
        End Try
    End Function
    Public Function DMMonHoc_Update(obj As DMMonHocEntity) As Boolean
        Dim db As Database
        Dim sp As String = "DMMonHoc_update"
        Dim objCmd As DbCommand

        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)
            db.AddInParameter(objCmd, "@Id", System.Data.DbType.String, obj.ID)
            db.AddInParameter(objCmd, "MaMH", System.Data.DbType.String, obj.MaMonHoc)
            db.AddInParameter(objCmd, "@TenMH", System.Data.DbType.String, obj.TenMonHoc)
            db.ExecuteNonQuery(objCmd)
            Return True
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return False
        End Try
    End Function
    Public Function DMMonHoc_DeleteByID(obj As DMMonHocEntity) As Boolean
        Dim db As Database
        Dim sp As String = "DMMonHoc_DeleteID"
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
    Public Function DMMonHoc_SelectByID(obj As DMMonHocEntity) As DMMonHocEntity
        Dim db As Database
        Dim sp As String = "DMMonHoc_SelectId"
        Dim objCmd As DbCommand
        Dim ds As DataSet = Nothing
        Dim objMonHoc As DMMonHocEntity = Nothing
        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)

            db.AddInParameter(objCmd, "@id", System.Data.DbType.String, obj.ID)
            ds = db.ExecuteDataSet(objCmd)
            If ds IsNot Nothing And ds.Tables(0).Rows.Count > 0 Then
                objMonHoc = New DMMonHocEntity
                For Each r As DataRow In ds.Tables(0).Rows
                    With objMonHoc
                        .ID = IIf(IsDBNull(r.Item("ID")), "", r.Item("ID").ToString)
                        .MaMonHoc = IIf(IsDBNull(r.Item("MaMonHoc")), "", r.Item("MaMonHoc").ToString)
                        .TenMonHoc = IIf(IsDBNull(r.Item("TenMonHoc")), "", r.Item("TenMonHoc").ToString)
                    End With
                Next
            End If
            Return objMonHoc
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function DMMonHoc_SelectAll() As List(Of DMMonHocEntity)
        Dim db As Database
        Dim sp As String = "DMMonHoc_selectAll"
        Dim objCmd As DbCommand
        Dim ds As DataSet = Nothing
        Dim listObjMonHoc As List(Of DMMonHocEntity) = Nothing
        Dim i As Integer = 0
        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)
            ds = db.ExecuteDataSet(objCmd)
            If ds IsNot Nothing And ds.Tables(0).Rows.Count > 0 Then
                listObjMonHoc = New List(Of DMMonHocEntity)
                For Each r As DataRow In ds.Tables(0).Rows
                    listObjMonHoc.Add(New DMMonHocEntity)
                    With listObjMonHoc(i)
                        .ID = IIf(IsDBNull(r.Item("ID")), "", r.Item("ID").ToString)
                        .MaMonHoc = IIf(IsDBNull(r.Item("MaMonHoc")), "", r.Item("MaMonHoc").ToString)
                        .TenMonHoc = IIf(IsDBNull(r.Item("TenMonHoc")), "", r.Item("TenMonHoc").ToString)
                    End With
                    i += 1
                Next
            End If
            Return listObjMonHoc
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return Nothing
        End Try
    End Function
End Class
