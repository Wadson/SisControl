using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SisControl.Relatorios
{
    public partial class RelClienteContaAberta : SisControl.FrmModeloForm
    {
        public RelClienteContaAberta()
        {
            InitializeComponent();
        }

        private void RelClienteContaAberta_Load(object sender, EventArgs e)
        {
            // Configura o ReportViewer ao carregar o formulário
            this.reportViewerRelContaPorClienteAberta.RefreshReport();
        }

        public void PreencherDataSet(DataSet dataset, string nomeCliente)
        {
            using (var connection = Conexao.Conex())
            {
                connection.Open();
                string query = @"
                    SELECT 
                        Cliente.NomeCliente, 
                        Parcela.ValorParcela, 
                        Parcela.DataVencimento, 
                        Parcela.SaldoRestante, 
                        Parcela.Pago 
                    FROM 
                        Produtos 
                    INNER JOIN
                        ItemVenda ON Produtos.ProdutoID = ItemVenda.ProdutoID
                    INNER JOIN
                        Venda ON ItemVenda.VendaID = Venda.VendaID
                    INNER JOIN
                        Parcela ON Venda.VendaID = Parcela.VendaID
                    INNER JOIN
                        Cliente ON Venda.ClienteID = Cliente.ClienteID
                    WHERE 
                        Parcela.Pago = 0 
                        AND Cliente.NomeCliente LIKE '%' + @NomeCliente + '%'
                ";

                using (var adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@NomeCliente", nomeCliente);

                    // Preencher o DataSet com os dados retornados pela consulta
                    adapter.Fill(dataset, "ContaReceber");
                }
            }
        }

        private void ConfigurarReportViewer()
        {
            string nomeCliente = txtNomeCliente.Text.Trim();

            // Cria o DataSet
            DataSet dataset = new DataSet();
            // Chama o método para preencher o DataSet com dados do banco conforme consulta SQL
            PreencherDataSet(dataset, nomeCliente);

            // Verifica se o DataSet foi preenchido corretamente
            if (dataset.Tables["ContaReceber"].Rows.Count > 0)
            {
                // Define a fonte de dados para o ReportViewer
                ReportDataSource rds = new ReportDataSource("DataSetbdSisControl", dataset.Tables["ContaReceber"]);
                reportViewerRelContaPorClienteAberta.LocalReport.DataSources.Clear();
                reportViewerRelContaPorClienteAberta.LocalReport.DataSources.Add(rds);

                // Atualizar e exibir o relatório
                reportViewerRelContaPorClienteAberta.RefreshReport();
            }
            else
            {
                MessageBox.Show("Nenhum dado encontrado para exibir no relatório.");
            }
        }


        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            ConfigurarReportViewer();
        }
    }
}