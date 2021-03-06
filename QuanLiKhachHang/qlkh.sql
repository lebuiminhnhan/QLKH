USE [QLKH]
GO
/****** Object:  Table [dbo].[tblCoUuDai]    Script Date: 10/01/2019 5:02:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCoUuDai](
	[MaUD] [int] NOT NULL,
	[MaKH] [int] NOT NULL,
	[MaGD] [int] NOT NULL,
 CONSTRAINT [PK_tblCoUuDai] PRIMARY KEY CLUSTERED 
(
	[MaUD] ASC,
	[MaKH] ASC,
	[MaGD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblGiaoDich]    Script Date: 10/01/2019 5:02:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblGiaoDich](
	[MaGD] [int] NOT NULL,
	[NgayGiaoDich] [datetime] NOT NULL,
	[TienThanhToan] [int] NOT NULL,
	[DiemTich] [int] NOT NULL,
	[TienGiam] [int] NOT NULL,
	[DiemTru] [int] NOT NULL,
	[TrangThai] [nvarchar](max) NOT NULL,
	[MaNV] [int] NOT NULL,
	[MaKH] [int] NOT NULL,
 CONSTRAINT [PK_tblGiaoDich] PRIMARY KEY CLUSTERED 
(
	[MaGD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblKhachHang]    Script Date: 10/01/2019 5:02:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhachHang](
	[MaKH] [int] IDENTITY(100400,1) NOT NULL,
	[HoTen] [nvarchar](max) NOT NULL,
	[GioiTinh] [nvarchar](max) NOT NULL,
	[NamSinh] [datetime] NOT NULL,
	[CMND] [nvarchar](max) NOT NULL,
	[SDT] [nvarchar](max) NOT NULL,
	[DiaChi] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[DiemLuu] [int] NULL,
	[DiemTichLuy] [int] NOT NULL,
	[LoaiKhachHang] [nvarchar](max) NULL,
	[TrangThai] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblKhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblLichSuGiaoDich]    Script Date: 10/01/2019 5:02:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLichSuGiaoDich](
	[MaLSGD] [int] IDENTITY(6000001,1) NOT NULL,
	[TongTienGD] [int] NOT NULL,
	[MaGD] [int] NOT NULL,
	[MaKH] [int] NOT NULL,
 CONSTRAINT [PK_tblLichSuGiaoDich] PRIMARY KEY CLUSTERED 
(
	[MaLSGD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblLoaiSanPham]    Script Date: 10/01/2019 5:02:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLoaiSanPham](
	[MaLoai] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblLoaiSanPham] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblNhaCungCap]    Script Date: 10/01/2019 5:02:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhaCungCap](
	[MaNCC] [int] IDENTITY(1,1) NOT NULL,
	[TenNCC] [nvarchar](50) NOT NULL,
	[SDT] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblNhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblNhanVien]    Script Date: 10/01/2019 5:02:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhanVien](
	[MaNV] [int] IDENTITY(5000001,1) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](50) NOT NULL,
	[NamSinh] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[SDT] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblNhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblQuyen]    Script Date: 10/01/2019 5:02:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblQuyen](
	[MaQuyen] [int] NOT NULL,
	[TenQuyen] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblQuyen] PRIMARY KEY CLUSTERED 
(
	[MaQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblSanPham]    Script Date: 10/01/2019 5:02:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSanPham](
	[MaSP] [int] IDENTITY(2000001,1) NOT NULL,
	[TenSP] [nvarchar](50) NOT NULL,
	[MucGiamGia] [int] NOT NULL,
	[DonGia] [int] NOT NULL,
	[MaNCC] [int] NOT NULL,
	[MaLH] [int] NOT NULL,
 CONSTRAINT [PK_tblSanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblSanPhamGiaoDich]    Script Date: 10/01/2019 5:02:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSanPhamGiaoDich](
	[MaGD] [int] NOT NULL,
	[MaSP] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_tblSanPhamGiaoDich] PRIMARY KEY CLUSTERED 
(
	[MaGD] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblTaiKhoan]    Script Date: 10/01/2019 5:02:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTaiKhoan](
	[TenDangNhap] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NOT NULL,
	[MaQuyen] [int] NOT NULL,
	[MaNV] [int] NULL,
	[MaKH] [int] NULL,
 CONSTRAINT [PK_tblTaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblUuDai]    Script Date: 10/01/2019 5:02:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUuDai](
	[MaUD] [int] IDENTITY(1,1) NOT NULL,
	[TenUD] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_tblUuDai] PRIMARY KEY CLUSTERED 
(
	[MaUD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[tblCoUuDai]  WITH CHECK ADD  CONSTRAINT [FK_tblCoUuDai_tblGiaoDich] FOREIGN KEY([MaGD])
REFERENCES [dbo].[tblGiaoDich] ([MaGD])
GO
ALTER TABLE [dbo].[tblCoUuDai] CHECK CONSTRAINT [FK_tblCoUuDai_tblGiaoDich]
GO
ALTER TABLE [dbo].[tblCoUuDai]  WITH CHECK ADD  CONSTRAINT [FK_tblCoUuDai_tblKhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[tblKhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[tblCoUuDai] CHECK CONSTRAINT [FK_tblCoUuDai_tblKhachHang]
GO
ALTER TABLE [dbo].[tblCoUuDai]  WITH CHECK ADD  CONSTRAINT [FK_tblCoUuDai_tblUuDai] FOREIGN KEY([MaUD])
REFERENCES [dbo].[tblUuDai] ([MaUD])
GO
ALTER TABLE [dbo].[tblCoUuDai] CHECK CONSTRAINT [FK_tblCoUuDai_tblUuDai]
GO
ALTER TABLE [dbo].[tblGiaoDich]  WITH CHECK ADD  CONSTRAINT [FK_tblGiaoDich_tblKhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[tblKhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[tblGiaoDich] CHECK CONSTRAINT [FK_tblGiaoDich_tblKhachHang]
GO
ALTER TABLE [dbo].[tblGiaoDich]  WITH CHECK ADD  CONSTRAINT [FK_tblGiaoDich_tblNhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[tblGiaoDich] CHECK CONSTRAINT [FK_tblGiaoDich_tblNhanVien]
GO
ALTER TABLE [dbo].[tblLichSuGiaoDich]  WITH CHECK ADD  CONSTRAINT [FK_tblLichSuGiaoDich_tblGiaoDich] FOREIGN KEY([MaGD])
REFERENCES [dbo].[tblGiaoDich] ([MaGD])
GO
ALTER TABLE [dbo].[tblLichSuGiaoDich] CHECK CONSTRAINT [FK_tblLichSuGiaoDich_tblGiaoDich]
GO
ALTER TABLE [dbo].[tblLichSuGiaoDich]  WITH CHECK ADD  CONSTRAINT [FK_tblLichSuGiaoDich_tblKhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[tblKhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[tblLichSuGiaoDich] CHECK CONSTRAINT [FK_tblLichSuGiaoDich_tblKhachHang]
GO
ALTER TABLE [dbo].[tblSanPham]  WITH CHECK ADD  CONSTRAINT [FK_tblSanPham_tblLoaiSanPham] FOREIGN KEY([MaLH])
REFERENCES [dbo].[tblLoaiSanPham] ([MaLoai])
GO
ALTER TABLE [dbo].[tblSanPham] CHECK CONSTRAINT [FK_tblSanPham_tblLoaiSanPham]
GO
ALTER TABLE [dbo].[tblSanPham]  WITH CHECK ADD  CONSTRAINT [FK_tblSanPham_tblNhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[tblNhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[tblSanPham] CHECK CONSTRAINT [FK_tblSanPham_tblNhaCungCap]
GO
ALTER TABLE [dbo].[tblSanPhamGiaoDich]  WITH CHECK ADD  CONSTRAINT [FK_tblSanPhamGiaoDich_tblGiaoDich] FOREIGN KEY([MaGD])
REFERENCES [dbo].[tblGiaoDich] ([MaGD])
GO
ALTER TABLE [dbo].[tblSanPhamGiaoDich] CHECK CONSTRAINT [FK_tblSanPhamGiaoDich_tblGiaoDich]
GO
ALTER TABLE [dbo].[tblSanPhamGiaoDich]  WITH CHECK ADD  CONSTRAINT [FK_tblSanPhamGiaoDich_tblSanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[tblSanPham] ([MaSP])
GO
ALTER TABLE [dbo].[tblSanPhamGiaoDich] CHECK CONSTRAINT [FK_tblSanPhamGiaoDich_tblSanPham]
GO
ALTER TABLE [dbo].[tblTaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_tblTaiKhoan_tblKhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[tblKhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[tblTaiKhoan] CHECK CONSTRAINT [FK_tblTaiKhoan_tblKhachHang]
GO
ALTER TABLE [dbo].[tblTaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_tblTaiKhoan_tblNhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[tblTaiKhoan] CHECK CONSTRAINT [FK_tblTaiKhoan_tblNhanVien]
GO
ALTER TABLE [dbo].[tblTaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_tblTaiKhoan_tblQuyen] FOREIGN KEY([MaQuyen])
REFERENCES [dbo].[tblQuyen] ([MaQuyen])
GO
ALTER TABLE [dbo].[tblTaiKhoan] CHECK CONSTRAINT [FK_tblTaiKhoan_tblQuyen]
GO
