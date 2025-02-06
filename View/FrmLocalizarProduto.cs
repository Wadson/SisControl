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

namespace SisControl.View
{
    public partial class FrmLocalizarProduto : SisControl.FrmBasePesquisa
    {
        private string _ClienteID;
        protected int LinhaAtual = -1;

        public int ProdutoID { get; set; }
        public string NomeProduto { get; set; }
        private decimal PrecoUnitario;
        private String referencia;
        public Form FormChamador { get; set; }        

        public FrmLocalizarProduto()
        {
            InitializeComponent();
            
            // Configurar o TextBox para capturar o evento KeyDown
            this.txtPesquisa.KeyDown += new KeyEventHandler(dataGridPesquisar_KeyDown);            
            this.dataGridPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridPesquisar_KeyDown);


            // Configurar o DataGridView (apenas exemplo, configure conforme necessário)
            dataGridPesquisar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

            dgv.Columns["Preco De Venda"].DefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Italic); // Fonte Arial, 12, Negrito
            dgv.Columns["Preco De Venda"].DefaultCellStyle.ForeColor = System.Drawing.Color.DarkGreen; // Cor da fonte: Verde Escuro
            dgv.Columns["Preco De Venda"].DefaultCellStyle.Format = "N2"; // Formato de moeda
            dgv.Columns["Preco De Venda"].DefaultCellStyle.BackColor = System.Drawing.Color.LightBlue; // Cor de fundo Azul Claro
            dgv.Columns["Preco De Venda"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // Alinhamento à direita



            // Ocultar a coluna ProdutoID
            dgv.Columns["ProdutoID"].Visible = false;
        }
        public new int ObterLinhaAtual()
        {
            return LinhaAtual;
        }
      
        public void ListarProduto()
        {
            ProdutoBLL objetoBll = new ProdutoBLL();
            dataGridPesquisar.DataSource = objetoBll.Listar();
            PersonalizarDataGridView(dataGridPesquisar);
        }
        private void FrmLocalizarProduto_Load(object sender, EventArgs e)
        {
            ListarProduto();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";
            ProdutosDal dao = new ProdutosDal();

            if (rbtCodigo.Checked)
            {
                dataGridPesquisar.DataSource = dao.PesquisarProdutoPorCodido(nome);
            }
            else
            {
                dataGridPesquisar.DataSource = dao.PesquisarProdutoPorNome(nome);
            }
        }

        private void FrmLocalizarProduto_FormClosing(object sender, FormClosingEventArgs e)
        {
            SelecionarProduto();
        }

        // No FrmLocalizarProduto, após selecionar o produto e fechar o formulário
        private bool isSelectingProduct = false;

        private void SelecionarProduto()
        {
            // Verifica se o processo de seleção de produto já está em andamento
            if (isSelectingProduct) return;
            isSelectingProduct = true;

            try
            {
                // Obtém a linha atual selecionada na grid
                LinhaAtual = ObterLinhaAtual();
                if (LinhaAtual < 0 || LinhaAtual >= dataGridPesquisar.Rows.Count)
                {
                    // Verifica se a linha obtida é válida
                    MessageBox.Show("Linha inválida.");
                    return;
                }
                // Verifica e obtém os valores das células NomeProduto e PrecoDeVenda
                if (dataGridPesquisar["Produto", LinhaAtual]?.Value == null ||
                    dataGridPesquisar["Preco De Venda", LinhaAtual]?.Value == null ||
                    !decimal.TryParse(dataGridPesquisar["Preco De Venda", LinhaAtual].Value.ToString(), out PrecoUnitario))
                {
                    // Caso os valores não sejam válidos, exibe uma mensagem de erro
                    MessageBox.Show("Dados do produto inválidos.");
                    return;
                }

                // Converte o valor da célula NomeProduto para string
                ProdutoID = int.Parse(dataGridPesquisar["ProdutoID", LinhaAtual].Value.ToString());
                NomeProduto = dataGridPesquisar["Produto", LinhaAtual].Value.ToString();
                referencia = dataGridPesquisar["Referencia", LinhaAtual].Value.ToString();

                // Acrescenta zeros à esquerda do ProdutoID
                string numeroComZeros = Utilitario.AcrescentarZerosEsquerda(ProdutoID, 4);

                // Obtém a instância do formulário FrmPedido (ou usa uma existente)
                if (this.Owner is FrmPedidoVendaNovo frmPedidoVendaNovo)
                {
                    // Preenche os campos no formulário FrmPedido com os dados do produto
                    frmPedidoVendaNovo.ProdutoID = ProdutoID;
                    frmPedidoVendaNovo.txtNomeProduto.Text = NomeProduto;
                    frmPedidoVendaNovo.txtValorProduto.Text = PrecoUnitario.ToString();
                    frmPedidoVendaNovo.txtQuantidade.Text = "1";

                    // Calcula o subtotal
                    frmPedidoVendaNovo.CalcularSubtotal();
                }
                if (this.Owner is FrmEntradaEstoque frmEntradaEstoque)
                {
                    // Preenche os campos no formulário FrmPedido com os dados do produto
                    frmEntradaEstoque.txtProdutoID.Text = ProdutoID.ToString();
                    frmEntradaEstoque.txtNomeProduto.Text = NomeProduto;
                    
                }              


                // Fecha o formulário FrmLocalizarProduto
                this.Close();
            }
            finally
            {
                // Certifica-se de que a variável isSelectingProduct seja false ao final do processo
                isSelectingProduct = false;
            }
        }
        // Alterado em 23/01/2025***************ACIMA

        private void dataGridPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se a linha clicada é válida
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridPesquisar.Rows[e.RowIndex];
                string produtoId = row.Cells["ProdutoID"].Value.ToString();
                string nomeProduto = row.Cells["NomeProduto"].Value.ToString();
                string precoUnitario = row.Cells["PrecoUnitario"].Value.ToString();

                // Obter a instância do FrmVendas (Owner)
                if (this.Owner is FrmPedidoVendaNovo frmPedidoVendaNovo)
                {
                    // Preencher os campos do FrmVendas
                    frmPedidoVendaNovo.ProdutoID = int.Parse(produtoId);
                    frmPedidoVendaNovo.txtNomeProduto.Text = nomeProduto;
                    frmPedidoVendaNovo.txtValorProduto.Text = precoUnitario;
                    frmPedidoVendaNovo.txtQuantidade.Text = "1"; // Define a quantidade padrão como 1

                    // Calcular o subtotal
                    frmPedidoVendaNovo.CalcularSubtotal();
                }

                // Fecha o FrmLocalizarProduto
                this.Close();
            }
        }

        private void dataGridPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && dataGridPesquisar.CurrentCell.RowIndex == 0)
            {
                txtPesquisa.Focus();
            }

            if (dataGridPesquisar.CurrentRow != null)
            {
                LinhaAtual = dataGridPesquisar.CurrentRow.Index;
            }
            // Verifica se a tecla pressionada foi a seta para baixo
            if (e.KeyCode == Keys.Down)
            {
                // Move o foco para o DataGridView
                dataGridPesquisar.Focus();

                // Seleciona a primeira linha se houver linhas
                if (dataGridPesquisar.Rows.Count > 0)
                {
                    dataGridPesquisar.ClearSelection();
                    dataGridPesquisar.Rows[0].Selected = true;
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                // Supondo que a seleção está habilitada em FullRowSelect para capturar a linha completa
                var selectedRow = dataGridPesquisar.CurrentRow;
                if (selectedRow != null)
                {
                    this.Close();
                }
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
            }
        }
    }
}


/*//dataGridPesquisar_SelectionChanged
 * 
 * if (dataGridPesquisar.CurrentRow != null)
            {
                LinhaAtual = dataGridPesquisar.CurrentRow.Index;
            }
 * */
/*//KeyDown
 *  if (dataGridPesquisar.CurrentRow != null)
            {
                LinhaAtual = dataGridPesquisar.CurrentRow.Index;
            }
            // Verifica se a tecla pressionada foi a seta para baixo
            if (e.KeyCode == Keys.Down)
            {
                // Move o foco para o DataGridView
                dataGridPesquisar.Focus();

                // Seleciona a primeira linha se houver linhas
                if (dataGridPesquisar.Rows.Count > 0)
                {
                    dataGridPesquisar.ClearSelection();
                    dataGridPesquisar.Rows[0].Selected = true;
                }
            }
 * */