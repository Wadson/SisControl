<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 52ded11ebc2146f3d05bb3a76b0841fddc107b63
﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisControl
{
    internal class CustomTextBox : TextBox // Herda de TextBox para ter acesso aos eventos Enter e Leave
    {
        public CustomTextBox()
        {
            this.Enter += new EventHandler(CustomTextBox_Enter);
            this.Leave += new EventHandler(CustomTextBox_Leave);
        }

        private void CustomTextBox_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue; // Azul claro quando entra no foco
        }

        private void CustomTextBox_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.White; // Branco quando perde o foco
        }
    }
}
<<<<<<< HEAD
=======
=======
﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisControl
{
    internal class CustomTextBox : TextBox // Herda de TextBox para ter acesso aos eventos Enter e Leave
    {
        public CustomTextBox()
        {
            this.Enter += new EventHandler(CustomTextBox_Enter);
            this.Leave += new EventHandler(CustomTextBox_Leave);
        }

        private void CustomTextBox_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue; // Azul claro quando entra no foco
        }

        private void CustomTextBox_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.White; // Branco quando perde o foco
        }
    }
}
>>>>>>> 4d7533ac6658105f916433324377f073e909b48b
>>>>>>> 52ded11ebc2146f3d05bb3a76b0841fddc107b63
