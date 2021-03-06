USE [QL]
GO
/****** Object:  Table [dbo].[DIEMCHUAN]    Script Date: 21/10/2021 8:51:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DIEMCHUAN](
	[MANGANH] [nvarchar](50) NOT NULL,
	[TENNGANH] [nvarchar](50) NULL,
	[MATRUONG] [nvarchar](50) NULL,
	[DIEM] [nvarchar](50) NULL,
 CONSTRAINT [PK_DIEMCHUAN] PRIMARY KEY CLUSTERED 
(
	[MANGANH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DIEMTHI]    Script Date: 21/10/2021 8:51:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DIEMTHI](
	[MAMON] [nvarchar](50) NOT NULL,
	[DIEM] [nvarchar](50) NULL,
 CONSTRAINT [PK_DIEMTHI] PRIMARY KEY CLUSTERED 
(
	[MAMON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DTUT]    Script Date: 21/10/2021 8:51:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DTUT](
	[MADTUT] [nvarchar](50) NOT NULL,
	[TENDTUT] [nvarchar](50) NULL,
 CONSTRAINT [PK_DTUT] PRIMARY KEY CLUSTERED 
(
	[MADTUT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HUYEN]    Script Date: 21/10/2021 8:51:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HUYEN](
	[MAHUYEN] [nvarchar](50) NOT NULL,
	[TENHUYEN] [nvarchar](50) NULL,
	[MATINH] [nvarchar](50) NULL,
 CONSTRAINT [PK_HUYEN] PRIMARY KEY CLUSTERED 
(
	[MAHUYEN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KETQUA]    Script Date: 21/10/2021 8:51:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KETQUA](
	[MAHS] [nvarchar](50) NOT NULL,
	[SBD] [nvarchar](50) NULL,
	[DIEMCONG] [nvarchar](50) NULL,
	[TONGDIEM] [nvarchar](50) NULL,
	[MAMON] [nvarchar](50) NULL,
 CONSTRAINT [PK_KETQUA] PRIMARY KEY CLUSTERED 
(
	[MAHS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KVUT]    Script Date: 21/10/2021 8:51:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KVUT](
	[MAKVUT] [nvarchar](50) NOT NULL,
	[TENKVUT] [nvarchar](50) NULL,
 CONSTRAINT [PK_KVUT] PRIMARY KEY CLUSTERED 
(
	[MAKVUT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MONTHI]    Script Date: 21/10/2021 8:51:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MONTHI](
	[MAMON] [nvarchar](50) NOT NULL,
	[TENMON] [nvarchar](50) NULL,
 CONSTRAINT [PK_MONTHI] PRIMARY KEY CLUSTERED 
(
	[MAMON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NGANH]    Script Date: 21/10/2021 8:51:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGANH](
	[MANGANH] [nvarchar](50) NOT NULL,
	[TENNGANH] [nvarchar](50) NULL,
	[MATRUONG] [nvarchar](50) NULL,
 CONSTRAINT [PK_NGANH] PRIMARY KEY CLUSTERED 
(
	[MANGANH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THISINH]    Script Date: 21/10/2021 8:51:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THISINH](
	[MAHS] [nvarchar](50) NOT NULL,
	[HOTEN] [nvarchar](50) NULL,
	[NGAYSINH] [date] NULL,
	[GIOITINH] [bit] NULL,
	[SBD] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[MAHUYEN] [nvarchar](50) NULL,
	[MATINH] [nvarchar](50) NULL,
	[MATRUONG] [nvarchar](50) NULL,
	[MANGANH] [nvarchar](50) NULL,
	[MAKVUT] [nvarchar](50) NULL,
	[MADTUT] [nvarchar](50) NULL,
 CONSTRAINT [PK_THISINH] PRIMARY KEY CLUSTERED 
(
	[MAHS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TINH]    Script Date: 21/10/2021 8:51:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TINH](
	[MATINH] [nvarchar](50) NOT NULL,
	[TENTINH] [nvarchar](50) NULL,
 CONSTRAINT [PK_TINH] PRIMARY KEY CLUSTERED 
(
	[MATINH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRUONG]    Script Date: 21/10/2021 8:51:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRUONG](
	[MATRUONG] [nvarchar](50) NOT NULL,
	[TENTRUONG] [nvarchar](50) NULL,
 CONSTRAINT [PK_TRUONG] PRIMARY KEY CLUSTERED 
(
	[MATRUONG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[HUYEN] ([MAHUYEN], [TENHUYEN], [MATINH]) VALUES (N'AD', N'An Dương', N'HP')
INSERT [dbo].[HUYEN] ([MAHUYEN], [TENHUYEN], [MATINH]) VALUES (N'AL', N'An Lão', N'HP')
INSERT [dbo].[HUYEN] ([MAHUYEN], [TENHUYEN], [MATINH]) VALUES (N'KT', N'Kiến Thuỵ', N'HP')
INSERT [dbo].[HUYEN] ([MAHUYEN], [TENHUYEN], [MATINH]) VALUES (N'LC', N'Lê Chân', N'HP')
INSERT [dbo].[HUYEN] ([MAHUYEN], [TENHUYEN], [MATINH]) VALUES (N'TL', N'Tiên Lãng', N'HP')
INSERT [dbo].[HUYEN] ([MAHUYEN], [TENHUYEN], [MATINH]) VALUES (N'TN', N'Thuỷ Nguyên', N'HP')
GO
INSERT [dbo].[THISINH] ([MAHS], [HOTEN], [NGAYSINH], [GIOITINH], [SBD], [SDT], [MAHUYEN], [MATINH], [MATRUONG], [MANGANH], [MAKVUT], [MADTUT]) VALUES (N'TS0001', N'Đặng Văn Huy', CAST(N'2000-09-29' AS Date), 1, N'123456', N'0376737464', N'Thuỷ Nguyên', N'Hải Phòng', N'THP', N'CNTT', N'KV1', N'DT1')
INSERT [dbo].[THISINH] ([MAHS], [HOTEN], [NGAYSINH], [GIOITINH], [SBD], [SDT], [MAHUYEN], [MATINH], [MATRUONG], [MANGANH], [MAKVUT], [MADTUT]) VALUES (N'TS0002', N'Trần Văn Giang', CAST(N'2000-10-09' AS Date), 1, N'123457', N'0376737565', N'Thuỷ Nguyên', N'Hải Phòng', N'THP', N'CNTT', N'KV1', N'DT1')
GO
/****** Object:  StoredProcedure [dbo].[HUYEN_Delete]    Script Date: 21/10/2021 8:51:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HUYEN_Delete]
@mahuyen1 nvarchar(50)
AS
BEGIN
delete from HUYEN where MAHUYEN = @mahuyen1
END
GO
/****** Object:  StoredProcedure [dbo].[HUYEN_Insert]    Script Date: 21/10/2021 8:51:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HUYEN_Insert]
@mahuyen nvarchar(50),
@tenhuyen nvarchar(50),
@matinh nvarchar(50)
AS
BEGIN
	Insert into HUYEN(MAHUYEN,TENHUYEN,MATINH)
	Values (@mahuyen,@tenhuyen,@matinh)
END
GO
/****** Object:  StoredProcedure [dbo].[HUYEN_SelectAll]    Script Date: 21/10/2021 8:51:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HUYEN_SelectAll]
AS
BEGIN
Select * from HUYEN
END
GO
/****** Object:  StoredProcedure [dbo].[HUYEN_Update]    Script Date: 21/10/2021 8:51:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HUYEN_Update]
@mahuyen2 nvarchar(50),
@tenhuyen2 nvarchar(50),
@matinh2 nvarchar(50)
AS
BEGIN
	Update HUYEN
	set TENHUYEN = @tenhuyen2,MATINH = @matinh2
	where MAHUYEN = @mahuyen2
END
GO
/****** Object:  StoredProcedure [dbo].[THISINH_Delete]    Script Date: 21/10/2021 8:51:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[THISINH_Delete]
@mahs nvarchar(50)
AS
BEGIN
delete from THISINH where MAHS = @mahs
END
GO
/****** Object:  StoredProcedure [dbo].[THISINh_Insert]    Script Date: 21/10/2021 8:51:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[THISINh_Insert]
@mahs nvarchar(50),
@hoten nvarchar(50),
@ngaysinh date,
@gioitinh bit,
@sbd nvarchar(50),
@sdt nvarchar(50),
@mahuyen nvarchar(50),
@matinh nvarchar(50),
@matruong nvarchar(50),
@manganh nvarchar(50),
@makvut nvarchar(50),
@madtut nvarchar(50)
AS
BEGIN
	Insert into THISINH(MAHS,HOTEN,NGAYSINH,GIOITINH,SBD,SDT,MAHUYEN,MATINH,MATRUONG,MANGANH,MAKVUT,MADTUT)
	Values (@mahs,@hoten,@ngaysinh,@gioitinh,@sbd,@sdt,@mahuyen,@matinh,@matruong,@manganh,@makvut,@madtut)
END
GO
/****** Object:  StoredProcedure [dbo].[THISINH_SelectAll]    Script Date: 21/10/2021 8:51:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[THISINH_SelectAll]
AS
BEGIN
		Select * from THISINH
END
GO
/****** Object:  StoredProcedure [dbo].[THISINH_Update]    Script Date: 21/10/2021 8:51:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[THISINH_Update]
@mahss nvarchar(50),
@hotens nvarchar(50),
@ngaysinhs date,
@gioitinhs bit,
@sbds nvarchar(50),
@sdts nvarchar(50),
@mahuyens nvarchar(50),
@matinhs nvarchar(50),
@matruongs nvarchar(50),
@manganhs nvarchar(50),
@makvuts nvarchar(50),
@madtuts nvarchar(50)
AS
BEGIN
	Update THISINH
	set HOTEN = @hotens,NGAYSINH =@ngaysinhs,GIOITINH = @gioitinhs,SBD = @sbds,SDT = @sdts,MAHUYEN = @mahuyens,MATINH = @matinhs,MATRUONG = @matruongs,MANGANH = @manganhs,MAKVUT = @makvuts,MADTUT = @madtuts
	where MAHS = @mahss
END
GO
