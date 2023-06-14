Public Class DMGiaoVienEntity
    Private _ID As String
    Public Property ID() As String
        Get
            Return _ID
        End Get
        Set(ByVal value As String)
            _ID = value
        End Set
    End Property

    Private _MaGiaoVien As String
    Public Property MaGiaoVien() As String
        Get
            Return _MaGiaoVien
        End Get
        Set(ByVal value As String)
            _MaGiaoVien = value
        End Set
    End Property

    Private _TenGiaoVien As String
    Public Property TenGiaoVien() As String
        Get
            Return _TenGiaoVien
        End Get
        Set(ByVal value As String)
            _TenGiaoVien = value
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
