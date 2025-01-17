USE [bdsiscontrol]
GO
/****** Object:  Table [dbo].[ContasAPagar]    Script Date: 13/01/2025 06:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContasAPagar](
	[ContaPagarID] [int] NOT NULL,
	[FornecedorID] [int] NULL,
	[DataVencimento] [date] NULL,
	[ValorTotal] [decimal](10, 2) NULL,
	[Pago] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ContaPagarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ContasAPagar]  WITH CHECK ADD FOREIGN KEY([FornecedorID])
REFERENCES [dbo].[Fornecedor] ([FornecedorID])
GO
