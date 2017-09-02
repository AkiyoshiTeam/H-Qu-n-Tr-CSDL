use QLTaiXe
go
Alter proc sp_GetIDTuyenDuong
 @MaTuyen varchar(10) output
as
 begin tran
   declare @n numeric
   declare @Z nchar(2),@W nchar(8)
   set @Z='TD'   
   if exists (Select top 1 * From TuyenDuong)
   begin
       WAITFOR DELAY '00:00:05'
       Select @n= max(cast(Substring(MaTuyen,3,8) as numeric)) From TuyenDuong
   end
   else
       set @n = 0
   set @n=@n+1
   set @W = cast(@n as nchar(8))
   While len(@W)<5
      set @W='0'+@W
   set @MaTuyen = @Z+@W
 commit
go
Alter proc sp_ThemTuyenDuong
 @MaTuyen varchar(10),
 @TenTuyen nvarchar(50),
 @KhoangCach bigint
as
 begin tran
    Insert into TuyenDuong(MaTuyen,TenTuyen,KhoangCach)
	Values (@MaTuyen,@TenTuyen,@KhoangCach)
 commit
go