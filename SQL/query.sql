USE [DesignPatterns]
GO
/****** Object:  Table [dbo].[Beer]    Script Date: 2/11/2021 12:05:03 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Beer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Style] [nvarchar](50) NULL,
 CONSTRAINT [PK_Beer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Brand]    Script Date: 2/11/2021 12:05:03 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brand](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Brand] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Beer] ON 

INSERT [dbo].[Beer] ([Id], [Name], [Style]) VALUES (1, N'Corona', N'Pilsen')
INSERT [dbo].[Beer] ([Id], [Name], [Style]) VALUES (2, N'Eirninger', N'Refajo')
INSERT [dbo].[Beer] ([Id], [Name], [Style]) VALUES (4, N'Club Colombia', N'Malta')
INSERT [dbo].[Beer] ([Id], [Name], [Style]) VALUES (6, N'pele', N'Fuitbol')
INSERT [dbo].[Beer] ([Id], [Name], [Style]) VALUES (7, N'Pilsen', N'Morrocoya')
SET IDENTITY_INSERT [dbo].[Beer] OFF
GO
SET IDENTITY_INSERT [dbo].[Brand] ON 

INSERT [dbo].[Brand] ([Id], [Name]) VALUES (1, N' Skoda')
INSERT [dbo].[Brand] ([Id], [Name]) VALUES (2, N' Tu puta madre')
INSERT [dbo].[Brand] ([Id], [Name]) VALUES (3, N'Mercachochas')
SET IDENTITY_INSERT [dbo].[Brand] OFF
GO
