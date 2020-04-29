create proc PROC_ThemKhachHang(@makh int,@ten nvarchar(50),@sdt varchar(12),@cmt varchar(20))as
begin
	insert into KhachHang(MaKH,TenKH,SDT,CMT)
	values(@makh,@ten,@sdt,@cmt)
end


go
create proc PROC_XemTatKhachHang as
begin
	select * from KhachHang
end

go
create proc PROC_XemTatPhong as
begin
	select * from Phong
end


go
create proc PROC_KiemTratruockhiCheckIn(@makh int)as
begin
	select MaKH from HoaDon 
	where MaKH= @makh 
	and HoaDon.NgayTao= '1900-01-01'
end



go 
create proc PROC_TaoHoaDon(@makh int , @maphong int)as
begin
	declare @maHD int
	set @maHD = (select count(MaHD) from HoaDon)

	insert into HoaDon(MaHD , NgayTao ,TongTien , MaKH)
	values(@maHD+1,'','',@makh)

	insert into HoaDonPhong(MaP ,MaHD ,NgayDen , NgayDi, Ngay, ThanhTien)
	values(@maphong,@maHD+1,GETDATE(),'','','')

	update Phong
	set Trong = 0
	where MaP = @maphong
		
end


go
create proc PROC_KiemTraDaCheckOut(@makh int)as
begin
	select TongTien from HoaDon
	where MaKH = @makh 
end



go
create proc PROC_CheckOut(@makh int)as
begin

	declare @tienDoDung money , @tienPhong money , @tienDichVu money , @tongtien money , @giaThueTheoNgay money , @giaThueTheoGio money
	declare @mahd int , @soNgayThue int , @soGiothue int , @maphong int
	declare @checkLoaiThuePhong bit 
	declare @ngayDen datetime , @ngayDi datetime

	set @mahd = (select MaHD from HoaDon where HoaDon.MaKH = @makh and HoaDon.NgayTao= '1900-01-01' )
	set @maphong = (select MaP from HoaDonPhong where MaHD = @mahd)
	set @giaThueTheoGio = (select GiaPhongGio from Phong where MaP = @maphong)
	set @giaThueTheoNgay = (select GiaPhongNgay from Phong where MaP = @maphong)
	set @checkLoaiThuePhong = (select Ngay from HoaDonPhong where MaP = @maphong and MaHD = @mahd)
	set @ngayDen = (select NgayDen from HoaDonPhong where MaP = @maphong and MaHD = @mahd)

	update HoaDonPhong
	set NgayDi = GETDATE()
	where MaP = @maphong and MaHD = @mahd

	set @ngayDi = (select NgayDi from HoaDonPhong where MaP = @maphong and MaHD = @mahd)
	set @soGiothue = (select DATEDIFF(hour, @ngayDen , @ngayDi) )
	set @soNgayThue = (select DATEDIFF(day, @ngayDen , @ngayDi) )

	if(@checkLoaiThuePhong = 1)
		begin
			update HoaDonPhong 
			set ThanhTien = @soNgayThue * @giaThueTheoNgay
			where MaP = @maphong and MaHD = @mahd

			update Phong
			set Phong.Trong = 1
			where MaP = @maphong
		end
	else 
		begin
			update HoaDonPhong 
			set ThanhTien = @soGiothue * @giaThueTheoGio
			where MaP = @maphong and MaHD = @mahd

			update Phong
			set Phong.Trong = 1
			where MaP = @maphong
		end

	set @tienDichVu  = (select ThanhTien from HoaDonDichVu where MaHD =@mahd)
	set @tienDoDung = (select ThanhTien from HoaDonDoDung where MaHD =@mahd)
	set @tienPhong = (select ThanhTien from HoaDonPhong where MaHD =@mahd)
	
	if(@tienDichVu is NULL)
		begin
			set @tienDichVu = 0
		end

	if(@tienDoDung is null)
		begin
			set @tienDoDung = 0
		end

	if(@tienPhong is null)
		begin
			set @tienPhong = 0
		end

	set @tongtien = @tienDichVu + @tienDoDung + @tienPhong
	
	update HoaDon 
	set NgayTao = GETDATE()
	where MaHD = @mahd

	update HoaDon 
	set TongTien = @tongtien
	where MaHD =@mahd
end


go
create proc PROC_LichSuThue(@mkh int)as
begin
	select HoaDonPhong.NgayDen , HoaDonPhong.NgayDi ,Phong.MaP
	from KhachHang , HoaDon , HoaDonPhong , Phong
	where KhachHang.MaKH = HoaDon.MaKH and
		HoaDon.MaHD = HoaDonPhong.MaHD and
		HoaDonPhong.MaP = Phong.MaP and KhachHang.MaKH = @mkh
end

go


