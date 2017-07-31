use QLTaiXe
go
-- Nơi đi không được trùng nơi đến.
--					T			X			S
-- LichTrinh		+			-			+(NoiDi,NoiDen)
create trigger tr1
on LichTrinh
for insert,update
as
begin
	if exists(
		Select *
		from inserted I 
		Where I.NoiDen = I.NoiDi
	)
	begin 
		raiserror(N'Nơi Đi Không Được Trùng Nơi Đến',16,1)
		rollback
	end
end
go
-- Giờ đi phải nhỏ hơn giờ đến.
--					T			X			S
-- LichTrinh		+			-			+(GioDi,GioDen)
create trigger tr2
on LichTrinh
for insert,update
as
begin
	if exists(
		Select *
		from inserted I 
		Where I.GioDi = I.GioDen
	)
	begin 
		raiserror(N'Giờ Đi Không Được Trùng Giờ Đến',16,1)
		rollback
	end
end
go
-- Mỗi tổ không được quá 10 thành viên
--					T			X			S
-- NhanVien			+			-			+(MaTo)
create trigger tr3
on NhanVien
for insert,update
as
begin
		Declare @SL int
		set @SL = (Select COUNT(*)
		from NhanVien join inserted I on I.MaTo=NhanVien.MaTo
		)
		if(@SL >10)
		begin
		raiserror (N'1 Tố Chỉ Được 10 Nhân Viên',16,1)
		rollback 
		end
end
go
-- Mỗi tổ phải có duy nhất 1 tổ trưởng.
--					T			X			S
-- Nhom				+			-			+(ToTruong)
create trigger tr4
on Nhom
for insert,update
as
begin
		Declare @SL int
		set @SL = (Select COUNT(*)
		from Nhom join inserted I on I.ToTruong=Nhom.ToTruong
		)
		if(@SL >1)
		begin
		raiserror (N'Mỗi tổ phải có duy nhất 1 tổ trưởng.',16,1)
		rollback 
		end
end
go
-- Khả năng lái đường dài của tài xế >= khoảng cách chuyến xe 
--					T			X			S
-- NhanVien			-			-			+(KhaNangLai)
-- TuyenDuong		-			-			+(KhoangCach)
-- LichTrinh		+			-			+(MaNV)
-- ChuyenXe			-			-			+(MaTuyen)
create trigger tr5c1
on NhanVien
for update
as
begin
	if exists (
			Select *
			from inserted I 
			where I.KhaNangLai < all (
									Select Max(TD.KhoangCach)
									from LichTrinh LT join ChuyenXe CX on  LT.MaChuyen=CX.MaChuyen join TuyenDuong TD  on CX.MaTuyen=TD.MaTuyen
									where LT.MaNV = I.MaNV )
			 )	
	begin
	raiserror(N'Tài Xế Này Chạy Xe Đường Quá Sức Rồi',16,1);
	rollback 
	end
end
go
create trigger tr5c2
on TuyenDuong
for update
as
begin
	if exists (
			Select *
			from inserted I 
			where I.KhoangCach > all(
									Select Min(NV.KhaNangLai)
									from LichTrinh LT join ChuyenXe CX on  LT.MaChuyen=CX.MaChuyen join NhanVien NV on LT.MaNV=NV.MaNV
									where CX.MaTuyen='TD00001' )
			)
	begin
	raiserror(N'Tài Xế Này Chạy Xe Đường Quá Sức Rồi',16,1)
	rollback
	end
end
go
create trigger tr5c3
on LichTrinh
for insert,update
as
begin
	if exists (
			Select *
			from inserted I join ChuyenXe CX on I.MaChuyen=CX.MaChuyen join TuyenDuong TD on CX.MaTuyen=TD.MaTuyen
			where TD.KhoangCach > all(
									Select NV.KhaNangLai
									from NhanVien NV
									where NV.MaNV=I.MaNV )
			)
	begin
	raiserror(N'Tài Xế Này Chạy Xe Đường Quá Sức Rồi',16,1)
	rollback
	end
end
go
create trigger tr5c4
on ChuyenXe
for update
as
begin
	if exists (
			Select *
			from inserted I join TuyenDuong TD on I.MaTuyen=TD.MaTuyen
			where TD.KhoangCach > all(
									Select Min(NV.KhaNangLai)
									from NhanVien NV join LichTrinh LT on LT.MaNV=NV.MaNV 
									where LT.MaChuyen = I.MaChuyen )
			)
	begin
	raiserror(N'Tài Xế Này Chạy Xe Đường Quá Sức Rồi',16,1)
	rollback
	end
end
go
-- Trong một tháng: mỗi tài xế phải lái không được quá 20 chuyến
--					T			X			S
-- LichTrinh		+			-			+(MaNV,Thang)
create trigger tr6
on LichTrinh
for insert,update
as
begin
	Declare @SL int
		set @SL = (Select COUNT(*)
		from LichTrinh LT join inserted I on I.MaNV=LT.MaNV
		Where LT.Thang=I.Thang
		)
		if(@SL >20)
		begin
		raiserror (N'Chạy Được 20 chuyến trong mỗi tháng thôi.',16,1)
		rollback 
		end
end
go