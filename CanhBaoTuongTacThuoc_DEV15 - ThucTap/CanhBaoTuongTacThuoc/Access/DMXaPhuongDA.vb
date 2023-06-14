Imports System.Data.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class DMXaPhuongDA
    Private objLog As New LogError.ShowError
    Public Function DMXaPhuong_SelectAll() As List(Of DMXaPhuongEntity)
        Dim db As Database
        Dim sp As String = "DMXaPhuong_selectAll"
        Dim objCmd As DbCommand
        Dim ds As DataSet = Nothing
        Dim listObjXaPhuong As List(Of DMXaPhuongEntity) = Nothing
        Dim i As Integer = 0
        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)
            ds = db.ExecuteDataSet(objCmd)
            If ds IsNot Nothing And ds.Tables(0).Rows.Count > 0 Then
                listObjXaPhuong = New List(Of DMXaPhuongEntity)
                For Each r As DataRow In ds.Tables(0).Rows
                    listObjXaPhuong.Add(New DMXaPhuongEntity)
                    With listObjXaPhuong(i)
                        .MaXa = IIf(IsDBNull(r.Item("MaXa")), "", r.Item("MaXa").ToString)
                        .TenXa = IIf(IsDBNull(r.Item("TenXa")), "", r.Item("TenXa").ToString)
                        .MoTaThonXa = IIf(IsDBNull(r.Item("MoTaThonXa")), "", r.Item("MoTaThonXa").ToString)
                        .MaQuanHuyen = IIf(IsDBNull(r.Item("MaQuanHuyen")), "", r.Item("MaQuanHuyen").ToString)
                        '.MaQuanHuyen_BH = IIf(IsDBNull(r.Item("MaQuanHuyen_BH")), "", r.Item("MaQuanHuyen_BH").ToString)

                    End With
                    i += 1
                Next
            End If
            Return listObjXaPhuong
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function DMXaPhuong_Insert(obj As DMXaPhuongEntity) As Boolean
        Dim db As Database
        Dim sp As String = "DMXaPhuong_insert"
        Dim objCmd As DbCommand

        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)
            db.AddInParameter(objCmd, "@MaXa", System.Data.DbType.String, obj.MaXa)
            db.AddInParameter(objCmd, "@TenXa", System.Data.DbType.String, obj.TenXa)
            db.AddInParameter(objCmd, "@MotaThonXa", System.Data.DbType.String, obj.MoTaThonXa)
            db.AddInParameter(objCmd, "@MaQh", System.Data.DbType.String, obj.MaQuanHuyen)
            'db.AddInParameter(objCmd, "@MaqhBh", System.Data.DbType.String, obj.MaQuanHuyen_BH)
            db.ExecuteNonQuery(objCmd)
            Return True
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return False
        End Try
    End Function
    Public Function DMXaPhuong_Update(obj As DMXaPhuongEntity) As Boolean
        Dim db As Database
        Dim sp As String = "DMXaPhuong_update"
        Dim objCmd As DbCommand

        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)
            db.AddInParameter(objCmd, "@MaXa", System.Data.DbType.String, obj.MaXa)
            db.AddInParameter(objCmd, "@TenXa", System.Data.DbType.String, obj.TenXa)
            db.AddInParameter(objCmd, "@MotaThonXa", System.Data.DbType.String, obj.MoTaThonXa)
            db.AddInParameter(objCmd, "@MaQh", System.Data.DbType.String, obj.MaQuanHuyen)
            ' db.AddInParameter(objCmd, "@MaqhBh", System.Data.DbType.String, obj.MaQuanHuyen_BH)
            db.ExecuteNonQuery(objCmd)
            Return True
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return False
        End Try
    End Function
    Public Function DMXaPhuong_DeleteByID(obj As DMXaPhuongEntity) As Boolean
        Dim db As Database
        Dim sp As String = "DMXaPhuong_deleteID"
        Dim objCmd As DbCommand

        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)
            db.AddInParameter(objCmd, "@Id", System.Data.DbType.String, obj.MaXa)
            db.ExecuteNonQuery(objCmd)
            Return True
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return False
        End Try
    End Function
    Public Function DMXaPhuong_SelectByID(obj As DMXaPhuongEntity) As DMXaPhuongEntity
        Dim db As Database
        Dim sp As String = "DMXaPhuong_SelectID"
        Dim objCmd As DbCommand
        Dim ds As DataSet = Nothing
        Dim objXaPhuong As DMXaPhuongEntity = Nothing
        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)

            db.AddInParameter(objCmd, "@id", System.Data.DbType.String, obj.MaQuanHuyen)
            ds = db.ExecuteDataSet(objCmd)
            If ds IsNot Nothing And ds.Tables(0).Rows.Count > 0 Then
                objXaPhuong = New DMXaPhuongEntity
                For Each r As DataRow In ds.Tables(0).Rows
                    With objXaPhuong
                        .MaXa = IIf(IsDBNull(r.Item("MaXa")), "", r.Item("MaXa").ToString)
                        .TenXa = IIf(IsDBNull(r.Item("TenXa")), "", r.Item("TenXa").ToString)
                        .MoTaThonXa = IIf(IsDBNull(r.Item("MoTaThonXa")), "", r.Item("MoTaThonXa").ToString)
                        .MaQuanHuyen = IIf(IsDBNull(r.Item("MaQuanHuyen")), "", r.Item("MaQuanHuyen").ToString)
                        ' .MaQuanHuyen_BH = IIf(IsDBNull(r.Item("MaQuanHuyen_BH")), "", r.Item("MaQuanHuyen_BH").ToString)

                    End With
                Next
            End If
            Return objXaPhuong
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return Nothing
        End Try
    End Function
End Class
