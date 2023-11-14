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
            KeyPreview = true;
            this.KeyDown += CerrarFrm_KeyDown;
        }
        public static void CerrarFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit(); // Cierra la aplicación completa
            }
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
            frmABM newobj = new frmABM();
            newobj.ShowDialog();
            this.Hide();

        }

        private void Socios_Click(object sender, EventArgs e)
        {

        }

        private void sociosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnsPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsmDatosSOCIOS_Click(object sender, EventArgs e)
        {
            frmSocios newobj = new frmSocios();
            newobj.ShowDialog();
            this.Hide();
        }

        private void SOCIOS_Click_1(object sender, EventArgs e)
        {
            frmSocios socios = new frmSocios();
            socios.ShowDialog();
            this.Hide();
        }
    }
}
