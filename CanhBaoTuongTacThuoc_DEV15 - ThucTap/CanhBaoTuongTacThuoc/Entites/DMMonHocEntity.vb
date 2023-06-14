Public Class DMMonHocEntity
    Private _ID As String
    Public Property ID() As String
        Get
            Return _ID
        End Get
        Set(ByVal value As String)
            _ID = value
        End Set
    End Property

    Private _MaMonHoc As String
    Public Property MaMonHoc() As String
        Get
            Return _MaMonHoc
        End Get
        Set(ByVal value As String)
            _MaMonHoc = value
        End Set
    End Property

    Private _TenMonHoc As String
    Public Property TenMonHoc() As String
        Get
            Return _TenMonHoc
        End Get
        Set(ByVal value As String)
            _TenMonHoc = value
        End Set
    End Property

End Class
