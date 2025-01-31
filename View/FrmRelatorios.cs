using SisControl.Relatorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using OfficeOpenXml; 
using iTextSharp.text;
using iTextSharp.text.pdf;
using ComponentFactory.Krypton.Toolkit;

namespace SisControl.View
{
    public partial class FrmRelatorios : SisControl.FrmModeloForm
    {
        public FrmRelatorios()
        {
            InitializeComponent();

            // Definindo o contexto de licença do EPPlus
            //ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // Para uso não comercial
                                                                        // ExcelPackage.LicenseContext = LicenseContext.Commercial; // Para uso comercial
        }

        private void CalcularTotalDataGrid()
        {
            try
            {
                // Calcular o total dos valores Não pagos na coluna "SaldoRestante"
                decimal totalEmAberto = Utilitario.SomarValoresDataGrid(dgvPesquisar, "SaldoRestante");

                // Atualizar a label com o total calculado
                lblTotal.Text = $"R$ {totalEmAberto:F2}";


                // Calcular o total dos valores na coluna "ValorParcela"
                decimal totalPago = Utilitario.SomarValoresDataGrid(dgvPesquisar, "ValorRecebido");

                // Atualizar a label com o total calculado
                lblTotalRecebido.Text = $"R$ {totalPago:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao calcular o total: " + ex.Message);
            }
        }
        // Chamando a função após carregar os dados no DataGridView

        private void PersonalizarDataGridView(DataTable dataTable)
        {
            // Define o DataTable como a fonte de dados do DataGridView
            dgvPesquisar.DataSource = dataTable;

            // Renomeia as colunas
            dgvPesquisar.Columns["NomeCliente"].HeaderText = "Cliente";
            dgvPesquisar.Columns["NumeroParcela"].HeaderText = "Parcela";
            dgvPesquisar.Columns["ValorParcela"].HeaderText = "Valor Parcela";
            dgvPesquisar.Columns["DataVencimento"].HeaderText = "Data Vencimento";
            dgvPesquisar.Columns["SaldoRestante"].HeaderText = "Saldo Restante";
            dgvPesquisar.Columns["ValorRecebido"].HeaderText = "Valor Recebido";
            dgvPesquisar.Columns["DataRecebimento"].HeaderText = "Data Recebimento";
            dgvPesquisar.Columns["Pago"].HeaderText = "Pago";
            dgvPesquisar.Columns["VendaID"].HeaderText = "Venda ID";

            // Oculta as colunas de CódigoID (se necessário)
            dgvPesquisar.Columns["VendaID"].Visible = false;

            // Formata as colunas de valores no formato de moeda ("N2")            
            dgvPesquisar.Columns["ValorParcela"].DefaultCellStyle.Format = "N2";
            dgvPesquisar.Columns["SaldoRestante"].DefaultCellStyle.Format = "N2";
            dgvPesquisar.Columns["ValorRecebido"].DefaultCellStyle.Format = "N2";

            // Redimensiona automaticamente as colunas para ajustar ao conteúdo
            dgvPesquisar.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // Alinhamento das colunas de valores
            dgvPesquisar.Columns["ValorParcela"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPesquisar.Columns["SaldoRestante"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPesquisar.Columns["ValorRecebido"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPesquisar.Columns["NumeroParcela"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Configura o DataGridView para exibir a coluna "Pago" como um checkbox
            dgvPesquisar.Columns["Pago"].ValueType = typeof(bool);

            // Habilita a seleção de linha inteira (FullRowSelect)
            dgvPesquisar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Centralização dos cabeçalhos de todas as colunas
            foreach (DataGridViewColumn column in dgvPesquisar.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Colore as colunas de valores
            dgvPesquisar.Columns["ValorParcela"].DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
            dgvPesquisar.Columns["SaldoRestante"].DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
            dgvPesquisar.Columns["ValorRecebido"].DefaultCellStyle.BackColor = System.Drawing.Color.LightBlue;
        }


        //1. Pesquisar por StatusGeral (Pago = @Pago)
        public DataTable PesquisarPorStatusGeral(bool pago)
        {
            string query = @"
                            SELECT
                                Cliente.NomeCliente, 
                                Parcela.NumeroParcela,
                                Parcela.ValorParcela, 
                                Parcela.DataVencimento, 
                                ContaReceber.SaldoRestante, 
                                Parcela.ValorRecebido, 
                                ContaReceber.DataRecebimento, 
                                ContaReceber.Pago,
                                Parcela.VendaID
                            FROM ContaReceber 
                            INNER JOIN Parcela ON ContaReceber.ParcelaID = Parcela.ParcelaID
                            INNER JOIN Venda ON Parcela.VendaID = Venda.VendaID
                            INNER JOIN Cliente ON Venda.ClienteID = Cliente.ClienteID
                            WHERE ContaReceber.Pago = @Pago";
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

                        CalcularTotalDataGrid();
                    }
                }
            }
        }
        // 2. Pesquisar por NomeCliente e StatusGeral (NomeCliente = @NomeCliente AND Pago = @Pago)

        public DataTable PesquisarPorNomeClienteEStatus(string nomeCliente, bool pago)
        {
            string query = @"
                            SELECT
                            Cliente.NomeCliente, 
                            Parcela.NumeroParcela,
                            Parcela.ValorParcela, 
                            Parcela.DataVencimento, 
                            ContaReceber.SaldoRestante, 
                            Parcela.ValorRecebido, 
                            ContaReceber.DataRecebimento, 
                            ContaReceber.Pago,
                            Parcela.VendaID
                        FROM ContaReceber 
                        INNER JOIN Parcela ON ContaReceber.ParcelaID = Parcela.ParcelaID
                        INNER JOIN Venda ON Parcela.VendaID = Venda.VendaID
                        INNER JOIN Cliente ON Venda.ClienteID = Cliente.ClienteID
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
                        CalcularTotalDataGrid();
                        return dataTable;                       
                    }
                }
            }
        }

        public DataTable PesquisarPorPeriodoEStatus(DateTime dataInicial, DateTime dataFinal, bool pago)
        {
            string query = @"
                            SELECT
                            Cliente.NomeCliente, 
                            Parcela.NumeroParcela,
                            Parcela.ValorParcela, 
                            Parcela.DataVencimento, 
                            ContaReceber.SaldoRestante, 
                            Parcela.ValorRecebido, 
                            ContaReceber.DataRecebimento, 
                            ContaReceber.Pago,
                            Parcela.VendaID
                        FROM ContaReceber 
                        INNER JOIN Parcela ON ContaReceber.ParcelaID = Parcela.ParcelaID
                        INNER JOIN Venda ON Parcela.VendaID = Venda.VendaID
                        INNER JOIN Cliente ON Venda.ClienteID = Cliente.ClienteID
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
                        CalcularTotalDataGrid();
                        return dataTable;                       
                    }
                }
            }
        }

        // 4. Pesquisar por Contas Vencidas (DataVencimento <= @DataVencimento)
        public DataTable PesquisarContasVencidas(DateTime dataVencimento)
        {
            string query = @"
                            SELECT
                                Cliente.NomeCliente, 
                                Parcela.NumeroParcela,
                                Parcela.ValorParcela, 
                                Parcela.DataVencimento, 
                                ContaReceber.SaldoRestante, 
                                Parcela.ValorRecebido, 
                                ContaReceber.DataRecebimento, 
                                ContaReceber.Pago,
                                Parcela.VendaID
                            FROM ContaReceber 
                            INNER JOIN Parcela ON ContaReceber.ParcelaID = Parcela.ParcelaID
                            INNER JOIN Venda ON Parcela.VendaID = Venda.VendaID
                            INNER JOIN Cliente ON Venda.ClienteID = Cliente.ClienteID
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
                        CalcularTotalDataGrid();
                        return dataTable;                       
                    }
                }
            }
        }

        // 5. Pesquisar por Contas Não Vencidas (DataVencimento >= @DataVencimento)

        public DataTable PesquisarContasNaoVencidas(DateTime dataVencimento)
        {
            string query = @"
                            SELECT
                                Cliente.NomeCliente, 
                                Parcela.NumeroParcela,
                                Parcela.ValorParcela, 
                                Parcela.DataVencimento, 
                                ContaReceber.SaldoRestante, 
                                Parcela.ValorRecebido, 
                                ContaReceber.DataRecebimento, 
                                ContaReceber.Pago,
                                Parcela.VendaID
                            FROM ContaReceber 
                            INNER JOIN Parcela ON ContaReceber.ParcelaID = Parcela.ParcelaID
                            INNER JOIN Venda ON Parcela.VendaID = Venda.VendaID
                            INNER JOIN Cliente ON Venda.ClienteID = Cliente.ClienteID
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
                        CalcularTotalDataGrid();
                        return dataTable;                       
                    }
                }
            }
        }

        private void ExportarExcel()
        {
            SaveFileDialog salvar = new SaveFileDialog();
            salvar.Filter = "Arquivo Excel (*.xlsx)|*.xlsx";
            salvar.Title = "Salvar como Excel";

            if (salvar.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(salvar.FileName);

                // Cria o pacote Excel
                using (var pacote = new ExcelPackage(fileInfo))
                {
                    // Cria uma nova planilha
                    var planilha = pacote.Workbook.Worksheets.Add("Dados");

                    // Preenche o cabeçalho (primeira linha)
                    for (int col = 0; col < dgvPesquisar.Columns.Count; col++)
                    {
                        planilha.Cells[1, col + 1].Value = dgvPesquisar.Columns[col].HeaderText;
                    }

                    // Preenche os dados
                    for (int row = 0; row < dgvPesquisar.Rows.Count; row++)
                    {
                        for (int col = 0; col < dgvPesquisar.Columns.Count; col++)
                        {
                            // Verifica se a célula não é nula
                            if (dgvPesquisar.Rows[row].Cells[col].Value != null)
                            {
                                planilha.Cells[row + 2, col + 1].Value = dgvPesquisar.Rows[row].Cells[col].Value.ToString();
                            }
                        }
                    }

                    // Salva o arquivo Excel
                    pacote.Save();
                }

                MessageBox.Show("Arquivo Excel salvo com sucesso!");
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
                    break;
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            // Limpa o DataGridView antes de aplicar um novo filtro
            dgvPesquisar.DataSource = null;
            dgvItensVenda.DataSource = null;

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
                dgvItensVenda.DataSource = null; // Limpa o DataGridView de Itens de Venda
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
        public void ExportarParaPDF(KryptonDataGridView dgv, string caminhoArquivo)
        {
            try
            {
                // Criando o documento PDF
                Document documento = new Document(PageSize.A4, 10, 10, 10, 10);
                PdfWriter.GetInstance(documento, new FileStream(caminhoArquivo, FileMode.Create));
                documento.Open();

                // Criando a tabela com base no número de colunas do DataGridView
                PdfPTable tabela = new PdfPTable(dgv.ColumnCount);
                tabela.WidthPercentage = 100;

                // Adicionando cabeçalhos
                foreach (DataGridViewColumn coluna in dgv.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(coluna.HeaderText));
                    cell.BackgroundColor = new BaseColor(240, 240, 240); // Cinza claro
                    tabela.AddCell(cell);
                }

                // Adicionando as linhas da tabela
                foreach (DataGridViewRow linha in dgv.Rows)
                {
                    if (!linha.IsNewRow) // Ignorar linha vazia
                    {
                        foreach (DataGridViewCell celula in linha.Cells)
                        {
                            tabela.AddCell(celula.Value?.ToString() ?? ""); // Adiciona os valores, evitando valores nulos
                        }
                    }
                }

                // Adicionando a tabela ao documento e fechando o PDF
                documento.Add(tabela);
                documento.Close();

                MessageBox.Show("PDF gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar PDF: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            SaveFileDialog salvar = new SaveFileDialog();
            salvar.Filter = "Arquivo PDF|*.pdf";
            salvar.Title = "Salvar como PDF";

            if (salvar.ShowDialog() == DialogResult.OK)
            {
                ExportarParaPDF(dgvPesquisar, salvar.FileName);                
            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            ExportarExcel();
        }

        private void dgvPesquisar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPesquisar.SelectedRows.Count > 0)
            {
                int vendaID = Convert.ToInt32(dgvPesquisar.SelectedRows[0].Cells["VendaID"].Value);
                CarregarItensVenda(vendaID);
            }
        }
        private void PersonalizarDataGridView()
        {
            //// Auto redimensionamento das colunas
            //dgvItensVenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Redimensiona automaticamente as colunas para ajustar ao conteúdo
            dgvItensVenda.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // Centralização dos campos "Referencia" e "Quantidade"
            dgvItensVenda.Columns["Referencia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvItensVenda.Columns["Quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Formatação em moeda para "PrecoUnitario" e "Subtotal"
            dgvItensVenda.Columns["PrecoUnitario"].DefaultCellStyle.Format = "C2"; // Formato moeda
            dgvItensVenda.Columns["Subtotal"].DefaultCellStyle.Format = "C2"; // Formato moeda

            // Centralização dos cabeçalhos de todas as colunas
            foreach (DataGridViewColumn column in dgvItensVenda.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        // Chame o método PersonalizarDataGridView após definir a fonte de dados do dgvItensVenda
        private void CarregarItensVenda(int vendaID)
        {
            string query = @"SELECT Produtos.Referencia, Produtos.NomeProduto, ItemVenda.Quantidade, 
                            ItemVenda.PrecoUnitario, ItemVenda.Subtotal, Produtos.Imagem
                     FROM ItemVenda 
                     INNER JOIN Produtos ON ItemVenda.ProdutoID = Produtos.ProdutoID 
                     WHERE VendaID = @VendaID";

            using (var connection = Conexao.Conex())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@VendaID", vendaID);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvItensVenda.DataSource = dataTable;

                // Personalize o DataGridView após definir a fonte de dados
                PersonalizarDataGridView();
            }
        }

    }
}
