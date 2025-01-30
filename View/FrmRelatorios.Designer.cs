namespace SisControl.View
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
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.gbNome = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btnLocalizarCliente = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtClienteID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPeriodo = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.dtpDataVencimentoInicio = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpDataVencimentoFim = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbStatus = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.radioBtnAberto = new System.Windows.Forms.RadioButton();
            this.radioBtnPago = new System.Windows.Forms.RadioButton();
            this.btnFiltro = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbNome.Panel)).BeginInit();
            this.gbNome.Panel.SuspendLayout();
            this.gbNome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbPeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbPeriodo.Panel)).BeginInit();
            this.gbPeriodo.Panel.SuspendLayout();
            this.gbPeriodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbStatus.Panel)).BeginInit();
            this.gbStatus.Panel.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(646, 472);
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
            this.btnImprimir.Click += new System.EventHandler(this.btnRelContaPorClienteAberta_Click);
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(12, 172);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.Size = new System.Drawing.Size(755, 294);
            this.kryptonDataGridView1.TabIndex = 5;
            // 
            // gbNome
            // 
            this.gbNome.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicControl;
            this.gbNome.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlAlternate;
            this.gbNome.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlCustom1;
            this.gbNome.Location = new System.Drawing.Point(12, 98);
            this.gbNome.Name = "gbNome";
            // 
            // gbNome.Panel
            // 
            this.gbNome.Panel.Controls.Add(this.btnLocalizarCliente);
            this.gbNome.Panel.Controls.Add(this.txtClienteID);
            this.gbNome.Panel.Controls.Add(this.kryptonTextBox1);
            this.gbNome.Panel.Controls.Add(this.label3);
            this.gbNome.Panel.Controls.Add(this.label1);
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
            this.gbNome.TabIndex = 591;
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
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(105, 19);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(286, 23);
            this.kryptonTextBox1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonTextBox1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonTextBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox1.TabIndex = 592;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(98, -2);
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
            this.gbPeriodo.Location = new System.Drawing.Point(12, 24);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(194, 12);
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
            this.gbStatus.Location = new System.Drawing.Point(403, 24);
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
            this.gbStatus.TabIndex = 593;
            this.gbStatus.Values.Heading = "Status";
            this.gbStatus.Visible = false;
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
            // btnFiltro
            // 
            this.btnFiltro.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Cluster;
            this.btnFiltro.Location = new System.Drawing.Point(637, 43);
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
            this.btnFiltro.TabIndex = 594;
            this.btnFiltro.Values.Image = global::SisControl.Properties.Resources.localizador16;
            this.btnFiltro.Values.Text = "&Filtrar";
            this.btnFiltro.Visible = false;
            // 
            // FrmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(779, 563);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.gbPeriodo);
            this.Controls.Add(this.gbNome);
            this.Controls.Add(this.kryptonDataGridView1);
            this.Controls.Add(this.btnImprimir);
            this.Name = "FrmRelatorios";
            this.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbNome.Panel)).EndInit();
            this.gbNome.Panel.ResumeLayout(false);
            this.gbNome.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbNome)).EndInit();
            this.gbNome.ResumeLayout(false);
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
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btnImprimir;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbNome;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnLocalizarCliente;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtClienteID;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbPeriodo;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpDataVencimentoInicio;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpDataVencimentoFim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox gbStatus;
        private System.Windows.Forms.RadioButton radioBtnAberto;
        private System.Windows.Forms.RadioButton radioBtnPago;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnFiltro;
    }
}
