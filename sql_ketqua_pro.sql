--selectall KQ
create proc DMKQ_selectAll
as
begin
	select * from tbl_KetQuaHocTap
end
exec DMKQ_selectAll
--select theo id
create proc DMKQ_selectId
@Id int
as
begin
	select * from tbl_KetQuaHocTap where ID=@Id
end
--insert
create proc DMKQ_insert
@MaGV varchar(50),
@MaLopHoc varchar(50),
@MaSinhVien varchar(50),
@MaMonHoc varchar(50),
@DiemThi float,
@NgayThi datetime
as
begin
	insert into tbl_KetQuaHocTap values(@MaGV,@MaLopHoc,@MaSinhVien,@MaMonHoc,@DiemThi,@NgayThi)
end
exec DMKQ_insert @MaGV='GV02',@MaLopHoc='Lop02',@MaSinhVien='Sinhvien02',@MaMonHoc='Toan1',@DiemThi=5.4,@NgayThi='2002-08-25'
--update
create proc DMKQ_update
@Id int,
@MaGV varchar(50),
@MaLopHoc varchar(50),
@MaSinhVien varchar(50),
@MaMonHoc varchar(50),
@DiemThi float,
@NgayThi datetime
as
begin
	update tbl_KetQuaHocTap set MaGiaoVien=@MaGV,MaLopHoc=@MaLopHoc,MaSinhVien=@MaSinhVien,@MaMonHoc=@MaMonHoc,DiemThi=@DiemThi,NgayThi=@NgayThi WHERE ID=@Id
end
EXEC DMKQ_update @Id=1,@MaGV='GV01',@MaLopHoc='Lop01',@MaSinhVien='Sinhvien01',@MaMonHoc='Sinh1',@DiemThi=7.5,@NgayThi='2022-05-4'
--deleteId
create proc DMKQ_deleteId
@Id int
as
begin
	delete from tbl_KetQuaHocTap where ID=@Id
end
--lấy dữ liệu cho các cbbox
select MaGiaoVien from DM_GiaoVien
select MaLop from DM_LopHoc
select MaSinhVien from DMSinhVien
select MaMonHoc from DMMonHoc
--select nhiều môn
CREATE PROCEDURE SelectByIDs
    @IDs nvarchar(MAX)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT *
    FROM tbl_KetQuaHocTap
    WHERE MaMonHoc IN (SELECT value FROM STRING_SPLIT(@IDs, ','))
END
exec SelectByIDs @IDs='Toan1,Van1'
