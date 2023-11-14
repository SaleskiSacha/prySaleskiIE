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
    public partial class frmView : Form
    {
        public frmView()
        {
            InitializeComponent();
            LlenarTreeView();

            KeyPreview = true;
            this.KeyDown += CerrarFrm_KeyDown;
        }
        
        private void LlenarTreeView()
        {
            TreeNode nodoMadre;

            DirectoryInfo info = new DirectoryInfo(@"../../Resources/Proveedores, aseguradores");
            if (info.Exists == true) //POR DEFECTO el IF pregunta true
            {
                nodoMadre = new TreeNode(info.Name);
                nodoMadre.Tag = info;
                ObtenerCarpetas(info.GetDirectories(), nodoMadre);
                treeView1.Nodes.Add(nodoMadre);
            }
        }
        private void ObtenerCarpetas(DirectoryInfo[] subDirs,
   TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;

            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";

                //es para tener los archivos dentro de las carpetas
                FileInfo[] files = subDir.GetFiles();
                foreach (FileInfo file in files)
                {
                    TreeNode fileNode = new TreeNode(file.Name, 1, 1);
                    fileNode.Tag = file;
                    aNode.Nodes.Add(fileNode);
                }
                //recursiva - se llama a si mismo para
                //buscar màs carpetas
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    ObtenerCarpetas(subSubDirs, aNode);
                }

                nodeToAddTo.Nodes.Add(aNode);
            }
        }
        public static void CerrarFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit(); // Cierra la aplicación completa
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        string leerLinea;
        string[] separarDatos;
        private DirectoryInfo info;
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            dgvDatos.Rows.Clear();
            dgvDatos.Columns.Clear();

            string Archivo = Convert.ToString(treeView1.SelectedNode.FullPath);
            string NombreArchivo = treeView1.SelectedNode.Text;
            info = new DirectoryInfo(@"../../Resources/");
            string ruta = info.FullName + Archivo;


            try
            {
                ruta = (@"../../Resources/");
                StreamReader sr = new StreamReader(ruta + "\\" + Archivo);

                leerLinea = sr.ReadLine();
                separarDatos = leerLinea.Split(';');

                for (int indice = 0; indice < separarDatos.Length; indice++)
                {
                    dgvDatos.Columns.Add(separarDatos[indice], separarDatos[indice]);
                }

                while (sr.EndOfStream == false)
                {
                    leerLinea = sr.ReadLine();
                    separarDatos = leerLinea.Split(';');
                    dgvDatos.Rows.Add(separarDatos);
                }

                sr.Close();

                dgvDatos.Visible = true;


            }
            catch (Exception)
            {

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal newobj = new frmPrincipal();
            this.Hide();
            newobj.ShowDialog();
        }
    }
}
