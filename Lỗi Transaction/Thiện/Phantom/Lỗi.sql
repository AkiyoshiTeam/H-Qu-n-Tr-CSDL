use QLTaiXe
go
Alter proc sp_GetIDNhanVien
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
Alter proc sp_ThemNV
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