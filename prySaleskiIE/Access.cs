using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace prySaleskiIE
{
    public class Access
    {
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;
        
        DataSet objDS;

        string cadenaDeConexion = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\EL_CLUB.accdb";

        public string estadoDeConexion = "";
        public string datosTabla = "";
        string varEstado;
        int varContador;
        string varSexo;
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

            //conexionBD.Open();

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
            grilla.Columns.Add("Estado", "Estado");


             if (lectorBD.HasRows)
            {
                while (lectorBD.Read())
                {
                    //cargo la grilla con valores de activo/inactivo para que no aparezca true o false
                    if ((bool)lectorBD[8] == true)
                    {
                        varEstado = "Activo";
                    }
                    else
                    {
                        varEstado = "Inactivo";
                    }

                    //cargo la grilla con valores de Masculino/Femenino para que no aparezca true o false
                    if ((bool)lectorBD[5] == true)
                    {
                        varSexo = "Masculino";
                    }
                    else
                    {
                        varSexo = "Femenino";
                    }

                    grilla.Rows.Add(lectorBD[0], lectorBD[1], lectorBD[2], lectorBD[3], lectorBD[4], varSexo, lectorBD[6], lectorBD[7], varEstado);
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
            comandoBD.CommandText = "USUARIOS";

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

        public void ModificarEstadoSocio(int id)
        {


            OleDbCommand comandoBD = new OleDbCommand();
            OleDbDataAdapter objda;
            DataSet objds = new DataSet();

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

            // establecer las propiedades al objeto comando
            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = CommandType.TableDirect;
            comandoBD.CommandText = "SOCIOS";

            // crear el objeto DataAdapter pasando como parámetro el objeto comando que queremos vincular
            objda = new OleDbDataAdapter(comandoBD);

            // ejecutar la lectura de la tabla y almacenarsu contenido en el dataAdapter

            objda.Fill(objds, "SOCIOS");


            // obtenemos una referencia a la tabla de SOCIOS
            DataTable dt = objds.Tables["SOCIOS"];

            // recorrer los registros de la tabla

            foreach (DataRow registro in dt.Rows)
            { 

                if ((int)registro["CODIGO_SOCIO"] == id)
                {
                    
                    registro.BeginEdit();

                    //  nuevo valor al estado del socio 
                    if ((bool)registro["ESTADO"])
                    {
                        registro["ESTADO"] = false;
                    }
                    else
                    {
                        registro["ESTADO"] = true;
                    }

                    
                    registro.EndEdit();
                    break;
                }


            }
            // creo OledBCommandBuilder pasando como parámetro el DataAdapter
            OleDbCommandBuilder cb = new OleDbCommandBuilder(objda);

            // ACTUALIZO LA BASE

            objda.Update(objds, "SOCIOS");

            MessageBox.Show("Estado Modificado");
        }












        public void BuscarPorId(string codigo, DataGridView dgvMostrar)
        {
            comandoBD = new OleDbCommand();
            
            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "SOCIOS";

            lectorBD = comandoBD.ExecuteReader();


            if (lectorBD.HasRows) 
            {
                bool bandera = false;
                if (codigo == "")
                {
                    MessageBox.Show("ingrese un numero");
                    bandera = true;
                }
                else
                {
                    while (lectorBD.Read()) 
                    {
                        if ((lectorBD[0].ToString()) == codigo) 
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
