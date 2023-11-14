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
        //OleDbCommand comandoBD;
        //OleDbDataReader lectorBD;
        //OleDbDataAdapter adaptadorBD;
        //DataSet objDataSet = new DataSet();

        string cadenaConexion = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ../../Resources/EMPLEADO.accdb";

        public string estadoConexion = "";
        //public string datosTabla;
        

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
    }
}
