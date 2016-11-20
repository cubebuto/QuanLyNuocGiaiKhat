CREATE PROCEDURE HOADON_Ins
	@CodeHD			varchar(10) = null,
	@Tongtienbd		int = null,
	@Giagiam		int = null,
	@Thanhtien		int = null,
	@MaNV			int = null,
	@Ngaytao		datetime = null,
	@Status         varchar(1) = null
AS
	BEGIN TRANSACTION 
	INSERT INTO HOADON(
	[CodeHD],
	[Tongtienbd],
	[Giagiam],
	[Thanhtien],
	[MaNV],
	[Ngaytao],
	[Status])
	VALUES
	(@CodeHD,
	@Tongtienbd,
	@Giagiam,
	@Thanhtien,
	@MaNV,
	@Ngaytao,
	@Status)
	COMMIT TRANSACTION
		SELECT SCOPE_IDENTITY() as Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE HOADON_Upd
	@MaHD			int = null,
	@CodeHD			varchar(10) = null,
	@Tongtienbd		int = null,
	@Giagiam		int = null,
	@Thanhtien		int = null,
	@MaNV			int = null,
	@Ngaytao		datetime = null,
	@Status         varchar(1) = null
AS
	BEGIN TRANSACTION
	UPDATE HOADON SET
	[CodeHD] = @CodeHD,
	[Tongtienbd] = @Tongtienbd,
	[Giagiam] = @Giagiam,
	[Thanhtien] = @Thanhtien,
	[MaNV] = @MaNV,
	[Ngaytao] = @Ngaytao,
	[Status] = @Status
	WHERE [MaHD] = @MaHD
	COMMIT TRANSACTION
		SELECT '1' as Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE HOADON_Del
	@MaHD	int = null
AS
	BEGIN TRANSACTION
	DELETE FROM HOADON 
	WHERE [MaHD]  = @MaHD
	COMMIT TRANSACTION
		SELECT '1' AS Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE HOADON_ById
	@MaHD	int = null
AS
	BEGIN TRANSACTION
	SELECT * FROM HOADON 
	WHERE [MaHD]  = @MaHD
	COMMIT TRANSACTION

GO

GO
CREATE PROCEDURE HOADON_Lst1
AS
SELECT * FROM HOADON 
WHERE [Status] = '1'

GO
CREATE PROCEDURE HOADON_Lst0
AS
SELECT * FROM HOADON 
WHERE [Status] = '0'

GO
CREATE PROCEDURE HOADON_Remove
AS
BEGIN TRANSACTION
	UPDATE HOADON SET [Status] = '0'
	COMMIT TRANSACTION
		SELECT '1' AS Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE HOADON_Restore
AS
BEGIN TRANSACTION
	UPDATE HOADON SET [Status] = '1'
	COMMIT TRANSACTION
		SELECT '1' AS Result
		RETURN '1'
RETURN 0