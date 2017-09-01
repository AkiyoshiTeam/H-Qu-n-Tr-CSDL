ALTER
PROC sp_ThongKeChuyenXeTheoTuyen
	@MaTuyen as varchar(45)
AS
BEGIN TRAN
	DECLARE @MaChuyenXe CHAR(10), @TONGSO INT
	BEGIN TRY
		DECLARE cur CURSOR DYNAMIC FOR SELECT MaChuyen
										FROM ChuyenXe 
										WHERE MaTuyen = @MaTuyen
		OPEN CUR
		SET @TONGSO = (SELECT COUNT(DISTINCT MaChuyen)
						FROM ChuyenXe 
						WHERE MaTuyen = @MaTuyen)
		PRINT N'T?NG S? SP: ' + CAST(@TONGSO AS CHAR(3))
		PRINT N'DANH SÁCH CÁC CHUY?N XE '
		PRINT '_________________________________________'
		FETCH NEXT FROM CUR INTO @MaChuyenXe
		WHILE (@@FETCH_STATUS = 0)
		BEGIN
			PRINT @MaChuyenXe
			WAITFOR DELAY '0:0:05'
			FETCH NEXT FROM CUR INTO @MaChuyenXe
		END
		CLOSE CUR
		DEALLOCATE CUR
	END TRY
	BEGIN CATCH
		DECLARE @ErrorMsg VARCHAR(2000)
		SELECT @ErrorMsg = N'L?i: ' + ERROR_MESSAGE()
		RAISERROR(@ErrorMsg, 16,1)
		ROLLBACK TRAN
		RETURN
	END CATCH
COMMIT TRAN
GO
--2
Alter proc sp_ThemChuyenXe
 @MaChuyen varchar(10),
 @HangXe nvarchar(50),
 @MaTuyen varchar(10),
 @GiaVe bigint
as
 begin tran
    begin try
		Insert into ChuyenXe(MaChuyen,HangXe,GiaVe,MaTuyen)
		Values (@MaChuyen,@HangXe,@GiaVe,@MaTuyen)
	end try
	begin catch 
	  rollback tran
	end catch
 commit tran
go