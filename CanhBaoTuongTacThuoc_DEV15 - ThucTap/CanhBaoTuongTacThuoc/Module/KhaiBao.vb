Module KhaiBao
    Public ChuoiKetNoi As String = "Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=NanoThucTap;Integrated Security=True"
    ' Public ChuoiKetNoi As String = "Data Source=123.24.142.45,2019;Initial Catalog=NanoThucTap;Persist Security Info=True;User ID=his;Password=s@123456"
    Public ADD_STATE As Byte = 1
    Public UPDATE_STATE As Byte = 2
    Public objTuongTacDA As New DMLopHocDA
    Public objCanhBaoDA As New DMGiaoVienDA
    Public TV As New ThuVien.HeThong
    Public nMaBenhVien As String = ""
End Module
