use QLTaiXe
go
alter proc sp_HuyVeFix
 @MaLich int
as
begin tran
set tran isolation level Repeatable read 
IF(NOT EXISTS (SELECT * FROM Lichtrinh with(xlock) WHERE MaLich = @MaLich))
		BEGIN
			PRINT @MaLich + N' KHÔNG TỒN TẠI'
			ROLLBACK TRAN
			RETURN
		END
  declare @SoLuongVeBanDuoc int
  set @SoLuongVeBanDuoc = (select SoLuongVeBanDuoc from LichTrinh where MaLich = @MaLich)
  waitfor delay '00:00:05'
 
  Update LichTrinh
  set SoLuongVeBanDuoc = @SoLuongVeBanDuoc -1 
  Where MaLich = @MaLich
commit
go