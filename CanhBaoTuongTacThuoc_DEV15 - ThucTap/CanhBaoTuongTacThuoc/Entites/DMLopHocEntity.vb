Public Class DMLopHocEntity

    Private _ID As String
    Public Property ID() As String
        Get
            Return _ID
        End Get
        Set(ByVal value As String)
            _ID = value
        End Set
    End Property

    Private _MaLop As String
    Public Property MaLop() As String
        Get
            Return _MaLop
        End Get
        Set(ByVal value As String)
            _MaLop = value
        End Set
    End Property

    Private _TenLop As String
    Public Property TenLop() As String
        Get
            Return _TenLop
        End Get
        Set(ByVal value As String)
            _TenLop = value
        End Set
    End Property
    Private _GhiChu As String
    Public Property GhiChu() As String
        Get
            Return _GhiChu
        End Get
        Set(ByVal value As String)
            _GhiChu = value
        End Set
    End Property
End Class
