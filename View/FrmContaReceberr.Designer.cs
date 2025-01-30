namespace SisControl.View
{
    partial class FrmContaReceberr
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
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.dtpDataVencimentoInicio = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpDataVencimentoFim = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioBtnAberto = new System.Windows.Forms.RadioButton();
            this.radioBtnPago = new System.Windows.Forms.RadioButton();
            this.txtClienteID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtNomeCliente = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.cmbFiltro = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.gbStatus = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.gbPeriodo = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.gbNome = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btnLocalizarCliente = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnFiltro = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgvContasReceber = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.btnSair = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnReceberConta = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgPagamentosParciais = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.label28 = new System.Windows.Forms.Label();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.btnExcluirConta = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtTotalPago = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtTotalEmAberto = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbStatus.Panel)).BeginInit();
            this.gbStatus.Panel.SuspendLayout();
            this.gbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbPeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbPeriodo.Panel)).BeginInit();
            this.gbPeriodo.Panel.SuspendLayout();
            this.gbPeriodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbNome.Panel)).BeginInit();
            this.gbNome.Panel.SuspendLayout();
            this.gbNome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContasReceber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPagamentosParciais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblTotalRegistros.ForeColor = System.Drawing.Color.White;
            this.lblTotalRegistros.Location = new System.Drawing.Point(12, 488);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(13, 17);
            this.lblTotalRegistros.TabIndex = 576;
            this.lblTotalRegistros.Text = "-";
            // 
            // dtpDataVencimentoInicio
            // 
            this.dtpDataVencimentoInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVencimentoInicio.Location = new System.Drawing.Point(95, 14);
            this.dtpDataVencimentoInicio.Name = "dtpDataVencimentoInicio";
            this.dtpDataVencimentoInicio.Size = new System.Drawing.Size(97, 21);
            this.dtpDataVencimentoInicio.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.dtpDataVencimentoInicio.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.dtpDataVencimentoInicio.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpDataVencimentoInicio.TabIndex = 595;
            // 
            // dtpDataVencimentoFim
            // 
            this.dtpDataVencimentoFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVencimentoFim.Location = new System.Drawing.Point(278, 14);
            this.dtpDataVencimentoFim.Name = "dtpDataVencimentoFim";
            this.dtpDataVencimentoFim.Size = new System.Drawing.Size(97, 21);
            this.dtpDataVencimentoFim.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.dtpDataVencimentoFim.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.dtpDataVencimentoFim.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpDataVencimentoFim.TabIndex = 594;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(194, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 578;
            this.label1.Text = "Data Final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 579;
            this.label2.Text = "Data Inícial";
            // 
            // radioBtnAberto
            // 
            this.radioBtnAberto.AutoSize = true;
            this.radioBtnAberto.BackColor = System.Drawing.Color.White;
            this.radioBtnAberto.Checked = true;
            this.radioBtnAberto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnAberto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.radioBtnAberto.Location = new System.Drawing.Point(26, 4);
            this.radioBtnAberto.Name = "radioBtnAberto";
            this.radioBtnAberto.Size = new System.Drawing.Size(75, 24);
            this.radioBtnAberto.TabIndex = 584;
            this.radioBtnAberto.TabStop = true;
            this.radioBtnAberto.Text = "Aberto";
            this.radioBtnAberto.UseVisualStyleBackColor = false;
            // 
            // radioBtnPago
            // 
            this.radioBtnPago.AutoSize = true;
            this.radioBtnPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.radioBtnPago.Location = new System.Drawing.Point(113, 3);
            this.radioBtnPago.Name = "radioBtnPago";
            this.radioBtnPago.Size = new System.Drawing.Size(64, 24);
            this.radioBtnPago.TabIndex = 585;
            this.radioBtnPago.TabStop = true;
            this.radioBtnPago.Text = "Pago";
            this.radioBtnPago.UseVisualStyleBackColor = true;
            // 
            // txtClienteID
            // 
            this.txtClienteID.Location = new System.Drawing.Point(11, 19);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.Size = new System.Drawing.Size(88, 23);
            this.txtClienteID.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.txtClienteID.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.txtClienteID.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtClienteID.TabIndex = 593;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(105, 19);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(286, 23);
            this.txtNomeCliente.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.txtNomeCliente.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.txtNomeCliente.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNomeCliente.TabIndex = 592;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.label14.Location = new System.Drawing.Point(98, -2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 15);
            this.label14.TabIndex = 573;
            this.label14.Text = "Nome Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(11, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 575;
            this.label3.Text = "ID Cliente";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonForm;
            this.kryptonGroupBox1.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonAlternate;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(4, 63);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.cmbFiltro);
            this.kryptonGroupBox1.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonGroupBox1_Panel_Paint);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(198, 68);
            this.kryptonGroupBox1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonGroupBox1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonGroupBox1.StateCommon.Border.ColorAngle = 45F;
            this.kryptonGroupBox1.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidTopLine;
            this.kryptonGroupBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox1.StateCommon.Border.Width = 1;
            this.kryptonGroupBox1.TabIndex = 587;
            this.kryptonGroupBox1.Values.Heading = "Filtrar Por";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.DropDownWidth = 244;
            this.cmbFiltro.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.cmbFiltro.Items.AddRange(new object[] {
            "",
            "Nome",
            "Período",
            "Status"});
            this.cmbFiltro.Location = new System.Drawing.Point(6, 13);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.cmbFiltro.Size = new System.Drawing.Size(174, 21);
            this.cmbFiltro.TabIndex = 588;
            this.cmbFiltro.SelectedValueChanged += new System.EventHandler(this.cmbFiltro_SelectedValueChanged);
            // 
            // gbStatus
            // 
            this.gbStatus.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl;
            this.gbStatus.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlAlternate;
            this.gbStatus.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlCustom1;
            this.gbStatus.Location = new System.Drawing.Point(218, 63);
            this.gbStatus.Name = "gbStatus";
            // 
            // gbStatus.Panel
            // 
            this.gbStatus.Panel.Controls.Add(this.radioBtnAberto);
            this.gbStatus.Panel.Controls.Add(this.radioBtnPago);
            this.gbStatus.Size = new System.Drawing.Size(208, 68);
            this.gbStatus.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.gbStatus.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.gbStatus.StateCommon.Border.ColorAngle = 45F;
            this.gbStatus.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidTopLine;
            this.gbStatus.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gbStatus.StateCommon.Border.Width = 1;
            this.gbStatus.TabIndex = 588;
            this.gbStatus.Values.Heading = "Status";
            this.gbStatus.Visible = false;
            // 
            // gbPeriodo
            // 
            this.gbPeriodo.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl;
            this.gbPeriodo.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlAlternate;
            this.gbPeriodo.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlCustom1;
            this.gbPeriodo.Location = new System.Drawing.Point(218, 63);
            this.gbPeriodo.Name = "gbPeriodo";
            // 
            // gbPeriodo.Panel
            // 
            this.gbPeriodo.Panel.Controls.Add(this.dtpDataVencimentoInicio);
            this.gbPeriodo.Panel.Controls.Add(this.dtpDataVencimentoFim);
            this.gbPeriodo.Panel.Controls.Add(this.label2);
            this.gbPeriodo.Panel.Controls.Add(this.label1);
            this.gbPeriodo.Size = new System.Drawing.Size(385, 68);
            this.gbPeriodo.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.gbPeriodo.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.gbPeriodo.StateCommon.Border.ColorAngle = 45F;
            this.gbPeriodo.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidTopLine;
            this.gbPeriodo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gbPeriodo.StateCommon.Border.Width = 1;
            this.gbPeriodo.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPeriodo.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPeriodo.TabIndex = 589;
            this.gbPeriodo.Values.Heading = "Período";
            this.gbPeriodo.Visible = false;
            // 
            // gbNome
            // 
            this.gbNome.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl;
            this.gbNome.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlAlternate;
            this.gbNome.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlCustom1;
            this.gbNome.Location = new System.Drawing.Point(218, 64);
            this.gbNome.Name = "gbNome";
            // 
            // gbNome.Panel
            // 
            this.gbNome.Panel.Controls.Add(this.btnLocalizarCliente);
            this.gbNome.Panel.Controls.Add(this.txtClienteID);
            this.gbNome.Panel.Controls.Add(this.txtNomeCliente);
            this.gbNome.Panel.Controls.Add(this.label3);
            this.gbNome.Panel.Controls.Add(this.label14);
            this.gbNome.Size = new System.Drawing.Size(534, 68);
            this.gbNome.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.gbNome.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.gbNome.StateCommon.Border.ColorAngle = 45F;
            this.gbNome.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidTopLine;
            this.gbNome.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gbNome.StateCommon.Border.Width = 1;
            this.gbNome.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNome.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNome.TabIndex = 590;
            this.gbNome.Values.Heading = "Nome";
            this.gbNome.Visible = false;
            // 
            // btnLocalizarCliente
            // 
            this.btnLocalizarCliente.Location = new System.Drawing.Point(397, 18);
            this.btnLocalizarCliente.Name = "btnLocalizarCliente";
            this.btnLocalizarCliente.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnLocalizarCliente.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnLocalizarCliente.OverrideDefault.Back.ColorAngle = 45F;
            this.btnLocalizarCliente.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnLocalizarCliente.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnLocalizarCliente.OverrideDefault.Border.ColorAngle = 45F;
            this.btnLocalizarCliente.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLocalizarCliente.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnLocalizarCliente.OverrideDefault.Border.Rounding = 20;
            this.btnLocalizarCliente.OverrideDefault.Border.Width = 1;
            this.btnLocalizarCliente.OverrideDefault.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizarCliente.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizarCliente.OverrideFocus.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizarCliente.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizarCliente.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnLocalizarCliente.Size = new System.Drawing.Size(129, 24);
            this.btnLocalizarCliente.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnLocalizarCliente.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnLocalizarCliente.StateCommon.Back.ColorAngle = 45F;
            this.btnLocalizarCliente.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnLocalizarCliente.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnLocalizarCliente.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLocalizarCliente.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnLocalizarCliente.StateCommon.Border.Rounding = 0;
            this.btnLocalizarCliente.StateCommon.Border.Width = 1;
            this.btnLocalizarCliente.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizarCliente.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnLocalizarCliente.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnLocalizarCliente.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizarCliente.StateDisabled.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizarCliente.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizarCliente.StateNormal.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizarCliente.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizarCliente.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnLocalizarCliente.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnLocalizarCliente.StatePressed.Back.ColorAngle = 135F;
            this.btnLocalizarCliente.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnLocalizarCliente.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnLocalizarCliente.StatePressed.Border.ColorAngle = 135F;
            this.btnLocalizarCliente.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLocalizarCliente.StatePressed.Border.Rounding = 20;
            this.btnLocalizarCliente.StatePressed.Border.Width = 1;
            this.btnLocalizarCliente.StatePressed.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizarCliente.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizarCliente.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnLocalizarCliente.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnLocalizarCliente.StateTracking.Back.ColorAngle = 45F;
            this.btnLocalizarCliente.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnLocalizarCliente.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnLocalizarCliente.StateTracking.Border.ColorAngle = 45F;
            this.btnLocalizarCliente.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLocalizarCliente.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnLocalizarCliente.StateTracking.Border.Rounding = 20;
            this.btnLocalizarCliente.StateTracking.Border.Width = 1;
            this.btnLocalizarCliente.StateTracking.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizarCliente.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnLocalizarCliente.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizarCliente.TabIndex = 595;
            this.btnLocalizarCliente.Values.Text = "&Localizar";
            this.btnLocalizarCliente.Click += new System.EventHandler(this.btnLocalizarCliente_Click);
            // 
            // btnFiltro
            // 
            this.btnFiltro.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.btnFiltro.Location = new System.Drawing.Point(609, 96);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnFiltro.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnFiltro.OverrideDefault.Back.ColorAngle = 45F;
            this.btnFiltro.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnFiltro.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnFiltro.OverrideDefault.Border.ColorAngle = 45F;
            this.btnFiltro.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnFiltro.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnFiltro.OverrideDefault.Border.Rounding = 20;
            this.btnFiltro.OverrideDefault.Border.Width = 1;
            this.btnFiltro.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btnFiltro.Size = new System.Drawing.Size(113, 35);
            this.btnFiltro.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnFiltro.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnFiltro.StateCommon.Back.ColorAngle = 45F;
            this.btnFiltro.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnFiltro.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnFiltro.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnFiltro.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnFiltro.StateCommon.Border.Rounding = 0;
            this.btnFiltro.StateCommon.Border.Width = 1;
            this.btnFiltro.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnFiltro.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnFiltro.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltro.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnFiltro.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnFiltro.StatePressed.Back.ColorAngle = 135F;
            this.btnFiltro.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnFiltro.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnFiltro.StatePressed.Border.ColorAngle = 135F;
            this.btnFiltro.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnFiltro.StatePressed.Border.Rounding = 20;
            this.btnFiltro.StatePressed.Border.Width = 1;
            this.btnFiltro.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnFiltro.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnFiltro.StateTracking.Back.ColorAngle = 45F;
            this.btnFiltro.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnFiltro.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnFiltro.StateTracking.Border.ColorAngle = 45F;
            this.btnFiltro.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnFiltro.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnFiltro.StateTracking.Border.Rounding = 20;
            this.btnFiltro.StateTracking.Border.Width = 1;
            this.btnFiltro.TabIndex = 591;
            this.btnFiltro.Values.Image = global::SisControl.Properties.Resources.localizador16;
            this.btnFiltro.Values.Text = "&Filtrar";
            this.btnFiltro.Visible = false;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // dgvContasReceber
            // 
            this.dgvContasReceber.AllowUserToAddRows = false;
            this.dgvContasReceber.AllowUserToDeleteRows = false;
            this.dgvContasReceber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContasReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContasReceber.Location = new System.Drawing.Point(4, 167);
            this.dgvContasReceber.MultiSelect = false;
            this.dgvContasReceber.Name = "dgvContasReceber";
            this.dgvContasReceber.ReadOnly = true;
            this.dgvContasReceber.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContasReceber.Size = new System.Drawing.Size(590, 223);
            this.dgvContasReceber.TabIndex = 592;
            this.dgvContasReceber.SelectionChanged += new System.EventHandler(this.dgvContasReceber_SelectionChanged);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.btnSair.Location = new System.Drawing.Point(740, 471);
            this.btnSair.Name = "btnSair";
            this.btnSair.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSair.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSair.OverrideDefault.Back.ColorAngle = 45F;
            this.btnSair.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSair.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSair.OverrideDefault.Border.ColorAngle = 45F;
            this.btnSair.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSair.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSair.OverrideDefault.Border.Rounding = 20;
            this.btnSair.OverrideDefault.Border.Width = 1;
            this.btnSair.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.btnSair.Size = new System.Drawing.Size(151, 43);
            this.btnSair.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSair.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSair.StateCommon.Back.ColorAngle = 45F;
            this.btnSair.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSair.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSair.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSair.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSair.StateCommon.Border.Rounding = 1;
            this.btnSair.StateCommon.Border.Width = 1;
            this.btnSair.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSair.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSair.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnSair.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnSair.StatePressed.Back.ColorAngle = 135F;
            this.btnSair.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnSair.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnSair.StatePressed.Border.ColorAngle = 135F;
            this.btnSair.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSair.StatePressed.Border.Rounding = 20;
            this.btnSair.StatePressed.Border.Width = 1;
            this.btnSair.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSair.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSair.StateTracking.Back.ColorAngle = 45F;
            this.btnSair.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnSair.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnSair.StateTracking.Border.ColorAngle = 45F;
            this.btnSair.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSair.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSair.StateTracking.Border.Rounding = 20;
            this.btnSair.StateTracking.Border.Width = 1;
            this.btnSair.TabIndex = 593;
            this.btnSair.Values.Text = "&Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnReceberConta
            // 
            this.btnReceberConta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReceberConta.Location = new System.Drawing.Point(422, 471);
            this.btnReceberConta.Name = "btnReceberConta";
            this.btnReceberConta.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnReceberConta.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnReceberConta.OverrideDefault.Back.ColorAngle = 45F;
            this.btnReceberConta.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnReceberConta.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnReceberConta.OverrideDefault.Border.ColorAngle = 45F;
            this.btnReceberConta.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnReceberConta.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnReceberConta.OverrideDefault.Border.Rounding = 20;
            this.btnReceberConta.OverrideDefault.Border.Width = 1;
            this.btnReceberConta.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnReceberConta.Size = new System.Drawing.Size(151, 43);
            this.btnReceberConta.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnReceberConta.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnReceberConta.StateCommon.Back.ColorAngle = 45F;
            this.btnReceberConta.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnReceberConta.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnReceberConta.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnReceberConta.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnReceberConta.StateCommon.Border.Rounding = 1;
            this.btnReceberConta.StateCommon.Border.Width = 1;
            this.btnReceberConta.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnReceberConta.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnReceberConta.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceberConta.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnReceberConta.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnReceberConta.StatePressed.Back.ColorAngle = 135F;
            this.btnReceberConta.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnReceberConta.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnReceberConta.StatePressed.Border.ColorAngle = 135F;
            this.btnReceberConta.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnReceberConta.StatePressed.Border.Rounding = 20;
            this.btnReceberConta.StatePressed.Border.Width = 1;
            this.btnReceberConta.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnReceberConta.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnReceberConta.StateTracking.Back.ColorAngle = 45F;
            this.btnReceberConta.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnReceberConta.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnReceberConta.StateTracking.Border.ColorAngle = 45F;
            this.btnReceberConta.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnReceberConta.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnReceberConta.StateTracking.Border.Rounding = 20;
            this.btnReceberConta.StateTracking.Border.Width = 1;
            this.btnReceberConta.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnReceberConta.TabIndex = 594;
            this.btnReceberConta.Values.Text = "&Receber Conta";
            this.btnReceberConta.Click += new System.EventHandler(this.btnReceberConta_Click);
            // 
            // dgPagamentosParciais
            // 
            this.dgPagamentosParciais.AllowUserToAddRows = false;
            this.dgPagamentosParciais.AllowUserToDeleteRows = false;
            this.dgPagamentosParciais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPagamentosParciais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPagamentosParciais.Location = new System.Drawing.Point(652, 167);
            this.dgPagamentosParciais.MultiSelect = false;
            this.dgPagamentosParciais.Name = "dgPagamentosParciais";
            this.dgPagamentosParciais.ReadOnly = true;
            this.dgPagamentosParciais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPagamentosParciais.Size = new System.Drawing.Size(261, 223);
            this.dgPagamentosParciais.TabIndex = 595;
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label28.ForeColor = System.Drawing.Color.Green;
            this.label28.Location = new System.Drawing.Point(354, 7);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(202, 24);
            this.label28.TabIndex = 614;
            this.label28.Text = "CONTAS A RECEBER";
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonGroupBox2.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl;
            this.kryptonGroupBox2.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlAlternate;
            this.kryptonGroupBox2.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlCustom1;
            this.kryptonGroupBox2.Location = new System.Drawing.Point(4, 0);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.label28);
            this.kryptonGroupBox2.Panel.Controls.Add(this.label5);
            this.kryptonGroupBox2.Panel.Controls.Add(this.lblNomeCliente);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(919, 40);
            this.kryptonGroupBox2.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonGroupBox2.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonGroupBox2.StateCommon.Border.ColorAngle = 45F;
            this.kryptonGroupBox2.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidTopLine;
            this.kryptonGroupBox2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox2.StateCommon.Border.Width = 1;
            this.kryptonGroupBox2.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox2.TabIndex = 615;
            this.kryptonGroupBox2.Values.Heading = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.label5.Location = new System.Drawing.Point(7, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 616;
            this.label5.Text = "CLIENTE:";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblNomeCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.lblNomeCliente.Location = new System.Drawing.Point(84, 11);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(13, 17);
            this.lblNomeCliente.TabIndex = 617;
            this.lblNomeCliente.Text = "-";
            // 
            // btnExcluirConta
            // 
            this.btnExcluirConta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirConta.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.btnExcluirConta.Location = new System.Drawing.Point(581, 471);
            this.btnExcluirConta.Name = "btnExcluirConta";
            this.btnExcluirConta.OverrideDefault.Back.Color1 = System.Drawing.Color.Red;
            this.btnExcluirConta.OverrideDefault.Back.Color2 = System.Drawing.Color.Red;
            this.btnExcluirConta.OverrideDefault.Back.ColorAngle = 45F;
            this.btnExcluirConta.OverrideDefault.Border.Color1 = System.Drawing.Color.Red;
            this.btnExcluirConta.OverrideDefault.Border.Color2 = System.Drawing.Color.Red;
            this.btnExcluirConta.OverrideDefault.Border.ColorAngle = 45F;
            this.btnExcluirConta.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExcluirConta.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnExcluirConta.OverrideDefault.Border.Rounding = 20;
            this.btnExcluirConta.OverrideDefault.Border.Width = 1;
            this.btnExcluirConta.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btnExcluirConta.Size = new System.Drawing.Size(151, 43);
            this.btnExcluirConta.StateCommon.Back.Color1 = System.Drawing.Color.Red;
            this.btnExcluirConta.StateCommon.Back.Color2 = System.Drawing.Color.Red;
            this.btnExcluirConta.StateCommon.Back.ColorAngle = 45F;
            this.btnExcluirConta.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnExcluirConta.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnExcluirConta.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExcluirConta.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnExcluirConta.StateCommon.Border.Rounding = 0;
            this.btnExcluirConta.StateCommon.Border.Width = 1;
            this.btnExcluirConta.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnExcluirConta.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnExcluirConta.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirConta.StatePressed.Back.Color1 = System.Drawing.Color.Red;
            this.btnExcluirConta.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnExcluirConta.StatePressed.Back.ColorAngle = 135F;
            this.btnExcluirConta.StatePressed.Border.Color1 = System.Drawing.Color.Red;
            this.btnExcluirConta.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnExcluirConta.StatePressed.Border.ColorAngle = 135F;
            this.btnExcluirConta.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExcluirConta.StatePressed.Border.Rounding = 20;
            this.btnExcluirConta.StatePressed.Border.Width = 1;
            this.btnExcluirConta.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnExcluirConta.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnExcluirConta.StateTracking.Back.ColorAngle = 45F;
            this.btnExcluirConta.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnExcluirConta.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnExcluirConta.StateTracking.Border.ColorAngle = 45F;
            this.btnExcluirConta.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExcluirConta.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnExcluirConta.StateTracking.Border.Rounding = 20;
            this.btnExcluirConta.StateTracking.Border.Width = 1;
            this.btnExcluirConta.TabIndex = 626;
            this.btnExcluirConta.Values.Text = "&Excluir Conta";
            this.btnExcluirConta.Click += new System.EventHandler(this.btnExcluirConta_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.txtTotalPago);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.txtTotalEmAberto);
            this.kryptonPanel1.Location = new System.Drawing.Point(3, 532);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.kryptonPanel1.Size = new System.Drawing.Size(918, 43);
            this.kryptonPanel1.TabIndex = 628;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(300, 7);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(133, 29);
            this.kryptonLabel2.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateDisabled.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateDisabled.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel2.TabIndex = 612;
            this.kryptonLabel2.Values.Text = "TOTAL PAGO:";
            // 
            // txtTotalPago
            // 
            this.txtTotalPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalPago.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.txtTotalPago.Location = new System.Drawing.Point(439, 8);
            this.txtTotalPago.Name = "txtTotalPago";
            this.txtTotalPago.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.txtTotalPago.ReadOnly = true;
            this.txtTotalPago.Size = new System.Drawing.Size(131, 26);
            this.txtTotalPago.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtTotalPago.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.txtTotalPago.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.txtTotalPago.StateCommon.Border.ColorAngle = 1F;
            this.txtTotalPago.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTotalPago.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtTotalPago.StateCommon.Border.Rounding = 1;
            this.txtTotalPago.StateCommon.Border.Width = 1;
            this.txtTotalPago.StateCommon.Content.Color1 = System.Drawing.Color.Green;
            this.txtTotalPago.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPago.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtTotalPago.TabIndex = 613;
            this.txtTotalPago.TabStop = false;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonLabel3.Location = new System.Drawing.Point(583, 8);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(180, 29);
            this.kryptonLabel3.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.StateDisabled.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.StateDisabled.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel3.TabIndex = 3;
            this.kryptonLabel3.Values.Text = "TOTAL EM ABERTO";
            // 
            // txtTotalEmAberto
            // 
            this.txtTotalEmAberto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalEmAberto.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.txtTotalEmAberto.Location = new System.Drawing.Point(757, 10);
            this.txtTotalEmAberto.Name = "txtTotalEmAberto";
            this.txtTotalEmAberto.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.txtTotalEmAberto.ReadOnly = true;
            this.txtTotalEmAberto.Size = new System.Drawing.Size(131, 26);
            this.txtTotalEmAberto.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtTotalEmAberto.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.txtTotalEmAberto.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.txtTotalEmAberto.StateCommon.Border.ColorAngle = 1F;
            this.txtTotalEmAberto.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTotalEmAberto.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtTotalEmAberto.StateCommon.Border.Rounding = 1;
            this.txtTotalEmAberto.StateCommon.Border.Width = 1;
            this.txtTotalEmAberto.StateCommon.Content.Color1 = System.Drawing.Color.Green;
            this.txtTotalEmAberto.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalEmAberto.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtTotalEmAberto.TabIndex = 609;
            this.txtTotalEmAberto.TabStop = false;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel2.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel2.Location = new System.Drawing.Point(653, 136);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.kryptonPanel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.kryptonPanel2.Size = new System.Drawing.Size(260, 29);
            this.kryptonPanel2.TabIndex = 629;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(23, -3);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(231, 29);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateDisabled.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateDisabled.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.TabIndex = 614;
            this.kryptonLabel1.Values.Text = "Histórico de pagamentos";
            // 
            // FrmContaReceberr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(925, 580);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.btnExcluirConta);
            this.Controls.Add(this.kryptonGroupBox2);
            this.Controls.Add(this.dgPagamentosParciais);
            this.Controls.Add(this.btnReceberConta);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dgvContasReceber);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.gbNome);
            this.Controls.Add(this.gbPeriodo);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.kryptonGroupBox1);
            this.Controls.Add(this.lblTotalRegistros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmContaReceberr";
            this.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Text = "Manutenção de Conta a Receber";
            this.Load += new System.EventHandler(this.FrmContaReceber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbStatus.Panel)).EndInit();
            this.gbStatus.Panel.ResumeLayout(false);
            this.gbStatus.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbStatus)).EndInit();
            this.gbStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbPeriodo.Panel)).EndInit();
            this.gbPeriodo.Panel.ResumeLayout(false);
            this.gbPeriodo.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbPeriodo)).EndInit();
            this.gbPeriodo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbNome.Panel)).EndInit();
            this.gbNome.Panel.ResumeLayout(false);
            this.gbNome.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbNome)).EndInit();
            this.gbNome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContasReceber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPagamentosParciais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTotalRegistros;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpDataVencimentoInicio;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpDataVencimentoFim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioBtnAberto;
        private System.Windows.Forms.RadioButton radioBtnPago;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        public ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbFiltro;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbPeriodo;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbNome;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnFiltro;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvContasReceber;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSair;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnReceberConta;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtClienteID;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNomeCliente;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnLocalizarCliente;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgPagamentosParciais;
        private System.Windows.Forms.Label label28;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExcluirConta;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTotalEmAberto;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTotalPago;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}
