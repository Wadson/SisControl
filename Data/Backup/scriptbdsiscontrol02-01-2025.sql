USE [bdsiscontrol]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 02/02/2025 14:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[CategoriaID] [int] NOT NULL,
	[NomeCategoria] [nvarchar](100) NULL,
 CONSTRAINT [PK__Categori] PRIMARY KEY CLUSTERED 
(
	[CategoriaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cidade]    Script Date: 02/02/2025 14:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cidade](
	[CidadeID] [int] NOT NULL,
	[NomeCidade] [varchar](120) NULL,
	[EstadoID] [int] NULL,
	[ibge] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CidadeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 02/02/2025 14:41:25 ******/
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
 CONSTRAINT [PK__Cliente] PRIMARY KEY CLUSTERED 
(
	[ClienteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContaReceber]    Script Date: 02/02/2025 14:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContaReceber](
	[DataRecebimento] [datetime] NULL,
	[ValorRecebido] [decimal](18, 2) NOT NULL,
	[SaldoRestante] [decimal](18, 2) NOT NULL,
	[Pago] [bit] NOT NULL,
	[ParcelaID] [int] NOT NULL,
	[VendaID] [int] NOT NULL,
	[ContaReceberID] [int] NOT NULL,
 CONSTRAINT [PK__ContaRec] PRIMARY KEY CLUSTERED 
(
	[ContaReceberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado]    Script Date: 02/02/2025 14:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado](
	[EstadoID] [int] NOT NULL,
	[NomeEstado] [varchar](75) NULL,
	[Uf] [varchar](2) NULL,
	[ibge] [int] NULL,
	[Pais] [int] NULL,
	[ddd] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[EstadoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FormaPgto]    Script Date: 02/02/2025 14:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FormaPgto](
	[FormaPgtoID] [int] NOT NULL,
	[NomeFormaPgto] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[FormaPgtoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fornecedor]    Script Date: 02/02/2025 14:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fornecedor](
	[FornecedorID] [int] NOT NULL,
	[NomeFornecedor] [nvarchar](100) NOT NULL,
	[Cnpj] [nvarchar](20) NULL,
	[Endereco] [nvarchar](255) NULL,
	[Telefone] [nvarchar](15) NULL,
	[Email] [nvarchar](100) NULL,
	[CidadeID] [int] NOT NULL,
 CONSTRAINT [PK__Forneced] PRIMARY KEY CLUSTERED 
(
	[FornecedorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemVenda]    Script Date: 02/02/2025 14:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemVenda](
	[ProdutoID] [int] NOT NULL,
	[Quantidade] [int] NOT NULL,
	[PrecoUnitario] [decimal](10, 2) NOT NULL,
	[Subtotal]  AS ([Quantidade]*[PrecoUnitario]),
	[ItemVendaID] [int] NOT NULL,
	[VendaID] [int] NULL,
 CONSTRAINT [PK__ItemVend] PRIMARY KEY CLUSTERED 
(
	[ItemVendaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PagamentosParciais]    Script Date: 02/02/2025 14:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PagamentosParciais](
	[PagamentoParcialID] [int] IDENTITY(1,1) NOT NULL,
	[ParcelaID] [int] NULL,
	[ValorPago] [decimal](18, 2) NULL,
	[DataPagamento] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[PagamentoParcialID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Parcela]    Script Date: 02/02/2025 14:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parcela](
	[NumeroParcela] [int] NOT NULL,
	[DataVencimento] [datetime] NOT NULL,
	[ValorParcela] [decimal](18, 2) NOT NULL,
	[ValorRecebido] [decimal](18, 2) NOT NULL,
	[SaldoRestante] [decimal](18, 2) NOT NULL,
	[Pago] [bit] NOT NULL,
	[ParcelaID] [int] NOT NULL,
	[VendaID] [int] NULL,
 CONSTRAINT [PK__Parcela] PRIMARY KEY CLUSTERED 
(
	[ParcelaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produtos]    Script Date: 02/02/2025 14:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produtos](
	[ProdutoID] [int] NOT NULL,
	[NomeProduto] [varchar](100) NOT NULL,
	[PrecoCusto] [decimal](10, 2) NOT NULL,
	[Lucro] [decimal](10, 2) NOT NULL,
	[PrecoDeVenda] [decimal](10, 2) NOT NULL,
	[QuantidadeEmEstoque] [int] NOT NULL,
	[DataDeEntrada] [datetime] NOT NULL,
	[Status] [varchar](50) NULL,
	[Referencia] [nvarchar](15) NULL,
 CONSTRAINT [PK__Produtos] PRIMARY KEY CLUSTERED 
(
	[ProdutoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 02/02/2025 14:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[UsuarioID] [int] NOT NULL,
	[NomeUsuario] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Senha] [nvarchar](100) NOT NULL,
	[TipoUsuario] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK__Usuario] PRIMARY KEY CLUSTERED 
(
	[UsuarioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venda]    Script Date: 02/02/2025 14:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venda](
	[ClienteID] [int] NOT NULL,
	[DataVenda] [datetime] NOT NULL,
	[ValorTotal] [decimal](10, 2) NOT NULL,
	[VendaID] [int] NOT NULL,
	[FormaPgto] [nvarchar](15) NULL,
 CONSTRAINT [PK__Venda] PRIMARY KEY CLUSTERED 
(
	[VendaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cidade] ADD  DEFAULT (NULL) FOR [NomeCidade]
GO
ALTER TABLE [dbo].[Cidade] ADD  DEFAULT (NULL) FOR [EstadoID]
GO
ALTER TABLE [dbo].[Cidade] ADD  DEFAULT (NULL) FOR [ibge]
GO
ALTER TABLE [dbo].[ContaReceber] ADD  DEFAULT ((0)) FOR [ValorRecebido]
GO
ALTER TABLE [dbo].[Estado] ADD  DEFAULT (NULL) FOR [NomeEstado]
GO
ALTER TABLE [dbo].[Estado] ADD  DEFAULT (NULL) FOR [Uf]
GO
ALTER TABLE [dbo].[Estado] ADD  DEFAULT (NULL) FOR [ibge]
GO
ALTER TABLE [dbo].[Estado] ADD  DEFAULT (NULL) FOR [Pais]
GO
ALTER TABLE [dbo].[Estado] ADD  DEFAULT (NULL) FOR [ddd]
GO
ALTER TABLE [dbo].[Cidade]  WITH CHECK ADD  CONSTRAINT [FK_Cidade_Estado] FOREIGN KEY([EstadoID])
REFERENCES [dbo].[Estado] ([EstadoID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cidade] CHECK CONSTRAINT [FK_Cidade_Estado]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Cidade] FOREIGN KEY([CidadeID])
REFERENCES [dbo].[Cidade] ([CidadeID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_Cliente_Cidade]
GO
ALTER TABLE [dbo].[ContaReceber]  WITH CHECK ADD  CONSTRAINT [FK__ContaRece__Parce] FOREIGN KEY([ParcelaID])
REFERENCES [dbo].[Parcela] ([ParcelaID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ContaReceber] CHECK CONSTRAINT [FK__ContaRece__Parce]
GO
ALTER TABLE [dbo].[ContaReceber]  WITH CHECK ADD  CONSTRAINT [FK__ContaRece__Venda] FOREIGN KEY([VendaID])
REFERENCES [dbo].[Venda] ([VendaID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ContaReceber] CHECK CONSTRAINT [FK__ContaRece__Venda]
GO
ALTER TABLE [dbo].[Fornecedor]  WITH CHECK ADD  CONSTRAINT [FK_Fornecedor_Cidade] FOREIGN KEY([CidadeID])
REFERENCES [dbo].[Cidade] ([CidadeID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Fornecedor] CHECK CONSTRAINT [FK_Fornecedor_Cidade]
GO
ALTER TABLE [dbo].[ItemVenda]  WITH CHECK ADD  CONSTRAINT [FK__ItemVenda__Venda] FOREIGN KEY([VendaID])
REFERENCES [dbo].[Venda] ([VendaID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ItemVenda] CHECK CONSTRAINT [FK__ItemVenda__Venda]
GO
ALTER TABLE [dbo].[ItemVenda]  WITH CHECK ADD  CONSTRAINT [FK_ItemVenda_Produto] FOREIGN KEY([ProdutoID])
REFERENCES [dbo].[Produtos] ([ProdutoID])
GO
ALTER TABLE [dbo].[ItemVenda] CHECK CONSTRAINT [FK_ItemVenda_Produto]
GO
ALTER TABLE [dbo].[PagamentosParciais]  WITH CHECK ADD  CONSTRAINT [FK__PagamentosParciais__ParcelaID] FOREIGN KEY([ParcelaID])
REFERENCES [dbo].[Parcela] ([ParcelaID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PagamentosParciais] CHECK CONSTRAINT [FK__PagamentosParciais__ParcelaID]
GO
ALTER TABLE [dbo].[Parcela]  WITH CHECK ADD  CONSTRAINT [FK_Parcela_Venda] FOREIGN KEY([VendaID])
REFERENCES [dbo].[Venda] ([VendaID])
GO
ALTER TABLE [dbo].[Parcela] CHECK CONSTRAINT [FK_Parcela_Venda]
GO
ALTER TABLE [dbo].[Venda]  WITH CHECK ADD  CONSTRAINT [FK__Venda__ClienteID] FOREIGN KEY([ClienteID])
REFERENCES [dbo].[Cliente] ([ClienteID])
GO
ALTER TABLE [dbo].[Venda] CHECK CONSTRAINT [FK__Venda__ClienteID]
GO
EXEC sys.sp_addextendedproperty @name=N'comentario_cidade', @value=N'Municipios das Unidades Federativas' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Cidade'
GO
EXEC sys.sp_addextendedproperty @name=N'comentario_estado', @value=N'Unidades Federativas' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Estado'
GO
