--thêm người dùng
create proc DMNguoiDung_insert
@MaND varchar(50),
@TenND nvarchar(300),
@MatKhau nvarchar(200)
as
begin
	insert into DM_NguoiDung values(@MaND,@TenND,@MatKhau)
end
-- update
create proc DMNguoiDung_update
@id int,
@MaND varchar(50),
@TenND nvarchar(300),
@MatKhau nvarchar(200)
as
begin
	update DM_NguoiDung set MaNguoiDung = @MaND,TenNguoiDung = @TenND,MatKhau = @MatKhau where ID = @id
end

--xóa theo id
create proc DMNguoiDung_DeleteID
@Id int
as
begin
	delete  from DM_NguoiDung WHERE ID = @Id
end
--LẤY THEO ID
CREATE PROC DMNguoiDung_selectByID
@Id int
as
begin
	SELECT *  from DM_NguoiDung WHERE ID = @Id
end
--LẤY TẤT CẢ
CREATE PROC DMNguoiDung_selectAll
as 
begin
	select * from DM_NguoiDung
end