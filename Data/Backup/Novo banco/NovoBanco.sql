USE [C:\PROGRAM FILES\MICROSOFT SQL SERVER\MSSQL10.SQLEXPRESS\MSSQL\DATA\BDFINANCAS.MDF]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 03/01/2025 22:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[CategoriaID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoriaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cidade]    Script Date: 03/01/2025 22:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cidade](
	[CidadeID] [int] NOT NULL,
	[Nome] [varchar](120) NULL,
	[EstadoID] [int] NULL,
	[Ibge] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CidadeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 03/01/2025 22:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[ClienteID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](100) NOT NULL,
	[CpfCnpj] [nvarchar](14) NOT NULL,
	[Endereco] [nvarchar](255) NULL,
	[Telefone] [nvarchar](15) NULL,
	[Email] [nvarchar](100) NULL,
	[CidadeID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ClienteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[CpfCnpj] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContaPagar]    Script Date: 03/01/2025 22:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContaPagar](
	[ContaPagarID] [int] IDENTITY(1,1) NOT NULL,
	[FornecedorID] [int] NOT NULL,
	[ValorTotal] [decimal](10, 2) NOT NULL,
	[DataVencimento] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ContaPagarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContaReceber]    Script Date: 03/01/2025 22:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContaReceber](
	[ContaReceberID] [int] IDENTITY(1,1) NOT NULL,
	[VendaID] [int] NOT NULL,
	[ValorTotal] [decimal](10, 2) NOT NULL,
	[DataVencimento] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ContaReceberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado]    Script Date: 03/01/2025 22:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado](
	[EstadoID] [int] NOT NULL,
	[Nome] [varchar](75) NULL,
	[Uf] [varchar](2) NULL,
	[Ibge] [int] NULL,
	[Pais] [int] NULL,
	[ddd] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[EstadoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fornecedor]    Script Date: 03/01/2025 22:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fornecedor](
	[FornecedorID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](100) NOT NULL,
	[Cnpj] [nvarchar](14) NOT NULL,
	[Endereco] [nvarchar](255) NULL,
	[Telefone] [nvarchar](15) NULL,
	[Email] [nvarchar](100) NULL,
	[CidadeID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[FornecedorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Cnpj] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemVenda]    Script Date: 03/01/2025 22:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemVenda](
	[ItemVendaID] [int] IDENTITY(1,1) NOT NULL,
	[VendaID] [int] NOT NULL,
	[ProdutoID] [int] NOT NULL,
	[Quantidade] [int] NOT NULL,
	[PrecoUnitario] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ItemVendaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pagamento]    Script Date: 03/01/2025 22:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pagamento](
	[PagamentoID] [int] IDENTITY(1,1) NOT NULL,
	[ParcelaID] [int] NOT NULL,
	[DataPagamento] [datetime] NULL,
	[ValorPago] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PagamentoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Parcela]    Script Date: 03/01/2025 22:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parcela](
	[ParcelaID] [int] IDENTITY(1,1) NOT NULL,
	[ContaReceberID] [int] NOT NULL,
	[NumeroParcela] [int] NOT NULL,
	[ValorParcela] [decimal](10, 2) NOT NULL,
	[DataVencimento] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ParcelaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produto]    Script Date: 03/01/2025 22:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produto](
	[ProdutoID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](100) NOT NULL,
	[Descricao] [nvarchar](max) NULL,
	[Preco] [decimal](10, 2) NOT NULL,
	[Estoque] [int] NOT NULL,
	[CategoriaID] [int] NOT NULL,
	[SubCategoriaID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProdutoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubCategoria]    Script Date: 03/01/2025 22:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubCategoria](
	[SubCategoriaID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](100) NOT NULL,
	[CategoriaID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SubCategoriaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 03/01/2025 22:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[UsuarioID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Senha] [nvarchar](100) NOT NULL,
	[TipoUsuario] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UsuarioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venda]    Script Date: 03/01/2025 22:04:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venda](
	[VendaID] [int] IDENTITY(1,1) NOT NULL,
	[ClienteID] [int] NOT NULL,
	[DataVenda] [datetime] NOT NULL,
	[ValorTotal] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[VendaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cidade] ADD  DEFAULT (NULL) FOR [Nome]
GO
ALTER TABLE [dbo].[Cidade] ADD  DEFAULT (NULL) FOR [EstadoID]
GO
ALTER TABLE [dbo].[Cidade] ADD  DEFAULT (NULL) FOR [Ibge]
GO
ALTER TABLE [dbo].[Estado] ADD  DEFAULT (NULL) FOR [Nome]
GO
ALTER TABLE [dbo].[Estado] ADD  DEFAULT (NULL) FOR [Uf]
GO
ALTER TABLE [dbo].[Estado] ADD  DEFAULT (NULL) FOR [Ibge]
GO
ALTER TABLE [dbo].[Estado] ADD  DEFAULT (NULL) FOR [Pais]
GO
ALTER TABLE [dbo].[Estado] ADD  DEFAULT (NULL) FOR [ddd]
GO
ALTER TABLE [dbo].[Pagamento] ADD  DEFAULT (getdate()) FOR [DataPagamento]
GO
ALTER TABLE [dbo].[Venda] ADD  DEFAULT (getdate()) FOR [DataVenda]
GO
ALTER TABLE [dbo].[Cidade]  WITH CHECK ADD  CONSTRAINT [FK_cidade_Estado] FOREIGN KEY([EstadoID])
REFERENCES [dbo].[Estado] ([EstadoID])
GO
ALTER TABLE [dbo].[Cidade] CHECK CONSTRAINT [FK_cidade_Estado]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Cidade] FOREIGN KEY([CidadeID])
REFERENCES [dbo].[Cidade] ([CidadeID])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_Cliente_Cidade]
GO
ALTER TABLE [dbo].[ContaPagar]  WITH CHECK ADD FOREIGN KEY([FornecedorID])
REFERENCES [dbo].[Fornecedor] ([FornecedorID])
GO
ALTER TABLE [dbo].[ContaReceber]  WITH CHECK ADD FOREIGN KEY([VendaID])
REFERENCES [dbo].[Venda] ([VendaID])
GO
ALTER TABLE [dbo].[Fornecedor]  WITH CHECK ADD  CONSTRAINT [FK_Fornecedor_Cidade] FOREIGN KEY([CidadeID])
REFERENCES [dbo].[Cidade] ([CidadeID])
GO
ALTER TABLE [dbo].[Fornecedor] CHECK CONSTRAINT [FK_Fornecedor_Cidade]
GO
ALTER TABLE [dbo].[ItemVenda]  WITH CHECK ADD FOREIGN KEY([ProdutoID])
REFERENCES [dbo].[Produto] ([ProdutoID])
GO
ALTER TABLE [dbo].[ItemVenda]  WITH CHECK ADD FOREIGN KEY([VendaID])
REFERENCES [dbo].[Venda] ([VendaID])
GO
ALTER TABLE [dbo].[Pagamento]  WITH CHECK ADD FOREIGN KEY([ParcelaID])
REFERENCES [dbo].[Parcela] ([ParcelaID])
GO
ALTER TABLE [dbo].[Parcela]  WITH CHECK ADD FOREIGN KEY([ContaReceberID])
REFERENCES [dbo].[ContaReceber] ([ContaReceberID])
GO
ALTER TABLE [dbo].[Produto]  WITH CHECK ADD FOREIGN KEY([CategoriaID])
REFERENCES [dbo].[Categoria] ([CategoriaID])
GO
ALTER TABLE [dbo].[Produto]  WITH CHECK ADD FOREIGN KEY([SubCategoriaID])
REFERENCES [dbo].[SubCategoria] ([SubCategoriaID])
GO
ALTER TABLE [dbo].[SubCategoria]  WITH CHECK ADD FOREIGN KEY([CategoriaID])
REFERENCES [dbo].[Categoria] ([CategoriaID])
GO
ALTER TABLE [dbo].[Venda]  WITH CHECK ADD FOREIGN KEY([ClienteID])
REFERENCES [dbo].[Cliente] ([ClienteID])
GO
ALTER TABLE [dbo].[ContaPagar]  WITH CHECK ADD CHECK  (([ValorTotal]>=(0)))
GO
ALTER TABLE [dbo].[ContaReceber]  WITH CHECK ADD CHECK  (([ValorTotal]>=(0)))
GO
ALTER TABLE [dbo].[ItemVenda]  WITH CHECK ADD CHECK  (([PrecoUnitario]>=(0)))
GO
ALTER TABLE [dbo].[ItemVenda]  WITH CHECK ADD CHECK  (([Quantidade]>(0)))
GO
ALTER TABLE [dbo].[Pagamento]  WITH CHECK ADD CHECK  (([ValorPago]>=(0)))
GO
ALTER TABLE [dbo].[Parcela]  WITH CHECK ADD CHECK  (([NumeroParcela]>(0)))
GO
ALTER TABLE [dbo].[Parcela]  WITH CHECK ADD CHECK  (([ValorParcela]>=(0)))
GO
EXEC sys.sp_addextendedproperty @name=N'comentario_cidade', @value=N'Municipios das Unidades Federativas' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Cidade'
GO
EXEC sys.sp_addextendedproperty @name=N'comentario_estado', @value=N'Unidades Federativas' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Estado'
GO
