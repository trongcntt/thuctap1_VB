Public Class DMQuanHuyenEntity
    Private _MaQuanHuyen As String
    Public Property MaQuanHuyen() As String
        Get
            Return _MaQuanHuyen
        End Get
        Set(ByVal value As String)
            _MaQuanHuyen = value
        End Set
    End Property

    Private _TenQuanHuyen As String
    Public Property TenQuanHuyen() As String
        Get
            Return _TenQuanHuyen
        End Get
        Set(ByVal value As String)
            _TenQuanHuyen = value
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
    Private _MaTinhThanh As String
    Public Property MaTinhThanh() As String
        Get
            Return _MaTinhThanh
        End Get
        Set(ByVal value As String)
            _MaTinhThanh = value
        End Set
    End Property

End Class
