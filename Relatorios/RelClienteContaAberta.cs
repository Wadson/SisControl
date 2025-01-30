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
 
        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {            
        }

        private void RelClienteContaAberta_Load(object sender, EventArgs e)
        {
            
            // Configure a origem de dados do relatório aqui
            DataSet dataset = new DataSet();
            // Adicione aqui o código para preencher o dataset com seus dados

            // Crie uma instância do ReportDataSource
            ReportDataSource rds = new ReportDataSource("DataSet2", dataset.Tables[0]);

            // Adicione o ReportDataSource ao reportViewer
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);

            // Atualize o relatório
            this.reportViewer1.RefreshReport();
        }
    }
}