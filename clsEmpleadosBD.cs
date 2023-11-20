using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Reflection.Emit;

namespace pryFernandezTP
{
    class clsEmpleadosBD
    {
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;
        OleDbDataAdapter adaptadorBD;
        DataSet objDataSet = new DataSet();

        string cadenaConexion = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ../../Resources/EMPLEADO.accdb";

        public string estadoConexion = "";
  
        public void ConectarBD()
        {
            try
            {
                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = cadenaConexion;
                conexionBD.Open();

                estadoConexion = "Conectado";               
            }
            catch (Exception ex)
            {
                estadoConexion = "Error" + ex.Message;
            }
        }

        public string datosTabla;
        public void leerBD(DataGridView grilla, string apellido, string direccion) // listado filtrado
        {
            ConectarBD();
            comandoBD = new OleDbCommand();

            //conecta el comando con la conexion
            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "DATOS PERSONALES";

            lectorBD = comandoBD.ExecuteReader();
            grilla.Columns.Add("CODIGO", "CODIGO");
            grilla.Columns.Add("NOMBRE", "NOMBRE");
            grilla.Columns.Add("APELLIDO", "APELLIDO");
            grilla.Columns.Add("DIRECCIÒN", "DIRECCIÒN");
            grilla.Columns.Add("CIUDAD", "CIUDAD");
            grilla.Columns.Add("TELEFONO", "TELEFONO");
            grilla.Columns.Add("FECHA_NACIMIENTO", "FECHA_NACIMIENTO");

            if (lectorBD.HasRows)
            {
                while (lectorBD.Read())
                {
                    datosTabla += "-" + lectorBD[1];
                    
                    if (apellido == Convert.ToString(lectorBD[2]))
                    {
                        grilla.Rows.Add(lectorBD[0], lectorBD[1], lectorBD[2], lectorBD[3], lectorBD[4], lectorBD[5], lectorBD[6]);
                    }
                    else if (direccion == Convert.ToString(lectorBD[3]))
                    {
                        grilla.Rows.Add(lectorBD[0], lectorBD[1], lectorBD[2], lectorBD[3], lectorBD[4], lectorBD[5], lectorBD[6]);
                    }                   
                }
            }
        }
       
        public void leerBD(DataGridView grilla) // listado general
        {            
            ConectarBD();
            comandoBD = new OleDbCommand();

            //conecta el comando con la conexion
            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "DATOS PERSONALES";

            lectorBD = comandoBD.ExecuteReader();
            grilla.Columns.Add("CODIGO", "CODIGO");
            grilla.Columns.Add("NOMBRE", "NOMBRE");
            grilla.Columns.Add("APELLIDO", "APELLIDO");
            grilla.Columns.Add("DIRECCION", "DIRECCION");
            grilla.Columns.Add("CIUDAD", "CIUDAD");
            grilla.Columns.Add("TELEFONO", "TELEFONO");
            grilla.Columns.Add("FECHA_NACIMIENTO", "FECHA_NACIMIENTO");

            if (lectorBD.HasRows)
            {
                while (lectorBD.Read())
                {
                    datosTabla += "-" + lectorBD[1];
                    grilla.Rows.Add(lectorBD[0], lectorBD[1], lectorBD[2], lectorBD[3], lectorBD[4], lectorBD[5], lectorBD[6]);
                }
            }           
        }
       
        
        public void registrarBD(string codigo, string nombre, string apellido, string direccion, string ciudad, string telefono, DateTime nacimiento)
        {
            ConectarBD();

            comandoBD = new OleDbCommand();
            comandoBD.Connection = conexionBD;

            // Construir la consulta SQL de inserción
            string consulta = "INSERT INTO [DATOS PERSONALES] (CODIGO, NOMBRE, APELLIDO, DIRECCION, CIUDAD, TELEFONO, FECHA_NACIMIENTO) " +
                              "VALUES (@codigo, @nombre, @apellido, @direccion, @ciudad, @telefono, @nacimiento)";

            comandoBD.CommandText = consulta;

            // Agregar parámetros
            comandoBD.Parameters.AddWithValue("@codigo", codigo);
            comandoBD.Parameters.AddWithValue("@nombre", nombre);
            comandoBD.Parameters.AddWithValue("@apellido", apellido);
            comandoBD.Parameters.AddWithValue("@direccion", direccion);
            comandoBD.Parameters.AddWithValue("@ciudad", ciudad);
            comandoBD.Parameters.AddWithValue("@telefono", telefono);
            comandoBD.Parameters.AddWithValue("@nacimiento", nacimiento);

            // Ejecutar la consulta
            comandoBD.ExecuteNonQuery();
        }      

        public void modificarBD() // modificar
        {

        }
    }
}
