--thêm quận huyện
create proc DMQuanHuyen_insert
@Maqh varchar(50),
@Tenqh nvarchar(100),
@GhiChu nvarchar(200),
@MaTT varchar(50)
as
begin
	insert into DMQuanHuyen values(@Maqh,@Tenqh,@GhiChu,@MaTT)
end
drop proc DMQuanHuyen_insert
exec DMQuanHuyen_insert @Maqh = 'gh1',@Tenqh ='Việt Yên',@GhiChu='đáadsad',@MaTT='98d2'
--sửa quận huyện
create proc DMQuanHuyen_update
@Maqh varchar(50),
@Tenqh varchar(100),
@GhiChu nvarchar(200),
@MaTT varchar(50)
as
begin
	update DMQuanHuyen set MaQuanHuyen=@Maqh,TenQuanHuyen=@Tenqh,GhiChu=@GhiChu,MaTinhThanh=@MaTT where MaQuanHuyen=@Maqh
end
exec DMQuanHuyen_update @Maqh ='gh1',@Tenqh='việt yên',@GhiChu = 'akee',@MaTT = '98b1'
-- xóa theo id
create proc DMQuanHuyen_DeleteID
@id varchar(50)
as
begin
	delete DMQuanHuyen where MaQuanHuyen = @id
end
--lấy theo id
create proc DMQuanHuyen_selectByID
@id varchar(50)
as
begin
	select * from DMQuanHuyen where MaQuanHuyen=@id
end
--lấy tất cả
create proc DMQuanHuyen_selectAll
as
begin
	select * from DMQuanHuyen
end
exec DMQuanHuyen_selectAll