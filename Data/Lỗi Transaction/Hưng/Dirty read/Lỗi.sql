--1
alter proc sp_CapNhatLichTrinh
 @MaLich int,
 @Thang int,
 @MaNV varchar(10),
 @GioDi datetime,
 @GioDen datetime,
 @NoiDi nvarchar(100),
 @NoiDen nvarchar(100),
 @MaChuyen varchar(10)
as
begin tran
    begin try
		Update LichTrinh
		set Thang=@Thang,MaNV=@MaNV, GioDi=@GioDi, GioDen=@GioDen, NoiDi=@NoiDi, NoiDen=@NoiDen, MaChuyen=@MaChuyen
		Where MaLich=@MaLich
	end try
	begin catch
		waitfor delay '00:00:05' 
	  rollback tran
	end catch
 commit tran
go
--2
--CREATE
ALTER
PROC sp_LichTrinhCN
	@MaNV nvarchar(100)
AS
BEGIN TRAN
	SET TRAN ISOLATION LEVEL READ UNCOMMITTED
	DECLARE @SODU FLOAT = 0
	BEGIN TRY
		Select L.MaLich,L.Thang,L.GioDi,L.GioDen,L.NoiDi,L.NoiDen,C.HangXe,T.TenTuyen,T.KhoangCach
		From ((NhanVien N join LichTrinh L on N.MaNV=L.MaNV) join ChuyenXe C on L.MaChuyen=C.MaChuyen) join TuyenDuong T on C.MaTuyen=T.MaTuyen
		Where N.MaNV = @MaNV
	END TRY
	BEGIN CATCH
		DECLARE @ERRORMSG NVARCHAR(1000)
		SET @ERRORMSG = N'L?I : ' + ERROR_MESSAGE()
		RAISERROR (@ERRORMSG, 16,1)
		ROLLBACK TRAN
		RETURN
	END CATCH
COMMIT TRAN
go