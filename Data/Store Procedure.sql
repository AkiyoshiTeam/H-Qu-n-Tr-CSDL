Use QLTaiXe
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
-- Xóa lịch trình --
Create proc sp_XoaLichTrinh
 @MaLich int
as
 begin
   Delete from LichTrinh where MaLich=@MaLich
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
-- Get ID tuyến đường --
Create proc sp_GetIDTuyenDuong
 @MaTuyen varchar(10) output
as
 begin
   declare @n numeric
   declare @Z nchar(2),@W nchar(8)
   set @Z='TD'   
   if exists (Select top 1 * From TuyenDuong)
       Select @n= max(cast(Substring(MaTuyen,3,8) as numeric)) From TuyenDuong
   else
       set @n = 0
   set @n=@n+1
   set @W = cast(@n as nchar(8))
   While len(@W)<5
      set @W='0'+@W
   set @MaTuyen = @Z+@W
 end
go
-- Thêm tuyến đường --
Create proc sp_ThemTuyenDuong
 @MaTuyen varchar(10),
 @TenTuyen nvarchar(50),
 @KhoangCach bigint
as
 begin
    Insert into TuyenDuong(MaTuyen,TenTuyen,KhoangCach)
	Values (@MaTuyen,@TenTuyen,@KhoangCach)
 end
go
-- Cập nhật tuyến đường --
Create proc sp_CapNhatTuyenDuong
 @MaTuyen varchar(10),
 @TenTuyen nvarchar(50),
 @KhoangCach bigint
as
 begin
    Update TuyenDuong
	set TenTuyen = @TenTuyen, KhoangCach = @KhoangCach
	Where MaTuyen = @MaTuyen
 end
go
-- Xóa tuyến đường --
Create proc sp_XoaTuyenDuong
 @MaTuyen varchar(10)
as
 begin
    Delete from TuyenDuong where MaTuyen = @MaTuyen 
 end
go
-- Get ID chuyến xe --
Create proc sp_GetIDChuyenXe
 @MaChuyen varchar(10) output
as
 begin
   declare @n numeric
   declare @Z nchar(1),@W nchar(8)
   set @Z='C'   
   if exists (Select top 1 * From ChuyenXe)
       Select @n= max(cast(Substring(MaChuyen,3,8) as numeric)) From ChuyenXe
   else
       set @n = 0
   set @n=@n+1
   set @W = cast(@n as nchar(8))
   While len(@W)<6
      set @W='0'+@W
   set @MaChuyen = @Z+@W
 end
go
-- Thêm chuyến xe --
Create proc sp_ThemChuyenXe
 @MaChuyen varchar(10),
 @HangXe nvarchar(50),
 @MaTuyen varchar(10),
 @GiaVe bigint
as
 begin
    Insert into ChuyenXe(MaChuyen,HangXe,GiaVe,MaTuyen)
	Values (@MaChuyen,@HangXe,@GiaVe,@MaTuyen)
 end
go
-- Cập nhật chuyến xe --
Create proc sp_CapNhatChuyenXe
 @MaChuyen varchar(10),
 @HangXe nvarchar(50),
 @MaTuyen varchar(10),
 @GiaVe bigint
as
 begin
    Update ChuyenXe
	set HangXe=@HangXe, GiaVe = @GiaVe, MaTuyen = @MaTuyen
	Where MaChuyen = @MaChuyen
 end
go
-- Xóa chuyến xe --
Create proc sp_XoaChuyenXe
 @MaChuyen varchar(10)
as
 begin
    Delete from ChuyenXe where MaChuyen = @MaChuyen 
 end
go
-- Thêm tổ --
Create proc sp_ThemTo
 @NgayLap date
as
 begin
    Insert into Nhom(NgayLap)
	Values (@NgayLap)
 end
go
-- Cập nhật tổ --
Create proc sp_CapNhatTo
 @MaTo int,
 @NgayLap date,
 @ToTruong varchar(10)
as
 begin
  if(@ToTruong = 'NULL')
    Update Nhom set NgayLap=@NgayLap, ToTruong = NULL where MaTo=@MaTo
  else
    Update Nhom set NgayLap=@NgayLap, ToTruong = @ToTruong where MaTo=@MaTo
 end
go
-- Xóa tổ --
Create proc sp_XoaTo
 @MaTo int
as
 begin
    Update NhanVien set MaTo = NULL where MaTo=@MaTo
	Delete from Nhom Where MaTo=@MaTo
 end
go
-- Load danh sách lịch trình cá nhân --
Create proc sp_LichTrinhCN
 @MaNV varchar(10)
 as
 begin
     Select L.MaLich,L.Thang,L.GioDi,L.GioDen,L.NoiDi,L.NoiDen,C.HangXe,T.TenTuyen,T.KhoangCach
	 From ((NhanVien N join LichTrinh L on N.MaNV=L.MaNV) join ChuyenXe C on L.MaChuyen=C.MaChuyen) join TuyenDuong T on C.MaTuyen=T.MaTuyen
	 Where N.MaNV = @MaNV
 end 
go
-- DIRTY READ --
-- Khóa tài khoản --
Create proc sp_Khoa
 @MaNV varchar(10)
as
 begin tran
    begin try
       Update  NhanVien 
	   set TinhTrang = 'False'
	   where MaNV=@MaNV
	   WAITFOR DELAY '0:0:05'
       rollback tran
    end try
	begin catch
	   rollback tran
	end catch
 commit tran
go
-- Lấy tình trạng --
Create proc sp_LayTinhTrang
 @username nvarchar(50),
 @tenTT nvarchar(50) output
as
SET TRAN ISOLATION LEVEL READ UNCOMMITTED
 begin tran
    begin try
      Select @tenTT=T.TenTinhTrang  From NhanVien NV join TinhTrang T on NV.TinhTrang=T.MaTinhTrang Where Username=@username
	end try
	begin catch
	  rollback tran
	end catch
 commit tran
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
 begin tran
    Update  NhanVien 
	set HoTen =@Hoten, DiaChi=@Diachi, CMND=@CMND, DienThoai=@Dienthoai, KhaNangLai=@Khananglai, Username=@Username, MaPQ=@MaPQ, MaTo=@MaTo
	where MaNV=@MaNV
	Waitfor delay '00:00:10'
 Rollback
go
-- FIX DIRTY READ --
Create proc sp_LayTinhTrangfix
 @username nvarchar(50),
 @tenTT nvarchar(50) output
as
--SET TRAN ISOLATION LEVEL READ UNCOMMITTED
 begin tran
    begin try
      Select @tenTT=T.TenTinhTrang  From NhanVien NV join TinhTrang T on NV.TinhTrang=T.MaTinhTrang Where Username=@username
	end try
	begin catch
	  rollback tran
	end catch
 commit tran
go
-- UNREPEATABLE READ --
-- Đăng Nhập --
Create proc sp_DangNhap
 @Username nvarchar(50),
 @Password varchar(20),
 @Trave int output
as
 SET TRAN ISOLATION LEVEL READ UNCOMMITTED
 begin tran
    begin try
	    if(@Username != All(Select Username from NhanVien))
		   set @Trave = 0
	    if(@Password != (Select Password From NhanVien Where Username = @Username))
		   set @Trave = 0
		WAITFOR DELAY '0:0:05'
		if(@Username = (Select Username from NhanVien Where Username = @Username) and @Password = (Select Password From NhanVien Where Username = @Username))
		   set @Trave = 1
	end try
	begin catch
	    set @Trave = 0
	end catch    
 commit 
go
-- Đổi password --
Create proc sp_DoiMatKhau
 @MaNV varchar(10),
 @Password varchar(20)
as
 begin tran
    update NhanVien
	set Password = @Password
	where MaNV = @MaNV
 commit
go
-- FIX UNREPEATABLE READ --
Create proc sp_DangNhapfix
 @Username nvarchar(50),
 @Password varchar(20),
 @Trave int output
as
 SET TRANSACTION ISOLATION LEVEL REPEATABLE READ
 begin tran
    begin try
	    if(@Username != All(Select Username from NhanVien))
		   set @Trave = 0
	    if(@Password != (Select Password From NhanVien Where Username = @Username))
		   set @Trave = 0
		WAITFOR DELAY '0:0:05'
		if(@Username = (Select Username from NhanVien Where Username = @Username) and @Password = (Select Password From NhanVien Where Username = @Username))
		   set @Trave = 1
	end try
	begin catch
	    set @Trave = 0
	end catch    
 commit 
go
-- PHANTOM --
-- Get ID Nhân viên --
Create proc sp_GetIDNhanVien
 @MaNV varchar(10) output
as
 begin tran
   declare @n numeric
   declare @Z nchar(2),@W nchar(8)
   set @Z='NV'   
   if exists (Select top 1 * From NhanVien)
   begin
       WAITFOR DELAY '00:00:05'
       Select @n= max(cast(Substring(MaNV,3,8) as numeric)) From NhanVien
   end
   else
       set @n = 0
   set @n=@n+1
   set @W = cast(@n as nchar(8))
   While len(@W)<5
      set @W='0'+@W
   set @MaNV = @Z+@W
 commit
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
 begin tran
    Insert into NhanVien(MaNV,HoTen,DiaChi,CMND,DienThoai,KhaNangLai,Username,Password,MaPQ,MaTo,TinhTrang)
	Values (@MaNV,@Hoten,@Diachi,@CMND,@Dienthoai,@Khananglai,@Username,@Password,@MaPQ,@MaTo,'1')
 commit
go
-- FIX PHANTOM --
Create proc sp_GetIDNhanVienFix
 @MaNV varchar(10) output
as
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
 begin tran
   declare @n numeric
   declare @Z nchar(2),@W nchar(8)
   set @Z='NV'   
   if exists (Select top 1 * From NhanVien)
   begin
       WAITFOR DELAY '00:00:05'
       Select @n= max(cast(Substring(MaNV,3,8) as numeric)) From NhanVien
   end
   else
       set @n = 0
   set @n=@n+1
   set @W = cast(@n as nchar(8))
   While len(@W)<5
      set @W='0'+@W
   set @MaNV = @Z+@W
 commit
go