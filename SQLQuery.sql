create proc GetDanhSachDichVu
as
begin
	select * from DichVu
end
go
create proc GetDanhSachDoDung
as
begin
	select * from DoDung
end
go
create proc ThemHoaDonDichVu (@madv varchar(10), @mahd int, @soluong int, @thanhtien money)
as
begin
	insert into HoaDonDichVu(MaDV,MaHD,SoLuong,ThanhTien)
	values (@madv,@mahd,@soluong,@thanhtien)
end
go
create proc ThemHoaDonDoDung (@madd varchar(10), @mahd int, @soluong int, @thanhtien money)
as
begin
	insert into HoaDonDoDung(MaDD,MaHD,SoLuong,ThanhTien)
	values (@madd,@mahd,@soluong,@thanhtien)
end
go