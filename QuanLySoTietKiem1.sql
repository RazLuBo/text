create database QuanLySoTietKiem1
go


USE [QuanLySoTietKiem1]
GO

/****** Object:  Table [dbo].[DANGNHAP]    Script Date: 6/10/2021 1:25:40 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DANGNHAP](
	[TenHienThi] [nvarchar](100) NOT NULL,
	[TenDN] [varchar](100) NOT NULL,
	[MatKhau] [varchar](100) NOT NULL,
	[Loai] [int] NOT NULL,
 CONSTRAINT [DANGNHAP_pk] PRIMARY KEY CLUSTERED 
(
	[TenDN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QuanLySoTietKiem1]
GO

/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 6/10/2021 1:26:07 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [char](4) NOT NULL,
	[HoTen] [varchar](50) NOT NULL,
	[DiaChi] [varchar](100) NOT NULL,
	[SDT] [varchar](20) NOT NULL,
	[CMNN_or_HoChieu] [varchar](50) NOT NULL,
	[SoDu] [money] NULL,
 CONSTRAINT [KhachHang_pk] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [QuanLySoTietKiem1]
GO

/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 6/10/2021 1:26:17 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [char](4) NOT NULL,
	[HoTen] [varchar](50) NOT NULL,
	[DiaChi] [varchar](100) NOT NULL,
	[SDT] [varchar](20) NOT NULL,
	[CMNN_or_HoChieu] [varchar](50) NOT NULL,
 CONSTRAINT [NhanVien_pk] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO



USE [QuanLySoTietKiem1]
GO

/****** Object:  Table [dbo].[DOANHTHU]    Script Date: 6/10/2021 1:26:33 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DOANHTHU](
	[MaLS] [char](4) NOT NULL,
	[LoaiSo] [varchar](50) NOT NULL,
	[TongThu] [money] NULL,
	[TongChi] [money] NULL,
	[ChenhLechThuChi] [money] NULL,
	[SoMo] [int] NULL,
	[SoDong] [int] NULL,
	[ChenhLechSoMD] [int] NULL,
	[Ngay] [smalldatetime] NOT NULL,
 CONSTRAINT [MaLS_pk] PRIMARY KEY CLUSTERED 
(
	[MaLS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QuanLySoTietKiem1]
GO

/****** Object:  Table [dbo].[SOTIETKIEM]    Script Date: 6/10/2021 1:26:51 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SOTIETKIEM](
	[MaSo] [char](4) NOT NULL,
	[MaNV] [char](4) NULL,
	[MaKH] [char](4) NULL,
	[MaLS] [char](4) NULL,
	[LoaiSo] [varchar](50) NOT NULL,
	[NgayMoSo] [smalldatetime] NOT NULL,
	[NgayHetHan] [smalldatetime] NOT NULL,
	[TienGoi] [money] NOT NULL,
 CONSTRAINT [SoTietKiem_pk] PRIMARY KEY CLUSTERED 
(
	[MaSo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[SOTIETKIEM]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO

ALTER TABLE [dbo].[SOTIETKIEM]  WITH CHECK ADD FOREIGN KEY([MaLS])
REFERENCES [dbo].[DOANHTHU] ([MaLS])
GO

ALTER TABLE [dbo].[SOTIETKIEM]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO




USE [QuanLySoTietKiem1]
GO

/****** Object:  Table [dbo].[GOITIEN]    Script Date: 6/10/2021 1:27:11 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[GOITIEN](
	[MaGT] [char](4) NOT NULL,
	[MaNV] [char](4) NULL,
	[MaKH] [char](4) NULL,
	[MaSo] [char](4) NULL,
	[NgayGoi] [smalldatetime] NOT NULL,
	[TienGoi] [money] NOT NULL,
 CONSTRAINT [GoiTien_pk] PRIMARY KEY CLUSTERED 
(
	[MaGT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[GOITIEN]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO

ALTER TABLE [dbo].[GOITIEN]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO

ALTER TABLE [dbo].[GOITIEN]  WITH CHECK ADD FOREIGN KEY([MaSo])
REFERENCES [dbo].[SOTIETKIEM] ([MaSo])
GO



USE [QuanLySoTietKiem1]
GO

/****** Object:  Table [dbo].[RUTTIEN]    Script Date: 6/10/2021 1:27:46 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RUTTIEN](
	[MaRT] [char](4) NOT NULL,
	[MaNV] [char](4) NULL,
	[MaKH] [char](4) NULL,
	[MaSo] [char](4) NULL,
	[NgayRut] [smalldatetime] NOT NULL,
	[TienRut] [money] NOT NULL,
 CONSTRAINT [RutTien_pk] PRIMARY KEY CLUSTERED 
(
	[MaRT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[RUTTIEN]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO

ALTER TABLE [dbo].[RUTTIEN]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO

ALTER TABLE [dbo].[RUTTIEN]  WITH CHECK ADD FOREIGN KEY([MaSo])
REFERENCES [dbo].[SOTIETKIEM] ([MaSo])
GO



USE [QuanLySoTietKiem1]
GO

/****** Object:  StoredProcedure [dbo].[insertAccount]    Script Date: 6/9/2021 10:36:25 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

USE [QuanLySoTietKiem1]
GO

/****** Object:  StoredProcedure [dbo].[insertAccount]    Script Date: 6/10/2021 1:27:58 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[insertAccount]
@tenHienThi varchar(50), @tenDN varchar(50), @matKhau varchar(50), @loai int
as
begin
	declare @countAccount int;
	select @countAccount = count(*) from DANGNHAP where TenDN = @tenDN

	if(@countAccount = 0)
	begin
		insert into DANGNHAP (TenHienThi, TenDN, MatKhau, Loai)
		values (
			@tenHienThi, @tenDN, @matKhau, @loai
		);
	end
end;
GO


select count(*) from dbo.DANGNHAP dn where dn.TenDN = 'admin' and dn.MatKhau = 'ISMvKXpXpadDiUoOSoAfww=='

USE [QuanLySoTietKiem1]
GO

/****** Object:  StoredProcedure [dbo].[searchAccount]    Script Date: 6/9/2021 10:36:52 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[searchAccount]
@tenDN varchar(50), @matKhau varchar(50)
as
begin
	select count(*) from DANGNHAP dn where dn.TenDN = @tenDN and dn.MatKhau = @matKhau
end;
GO



USE [QuanLySoTietKiem1]
GO

/****** Object:  StoredProcedure [dbo].[insertCustomer]    Script Date: 6/9/2021 10:37:35 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[insertCustomer]
@maKH varchar(50), @hoTen varchar(50), @diaChi varchar(50), @sDT varchar(50), @cmnd varchar(50), @soDu money
as
begin
	Declare @countCus int;
	Declare @money money;

	select @countCus = COUNT (*) from KHACHHANG k where k.MaKH = @maKH
	select @money from KHACHHANG where MaKH = @maKH

	if(@countCus = 0)
	begin
		insert into KHACHHANG(MaKH, HoTen, DiaChi, SDT, CMNN_or_HoChieu, SoDu)
		values (
			@maKH, @hoTen, @diaChi, @sDT, @cmnd, @soDu
		);
	end
	else
	begin
		update KHACHHANG set SoDu = @money + @soDu
	end
end;
GO



USE [QuanLySoTietKiem1]
GO

/****** Object:  StoredProcedure [dbo].[searchCustomer]    Script Date: 6/9/2021 10:37:18 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[searchCustomer]
@maKH varchar(50)
as 
begin 
	select * from KHACHHANG where MaKH = @maKH
end;
GO



USE [QuanLySoTietKiem1]
GO

/****** Object:  StoredProcedure [dbo].[insertSoTietKiem]    Script Date: 6/9/2021 10:35:32 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[insertSoTietKiem] 
@maSo varchar(50), @maNV varchar(50), @maKH varchar(50), @maLS varchar(50), @loaiSo varchar(50), @ngayMoSo smallDatetime, @ngayHetHan smallDatetime, @tienGoi money
as
begin 
	Declare @countMaSo int;
	select @countMaSo = COUNT (*) from SOTIETKIEM where MaSo = @maSo
	declare @countLS int;
	select @countLS = COUNT (*) from DOANHTHU where MaLS = @maLS
	if(@countMaSo = 0 and @countLS = 1)
	begin
		insert into SOTIETKIEM(MaSo, MaNV, MaKH, MaLS, LoaiSo, NgayMoSo, NgayHetHan, TienGoi)
		values (
			@maSo, @maNV, @maKH, @maLS, @loaiSo, @ngayMoSo, @ngayHetHan, @tienGoi
		)
		update DOANHTHU
		set SoMo = SoMo + 1, TongThu = TongThu + @tienGoi, ChenhLechThuChi = TongThu - TongChi
		where @maLS = MaLS
	end
end;
GO

USE [QuanLySoTietKiem1]
GO

/****** Object:  StoredProcedure [dbo].[insertStaff]    Script Date: 6/10/2021 1:28:58 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[insertStaff] 
@maNV varchar(50), @hoTen varchar(50), @diaChi varchar(50), @sdt varchar(50), @cmnd varchar(50)
as
begin
Declare @countCus int;
	Declare @money money;

	select @countCus = COUNT (*) from NHANVIEN k where k.MaNV = @maNV

	if(@countCus = 0)
	begin
		insert into NHANVIEN(MaNV, HoTen, DiaChi, SDT, CMNN_or_HoChieu)
		values (
			@maNV, @hoTen, @diaChi, @sdt, @cmnd
		);
	end
end;
GO



USE [QuanLySoTietKiem1]
GO

/****** Object:  StoredProcedure [dbo].[insertGoiTien]    Script Date: 6/10/2021 1:29:09 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[insertGoiTien] 
@maGT varchar(50), @maNV varchar(50), @maKH varchar(50), @maSo varchar(50), @ngayGoi smalldatetime, @tienGoi money
as
begin
	declare @countGT int;
	select @countGT = count(*) from GOITIEN where @maGT = MaGT

	if(@countGT = 0)
	begin
		insert into GOITIEN (MaGT, MaNV, MaKH, MaSo, NgayGoi, TienGoi)
		values (
			@maGT, @maNV, @maKH, @maSo, @ngayGoi, @tienGoi
		);
		update KHACHHANG
		set SoDu = SoDu + @tienGoi
		where @maKH = MaKH

		update DOANHTHU
		set TongThu = TongThu + @tienGoi
		where MaLS in (select stk.MaLS from SOTIETKIEM stk where stk.MaSo = @maSo)

		update DOANHTHU
		set ChenhLechThuChi = TongThu - TongChi
		where MaLS in (select stk.MaLS from SOTIETKIEM stk where stk.MaSo = @maSo)
	end
end;
GO


USE [QuanLySoTietKiem1]
GO

/****** Object:  StoredProcedure [dbo].[insertRutTien]    Script Date: 6/10/2021 1:29:25 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[insertRutTien] 
@maRT varchar(50), @maNV varchar(50), @maKH varchar(50), @maSo varchar(50), @ngayRut smalldatetime, @tienRut money
as
begin
	declare @countGT int;
	declare @soDu money;

	select @countGT = count(*) from RUTTIEN where @maRT = MaRT

	select @soDu = SoDu from KHACHHANG where MaKH = @maKH

	if(@countGT = 0 and @soDu - @tienRut > 0)
	begin
		insert into RUTTIEN (MaRT, MaNV, MaKH, MaSo, NgayRut, TienRut)
		values (
			@maRT, @maNV, @maKH, @maSo, @ngayRut, @tienRut
		);
		update KHACHHANG
		set SoDu = SoDu - @tienRut
		where @maKH = MaKH

		update DOANHTHU
		set TongChi = TongChi + @tienRut, ChenhLechThuChi = TongThu - TongChi
		where MaLS in (select stk.MaLS from SOTIETKIEM stk where stk.MaSo = @maSo)

		update DOANHTHU
		set ChenhLechThuChi = TongThu - TongChi
		where MaLS in (select stk.MaLS from SOTIETKIEM stk where stk.MaSo = @maSo)
	end

end;
GO

USE [QuanLySoTietKiem1]
GO

/****** Object:  StoredProcedure [dbo].[GetStaffInfo]    Script Date: 6/10/2021 1:29:36 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[GetStaffInfo]
@maNV varchar(50)
as 
begin
	select * from NHANVIEN where @maNV = MaNV
end;
GO
