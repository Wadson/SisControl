USE [bdsiscontrol]
GO
/****** Object:  Table [dbo].[Recebimentos]    Script Date: 13/01/2025 06:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recebimentos](
	[RecebimentoID] [int] NOT NULL,
	[VendaID] [int] NULL,
	[DataRecebimento] [date] NULL,
	[ValorRecebido] [decimal](18, 2) NULL,
	[MetodoRecebimento] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[RecebimentoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Recebimentos]  WITH CHECK ADD FOREIGN KEY([VendaID])
REFERENCES [dbo].[Venda] ([VendaID])
GO
