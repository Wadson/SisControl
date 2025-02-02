using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SisControl.Relatorios
{
    public partial class FrmRelGeralContasAbertas : SisControl.FrmModeloForm
    {
        public FrmRelGeralContasAbertas()
        {
            InitializeComponent();
        }

        private void FrmRelGeralContasAbertas_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
