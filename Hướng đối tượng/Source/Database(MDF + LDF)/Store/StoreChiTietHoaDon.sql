CREATE PROCEDURE CHITIETHOADON_Ins
	@MaHD			int = null,
	@MaTU			int = null,
	@Giatien		int = null,
	@Soluong		int = null,
	@Thanhtien		int = null
AS
	BEGIN TRANSACTION 
	INSERT INTO CHITIETHOADON(
	[MaHD],
	[MaTU],
	[Giatien],
	[Soluong],
	[Thanhtien])
	VALUES
	(@MaHD,
	@MaTU,
	@Giatien,
	@Soluong,
	@Thanhtien)
	COMMIT TRANSACTION
		SELECT SCOPE_IDENTITY() as Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE CHITIETHOADON_Upd
	@MaCTHD			int = null,
	@MaHD			int = null,
	@MaTU			int = null,
	@Giatien		int = null,
	@Soluong		int = null,
	@Thanhtien		int = null
AS
	BEGIN TRANSACTION
	UPDATE CHITIETHOADON SET
	[MaHD] = @MaHD,
	[MaTU] = @MaTU,
	[Giatien] = @Giatien,
	[Soluong] = @Soluong,
	[Thanhtien]= @Thanhtien
	WHERE [MaCTHD] = @MaCTHD
	COMMIT TRANSACTION
		SELECT '1' as Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE CHITIETHOADON_Del
	@MaCTHD	int = null
AS
	BEGIN TRANSACTION
	DELETE FROM CHITIETHOADON 
	WHERE [MaCTHD] = @MaCTHD
	COMMIT TRANSACTION
		SELECT '1' AS Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE CHITIETHOADON_ByMaHDId
	@MaHD	int = null
AS
	BEGIN TRANSACTION
	SELECT * FROM CHITIETHOADON 
	WHERE [MaHD] = @MaHD
	COMMIT TRANSACTION


