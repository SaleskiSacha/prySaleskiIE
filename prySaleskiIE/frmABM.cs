using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace prySaleskiIE
{
    public partial class frmABM : Form
    {
        public frmABM()
        {
            InitializeComponent();
            KeyPreview = true;
            this.KeyDown += CerrarFrm_KeyDown;
        }
        string rutaCarpeta;
        FolderBrowserDialog fbD = new FolderBrowserDialog();

        public static void CerrarFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit(); // Cierra la aplicación completa
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal newobj = new frmPrincipal();
            this.Hide();
            newobj.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDestino_Click(object sender, EventArgs e)
        {
            rutaCarpeta = string.Empty;
            if (fbD.ShowDialog() == DialogResult.OK)
            {
                rutaCarpeta = fbD.SelectedPath;
                MessageBox.Show("Ruta seleccionada: " + rutaCarpeta);
            }
            lblDestino.Text = rutaCarpeta;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(rutaCarpeta + "/" + ".csv", true);
            string linea = txtNumero.Text + ";" + txtEntidad.Text + ";" + txtApertura.Text + ";" + txtExpediente.Text + ";" + txtJuzgado.Text + ";" + txtJurisdiccion.Text + ";" + txtDireccion.Text + ";" + txtLiquidador.Text;
            sw.WriteLine(linea);
            sw.Close();
            sw.Dispose();
            MessageBox.Show("Se ha cargado el archivo correctamente");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEntidad.Clear();
            txtApertura.Clear();
            txtExpediente.Clear();
            txtJuzgado.Clear();
            txtJurisdiccion.Clear();
            txtDireccion.Clear();
            txtLiquidador.Clear();
        }

        private void frmABM_Load(object sender, EventArgs e)
        {

        }
    }
}
