Imports System.ComponentModel

Public Class KetNoiCSDL

    Public Property strKetNoiCSDL() As String
        Get
            Return ChuoiKetNoi
        End Get
        Set(ByVal value As String)
            ChuoiKetNoi = value
        End Set
    End Property

End Class
