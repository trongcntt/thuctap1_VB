Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data
Imports System.Data.Common
Public Class ReturnSQLDA
    Private objLog As New LogError.ShowError
    Public Function ReturnBoolean(ByVal sqlString As String, ByVal ListPara As List(Of ReturnSQLEntity)) As Boolean
        Dim db As Database
        Dim sp As String = sqlString
        Dim objCmd As DbCommand
        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)
            objCmd.CommandTimeout = 10000
            For Each para As ReturnSQLEntity In ListPara
                db.AddInParameter(objCmd, "@" & para.ParameterName, para.ParameterType, para.Value)
            Next
            db.ExecuteNonQuery(objCmd)
            Return True
        Catch ex As Exception
            objLog.WriteLog(sqlString, ex.Message)
            Return False
        End Try
    End Function
    Public Function ReturnDataTable(ByVal sqlString As String, ByVal ListPara As List(Of ReturnSQLEntity)) As DataTable
        Dim db As Database
        Dim sp As String = sqlString
        Dim objCmd As DbCommand
        Dim objDs As DataSet
        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)
            objCmd.CommandTimeout = 10000
            For Each para As ReturnSQLEntity In ListPara
                db.AddInParameter(objCmd, "@" & para.ParameterName, para.ParameterType, para.Value)
            Next
            objDs = db.ExecuteDataSet(objCmd)
            Return objDs.Tables(0)
        Catch ex As Exception
            objLog.WriteLog(sqlString, ex.Message)
            Return New DataTable
        End Try
    End Function
    Public Function ReturnDataSet(ByVal sqlString As String, ByVal ListPara As List(Of ReturnSQLEntity)) As DataSet
        Dim db As Database
        Dim sp As String = sqlString
        Dim objCmd As DbCommand
        Dim objDs As DataSet
        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)
            objCmd.CommandTimeout = 10000
            For Each para As ReturnSQLEntity In ListPara
                db.AddInParameter(objCmd, "@" & para.ParameterName, para.ParameterType, para.Value)
            Next
            objDs = db.ExecuteDataSet(objCmd)
            Return objDs
        Catch ex As Exception
            objLog.WriteLog(sqlString, ex.Message)
            Return New DataSet
        End Try
    End Function

    Public Function ReturnDataSetMutil(ByVal sqlString As String, ByVal ListPara As String)
        Dim db As Database
        Dim sp As String = sqlString
        Dim objCmd As DbCommand
        Dim objDs As DataSet
        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)
            objCmd.CommandTimeout = 10000
            'For Each para As ReturnSQLEntity In ListPara
            'db.AddInParameter(objCmd, "@" & para.ParameterName, para.ParameterType, para.Value)
            db.AddInParameter(objCmd, "@ID", DbType.String, ListPara)
            'Next
            objDs = db.ExecuteDataSet(objCmd)
            Return objDs
        Catch ex As Exception
            objLog.WriteLog(sqlString, ex.Message)
            Return New DataSet
        End Try
    End Function

    Public Sub ReturnObject(ByVal sqlString As String, ByVal ListPara As List(Of ReturnSQLEntity), ByVal objOut As ReturnSQLEntity, ByRef obj As Object) 'As Boolean
        Dim db As Database
        Dim sp As String = sqlString
        Dim objCmd As DbCommand
        Try
            db = New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ChuoiKetNoi)
            objCmd = db.GetStoredProcCommand(sp)
            objCmd.CommandTimeout = 10000
            db.AddOutParameter(objCmd, "@" + objOut.ParameterName, objOut.ParameterType, 50)
            For Each para As ReturnSQLEntity In ListPara
                db.AddInParameter(objCmd, "@" & para.ParameterName, para.ParameterType, para.Value)
            Next
            db.ExecuteNonQuery(objCmd)
            obj = db.GetParameterValue(objCmd, "@" + objOut.ParameterName)
            'Return True
        Catch ex As Exception
            objLog.WriteLog(sqlString, ex.Message)
            'Return False
        End Try
    End Sub

End Class
