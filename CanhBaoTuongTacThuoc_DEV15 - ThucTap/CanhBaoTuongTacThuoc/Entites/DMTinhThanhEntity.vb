Public Class DMTinhThanhEntity
    Private _MaTinhThanh As String
    Public Property MaTinhThanh() As String
        Get
            Return _MaTinhThanh
        End Get
        Set(ByVal value As String)
            _MaTinhThanh = value
        End Set
    End Property

    Private _TenTinhThanh As String
    Public Property TenTinhThanh() As String
        Get
            Return _TenTinhThanh
        End Get
        Set(ByVal value As String)
            _TenTinhThanh = value
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
    Private _MaQuocGia As String
    Public Property MaQuocGia() As String
        Get
            Return _MaQuocGia
        End Get
        Set(ByVal value As String)
            _MaQuocGia = value
        End Set
    End Property
End Class
