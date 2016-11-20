CREATE PROCEDURE NGUYENVATLIEU_Ins
	@TenNVL			nvarchar(30) = null,
	@Soluong		int = null,
	@Gia			int = null,
	@Tinhtrang		varchar(1) = null,
	@Status         varchar(1) = null
AS
	BEGIN TRANSACTION 
	INSERT INTO NGUYENVATLIEU(
	[TenNVL],
	[Soluong],
	[Gia],
	[Tinhtrang],
	[Status])
	VALUES
	(@TenNVL,
	@Soluong,
	@Gia,
	@Tinhtrang,
	@Status)
	COMMIT TRANSACTION
		SELECT SCOPE_IDENTITY() as Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE NGUYENVATLIEU_Upd
	@MaNL			int = null,
	@TenNVL			nvarchar(30) = null,
	@Soluong		int = null,
	@Gia			int = null,
	@Tinhtrang		varchar(1) = null,
	@Status         varchar(1) = null
AS
	BEGIN TRANSACTION
	UPDATE NGUYENVATLIEU SET
	[TenNVL] = @TenNVL,
	[Soluong] = @Soluong,
	[Gia] = @Gia,
	[Tinhtrang] = @Tinhtrang,
	[Status] = @Status
	WHERE [MaNL] = @MaNL
	COMMIT TRANSACTION
		SELECT '1' as Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE NGUYENVATLIEU_Del
	@MaNL	int = null
AS
	BEGIN TRANSACTION
	DELETE FROM NGUYENVATLIEU 
	WHERE [MaNL] = @MaNL
	COMMIT TRANSACTION
		SELECT '1' AS Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE NGUYENVATLIEU_ById
	@MaNL	int = null
AS
	BEGIN TRANSACTION
	SELECT * FROM NGUYENVATLIEU 
	WHERE [MaNL] = @MaNL
	COMMIT TRANSACTION

GO
CREATE PROCEDURE NGUYENVATLIEU_Seach
	@TenNVL	nvarchar(30) = null
AS
	BEGIN TRANSACTION
	SELECT * FROM NGUYENVATLIEU
	WHERE [TenNVL] LIKE '%' + @TenNVL + '%' OR  @TenNVL IS NULL OR @TenNVL= ''
	COMMIT TRANSACTION

GO
CREATE PROCEDURE NGUYENVATLIEU_Lst1
AS
SELECT * FROM NGUYENVATLIEU 
WHERE [Status] = '1'

GO
CREATE PROCEDURE NGUYENVATLIEU_Lst0
AS
SELECT * FROM NGUYENVATLIEU 
WHERE [Status] = '0'

GO
CREATE PROCEDURE NGUYENVATLIEU_Remove
AS
BEGIN TRANSACTION
	UPDATE NGUYENVATLIEU SET [Status] = '0'
	COMMIT TRANSACTION
		SELECT '1' AS Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE NGUYENVATLIEU_Restore
AS
BEGIN TRANSACTION
	UPDATE NGUYENVATLIEU SET [Status] = '1'
	COMMIT TRANSACTION
		SELECT '1' AS Result
		RETURN '1'
RETURN 0