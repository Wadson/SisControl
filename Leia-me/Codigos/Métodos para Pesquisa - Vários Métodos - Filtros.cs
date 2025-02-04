//1. Pesquisar por StatusGeral (Pago = @Pago)

public DataTable PesquisarPorStatusGeral(bool pago)
{
    string query = @"
        SELECT Cliente.NomeCliente, Produtos.NomeProduto, Venda.VendaID, ItemVenda.Quantidade, ItemVenda.PrecoUnitario, 
               ItemVenda.Subtotal, Parcela.NumeroParcela, Parcela.DataVencimento, Parcela.ValorParcela, 
               Parcela.SaldoRestante, Parcela.Pago, ContaReceber.DataRecebimento, ContaReceber.ValorRecebido
        FROM Produtos 
        INNER JOIN ItemVenda ON Produtos.ProdutoID = ItemVenda.ProdutoID 
        INNER JOIN Venda ON ItemVenda.VendaID = Venda.VendaID 
        INNER JOIN Parcela ON Venda.VendaID = Parcela.VendaID 
        INNER JOIN Cliente ON Venda.ClienteID = Cliente.ClienteID 
        INNER JOIN ContaReceber ON Venda.VendaID = ContaReceber.VendaID AND Parcela.ParcelaID = ContaReceber.ParcelaID
        WHERE Parcela.Pago = @Pago";

    using (var connection = Conexao.Conex())
    {
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@Pago", pago);
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
    }
}
// 2. Pesquisar por NomeCliente e StatusGeral (NomeCliente = @NomeCliente AND Pago = @Pago)

public DataTable PesquisarPorNomeClienteEStatus(string nomeCliente, bool pago)
{
    string query = @"
        SELECT Cliente.NomeCliente, Produtos.NomeProduto, Venda.VendaID, ItemVenda.Quantidade, ItemVenda.PrecoUnitario, 
               ItemVenda.Subtotal, Parcela.NumeroParcela, Parcela.DataVencimento, Parcela.ValorParcela, 
               Parcela.SaldoRestante, Parcela.Pago, ContaReceber.DataRecebimento, ContaReceber.ValorRecebido
        FROM Produtos 
        INNER JOIN ItemVenda ON Produtos.ProdutoID = ItemVenda.ProdutoID 
        INNER JOIN Venda ON ItemVenda.VendaID = Venda.VendaID 
        INNER JOIN Parcela ON Venda.VendaID = Parcela.VendaID 
        INNER JOIN Cliente ON Venda.ClienteID = Cliente.ClienteID 
        INNER JOIN ContaReceber ON Venda.VendaID = ContaReceber.VendaID AND Parcela.ParcelaID = ContaReceber.ParcelaID
        WHERE Cliente.NomeCliente = @NomeCliente AND Parcela.Pago = @Pago";

    using (var connection = Conexao.Conex())
    {
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@NomeCliente", nomeCliente);
            command.Parameters.AddWithValue("@Pago", pago);
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
    }
}

// public DataTable PesquisarPorPeriodoEStatus(DateTime dataInicial, DateTime dataFinal, bool pago)
{
    string query = @"
        SELECT Cliente.NomeCliente, Produtos.NomeProduto, Venda.VendaID, ItemVenda.Quantidade, ItemVenda.PrecoUnitario, 
               ItemVenda.Subtotal, Parcela.NumeroParcela, Parcela.DataVencimento, Parcela.ValorParcela, 
               Parcela.SaldoRestante, Parcela.Pago, ContaReceber.DataRecebimento, ContaReceber.ValorRecebido
        FROM Produtos 
        INNER JOIN ItemVenda ON Produtos.ProdutoID = ItemVenda.ProdutoID 
        INNER JOIN Venda ON ItemVenda.VendaID = Venda.VendaID 
        INNER JOIN Parcela ON Venda.VendaID = Parcela.VendaID 
        INNER JOIN Cliente ON Venda.ClienteID = Cliente.ClienteID 
        INNER JOIN ContaReceber ON Venda.VendaID = ContaReceber.VendaID AND Parcela.ParcelaID = ContaReceber.ParcelaID
        WHERE Parcela.DataVencimento BETWEEN @DataInicial AND @DataFinal AND Parcela.Pago = @Pago";

    using (var connection = Conexao.Conex())
    {
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@DataInicial", dataInicial);
            command.Parameters.AddWithValue("@DataFinal", dataFinal);
            command.Parameters.AddWithValue("@Pago", pago);
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
    }
}

// 4. Pesquisar por Contas Vencidas (DataVencimento <= @DataVencimento)
public DataTable PesquisarContasVencidas(DateTime dataVencimento)
{
    string query = @"
        SELECT Cliente.NomeCliente, Produtos.NomeProduto, Venda.VendaID, ItemVenda.Quantidade, ItemVenda.PrecoUnitario, 
               ItemVenda.Subtotal, Parcela.NumeroParcela, Parcela.DataVencimento, Parcela.ValorParcela, 
               Parcela.SaldoRestante, Parcela.Pago, ContaReceber.DataRecebimento, ContaReceber.ValorRecebido
        FROM Produtos 
        INNER JOIN ItemVenda ON Produtos.ProdutoID = ItemVenda.ProdutoID 
        INNER JOIN Venda ON ItemVenda.VendaID = Venda.VendaID 
        INNER JOIN Parcela ON Venda.VendaID = Parcela.VendaID 
        INNER JOIN Cliente ON Venda.ClienteID = Cliente.ClienteID 
        INNER JOIN ContaReceber ON Venda.VendaID = ContaReceber.VendaID AND Parcela.ParcelaID = ContaReceber.ParcelaID
        WHERE Parcela.DataVencimento <= @DataVencimento";

    using (var connection = Conexao.Conex())
    {
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@DataVencimento", dataVencimento);
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
    }
}

// 5. Pesquisar por Contas Não Vencidas (DataVencimento >= @DataVencimento)

public DataTable PesquisarContasNaoVencidas(DateTime dataVencimento)
{
    string query = @"
        SELECT Cliente.NomeCliente, Produtos.NomeProduto, Venda.VendaID, ItemVenda.Quantidade, ItemVenda.PrecoUnitario, 
               ItemVenda.Subtotal, Parcela.NumeroParcela, Parcela.DataVencimento, Parcela.ValorParcela, 
               Parcela.SaldoRestante, Parcela.Pago, ContaReceber.DataRecebimento, ContaReceber.ValorRecebido
        FROM Produtos 
        INNER JOIN ItemVenda ON Produtos.ProdutoID = ItemVenda.ProdutoID 
        INNER JOIN Venda ON ItemVenda.VendaID = Venda.VendaID 
        INNER JOIN Parcela ON Venda.VendaID = Parcela.VendaID 
        INNER JOIN Cliente ON Venda.ClienteID = Cliente.ClienteID 
        INNER JOIN ContaReceber ON Venda.VendaID = ContaReceber.VendaID AND Parcela.ParcelaID = ContaReceber.ParcelaID
        WHERE Parcela.DataVencimento >= @DataVencimento";

    using (var connection = Conexao.Conex())
    {
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@DataVencimento", dataVencimento);
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
    }
}

// 6. Como Usar os Métodos

// Exemplo de uso: Pesquisar por StatusGeral
DataTable resultado = PesquisarPorStatusGeral(true); // true para "Pago", false para "Não Pago"
dataGridView.DataSource = resultado;

// Exemplo de uso: Pesquisar por NomeCliente e StatusGeral
DataTable resultado = PesquisarPorNomeClienteEStatus("João Silva", false);
dataGridView.DataSource = resultado;

// Exemplo de uso: Pesquisar por Período e StatusGeral
DataTable resultado = PesquisarPorPeriodoEStatus(new DateTime(2023, 01, 01), new DateTime(2023, 12, 31), false);
dataGridView.DataSource = resultado;

// Exemplo de uso: Pesquisar por Contas Vencidas
DataTable resultado = PesquisarContasVencidas(DateTime.Now);
dataGridView.DataSource = resultado;

// Exemplo de uso: Pesquisar por Contas Não Vencidas
DataTable resultado = PesquisarContasNaoVencidas(DateTime.Now);
dataGridView.DataSource = resultado;


/*
7. Observações
Substitua "SUA_CONNECTION_STRING" pela sua string de conexão com o banco de dados.

Certifique-se de que os nomes das colunas e tabelas no SQL correspondem ao seu banco de dados.

Adicione tratamento de exceções (try-catch) para lidar com erros de conexão ou consulta.

Com esses métodos, você pode realizar as pesquisas necessárias e exibir os resultados no
*/