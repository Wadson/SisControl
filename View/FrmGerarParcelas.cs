using SisControl.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace SisControl.View
{
    public partial class FrmGerarParcelas : FrmModeloForm  
    {
        public int clienteID;
        public int vendaID;
        public List<ParcelaModel> parcelas;
        public decimal valorParcela, valorTotal;
        public int numeroParcelas;
        public string nomeCliente = "";
        public DateTime dataVencimento;
        private string QueryParcela = "SELECT MAX(ParcelaID)  FROM Parcela";
        public FrmGerarParcelas()
        {
            InitializeComponent();
            
            this.valorTotal = valorTotal;
            this.numeroParcelas = numeroParcelas;
            this.parcelas = new List<ParcelaModel>();           
        }
        public int parcelaID { get; set; }

        // Método público para definir o valor de parcelaID
        public void SetParcelaID(int id)
        {
            // Atribui o valor passado do parâmetro id para a variável pública parcelaID
            parcelaID = id;
        }

        private void PersonalizarDataGridParcelas()
        {
            if (dgvParcelas.Columns.Count == 0)
                return; // Evita erro caso o DataGridView ainda não tenha colunas

            // Definir cabeçalhos das colunas
            dgvParcelas.Columns["ParcelaID"].HeaderText = "Cód. Parc.";
            dgvParcelas.Columns["ValorParcela"].HeaderText = "Vlr. Parc.";
            dgvParcelas.Columns["NumeroParcela"].HeaderText = "Nr. Parc.";
            dgvParcelas.Columns["DataVencimento"].HeaderText = "Dta. Vcto";

            // Formatar a exibição dos valores
            dgvParcelas.Columns["ValorParcela"].DefaultCellStyle.Format = "C2"; // Formato monetário
            dgvParcelas.Columns["DataVencimento"].DefaultCellStyle.Format = "dd/MM/yyyy"; // Formato de data

            // Centralizar colunas específicas
            dgvParcelas.Columns["ParcelaID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvParcelas.Columns["NumeroParcela"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvParcelas.Columns["DataVencimento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Definir tamanhos das colunas
            dgvParcelas.Columns["ParcelaID"].Width = 90;
            dgvParcelas.Columns["ValorParcela"].Width = 90;
            dgvParcelas.Columns["NumeroParcela"].Width = 70;
            dgvParcelas.Columns["DataVencimento"].Width = 100;

            // Ocultar a coluna ParcelaID se necessário
            dgvParcelas.Columns["ParcelaID"].Visible = false;
        }

        private void GerarParcelas()
        {
            try
            {
                int dias = Convert.ToInt32(txtDias.Text);
                int numeroParcelas = Convert.ToInt32(txtQtdParcelas.Text);
                decimal valorTotal = Convert.ToDecimal(txtTotal.Text);
                DateTime dataVencimento = Convert.ToDateTime(dtPrimeiraParc.Value).Date;
                decimal valorParcela = Math.Round(valorTotal / numeroParcelas, 2);

                DataTable dt = new DataTable();
                dt.Columns.Add("ParcelaID", typeof(int));
                dt.Columns.Add("ValorParcela", typeof(decimal));
                dt.Columns.Add("NumeroParcela", typeof(int));
                dt.Columns.Add("DataVencimento", typeof(DateTime));

                // Gerar as parcelas
                int parcelaID = Utilitario.GerarNovoCodigoID("ParcelaID", "Parcela");
                for (var i = 0; i < numeroParcelas; i++)
                {
                    dt.Rows.Add(parcelaID, valorParcela, i + 1, dataVencimento.AddDays(i * dias).Date);
                    parcelaID++;
                }

                // Atualizar o DataGridView local
                dgvParcelas.DataSource = dt;

                // Personalizar o DataGridView
                PersonalizarDataGridParcelas();
                // Passar os dados para o FrmPedido
                FrmPedido frmPedidos = Application.OpenForms.OfType<FrmPedido>().FirstOrDefault();
                if (frmPedidos != null)
                {
                    frmPedidos.ReceberDadosParcelas(dt);
                }
                else
                {
                    MessageBox.Show("FrmPedido não está aberto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar parcelas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void GerarParcelas()
        //{
        //    try
        //    {
        //        int dias = Convert.ToInt32(txtDias.Text);
        //        string nomeCliente = txtNomeCliente.Text;
        //        int numeroParcelas = Convert.ToInt32(txtQtdParcelas.Text);
        //        decimal valorTotal = Convert.ToDecimal(txtTotal.Text);
        //        DateTime dataVencimento = Convert.ToDateTime(dtPrimeiraParc.Value).Date;
        //        decimal valorParcela = Math.Round(valorTotal / numeroParcelas, 2);

        //        DataTable dt = dataGrid_Parcelas.DataSource as DataTable;

        //        if (dt == null || dt.Columns.Count == 0)
        //        {
        //            dt = new DataTable();
        //            dt.Columns.Add("ParcelaID", typeof(int));
        //            dt.Columns.Add("ValorParcela", typeof(decimal));
        //            dt.Columns.Add("NumeroParcela", typeof(int));
        //            dt.Columns.Add("DataVencimento", typeof(DateTime));

        //            dataGrid_Parcelas.DataSource = dt;
        //        }
        //        else
        //        {
        //            // Desvincula Temporariamente
        //            dataGrid_Parcelas.DataSource = null;

        //            dt.Rows.Clear();

        //            // Reassocia a fonte de dados
        //            dataGrid_Parcelas.DataSource = dt;
        //        }

        //        int parcelaID = Utilitario.GerarNovoCodigoID("ParcelaID", "Parcela");
        //        for (var i = 0; i < numeroParcelas; i++)
        //        {
        //            dt.Rows.Add(parcelaID, valorParcela, i + 1, dataVencimento.AddDays(i * dias).Date);
        //            parcelaID++;
        //        }

        //        FrmPedido frmPedidos = Application.OpenForms.OfType<FrmPedido>().FirstOrDefault();

        //        if (frmPedidos != null)
        //        {
        //            frmPedidos.ReceberDadosParcelas(dt);
        //        }
        //        else
        //        {
        //            MessageBox.Show("FrmVendas não está aberto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erro ao gerar parcelas: " + ex.Message + "\n" + ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


        public List<ParcelaModel> ObterParcelas()
        {
            return parcelas;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {           
        }

        private void kryptonTextBox1_Leave(object sender, EventArgs e)
        {
            GerarParcelas();
        }

        private void txtQtdParcelas_Leave(object sender, EventArgs e)
        {
            GerarParcelas();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGerarParcelas_Click(object sender, EventArgs e)
        {
            GerarParcelas();
        }
    }
}
