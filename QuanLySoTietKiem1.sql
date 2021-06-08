create database QuanLySoTietKiem1
go

use QuanLySoTietKiem1
go


CREATE TABLE DANGNHAP
(
	TenHienThi nvarchar(100) NOT NULL,
	TenDN varchar(100) NOT NULL,
	MatKhau varchar(100) NOT NULL,
	Loai int NOT NULL,--Loại tài khoản đăng nhập
	constraint DANGNHAP_pk primary key (TenDN)
)
GO

CREATE TABLE KHACHHANG
(
	MaKH char(4) ,
	HoTen varchar(50) NOT NULL,
	DiaChi varchar(100)NOT NULL,
	SDT varchar(20)NOT NULL,
	CMNN_or_HoChieu varchar(50)NOT NULL,
	SoDu money--Số Dư Tài Khoảng
	constraint KhachHang_pk primary key (MaKH)
)
GO
CREATE TABLE NHANVIEN
(
	MaNV char(4) ,
	HoTen varchar(50) NOT NULL,
	DiaChi varchar(100)NOT NULL,
	SDT varchar(20)NOT NULL,
	CMNN_or_HoChieu varchar(50)NOT NULL
	constraint NhanVien_pk primary key (MaNV)
)
GO

CREATE TABLE DOANHTHU
(
	MaLS char(4),
	LoaiSo varchar(50) NOT NULL,
	TongThu money,
	TongChi money,
	ChenhLechThuChi money,
	SoMo int,
	SoDong int,
	ChenhLechSoMD int,
	Ngay smalldatetime NOT NULL,
	constraint MaLS_pk primary key (MaLS)
)
GO

CREATE TABLE SOTIETKIEM
(
	MaSo char(4) ,
	MaNV char(4) ,
	MaKH char(4),
	MaLS char(4),
	LoaiSo Varchar(50)NOT NULL, 
	NgayMoSo smalldatetime NOT NULL,
	NgayHetHan smalldatetime NOT NULL,
	TienGoi money NOT NULL,

	constraint SoTietKiem_pk primary key (MaSo),
	foreign key (MaNV) references NHANVIEN(MaNV),
	foreign key (MaKH) references KHACHHANG(MaKH),
	foreign key (MaLS) references DOANHTHU(MaLS)
)
GO


CREATE TABLE GOITIEN
(
	MaGT char(4) ,
	MaNV char(4) ,
	MaKH char(4),
	MaSo char(4),
	NgayGoi smalldatetime NOT NULL,
	TienGoi money NOT NULL,
	
	constraint GoiTien_pk primary key (MaGT),
	foreign key (MaNV) references NHANVIEN(MaNV),
	foreign key (MaKH) references KHACHHANG(MaKH),
	foreign key (MaSo) references SOTIETKIEM(MaSo)
)
GO

CREATE TABLE RUTTIEN
(
	MaRT char(4) ,
	MaNV char(4) ,
	MaKH char(4),
	MaSo char(4),
	NgayRut smalldatetime NOT NULL,
	TienRut money NOT NULL,
	
	constraint RutTien_pk primary key (MaRT),
	foreign key (MaNV) references NHANVIEN(MaNV),
	foreign key (MaKH) references KHACHHANG(MaKH),
	foreign key (MaSo) references SOTIETKIEM(MaSo)
)
GO
