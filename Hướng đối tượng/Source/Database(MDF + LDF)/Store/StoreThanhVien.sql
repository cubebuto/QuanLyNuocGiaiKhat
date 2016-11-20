CREATE PROCEDURE THANHVIEN_Ins
	@TenTV				nvarchar(30) = null,
	@Gioitinh			varchar(1) = null,
	@Ngaysinh			datetime = null,
	@Email				varchar(30) = null,
	@SDT				varchar(15) = null,
	@Tongtientichluy	int = null,
	@Diemtichluy		int = null,
	@Diachi				nvarchar(100) = null,
	@Status				varchar(1) = null
AS
	BEGIN TRANSACTION 
	INSERT INTO THANHVIEN(
	[TenTV],
	[Gioitinh],
	[Ngaysinh],
	[Email],
	[SDT],
	[Tongtientichluy],
	[Diemtichluy],
	[Diachi],
	[Status])
	VALUES
	(@TenTV,
	@Gioitinh,
	@Ngaysinh,
	@Email,
	@SDT,
	@Tongtientichluy,
	@Diemtichluy,
	@Diachi,
	@Status)
	COMMIT TRANSACTION
		SELECT SCOPE_IDENTITY() as Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE THANHVIEN_Upd
	@MaTV				int = null,
	@TenTV				nvarchar(30) = null,
	@Gioitinh			varchar(1) = null,
	@Ngaysinh			datetime = null,
	@Email				varchar(30) = null,
	@SDT				varchar(15) = null,
	@Tongtientichluy	int = null,
	@Diemtichluy		int = null,
	@Diachi				nvarchar(100) = null,
	@Status				varchar(1) = null
AS
	BEGIN TRANSACTION
	UPDATE THANHVIEN SET
	[TenTV] = @TenTV,
	[Gioitinh] = @Gioitinh,
	[Ngaysinh] = @Ngaysinh,
	[Email] = @Email,
	[SDT] = @SDT,
	[Tongtientichluy] = @Tongtientichluy,
	[Diemtichluy] = @Diemtichluy,
	[Diachi] = @Diachi,
	[Status] = @Status
	WHERE MaTV = @MaTV
	COMMIT TRANSACTION
		SELECT '1' as Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE THANHVIEN_Lst1
AS
SELECT * FROM THANHVIEN 
WHERE [Status] = '1'

GO
CREATE PROCEDURE THANHVIEN_Lst0
AS
SELECT * FROM THANHVIEN 
WHERE [Status] = '0'

GO
CREATE PROCEDURE THANHVIEN_Seach
	@TenTV	nvarchar(30) = null
AS
	BEGIN TRANSACTION
	SELECT * FROM THANHVIEN
	WHERE [TenTV] LIKE '%' + @TenTV + '%' OR  @TenTV IS NULL OR @TenTV= ''
	COMMIT TRANSACTION

GO
CREATE PROCEDURE THANHVIEN_ById
	@MaTV	int = null
AS
	BEGIN TRANSACTION
	SELECT * FROM THANHVIEN
	WHERE [MaTV] = @MaTV
	COMMIT TRANSACTION

GO
CREATE PROCEDURE THANHVIEN_Del
	@MaTV	int = null
AS
	BEGIN TRANSACTION
	DELETE FROM THANHVIEN
	WHERE [MaTV] = @MaTV
	COMMIT TRANSACTION
		SELECT '1' AS Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE THANHVIEN_Remove
AS
BEGIN TRANSACTION
	UPDATE THANHVIEN SET [Status] = '0'
	COMMIT TRANSACTION
		SELECT '1' AS Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE THANHVIEN_Restore
AS
BEGIN TRANSACTION
	UPDATE THANHVIEN SET [Status] = '1'
	COMMIT TRANSACTION
		SELECT '1' AS Result
		RETURN '1'
RETURN 0