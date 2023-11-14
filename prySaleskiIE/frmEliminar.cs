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
    public partial class frmEliminar : Form
    {
        public frmEliminar()
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
        OpenFileDialog ofD = new OpenFileDialog();
        string rutaArchivo = string.Empty;
        string directorioActual = Application.StartupPath;
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal newobj = new frmPrincipal();
            this.Hide();
            newobj.ShowDialog();
        }

        private void btnArchivoEliminar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                directorioActual = System.IO.Directory.GetParent(directorioActual).FullName;
            }
            directorioActual = System.IO.Path.Combine(directorioActual, "Resources");

            //marca donde se inicializa el OpenFileDialog
            ofD.InitialDirectory = directorioActual;
            ofD.Filter = "Carpetas|*.folder";


            if (ofD.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = ofD.FileName;
            }

            lblRuta.Text = rutaArchivo;


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿ Está seguro que desea borrar el archivo:  " + rutaArchivo + " ?", "Eliminar archivo", MessageBoxButtons.OKCancel);


            if (result == DialogResult.OK)
            {
                if (File.Exists(rutaArchivo))
                {
                    File.Delete(rutaArchivo);
                }


            }
        }

        private void frmEliminar_Load(object sender, EventArgs e)
        {

        }
    }
}
