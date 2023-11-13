using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace prySaleskiIE
{
    public class Access
    {
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;



        string cadenaDeConexion = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\EL_CLUB.accdb";

        public string estadoDeConexion = "";
        public string datosTabla = "";
        int varContador;
        public Access()
        {
            varContador = 0;
        }
        public void ConectarBD()
        {
            try
            {
                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = cadenaDeConexion;
                conexionBD.Open();
                estadoDeConexion = "Conectado";
            }
            catch (Exception ex)
            {
                estadoDeConexion = "Error" + ex.Message;
            }

        }
        public void traerDatos(DataGridView grilla)
        {
            comandoBD = new OleDbCommand();

            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "SOCIOS";

            lectorBD = comandoBD.ExecuteReader();

            grilla.Columns.Add("ID", "ID");
            grilla.Columns.Add("Nombre", "Nombre");
            grilla.Columns.Add("Apellido", "Apellido");
            grilla.Columns.Add("Pais", "Pais");
            grilla.Columns.Add("Edad", "Edad");
            grilla.Columns.Add("Ingreso", "Ingreso");
            grilla.Columns.Add("Puntaje", "Puntaje");



            if (lectorBD.HasRows)
            {
                while (lectorBD.Read())
                {
                    datosTabla += "-" + lectorBD[0];
                    grilla.Rows.Add(lectorBD[0], lectorBD[1], lectorBD[2], lectorBD[3], lectorBD[4], lectorBD[5], lectorBD[6]);
                }
            }
        }
        public void ValidarUsuario(string varNombre, string varContraseña, Form frm)
        {

            comandoBD = new OleDbCommand();
            int intentosMaximos = 3;
            bool usuarioEncontrado = false;

            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "USERS";

            lectorBD = comandoBD.ExecuteReader();

            while (lectorBD.Read())
            {
                string nombreDB = lectorBD[1].ToString();
                string contraseñaDB = lectorBD[2].ToString();

                if (nombreDB == varNombre && contraseñaDB == varContraseña)
                {
                    MessageBox.Show("Datos correctos");
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












        public void BuscarPorId(string codigo, DataGridView dgvMostrar)
        {
            comandoBD = new OleDbCommand();
            //bandera=false;
            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "SOCIOS";

            lectorBD = comandoBD.ExecuteReader();


            if (lectorBD.HasRows) //SI TIENE FILAS
            {
                bool bandera = false;
                if (codigo == "")
                {
                    MessageBox.Show("ingrese un numero");
                    bandera = true;
                }
                else
                {
                    while (lectorBD.Read()) //mientras pueda leer que ejecute el sig codigo
                    {
                        if ((lectorBD[0].ToString()) == codigo) //Si el codigo ingresado por pantalla es igual a la primera posicion del registro
                        {

                            dgvMostrar.Rows.Clear();
                            dgvMostrar.Rows.Add(lectorBD[0], lectorBD[1], lectorBD[2], lectorBD[3], lectorBD[4], lectorBD[6], lectorBD[7]);
                            bandera = true;
                            break;
                        }

                    }
                }

                if (bandera == false)
                {

                    MessageBox.Show("La identificación ingresada no existe", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                }
            }
        }


    }
}
