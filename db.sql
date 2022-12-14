USE master
GO
DROP DATABASE IF EXISTS PhongKham
GO
CREATE DATABASE PhongKham
GO

USE [PhongKham]
GO
/****** Object:  Table [dbo].[tBenhNhan]    Script Date: 9/13/2022 11:29:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tBenhNhan](
	[MaBenhNhan] [nvarchar](50) NOT NULL,
	[TenBenhNhan] [nvarchar](50) NULL,
	[Tuoi] [tinyint] NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBenhNhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tChiTietToaThuoc]    Script Date: 9/13/2022 11:29:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tChiTietToaThuoc](
	[STT] [int] NOT NULL,
	[Thuoc] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[LieuDung] [nvarchar](500) NULL,
 CONSTRAINT [PK_tChiTietToaThuoc] PRIMARY KEY CLUSTERED 
(
	[STT] ASC,
	[Thuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tThuoc]    Script Date: 9/13/2022 11:29:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tThuoc](
	[TenThuoc] [nvarchar](50) NULL,
	[NuocSX] [nvarchar](50) NULL,
	[DonGia] [int] NULL,
	[HanSuDung] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](1000) NULL,
	[MaThuoc] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_tThuoc] PRIMARY KEY CLUSTERED 
(
	[MaThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tToaThuoc]    Script Date: 9/13/2022 11:29:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tToaThuoc](
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[BenhNhan] [nvarchar](50) NULL,
	[BenhDuocChanDoan] [nvarchar](50) NULL,
	[NgayKham] [date] NULL,
 CONSTRAINT [PK_tToaThuoc] PRIMARY KEY CLUSTERED 
(
	[STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tBenhNhan] ([MaBenhNhan], [TenBenhNhan], [Tuoi], [GioiTinh], [DiaChi]) VALUES (N'33316557', N'Hoài Bảo', 27, N'Nam', N'Bình Chánh, TP.HCM')
INSERT [dbo].[tBenhNhan] ([MaBenhNhan], [TenBenhNhan], [Tuoi], [GioiTinh], [DiaChi]) VALUES (N'35766751', N'Đăng Khoa', 21, N'Nam', N'Bình Tân, TP.HCM')
INSERT [dbo].[tBenhNhan] ([MaBenhNhan], [TenBenhNhan], [Tuoi], [GioiTinh], [DiaChi]) VALUES (N'48260526', N'Minh Long', 29, N'Nam', N'Quận 1, TP.HCM')
INSERT [dbo].[tBenhNhan] ([MaBenhNhan], [TenBenhNhan], [Tuoi], [GioiTinh], [DiaChi]) VALUES (N'57903504', N'Thái Học', 30, N'Nam', N'Quận 7, TPHCM')
INSERT [dbo].[tBenhNhan] ([MaBenhNhan], [TenBenhNhan], [Tuoi], [GioiTinh], [DiaChi]) VALUES (N'62755794', N'Ngọc Lan', 23, N'Nữ', N'Nhà Bè, TP.HCM')
INSERT [dbo].[tBenhNhan] ([MaBenhNhan], [TenBenhNhan], [Tuoi], [GioiTinh], [DiaChi]) VALUES (N'79333311', N'Ngọc Thảo', 22, N'Nữ', N'Bình Chánh, TP.HCM')
INSERT [dbo].[tBenhNhan] ([MaBenhNhan], [TenBenhNhan], [Tuoi], [GioiTinh], [DiaChi]) VALUES (N'85957393', N'Hoàng Duy', 25, N'Nam', N'Thủ Đức, TP.HCM')
INSERT [dbo].[tBenhNhan] ([MaBenhNhan], [TenBenhNhan], [Tuoi], [GioiTinh], [DiaChi]) VALUES (N'93016157', N'Minh Hiếu', 24, N'Nam', N'Tân Bình, TP.HCM')
GO
INSERT [dbo].[tChiTietToaThuoc] ([STT], [Thuoc], [SoLuong], [LieuDung]) VALUES (1, 2, 1, N'1 đến 2 gói/lần, 2 đến 3 lần mỗi ngày.')
INSERT [dbo].[tChiTietToaThuoc] ([STT], [Thuoc], [SoLuong], [LieuDung]) VALUES (1, 3, 1, N'NULLNgày uống 2-4 gói (không uống quá 6 gói/ngày), mỗi lần 1 gói.
')
INSERT [dbo].[tChiTietToaThuoc] ([STT], [Thuoc], [SoLuong], [LieuDung]) VALUES (2, 4, 2, N'1 viên mỗi 4 đến 6 giờ. Liều tối đa cần hàng ngày là: 6 viên ( tương đương 24mg) trong 24 giờ của ngày')
INSERT [dbo].[tChiTietToaThuoc] ([STT], [Thuoc], [SoLuong], [LieuDung]) VALUES (2, 5, 3, N'10 mg/lần/ngày')
INSERT [dbo].[tChiTietToaThuoc] ([STT], [Thuoc], [SoLuong], [LieuDung]) VALUES (3, 6, 2, N'Uống 1 - 3 gói/ngày, uống trước khi ăn hoặc khi có biểu hiện khó tiêu, rối loạn tiêu hóa')
INSERT [dbo].[tChiTietToaThuoc] ([STT], [Thuoc], [SoLuong], [LieuDung]) VALUES (4, 7, 1, N'liều từ 400mg-800mg cách mỗi 6-8 giờ.')
GO
SET IDENTITY_INSERT [dbo].[tThuoc] ON 

INSERT [dbo].[tThuoc] ([TenThuoc], [NuocSX], [DonGia], [HanSuDung], [GhiChu], [MaThuoc]) VALUES (N'Yumangel ', N'Hàn Quốc', 90000, N'24 tháng', N'Thuốc có tác dụng kháng acid và cải thiện các chứng bệnh sau: loét dạ dày, loét tá tràng; viêm dạ dày; các chứng bệnh do tăng tiết acid (ợ nóng, buồn nôn, nôn, đau dạ dày, chứng ợ); bệnh trào ngược thực quản', 1)
INSERT [dbo].[tThuoc] ([TenThuoc], [NuocSX], [DonGia], [HanSuDung], [GhiChu], [MaThuoc]) VALUES (N'Phosphalugel ', N'Pháp', 1170000, N'36 tháng', N'giúp cải thiện, giảm nhẹ các triệu chứng tiêu hóa bao gồm đau, bỏng rát do axit gây ra trong các bệnh lý viêm loét dạ dày hoặc thực quản. Thuốc thường được biết đến là thuốc dạ dày chữ P, sử dụng không cần kê đơn của bác sĩ, bào chế dưới dạng hỗn dịch uống nên phù hợp cho cả những người khó nuốt như người già, trẻ em.', 2)
INSERT [dbo].[tThuoc] ([TenThuoc], [NuocSX], [DonGia], [HanSuDung], [GhiChu], [MaThuoc]) VALUES (N'Gastropulgite', N'Pháp', 120000, N'36 tháng', N'điều trị các triệu chứng đau do rối loạn thực quản - dạ dày - tá tràng và triệu chứng trong trào ngược dạ dày thực quản', 3)
INSERT [dbo].[tThuoc] ([TenThuoc], [NuocSX], [DonGia], [HanSuDung], [GhiChu], [MaThuoc]) VALUES (N'Clorpheniramin', N'Việt Nam', 30000, N'36 tháng', N'Thuốc thường được dùng để trị cho những trường hợp viêm mũi dị ứng theo mùa và quanh năm. Thuốc cũng điều trị tốt với những trường hợp liên quan đến dị ứng của bệnh mề đay, viêm mũi vận mạch, viêm kết mạc, viêm da tiếp xúc…', 4)
INSERT [dbo].[tThuoc] ([TenThuoc], [NuocSX], [DonGia], [HanSuDung], [GhiChu], [MaThuoc]) VALUES (N'Loratadin', N'Việt Nam', 20000, N'36 tháng', N'điều trị viêm mũi dị ứng bao gồm hắt hơi, sổ mũi, chảy nước mũi, ngứa mũi, viêm kết mạc dị ứng, ngứa và chảy nước mắt do dị ứng, ngứa, mày đay và các bệnh về da do dị ứng khác', 5)
INSERT [dbo].[tThuoc] ([TenThuoc], [NuocSX], [DonGia], [HanSuDung], [GhiChu], [MaThuoc]) VALUES (N'Sorbitol', N'Việt Nam', 40000, N'36 tháng', N'Thúc đẩy quá trình hydrat hóa các chất trong đường ruột, từ đó dễ dàng chuyển hóa thức ăn. Làm tăng áp suất thẩm thấu ở ruột, từ đó làm tăng lượng nước trong đường ruột, giúp việc đi ngoài được dễ dàng hơn.', 6)
INSERT [dbo].[tThuoc] ([TenThuoc], [NuocSX], [DonGia], [HanSuDung], [GhiChu], [MaThuoc]) VALUES (N'Ibuprofen', N'Việt Nam', 88000, N'24 tháng', N'Dùng cho viêm khớp dạng thấp, viêm khớp dạng thấp thiếu niên.', 7)
SET IDENTITY_INSERT [dbo].[tThuoc] OFF
GO
SET IDENTITY_INSERT [dbo].[tToaThuoc] ON 

INSERT [dbo].[tToaThuoc] ([STT], [BenhNhan], [BenhDuocChanDoan], [NgayKham]) VALUES (1, N'33316557', N'Viêm dạ dày', CAST(N'2022-02-03' AS Date))
INSERT [dbo].[tToaThuoc] ([STT], [BenhNhan], [BenhDuocChanDoan], [NgayKham]) VALUES (2, N'62755794', N'Viêm mũi dị ứng', CAST(N'2022-03-17' AS Date))
INSERT [dbo].[tToaThuoc] ([STT], [BenhNhan], [BenhDuocChanDoan], [NgayKham]) VALUES (3, N'79333311', N'Viêm đại tràng', CAST(N'2022-04-05' AS Date))
INSERT [dbo].[tToaThuoc] ([STT], [BenhNhan], [BenhDuocChanDoan], [NgayKham]) VALUES (4, N'85957393', N'Viêm cơ', CAST(N'2022-01-23' AS Date))
SET IDENTITY_INSERT [dbo].[tToaThuoc] OFF
GO
ALTER TABLE [dbo].[tChiTietToaThuoc]  WITH CHECK ADD  CONSTRAINT [FK_tChiTietToaThuoc_tThuoc] FOREIGN KEY([Thuoc])
REFERENCES [dbo].[tThuoc] ([MaThuoc])
GO
ALTER TABLE [dbo].[tChiTietToaThuoc] CHECK CONSTRAINT [FK_tChiTietToaThuoc_tThuoc]
GO
ALTER TABLE [dbo].[tChiTietToaThuoc]  WITH CHECK ADD  CONSTRAINT [FK_tChiTietToaThuoc_tToaThuoc] FOREIGN KEY([STT])
REFERENCES [dbo].[tToaThuoc] ([STT])
GO
ALTER TABLE [dbo].[tChiTietToaThuoc] CHECK CONSTRAINT [FK_tChiTietToaThuoc_tToaThuoc]
GO
ALTER TABLE [dbo].[tToaThuoc]  WITH CHECK ADD  CONSTRAINT [FK_tToaThuoc_tBenhNhan] FOREIGN KEY([BenhNhan])
REFERENCES [dbo].[tBenhNhan] ([MaBenhNhan])
GO
ALTER TABLE [dbo].[tToaThuoc] CHECK CONSTRAINT [FK_tToaThuoc_tBenhNhan]
GO
