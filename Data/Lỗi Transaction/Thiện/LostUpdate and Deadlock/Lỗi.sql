use QLTaiXe
go
----Lost Update
alter proc sp_DatVe
 @MaLich int
as
begin tran
IF(NOT EXISTS (SELECT *  FROM Lichtrinh WHERE MaLich = @MaLich))
		BEGIN
			PRINT @MaLich + N' KHÔNG TỒN TẠI'
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
-- Hủy vé --
alter proc sp_HuyVe
 @MaLich int
as
begin tran 
IF(NOT EXISTS (SELECT * FROM Lichtrinh WHERE MaLich = @MaLich))
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