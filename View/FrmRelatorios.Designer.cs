﻿namespace SisControl.View
{
    partial class FrmRelatorios
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
            this.btnImprimir = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgvPesquisar = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.gbNomeCliente = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btnPesquisar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtClienteID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtNomeCliente = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPeriodo = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.dtpDataVencimentoInicio = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpDataVencimentoFim = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbStatus = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.rbAberto = new System.Windows.Forms.RadioButton();
            this.rbPago = new System.Windows.Forms.RadioButton();
            this.btnFiltro = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.cmbFiltro = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblTotal = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbNomeCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbNomeCliente.Panel)).BeginInit();
            this.gbNomeCliente.Panel.SuspendLayout();
            this.gbNomeCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbPeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbPeriodo.Panel)).BeginInit();
            this.gbPeriodo.Panel.SuspendLayout();
            this.gbPeriodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbStatus.Panel)).BeginInit();
            this.gbStatus.Panel.SuspendLayout();
            this.gbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(844, 405);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnImprimir.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnImprimir.OverrideDefault.Back.ColorAngle = 45F;
            this.btnImprimir.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnImprimir.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnImprimir.OverrideDefault.Border.ColorAngle = 45F;
            this.btnImprimir.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnImprimir.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnImprimir.OverrideDefault.Border.Rounding = 20;
            this.btnImprimir.OverrideDefault.Border.Width = 1;
            this.btnImprimir.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnImprimir.Size = new System.Drawing.Size(121, 35);
            this.btnImprimir.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnImprimir.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnImprimir.StateCommon.Back.ColorAngle = 45F;
            this.btnImprimir.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnImprimir.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnImprimir.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnImprimir.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnImprimir.StateCommon.Border.Rounding = 20;
            this.btnImprimir.StateCommon.Border.Width = 1;
            this.btnImprimir.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnImprimir.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnImprimir.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnImprimir.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnImprimir.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnImprimir.StatePressed.Back.ColorAngle = 135F;
            this.btnImprimir.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnImprimir.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnImprimir.StatePressed.Border.ColorAngle = 135F;
            this.btnImprimir.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnImprimir.StatePressed.Border.Rounding = 20;
            this.btnImprimir.StatePressed.Border.Width = 1;
            this.btnImprimir.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnImprimir.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnImprimir.StateTracking.Back.ColorAngle = 45F;
            this.btnImprimir.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnImprimir.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnImprimir.StateTracking.Border.ColorAngle = 45F;
            this.btnImprimir.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnImprimir.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnImprimir.StateTracking.Border.Rounding = 20;
            this.btnImprimir.StateTracking.Border.Width = 1;
            this.btnImprimir.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Values.Text = "Imprimir";
            // 
            // dgvPesquisar
            // 
            this.dgvPesquisar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisar.Location = new System.Drawing.Point(12, 113);
            this.dgvPesquisar.Name = "dgvPesquisar";
            this.dgvPesquisar.Size = new System.Drawing.Size(953, 286);
            this.dgvPesquisar.TabIndex = 5;
            // 
            // gbNomeCliente
            // 
            this.gbNomeCliente.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl;
            this.gbNomeCliente.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlAlternate;
            this.gbNomeCliente.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlCustom1;
            this.gbNomeCliente.Location = new System.Drawing.Point(426, 12);
            this.gbNomeCliente.Name = "gbNomeCliente";
            // 
            // gbNomeCliente.Panel
            // 
            this.gbNomeCliente.Panel.Controls.Add(this.btnPesquisar);
            this.gbNomeCliente.Panel.Controls.Add(this.txtClienteID);
            this.gbNomeCliente.Panel.Controls.Add(this.txtNomeCliente);
            this.gbNomeCliente.Panel.Controls.Add(this.label3);
            this.gbNomeCliente.Panel.Controls.Add(this.label1);
            this.gbNomeCliente.Size = new System.Drawing.Size(442, 68);
            this.gbNomeCliente.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.gbNomeCliente.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.gbNomeCliente.StateCommon.Border.ColorAngle = 45F;
            this.gbNomeCliente.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidTopLine;
            this.gbNomeCliente.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gbNomeCliente.StateCommon.Border.Width = 1;
            this.gbNomeCliente.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNomeCliente.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNomeCliente.TabIndex = 591;
            this.gbNomeCliente.Values.Heading = "Nome";
            this.gbNomeCliente.Visible = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(362, 18);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnPesquisar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnPesquisar.OverrideDefault.Back.ColorAngle = 45F;
            this.btnPesquisar.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnPesquisar.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnPesquisar.OverrideDefault.Border.ColorAngle = 45F;
            this.btnPesquisar.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPesquisar.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnPesquisar.OverrideDefault.Border.Rounding = 20;
            this.btnPesquisar.OverrideDefault.Border.Width = 1;
            this.btnPesquisar.OverrideDefault.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.OverrideFocus.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnPesquisar.Size = new System.Drawing.Size(74, 24);
            this.btnPesquisar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnPesquisar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnPesquisar.StateCommon.Back.ColorAngle = 45F;
            this.btnPesquisar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnPesquisar.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnPesquisar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPesquisar.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnPesquisar.StateCommon.Border.Rounding = 0;
            this.btnPesquisar.StateCommon.Border.Width = 1;
            this.btnPesquisar.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnPesquisar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnPesquisar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.StateDisabled.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.StateNormal.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnPesquisar.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnPesquisar.StatePressed.Back.ColorAngle = 135F;
            this.btnPesquisar.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btnPesquisar.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btnPesquisar.StatePressed.Border.ColorAngle = 135F;
            this.btnPesquisar.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPesquisar.StatePressed.Border.Rounding = 20;
            this.btnPesquisar.StatePressed.Border.Width = 1;
            this.btnPesquisar.StatePressed.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnPesquisar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnPesquisar.StateTracking.Back.ColorAngle = 45F;
            this.btnPesquisar.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btnPesquisar.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btnPesquisar.StateTracking.Border.ColorAngle = 45F;
            this.btnPesquisar.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPesquisar.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnPesquisar.StateTracking.Border.Rounding = 20;
            this.btnPesquisar.StateTracking.Border.Width = 1;
            this.btnPesquisar.StateTracking.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnPesquisar.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.TabIndex = 595;
            this.btnPesquisar.Values.Text = "&Localizar";
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtClienteID
            // 
            this.txtClienteID.Location = new System.Drawing.Point(7, 19);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.Size = new System.Drawing.Size(60, 23);
            this.txtClienteID.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.txtClienteID.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.txtClienteID.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtClienteID.TabIndex = 593;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(70, 19);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(286, 23);
            this.txtNomeCliente.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.txtNomeCliente.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.txtNomeCliente.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNomeCliente.TabIndex = 592;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(7, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 575;
            this.label3.Text = "ID Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(63, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 573;
            this.label1.Text = "Nome Cliente";
            // 
            // gbPeriodo
            // 
            this.gbPeriodo.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl;
            this.gbPeriodo.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlAlternate;
            this.gbPeriodo.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlCustom1;
            this.gbPeriodo.Location = new System.Drawing.Point(422, 13);
            this.gbPeriodo.Name = "gbPeriodo";
            // 
            // gbPeriodo.Panel
            // 
            this.gbPeriodo.Panel.Controls.Add(this.dtpDataVencimentoInicio);
            this.gbPeriodo.Panel.Controls.Add(this.dtpDataVencimentoFim);
            this.gbPeriodo.Panel.Controls.Add(this.label2);
            this.gbPeriodo.Panel.Controls.Add(this.label4);
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
            this.gbPeriodo.TabIndex = 592;
            this.gbPeriodo.Values.Heading = "Período";
            this.gbPeriodo.Visible = false;
            // 
            // dtpDataVencimentoInicio
            // 
            this.dtpDataVencimentoInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVencimentoInicio.Location = new System.Drawing.Point(83, 12);
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
            this.dtpDataVencimentoFim.Location = new System.Drawing.Point(268, 12);
            this.dtpDataVencimentoFim.Name = "dtpDataVencimentoFim";
            this.dtpDataVencimentoFim.Size = new System.Drawing.Size(97, 21);
            this.dtpDataVencimentoFim.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.dtpDataVencimentoFim.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.dtpDataVencimentoFim.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpDataVencimentoFim.TabIndex = 594;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 579;
            this.label2.Text = "Data Inícial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(194, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 578;
            this.label4.Text = "Data Final";
            // 
            // gbStatus
            // 
            this.gbStatus.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl;
            this.gbStatus.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlAlternate;
            this.gbStatus.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlCustom1;
            this.gbStatus.Location = new System.Drawing.Point(268, 12);
            this.gbStatus.Name = "gbStatus";
            // 
            // gbStatus.Panel
            // 
            this.gbStatus.Panel.Controls.Add(this.rbAberto);
            this.gbStatus.Panel.Controls.Add(this.rbPago);
            this.gbStatus.Size = new System.Drawing.Size(150, 68);
            this.gbStatus.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.gbStatus.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.gbStatus.StateCommon.Border.ColorAngle = 45F;
            this.gbStatus.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidTopLine;
            this.gbStatus.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gbStatus.StateCommon.Border.Width = 1;
            this.gbStatus.TabIndex = 593;
            this.gbStatus.Values.Heading = "Status";
            this.gbStatus.Visible = false;
            // 
            // rbAberto
            // 
            this.rbAberto.AutoSize = true;
            this.rbAberto.BackColor = System.Drawing.Color.White;
            this.rbAberto.Checked = true;
            this.rbAberto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAberto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.rbAberto.Location = new System.Drawing.Point(8, 12);
            this.rbAberto.Name = "rbAberto";
            this.rbAberto.Size = new System.Drawing.Size(75, 24);
            this.rbAberto.TabIndex = 584;
            this.rbAberto.TabStop = true;
            this.rbAberto.Text = "Aberto";
            this.rbAberto.UseVisualStyleBackColor = false;
            // 
            // rbPago
            // 
            this.rbPago.AutoSize = true;
            this.rbPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.rbPago.Location = new System.Drawing.Point(84, 13);
            this.rbPago.Name = "rbPago";
            this.rbPago.Size = new System.Drawing.Size(64, 24);
            this.rbPago.TabIndex = 585;
            this.rbPago.TabStop = true;
            this.rbPago.Text = "Pago";
            this.rbPago.UseVisualStyleBackColor = true;
            // 
            // btnFiltro
            // 
            this.btnFiltro.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.btnFiltro.Location = new System.Drawing.Point(874, 44);
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
            this.btnFiltro.Size = new System.Drawing.Size(91, 35);
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
            this.btnFiltro.TabIndex = 594;
            this.btnFiltro.Values.Image = global::SisControl.Properties.Resources.localizador16;
            this.btnFiltro.Values.Text = "&Filtrar";
            this.btnFiltro.Visible = false;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonForm;
            this.kryptonGroupBox1.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonAlternate;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(3, 12);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.cmbFiltro);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(261, 68);
            this.kryptonGroupBox1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonGroupBox1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonGroupBox1.StateCommon.Border.ColorAngle = 45F;
            this.kryptonGroupBox1.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidTopLine;
            this.kryptonGroupBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox1.StateCommon.Border.Width = 1;
            this.kryptonGroupBox1.TabIndex = 595;
            this.kryptonGroupBox1.Values.Heading = "Filtrar Por";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.DropDownWidth = 244;
            this.cmbFiltro.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.cmbFiltro.Items.AddRange(new object[] {
            "",
            "PesquisarPorStatusGeral",
            "PesquisarPorNomeClienteEStatus",
            "PesquisarPorPeriodoEStatus",
            "PesquisarContasVencidas",
            "PesquisarContasNaoVencidas"});
            this.cmbFiltro.Location = new System.Drawing.Point(6, 13);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.cmbFiltro.Size = new System.Drawing.Size(248, 21);
            this.cmbFiltro.TabIndex = 588;
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro_SelectedIndexChanged);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel1.Controls.Add(this.lblTotal);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Location = new System.Drawing.Point(-1, 519);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.kryptonPanel1.Size = new System.Drawing.Size(974, 43);
            this.kryptonPanel1.TabIndex = 629;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonLabel3.Location = new System.Drawing.Point(688, 8);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(159, 29);
            this.kryptonLabel3.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.StateDisabled.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.StateDisabled.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel3.TabIndex = 3;
            this.kryptonLabel3.Values.Text = "TOTAL NA GRID:";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.lblTotal.Location = new System.Drawing.Point(847, 8);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(20, 29);
            this.lblTotal.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.StateDisabled.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.StateDisabled.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.lblTotal.TabIndex = 614;
            this.lblTotal.Values.Text = "-";
            // 
            // FrmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(969, 563);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.kryptonGroupBox1);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.gbPeriodo);
            this.Controls.Add(this.gbNomeCliente);
            this.Controls.Add(this.dgvPesquisar);
            this.Controls.Add(this.btnImprimir);
            this.Name = "FrmRelatorios";
            this.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Load += new System.EventHandler(this.FrmRelatorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbNomeCliente.Panel)).EndInit();
            this.gbNomeCliente.Panel.ResumeLayout(false);
            this.gbNomeCliente.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbNomeCliente)).EndInit();
            this.gbNomeCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbPeriodo.Panel)).EndInit();
            this.gbPeriodo.Panel.ResumeLayout(false);
            this.gbPeriodo.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbPeriodo)).EndInit();
            this.gbPeriodo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbStatus.Panel)).EndInit();
            this.gbStatus.Panel.ResumeLayout(false);
            this.gbStatus.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbStatus)).EndInit();
            this.gbStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btnImprimir;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvPesquisar;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbNomeCliente;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnPesquisar;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtClienteID;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNomeCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbPeriodo;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpDataVencimentoInicio;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpDataVencimentoFim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbAberto;
        private System.Windows.Forms.RadioButton rbPago;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnFiltro;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        public ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbFiltro;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblTotal;
    }
}
