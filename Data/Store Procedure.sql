﻿Use QLTaiXe
go
-- Đăng Nhập --
Create proc sp_DangNhap
 @Username nvarchar(50),
 @Password varchar(20),
 @Trave int output
as
 begin
    begin try
	    if(@Username != All(Select Username from NhanVien))
		   set @Trave = 0
	    if(@Password != (Select Password From NhanVien Where Username = @Username))
		   set @Trave = 0
		if(@Username = (Select Username from NhanVien Where Username = @Username) and @Password = (Select Password From NhanVien Where Username = @Username))
		   set @Trave = 1
	end try
	begin catch
	    set @Trave = 0
	end catch    
 end
go
-- Cập nhật thông tin cá nhân tài xế --
Create proc sp_CapNhatthongTin
 @MaNV varchar(10),
 @Hoten nvarchar(50),
 @Diachi nvarchar(100),
 @CMND varchar(12),
 @Dienthoai varchar(11),
 @Khananglai int
as
 begin
    update NhanVien
	set HoTen = @Hoten, DiaChi=@Diachi, CMND=@CMND, DienThoai=@Dienthoai, KhaNangLai=@Khananglai
	Where MaNV=@MaNV
 end
go
 -- Đổi password --
Create proc sp_DoiMatKhau
 @MaNV varchar(10),
 @Password varchar(20)
as
 begin
    update NhanVien
	set Password = @Password
	where MaNV = @MaNV
 end
go 
-- Thêm lịch trình --
Create proc sp_ThemLichTrinh
 @Thang int,
 @MaNV varchar(10),
 @GioDi datetime,
 @GioDen datetime,
 @NoiDi nvarchar(100),
 @NoiDen nvarchar(100),
 @MaChuyen varchar(10)
as
 begin
    Insert into LichTrinh(Thang,MaNV,GioDi,GioDen,NoiDi,NoiDen,MaChuyen)
	Values (@Thang,@MaNV,@GioDi,@GioDen,@NoiDi,@NoiDen,@MaChuyen)
 end
go
-- Cập nhật lịch trình --
Create proc sp_CapNhatLichTrinh
 @MaLich int,
 @Thang int,
 @MaNV varchar(10),
 @GioDi datetime,
 @GioDen datetime,
 @NoiDi nvarchar(100),
 @NoiDen nvarchar(100),
 @MaChuyen varchar(10)
as
 begin
    Update LichTrinh
	set Thang=@Thang,MaNV=@MaNV, GioDi=@GioDi, GioDen=@GioDen, NoiDi=@NoiDi, NoiDen=@NoiDen, MaChuyen=@MaChuyen
	Where MaLich=@MaLich
 end
go
-- Get ID Nhân viên --
Create proc sp_GetIDNhanVien
 @MaNV varchar(10) output
as
 begin
   declare @n numeric
   declare @Z nchar(2),@W nchar(8)
   set @Z='NV'   
   if exists (Select top 1 * From NhanVien)
       Select @n= max(cast(Substring(MaNV,3,8) as numeric)) From NhanVien
   else
       set @n = 0
   set @n=@n+1
   set @W = cast(@n as nchar(8))
   While len(@W)<5
      set @W='0'+@W
   set @MaNV = @Z+@W
 end
go
-- Thêm Nhân viên --
Create proc sp_ThemNV
 @MaNV varchar(10),
 @Hoten nvarchar(50),
 @Diachi nvarchar(100),
 @CMND varchar(12),
 @Dienthoai varchar(11),
 @Khananglai int,
 @Username nvarchar(50),
 @Password varchar(20),
 @MaPQ int,
 @MaTo int
as
 begin
    Insert into NhanVien(MaNV,HoTen,DiaChi,CMND,DienThoai,KhaNangLai,Username,Password,MaPQ,MaTo,TinhTrang)
	Values (@MaNV,@Hoten,@Diachi,@CMND,@Dienthoai,@Khananglai,@Username,@Password,@MaPQ,@MaTo,'1')
 end
go
-- Xóa nhân viên --
Create proc sp_XoaNV
 @MaNV varchar(10)
as
 begin
   Delete from LichTrinh where MaNV = @MaNV
   Delete from NhanVien Where MaNV=@MaNV
 end
go
-- Cập nhật nhân viên --
Create proc sp_CapNhatNV
 @MaNV varchar(10),
 @Hoten nvarchar(50),
 @Diachi nvarchar(100),
 @CMND varchar(12),
 @Dienthoai varchar(11),
 @Khananglai int,
 @Username nvarchar(50),
 @MaPQ int,
 @MaTo int
as
 begin
    Update  NhanVien 
	set HoTen =@Hoten, DiaChi=@Diachi, CMND=@CMND, DienThoai=@Dienthoai, KhaNangLai=@Khananglai, Username=@Username, MaPQ=@MaPQ, MaTo=@MaTo
	where MaNV=@MaNV
 end
go
-- Khóa tài khoản --
Create proc sp_Khoa
 @MaNV varchar(10)
as
 begin
    Update  NhanVien 
	set TinhTrang = 'False'
	where MaNV=@MaNV
 end
go
-- Mở khóa tài khoản --
Create proc sp_MoKhoa
 @MaNV varchar(10)
as
 begin
    Update  NhanVien 
	set TinhTrang = 'True'
	where MaNV=@MaNV
 end
go