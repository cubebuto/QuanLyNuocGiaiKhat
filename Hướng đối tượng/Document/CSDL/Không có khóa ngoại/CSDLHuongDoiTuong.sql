CREATE TABLE SUCO
(
	MaSC			int identity(1,1) primary key,
	TenSC			nvarchar(100),
	Lydo			nvarchar(MAX),
	Ngaytao			datetime,
	Trangthai		varchar(1),
	Huonggiaiquyet	nvarchar(MAX),
	Status          varchar(1)
)

CREATE TABLE NHANVIEN
(
	MaNV			int identity(1,1) primary key,
	TenNV			nvarchar(30),
	CodeNV			nvarchar(20),
	ChucVu			nvarchar(20),
	Status          varchar(1)
)

CREATE TABLE THANHVIEN
(
	MaTV			int identity(1,1) primary key,
	TenTV			nvarchar(30),
	Gioitinh		varchar(1),
	Ngaysinh		datetime,
	Email			varchar(30),
	SDT				varchar(15),
	Tongtientichluy	int,
	Diemtichluy		int,
	Diachi			nvarchar(100),
	Status          varchar(1),

)

CREATE TABLE LOAITHUCUONG
(
	MaLoaiTU		int identity(1,1) primary key,
	TenTU			nvarchar(30),
	Status          varchar(1)
)

CREATE TABLE THUCUONG
(
	MaTU			int identity(1,1) primary key,
	TenTU			nvarchar(30),
	MaLoaiTU		int ,
	Thanhtien		int ,
	Status          varchar(1)
)

CREATE TABLE HOADON
(
	MaHD			int identity(1,1) primary key,
	CodeHD			varchar(10),
	Tongtienbd		int,
	Giagiam			int,
	Thanhtien		int,
	MaNV			int,
	Status          varchar(1)
)

CREATE TABLE CHITIETHOADON
(
	MaCTHD			int identity(1,1) primary key,
	MaHD			int ,
	MaTU			int,
	Giatien			int,
	Soluong			int,
	Thanhtien		int,
)

CREATE TABLE KHUYENMAI
(
	Mavoucher		int identity(1,1) primary key,
	Tenvoucher		nvarchar(30),
	Giagiam			int,
	Ngaytao			datetime,
	Trangthai		varchar(1),
	Ngaysudung		datetime,
	MaHDsudung		int ,
	Status          varchar(1)
)

CREATE TABLE PHIEUYEUCAU
(
	MaPYC			int identity(1,1) primary key,
	Ngaytao			datetime,
	MaNV			int ,
	Status          varchar(1)
)

CREATE TABLE NGUYENVATLIEU
(
	MaNL			int identity(1,1) primary key,
	TenNVL			nvarchar(30),
	Soluong			int,
	Gia				int,
	Tinhtrang		varchar(1),
	Status          varchar(1)
)

CREATE TABLE CTPHIEUYEUCAU
(
	MaCTPYC			int identity(1,1) primary key,
	MaPYC			int ,
	MaNL			int ,
	Soluong			int ,
)

CREATE TABLE PHIEUCHI
(
	MaPC			int identity(1,1) primary key,
	CodePC			varchar(10),
	Ngaytao			datetime,
	Lydo			nvarchar(MAX),
	Sotien			int,
	MaNV			int,
	Status          varchar(1)

)

CREATE TABLE PHIEUKIEMKE
(
	MaPKK			int identity(1,1) primary key,
	CodePKK			varchar(10),
	Ngaytao			datetime,
	MaNV			int ,
	Status          varchar(1)
)

CREATE TABLE CTPHIEUKIEMKE
(
	MaCTPKK			int identity(1,1) primary key,
	MaPKK			int ,
	MaNL			int ,
	Soluongtrongkho int,
	Soluongthucte	int,
	Lydochenhlech	nvarchar(MAX),
	Status          varchar(1)
)

CREATE TABLE HOADONNHAPHANG
(
	MAHDNHAPHANG	int identity(1,1) primary key,
	CODEHD          varchar(30),
	TONGTIEN		int,
	NGAYNHAP        date,
	MANVXACNHAN     int,
	STATUS          varchar(1)
)

CREATE TABLE CTHOADONNHAPHANG
(
	MACTHD			int identity(1,1) primary key,
	MAHDNHAPHANG    int,
	MANVL			int,
	SL      		int,
	GIA     		int,
	TONGTIEN 		int,
)