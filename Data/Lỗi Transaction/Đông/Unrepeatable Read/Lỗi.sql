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
Alter proc sp_DoiMatKhau
 @MaNV varchar(10),
 @Password varchar(20)
as
 begin tran
    update NhanVien
	set Password = @Password
	where MaNV = @MaNV
 commit