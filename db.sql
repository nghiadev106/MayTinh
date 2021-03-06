USE [Loc]
GO
/****** Object:  UserDefinedFunction [dbo].[fuConvertToUnsign1]    Script Date: 07/06/2022 23:26:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 07/06/2022 23:26:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 07/06/2022 23:26:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 07/06/2022 23:26:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 07/06/2022 23:26:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 07/06/2022 23:26:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 07/06/2022 23:26:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 07/06/2022 23:26:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 07/06/2022 23:26:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CategoriesNew]    Script Date: 07/06/2022 23:26:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoriesNew](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NULL,
	[Description] [nvarchar](500) NULL,
	[Url] [nvarchar](250) NULL,
	[DisplayOrder] [int] NULL,
	[CreateDate] [datetime] NULL,
	[ShowHome] [bit] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_CategoriesNew] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 07/06/2022 23:26:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NULL,
	[ParentId] [bigint] NULL,
	[Description] [nvarchar](500) NULL,
	[Url] [nvarchar](500) NULL,
	[DisplayOrder] [int] NULL,
	[CreateDate] [datetime] NULL,
	[ShowHome] [bit] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contact]    Script Date: 07/06/2022 23:26:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contact](
	[Id] [bigint] NOT NULL,
	[Name] [nvarchar](500) NULL,
	[Phone] [nvarchar](500) NULL,
	[Email] [nvarchar](500) NULL,
	[Content] [text] NULL,
	[Status] [int] NULL,
	[CreateDate] [datetime] NULL,
 CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[News]    Script Date: 07/06/2022 23:26:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[News](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NULL,
	[CategoryId] [bigint] NULL,
	[Logo] [nvarchar](500) NULL,
	[Description] [nvarchar](max) NULL,
	[Detail] [nvarchar](max) NULL,
	[IsNew] [bit] NULL,
	[CreateDate] [datetime] NULL,
	[EditDate] [datetime] NULL,
	[Url] [nvarchar](250) NULL,
	[DisplayOrder] [int] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_News] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 07/06/2022 23:26:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[OrderName] [nvarchar](500) NOT NULL,
	[OrderAddress] [nvarchar](500) NOT NULL,
	[OrderEmail] [nvarchar](500) NULL,
	[OrderPhone] [int] NOT NULL,
	[OrderNote] [nvarchar](500) NULL,
	[TotalMoney] [decimal](18, 0) NULL,
	[PaymentStatus] [int] NULL,
	[CreatedDate] [datetime] NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 07/06/2022 23:26:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[OrderId] [bigint] NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[Price] [decimal](18, 0) NULL,
	[Quantity] [int] NULL,
	[CreatedDate] [datetime] NULL,
 CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductImages]    Script Date: 07/06/2022 23:26:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductImages](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductId] [bigint] NULL,
	[Path] [nvarchar](500) NULL,
 CONSTRAINT [PK_ProductImages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 07/06/2022 23:26:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NULL,
	[CategoryId] [bigint] NULL,
	[Logo] [nvarchar](500) NULL,
	[Description] [nvarchar](max) NULL,
	[Detail] [nvarchar](max) NULL,
	[Price] [decimal](18, 0) NULL,
	[PriceDiscount] [decimal](18, 0) NULL,
	[IsNew] [bit] NULL,
	[CreateDate] [datetime] NULL,
	[EditDate] [datetime] NULL,
	[Url] [nvarchar](250) NULL,
	[DisplayOrder] [int] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Promotion]    Script Date: 07/06/2022 23:26:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Promotion](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Logo] [nvarchar](250) NULL,
	[Link] [nvarchar](250) NULL,
	[Status] [int] NULL,
	[DisplayOrder] [int] NULL,
	[CreateDate] [datetime] NULL,
 CONSTRAINT [PK_Promotion] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Setting]    Script Date: 07/06/2022 23:26:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Setting](
	[Logo] [nchar](10) NULL,
	[Hotline1] [nchar](10) NULL,
	[Hotline2] [nchar](10) NULL,
	[Info] [nchar](10) NULL,
	[Address] [nchar](10) NULL,
	[Facebook] [nchar](10) NULL,
	[Zalo] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Slides]    Script Date: 07/06/2022 23:26:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Slides](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Logo] [nvarchar](250) NULL,
	[Link] [nvarchar](250) NULL,
	[Status] [int] NULL,
	[DisplayOrder] [int] NULL,
	[CreateDate] [datetime] NULL,
 CONSTRAINT [PK_Slides] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TopMenu]    Script Date: 07/06/2022 23:26:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TopMenu](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Logo] [nvarchar](250) NULL,
	[Link] [nvarchar](250) NULL,
	[Status] [int] NULL,
	[DisplayOrder] [int] NULL,
	[CreateDate] [datetime] NULL,
 CONSTRAINT [PK_TopMenu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'450db95e-f81e-45be-94ff-c0f85971bff8', N'nghiadv1006@gmail.com', N'NGHIADV1006@GMAIL.COM', N'nghiadv1006@gmail.com', N'NGHIADV1006@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEO7pp2dNIbwsGORDl8dknLkjh2tOLa18uV5cKf2hcMdj0JIfX5RS9F5MmdronhOn8g==', N'YG3JYPI34SZW5OAWXYC5HNUAGSABE4JW', N'a0d2f40d-332b-4fde-b242-b36756863b0e', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'630a4bea-2ceb-46ab-b26d-0854287bf13c', N'admin', N'ADMIN', N'admin@gmail.com', N'admin@gmail.com', 1, N'AQAAAAEAACcQAAAAEDVVxU5cqemmkrHx2w7DXR3pSfWcVsm9I0MO+ykCl7NAcXhhfP7Hl5wgaTkSJP85uA==', N'UQUDWAPTGCCH6GAA3ZT6CXR4RKDQA6BX', N'74342c66-d5f1-4ad7-b80c-1df22c2d1c9f', NULL, 0, 0, NULL, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[CategoriesNew] ON 

INSERT [dbo].[CategoriesNew] ([Id], [Name], [Description], [Url], [DisplayOrder], [CreateDate], [ShowHome], [Status]) VALUES (1, N'Đồng hồ nam', N'ko', N'dong-ho-nam', 1, CAST(N'2022-04-14T00:44:12.873' AS DateTime), 1, 1)
SET IDENTITY_INSERT [dbo].[CategoriesNew] OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [Name], [ParentId], [Description], [Url], [DisplayOrder], [CreateDate], [ShowHome], [Status]) VALUES (1, N'Đồng hồ nam', 3, N'Đồng hồ nam', N'dong-ho-nam', 2, CAST(N'2022-04-13T21:40:05.777' AS DateTime), 1, 1)
INSERT [dbo].[Category] ([Id], [Name], [ParentId], [Description], [Url], [DisplayOrder], [CreateDate], [ShowHome], [Status]) VALUES (2, N'Đồng hồ nữ', 3, N'Đồng hồ nữ', N'dong-ho-nu', 3, CAST(N'2022-04-13T21:40:25.897' AS DateTime), 1, 1)
INSERT [dbo].[Category] ([Id], [Name], [ParentId], [Description], [Url], [DisplayOrder], [CreateDate], [ShowHome], [Status]) VALUES (3, N'Đồng hồ', NULL, N'Đồng hồ', N'dong-ho', 1, CAST(N'2022-04-20T00:41:18.847' AS DateTime), 1, 1)
INSERT [dbo].[Category] ([Id], [Name], [ParentId], [Description], [Url], [DisplayOrder], [CreateDate], [ShowHome], [Status]) VALUES (4, N'Kính mắt', NULL, N'Kính mắt', N'kinh-mat', 4, CAST(N'2022-04-20T00:42:12.893' AS DateTime), 1, 1)
INSERT [dbo].[Category] ([Id], [Name], [ParentId], [Description], [Url], [DisplayOrder], [CreateDate], [ShowHome], [Status]) VALUES (5, N'Trang sức', NULL, N'Trang sức', N'trang-suc', 5, CAST(N'2022-04-20T00:42:32.017' AS DateTime), 1, 1)
INSERT [dbo].[Category] ([Id], [Name], [ParentId], [Description], [Url], [DisplayOrder], [CreateDate], [ShowHome], [Status]) VALUES (6, N'Phụ kiện', NULL, N'phụ kiện', N'phu-kien', 6, CAST(N'2022-04-20T20:14:53.240' AS DateTime), 1, 1)
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[News] ON 

INSERT [dbo].[News] ([Id], [Name], [CategoryId], [Logo], [Description], [Detail], [IsNew], [CreateDate], [EditDate], [Url], [DisplayOrder], [Status]) VALUES (1, N'Mạnh Mẽ & Cuốn Hút với đồng hồ mặt rắn L’Duchen Silver Snake', 1, N'/uploads/94f75917-07d0-4427-b3fa-970204cd2489.jpg', N'Thương hiệu đồng hồ Thụy Sỹ L’Duchen đã mở rộng bộ sưu tập Art Collection của mình với mẫu đồng hồ mặt rắn – L’Duchen Silver snake mã hiệu D 161.11.23 dây da cao cấp phiên bản giới hạn.', N'<p><span style="font-weight: bolder; color: rgb(0, 0, 0); font-family: Quicksand, sans-serif; font-size: 16px;"><em>Thương hiệu đồng hồ Thụy Sỹ L’Duchen đã mở rộng bộ sưu tập Art Collection của mình với mẫu đồng hồ mặt rắn – L’Duchen Silver snake mã hiệu D 161.11.23 dây da cao cấp phiên bản giới hạn.</em></span><br></p>', 1, CAST(N'2022-04-14T00:46:03.617' AS DateTime), NULL, N'manh-me-cuon-hut-voi-dong-ho-mat-ran-l’duchen-silver-snake', 1, 1)
SET IDENTITY_INSERT [dbo].[News] OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([Id], [OrderName], [OrderAddress], [OrderEmail], [OrderPhone], [OrderNote], [TotalMoney], [PaymentStatus], [CreatedDate]) VALUES (5, N'Đỗ Văn Nghĩa', N'11111', N'nghia123@gmail.com', 12211111, N'koooo', CAST(1589999 AS Decimal(18, 0)), 0, CAST(N'2023-04-20T23:40:27.497' AS DateTime))
INSERT [dbo].[Order] ([Id], [OrderName], [OrderAddress], [OrderEmail], [OrderPhone], [OrderNote], [TotalMoney], [PaymentStatus], [CreatedDate]) VALUES (6, N'jrjjr', N'fjfjjfjfjf', N'test23@gmail.com', 39393, N'koo', CAST(2799996 AS Decimal(18, 0)), 0, CAST(N'2022-06-07T22:25:27.343' AS DateTime))
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderDetail] ON 

INSERT [dbo].[OrderDetail] ([Id], [OrderId], [ProductId], [Price], [Quantity], [CreatedDate]) VALUES (5, 5, 2, CAST(699999 AS Decimal(18, 0)), 1, CAST(N'2022-04-20T23:40:27.493' AS DateTime))
INSERT [dbo].[OrderDetail] ([Id], [OrderId], [ProductId], [Price], [Quantity], [CreatedDate]) VALUES (6, 5, 4, CAST(890000 AS Decimal(18, 0)), 1, CAST(N'2022-04-20T23:40:27.493' AS DateTime))
INSERT [dbo].[OrderDetail] ([Id], [OrderId], [ProductId], [Price], [Quantity], [CreatedDate]) VALUES (7, 6, 2, CAST(699999 AS Decimal(18, 0)), 3, CAST(N'2022-06-07T22:25:27.337' AS DateTime))
INSERT [dbo].[OrderDetail] ([Id], [OrderId], [ProductId], [Price], [Quantity], [CreatedDate]) VALUES (8, 6, 3, CAST(699999 AS Decimal(18, 0)), 1, CAST(N'2022-06-07T22:25:27.340' AS DateTime))
SET IDENTITY_INSERT [dbo].[OrderDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductImages] ON 

INSERT [dbo].[ProductImages] ([Id], [ProductId], [Path]) VALUES (6, 2, N'/uploads/8be64e8b-5cf0-4e72-85ed-332c6a0d429b.jpg')
INSERT [dbo].[ProductImages] ([Id], [ProductId], [Path]) VALUES (7, 2, N'/uploads/328cca99-a82e-4eaa-bf15-0010a48ec6fa.jpg')
INSERT [dbo].[ProductImages] ([Id], [ProductId], [Path]) VALUES (8, 2, N'/uploads/601e947b-6253-4199-bae9-d9b159ad225b.jpg')
INSERT [dbo].[ProductImages] ([Id], [ProductId], [Path]) VALUES (9, 3, N'/uploads/6434ef88-c4ea-4a3c-a6c0-232d86176f2e.jpg')
INSERT [dbo].[ProductImages] ([Id], [ProductId], [Path]) VALUES (10, 3, N'/uploads/7d6c6170-9143-46a5-abd0-e393dbdeca9f.jpg')
INSERT [dbo].[ProductImages] ([Id], [ProductId], [Path]) VALUES (11, 3, N'/uploads/a1f8fa7f-945b-49a4-9098-6466b83c8f6e.jpg')
INSERT [dbo].[ProductImages] ([Id], [ProductId], [Path]) VALUES (12, 3, N'/uploads/7ac44c9f-2b76-40ab-818a-e829af4adf82.jpg')
INSERT [dbo].[ProductImages] ([Id], [ProductId], [Path]) VALUES (13, 4, N'/uploads/80c443ec-5184-4046-acd8-5f3dfe5c4c90.jpg')
INSERT [dbo].[ProductImages] ([Id], [ProductId], [Path]) VALUES (14, 4, N'/uploads/82c185d3-2f9e-4690-a80a-33f28ec80ded.jpg')
INSERT [dbo].[ProductImages] ([Id], [ProductId], [Path]) VALUES (15, 4, N'/uploads/b1c83154-9ab9-46d8-8cae-39942c30fd07.jpg')
INSERT [dbo].[ProductImages] ([Id], [ProductId], [Path]) VALUES (16, 4, N'/uploads/b1616e86-1e11-4efe-b26b-335c5d85bf5b.jpg')
INSERT [dbo].[ProductImages] ([Id], [ProductId], [Path]) VALUES (17, 3, N'/uploads/47f41c97-399a-4a4c-990e-e1501261200d.jpg')
INSERT [dbo].[ProductImages] ([Id], [ProductId], [Path]) VALUES (18, 3, N'/uploads/321e3a4b-0c8d-41ed-b0de-4991a63aeef1.jpg')
INSERT [dbo].[ProductImages] ([Id], [ProductId], [Path]) VALUES (19, 2, N'/uploads/66d8a8b8-a7d2-4949-9018-5c57c5fc8a78.jpg')
INSERT [dbo].[ProductImages] ([Id], [ProductId], [Path]) VALUES (20, 2, N'/uploads/ed460e16-326a-4b36-86ae-92f056f0b6eb.jpg')
INSERT [dbo].[ProductImages] ([Id], [ProductId], [Path]) VALUES (21, 1, N'/uploads/699ab5a2-0fae-4208-9c8f-3d0a30292d7d.jpg')
INSERT [dbo].[ProductImages] ([Id], [ProductId], [Path]) VALUES (22, 1, N'/uploads/0e7bffed-cd44-4b48-b6b2-71bdfee5de00.jpg')
SET IDENTITY_INSERT [dbo].[ProductImages] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [Name], [CategoryId], [Logo], [Description], [Detail], [Price], [PriceDiscount], [IsNew], [CreateDate], [EditDate], [Url], [DisplayOrder], [Status]) VALUES (1, N'Đồng hồ Calvin Klein Nữ K4E2', 2, N'/uploads/5b1b831e-ed07-4f49-a3d1-e4e7275aef7e.jpg', N'Đồng hồ Calvin Klein Nữ K4E2', N'<p><a href="https://localhost:44302/dong-ho-calvin-klein-nu-k4e2/index.html" style="background-color: rgb(255, 255, 255); touch-action: manipulation; color: rgb(0, 0, 0); display: inline-block; line-height: 1.3; margin-top: 0.1em; margin-bottom: 0.1em; font-family: Quicksand, sans-serif; font-size: 14.4px; text-align: center;">Đồng hồ Calvin Klein Nữ K4E2</a><br></p>', CAST(900000 AS Decimal(18, 0)), CAST(799999 AS Decimal(18, 0)), 1, CAST(N'2022-04-13T21:43:38.120' AS DateTime), NULL, N'dong-ho-calvin-klein-nu-k4e2', 1, 1)
INSERT [dbo].[Products] ([Id], [Name], [CategoryId], [Logo], [Description], [Detail], [Price], [PriceDiscount], [IsNew], [CreateDate], [EditDate], [Url], [DisplayOrder], [Status]) VALUES (2, N'Đồng hồ Calvin Klein Nữ N4E2', 2, N'/uploads/cb017a3f-3dd0-4a6c-beb7-f38408b67b61.jpg', N'Đồng hồ Calvin Klein Nữ K4E2', N'<p>Đồng hồ Calvin Klein Nữ K4E2<br></p>', CAST(899999 AS Decimal(18, 0)), CAST(699999 AS Decimal(18, 0)), 1, CAST(N'2022-04-13T23:06:59.683' AS DateTime), CAST(N'2022-04-13T23:48:44.053' AS DateTime), N'dong-ho-calvin-klein-nu-n4e2', 2, 1)
INSERT [dbo].[Products] ([Id], [Name], [CategoryId], [Logo], [Description], [Detail], [Price], [PriceDiscount], [IsNew], [CreateDate], [EditDate], [Url], [DisplayOrder], [Status]) VALUES (3, N'Đồng hồ Calvin Klein Nam K4E2', 1, N'/uploads/a818897c-b886-4eec-b083-4441db3e25e0.jpg', N'Đồng hồ Calvin Klein Nữ K4E2', N'<p>Đồng hồ Calvin Klein Nữ K4E2<br></p>', CAST(799999 AS Decimal(18, 0)), CAST(699999 AS Decimal(18, 0)), 1, CAST(N'2022-04-14T00:11:45.007' AS DateTime), CAST(N'2022-04-14T00:17:13.403' AS DateTime), N'dong-ho-calvin-klein-nam-k4e2', 3, 1)
INSERT [dbo].[Products] ([Id], [Name], [CategoryId], [Logo], [Description], [Detail], [Price], [PriceDiscount], [IsNew], [CreateDate], [EditDate], [Url], [DisplayOrder], [Status]) VALUES (4, N'Đồng hồ Calvin Klein Nữ ', 2, N'/uploads/59f298d7-7d27-4875-9c19-1e2c7e4630c8.jpg', N'Đồng hồ Calvin Klein Nữ ', N'<p>Đồng hồ Calvin Klein Nữ&nbsp;<br></p>', CAST(890000 AS Decimal(18, 0)), NULL, 1, CAST(N'2022-04-20T00:46:18.333' AS DateTime), NULL, N'dong-ho-calvin-klein-nu', 11, 1)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Promotion] ON 

INSERT [dbo].[Promotion] ([Id], [Name], [Logo], [Link], [Status], [DisplayOrder], [CreateDate]) VALUES (1, N'Danh mục 1', N'/uploads/f2a383b7-19e5-4432-a920-b9ba57ffd091.png', N'kkkkk', 1, 1, CAST(N'2022-03-18T11:08:14.393' AS DateTime))
SET IDENTITY_INSERT [dbo].[Promotion] OFF
GO
SET IDENTITY_INSERT [dbo].[Slides] ON 

INSERT [dbo].[Slides] ([Id], [Name], [Logo], [Link], [Status], [DisplayOrder], [CreateDate]) VALUES (1, N'slide 1', N'/uploads/c73e6252-cb3f-4f7a-b407-4b0af58f3b18.jpg', N'kkkkk', 1, 1, CAST(N'2021-09-07T16:31:05.600' AS DateTime))
INSERT [dbo].[Slides] ([Id], [Name], [Logo], [Link], [Status], [DisplayOrder], [CreateDate]) VALUES (2, N'slide 2', N'/uploads/08e6575b-84c5-4f9f-a448-5222ebbd1a5c.jpg', N'kkkkk', 1, 2, CAST(N'2021-09-07T16:33:44.903' AS DateTime))
SET IDENTITY_INSERT [dbo].[Slides] OFF
GO
SET IDENTITY_INSERT [dbo].[TopMenu] ON 

INSERT [dbo].[TopMenu] ([Id], [Name], [Logo], [Link], [Status], [DisplayOrder], [CreateDate]) VALUES (1, N'dddđ', N'/uploads/2d179ecf-981b-45d3-ad25-53431fa4b81e.png', N'ddđ', 1, 1, CAST(N'2021-09-07T20:22:35.440' AS DateTime))
INSERT [dbo].[TopMenu] ([Id], [Name], [Logo], [Link], [Status], [DisplayOrder], [CreateDate]) VALUES (2, N'ss', N'/uploads/09ab4e00-3e4f-4d50-a203-b55c0e55ce19.png', N'1111', 1, 111, CAST(N'2021-09-07T20:30:49.150' AS DateTime))
SET IDENTITY_INSERT [dbo].[TopMenu] OFF
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[News]  WITH CHECK ADD  CONSTRAINT [FK_News_CategoriesNew] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[CategoriesNew] ([Id])
GO
ALTER TABLE [dbo].[News] CHECK CONSTRAINT [FK_News_CategoriesNew]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Order] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([Id])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Order]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Products] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Products]
GO
ALTER TABLE [dbo].[ProductImages]  WITH CHECK ADD  CONSTRAINT [FK_ProductImages_Products] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[ProductImages] CHECK CONSTRAINT [FK_ProductImages_Products]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Category]
GO
