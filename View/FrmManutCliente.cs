using ComponentFactory.Krypton.Toolkit;
using SisControl.BLL;
using SisControl.DALL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit; 

namespace SisControl.View
{
    public partial class FrmManutCliente : SisControl.FrmBaseManutencao
    {
        private new string StatusOperacao;
        public FrmManutCliente(string statusOperacao)
        {
            this.StatusOperacao = statusOperacao;
            InitializeComponent();
        }
        public void ListarCliente()
        {
            ClienteBLL objetoBll = new ClienteBLL();
            dataGridPesquisar.DataSource = objetoBll.Listar();
            PersonalizarDataGridView(dataGridPesquisar);
        }
        public void HabilitarTimer(bool habilitar)
        {
            timer1.Enabled = habilitar;
        }
        public void PersonalizarDataGridView(KryptonDataGridView dgv)
        {
            // Renomear colunas
           dgv.Columns[0].Name = "ClienteID";
           dgv.Columns[1].Name = "Cliente";
           dgv.Columns[2].Name = "Cpf";
           dgv.Columns[3].Name = "Endereco";
           dgv.Columns[4].Name = "Telefone";
           dgv.Columns[5].Name = "Email";
           dgv.Columns[6].Name = "CidadeID";
           dgv.Columns[7].Name = "Cidade";
           dgv.Columns[8].Name = "EstadoID";
            dgv.Columns[9].Name = "Estado";

            // Ocultar coluna de Código (exemplo: CidadeID)
            dgv.Columns["CidadeID"].Visible = false;
            dgv.Columns["ClienteID"].Visible = false;
            dgv.Columns["EstadoID"].Visible = false;
            // Definir tamanhos das colunas
            //this.dataGridPesquisar.Columns["ClienteID"].Width = 100;
            //this.dataGridPesquisar.Columns["Cliente"].Width = 150;
            //this.dataGridPesquisar.Columns["Cpf"].Width = 120;
            //this.dataGridPesquisar.Columns["Endereco"].Width = 250;
            //this.dataGridPesquisar.Columns["Telefone"].Width = 100;
            //this.dataGridPesquisar.Columns["Email"].Width = 180;
            //this.dataGridPesquisar.Columns["Cidade"].Width = 150;
            //this.dataGridPesquisar.Columns["Estado"].Width = 100;

            // Ajustar colunas automaticamente
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Tornar o grid somente leitura
            dgv.ReadOnly = true;

            // Centralizar coluna de Estoque (exemplo: NomeCidade)
            //this.dataGridPesquisar.Columns["NomeCidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }


        private void CarregaDados()
        {
            FrmCadCliente cadCliente = new FrmCadCliente(StatusOperacao);

            if (StatusOperacao == "NOVO")
            {
                cadCliente.Text = "SISCONTROL - NOVO CADASTRO DE CLIENTE";
                StatusOperacao = "NOVO";
                cadCliente.ShowDialog();

                ((FrmManutCliente)Application.OpenForms["FrmManutCliente"]).HabilitarTimer(true);
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
                        cadCliente.txtClienteID.Text = dataGridPesquisar.CurrentRow.Cells["ClienteID"].Value.ToString();
                        cadCliente.txtNomeCliente.Text = dataGridPesquisar.CurrentRow.Cells["Cliente"].Value.ToString();
                        cadCliente.txtCpf.Text = dataGridPesquisar.CurrentRow.Cells["Cpf"].Value.ToString();
                        cadCliente.txtEndereco.Text = dataGridPesquisar.CurrentRow.Cells["Endereco"].Value.ToString();
                        cadCliente.txtTelefone.Text = dataGridPesquisar.CurrentRow.Cells["Telefone"].Value.ToString();
                        cadCliente.txtEmail.Text = dataGridPesquisar.CurrentRow.Cells["Email"].Value.ToString();
                        cadCliente.txtCidadeID.Text = dataGridPesquisar.CurrentRow.Cells["CidadeID"].Value.ToString();
                        cadCliente.txtNomeCidade.Text = dataGridPesquisar.CurrentRow.Cells["Cidade"].Value.ToString();
                        cadCliente.txtEstadoCliente.Text = dataGridPesquisar.CurrentRow.Cells["Estado"].Value.ToString();
                        cadCliente.txtCidadeID.Text = dataGridPesquisar.CurrentRow.Cells["CidadeID"].Value.ToString();
                        
                        
                        

                        cadCliente.Text = "SISCONTROL - ALTERAR REGISTRO";
                        StatusOperacao = "ALTERAR";
                        cadCliente.btnSalvar.Text = "Alterar";
                        cadCliente.btnNovo.Enabled = false;
                      
                        cadCliente.ShowDialog();
                        ((FrmManutCliente)Application.OpenForms["FrmManutCliente"]).HabilitarTimer(true);
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
                        cadCliente.txtClienteID.Text = dataGridPesquisar.CurrentRow.Cells["ClienteID"].Value.ToString();
                        cadCliente.txtNomeCliente.Text = dataGridPesquisar.CurrentRow.Cells["Cliente"].Value.ToString();
                        cadCliente.txtCpf.Text = dataGridPesquisar.CurrentRow.Cells["Cpf"].Value.ToString();
                        cadCliente.txtEndereco.Text = dataGridPesquisar.CurrentRow.Cells["Endereco"].Value.ToString();
                        cadCliente.txtTelefone.Text = dataGridPesquisar.CurrentRow.Cells["Telefone"].Value.ToString();
                        cadCliente.txtEmail.Text = dataGridPesquisar.CurrentRow.Cells["Email"].Value.ToString();
                        cadCliente.txtCidadeID.Text = dataGridPesquisar.CurrentRow.Cells["CidadeID"].Value.ToString();
                        cadCliente.txtNomeCidade.Text = dataGridPesquisar.CurrentRow.Cells["Cidade"].Value.ToString();
                        cadCliente.txtEstadoCliente.Text = dataGridPesquisar.CurrentRow.Cells["Estado"].Value.ToString();
                        cadCliente.txtCidadeID.Text = dataGridPesquisar.CurrentRow.Cells["CidadeID"].Value.ToString();

                        cadCliente.Text = "SISCONTROL - EXCLUSÃO DE REGISTRO";
                        StatusOperacao = "EXCLUSÃO";
                        cadCliente.btnSalvar.Text = "Excluir";
                        cadCliente.btnNovo.Enabled = false;
                       

                        cadCliente.txtClienteID.Enabled = false;
                        cadCliente.txtNomeCliente.Enabled = false;
                        cadCliente.txtCpf.Enabled = false;
                        cadCliente.txtEndereco.Enabled = false;
                        cadCliente.txtTelefone.Enabled = false;
                        cadCliente.txtEmail.Enabled = false;
                        cadCliente.txtCidadeID.Enabled = false;
                        cadCliente.txtNomeCidade.Enabled = false;
                        cadCliente.txtEstadoCliente.Enabled = false;
                        cadCliente.btnLocalizar.Enabled = false;

                        cadCliente.ShowDialog();
                        ((FrmManutCliente)Application.OpenForms["FrmManutCliente"]).HabilitarTimer(true);
                    }
                    // Execução do código desejado
                    //foreach (DataGridViewRow row in dataGridPesquisar.Rows)
                    //{
                    //}
                }
                catch (Exception ex)
                {
                    // Exibir uma mensagem de erro para o usuário
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }       
            }
            ListarCliente();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            ListarCliente();
            timer1.Enabled = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {            
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";
            ClienteDALL clienteDao = new ClienteDALL();

            dataGridPesquisar.DataSource = clienteDao.PesquisarPorNome(nome);
            PersonalizarDataGridView(dataGridPesquisar);
        }

        private void FrmManutCliente_Load(object sender, EventArgs e)
        {
            ListarCliente();
        }
    }
}
