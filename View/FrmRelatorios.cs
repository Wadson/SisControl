using SisControl.Relatorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SisControl.View
{
    public partial class FrmRelatorios : SisControl.FrmModeloForm
    {
        public FrmRelatorios()
        {
            InitializeComponent();
        }
        // Supomos que seu DataGridView se chama dataGridView1 e seu Label se chama lblTotal

        private void CalcularSaldoRestante()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvPesquisar.Rows)
            {
                if (row.Cells["SaldoRestante"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["SaldoRestante"].Value);
                }
            }

            lblTotal.Text = total.ToString("N2"); // "N" para formatar como moeda
        }

        // Chamando a função após carregar os dados no DataGridView
        
        private void PersonalizarDataGridView(DataTable dataTable)
        {
            // Define o DataTable como a fonte de dados do DataGridView
            dgvPesquisar.DataSource = dataTable;

            // Renomeia as colunas
            dgvPesquisar.Columns["NomeCliente"].HeaderText = "Cliente";
            dgvPesquisar.Columns["NomeProduto"].HeaderText = "Produto";
            dgvPesquisar.Columns["VendaID"].HeaderText = "Venda ID";
            dgvPesquisar.Columns["Quantidade"].HeaderText = "Quantidade";
            dgvPesquisar.Columns["PrecoUnitario"].HeaderText = "Preço Unitário";
            dgvPesquisar.Columns["Subtotal"].HeaderText = "Subtotal";
            dgvPesquisar.Columns["NumeroParcela"].HeaderText = "Parcela";
            dgvPesquisar.Columns["DataVencimento"].HeaderText = "Data Vencimento";
            dgvPesquisar.Columns["ValorParcela"].HeaderText = "Valor Parcela";
            dgvPesquisar.Columns["SaldoRestante"].HeaderText = "Saldo Restante";
            dgvPesquisar.Columns["Pago"].HeaderText = "Pago";
            dgvPesquisar.Columns["DataRecebimento"].HeaderText = "Data Recebimento";
            dgvPesquisar.Columns["ValorRecebido"].HeaderText = "Valor Recebido";

            // Oculta as colunas de CódigoID (se necessário)
            dgvPesquisar.Columns["VendaID"].Visible = false;
            dgvPesquisar.Columns["PrecoUnitario"].Visible = false;
            dgvPesquisar.Columns["Subtotal"].Visible = false;
            dgvPesquisar.Columns["Quantidade"].Visible = false;

            // Formata as colunas de valores no formato de moeda ("N2")
            dgvPesquisar.Columns["PrecoUnitario"].DefaultCellStyle.Format = "N2";
            dgvPesquisar.Columns["Subtotal"].DefaultCellStyle.Format = "N2";
            dgvPesquisar.Columns["ValorParcela"].DefaultCellStyle.Format = "N2";
            dgvPesquisar.Columns["SaldoRestante"].DefaultCellStyle.Format = "N2";
            dgvPesquisar.Columns["ValorRecebido"].DefaultCellStyle.Format = "N2";

            // Redimensiona automaticamente as colunas para ajustar ao conteúdo
            dgvPesquisar.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // Configura o DataGridView para exibir as colunas de valores alinhadas à direita
            dgvPesquisar.Columns["PrecoUnitario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPesquisar.Columns["Subtotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPesquisar.Columns["ValorParcela"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPesquisar.Columns["SaldoRestante"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPesquisar.Columns["ValorRecebido"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvPesquisar.Columns["NumeroParcela"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPesquisar.Columns["Quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Configura o DataGridView para exibir a coluna "Pago" como um checkbox
            dgvPesquisar.Columns["Pago"].ValueType = typeof(bool);

            // Habilita a seleção de linha inteira (FullRowSelect)
            dgvPesquisar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

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
                        // Personaliza o DataGridView com o DataTable resultante
                        PersonalizarDataGridView(dataTable);
                        return dataTable;
                        CalcularSaldoRestante();
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
                        // Personaliza o DataGridView com o DataTable resultante
                        PersonalizarDataGridView(dataTable);
                        return dataTable;
                        CalcularSaldoRestante();
                    }
                }
            }
        }

        public DataTable PesquisarPorPeriodoEStatus(DateTime dataInicial, DateTime dataFinal, bool pago)
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
                        // Personaliza o DataGridView com o DataTable resultante
                        PersonalizarDataGridView(dataTable);
                        return dataTable;
                        CalcularSaldoRestante();
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
                        // Personaliza o DataGridView com o DataTable resultante
                        PersonalizarDataGridView(dataTable);
                        return dataTable;
                        CalcularSaldoRestante();
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
                        // Personaliza o DataGridView com o DataTable resultante
                        PersonalizarDataGridView(dataTable);
                        return dataTable;
                        CalcularSaldoRestante();
                    }
                }
            }
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Oculta todos os GroupBox inicialmente
            gbStatus.Visible = false;
            gbPeriodo.Visible = false;
            gbNomeCliente.Visible = false;

            // Obtém o método selecionado no ComboBox
            string metodoSelecionado = cmbFiltro.SelectedItem?.ToString();

            // Habilita os GroupBox necessários conforme o método selecionado
            switch (metodoSelecionado)
            {
                case "PesquisarPorStatusGeral":
                    gbStatus.Visible = true; // Apenas o GroupBox de Status é necessário
                    btnFiltro.Visible = true;                    
                    break;

                case "PesquisarPorNomeClienteEStatus":
                    gbStatus.Visible = true; // Status e Nome do Cliente são necessários
                    gbNomeCliente.Visible = true;
                    btnFiltro.Visible = true;
                    break;

                case "PesquisarPorPeriodoEStatus":
                    gbStatus.Visible = true; // Status e Período são necessários
                    gbPeriodo.Visible = true;
                    btnFiltro.Visible = true;
                    break;

                case "PesquisarContasVencidas":
                case "PesquisarContasNaoVencidas":
                    // Nenhum GroupBox é necessário, pois o filtro é baseado apenas na data atual
                    break;

                default:
                    MessageBox.Show("Selecione um método válido.");
                    break;
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            // Limpa o DataGridView antes de aplicar um novo filtro
            dgvPesquisar.DataSource = null;

            // Obtém o método selecionado no ComboBox
            string metodoSelecionado = cmbFiltro.SelectedItem?.ToString();

            // Variável para armazenar o resultado da pesquisa
            DataTable resultado = null;

            // Executa o método de pesquisa correspondente ao item selecionado no ComboBox
            switch (metodoSelecionado)
            {
                case "PesquisarPorStatusGeral":
                    if (gbStatus.Visible) // Verifica se o GroupBox está visível
                    {
                        bool status = rbPago.Checked; // true para "Pago", false para "Não Pago"
                        resultado = PesquisarPorStatusGeral(status);
                    }
                    break;

                case "PesquisarPorNomeClienteEStatus":
                    if (gbStatus.Visible && gbNomeCliente.Visible) // Verifica se os GroupBox estão visíveis
                    {
                        string nomeCliente = txtNomeCliente.Text;
                        bool statusCliente = rbPago.Checked; // true para "Pago", false para "Não Pago"
                        resultado = PesquisarPorNomeClienteEStatus(nomeCliente, statusCliente);
                    }
                    break;

                case "PesquisarPorPeriodoEStatus":
                    if (gbStatus.Visible && gbPeriodo.Visible) // Verifica se os GroupBox estão visíveis
                    {
                        DateTime dataInicio = dtpDataVencimentoInicio.Value;
                        DateTime dataFim = dtpDataVencimentoFim.Value;
                        bool statusPeriodo = rbPago.Checked; // true para "Pago", false para "Não Pago"
                        resultado = PesquisarPorPeriodoEStatus(dataInicio, dataFim, statusPeriodo);
                    }
                    break;

                case "PesquisarContasVencidas":
                    resultado = PesquisarContasVencidas(DateTime.Now);
                    break;

                case "PesquisarContasNaoVencidas":
                    resultado = PesquisarContasNaoVencidas(DateTime.Now);
                    break;

                default:
                    MessageBox.Show("Selecione um método válido.");
                    break;
            }

            // Exibe o resultado no DataGridView
            if (resultado != null)
            {
                dgvPesquisar.DataSource = resultado;
            }
            else
            {
                MessageBox.Show("Nenhum resultado encontrado ou parâmetros inválidos.");
            }
        }

        private void FrmRelatorios_Load(object sender, EventArgs e)
        {
            // Define o primeiro item como selecionado por padrão (opcional)
            if (cmbFiltro.Items.Count > 0)
            {
                cmbFiltro.SelectedIndex = 0;
            }
        }


        private void AbrirFrmLocalizarCliente()
        {
            FrmLocalizarCliente frmLocalizarCliente = new FrmLocalizarCliente();
            frmLocalizarCliente.FormChamador = this; // Define o formulário chamador
            frmLocalizarCliente.ShowDialog();
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AbrirFrmLocalizarCliente();
        }
    }
}
