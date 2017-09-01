----Fix
alter proc sp_DatVe
 @MaLich int
as
begin tran
set tran isolation level Repeatable read 
IF(NOT EXISTS (SELECT *  FROM Lichtrinh with(xlock) WHERE MaLich = @MaLich))
		BEGIN
			PRINT @MaLich + N' KHÔNG T?N T?I'
			ROLLBACK TRAN
			RETURN
		END
  declare @SoLuongVeBanDuoc int
  set @SoLuongVeBanDuoc = (select SoLuongVeBanDuoc from LichTrinh where MaLich = @MaLich)
  waitfor delay '00:00:05'
  Update LichTrinh
  set SoLuongVeBanDuoc = @SoLuongVeBanDuoc + 1
  Where MaLich = @MaLich
commit
go
-- H?y vé --
alter proc sp_HuyVe
 @MaLich int
as
begin tran
set tran isolation level Repeatable read 
IF(NOT EXISTS (SELECT * FROM Lichtrinh with(xlock) WHERE MaLich = @MaLich))
		BEGIN
			PRINT @MaLich + N' KHÔNG T?N T?I'
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