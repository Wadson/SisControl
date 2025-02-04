using ComponentFactory.Krypton.Toolkit;
using SisControl.BLL;
using SisControl.DALL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace SisControl.View
{
    public partial class FrmManutProduto : SisControl.FrmBaseManutencao
    {
        private new string StatusOperacao;
       
        public FrmManutProduto(string statusOperacao)
        {            
            InitializeComponent();
            this.StatusOperacao = statusOperacao;
        }

        public void HabilitarTimer(bool habilitar)
        {
            timer1.Enabled = habilitar;
        }
        public void ListarProduto()
        {
            ProdutoBLL objetoBll = new ProdutoBLL();
            dataGridPesquisar.DataSource = objetoBll.Listar();
            PersonalizarDataGridView(dataGridPesquisar);
        }
        public void PersonalizarDataGridView(KryptonDataGridView dgv)
        {
            // Renomear colunas
            dgv.Columns[0].Name = "ProdutoID";
            dgv.Columns[1].Name = "Referencia";
            dgv.Columns[2].Name = "Produto";
            dgv.Columns[3].Name = "Preco de Custo";
            dgv.Columns[4].Name = "Lucro";
            dgv.Columns[5].Name = "Preco De Venda";
            dgv.Columns[6].Name = "Estoque";
            dgv.Columns[7].Name = "Dta. Entrada";
            dgv.Columns[8].Name = "Status";            
            
          
            // Ajustar colunas automaticamente
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Tornar o grid somente leitura
            dgv.ReadOnly = true;

            // Centralizar colunas de IDs e Quantidade
            dgv.Columns["ProdutoID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["Estoque"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Ocultar a coluna ProdutoID
            dgv.Columns["ProdutoID"].Visible = false;
        }

        private void CarregaDados()
        {
            FrmCadProdutos frm = new  FrmCadProdutos(StatusOperacao);

            if (StatusOperacao == "NOVO")
            {
                frm.Text = "SISCONTROL - NOVO CADASTRO DE PRODUTOS";
                StatusOperacao = "NOVO";
                frm.ShowDialog();

                ((FrmManutProduto)System.Windows.Forms.Application.OpenForms["FrmManutProduto"]).HabilitarTimer(true);
            }
            if (StatusOperacao == "ALTERAR")
            {
                try
                {
                    // Verificar se a DataGridView contém alguma linha
                    if (dataGridPesquisar.Rows.Count == 0)
                    {
                        // Lançar exceção personalizada
                        //throw new Exception("A DataGridView está vazia. Não há dados para serem processados.");
                        MessageBox.Show("A DataGridView está vazia. Não há dados para serem processados.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                    else
                    {
                        // Exemplo: Acessar a primeira célula de cada linha
                        //  var valor = row.Cells[0].Value;
                        frm.txtProdutoID.Text = dataGridPesquisar.CurrentRow.Cells["ProdutoID"].Value.ToString();
                        frm.txtNomeProduto.Text = dataGridPesquisar.CurrentRow.Cells["Produto"].Value.ToString();
                        frm.txtPrecoCusto.Text = dataGridPesquisar.CurrentRow.Cells["Preco de Custo"].Value.ToString();
                        frm.txtLucro.Text = dataGridPesquisar.CurrentRow.Cells["Lucro"].Value.ToString();
                        frm.txtPrecoDeVenda.Text = dataGridPesquisar.CurrentRow.Cells["Preco de Venda"].Value.ToString();
                        frm.txtEstoque.Text = dataGridPesquisar.CurrentRow.Cells["Estoque"].Value.ToString();                        
                        frm.dtpDataDeEntrada.Text = dataGridPesquisar.CurrentRow.Cells["Dta. Entrada"].Value.ToString();
                        frm.cmbStatus.Text = dataGridPesquisar.CurrentRow.Cells["Status"].Value.ToString();
                        frm.txtReferencia.Text = dataGridPesquisar.CurrentRow.Cells["Referencia"].Value.ToString();                       
                        

                        frm.Text = "SISCONTROL - ALTERAR REGISTRO";
                        StatusOperacao = "ALTERAR";                        
                        frm.btnNovo.Enabled = false;
                        frm.btnSalva.Text = "&Alterar";
                        frm.ShowDialog();
                        ((FrmManutProduto)System.Windows.Forms.Application.OpenForms["FrmManutProduto"]).HabilitarTimer(true);
                    }
                    
                }
                catch (Exception ex)
                {
                    // Exibir uma mensagem de erro para o usuário
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (StatusOperacao == "EXCLUSÃO")
            {
                try
                {
                    // Verificar se a DataGridView contém alguma linha
                    if (dataGridPesquisar.Rows.Count == 0)
                    {
                        // Lançar exceção personalizada
                        //throw new Exception("A DataGridView está vazia. Não há dados para serem processados.");
                        MessageBox.Show("A DataGridView está vazia. Não há dados para serem processados.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        // Exemplo: Acessar a primeira célula de cada linha
                        //  var valor = row.Cells[0].Value;
                        frm.txtProdutoID.Text = dataGridPesquisar.CurrentRow.Cells["ProdutoID"].Value.ToString();
                        frm.txtNomeProduto.Text = dataGridPesquisar.CurrentRow.Cells["Produto"].Value.ToString();
                        frm.txtPrecoCusto.Text = dataGridPesquisar.CurrentRow.Cells["Preco de Custo"].Value.ToString();
                        frm.txtLucro.Text = dataGridPesquisar.CurrentRow.Cells["Lucro"].Value.ToString();
                        frm.txtPrecoDeVenda.Text = dataGridPesquisar.CurrentRow.Cells["Preco de Venda"].Value.ToString();
                        frm.txtEstoque.Text = dataGridPesquisar.CurrentRow.Cells["Estoque"].Value.ToString();
                        frm.dtpDataDeEntrada.Text = dataGridPesquisar.CurrentRow.Cells["Dta. Entrada"].Value.ToString();
                        frm.cmbStatus.Text = dataGridPesquisar.CurrentRow.Cells["Status"].Value.ToString();
                        frm.txtReferencia.Text = dataGridPesquisar.CurrentRow.Cells["Referencia"].Value.ToString();

                        frm.Text = "SISCONTROL - EXCLUSÃO DE REGISTRO";
                        frm.btnSalva.Text = "&Excluir";

                        frm.btnNovo.Enabled = false;                       

                        // Desabilitar os campos
                        frm.txtProdutoID.Enabled = false;
                        frm.txtNomeProduto.Enabled = false;
                        frm.txtReferencia.Enabled = false;                      
                        frm.txtPrecoCusto.Enabled = false;
                        frm.txtLucro.Enabled = false;
                        frm.txtPrecoDeVenda.Enabled = false;
                        frm.dtpDataDeEntrada.Enabled = false;   
                        frm.cmbStatus.Enabled = false;
                        frm.txtReferencia.Enabled = false;
                       

                        frm.ShowDialog();
                        ((FrmManutProduto)System.Windows.Forms.Application.OpenForms["FrmManutProduto"]).HabilitarTimer(true);
                    }                   
                }
                catch (Exception ex)
                {
                    // Exibir uma mensagem de erro para o usuário
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }           
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";
            ProdutosDal objetoDal = new ProdutosDal();

            dataGridPesquisar.DataSource = objetoDal.PesquisarProdutoPorNome(nome);
            PersonalizarDataGridView(dataGridPesquisar);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            StatusOperacao = "NOVO";
            CarregaDados();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            StatusOperacao = "ALTERAR";
            CarregaDados();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            StatusOperacao = "EXCLUSÃO";
            CarregaDados();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ListarProduto();
            timer1.Enabled = false;
        }

        private void FrmManutProduto_Load(object sender, EventArgs e)
        {
            ListarProduto();
        }

        private void dataGridPesquisar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dataGridPesquisar.Columns[e.ColumnIndex].Name == "PrecoCusto" || dataGridPesquisar.Columns[e.ColumnIndex].Name == "PrecoVenda") && e.Value != null)
            {
                decimal valor = (decimal)e.Value;
                e.Value = valor.ToString("C", CultureInfo.CurrentCulture);
                e.FormattingApplied = true;
            }
        }
    }
}
