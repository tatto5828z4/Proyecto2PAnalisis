using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace navModelo
{
    class Conexion
    {
        public OdbcConnection conexion()
        {
            //creacion de la conexion via ODBC
            OdbcConnection conn = new OdbcConnection("Dsn=nube");
            try
            {
                conn.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No se establecio Conexion!");
            }
            return conn;
        }

        //metodo para cerrar la conexion
        public void desconexion(OdbcConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No se establecio Conexion!");
            }
        }

    }

    class Conexiontwo
    {
        public static MySqlConnection conexion()
        {
            String servidor = "34.132.76.83";
            String bd = "pruebas";
            String usuario = "root";
            String password = "root";

            String cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id= " + usuario +
            "; Password=" + password + ";";

            try
            {
                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
                MessageBox.Show("conectado");

                return conexionBD;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }


}