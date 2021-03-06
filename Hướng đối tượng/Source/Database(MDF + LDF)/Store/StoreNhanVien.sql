CREATE PROCEDURE NHANVIEN_Ins
	@TenNV nvarchar(30) = null,
	@CodeNV nvarchar(20) = null,
	@ChucVu nvarchar(20) = null,
	@Status varchar(1) = null
AS
	BEGIN TRANSACTION 
	INSERT INTO NHANVIEN(
	[TenNV],
	[CodeNV],
	[ChucVu],
	[Status])
	VALUES
	(@TenNV,
	@CodeNV,
	@ChucVu,
	@Status)
	COMMIT TRANSACTION
		SELECT SCOPE_IDENTITY() as Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE NHANVIEN_Upd
	@MaNV	int = null,
	@TenNV nvarchar(30) = null,
	@CodeNV nvarchar(20) = null,
	@ChucVu nvarchar(20) = null,
	@Status varchar(1) = null
AS
	BEGIN TRANSACTION
	UPDATE NHANVIEN SET
	[TenNV] = @TenNV,
	[CodeNV] = @CodeNV,
	[ChucVu] = @ChucVu,
	[Status] = @Status
	WHERE MaNV = @MaNV
	COMMIT TRANSACTION
		SELECT '1' as Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE NHANVIEN_Lst1
AS
SELECT * FROM NHANVIEN 
WHERE [Status] = '1'

GO
CREATE PROCEDURE NHANVIEN_Lst0
AS
SELECT * FROM NHANVIEN 
WHERE [Status] = '0'

GO
CREATE PROCEDURE NHANVIEN_Seach
	@TenNV	nvarchar(30) = null
AS
	BEGIN TRANSACTION
	SELECT * FROM NHANVIEN
	WHERE TenNV LIKE '%' + @TenNV + '%' OR  @TenNV IS NULL OR @TenNV= ''
	COMMIT TRANSACTION

GO
CREATE PROCEDURE NHANVIEN_ById
	@MaNV	int = null
AS
	BEGIN TRANSACTION
	SELECT * FROM NHANVIEN 
	WHERE MaNV = @MaNV
	COMMIT TRANSACTION

GO
CREATE PROCEDURE NHANVIEN_Del
	@MaNV	int = null
AS
	BEGIN TRANSACTION
	DELETE FROM NHANVIEN 
	WHERE MaNV = @MaNV
	COMMIT TRANSACTION
		SELECT '1' AS Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE NHANVIEN_Remove
AS
BEGIN TRANSACTION
	UPDATE NHANVIEN SET [Status] = '0'
	COMMIT TRANSACTION
		SELECT '1' AS Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE NHANVIEN_Restore
AS
BEGIN TRANSACTION
	UPDATE NHANVIEN SET [Status] = '1'
	COMMIT TRANSACTION
		SELECT '1' AS Result
		RETURN '1'
RETURN 0