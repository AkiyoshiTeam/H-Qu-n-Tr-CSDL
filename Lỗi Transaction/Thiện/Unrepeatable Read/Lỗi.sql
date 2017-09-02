use QLTaiXe
go
Alter proc sp_DangNhap
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
Alter proc sp_CapNhatNV
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
   begin try
     Update  NhanVien 
	 set HoTen =@Hoten, DiaChi=@Diachi, CMND=@CMND, DienThoai=@Dienthoai, KhaNangLai=@Khananglai, Username=@Username, MaPQ=@MaPQ, MaTo=@MaTo
	 where MaNV=@MaNV
   end try
   begin catch
      Waitfor delay '00:00:10'
      rollback
   end catch
 commit
go