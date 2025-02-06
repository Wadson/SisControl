using SisControl.DALL;
using SisControl.Relatorios;
using System;
using System.Windows.Forms;

namespace SisControl.View
{
    public partial class FrmLocalizarCliente : SisControl.FrmBasePesquisa
    {        
        protected int LinhaAtual = -1;
        private int _clienteID;
        public int numeroComZeros { get; set; }
        public string nomeCliente { get; set; }

        private Form _formChamador;
        public FrmLocalizarCliente(Form formChamador)
        {
            InitializeComponent();

            _formChamador = formChamador;
            dataGridPesquisar.SelectionChanged += dataGridPesquisar_SelectionChanged;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            this.dataGridPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridPesquisar_KeyDown);
            this.txtPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisa_KeyDown);
        }

        public new int ObterLinhaAtual()
        {
            return LinhaAtual;
        }

        public void PersonalizarDataGridView()
        {
            dataGridPesquisar.Columns["ClienteID"].HeaderText = "Cód. Cliente";
            dataGridPesquisar.Columns["NomeCliente"].HeaderText = "Nome do Cliente";
            dataGridPesquisar.Columns["Cpf"].HeaderText = "CPF";
            dataGridPesquisar.Columns["Endereco"].HeaderText = "Endereço";
            dataGridPesquisar.Columns["Telefone"].HeaderText = "Telefone";
            dataGridPesquisar.Columns["Email"].HeaderText = "E-mail";
            dataGridPesquisar.Columns["CidadeID"].HeaderText = "Cód. Cidade";
            dataGridPesquisar.Columns["NomeCidade"].HeaderText = "Nome da Cidade";           
            dataGridPesquisar.Columns["NomeEstado"].HeaderText = "Nome do Estado";          

            // Ocultar coluna de Código (exemplo: CidadeID)
            //dataGridPesquisar.Columns["CidadeID"].Visible = false;
            //dataGridPesquisar.Columns["ClienteID"].Visible = false;
            //dataGridPesquisar.Columns["EstadoID"].Visible = false;
            // Definir tamanhos das colunas
            //this.dataGridPesquisar.Columns["ClienteID"].Width = 100;

            // Ajustar colunas automaticamente
            dataGridPesquisar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Tornar o grid somente leitura
            dataGridPesquisar.ReadOnly = true;

            // Centralizar coluna de Estoque (exemplo: NomeCidade)
            //this.dataGridPesquisar.Columns["NomeCidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public void ListarCliente()
        {
            ClienteDALL dao = new ClienteDALL();
            dataGridPesquisar.DataSource = dao.PesquisarGeral();

            PersonalizarDataGridView();
        }

        private void FrmLocalizarCliente_Load(object sender, EventArgs e)
        {
            ListarCliente();
        }

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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLocalizarCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            SelecionarCliente(); // Seleciona o cliente no dataGridPesquisar
        }

        private bool isSelectingProduct = false;

        private void SelecionarCliente()
        {
            if (isSelectingProduct) return;
            isSelectingProduct = true;

            try
            {
                if (LinhaAtual < 0 || LinhaAtual >= dataGridPesquisar.Rows.Count)
                {
                    MessageBox.Show("Linha inválida.");
                    return;
                }

                if (dataGridPesquisar["ClienteID", LinhaAtual]?.Value == null ||
                    dataGridPesquisar["NomeCliente", LinhaAtual]?.Value == null)
                {
                    MessageBox.Show("Dados do cliente inválidos.");
                    return;
                }

                _clienteID = int.Parse(dataGridPesquisar["ClienteID", LinhaAtual].Value.ToString());
                nomeCliente = dataGridPesquisar["NomeCliente", LinhaAtual].Value.ToString();

                if (this.Owner is FrmPedidoVendaNovo frmPedidoVendaNovo)
                {
                    frmPedidoVendaNovo.ClienteID = _clienteID;
                    frmPedidoVendaNovo.txtNomeCliente.Text = nomeCliente;
                }
                else if (this.Owner is FrmContaReceberr frmContaReceberr)
                {
                    frmContaReceberr.clienteID = _clienteID;
                    frmContaReceberr.txtNomeCliente.Text = nomeCliente;
                }
                else if (this.Owner is FrmRelatorios frmRelatorios)
                {
                    frmRelatorios.txtClienteID.Text = _clienteID.ToString();
                    frmRelatorios.txtNomeCliente.Text = nomeCliente;
                }
                else if (this.Owner is RelClienteContaAberta frmRelGeralContasAbertas)
                {
                    //frmRelGeralContasAbertas.txtClienteID.Text = ClienteID.ToString();
                    frmRelGeralContasAbertas.txtNomeCliente.Text = nomeCliente;
                }
                else
                {
                    MessageBox.Show("O formulário chamador não é reconhecido.");
                }

                this.Close();
            }
            finally
            {
                isSelectingProduct = false;
            }
        }



        private void dataGridPesquisar_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridPesquisar.CurrentRow != null)
            {
                LinhaAtual = dataGridPesquisar.CurrentRow.Index;
            }
        }

        private void dataGridPesquisar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                dataGridPesquisar.Focus();
                if (dataGridPesquisar.Rows.Count > 0)
                {
                    dataGridPesquisar.CurrentCell = dataGridPesquisar.Rows[0].Cells[0];
                }
            }
        }

        private void dataGridPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && dataGridPesquisar.CurrentCell.RowIndex == 0)
            {
                txtPesquisa.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita o "beep" do Enter no DataGridView

                if (dataGridPesquisar.CurrentRow != null)
                {
                    LinhaAtual = dataGridPesquisar.CurrentRow.Index; // Atualiza a linha atual corretamente
                    SelecionarCliente();
                }
            }
        }

    }
}