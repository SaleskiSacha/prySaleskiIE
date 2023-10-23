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
            frmView newobj = new frmView();
            newobj.ShowDialog();
            this.Hide();
        }

        private void tsmResultado_Click(object sender, EventArgs e)
        {
            frmEliminar newobj = new frmEliminar();
            newobj.ShowDialog(this);
            this.Hide();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void tsmConsulta_Click(object sender, EventArgs e)
        {
            frmAgregar newobj = new frmAgregar();
            newobj.ShowDialog();
            this.Hide();
        }

        private void tsmEditar_Click(object sender, EventArgs e)
        {
            frmEditar newobj = new frmEditar();
            newobj.ShowDialog();
            this.Hide();

        }
    }
}
