use QLTaiXe
go
Alter proc sp_GetIDNhanVienFix
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