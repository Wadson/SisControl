USE [master]
GO


/****** Object:  Table [dbo].[Cliente]    Script Date: 15/01/2025 18:33:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[ClienteID] [int] NOT NULL,
	[NomeCliente] [nvarchar](100) NOT NULL,
	[Cpf] [varchar](14) NULL,
	[Email] [nvarchar](100) NULL,
	[Endereco] [varchar](150) NULL,
	[Telefone] [varchar](20) NULL,
	[CidadeID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ClienteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO



/****** Object:  Table [dbo].[Produto]    Script Date: 15/01/2025 18:33:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produto](
	[ProdutoID] [int] NOT NULL,
	[NomeProduto] [nvarchar](100) NULL,
	[PrecoCusto] [decimal](18, 2) NULL,
	[Estoque] [int] NULL,
	[PrecoVenda] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[ProdutoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO






/****** Object:  Table [dbo].[Venda]    Script Date: 15/01/2025 18:33:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venda](
	[ClienteID] [int] NOT NULL,
	[DataVenda] [datetime] NOT NULL,
	[ValorTotal] [decimal](10, 2) NOT NULL,
	[VendaID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Venda] PRIMARY KEY CLUSTERED 
(
	[VendaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO




/****** Object:  Table [dbo].[ItemVenda]    Script Date: 15/01/2025 18:33:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemVenda](
	[VendaID] [uniqueidentifier] NULL,
	[ProdutoID] [uniqueidentifier] NULL,
	[Quantidade] [int] NOT NULL,
	[PrecoUnitario] [decimal](10, 2) NOT NULL,
	[Subtotal]  AS ([Quantidade]*[PrecoUnitario]),
	[ItemVendaID] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_ItemVenda] PRIMARY KEY CLUSTERED 
(
	[ItemVendaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Parcela]    Script Date: 15/01/2025 18:33:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parcela](
	[VendaID] [uniqueidentifier] NOT NULL,
	[NumeroParcela] [int] NOT NULL,
	[DataVencimento] [datetime] NOT NULL,
	[ValorParcela] [decimal](18, 2) NOT NULL,
	[ValorRecebido] [decimal](18, 2) NOT NULL,
	[SaldoRestante] [decimal](18, 2) NOT NULL,
	[Pago] [bit] NOT NULL,
	[ParcelaID] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Parcela] PRIMARY KEY CLUSTERED 
(
	[ParcelaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


/****** Object:  Table [dbo].[ContaReceber]    Script Date: 15/01/2025 18:33:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContaReceber](
	[VendaID] [uniqueidentifier] NOT NULL,
	[ParcelaID] [uniqueidentifier] NOT NULL,
	[DataRecebimento] [datetime] NULL,
	[ValorRecebido] [decimal](18, 2) NOT NULL,
	[SaldoRestante] [decimal](18, 2) NOT NULL,
	[Pago] [bit] NOT NULL,
	[ContaReceberID] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_ContaReceber] PRIMARY KEY CLUSTERED 
(
	[ContaReceberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO