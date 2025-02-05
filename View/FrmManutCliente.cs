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
            PersonalizarDataGridView();
        }
        public void HabilitarTimer(bool habilitar)
        {
            timer1.Enabled = habilitar;
        }
        public void PersonalizarDataGridView()
        {
            //DataTable dt = new DataTable();
                       
            //dt.Columns.Add("ClienteID", typeof(int));
            //dt.Columns.Add("NomeCliente", typeof(string));
            //dt.Columns.Add("Cpf", typeof(string));
            //dt.Columns.Add("Endereco", typeof(string));
            //dt.Columns.Add("Telefone", typeof(string));
            //dt.Columns.Add("Email", typeof(string));
            //dt.Columns.Add("CidadeID", typeof(int));
            //dt.Columns.Add("NomeCidade", typeof(string));
            //dt.Columns.Add("EstadoID", typeof(int));
            //dt.Columns.Add("NomeEstado", typeof(string));
            //dt.Columns.Add("Uf", typeof(string));
            
            //dataGridPesquisar.DataSource = dt;
            
            dataGridPesquisar.Columns["ClienteID"].HeaderText = "Cód. Cliente";
            dataGridPesquisar.Columns["NomeCliente"].HeaderText = "Nome do Cliente";
            dataGridPesquisar.Columns["Cpf"].HeaderText = "CPF";
            dataGridPesquisar.Columns["Endereco"].HeaderText = "Endereço";
            dataGridPesquisar.Columns["Telefone"].HeaderText = "Telefone";
            dataGridPesquisar.Columns["Email"].HeaderText = "E-mail";
            dataGridPesquisar.Columns["CidadeID"].HeaderText = "Cód. Cidade";
            dataGridPesquisar.Columns["NomeCidade"].HeaderText = "Nome da Cidade";
            dataGridPesquisar.Columns["EstadoID"].HeaderText = "Cód. Estado";
            dataGridPesquisar.Columns["NomeEstado"].HeaderText = "Nome do Estado";
            dataGridPesquisar.Columns["Uf"].HeaderText = "UF";
            // Renomear colunas


            // Ocultar coluna de Código (exemplo: CidadeID)
            dataGridPesquisar.Columns["CidadeID"].Visible = false;
            dataGridPesquisar.Columns["ClienteID"].Visible = false;
            dataGridPesquisar.Columns["EstadoID"].Visible = false;
            // Definir tamanhos das colunas
            //this.dataGridPesquisar.Columns["ClienteID"].Width = 100;


            // Ajustar colunas automaticamente
            dataGridPesquisar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Tornar o grid somente leitura
            dataGridPesquisar.ReadOnly = true;

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
                        cadCliente.txtNomeCliente.Text = dataGridPesquisar.CurrentRow.Cells["NomeCliente"].Value.ToString();
                        cadCliente.txtCpf.Text = dataGridPesquisar.CurrentRow.Cells["Cpf"].Value.ToString();
                        cadCliente.txtEndereco.Text = dataGridPesquisar.CurrentRow.Cells["Endereco"].Value.ToString();
                        cadCliente.txtTelefone.Text = dataGridPesquisar.CurrentRow.Cells["Telefone"].Value.ToString();
                        cadCliente.txtEmail.Text = dataGridPesquisar.CurrentRow.Cells["Email"].Value.ToString();
                        cadCliente.txtCidadeID.Text = dataGridPesquisar.CurrentRow.Cells["CidadeID"].Value.ToString();
                        cadCliente.txtNomeCidade.Text = dataGridPesquisar.CurrentRow.Cells["NomeCidade"].Value.ToString();
                        cadCliente.txtEstadoCliente.Text = dataGridPesquisar.CurrentRow.Cells["NomeEstado"].Value.ToString();
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
                        cadCliente.txtNomeCliente.Text = dataGridPesquisar.CurrentRow.Cells["NomeCliente"].Value.ToString();
                        cadCliente.txtCpf.Text = dataGridPesquisar.CurrentRow.Cells["Cpf"].Value.ToString();
                        cadCliente.txtEndereco.Text = dataGridPesquisar.CurrentRow.Cells["Endereco"].Value.ToString();
                        cadCliente.txtTelefone.Text = dataGridPesquisar.CurrentRow.Cells["Telefone"].Value.ToString();
                        cadCliente.txtEmail.Text = dataGridPesquisar.CurrentRow.Cells["Email"].Value.ToString();
                        cadCliente.txtCidadeID.Text = dataGridPesquisar.CurrentRow.Cells["CidadeID"].Value.ToString();
                        cadCliente.txtNomeCidade.Text = dataGridPesquisar.CurrentRow.Cells["NomeCidade"].Value.ToString();
                        cadCliente.txtEstadoCliente.Text = dataGridPesquisar.CurrentRow.Cells["NomeEstado"].Value.ToString();
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
            PersonalizarDataGridView();
        }

        private void FrmManutCliente_Load(object sender, EventArgs e)
        {
            ListarCliente();
        }
    }
}
