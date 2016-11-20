CREATE PROCEDURE PHIEUCHI_Ins
	@CodePC			varchar(10) = null,
	@Ngaytao		datetime = null,
	@Lydo			nvarchar(MAX) = null,
	@Sotien			int = null,
	@MaNV			int = null,
	@Status         varchar(1) = null
AS
	BEGIN TRANSACTION 
	INSERT INTO PHIEUCHI(
	[CodePC],
	[Ngaytao],
	[Lydo],
	[Sotien],
	[MaNV],
	[Status])
	VALUES
	(@CodePC,
	@Ngaytao,
	@Lydo,
	@Sotien,
	@MaNV,
	@Status)
	COMMIT TRANSACTION
		SELECT SCOPE_IDENTITY() as Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE PHIEUCHI_Upd
	@MaPC			int	= null,
	@CodePC			varchar(10) = null,
	@Ngaytao		datetime = null,
	@Lydo			nvarchar(MAX) = null,
	@Sotien			int = null,
	@MaNV			int = null,
	@Status         varchar(1) = null
AS
	BEGIN TRANSACTION
	UPDATE PHIEUCHI SET
	[CodePC] = @CodePC,
	[Ngaytao] = @Ngaytao,
	[Lydo] = @Lydo,
	[Sotien] = @Sotien,
	[MaNV] = @MaNV,
	[Status] = @Status
	WHERE [MaPC] = @MaPC
	COMMIT TRANSACTION
		SELECT '1' as Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE PHIEUCHI_Del
	@MaPC	int = null
AS
	BEGIN TRANSACTION
	DELETE FROM PHIEUCHI 
	WHERE [MaPC]  = @MaPC
	COMMIT TRANSACTION
		SELECT '1' AS Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE PHIEUCHI_ById
	@MaPC	int = null
AS
	BEGIN TRANSACTION
	SELECT * FROM PHIEUCHI 
	WHERE [MaPC]  = @MaPC
	COMMIT TRANSACTION

GO
CREATE PROCEDURE PHIEUCHI_Seach
	@Lydo	nvarchar(MAX) = null
AS
	BEGIN TRANSACTION
	SELECT * FROM PHIEUCHI
	WHERE [Lydo] LIKE '%' + @Lydo + '%' OR  @Lydo IS NULL OR @Lydo= ''
	COMMIT TRANSACTION

GO
CREATE PROCEDURE PHIEUCHI_Lst1
AS
SELECT * FROM PHIEUCHI 
WHERE [Status] = '1'

GO
CREATE PROCEDURE PHIEUCHI_Lst0
AS
SELECT * FROM PHIEUCHI 
WHERE [Status] = '0'

GO
CREATE PROCEDURE PHIEUCHI_Remove
AS
BEGIN TRANSACTION
	UPDATE PHIEUCHI SET [Status] = '0'
	COMMIT TRANSACTION
		SELECT '1' AS Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE PHIEUCHI_Restore
AS
BEGIN TRANSACTION
	UPDATE PHIEUCHI SET [Status] = '1'
	COMMIT TRANSACTION
		SELECT '1' AS Result
		RETURN '1'
RETURN 0