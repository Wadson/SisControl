﻿using SisControl.DALL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SisControl.View
{
    public partial class FrmLocalizarCliente : SisControl.FrmBasePesquisa
    {
        private int ClienteID;
        protected int LinhaAtual = -1;
        public Form FormChamador { get; set; }
        public int numeroComZeros { get; set; }
        public string nomeCliente { get; set; }
        public FrmLocalizarCliente()
        {
            InitializeComponent();
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
        }      
        private void InicializaDataGridView()
        {
            dataGridPesquisar.MultiSelect = false;

            //Configuração das linhas do DataGridView

            //Cores alternadas no DataGridView
            dataGridPesquisar.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridPesquisar.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

            //Redimensiona o tamanho das colunas do DataGridView 
            dataGridPesquisar.Columns[0].Width = 100;
            dataGridPesquisar.Columns[1].Width = 660;
            dataGridPesquisar.Columns[2].Width = 200;
            dataGridPesquisar.Columns[3].Width = 350;
        }
        public void ListarCliente()
        {
            ClienteDALL dao = new ClienteDALL();
            dataGridPesquisar.DataSource = dao.PesquisarGeral();

            InicializaDataGridView();
        }

        private void FrmLocalizarCliente_Load(object sender, EventArgs e)
        {
            ListarCliente();
        }
<<<<<<< HEAD
       
=======

        private void FrmLocalizarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClienteID = Convert.ToInt32(dataGridPesquisar[0, LinhaAtual].Value);            
            string numeroComZeros = Utilitario.AcrescentarZerosEsquerda(ClienteID, 4);



            ((FrmVendas)Application.OpenForms["FrmVendas"]).txtClienteID.Text = numeroComZeros;
            ((FrmVendas)Application.OpenForms["FrmVendas"]).txtNomeCliente.Text = dataGridPesquisar[1, LinhaAtual].Value.ToString();
        }

>>>>>>> 4d7533ac6658105f916433324377f073e909b48b
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string textoPesquisa = txtPesquisa.Text.ToLower();

            string nome = "%" + txtPesquisa.Text + "%";
            ClienteDALL dao = new ClienteDALL();

            if (rbtCodigo.Checked)
            {
                dataGridPesquisar.DataSource = dao.PesquisarPorCodigo(nome);
            }
            else
            {
                dataGridPesquisar.DataSource = dao.PesquisarPorNome(nome);
            }
        }

        private void dataGridPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (dataGridPesquisar.CurrentRow != null)
            {
                LinhaAtual = dataGridPesquisar.CurrentRow.Index;
            }
        }

        private void dataGridPesquisar_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridPesquisar.CurrentRow != null)
            {
                LinhaAtual = dataGridPesquisar.CurrentRow.Index;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLocalizarCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Obtém o ID do cliente da célula [0, LinhaAtual] do dataGridPesquisar e converte para inteiro.
            ClienteID = Convert.ToInt32(dataGridPesquisar[0, LinhaAtual].Value);

            // Acrescenta zeros à esquerda do ID do cliente até que ele tenha 4 dígitos.
            numeroComZeros = int.Parse(Utilitario.AcrescentarZerosEsquerda(ClienteID, 4));

            // Obtém o nome do cliente da célula [1, LinhaAtual] do dataGridPesquisar e converte para string.
            nomeCliente = dataGridPesquisar[1, LinhaAtual].Value.ToString();

            // Verifica se o formulário chamador é uma instância de FrmVendas.
            if (FormChamador is FrmVendas frmVendas)
            {
                // Se for, define os textos dos campos txtClienteID e txtNomeCliente de FrmVendas.
                frmVendas.txtClienteID.Text = numeroComZeros.ToString();
                frmVendas.txtNomeCliente.Text = nomeCliente;
            }
            // Verifica se o formulário chamador é uma instância de FrmContaReceber.
            else if (FormChamador is FrmContaReceber frmContaReceber)
            {
                // Se for, define os textos dos campos txtClienteID e txtNomeCliente de FrmContaReceber.
                frmContaReceber.txtClienteID.Text = numeroComZeros.ToString();
                frmContaReceber.txtNomeCliente.Text = nomeCliente;
            }
        }       
    }
}
