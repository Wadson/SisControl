using SisControl.BLL;
using SisControl.DALL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static SisControl.View.FrmContaReceberr;

namespace SisControl.View
{
    public partial class FrmExclusaoOrfao : SisControl.FrmModeloForm
    {
        public FrmExclusaoOrfao()
        {
            InitializeComponent();
        }

        private void ExcluirTudo()
        {
            VendaDAL vendaDAL = new VendaDAL();
           
        }
        public void ListarVenda()
        {
            VendaDAL vendaDAL = new VendaDAL();            
            dgvVendas.DataSource = vendaDAL.ListarVenda();
            
        }
        public void ListarPagamentosParciais()
        {
            PagamentoParcialDal pagamentoParcialDAL = new PagamentoParcialDal();
            dgvPagamentosParciais.DataSource = pagamentoParcialDAL.ListarPagamentosParciais();
        }
        public void ListarContaReceber()
        {
            ContaReceberDAL contaReceberDAL = new ContaReceberDAL();
            dgvContaReceber.DataSource = contaReceberDAL.ListarContasReceber();
        }
        public void ListarParcelas()
        {
            ParcelaDAL parcelaDAL = new ParcelaDAL();
            dgvParcelas.DataSource = parcelaDAL.ListarParcelas();
        }
        public void ListarItensVenda()
        {
            ItemVendaDAL itemVendaDAL = new ItemVendaDAL();
            dgvItensVenda.DataSource = itemVendaDAL.ListarItensVenda();
        }

        private void btnExcluirVenda_Click(object sender, EventArgs e)
        {           
            if (dgvVendas.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja excluir a conta selecionada?", "Excluir conta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int vendaID = Convert.ToInt32(dgvVendas.SelectedRows[0].Cells["VendaID"].Value);

                        // 5. Excluir a venda
                        VendaDAL vendaDAL = new VendaDAL();
                        vendaDAL.ExcluirVenda(vendaID);

                        MessageBox.Show("Conta excluída com sucesso.", "Excluir conta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvVendas.Rows.Clear();
                        ListarVenda();
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

        private void btnExcluirPagamentoParcial_Click(object sender, EventArgs e)
        {            
            if (dgvPagamentosParciais.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja excluir a conta selecionada?", "Excluir conta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int PagamentoParcialID = Convert.ToInt32(dgvPagamentosParciais.SelectedRows[0].Cells["PagamentoParcialID"].Value);
                        // 2. Excluir pagamentos parciais relacionados
                        PagamentoParcialDal pagamentoParcialDAL = new PagamentoParcialDal();
                        pagamentoParcialDAL.ExcluirPagamentosParciaisPorParcelaID(PagamentoParcialID);

                        MessageBox.Show("Conta excluída com sucesso.", "Excluir conta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvPagamentosParciais.Rows.Clear();
                        ListarPagamentosParciais();
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

        private void btnExcluirContaReceber_Click(object sender, EventArgs e)
        {
            if (dgvContaReceber.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja excluir a conta selecionada?", "Excluir conta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int contaReceberID = Convert.ToInt32(dgvContaReceber.SelectedRows[0].Cells["ContaReceberID"].Value);
                        // 3. Excluir contas a receber relacionadas
                        ContaReceberDAL contaReceberDAL = new ContaReceberDAL();
                        contaReceberDAL.ExcluirContasReceberPorParcelaID(contaReceberID);

                        MessageBox.Show("Conta excluída com sucesso.", "Excluir conta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvContaReceber.Rows.Clear();
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

        private void btnExcluirParcelas_Click(object sender, EventArgs e)
        {
            if (dgvParcelas.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja excluir a conta selecionada?", "Excluir conta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int parcelaID = Convert.ToInt32(dgvParcelas.SelectedRows[0].Cells["ParcelaID"].Value);
                        // 4. Excluir a parcela
                        ParcelaDAL parcelaDAL = new ParcelaDAL();
                        parcelaDAL.ExcluirParcela(parcelaID);

                        MessageBox.Show("Conta excluída com sucesso.", "Excluir conta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvParcelas.Rows.Clear();
                        ListarParcelas();
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

        private void btnExcluirItensVenda_Click(object sender, EventArgs e)
        {
            if (dgvParcelas.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja excluir a conta selecionada?", "Excluir conta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int ItemVendaID = Convert.ToInt32(dgvItensVenda.SelectedRows[0].Cells["ItemVendaID"].Value);
                        // 1. Excluir os itens de venda associados
                        ItemVendaDAL itemVendaDAL = new ItemVendaDAL();
                        itemVendaDAL.ExcluirItensPorVendaID(ItemVendaID);

                        MessageBox.Show("Conta excluída com sucesso.", "Excluir conta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvItensVenda.Rows.Clear();
                        ListarItensVenda();
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

        private void FrmExclusaoOrfao_Load(object sender, EventArgs e)
        {
            ListarVenda();
            ListarPagamentosParciais();
            ListarContaReceber();
            ListarParcelas();
            ListarItensVenda();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
