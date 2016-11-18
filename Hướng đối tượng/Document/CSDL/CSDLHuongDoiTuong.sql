CREATE TABLE SUCO
(
	MaSC			int identity(1,1) primary key,
	TenSC			nvarchar(100),
	Lydo			nvarchar(MAX),
	Ngaytao			datetime,
	Trangthai		varchar(1),
	Huonggiaiquyet	nvarchar(MAX)
)

CREATE TABLE NHANVIEN
(
	MaNV			int identity(1,1) primary key,
	TenNV			nvarchar(30),
	CodeNV			nvarchar(20),
	ChucVu			nvarchar(20)
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
	Diachi			nvarchar(100)
)

CREATE TABLE LOAITHUCUONG
(
	MaLoaiTU		int identity(1,1) primary key,
	TenTU			nvarchar(30)
)

CREATE TABLE THUCUONG
(
	MaTU			int identity(1,1) primary key,
	TenTU			nvarchar(30),
	MaLoaiTU		int FOREIGN KEY REFERENCES LOAITHUCUONG(MaLoaiTU),
	Thanhtien		int
)

CREATE TABLE HOADON
(
	MaHD			int identity(1,1) primary key,
	CodeHD			varchar(10),
	Tongtienbd		int,
	Giagiam			int,
	Thanhtien		int,
	MaNV			int FOREIGN KEY REFERENCES NHANVIEN(MaNV)
)

CREATE TABLE CHITIETHOADON
(
	MaCTHD			int identity(1,1) primary key,
	MaHD			int FOREIGN KEY REFERENCES HOADON(MaHD),
	MaTU			int,
	Giatien			int,
	Soluong			int,
	Thanhtien		int
)

CREATE TABLE KHUYENMAI
(
	Mavoucher		int identity(1,1) primary key,
	Tenvoucher		nvarchar(30),
	Giagiam			int,
	Ngaytao			datetime,
	Trangthai		varchar(1),
	Ngaysudung		datetime,
	MaHDsudung		int FOREIGN KEY REFERENCES HOADON(MaHD)
)

CREATE TABLE PHIEUYEUCAU
(
	MaPYC			int identity(1,1) primary key,
	Ngaytao			datetime,
	MaNV			int FOREIGN KEY REFERENCES NHANVIEN(MaNV)
)

CREATE TABLE NGUYENVATLIEU
(
	MaNL			int identity(1,1) primary key,
	TenNVL			nvarchar(30),
	Soluong			int,
	Gia				int,
	Tinhtrang		varchar(1)
)

CREATE TABLE CTPHIEUYEUCAU
(
	MaCTPYC			int identity(1,1) primary key,
	MaPYC			int FOREIGN KEY REFERENCES PHIEUYEUCAU(MaPYC),
	MaNL			int FOREIGN KEY REFERENCES NGUYENVATLIEU(MaNL),
	Soluong			int
)

CREATE TABLE PHIEUCHI
(
	MaPC			int identity(1,1) primary key,
	CodePC			varchar(10),
	Ngaytao			datetime,
	Lydo			nvarchar(MAX),
	Sotien			int,
	MaNV			int FOREIGN KEY REFERENCES NHANVIEN(MaNV)
)

CREATE TABLE PHIEUKIEMKE
(
	MaPKK			int identity(1,1) primary key,
	CodePKK			varchar(10),
	Ngaytao			datetime,
	MaNV			int FOREIGN KEY REFERENCES NHANVIEN(MaNV)
)

CREATE TABLE CTPHIEUKIEMKE
(
	MaCTPKK			int identity(1,1) primary key,
	MaPKK			int FOREIGN KEY REFERENCES PHIEUKIEMKE(MaPKK),
	MaNL			int FOREIGN KEY REFERENCES NGUYENVATLIEU(MaNL),
	Soluongtrongkho int,
	Soluongthucte	int,
	Lydochenhlech	nvarchar(MAX)
)