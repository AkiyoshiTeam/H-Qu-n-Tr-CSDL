use QLTaiXe
go
Alter PROC sp_LichTrinhCNFix
	@MaNV nvarchar(100)
AS
BEGIN TRAN
	DECLARE @SODU FLOAT = 0
	BEGIN TRY
		Select L.MaLich,L.Thang,L.GioDi,L.GioDen,L.NoiDi,L.NoiDen,C.HangXe,T.TenTuyen,T.KhoangCach
		From ((NhanVien N join LichTrinh L on N.MaNV=L.MaNV) join ChuyenXe C on L.MaChuyen=C.MaChuyen) join TuyenDuong T on C.MaTuyen=T.MaTuyen
		Where N.MaNV = @MaNV
	END TRY
	BEGIN CATCH
		DECLARE @ERRORMSG NVARCHAR(1000)
		SET @ERRORMSG = N'LỖI : ' + ERROR_MESSAGE()
		RAISERROR (@ERRORMSG, 16,1)
		ROLLBACK TRAN
		RETURN
	END CATCH
COMMIT TRAN
go