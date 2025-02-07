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
    public partial class FrmPrincipal : SisControl.FrmModeloForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            StatusOperacao = "";
        }
        private string StatusOperacao = "";
        private FrmContaReceberr _frmContaReceberr;
        private Parcela _parcela;
        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.LayoutPanelGeral.Controls.Count > 0)
                this.LayoutPanelGeral.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.LayoutPanelGeral.Controls.Add(fh);
            this.LayoutPanelGeral.Tag = fh;
            fh.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FrmManutUsuario frm = new FrmManutUsuario(StatusOperacao);
            AbrirFormEnPanel(frm);
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmManutCliente frm = new FrmManutCliente(StatusOperacao);
            StatusOperacao = "NOVO";
            AbrirFormEnPanel(frm);
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            FrmManutFornecedor frm = new FrmManutFornecedor(StatusOperacao);
            StatusOperacao = "NOVO";
            AbrirFormEnPanel(frm);
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            FrmManutProduto frm = new FrmManutProduto(StatusOperacao);
            StatusOperacao = "NOVO";
            AbrirFormEnPanel(frm);
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            FrmPedidoVendaNovo frm = new FrmPedidoVendaNovo();
            AbrirFormEnPanel(frm);
        }

        private void btnFerramentas_Click(object sender, EventArgs e)
        {
            FrmFerramentas frm = new FrmFerramentas();
            AbrirFormEnPanel(frm);
        }

        private void btnContaReceber_Click(object sender, EventArgs e)
        {
            // Suponha que você tenha uma instância de Parcela
            Parcela parcela = new Parcela();
            // Chama o construtor de FrmContaReceberr com os parâmetros necessários
            FrmContaReceberr frm = new FrmContaReceberr(parcela);
            AbrirFormEnPanel(frm);
        }
        

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            FrmRelatorios frm = new FrmRelatorios();
            AbrirFormEnPanel(frm);
        }
    }
}
