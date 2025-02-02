-- Tabela Categoria
CREATE TABLE Categoria (
    CategoriaID INTEGER PRIMARY KEY AUTOINCREMENT,
    NomeCategoria TEXT
);

-- Tabela Estado
CREATE TABLE Estado (
    EstadoID INTEGER PRIMARY KEY AUTOINCREMENT,
    NomeEstado TEXT,
    Uf TEXT,
    ibge INTEGER,
    Pais INTEGER,
    ddd TEXT
);

-- Tabela Cidade
CREATE TABLE Cidade (
    CidadeID INTEGER PRIMARY KEY AUTOINCREMENT,
    NomeCidade TEXT,
    EstadoID INTEGER,
    ibge INTEGER,
    FOREIGN KEY (EstadoID) REFERENCES Estado(EstadoID) ON DELETE CASCADE
);

-- Tabela Cliente
CREATE TABLE Cliente (
    ClienteID INTEGER PRIMARY KEY AUTOINCREMENT,
    NomeCliente TEXT NOT NULL,
    Cpf TEXT,
    Email TEXT,
    Endereco TEXT,
    Telefone TEXT,
    CidadeID INTEGER,
    FOREIGN KEY (CidadeID) REFERENCES Cidade(CidadeID) ON DELETE CASCADE
);

-- Tabela FormaPgto
CREATE TABLE FormaPgto (
    FormaPgtoID INTEGER PRIMARY KEY AUTOINCREMENT,
    NomeFormaPgto TEXT
);

-- Tabela Fornecedor
CREATE TABLE Fornecedor (
    FornecedorID INTEGER PRIMARY KEY AUTOINCREMENT,
    NomeFornecedor TEXT NOT NULL,
    Cnpj TEXT,
    Endereco TEXT,
    Telefone TEXT,
    Email TEXT,
    CidadeID INTEGER NOT NULL,
    FOREIGN KEY (CidadeID) REFERENCES Cidade(CidadeID) ON DELETE CASCADE
);

-- Tabela Produtos
CREATE TABLE Produtos (
    ProdutoID INTEGER PRIMARY KEY AUTOINCREMENT,
    NomeProduto TEXT NOT NULL,
    PrecoCusto REAL NOT NULL,
    Lucro REAL NOT NULL,
    PrecoDeVenda REAL NOT NULL,
    QuantidadeEmEstoque INTEGER NOT NULL,
    DataDeEntrada TEXT NOT NULL,
    UnidadeDeMedida TEXT,
    Status TEXT,
    Imagem BLOB,
    Referencia TEXT
);

-- Tabela Venda
CREATE TABLE Venda (
    VendaID INTEGER PRIMARY KEY AUTOINCREMENT,
    ClienteID INTEGER NOT NULL,
    DataVenda TEXT NOT NULL,
    ValorTotal REAL NOT NULL,
    FormaPgto TEXT,
    FOREIGN KEY (ClienteID) REFERENCES Cliente(ClienteID)
);

-- Tabela ItemVenda
CREATE TABLE ItemVenda (
    ItemVendaID INTEGER PRIMARY KEY AUTOINCREMENT,
    ProdutoID INTEGER NOT NULL,
    Quantidade INTEGER NOT NULL,
    PrecoUnitario REAL NOT NULL,
    Subtotal REAL GENERATED ALWAYS AS (Quantidade * PrecoUnitario) STORED,
    VendaID INTEGER,
    FOREIGN KEY (ProdutoID) REFERENCES Produtos(ProdutoID),
    FOREIGN KEY (VendaID) REFERENCES Venda(VendaID) ON DELETE CASCADE
);

-- Tabela Parcela
CREATE TABLE Parcela (
    ParcelaID INTEGER PRIMARY KEY AUTOINCREMENT,
    NumeroParcela INTEGER NOT NULL,
    DataVencimento TEXT NOT NULL,
    ValorParcela REAL NOT NULL,
    ValorRecebido REAL NOT NULL,
    SaldoRestante REAL NOT NULL,
    Pago INTEGER NOT NULL, -- SQLite não tem tipo BIT, usamos INTEGER (0 ou 1)
    VendaID INTEGER,
    FOREIGN KEY (VendaID) REFERENCES Venda(VendaID)
);

-- Tabela ContaReceber
CREATE TABLE ContaReceber (
    ContaReceberID INTEGER PRIMARY KEY AUTOINCREMENT,
    DataRecebimento TEXT,
    ValorRecebido REAL NOT NULL,
    SaldoRestante REAL NOT NULL,
    Pago INTEGER NOT NULL, -- SQLite não tem tipo BIT, usamos INTEGER (0 ou 1)
    ParcelaID INTEGER NOT NULL,
    VendaID INTEGER NOT NULL,
    FormaPgtoID INTEGER,
    FOREIGN KEY (ParcelaID) REFERENCES Parcela(ParcelaID) ON DELETE CASCADE,
    FOREIGN KEY (VendaID) REFERENCES Venda(VendaID) ON DELETE CASCADE,
    FOREIGN KEY (FormaPgtoID) REFERENCES FormaPgto(FormaPgtoID) ON DELETE CASCADE
);

-- Tabela ContasAPagar
CREATE TABLE ContasAPagar (
    ContaPagarID INTEGER PRIMARY KEY AUTOINCREMENT,
    FornecedorID INTEGER,
    DataVencimento TEXT,
    ValorTotal REAL,
    Pago INTEGER, -- SQLite não tem tipo BIT, usamos INTEGER (0 ou 1)
    FOREIGN KEY (FornecedorID) REFERENCES Fornecedor(FornecedorID) ON DELETE CASCADE
);

-- Tabela PagamentosParciais
CREATE TABLE PagamentosParciais (
    PagamentoParcialID INTEGER PRIMARY KEY AUTOINCREMENT,
    ParcelaID INTEGER,
    ValorPago REAL,
    DataPagamento TEXT,
    FOREIGN KEY (ParcelaID) REFERENCES Parcela(ParcelaID) ON DELETE CASCADE
);

-- Tabela Usuario
CREATE TABLE Usuario (
    UsuarioID INTEGER PRIMARY KEY AUTOINCREMENT,
    NomeUsuario TEXT NOT NULL,
    Email TEXT NOT NULL,
    Senha TEXT NOT NULL,
    TipoUsuario TEXT NOT NULL
);

-- Comentários (SQLite não suporta comentários de tabela diretamente, então você pode adicionar comentários como texto)
-- Municípios das Unidades Federativas
-- Unidades Federativas