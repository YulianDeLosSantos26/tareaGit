USE [Agenda_electrónica]
GO
/****** Object:  Table [dbo].[Agenda_Personas]    Script Date: 19/3/2023 11:13:39 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Agenda_Personas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
	[Apellido] [varchar](20) NOT NULL,
	[Fecha_Nacimiento] [varchar](50) NULL,
	[Dirección] [varchar](40) NULL,
	[Genero] [varchar](20) NOT NULL,
	[Estado_civil] [varchar](20) NULL,
	[Movil] [varchar](20) NULL,
	[Telefono] [varchar](20) NULL,
	[Correo_electronico] [varchar](40) NULL,
	[UserID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 19/3/2023 11:13:39 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Email] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Agenda_Personas] ON 

INSERT [dbo].[Agenda_Personas] ([Id], [Nombre], [Apellido], [Fecha_Nacimiento], [Dirección], [Genero], [Estado_civil], [Movil], [Telefono], [Correo_electronico], [UserID]) VALUES (1, N'Pedro', N'Mella', N'2000-12-04', N'Puerto Principe', N'Hombre', N'Soltero', N'829-555-8091', N'809-888-1254', N'PedroMella@gmail.com', 1)
INSERT [dbo].[Agenda_Personas] ([Id], [Nombre], [Apellido], [Fecha_Nacimiento], [Dirección], [Genero], [Estado_civil], [Movil], [Telefono], [Correo_electronico], [UserID]) VALUES (4, N'Marcos', N'De Los Santos', N'1998-05-25', N'Piantini', N'Masculino', N'Soltero', N'809-555-0870', N'829777-3021', N'MarcosDelosantos@gmail.com', 3)
SET IDENTITY_INSERT [dbo].[Agenda_Personas] OFF
GO
SET IDENTITY_INSERT [dbo].[Login] ON 

INSERT [dbo].[Login] ([UserID], [Username], [Password], [Nombre], [Apellido], [Email]) VALUES (1, N'jdoe', N'pass123', N'John', N'Doe', N'jdoe@example.com')
INSERT [dbo].[Login] ([UserID], [Username], [Password], [Nombre], [Apellido], [Email]) VALUES (2, N'jsmith', N'pass456', N'Jane', N'Smith', N'jsmith@example.com')
INSERT [dbo].[Login] ([UserID], [Username], [Password], [Nombre], [Apellido], [Email]) VALUES (3, N'rbrown', N'pass789', N'Robert', N'Brown', N'rbrown@example.com')
SET IDENTITY_INSERT [dbo].[Login] OFF
GO
