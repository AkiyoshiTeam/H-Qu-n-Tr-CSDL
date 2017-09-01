use QLTaiXe
go
Alter proc sp_Khoa
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
Alter proc sp_LayTinhTrang
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