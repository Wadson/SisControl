using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SisControl.View
{
    public partial class FrmFerramentas : SisControl.FrmModeloForm
    {
        public FrmFerramentas()
        {
            InitializeComponent();
        }

        private void btnExcluirRegistrosOrfao_Click(object sender, EventArgs e)
        {
            FrmExclusaoOrfao frmExclusaoOrfao = new FrmExclusaoOrfao();
            frmExclusaoOrfao.ShowDialog();
        }
    }
}
