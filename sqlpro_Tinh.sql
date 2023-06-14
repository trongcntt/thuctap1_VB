CREATE PROC DMTinhThanh_SelectAll
as
begin 
	select * from DMTinhThanh
end

--thêm dữ liệu
create proc DMTinhThanh_insert
@MaTT varchar(100),
@TenTT NVARCHAR(100),
@Ghichu nvarchar(200),
@MaTTBH nvarchar(20)
as
begin
	insert into DMTinhThanh values(@MaTT,@TenTT,@Ghichu,@MaTTBH)
end
--update
create proc DMTinhThanh_update
@MaTT varchar(100),
@TenTT NVARCHAR(100),
@Ghichu nvarchar(200),
@MaTTBH nvarchar(20)
as
begin
	update DMTinhThanh set MaTinhThanh=@MaTT,TenTinhThanh=@TenTT,GhiChu=@Ghichu,MaTinhThanh_BH=@MaTTBH
end
--deletebyId
create proc DMTinhThanh_DeleteByMatt
@MaTT varchar(100)
as
begin
	DELETE DMTinhThanh where MaTinhThanh = @MaTT
end
--lấy theo mã
create proc DMTinhThanh_SelectTT
@MaTT varchar(100)
as
begin
	select * from DMTinhThanh where MaTinhThanh = @MaTT
end

select * from DMTinhThanh
select * from DMQuanHuyen
select * from DMXaPhuong