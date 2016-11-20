CREATE PROCEDURE CTPHIEUKIEMKE_Ins
	@MaPKK				int = null,
	@MaNL				int = null,
	@Soluongtrongkho	int = null,
	@Soluongthucte		int = null,
	@Lydochenhlech		nvarchar(MAX) = null,
	@Status				varchar(1) = null
AS
	BEGIN TRANSACTION 
	INSERT INTO CTPHIEUKIEMKE(
	[MaPKK],
	[MaNL],
	[Soluongtrongkho],
	[Soluongthucte],
	[Lydochenhlech],
	[Status])
	VALUES
	(@MaPKK,
	@MaNL,
	@Soluongtrongkho,
	@Soluongthucte,
	@Lydochenhlech,
	@Status)
	COMMIT TRANSACTION
		SELECT SCOPE_IDENTITY() as Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE CTPHIEUKIEMKE_Upd
	@MaCTPKK			int = null,
	@MaPKK				int = null,
	@MaNL				int = null,
	@Soluongtrongkho	int = null,
	@Soluongthucte		int = null,
	@Lydochenhlech		nvarchar(MAX) = null,
	@Status				varchar(1) = null
AS
	BEGIN TRANSACTION
	UPDATE CTPHIEUKIEMKE SET
	[MaPKK] = @MaPKK,
	[MaNL] = @MaNL,
	[Soluongtrongkho] = @Soluongtrongkho,
	[Soluongthucte] = @Soluongthucte,
	[Lydochenhlech] = @Lydochenhlech,
	[Status] = @Status
	WHERE [MaCTPKK] = @MaCTPKK
	COMMIT TRANSACTION
		SELECT '1' as Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE CTPHIEUKIEMKE_Del
	@MaCTPKK	int = null
AS
	BEGIN TRANSACTION
	DELETE FROM CTPHIEUKIEMKE 
	WHERE [MaCTPKK] = @MaCTPKK
	COMMIT TRANSACTION
		SELECT '1' AS Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE CTPHIEUKIEMKE_ByPhieuKiemKeId
	@MaPKK	int = null
AS
	BEGIN TRANSACTION
	SELECT * FROM CTPHIEUKIEMKE 
	WHERE [MaPKK] = @MaPKK
	COMMIT TRANSACTION

