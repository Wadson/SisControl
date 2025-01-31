using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace SisControl.Relatorios
{
    public partial class RelClienteContaAberta : SisControl.FrmModeloForm
    {
        public RelClienteContaAberta()
        {
            InitializeComponent();
        }
 
        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {            
        }

        private void RelClienteContaAberta_Load(object sender, EventArgs e)
        {

            // Obtém os dados do banco de dados
            DataTable dtClientes = ObterClientesContaAberta();

            // Adiciona os dados ao relatório
            Microsoft.Reporting.WinForms.ReportDataSource fonteDados = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dtClientes);

            reportViewer1.LocalReport.ReportPath = "ReportGeralAberta.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();  // Evita duplicação
            reportViewer1.LocalReport.DataSources.Add(fonteDados);
            reportViewer1.RefreshReport();
        }

        private void btnGerarRelatorio_Click_1(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private DataTable ObterClientesContaAberta()
        {
            DataTable dt = new DataTable();            

            using (var conexao =  Conexao.Conex())
            {
                string query = @"
                SELECT Cliente.NomeCliente, Parcela.NumeroParcela, Parcela.ValorParcela, 
                       Parcela.DataVencimento, Parcela.SaldoRestante
                FROM Produtos 
                INNER JOIN ItemVenda ON Produtos.ProdutoID = ItemVenda.ProdutoID 
                INNER JOIN Venda ON ItemVenda.VendaID = Venda.VendaID 
                INNER JOIN Parcela ON Venda.VendaID = Parcela.VendaID 
                INNER JOIN Cliente ON Venda.ClienteID = Cliente.ClienteID
                WHERE Parcela.Pago = 0";

                using (SqlCommand comando = new SqlCommand(query, conexao))
                {
                    conexao.Open();
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(dt);
                    }
                }
            }
            return dt;
        }
    }
}