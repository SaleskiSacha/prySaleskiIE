﻿using System;
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
        public frmSocios()
        {
            InitializeComponent();
        }
        Access objBD;

        private void frmSocios_Load(object sender, EventArgs e)
        {
            objBD = new Access();
            objBD.ConectarBD();
            objBD.traerDatos(dgvMostrar);
        }
    }
}