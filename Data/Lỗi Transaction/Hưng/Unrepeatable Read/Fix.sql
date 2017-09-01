alter proc sp_CapNhatTuyenDuong
 @MaTuyen varchar(10),
 @TenTuyen nvarchar(50),
 @KhoangCach bigint
as
 begin tran
	SET TRAN ISOLATION LEVEL REPEATABLE READ
    begin try
		IF(NOT EXISTS (SELECT * FROM TuyenDuong WHERE MaTuyen = @MaTuyen))
		BEGIN
			PRINT @MaTuyen + N' KHÔNG T?N T?I'
			ROLLBACK TRAN
			RETURN
		END
		WAITFOR DELAY '0:0:05'
		Update TuyenDuong
		set TenTuyen = @TenTuyen, KhoangCach = @KhoangCach
		Where MaTuyen = @MaTuyen
	end try
	begin catch
	   rollback tran
	end catch
 commit tran
go