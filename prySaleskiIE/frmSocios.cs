using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace prySaleskiIE
{
    public partial class frmSocios : Form
    {
        int id = 0;
        public frmSocios()
        {
            InitializeComponent();
            KeyPreview = true;
            this.KeyDown += CerrarFrm_KeyDown;

        }
        Access objBD;
        public static void CerrarFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit(); // Cierra la aplicación completa
            }
        }
        private void frmSocios_Load(object sender, EventArgs e)
        {
            objBD = new Access();
            objBD.ConectarBD();
            objBD.traerDatos(dgvMostrar);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            objBD.BuscarPorId(txtID.Text, dgvMostrar);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            this.Hide();
            frmPrincipal.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(txtID2.Text);

            Access objLogin = new Access();

            objLogin.ModificarEstadoSocio(id);


            Usuarios objLogs = new Usuarios();

            objLogs.RegistroLogInicioSesion();

            txtID2.Clear();
        }
    }
}
