create proc dangnhap
@taikhoan nvarchar(100),
@matkhau nvarchar(100)
as
begin
	select * from DM_NguoiDung where TenNguoiDung = @taikhoan and MatKhau = @matkhau;
end
exec dangnhap @taikhoan = Nano ,@matkhau = 123456
select * from DM_NguoiDung
--đọc dư liệu từ bảng giáo viên
create proc laydataGiaoVien
as
begin
select * from DM_GiaoVien
end
exec laydataGiaoVien
-- thêm giáo viên
create proc Themgiaovien
@MaGV VARCHAR(50),
@TenGV NVARCHAR(200),
@GhiChu nvarchar(500)
as
begin
insert into DM_GiaoVien VALUES(@MaGV,@TenGV,@GhiChu)
end
exec Themgiaovien @MaGV='GiaoVien11',@TenGV=N'Nguyễn Trọng',@GhiChu=N'chả có gì'
exec Themgiaovien @MaGV='GiaoVien12',@TenGV=N'Nguyễn Trọng',@GhiChu=N'chả có gì'
exec Themgiaovien @MaGV='GiaoVien13',@TenGV=N'Nguyễn Trọng',@GhiChu=N'chả có gì'
exec Themgiaovien @MaGV='GiaoVien14',@TenGV=N'Nguyễn Trọng',@GhiChu=N'chả có gì'
exec Themgiaovien @MaGV='GiaoVien15',@TenGV=N'Nguyễn Trọng',@GhiChu=N'chả có gì'
exec Themgiaovien @MaGV='GiaoVien16',@TenGV=N'Nguyễn Trọng',@GhiChu=N'chả có gì'
exec Themgiaovien @MaGV='GiaoVien17',@TenGV=N'Nguyễn Trọng',@GhiChu=N'chả có gì'
exec Themgiaovien @MaGV='GiaoVien18',@TenGV=N'Nguyễn Trọng',@GhiChu=N'chả có gì'
exec Themgiaovien @MaGV='GiaoVien19',@TenGV=N'Nguyễn Trọng',@GhiChu=N'chả có gì'


--update Giaso Vien
create proc updateGV
@id int,
@MaGV varchar(50),
@TenGV NVARCHAR(200),
@GhiChu nvarchar(500)
as
begin
	update DM_GiaoVien set MaGiaoVien = @MaGV,TenGiaoVien = @TenGV, GhiChu = @GhiChu 
	WHERE ID = @id
end
exec updateGV @id=11,@MaGV='gv99',@TenGV='Cụ me',@GhiChu='không được cay lắm'
--xóa giáo viên

create proc XoaId
@Id int
as
begin
delete DM_GiaoVien where ID = @Id
end
drop proc DeleteByMaGV
EXEC DeleteGiaoVien @Id = 11
CREATE proc XoaGiaoVien
@Magv nvarchar(100)
as
begin
	delete from DM_GiaoVien where MaGiaoVien = @Magv
end
exec XoaGiaoVien @Magv = gv05
--tìm kiếm 
CREATE PROCEDURE TimKiemGiaoVien
    @TuKhoa NVARCHAR(100)
AS
BEGIN
    SELECT * FROM DM_GiaoVien
    WHERE MaGiaoVien LIKE '%' + @TuKhoa + '%' OR TenGiaoVien LIKE '%' + @TuKhoa + '%'
END
--xóa các dòng dã chọn cho proctest
CREATE PROCEDURE DeleteRows
    @IDs VARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM DM_GiaoVien
    WHERE ID IN (SELECT value FROM STRING_SPLIT(@IDs, ','))
END
-- xóa theo cách 2 qlgvfull
CREATE PROCEDURE xoacacmuc
    @IDs NVARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM DM_GiaoVien
    WHERE ID IN (SELECT CAST(value AS bigint) FROM STRING_SPLIT(@IDs, ','))
END

-- xóa all giáo viên
create proc deleteAllGV
as
begin
	delete from DM_GiaoVien
end
select * from DM_GiaoVien
select * from DM_LopHoc
select * from DM_NguoiDung
select * from DMQuanHuyen
select * from DMSinhVien
select * from DMTinhThanh
select * from DMXaPhuong