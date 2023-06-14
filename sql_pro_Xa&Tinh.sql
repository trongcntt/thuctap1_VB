--lấy toàn bộ tỉnh thành
create proc DMTinhThanh_selectAll
as
begin 
select * from DMTinhThanh
end
exec DMTinhThanh_selectAll
-- lấy toàn bộ xã phường
create proc DMXaPhuong_selectAll
as
begin 
select * from DMXaPhuong
end
exec DMXaPhuong_selectAll
--insert tỉnh
create proc DMTinhThanh_insert
@MaTT varchar(50),
@TenTT nvarchar(100),
@GhiChu nvarchar(200),
@MaQG varchar(50)
as
begin
	insert into DMTinhThanh values(@MaTT,@TenTT,@GhiChu,@MaQG)
end
--UPDATE tỉnh
create proc DMTinhThanh_update
@MaTT varchar(50),
@TenTT nvarchar(100),
@GhiChu nvarchar(200),
@MaQG varchar(50)
as
begin
	update DMTinhThanh set MaTinhThanh=@MaTT, TenTinhThanh = @TenTT, GhiChu = @GhiChu, MaQuocGia= @MaQG where MaTinhThanh=@MaTT
end
--XÓA Tỉnh theo id
create proc DMTinhThanh_deleteID
@Id varchar(50)
as
begin
	delete from DMTinhThanh where MaTinhThanh=@Id
end
--Lấy theo id
create proc DMTinhThanh_SelectID
@Id varchar(50)
as
begin
	select *  from DMTinhThanh where MaTinhThanh=@Id
end
--------------------------------------------------------
--insert xã
create proc DMXaPhuong_insert
@MaXa varchar(50),
@TenXa nvarchar(200),
@MotaThonXa nvarchar(200),
@MaQh varchar(50)
as
begin
	insert into DMXaPhuong values(@MaXa,@TenXa,@MotaThonXa,@MaQh)
end
--update xã
create proc DMXaPhuong_update
@MaXa varchar(50),
@TenXa nvarchar(200),
@MotaThonXa nvarchar(200),
@MaQh varchar(50)
as
begin
	update DMXaPhuong set MaXa=@MaXa,TenXa=@TenXa,MoTaThonXa=@MotaThonXa,MaQuanHuyen=@MaQh where MaXa=@MaXa
end

--XÓA xã theo id
create proc DMXaPhuong_deleteID
@Id varchar(50)
as
begin
	delete from DMXaPhuong where MaXa=@Id
end
--Lấy theo id
create proc DMXaPhuong_SelectID
@Id varchar(50)
as
begin
	select *  from DMXaPhuong where MaXa=@Id
end