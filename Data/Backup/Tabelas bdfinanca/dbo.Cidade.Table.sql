USE [bdsiscontrol]
GO
/****** Object:  Table [dbo].[Cidade]    Script Date: 13/01/2025 06:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cidade](
	[CidadeID] [int] NOT NULL,
	[NomeCidade] [nvarchar](100) NULL,
	[EstadoID] [int] NULL,
	[ibge] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CidadeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cidade]  WITH CHECK ADD FOREIGN KEY([EstadoID])
REFERENCES [dbo].[Estado] ([EstadoID])
GO
