Imports System.Data.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class DMKetQuaHocTapDA
    Private objLog As New LogError.ShowError

    Public Function DMKQ_Insert(obj As DMKetQuaHocTapEntity) As Boolean
        Dim db As Database
        Dim sp As String = "DMKQ_insert"
        Dim objCmd As DbCommand

        Try

            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)
            db.AddInParameter(objCmd, "@MaGV", System.Data.DbType.String, obj.MaGiaoVien)
            db.AddInParameter(objCmd, "@MaLopHoc", System.Data.DbType.String, obj.MaLopHoc)
            db.AddInParameter(objCmd, "@MaSinhVien", System.Data.DbType.String, obj.MaSinhVien)
            db.AddInParameter(objCmd, "@MaMonHoc", System.Data.DbType.String, obj.MaMonHoc)
            db.AddInParameter(objCmd, "@DiemThi", System.Data.DbType.Double, obj.DiemThi)
            db.AddInParameter(objCmd, "@NgayThi", System.Data.DbType.DateTime, obj.NgayThi)
            db.ExecuteNonQuery(objCmd)
            Return True
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return False
        End Try
    End Function
    Public Function DMKQ_Update(obj As DMKetQuaHocTapEntity) As Boolean
        Dim db As Database
        Dim sp As String = "DMKQ_update"
        Dim objCmd As DbCommand

        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)
            db.AddInParameter(objCmd, "@Id", System.Data.DbType.String, obj.ID)
            db.AddInParameter(objCmd, "@MaGV", System.Data.DbType.String, obj.MaGiaoVien)
            db.AddInParameter(objCmd, "@MaLopHoc", System.Data.DbType.String, obj.MaLopHoc)
            db.AddInParameter(objCmd, "@MaSinhVien", System.Data.DbType.String, obj.MaSinhVien)
            db.AddInParameter(objCmd, "@MaMonHoc", System.Data.DbType.String, obj.MaMonHoc)
            db.AddInParameter(objCmd, "@DiemThi", System.Data.DbType.Double, obj.DiemThi)
            db.AddInParameter(objCmd, "@NgayThi", System.Data.DbType.DateTime, obj.NgayThi)
            db.ExecuteNonQuery(objCmd)
            Return True
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return False
        End Try
    End Function

    Public Function DMKQ_DeleteByID(obj As DMKetQuaHocTapEntity) As Boolean
        Dim db As Database
        Dim sp As String = "DMKQ_deleteId"
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


    Public Function DMKQ_SelectByID(obj As DMKetQuaHocTapEntity) As DMKetQuaHocTapEntity
        Dim db As Database
        Dim sp As String = "DMKQ_selectId"
        Dim objCmd As DbCommand
        Dim ds As DataSet = Nothing
        Dim objKetQua As DMKetQuaHocTapEntity = Nothing
        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)

            db.AddInParameter(objCmd, "@Id", System.Data.DbType.String, obj.ID)
            ds = db.ExecuteDataSet(objCmd)
            If ds IsNot Nothing And ds.Tables(0).Rows.Count > 0 Then
                objKetQua = New DMKetQuaHocTapEntity
                For Each r As DataRow In ds.Tables(0).Rows
                    With objKetQua
                        .ID = IIf(IsDBNull(r.Item("ID")), "", r.Item("ID").ToString)
                        .MaGiaoVien = IIf(IsDBNull(r.Item("MaGiaoVien")), "", r.Item("MaGiaoVien").ToString)
                        .MaLopHoc = IIf(IsDBNull(r.Item("MaLopHoc")), "", r.Item("MaLopHoc").ToString)
                        .MaSinhVien = IIf(IsDBNull(r.Item("MaSinhVien")), "", r.Item("MaSinhVien").ToString)
                        .MaMonHoc = IIf(IsDBNull(r.Item("MaMonHoc")), "", r.Item("MaMonHoc").ToString)
                        .DiemThi = IIf(IsDBNull(r.Item("DiemThi")), "", r.Item("DiemThi").ToString)
                        .NgayThi = IIf(IsDBNull(r.Item("NgayThi")), "", r.Item("NgayThi").ToString)

                    End With
                Next
            End If
            Return objKetQua
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function DMkq_SelectAll() As List(Of DMKetQuaHocTapEntity)
        Dim db As Database
        Dim sp As String = "DMKQ_selectAll"
        Dim objCmd As DbCommand
        Dim ds As DataSet = Nothing
        Dim listObjKetQua As List(Of DMKetQuaHocTapEntity) = Nothing
        Dim i As Integer = 0
        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)
            ds = db.ExecuteDataSet(objCmd)
            If ds IsNot Nothing And ds.Tables(0).Rows.Count > 0 Then
                listObjKetQua = New List(Of DMKetQuaHocTapEntity)
                For Each r As DataRow In ds.Tables(0).Rows
                    listObjKetQua.Add(New DMKetQuaHocTapEntity)
                    With listObjKetQua(i)
                        .ID = IIf(IsDBNull(r.Item("ID")), "", r.Item("ID").ToString)
                        .MaGiaoVien = IIf(IsDBNull(r.Item("MaGiaoVien")), "", r.Item("MaGiaoVien").ToString)
                        .MaLopHoc = IIf(IsDBNull(r.Item("MaLopHoc")), "", r.Item("MaLopHoc").ToString)
                        .MaSinhVien = IIf(IsDBNull(r.Item("MaSinhVien")), "", r.Item("MaSinhVien").ToString)
                        .MaMonHoc = IIf(IsDBNull(r.Item("MaMonHoc")), "", r.Item("MaMonHoc").ToString)
                        .DiemThi = IIf(IsDBNull(r.Item("DiemThi")), "", r.Item("DiemThi").ToString)
                        .NgayThi = IIf(IsDBNull(r.Item("NgayThi")), "", r.Item("NgayThi").ToString)
                    End With
                    i += 1
                Next
            End If
            Return listObjKetQua
        Catch ex As Exception
            objLog.WriteLog(sp, ex.Message)
            Return Nothing
        End Try
    End Function

End Class
