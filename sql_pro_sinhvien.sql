--hiển thị dữ liệu sinh viên
use NanoThucTap
create proc SelectSV
as
begin
	select * from DMSinhVien
end
drop proc SelectSV
EXEC SelectSV
DROP  proc SelectSV
-- thêm sinh viên
create proc InsertSV
@MaSV varchar(20),@MaLop varchar(20),@MaGV varchar(20), @TenSV NVARCHAR(100),@NamSinh int,
@GioiTinh nvarchar(10),@MaTT nvarchar(50),@MaQH nvarchar(50),@MaXP nvarchar(50)
as
begin
	insert into DMSinhVien values(@MaSV,@MaLop,@MaGV,@TenSV,@NamSinh,@GioiTinh,@MaTT,@MaQH,@MaXP)
end
drop proc InsertSV
EXEC InsertSV @MaSV= 'Sinhvien01',@MaLop='Lop02',@MaGV='GiaoVien02',@TenSV=N'Nguyễn Hoàng',@NamSinh=2012,@GioiTinh='Nam'
,@MaTT='Hà Nội',@MaQH='Hà tây',@MaXP='Tiên Sơn'
--update sinh viên
create proc UpdateSV
@id int,@MaSV varchar(20),@MaLop varchar(20),@MaGV varchar(20), @TenSV NVARCHAR(100),@NamSinh int,
@GioiTinh nvarchar(10),@MaTT nvarchar(50),@MaQH nvarchar(50),@MaXP nvarchar(50)
as
begin
	update DMSinhVien set MaSinhVien=@MaSV,MaLop=@MaLop,MaGiaoVien=@MaGV,
	TenSinhVien=@TenSV,NamSinh=@NamSinh,GioiTinh=@GioiTinh,
	MaTinhThanh=@MaTT,MaQuanHuyen=@MaQH,MaXaPhuong=@MaXP
	WHERE ID = @id
end
EXEC UpdateSV @id=40086, @MaSV= 'Sinhvien01',@MaLop='Lop02',@MaGV='GiaoVien02',@TenSV=N'Nguyễn Văn Hoàng',@NamSinh=2012,@GioiTinh='Nữ'
,@MaTT='Bắc Ninh',@MaQH='Hà Tây',@MaXP='Yên Phong'
DROP PROC UpdateSV
--xóa theo id
CREATE PROC DeleteID
@id INT
as 
begin
delete from DMSinhVien where ID = @id
end
drop proc DeleteID
--xóa tất cả 
create proc deleteAll
as
begin
	delete from DMSinhVien
end
--tìm kiếm theo tên sinh viên hoặc mã sv
create proc search 
@tukhoa nvarchar(100)
as
begin
	select * from DMSinhVien WHERE MaSinhVien Like '%'+ @tukhoa + '%' OR TenSinhVien like '%'+@tukhoa+'%'
end
exec search @tukhoa = N'Trọng'
--xóa những dòng đã chọn
create proc DeleteSelected
@IDs nvarchar(Max)
as
begin
	SET NOCOUNT ON;
    DELETE FROM DMSinhVien
    WHERE ID IN (SELECT value FROM STRING_SPLIT(@IDs, ','))
end
drop proc DeleteSelected
--cach 2 DeleteSelected
CREATE PROCEDURE DeleteSelected
@IDs nvarchar(MAX)
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM DMSinhVien
	WHERE ID IN (SELECT CAST(value AS int) FROM STRING_SPLIT(@IDs, ','))
END

--l?y huy?n t? t?nh
CREATE PROCEDURE GetHuyenByTinh
    @TenTT NVARCHAR(100)
AS
BEGIN
    SELECT huyen.TenQH
    FROM tinh
    INNER JOIN huyen ON tinh.MaTT = huyen.MaTT
    WHERE tinh.TenTT = @TenTT
END

select huyen.TenQH from tinh inner join huyen on tinh.MaTT = huyen.MaTT where tinh.TenTT = N'" + cbTinhThanh.Text + "'
select xa.TenXa from huyen inner join xa on huyen.MaQH = xa.MaQH where huyen.TenQH = N'" + cbQuanHuyen.Text + "'
--l?y xã t? huy?n
CREATE PROCEDURE GetXaByTinh
    @TenQH NVARCHAR(100)
AS
BEGIN
    SELECT xa.TenXa
    FROM huyen
    INNER JOIN xa on huyen.MaQH = xa.MaQH where huyen.TenQH = @TenQH
END
 --lấy địa chỉ
 create proc LayDiaChi
 as
 begin 
   select CONCAT(xa.TenXa, ', ', huyen.TenQH, ', ', tinh.TenTT) AS DiaChi
   FROM tinh INNER JOIN huyen ON tinh.MaTT = huyen.MaTT 
	 INNER JOIN xa ON huyen.MaQH = xa.MaQH
 end
 --thêm sinh viên bảng sv2
 create proc InsertSV22
 @MaSV varchar(50),@MaLop varchar(50),@MaGV varchar(50),@TenSV nvarchar(50),@NamSinh int,@GioiTinh nvarchar(200),@DiaChi nvarchar(50)
 as
 begin
 insert into DM_SinhVien2 values(@MaSV,@MaLop,@MaGV,@TenSV,@NamSinh,@GioiTinh,@DiaChi)
 end
 

 --thông tin tin người dùng
 
 CREATE PROCEDURE DangKy
    @TenNguoiDung NVARCHAR(300),
    @MatKhau NVARCHAR(200),
    @MatKhauNhapLai NVARCHAR(200)
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra xem tên tài khoản đã tồn tại hay chưa
    IF EXISTS (SELECT 1 FROM [dbo].[DM_NguoiDung] WHERE [TenNguoiDung] = @TenNguoiDung)
    BEGIN
        RAISERROR('Tên tài khoản đã tồn tại.', 16, 1);
        RETURN;
    END

    -- Kiểm tra xem mật khẩu và mật khẩu nhập lại có khớp nhau hay không
    IF @MatKhau <> @MatKhauNhapLai
    BEGIN
        RAISERROR('Mật khẩu và mật khẩu nhập lại không khớp.', 16, 1);
        RETURN;
    END

    -- Thêm người dùng mới vào bảng DM_NguoiDung
    INSERT INTO [dbo].[DM_NguoiDung] ([TenNguoiDung], [MatKhau])
    VALUES (@TenNguoiDung, @MatKhau);

    -- Trả về thông báo thành công
    SELECT 'Đăng ký người dùng thành công.' AS [Message];
END

--LẤY THEO ID
create proc selectID
@id int
as
begin
	select * from DMSinhVien WHERE ID = @id
end
exec selectID @id=40086
