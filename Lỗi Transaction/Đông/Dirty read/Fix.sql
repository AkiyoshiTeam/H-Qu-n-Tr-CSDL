use QLTaiXe
go
Alter proc sp_LayTinhTrangfix
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