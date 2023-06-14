Public Class DMSinhVienEntity
    Private _ID As String
    Public Property ID() As String
        Get
            Return _ID
        End Get
        Set(ByVal value As String)
            _ID = value
        End Set
    End Property
    Private _MaSinhVien As String
    Public Property MaSinhVien() As String
        Get
            Return _MaSinhVien
        End Get
        Set(ByVal value As String)
            _MaSinhVien = value
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

    Private _MaGiaoVien As String
    Public Property MaGiaoVien() As String
        Get
            Return _MaGiaoVien
        End Get
        Set(ByVal value As String)
            _MaGiaoVien = value
        End Set
    End Property
    Private _TenSinhVien As String
    Public Property TenSinhVien() As String
        Get
            Return _TenSinhVien
        End Get
        Set(ByVal value As String)
            _TenSinhVien = value
        End Set
    End Property
    Private _NamSinh As String
    Public Property NamSinh() As String
        Get
            Return _NamSinh
        End Get
        Set(ByVal value As String)
            _NamSinh = value
        End Set
    End Property
    Private _GioiTinh As String
    Public Property GioiTinh() As String
        Get
            Return _GioiTinh
        End Get
        Set(ByVal value As String)
            _GioiTinh = value
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
    Private _MaQuanHuyen As String
    Public Property MaQuanHuyen() As String
        Get
            Return _MaQuanHuyen
        End Get
        Set(ByVal value As String)
            _MaQuanHuyen = value
        End Set
    End Property
    Private _MaXaPhuong As String
    Public Property MaXaPhuong() As String
        Get
            Return _MaXaPhuong
        End Get
        Set(ByVal value As String)
            _MaXaPhuong = value
        End Set
    End Property
End Class
