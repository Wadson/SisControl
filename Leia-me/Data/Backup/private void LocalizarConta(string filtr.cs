private void LocalizarConta(string filtro = "")
{
    string queryBase = @"
SELECT
    Parcela.ParcelaID,                -- ID da parcela
    Parcela.ValorParcela,             -- Valor da parcela
    Parcela.NumeroParcela,            -- Número da parcela
    ContaReceber.SaldoRestante,       -- Saldo restante da parcela
    Parcela.DataVencimento,           -- Data de vencimento da parcela
    Parcela.VendaID,                  -- ID da venda associada
    ContaReceber.Pago,                -- Status de pagamento
    Parcela.ValorRecebido,            -- Valor recebido da parcela
    ContaReceber.DataRecebimento,     -- Data de recebimento da conta
    Cliente.ClienteID,                -- Adicionando o ClienteID
    Cliente.NomeCliente               -- Nome do cliente
FROM
    ContaReceber
INNER JOIN
    Parcela ON ContaReceber.ParcelaID = Parcela.ParcelaID
INNER JOIN
    Venda ON Parcela.VendaID = Venda.VendaID
INNER JOIN
    Cliente ON Venda.ClienteID = Cliente.ClienteID
WHERE ";

    string queryFinal = queryBase;

    // Adicionar a parte do filtro
    if (filtro == "Status")
    {
        string StatusConta = radioBtnAberto.Checked ? "0" : "1";
        queryFinal += "ContaReceber.Pago = @Pago";
        Utilitario.PesquisarPorNome(queryFinal, "@Pago", StatusConta, dgvContasReceber);
    }
    else if (filtro == "Nome" && txtClienteID.Text != string.Empty)
    {
        queryFinal += "ContaReceber.Pago = 0 AND Cliente.NomeCliente = @NomeCliente";
        Utilitario.PesquisarPorNome(queryFinal, "@NomeCliente", txtNomeCliente.Text, dgvContasReceber);
    }
    else if (filtro == "Período")
    {
        queryFinal += "Parcela.DataVencimento BETWEEN @DataVencimentoInicio AND @DataVencimentoFim";
        Utilitario.PesquisarPorPeriodo(queryFinal, "@DataVencimentoInicio", DateTime.Parse(dtpDataVencimentoInicio.Text),
                                                "@DataVencimentoFim", DateTime.Parse(dtpDataVencimentoFim.Text), dgvContasReceber);
    }
    else
    {
        MessageBox.Show("Por favor, selecione um critério de filtro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        ListarContaReceber();
        return;
    }

    AtualizarContagemRegistros();
}










