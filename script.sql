USE [StockControl]
GO
/****** Object:  Table [dbo].[basket]    Script Date: 12.05.2021 15:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[basket](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[namesurname] [nvarchar](50) NOT NULL,
	[phone] [nvarchar](50) NOT NULL,
	[barcodenumber] [nvarchar](50) NOT NULL,
	[productname] [nvarchar](50) NOT NULL,
	[quantity] [int] NOT NULL,
	[saleprice] [decimal](18, 2) NOT NULL,
	[totalprice] [decimal](18, 2) NOT NULL,
	[date] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_basket] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[brandinformation]    Script Date: 12.05.2021 15:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[brandinformation](
	[category] [nvarchar](50) NOT NULL,
	[brand] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[categoryinformation]    Script Date: 12.05.2021 15:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categoryinformation](
	[category] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 12.05.2021 15:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[namesurname] [nvarchar](50) NULL,
	[phone] [nvarchar](50) NULL,
	[adress] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
 CONSTRAINT [PK_customer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product]    Script Date: 12.05.2021 15:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product](
	[barcodenumber] [nvarchar](50) NOT NULL,
	[category] [nvarchar](50) NOT NULL,
	[brand] [nvarchar](50) NOT NULL,
	[productname] [nvarchar](50) NOT NULL,
	[quantity] [int] NOT NULL,
	[purchaseprice] [decimal](18, 2) NOT NULL,
	[saleprice] [decimal](18, 2) NOT NULL,
	[date] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sale]    Script Date: 12.05.2021 15:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sale](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[namesurname] [nvarchar](50) NOT NULL,
	[phone] [nvarchar](50) NOT NULL,
	[barcodenumber] [nvarchar](50) NOT NULL,
	[productname] [nvarchar](50) NOT NULL,
	[quantity] [int] NOT NULL,
	[saleprice] [decimal](18, 2) NOT NULL,
	[totalprice] [decimal](18, 2) NOT NULL,
	[date] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_sale] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[brandinformation] ([category], [brand]) VALUES (N'Technology', N'Samsung')
INSERT [dbo].[brandinformation] ([category], [brand]) VALUES (N'Technology', N'Xiaomi')
INSERT [dbo].[brandinformation] ([category], [brand]) VALUES (N'Chair', N'Xdrive')
GO
INSERT [dbo].[categoryinformation] ([category]) VALUES (N'Technology')
INSERT [dbo].[categoryinformation] ([category]) VALUES (N'Chair')
GO
SET IDENTITY_INSERT [dbo].[customer] ON 

INSERT [dbo].[customer] ([Id], [namesurname], [phone], [adress], [email]) VALUES (1003, N'Can Kayacı', N'7259234', N'Istanbul', N'cankayaci')
INSERT [dbo].[customer] ([Id], [namesurname], [phone], [adress], [email]) VALUES (1004, N'Ecem Akova', N'975662', N'Ankara', N'ecemakova')
INSERT [dbo].[customer] ([Id], [namesurname], [phone], [adress], [email]) VALUES (1005, N'Sena Akyıldız', N'6723462', N'Samsun', N'senaakyildiz')
INSERT [dbo].[customer] ([Id], [namesurname], [phone], [adress], [email]) VALUES (1006, N'Cihan Akpınar', N'3514515', N'Mersin', N'cihanakpinar')
SET IDENTITY_INSERT [dbo].[customer] OFF
GO
INSERT [dbo].[product] ([barcodenumber], [category], [brand], [productname], [quantity], [purchaseprice], [saleprice], [date]) VALUES (N'190', N'Technology', N'Samsung', N'Television', 49, CAST(499.95 AS Decimal(18, 2)), CAST(799.95 AS Decimal(18, 2)), N'8.05.2021 18:14:29')
INSERT [dbo].[product] ([barcodenumber], [category], [brand], [productname], [quantity], [purchaseprice], [saleprice], [date]) VALUES (N'191', N'Technology', N'Samsung', N'Telephone', 100, CAST(295.00 AS Decimal(18, 2)), CAST(395.00 AS Decimal(18, 2)), N'8.05.2021 18:15:02')
INSERT [dbo].[product] ([barcodenumber], [category], [brand], [productname], [quantity], [purchaseprice], [saleprice], [date]) VALUES (N'192', N'Technology', N'Xiaomi', N'Robot Cleaner', 95, CAST(755.50 AS Decimal(18, 2)), CAST(800.00 AS Decimal(18, 2)), N'8.05.2021 18:21:06')
INSERT [dbo].[product] ([barcodenumber], [category], [brand], [productname], [quantity], [purchaseprice], [saleprice], [date]) VALUES (N'193', N'Technology', N'Xiaomi', N'Mi Wi-fi', 20, CAST(49.00 AS Decimal(18, 2)), CAST(59.00 AS Decimal(18, 2)), N'8.05.2021 18:27:04')
INSERT [dbo].[product] ([barcodenumber], [category], [brand], [productname], [quantity], [purchaseprice], [saleprice], [date]) VALUES (N'194', N'Technology', N'Xiaomi', N'Headphones', 171, CAST(45.00 AS Decimal(18, 2)), CAST(170.00 AS Decimal(18, 2)), N'8.05.2021 18:29:28')
INSERT [dbo].[product] ([barcodenumber], [category], [brand], [productname], [quantity], [purchaseprice], [saleprice], [date]) VALUES (N'195', N'Chair', N'Xdrive', N'Gamer chair', 240, CAST(75.50 AS Decimal(18, 2)), CAST(95.50 AS Decimal(18, 2)), N'12.05.2021 15:09:10')
GO
SET IDENTITY_INSERT [dbo].[sale] ON 

INSERT [dbo].[sale] ([Id], [namesurname], [phone], [barcodenumber], [productname], [quantity], [saleprice], [totalprice], [date]) VALUES (1, N'Can Kayacı', N'7259234', N'195', N'Gamer chair', 10, CAST(95.50 AS Decimal(18, 2)), CAST(955.00 AS Decimal(18, 2)), N'12.05.2021 15:34:14')
INSERT [dbo].[sale] ([Id], [namesurname], [phone], [barcodenumber], [productname], [quantity], [saleprice], [totalprice], [date]) VALUES (2, N'Can Kayacı', N'7259234', N'193', N'Mi Wi-fi', 5, CAST(59.00 AS Decimal(18, 2)), CAST(295.00 AS Decimal(18, 2)), N'12.05.2021 15:34:18')
SET IDENTITY_INSERT [dbo].[sale] OFF
GO
