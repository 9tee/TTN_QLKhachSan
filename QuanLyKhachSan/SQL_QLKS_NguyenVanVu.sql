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
create proc PROC_KiemTraTruocKhiDatPhong(@makh int)as
begin
	select MaKH from HoaDon 
	where MaKH= @makh 
	and HoaDon.NgayTao= '1900-01-01'
end




go
create proc PROC_TaoHoaDon(@makh int )as
begin
	declare @maHD int
	set @maHD = (select count(MaHD) from HoaDon)

	insert into HoaDon(MaHD , NgayTao ,TongTien , MaKH)
	values(@maHD+1,'','',@makh)

end



go 
create proc PROC_DatPhongTruoc(@makh int , @maphong int ,@ngayden datetime , @ngaydi datetime ,@ngay bit )as
begin
	declare @maHD int
	set @maHD = (select MaHD from HoaDon where HoaDon.MaKH = @makh and HoaDon.NgayTao= '1900-01-01')

	insert into HoaDonPhong(MaP ,MaHD ,NgayDen , NgayDi, Ngay, ThanhTien)
	values(@maphong,@maHD,@ngayden,@ngaydi,'','')

	update Phong
	set Trong = 0
	where MaP = @maphong

	if(@ngay = 'true')
		begin
			update HoaDonPhong
			set Ngay = 1
			where MaHD = @maHD and MaP = @maphong
		end
	else
		begin
			update HoaDonPhong
			set Ngay = 0
			where MaHD = @maHD and MaP = @maphong
		end
	update HoaDonPhong
	set TrangThai = N'Chua Nhan Phong'
	where MaHD = @maHD and MaP = @maphong
end



go
alter proc PROC_CheckIn(@makh int) as
begin
	declare @trangthai nvarchar(50)
	declare @ngayhomnay datetime
	declare @ngayDi datetime , @soNgay datetime
	declare @mahd int , @maphong int


	set @mahd = (select MaHD from HoaDon where HoaDon.MaKH = @makh and HoaDon.NgayTao= '1900-01-01' )

	set @ngayhomnay = GETDATE()
	DECLARE cursormaPhong CURSOR FOR
	select MaP from HoaDonPhong where MaHD = @mahd
	
	OPEN cursormaPhong

	FETCH NEXT FROM cursormaPhong
		INTO @maphong

	WHILE @@FETCH_STATUS = 0
		BEGIN
			set @ngayDi = (select MAX(NgayDi) from HoaDonPhong where MaP = @maphong and MaHD = @mahd)
	
			set @trangthai = (select TrangThai
							from HoaDonPhong , HoaDon
							where HoaDonPhong.MaHD = HoaDon.MaHD and MaKH = @makh and MaP = @maphong)
			set @soNgay = (select DATEDIFF(day, @ngayhomnay , @ngayDi))

			if(@trangthai = N'Chua Nhan Phong' and @soNgay >=0)
				begin
					update HoaDonPhong
					set TrangThai = N'Da Nhan Phong'
					where MaHD = @mahd and MaP = @maphong
				end
			else 
				begin
					update Phong
					set Trong = 1
					where MaP = @maphong

					update HoaDonPhong
					set TrangThai = N'Huy'
					where MaHD = @mahd and MaHD=@mahd

					update HoaDonPhong
					set ThanhTien = 0
					where MaHD = @mahd and MaHD=@mahd

					update HoaDon
					set NgayTao = getdate()

					update HoaDon
					set TongTien = 0
					where MaHD = @mahd and MaKH = @makh
				end

			FETCH NEXT FROM cursormaPhong -- Đọc dòng tiếp
				  INTO @maphong
		END
		CLOSE cursormaPhong              
		DEALLOCATE cursormaPhong
end


alter proc PROC_KiemTraTrangThaiPhong(@makh int )as
begin
	declare @mahd int , @maphong int
	declare  @ngaytao datetime
	DECLARE cursordate CURSOR FOR
	select Min(NgayTao) from HoaDon where MaKH=@makh

	OPEN cursordate 
	FETCH NEXT FROM cursordate
		  INTO @ngaytao

	WHILE @@FETCH_STATUS = 0         
		BEGIN
		
			set @mahd = (select MaHD 
				from HoaDon
				where HoaDon.MaKH = @makh and NgayTao = @ngaytao)

			select Distinct HoaDonPhong.TrangThai
			from HoaDonPhong , HoaDon
			where HoaDon.MaHD = HoaDonPhong.MaHD and HoaDon.MaHD = @mahd and MaKH = @makh
			FETCH NEXT FROM cursordate 
				 INTO @ngaytao
		END
	CLOSE cursordate             
	DEALLOCATE cursordate         
end




go
create proc PROC_KiemTraDaCheckOut(@makh int)as
begin
	declare @mahd int 

	set @mahd = (select MaHD from HoaDon where HoaDon.MaKH = @makh and HoaDon.NgayTao= '1900-01-01' )
	select TongTien from HoaDon
	where MaKH = @makh and MaHD = @mahd
end




go
alter proc PROC_CheckOut(@makh int)as
begin

	declare @tienDoDung money , @tienPhong money , @tongtienPhong money, @tienDichVu money , @tongtien money , @giaThueTheoNgay money , @giaThueTheoGio money
	declare @mahd int , @soNgayThue int , @soGiothue int , @maphong int
	declare @checkLoaiThuePhong bit 
	declare @ngayDen datetime , @ngayDi datetime

	set @mahd = (select MaHD from HoaDon where HoaDon.MaKH = @makh and HoaDon.NgayTao= '1900-01-01' )

	DECLARE cursormaPhong CURSOR FOR
	select MaP from HoaDonPhong where MaHD = @mahd
	
	OPEN cursormaPhong

	FETCH NEXT FROM cursormaPhong
		INTO @maphong
	WHILE @@FETCH_STATUS = 0         
		BEGIN
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

			update HoaDonPhong
			set TrangThai = N'Da Tra Phong'
			where MaHD = @mahd and MaP = @maphong

			set @tienPhong = (select ThanhTien from HoaDonPhong where MaHD = @mahd and MaP = @maphong)

			set @tongtienPhong += @tienPhong

			FETCH NEXT FROM cursormaPhong 
				 INTO @maphong
		END
	CLOSE cursormaPhong             
	DEALLOCATE cursormaPhong 

	set @tienDichVu  = (select ThanhTien from HoaDonDichVu where MaHD =@mahd)
	set @tienDoDung = (select ThanhTien from HoaDonDoDung where MaHD =@mahd)
		
	if(@tienDichVu is NULL)
		begin
			set @tienDichVu = 0
		end

	if(@tienDoDung is null)
		begin
			set @tienDoDung = 0
		end

	if(@tongtienPhong is null)
		begin
			set @tongtienPhong = 0
		end

	set @tongtien = @tienDichVu + @tienDoDung + @tongtienPhong
	
	update HoaDon 
	set NgayTao = GETDATE()
	where MaHD = @mahd

	update HoaDon 
	set TongTien = @tongtien
	where MaHD =@mahd

	if(@tongtien=0)
		begin
			update HoaDon 
			set TongTien = 1
			where MaHD =@mahd
		end

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




