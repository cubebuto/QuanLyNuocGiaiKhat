CREATE PROCEDURE SUCO_Ins
	@TenSC				nvarchar(100) = null,
	@Lydo				nvarchar(MAX) = null,
	@Ngaytao			datetime  = null,
	@Trangthai			varchar(1)  = null,
	@Huonggiaiquyet		nvarchar(MAX)  = null,
	@Status				varchar(1)  = null
AS
	BEGIN TRANSACTION 
	INSERT INTO SUCO(
	[TenSC],
	[Lydo],
	[Ngaytao],
	[Trangthai],
	[Huonggiaiquyet],
	[Status])
	VALUES
	(@TenSC,
	@Lydo,
	@Ngaytao,
	@Trangthai,
	@Huonggiaiquyet,
	@Status)
	COMMIT TRANSACTION
		SELECT SCOPE_IDENTITY() as Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE SUCO_Upd
	@MaSC				int = null,
	@TenSC				nvarchar(100) = null,
	@Lydo				nvarchar(MAX) = null,
	@Ngaytao			datetime  = null,
	@Trangthai			varchar(1)  = null,
	@Huonggiaiquyet		nvarchar(MAX)  = null,
	@Status				varchar(1)  = null
AS
	BEGIN TRANSACTION
	UPDATE SUCO SET
	[TenSC] = @TenSC,
	[Lydo] = @Lydo,
	[Ngaytao] = @Ngaytao,
	[Trangthai] = @Trangthai,
	[Huonggiaiquyet] = @Huonggiaiquyet,
	[Status] = @Status
	WHERE [MaSC] = @MaSC
	COMMIT TRANSACTION
		SELECT '1' as Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE SUCO_Del
	@MaSC	int = null
AS
	BEGIN TRANSACTION
	DELETE FROM SUCO 
	WHERE [MaSC] = @MaSC
	COMMIT TRANSACTION
		SELECT '1' AS Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE SUCO_ById
	@MaSC	int = null
AS
	BEGIN TRANSACTION
	SELECT * FROM SUCO 
	WHERE [MaSC]  = @MaSC
	COMMIT TRANSACTION

GO
CREATE PROCEDURE SUCO_Seach
	@TenSC	nvarchar(30) = null
AS
	BEGIN TRANSACTION
	SELECT * FROM SUCO
	WHERE [TenSC] LIKE '%' + @TenSC + '%' OR  @TenSC IS NULL OR @TenSC= ''
	COMMIT TRANSACTION

GO
CREATE PROCEDURE SUCO_Lst1
AS
SELECT * FROM SUCO 
WHERE [Status] = '1'

GO
CREATE PROCEDURE SUCO_Lst0
AS
SELECT * FROM SUCO 
WHERE [Status] = '0'

GO
CREATE PROCEDURE SUCO_Remove
AS
BEGIN TRANSACTION
	UPDATE SUCO SET [Status] = '0'
	COMMIT TRANSACTION
		SELECT '1' AS Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE SUCO_Restore
AS
BEGIN TRANSACTION
	UPDATE SUCO SET [Status] = '1'
	COMMIT TRANSACTION
		SELECT '1' AS Result
		RETURN '1'
RETURN 0