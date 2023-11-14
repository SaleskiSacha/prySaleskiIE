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
    public partial class frmPantalladeCarga : Form
    {
        public frmPantalladeCarga()
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
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login newobj = new Login();
            newobj.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            pgbCargar.Increment(5);
            if (pgbCargar.Value == pgbCargar.Maximum)
            {
                timer1.Stop();
                this.Hide();
                Login newobj = new Login();
                newobj.ShowDialog();
                
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
