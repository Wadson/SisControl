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

        private void txtBackup_Click(object sender, EventArgs e)
        {
            FrmBackup frmBackup = new FrmBackup();
            frmBackup.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestaurarBackup_Click(object sender, EventArgs e)
        {
            FrmRestauraBackup frmRestauraBackup = new FrmRestauraBackup();
            frmRestauraBackup.ShowDialog();
        }
    }
}
