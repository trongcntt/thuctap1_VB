Public Class DMNguoiDungEntity
    Private _ID As String
    Public Property ID() As String
        Get
            Return _ID
        End Get
        Set(ByVal value As String)
            _ID = value
        End Set
    End Property

    Private _MaNguoiDung As String
    Public Property MaNguoiDung() As String
        Get
            Return _MaNguoiDung
        End Get
        Set(ByVal value As String)
            _MaNguoiDung = value
        End Set
    End Property

    Private _TenNguoiDung As String
    Public Property TenNguoiDung() As String
        Get
            Return _TenNguoiDung
        End Get
        Set(ByVal value As String)
            _TenNguoiDung = value
        End Set
    End Property
    Private _MatKhau As String
    Public Property MatKhau() As String
        Get
            Return _MatKhau
        End Get
        Set(ByVal value As String)
            _MatKhau = value
        End Set
    End Property
End Class
