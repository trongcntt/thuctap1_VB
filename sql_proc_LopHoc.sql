--Hiển thị toàn bộ data
create proc laydsLopHoc
as
BEGIN
select * from DM_LopHoc
END
execute laydsLopHoc
-- hiển thị sp theo mã đổ lên datagridview
CREATE PROC hienthisptheoma
@ma INT
as
begin
 SELECT * FROM DM_LopHoc WHERE ID = @ma;
end
execute hienthisptheoma @ma =1
--thêm lớp học
create proc ThemLopHoc
@MaLop varchar(50),
@TenLop nvarchar(500),
@GhiChu nvarchar(500)
as
begin
insert into DM_LopHoc values(@MaLop,@TenLop,@GhiChu)
end
exec ThemLopHoc @MaLop = 'Lop01',@TenLop =N'Lớp Giỏi',@GhiChu =N'mong là được'
exec ThemLopHoc @MaLop = 'Lop02',@TenLop =N'Lớp Giỏi',@GhiChu =N'mong là được'
exec ThemLopHoc @MaLop = 'Lop03',@TenLop =N'Lớp Giỏi',@GhiChu =N'mong là được'
--update dữ liệu

create proc EditLopHoc
@id int,
@MaLop varchar(50),
@TenLop nvarchar(500),
@GhiChu nvarchar(500)
as
begin
update DM_LopHoc set MaLop=@MaLop,TenLop=@TenLop,GhiChu=@GhiChu where ID =@id
end
--xóa lớp
create proc DeleteLopHoc
@Id int
as
begin
delete DM_LopHoc where ID = @Id
end
--tìm kiếm 
CREATE PROCEDURE TimKiemLopHoc
    @TuKhoa NVARCHAR(100)
AS
BEGIN
    SELECT * FROM DM_LopHoc
    WHERE MaLop LIKE '%' + @TuKhoa + '%' OR TenLop LIKE '%' + @TuKhoa + '%'
END
-- xóa toàn bộ bảng
create proc XoaAll
as
begin
delete from DM_LopHoc
end
--xóa các dòng dã chọn
CREATE PROCEDURE DeleteRows
    @IDs VARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM DM_LopHoc
    WHERE ID IN (SELECT value FROM STRING_SPLIT(@IDs, ','))
END
