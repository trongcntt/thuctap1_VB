Public Class ReturnSQLEntity
    Private _ParameterName As String
    Private _ParameterType As System.Data.DbType
    Private _Value As Object
    Sub New(ByVal ParameterName As String, ByVal ParameterType As System.Data.DbType, ByVal Value As Object)
        _ParameterName = ParameterName
        _ParameterType = ParameterType
        _Value = Value
    End Sub
    Public Property Value() As Object
        Get
            Return _Value
        End Get
        Set(ByVal value As Object)
            _Value = value
        End Set
    End Property
    Public Property ParameterName() As String
        Get
            Return _ParameterName
        End Get
        Set(ByVal value As String)
            _ParameterName = value
        End Set
    End Property

    Public Property ParameterType() As System.Data.DbType
        Get
            Return _ParameterType
        End Get
        Set(ByVal value As System.Data.DbType)
            _ParameterType = value
        End Set
    End Property
End Class
