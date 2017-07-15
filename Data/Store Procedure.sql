Use QLTaiXe
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
--


