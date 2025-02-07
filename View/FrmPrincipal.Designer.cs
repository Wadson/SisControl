namespace SisControl.View
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnFerramentas = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnContaReceber = new System.Windows.Forms.Button();
            this.LayoutPanelGeral = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.LayoutPanelGeral.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.White;
            this.btnUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Image = global::SisControl.Properties.Resources.Usuarios32;
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsuario.Location = new System.Drawing.Point(3, 3);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(75, 65);
            this.btnUsuario.TabIndex = 1;
            this.btnUsuario.Text = "&Usuários";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.White;
            this.btnCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Image = global::SisControl.Properties.Resources.Clientes32;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCliente.Location = new System.Drawing.Point(84, 3);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(75, 65);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "&Clientes";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.BackColor = System.Drawing.Color.White;
            this.btnFornecedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecedor.Image = global::SisControl.Properties.Resources.Fornecedores32;
            this.btnFornecedor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFornecedor.Location = new System.Drawing.Point(165, 3);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(75, 66);
            this.btnFornecedor.TabIndex = 3;
            this.btnFornecedor.Text = "&Fornecedor";
            this.btnFornecedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFornecedor.UseVisualStyleBackColor = false;
            this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.BackColor = System.Drawing.Color.White;
            this.btnProduto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduto.Image = global::SisControl.Properties.Resources.Produtos32;
            this.btnProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProduto.Location = new System.Drawing.Point(246, 3);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(75, 66);
            this.btnProduto.TabIndex = 4;
            this.btnProduto.Text = "&Produtos";
            this.btnProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProduto.UseVisualStyleBackColor = false;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.BackColor = System.Drawing.Color.White;
            this.btnVendas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendas.Image = global::SisControl.Properties.Resources.Vendas32;
            this.btnVendas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVendas.Location = new System.Drawing.Point(327, 3);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(75, 65);
            this.btnVendas.TabIndex = 5;
            this.btnVendas.Text = "&Vendas";
            this.btnVendas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVendas.UseVisualStyleBackColor = false;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnFerramentas
            // 
            this.btnFerramentas.BackColor = System.Drawing.Color.White;
            this.btnFerramentas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnFerramentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFerramentas.Image = global::SisControl.Properties.Resources.Ferramentas32;
            this.btnFerramentas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFerramentas.Location = new System.Drawing.Point(408, 3);
            this.btnFerramentas.Name = "btnFerramentas";
            this.btnFerramentas.Size = new System.Drawing.Size(75, 65);
            this.btnFerramentas.TabIndex = 6;
            this.btnFerramentas.Text = "&Ferramentas";
            this.btnFerramentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFerramentas.UseVisualStyleBackColor = false;
            this.btnFerramentas.Click += new System.EventHandler(this.btnFerramentas_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Image = global::SisControl.Properties.Resources.Sair32;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(651, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 65);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnContaReceber
            // 
            this.btnContaReceber.BackColor = System.Drawing.Color.White;
            this.btnContaReceber.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnContaReceber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContaReceber.Image = global::SisControl.Properties.Resources.Receber32;
            this.btnContaReceber.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnContaReceber.Location = new System.Drawing.Point(489, 3);
            this.btnContaReceber.Name = "btnContaReceber";
            this.btnContaReceber.Size = new System.Drawing.Size(75, 65);
            this.btnContaReceber.TabIndex = 8;
            this.btnContaReceber.Text = "&Conta Receber";
            this.btnContaReceber.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnContaReceber.UseVisualStyleBackColor = false;
            this.btnContaReceber.Click += new System.EventHandler(this.btnContaReceber_Click);
            // 
            // LayoutPanelGeral
            // 
            this.LayoutPanelGeral.Controls.Add(this.flowLayoutPanel2);
            this.LayoutPanelGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutPanelGeral.Location = new System.Drawing.Point(0, 24);
            this.LayoutPanelGeral.Name = "LayoutPanelGeral";
            this.LayoutPanelGeral.Size = new System.Drawing.Size(1008, 705);
            this.LayoutPanelGeral.TabIndex = 17;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnUsuario);
            this.flowLayoutPanel2.Controls.Add(this.btnCliente);
            this.flowLayoutPanel2.Controls.Add(this.btnFornecedor);
            this.flowLayoutPanel2.Controls.Add(this.btnProduto);
            this.flowLayoutPanel2.Controls.Add(this.btnVendas);
            this.flowLayoutPanel2.Controls.Add(this.btnFerramentas);
            this.flowLayoutPanel2.Controls.Add(this.btnContaReceber);
            this.flowLayoutPanel2.Controls.Add(this.btnRelatorios);
            this.flowLayoutPanel2.Controls.Add(this.btnSair);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1012, 71);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.BackColor = System.Drawing.Color.White;
            this.btnRelatorios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Image = global::SisControl.Properties.Resources.Relatorios32;
            this.btnRelatorios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRelatorios.Location = new System.Drawing.Point(570, 3);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(75, 65);
            this.btnRelatorios.TabIndex = 9;
            this.btnRelatorios.Text = "&Relatórios";
            this.btnRelatorios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRelatorios.UseVisualStyleBackColor = false;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.LayoutPanelGeral);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.LayoutPanelGeral.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnFornecedor;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnFerramentas;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnContaReceber;
        private System.Windows.Forms.FlowLayoutPanel LayoutPanelGeral;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnRelatorios;
    }
}
