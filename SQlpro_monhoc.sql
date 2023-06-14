-- lấy ra danh sách môn học
create proc DMMonHoc_selectAll
as
begin
	select * from DMMonHoc
end
exec DMMonHoc_selectAll
--insert môn học
create proc DMMonHoc_insert
@MaMH NVARCHAR(50),
@TenMH nvarchar(500)
as
begin	
	insert into DMMonHoc values(@MaMH,@TenMH)
end
exec DMMonHoc_insert @MaMH=N'GDCD',@TenMH=N'Giáo Dục Công Dân'
--update môn học
create proc DMMonHoc_update
@Id int,
@MaMH NVARCHAR(50),
@TenMH nvarchar(500)
as
begin	
	update DMMonHoc set MaMonHoc=@MaMH,TenMonHoc=@TenMH where ID = @Id
end
exec DMMonHoc_update @Id=6,@MaMH=N'Sinh1',@TenMH=N'Sinh Học'
--lấy theo id
create proc DMMonHoc_SelectId
@Id int
as
begin
	select * from DMMonHoc where ID= @Id
END
exec DMMonHoc_SelectId @Id=6
--XÓA THEO ID
CREATE PROC DMMonHoc_DeleteID
@Id int
as
begin
	delete FROM DMMonHoc where ID=@Id
end
--lấy ra giá trị các mã môn học trong comboboxedit
select MaMonHoc from DMMonHoc 