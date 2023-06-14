insert into tbl_KetQuaHocTap values('GV02','L01','112','Toan1',6,'2022-05-21')
insert into tbl_KetQuaHocTap values('GV03','L02','114','Van1',6,'2022-05-21')
insert into tbl_KetQuaHocTap values('GV05','L03','112','Anh1',6,'2022-05-21')
insert into tbl_KetQuaHocTap values('GV01','L01','112','Su1',6,'2022-05-21')
insert into tbl_KetQuaHocTap values('GV03','L01','113','Toan1',6,'2022-05-21')
insert into tbl_KetQuaHocTap values('GV02','L01','111','Toan1',6,'2022-05-21')
insert into tbl_KetQuaHocTap values('GV04','L02','111','Van1',6,'2022-05-21')
insert into tbl_KetQuaHocTap values('GV05','L03','111','Anh1',6,'2022-05-21')
select * from tbl_KetQuaHocTap
select MaSinhVien from tbl_KetQuaHocTap
--tìm kiếm theo mã sv
create proc tblKQ_search 
@tukhoa nvarchar(100)
as
begin
	select * from tbl_KetQuaHocTap WHERE MaSinhVien Like '%'+ @tukhoa 
end
exec tblKQ_search @tukhoa = '112'
