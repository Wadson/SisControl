using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Microsoft.Win32;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
using SisControl.DALL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static SisControl.View.FrmContaReceberr;

namespace SisControl.View
{
    public partial class FrmContaReceberr : SisControl.FrmModeloForm
    {
        private Parcela _parcela;
        public int clienteID { get; set; }
        private FrmBaixarConta frmBaixarConta;
        public int vendaID { get; set; }

        public FrmContaReceberr(Parcela parcela)
        {
            InitializeComponent();

            _parcela = parcela;
            ListarContaReceber();
            ConfigurarDgvContasReceber();            

            // No construtor do formulário ou no método de inicialização
            dgvContasReceber.SelectionChanged += dgvContasReceber_SelectionChanged;

        }        
        public void PersonalizarDataGridViewPagParciais()
        {
            if (dgvContasReceber.Columns.Count >= 4)
            {
                // Renomear colunas
                //dgvContasReceber.Columns["PagamentoParcialID"].HeaderText = "Código";
                //dgvContasReceber.Columns["ParcelaID"].HeaderText = "ParcelaID";
                //dgvContasReceber.Columns["ValorPago"].HeaderText = "Vlr. Pago";
                //dgvContasReceber.Columns["DataPagamento"].HeaderText = "Dta. Pgto";


                // Ajustar colunas automaticamente
                dgvContasReceber.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Tornar o grid somente leitura
                dgvContasReceber.ReadOnly = true;

                // Ocultar as colunas PagamentoParcialID e ParcelaID
                //dgvContasReceber.Columns["PagamentoParcialID"].Visible = false;
                //dgvContasReceber.Columns["ParcelaID"].Visible = false;
            }
            else
            {
                MessageBox.Show("Erro: O DataGridView não possui colunas suficientes para personalizar.");
            }
        }
        private void ConfigurarDgvContasReceber()
        {
            // Inicializar o DataGridView se ainda não estiver feito
            if (dgvContasReceber == null)
            {
                dgvContasReceber = new KryptonDataGridView();
            }

            dgvContasReceber.Columns["ParcelaID"].HeaderText = "Código";
            dgvContasReceber.Columns["ValorParcela"].HeaderText = "Vlr Parc;";
            dgvContasReceber.Columns["NumeroParcela"].HeaderText = "Nº Parc.";
            dgvContasReceber.Columns["SaldoRestante"].HeaderText = "Saldo Rest.";
            dgvContasReceber.Columns["DataVencimento"].HeaderText = "Dt. Vencto";
            dgvContasReceber.Columns["VendaID"].HeaderText = "VendaID";
            dgvContasReceber.Columns["Pago"].HeaderText = "Pago";
            dgvContasReceber.Columns["ValorRecebido"].HeaderText = "Vlr Rec.";
            dgvContasReceber.Columns["ClienteID"].HeaderText = "ClienteID";
            dgvContasReceber.Columns["NomeCliente"].HeaderText = "Nome do Cliente";


            // Verifique se as colunas existem antes de tentar configurá-las
            if (dgvContasReceber.Columns.Contains("ParcelaID"))
            {
                dgvContasReceber.Columns["ParcelaID"].Visible = false;
            }

            if (dgvContasReceber.Columns.Contains("VendaID"))
            {
                dgvContasReceber.Columns["VendaID"].Visible = false;
            }

            if (dgvContasReceber.Columns.Contains("ClienteID"))
            {
                dgvContasReceber.Columns["ClienteID"].Visible = false;
            }

            if (dgvContasReceber.Columns.Contains("NumeroParcela"))
            {
                // Centralizar coluna
                dgvContasReceber.Columns["NumeroParcela"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Ajustar colunas automaticamente
            dgvContasReceber.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Tornar o grid somente leitura
            dgvContasReceber.ReadOnly = true;
        }



        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtProdutoID;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNomeProduto;

        public object Value { get; }


        private void RealizarPagamento(int id)
        {
            // Simulação de atualização no banco de dados ou na lógica de negócios
            Log($"Pagamento realizado para a conta ID: {id}");

            // Atualiza a interface
            foreach (DataGridViewRow row in dgvContasReceber.Rows)
            {
                if (Convert.ToInt32(row.Cells["Id"].Value) == id)
                {
                    row.Cells["Pago"].Value = true;
                }
            }

            MessageBox.Show($"Pagamento realizado para a conta ID: {id}");
        }

        // Método de log (como previamente discutido)
        private void Log(string message)
        {
            File.AppendAllText("log.txt", $"{DateTime.Now}: {message}\n");
        }
        private void AbrirFrmLocalizarCliente()
        {
            // Cria uma instância do frmLocalizarCliente e define o Owner como o FrmPedidoVendaNovo
            FrmLocalizarCliente frmLocalizarCliente = new FrmLocalizarCliente(this)
            {
                Owner = this
            };
            frmLocalizarCliente.ShowDialog();
            frmLocalizarCliente.Text = "Localizar Clientes";
        }


        private void LocalizarContaPorPeriodo()
        {
            string query = @"SELECT Parcela.ParcelaID, Parcela.ValorParcela,  Parcela.NumeroParcela, Parcela.SaldoRestante,  Parcela.DataVencimento,           
                        Parcela.VendaID, Parcela.Pago, Parcela.ValorRecebido, Cliente.ClienteID, Cliente.NomeCliente               
                    FROM  Parcela               
                    INNER JOIN Parcela                          
                    INNER JOIN Venda                            
                        ON Parcela.VendaID = Venda.VendaID
                    INNER JOIN Cliente                           
                        ON Venda.ClienteID = Cliente.ClienteID
                    WHERE  Parcela.DataVencimento BETWEEN @DataVencimentoInicio AND @DataVencimentoFim  -- Filtrar por período de vencimento
                        AND Parcela.Pago = 0            -- Filtrar apenas parcelas não pagas
                    ORDER BY  Parcela.DataVencimento DESC;      -- Ordenar por data de vencimento em ordem decrescente";



            string nomeParametroInicio = "@DataVencimentoInicio";
            string nomeParametroFim = "@DataVencimentoFim";
            DateTime dataVencimentoInicio = DateTime.Parse(dtpDataVencimentoInicio.Text);
            DateTime dataVencimentoFim = DateTime.Parse(dtpDataVencimentoFim.Text);

            Utilitario.PesquisarPorPeriodo(query, nomeParametroInicio, dataVencimentoInicio, nomeParametroFim, dataVencimentoFim, dgvContasReceber);
        }

        private void LocalizarConta()
        {
            string selectedText = cmbFiltro.Text;

            if (selectedText == "Status")
            {
                LocalizarContaPorStatus();
            }
            else if (selectedText == "Período")
            {
                LocalizarContaPorPeriodo();
            }
            else if (selectedText == "Nome" && clienteID.ToString() != string.Empty)
            {
                LocalizarContaPorNome();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um critério de filtro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ListarContaReceber();
            }
            AtualizarContagemRegistros();
        }
        public void ListarContaReceber()
        {
            string query = @"
                SELECT
                    Parcela.ParcelaID,   
                    Parcela.ValorParcela, 
                    Parcela.NumeroParcela,   
                    Parcela.SaldoRestante,     
                    Parcela.DataVencimento, 
                    Parcela.VendaID,           
                    Parcela.Pago,              
                    Parcela.ValorRecebido,         
                    Cliente.ClienteID,              
                    Cliente.NomeCliente            
                FROM Parcela                          
                INNER JOIN Venda ON Parcela.VendaID = Venda.VendaID
                INNER JOIN Cliente ON Venda.ClienteID = Cliente.ClienteID
                
                WHERE Parcela.Pago = 0";

            string nomeParametro = "@ClienteID";
            string nomePesquisar = clienteID.ToString();
            Utilitario.PesquisarPorNome(query, nomeParametro, nomePesquisar, dgvContasReceber);
            CalcularTotalDataGrid();
        }

        private void AtualizarContagemRegistros()
        {
            int totalRegistros = Utilitario.ContaRegistros(dgvContasReceber);
            lblTotalRegistros.Text = $"Total de registros: {totalRegistros}";
        }
        private void CarregarContasAReceber(string cliente = "", DateTime? dataVencimentoInicio = null, DateTime? dataVencimentoFim = null)
        {
            var connection = Conexao.Conex();
            using (connection)
            {
                // Construir a consulta SQL com filtros opcionais
                string query = @"SELECT * Parcela;
";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Cliente", cliente);
                command.Parameters.AddWithValue("@DataVencimentoInicio", dataVencimentoInicio.HasValue ? (object)dataVencimentoInicio.Value : DBNull.Value);
                command.Parameters.AddWithValue("@DataVencimentoFim", dataVencimentoFim.HasValue ? (object)dataVencimentoFim.Value : DBNull.Value);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvContasReceber.DataSource = dataTable;
            }
        }
        public void BaixarParcelaEContaReceber(int parcelaID, decimal valorRecebido, DateTime dataRecebimento, int formaPgtoID)
        {
            string connectionString = "sua_connection_string";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Iniciar uma transação para garantir a integridade das atualizações
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Atualizar a tabela Parcelas
                        string queryParcelas = @"UPDATE Parcela
                                         SET ValorRecebido = @ValorRecebido,
                                             Pago = CASE WHEN ValorRecebido >= ValorParcela THEN 1 ELSE 0 END
                                         WHERE ParcelaID = @ParcelaID";

                        using (SqlCommand cmdParcelas = new SqlCommand(queryParcelas, conn, transaction))
                        {
                            cmdParcelas.Parameters.AddWithValue("@ParcelaID", parcelaID);
                            cmdParcelas.Parameters.AddWithValue("@ValorRecebido", valorRecebido);

                            cmdParcelas.ExecuteNonQuery();
                        }

                        // Atualizar a tabela Parcela
                        string queryContaReceber = @"UPDATE Parcela
                                        SET DataVencimento = @DataRecebimento, 
                                            ValorRecebido = @ValorRecebido, 
                                            Pago = CASE WHEN SaldoRestante - @ValorRecebido <= 0 THEN 1 ELSE 0 END, 
                                            FormaPagamento = @FormaPgtoID
                                        WHERE ParcelaID = @ParcelaID;";

                        using (SqlCommand cmdContaReceber = new SqlCommand(queryContaReceber, conn, transaction))
                        {
                            cmdContaReceber.Parameters.AddWithValue("@ParcelaID", parcelaID);
                            cmdContaReceber.Parameters.AddWithValue("@DataRecebimento", dataRecebimento);
                            cmdContaReceber.Parameters.AddWithValue("@ValorRecebido", valorRecebido);
                            cmdContaReceber.Parameters.AddWithValue("@FormaPgtoID", formaPgtoID);

                            cmdContaReceber.ExecuteNonQuery();
                        }

                        // Commit a transação
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Rollback a transação em caso de erro
                        transaction.Rollback();
                        throw new Exception("Erro ao baixar a parcela e conta a receber: " + ex.Message);
                    }
                }
            }
        }


        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {
            FiltrarContasAReceber();
        }

        private void dtpDataVencimentoInicio_ValueChanged(object sender, EventArgs e)
        {
            FiltrarContasAReceber();
        }

        private void dtpDataVencimentoFim_ValueChanged(object sender, EventArgs e)
        {
            FiltrarContasAReceber();
        }

        private void FiltrarContasAReceber()
        {
            string cliente = txtNomeCliente.Text;
            DateTime? dataVencimentoInicio = dtpDataVencimentoInicio.Checked ? (DateTime?)dtpDataVencimentoInicio.Value : null;
            DateTime? dataVencimentoFim = dtpDataVencimentoFim.Checked ? (DateTime?)dtpDataVencimentoFim.Value : null;

            CarregarContasAReceber(cliente, dataVencimentoInicio, dataVencimentoFim);
        }

        private void FrmContaReceber_Load(object sender, EventArgs e)
        {
            ListarContaReceber();
        }

        private void txtClienteID_TextChanged(object sender, EventArgs e)
        {
            LocalizarContaPorNome();
        }

        private void kryptonGroupBox1_Panel_Paint(object sender, PaintEventArgs e)
        {
        }
        private void cmbFiltro_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedText = cmbFiltro.Text;

            if (selectedText == "Status")
            {
                btnFiltrar.Visible = true;
                gbStatus.Visible = true;
                gbNome.Visible = false;
                gbPeriodo.Visible = false;
                btnFiltrar.Location = new Point(353, 76);                
            }
            else if (selectedText == "Período")
            {
                btnFiltrar.Visible = true;
                gbPeriodo.Visible = true;
                gbStatus.Visible = false;
                gbNome.Visible = false;
                btnFiltrar.Location = new Point(577, 74);                
            }
            else if (selectedText == "Nome")
            {
                btnFiltrar.Visible = true;
                gbNome.Visible = true;
                gbPeriodo.Visible = false;
                gbStatus.Visible = false;
                //btnFiltrar.Location = new Point(758, 96);
                btnFiltrar.Visible = false;
            }
            else
            {
                btnFiltrar.Visible = false;
                gbStatus.Visible = false;
                gbPeriodo.Visible = false;
                gbNome.Visible = false;
                ListarContaReceber();               
                
                Utilitario.LimpaCampoKrypton(this);
                LimparDataGrid();
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            LocalizarConta();
            if (dgvContasReceber.Rows.Count == 0)
            {
                dgvPagamentosParciais.DataSource = null;
                dgvPagamentosParciais.DataSource = new List<object>(); // Definir como uma lista vazia
            }

            CalcularTotalDataGrid();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvContasReceber_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvContasReceber.SelectedRows.Count > 0)
                {
                    // Verifica se a coluna "ClienteID" existe e está preenchida
                    if (dgvContasReceber.Columns.Contains("ClienteID") &&
                        dgvContasReceber.SelectedRows[0].Cells["ClienteID"].Value != null)
                    {
                        int clienteID = Convert.ToInt32(dgvContasReceber.SelectedRows[0].Cells["ClienteID"].Value);
                        // Usar o clienteID para buscar informações adicionais
                        lblNomeCliente.Text = dgvContasReceber.SelectedRows[0].Cells["NomeCliente"].Value.ToString();

                        // Listar Pagametnos Parciais através da ParcelaID na linha selecionada no dgvContasReceber
                        int parcelaID = Convert.ToInt32(dgvContasReceber.SelectedRows[0].Cells["ParcelaID"].Value);
                        ListarPagamentosParciais(parcelaID);
                    }
                    else
                    {
                        MessageBox.Show("ClienteID não encontrado na linha selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar a conta: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Recalcular total do DataGridView (se necessário)
                CalcularTotalDataGrid();
            }
        }

        private void CalcularTotalDataGrid()
        {
            try
            {
                // Calcular o total dos valores Não pagos na coluna "SaldoRestante"
                decimal totalEmAberto = Utilitario.SomarValoresDataGrid(dgvContasReceber, "SaldoRestante");

                // Atualizar a label com o total calculado
                txtTotalEmAberto.Text = $"R$ {totalEmAberto:F2}";


                // Calcular o total dos valores na coluna "ValorParcela"
                decimal totalPago = Utilitario.SomarValoresDataGrid(dgvContasReceber, "ValorRecebido");

                // Atualizar a label com o total calculado
                txtTotalPago.Text = $"R$ {totalPago:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao calcular o total: " + ex.Message);
            }
        }
        private void ListarPagamentosParciais(int parcelaID)
        {
            try
            {
                string query = @"SELECT PagamentoParcialID, ParcelaID,  ValorPago,  DataPagamento
        FROM  PagamentosParciais  WHERE ParcelaID = @ParcelaID";

                string nomeParametro = "@ParcelaID";
                string valorParametro = parcelaID.ToString();
                Utilitario.PesquisarPorNomeMensagemSuprimida(query, nomeParametro, valorParametro, dgvPagamentosParciais);

                // Verifica se há dados no DataGridView antes de personalizar
                if (dgvPagamentosParciais.Rows.Count > 0)
                {
                    PersonalizarDataGridViewPagParciais();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar pagamentos parciais: " + ex.Message);
            }
        }

        //******OUTRO MÉTODO
        public class Parcela
        {
            public int ParcelaID { get; set; }
            public int NumeroParcela { get; set; }
            public decimal ValorParcela { get; set; }
            public DateTime DataVencimento { get; set; }
            public decimal SaldoRestante { get; set; }
            public decimal ValorPago { get; set; }
            public bool Pago { get; set; }
        }
        private void AbrirFormBaixrConta()
        {
            if (dgvContasReceber.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvContasReceber.SelectedRows[0];

                Parcela parcela = new Parcela
                {
                    ParcelaID = Convert.ToInt32(row.Cells["ParcelaID"].Value),
                    NumeroParcela = Convert.ToInt32(row.Cells["NumeroParcela"].Value),
                    ValorParcela = Convert.ToDecimal(row.Cells["ValorParcela"].Value),
                    DataVencimento = Convert.ToDateTime(row.Cells["DataVencimento"].Value),
                    SaldoRestante = Convert.ToDecimal(row.Cells["SaldoRestante"].Value),
                    Pago = Convert.ToBoolean(row.Cells["Pago"].Value)
                };

                //Parcela parcela = new Parcela(); // Obtenha a instância de Parcela conforme necessário
                frmBaixarConta = new FrmBaixarConta(parcela);
                frmBaixarConta.ShowDialog();
                ListarContaReceber();
            }
            else
            {
                MessageBox.Show("Selecione uma parcela para baixar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnReceberConta_Click(object sender, EventArgs e)
        {
            AbrirFormBaixrConta();
        }
        private void ExcluirTudo()
        {
            VendaDAL vendaDAL = new VendaDAL();
            if (dgvContasReceber.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja excluir a conta selecionada?", "Excluir conta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int parcelaID = Convert.ToInt32(dgvContasReceber.SelectedRows[0].Cells["ParcelaID"].Value);
                        int vendaID = Convert.ToInt32(dgvContasReceber.SelectedRows[0].Cells["VendaID"].Value);

                        // 1. Excluir os itens de venda associados
                        ItemVendaDAL itemVendaDAL = new ItemVendaDAL();
                        itemVendaDAL.ExcluirItensPorVendaID(vendaID);

                        // 2. Excluir pagamentos parciais relacionados
                        PagamentoParcialDal pagamentoParcialDAL = new PagamentoParcialDal();
                        pagamentoParcialDAL.ExcluirPagamentosParciaisPorParcelaID(parcelaID);
                                              
                        // 4. Excluir a parcela
                        ParcelaDAL parcelaDAL = new ParcelaDAL();
                        parcelaDAL.DeleteParcela(parcelaID);

                        // 5. Excluir a venda
                        vendaDAL.DeleteVenda(vendaID);

                        MessageBox.Show("Conta excluída com sucesso.", "Excluir conta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarContaReceber();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir a conta: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma conta para excluir.", "Excluir conta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnExcluirConta_Click(object sender, EventArgs e)
        {
            ExcluirTudo();
        }

        private void LimparDataGrid()
        {
            dgvContasReceber.DataSource = null;
            dgvPagamentosParciais.DataSource = null;
            dgvPagamentosParciais.Rows.Clear();
            dgvContasReceber.Rows.Clear();
        }

        private void LocalizarContaPorNome()
        {
            string clausulaWhere = "Parcela.Pago = 0 AND Cliente.NomeCliente = @NomeCliente";
            var parametros = new Dictionary<string, object>
            {
                   { "@NomeCliente", txtNomeCliente.Text }
            };

            LocalizarContas(clausulaWhere, parametros, dgvContasReceber);
        }
        private void LocalizarContaPorStatus()
        {
            string StatusConta = "";
            string nomeParametro = "@Pago";

            if (radioBtnAberto.Checked == true)
            {
                StatusConta = "0";
            }
            if (radioBtnPago.Checked == true)
            {
                StatusConta = "1";
            }
            string clausulaWhere = "Parcela.Pago = @Pago";
            var parametros = new Dictionary<string, object>
            {
                   { "@Pago", StatusConta }
            };
            //Utilitario.PesquisarPorNome(query, nomeParametro, StatusConta, dgvContasReceber);
            LocalizarContas(clausulaWhere, parametros, dgvContasReceber);
        }
      
        private void LocalizarContas(string clausulaWhere, Dictionary<string, object> parametros, DataGridView grid)
        {
            string query = $@"
                SELECT
                    Parcela.ParcelaID,   
                    Parcela.ValorParcela, 
                    Parcela.NumeroParcela,   
                    Parcela.SaldoRestante,     
                    Parcela.DataVencimento, 
                    Parcela.VendaID,           
                    Parcela.Pago,              
                    Parcela.ValorRecebido,         
                    Cliente.ClienteID,              
                    Cliente.NomeCliente            
                FROM Parcela                          
                INNER JOIN Venda ON Parcela.VendaID = Venda.VendaID
                INNER JOIN Cliente ON Venda.ClienteID = Cliente.ClienteID

            { (string.IsNullOrWhiteSpace(clausulaWhere) ? "" : "WHERE " + clausulaWhere)}";

            Utilitario.PesquisarComParametros(query, parametros, grid);
        }


            // 6️ Pagamento das Parcelas
            //O pagamento das parcelas deve ser feito em outra tela de Contas a Receber.
            //Quando uma parcela for paga, marque o campo Pago = 0;


        private void RegistrarPagamento(int parcelaID, decimal valorPago)
        {
            using (var connection = Conexao.Conex())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string updateParcela = "UPDATE Parcela SET ValorRecebido += @ValorPago, SaldoRestante -= @ValorPago, Pago = CASE WHEN SaldoRestante = 0 THEN 1 ELSE 0 END WHERE ParcelaID = @ParcelaID";
                        using (SqlCommand cmd = new SqlCommand(updateParcela, connection, transaction))
                        {
                            cmd.Parameters.Add("@ParcelaID", SqlDbType.Int).Value = parcelaID;
                            cmd.Parameters.Add("@ValorPago", SqlDbType.Decimal).Value = valorPago;
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                    }
                }
            }
        }

        private void btnLocalizarCliente_Click(object sender, EventArgs e)
        {
            AbrirFrmLocalizarCliente();
        }

        private void txtNomeCliente_TextChanged_1(object sender, EventArgs e)
        {
            LocalizarConta();
            if (dgvContasReceber.Rows.Count == 0)
            {
                dgvPagamentosParciais.DataSource = null;
                dgvPagamentosParciais.DataSource = new List<object>(); // Definir como uma lista vazia
            }

            CalcularTotalDataGrid();
        }
    }
}

