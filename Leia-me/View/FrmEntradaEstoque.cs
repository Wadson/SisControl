﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using SisControl.BLL;
using SisControl.DALL;

namespace SisControl.View
{
    public partial class FrmEntradaEstoque : SisControl.FrmModeloForm
    {
        public FrmEntradaEstoque()
        {
            InitializeComponent();
        }
              
        private void AbrirFrmLocalizarProduto()
        {
            FrmLocalizarProduto frmLocalizarProduto = new FrmLocalizarProduto()
            {
                Owner = this
            };
            frmLocalizarProduto.ShowDialog();
            frmLocalizarProduto.Text = "Localizar Produtos";
        }
        private void CalcularLucro()
        {
            if (txtPrecoCusto.Text != "" && txtPrecoDeVenda.Text != "")
            {
                decimal precoCusto = Convert.ToDecimal(txtPrecoCusto.Text);
                decimal precoVenda = Convert.ToDecimal(txtPrecoDeVenda.Text);
                decimal lucro = precoVenda - precoCusto;
                txtLucro.Text = lucro.ToString("N2");
            }
        }
        private void LocalizarProduto()
        {
            // Cria uma instância do FrmLocalizarProduto e define o Owner como o FrmVendas
            FrmLocalizarProduto frmLocalizarProduto = new FrmLocalizarProduto
            {
                Owner = this
            };
            frmLocalizarProduto.ShowDialog();
            frmLocalizarProduto.Text = "Localizar Produtos";
        }

        private void btnLocalizarProduto_Click(object sender, EventArgs e)
        {
            AbrirFrmLocalizarProduto();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (txtNomeProduto.Text == string.Empty ||
               !int.TryParse(txtQuantidade.Text, out int quantidade) ||
               !decimal.TryParse(txtPrecoCusto.Text, out decimal precoCusto) ||
               !decimal.TryParse(txtPrecoDeVenda.Text, out decimal precoVenda))
            {
                MessageBox.Show("Preencha todos os campos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int produtoID = Convert.ToInt32(txtProdutoID.Text);
            decimal lucro = precoVenda - precoCusto;

            // Atualiza o estoque
            ProdutosDal produtoDal = new ProdutosDal();
            produtoDal.AtualizarEstoque(produtoID, quantidade);

            // Registra no histórico de preços
            HistoricoPrecoBLL historico = new HistoricoPrecoBLL
            {
                ProdutoID = produtoID,
                DataRegistro = DateTime.Now,
                PrecoCusto = precoCusto,
                Lucro = lucro,
                PrecoVenda = precoVenda
            };

            DALL.HistoricoProdutoDALL historicoDAL = new DALL.HistoricoProdutoDALL();
            historicoDAL.InserirHistorico(historico);

            MessageBox.Show("Entrada de estoque registrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
         
        private void PopularCombobox()
        {
            //using (var conn = Conexao.Conex())
            //{
            //    string sql = "SELECT ProdutoID, Nome FROM Produto";
            //    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);

            //    cmbProduto.DataSource = dt;
            //    cmbProduto.DisplayMember = "Nome";
            //    cmbProduto.ValueMember = "ProdutoID";
            //}
        }

        private void FrmEntradaEstoque_Load(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Utilitario.LimpaCampoKrypton(this);
            txtNomeProduto.Focus();
        }
    }
}


/*
 * Resumo do Funcionamento
O usuário escolhe um produto e informa a quantidade recebida.
Digita os preços de custo e venda.
O lucro é calculado automaticamente.
Ao salvar:
O estoque do produto é atualizado.
O histórico de preços é registrado.
Exibe uma mensagem de sucesso.
Próximos Passos
Criar um botão para adicionar um novo produto caso ele ainda não esteja cadastrado.
Criar uma tela de consulta do histórico de compras.
Se precisar de ajustes ou quiser adicionar mais funcionalidades, me avise! 🚀
 * */
