CREATE PROCEDURE CTPHIEUYEUCAU_Ins
	@MaPYC			int = null,
	@MaNL			int = null,
	@Soluong		int = null
AS
	BEGIN TRANSACTION 
	INSERT INTO CTPHIEUYEUCAU(
	[MaPYC],
	[MaNL],
	[Soluong])
	VALUES
	(@MaPYC,
	@MaNL,
	@Soluong)
	COMMIT TRANSACTION
		SELECT SCOPE_IDENTITY() as Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE CTPHIEUYEUCAU_Upd
	@MaCTPYC		int = null,
	@MaPYC			int = null,
	@MaNL			int = null,
	@Soluong		int = null
AS
	BEGIN TRANSACTION
	UPDATE CTPHIEUYEUCAU SET
	[MaPYC] = @MaPYC,
	[MaNL] = @MaNL,
	[Soluong] = @Soluong
	WHERE [MaCTPYC] = @MaCTPYC
	COMMIT TRANSACTION
		SELECT '1' as Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE CTPHIEUYEUCAU_Del
	@MaCTPYC	int = null
AS
	BEGIN TRANSACTION
	DELETE FROM CTPHIEUYEUCAU 
	WHERE [MaCTPYC] = @MaCTPYC
	COMMIT TRANSACTION
		SELECT '1' AS Result
		RETURN '1'
RETURN 0

GO
CREATE PROCEDURE CTPHIEUYEUCAU_ByMaPYC
	@MaPYC	int = null
AS
	BEGIN TRANSACTION
	SELECT * FROM CTPHIEUYEUCAU 
	WHERE [MaPYC]  = @MaPYC
	COMMIT TRANSACTION

