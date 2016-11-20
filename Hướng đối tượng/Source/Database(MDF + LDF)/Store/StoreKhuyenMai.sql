CREATE PROCEDURE KHUYENMAI_Ins
	@Codevoucher	nvarchar(20) = null,
	@Tenvoucher		nvarchar(30) = null,
	@Giagiam		int = null,
	@Ngaytao		datetime = null,
	@Ngaybatdau		datetime = null,
	@Ngayketthuc	datetime = null,
	@Status         varchar(1) = null
AS
	BEGIN TRANSACTION 
	INSERT INTO KHUYENMAI(
	[Codevoucher],
	[Tenvoucher],
	[Giagiam],
	[Ngaytao],
	[Ngaybatdau],
	[Ngayketthuc],
	[Status])
	VALUES
	(@Codevoucher,
	@Tenvoucher,
	@Giagiam,
	@Ngaytao,
	@Ngaybatdau,
	@Ngayketthuc,
	@Status)
	COMMIT TRANSACTION
		SELECT SCOPE_IDENTITY() as Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE KHUYENMAI_Upd
	@Mavoucher		int = null,
	@Codevoucher	nvarchar(20) = null,
	@Tenvoucher		nvarchar(30) = null,
	@Giagiam		int = null,
	@Ngaytao		datetime = null,
	@Ngaybatdau		datetime = null,
	@Ngayketthuc	datetime = null,
	@Status         varchar(1) = null
AS
	BEGIN TRANSACTION
	UPDATE KHUYENMAI SET
	[Codevoucher] = @Codevoucher,
	[Tenvoucher] = @Tenvoucher,
	[Giagiam] = @Giagiam,
	[Ngaytao] = @Ngaytao,
	[Ngaybatdau] = @Ngaybatdau,
	[Ngayketthuc] = @Ngayketthuc,
	[Status] = @Status
	WHERE [Mavoucher] = @Mavoucher
	COMMIT TRANSACTION
		SELECT '1' as Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE KHUYENMAI_Del
	@Mavoucher	int = null
AS
	BEGIN TRANSACTION
	DELETE FROM KHUYENMAI 
	WHERE [Mavoucher]  = @Mavoucher
	COMMIT TRANSACTION
		SELECT '1' AS Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE KHUYENMAI_ById
	@Mavoucher	int = null
AS
	BEGIN TRANSACTION
	SELECT * FROM KHUYENMAI 
	WHERE [Mavoucher]  = @Mavoucher
	COMMIT TRANSACTION

GO
CREATE PROCEDURE KHUYENMAI_Seach
	@Tenvoucher	nvarchar(30) = null
AS
	BEGIN TRANSACTION
	SELECT * FROM KHUYENMAI
	WHERE [Tenvoucher] LIKE '%' + @Tenvoucher + '%' OR  @Tenvoucher IS NULL OR @Tenvoucher= ''
	COMMIT TRANSACTION

GO
CREATE PROCEDURE KHUYENMAI_Lst1
AS
SELECT * FROM KHUYENMAI 
WHERE [Status] = '1'

GO
CREATE PROCEDURE KHUYENMAI_Lst0
AS
SELECT * FROM KHUYENMAI 
WHERE [Status] = '0'

GO
CREATE PROCEDURE KHUYENMAI_Remove
AS
BEGIN TRANSACTION
	UPDATE KHUYENMAI SET [Status] = '0'
	COMMIT TRANSACTION
		SELECT '1' AS Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE KHUYENMAI_Restore
AS
BEGIN TRANSACTION
	UPDATE KHUYENMAI SET [Status] = '1'
	COMMIT TRANSACTION
		SELECT '1' AS Result
		RETURN '1'
RETURN 0