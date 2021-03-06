USE [DesignPatterns]
GO
/****** Object:  Table [dbo].[Beer]    Script Date: 5/11/2021 12:09:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Beer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Style] [nvarchar](50) NULL,
	[BrandId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Beer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Brand]    Script Date: 5/11/2021 12:09:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brand](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Brand] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Beer] ON 

INSERT [dbo].[Beer] ([Id], [Name], [Style], [BrandId]) VALUES (1, N'Poker', N'Cebada', N'10828eda-7bdf-4532-a9e4-2e75326a915e')
INSERT [dbo].[Beer] ([Id], [Name], [Style], [BrandId]) VALUES (2, N'Club Colombia', N'Trigo', N'10828eda-7bdf-4532-a9e4-2e75326a915e')
SET IDENTITY_INSERT [dbo].[Beer] OFF
GO
INSERT [dbo].[Brand] ([Id], [Name]) VALUES (N'10828eda-7bdf-4532-a9e4-2e75326a915e', N'Malta')
GO
ALTER TABLE [dbo].[Brand] ADD  CONSTRAINT [DF_Brand_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[Beer]  WITH CHECK ADD  CONSTRAINT [FK_Beer_Brand] FOREIGN KEY([BrandId])
REFERENCES [dbo].[Brand] ([Id])
GO
ALTER TABLE [dbo].[Beer] CHECK CONSTRAINT [FK_Beer_Brand]
GO
