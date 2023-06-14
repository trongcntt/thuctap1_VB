Public Class DMKetQuaHocTapEntity
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

    Private _MaLopHoc As String
    Public Property MaLopHoc() As String
        Get
            Return _MaLopHoc
        End Get
        Set(ByVal value As String)
            _MaLopHoc = value
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
    Private _MaMonHoc As String
    Public Property MaMonHoc() As String
        Get
            Return _MaMonHoc
        End Get
        Set(ByVal value As String)
            _MaMonHoc = value
        End Set
    End Property
    Private _DiemThi As Double
    Public Property DiemThi() As Double
        Get
            Return _DiemThi
        End Get
        Set(ByVal value As Double)
            _DiemThi = value
        End Set
    End Property
    Private _NgayThi As DateTime
    Public Property NgayThi() As DateTime
        Get
            Return _NgayThi
        End Get
        Set(ByVal value As DateTime)
            _NgayThi = value
        End Set
    End Property
End Class
