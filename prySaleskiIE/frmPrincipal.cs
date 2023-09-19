using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySaleskiIE
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void tsmDatos_Click(object sender, EventArgs e)
        {
            Form1 newobj = new Form1();
            newobj.ShowDialog();
        }

        private void tsmResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
