﻿using SisControl.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Runtime.InteropServices;
using static SisControl.View.FrmContaReceberr;

namespace SisControl
{
    public partial class FrmTelaPrincipal : SisControl.FrmModeloForm
    {
        private string StatusOperacao = "";
        private FrmContaReceberr _frmContaReceberr;
        private Parcela _parcela;
        public FrmTelaPrincipal()
        {
            InitializeComponent();
            //_frmContaReceberr = new FrmContaReceberr();
            StatusOperacao = "";
        }

        //private void AbrirFormEnPanel(object Form)
        //{
        //    // Se há algum formulário no painel, remova-o
        //    if (this.panelContenedor.Controls.Count > 0)
        //        this.panelContenedor.Controls.RemoveAt(0);

        //    // Adiciona o novo formulário
        //    Form fh = Form as Form;
        //    fh.TopLevel = false;
        //    fh.Dock = DockStyle.Fill;
        //    this.panelContenedor.Controls.Add(fh);
        //    this.panelContenedor.Tag = fh;
        //    fh.Show();
        //}
             
        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            string currentPath = Path.GetDirectoryName(Application.ExecutablePath);

            //lblUsuarioLogado.Text = FrmLogin.usuarioConectado + "  |  Previlégio:" + FrmLogin.NivelAcesso + "  |  Diretório:" + currentPath + @"\Money.exe";

            string data = DateTime.Now.ToLongDateString();
            data = data.Substring(0, 1).ToUpper() + data.Substring(1, data.Length - 1);
            toolStripStatusData.Text = data;

            string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
            var informacao = Environment.UserName;
            var nomeComputador = Environment.MachineName;

            toolStripStatusExecutablePath.Text = path;            
            toolStripStatusCommonAppDataPath.Text = nomeComputador + " | " + informacao;

            lblEstação.Text = nomeComputador;
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHoraAtual.Text = DateTime.Now.ToString("HH:mm:ss");            
        }

       
        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {           
        }

        private void fabricanteToolStripMenuItem_Click(object sender, EventArgs e)
        {           
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
                    
        }

        private void btnCadClientes_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            //FrmPedido frm = new FrmPedido();
            //AbrirFormEnPanel(frm); 
           
        }

        private void btnContasPagar_Click(object sender, EventArgs e)
        {
        }

        private void btnContasReceber_Click(object sender, EventArgs e)
        {
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFerramentas_Click(object sender, EventArgs e)
        {
            
        }
        
         
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void telaUiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModeloUI frmModeloUI = new FrmModeloUI();
            frmModeloUI.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre frmSobre = new Sobre();
            frmSobre.ShowDialog();
        }

        private void entradaDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEntradaEstoque frmEntradaEstoque = new FrmEntradaEstoque();
            frmEntradaEstoque.ShowDialog();
        }
    }
}
