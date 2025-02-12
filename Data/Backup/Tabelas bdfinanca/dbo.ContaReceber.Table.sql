USE [bdsiscontrol]
GO
/****** Object:  Table [dbo].[ContaReceber]    Script Date: 13/01/2025 06:04:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContaReceber](
	[ContaReceberID] [int] NOT NULL,
	[VendaID] [int] NOT NULL,
	[ParcelaID] [int] NOT NULL,
	[DataRecebimento] [datetime] NULL,
	[ValorRecebido] [decimal](18, 2) NOT NULL,
	[SaldoRestante] [decimal](18, 2) NOT NULL,
	[Pago] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ContaReceberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ContaReceber] ADD  DEFAULT ((0)) FOR [ValorRecebido]
GO
ALTER TABLE [dbo].[ContaReceber] ADD  DEFAULT ((0)) FOR [Pago]
GO
ALTER TABLE [dbo].[ContaReceber]  WITH CHECK ADD FOREIGN KEY([ParcelaID])
REFERENCES [dbo].[Parcela] ([ParcelaID])
GO
ALTER TABLE [dbo].[ContaReceber]  WITH CHECK ADD FOREIGN KEY([VendaID])
REFERENCES [dbo].[Venda] ([VendaID])
GO
