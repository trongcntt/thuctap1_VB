Imports System.Data.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class DMNguoiDungDA
    Private objLog As New LogError.ShowError

    Public Function DMNguoiDung_Insert(obj As DMNguoiDungEntity) As Boolean
        Dim db As Database
        Dim sp As String = "DMNguoiDung_insert"
        Dim objCmd As DbCommand

        Try

            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)

            db.AddInParameter(objCmd, "@MaND", System.Data.DbType.String, obj.MaNguoiDung)
            db.AddInParameter(objCmd, "@TenND", System.Data.DbType.String, obj.TenNguoiDung)
            db.AddInParameter(objCmd, "@MatKhau", System.Data.DbType.String, obj.MatKhau)
            db.ExecuteNonQuery(objCmd)
            Return True
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return False
        End Try
    End Function
    Public Function DMNguoiDung_Update(obj As DMNguoiDungEntity) As Boolean
        Dim db As Database
        Dim sp As String = "DMNguoiDung_update"
        Dim objCmd As DbCommand

        Try

            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)
            db.AddInParameter(objCmd, "@id", System.Data.DbType.String, obj.ID)
            db.AddInParameter(objCmd, "@MaND", System.Data.DbType.String, obj.MaNguoiDung)
            db.AddInParameter(objCmd, "@TenND", System.Data.DbType.String, obj.TenNguoiDung)
            db.AddInParameter(objCmd, "@MatKhau", System.Data.DbType.String, obj.MatKhau)
            db.ExecuteNonQuery(objCmd)
            Return True
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return False
        End Try
    End Function
    Public Function DMNguoiDung_DeleteByID(obj As DMNguoiDungEntity) As Boolean
        Dim db As Database
        Dim sp As String = "DMNguoiDung_DeleteID"
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
    Public Function DMNguoiDung_SelectByID(obj As DMNguoiDungEntity) As DMNguoiDungEntity
        Dim db As Database
        Dim sp As String = "DMNguoiDung_selectByID"
        Dim objCmd As DbCommand
        Dim ds As DataSet = Nothing
        Dim objNguoiDung As DMNguoiDungEntity = Nothing
        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)

            db.AddInParameter(objCmd, "@id", System.Data.DbType.String, obj.ID)
            ds = db.ExecuteDataSet(objCmd)
            If ds IsNot Nothing And ds.Tables(0).Rows.Count > 0 Then
                objNguoiDung = New DMNguoiDungEntity
                For Each r As DataRow In ds.Tables(0).Rows
                    With objNguoiDung
                        .MaNguoiDung = IIf(IsDBNull(r.Item("MaNguoiDung")), "", r.Item("MaNguoiDung").ToString)
                        .TenNguoiDung = IIf(IsDBNull(r.Item("TenNguoiDung")), "", r.Item("TenNguoiDung").ToString)
                        .MatKhau = IIf(IsDBNull(r.Item("MatKhau")), "", r.Item("MatKhau").ToString)

                    End With
                Next
            End If
            Return objNguoiDung
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function DMNguoiDung_SelectAll() As List(Of DMNguoiDungEntity)
        Dim db As Database
        Dim sp As String = "DMNguoiDung_selectAll"
        Dim objCmd As DbCommand
        Dim ds As DataSet = Nothing
        Dim listObjNguoiDung As List(Of DMNguoiDungEntity) = Nothing
        Dim i As Integer = 0
        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)
            ds = db.ExecuteDataSet(objCmd)
            If ds IsNot Nothing And ds.Tables(0).Rows.Count > 0 Then
                listObjNguoiDung = New List(Of DMNguoiDungEntity)
                For Each r As DataRow In ds.Tables(0).Rows
                    listObjNguoiDung.Add(New DMNguoiDungEntity)
                    With listObjNguoiDung(i)
                        .ID = IIf(IsDBNull(r.Item("ID")), "", r.Item("ID").ToString)
                        .MaNguoiDung = IIf(IsDBNull(r.Item("MaNguoiDung")), "", r.Item("MaNguoiDung").ToString)
                        .TenNguoiDung = IIf(IsDBNull(r.Item("TenNguoiDung")), "", r.Item("TenNguoiDung").ToString)
                        .MatKhau = IIf(IsDBNull(r.Item("MatKhau")), "", r.Item("MatKhau").ToString)

                    End With
                    i += 1
                Next
            End If
            Return listObjNguoiDung
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return Nothing
        End Try
    End Function

End Class
