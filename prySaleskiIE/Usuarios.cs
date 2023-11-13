using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace prySaleskiIE
{
    public class Usuarios
    {
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;

        string cadenaDeConexion = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\EL_CLUB.accdb";



        int varContador;



        public void ValidarUsuario(string varNombre, string varContraseña, Form frm)
        {
            try
            {
                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = cadenaDeConexion;
                conexionBD.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

            comandoBD = new OleDbCommand();
            int intentosMaximos = 3;
            bool usuarioEncontrado = false;

            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "USUARIOS";

            lectorBD = comandoBD.ExecuteReader();

            while (lectorBD.Read())
            {
                string nombreDB = lectorBD[1].ToString();
                string contraseñaDB = lectorBD[2].ToString();

                if (nombreDB == varNombre && contraseñaDB == varContraseña)
                {

                    frm.Hide();
                    frmPrincipal frmPrincipal = new frmPrincipal();
                    frmPrincipal.Show();
                    usuarioEncontrado = true;
                    break;
                }
            }

            if (!usuarioEncontrado)
            {
                varContador++;
                MessageBox.Show("Datos de inicio de sesión incorrectos");

                if (varContador >= intentosMaximos)
                {
                    MessageBox.Show("Demasiados intentos de inicio de sesión, el sistema se cerrará");
                    Application.Exit();
                }
            }
        }


    }
}
