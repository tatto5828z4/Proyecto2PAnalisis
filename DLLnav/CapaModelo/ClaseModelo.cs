using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;


namespace CapaModelo
{
    public class ClaseModelo
    {
        Conexion conexion = new Conexion();
        public string funAsignarAlias(TextBox[] alias, string tabla, string BD)
        {
            /* Inicio para busqueda de tabla en BD */
            string cantidad_tabla = "";
            string errores = "";
            string sql = "SELECT count(*) FROM information_schema.TABLES WHERE TABLE_SCHEMA = '" + BD + "' AND TABLE_NAME = '" + tabla + "'";

            /*MySqlConnection conexionBD = Conexiontwo.conexion();
            conexionBD.Open();*/
            OdbcConnection conect = conexion.conexion();
            try
            {
                OdbcCommand comando = new OdbcCommand(sql, conect);
                cantidad_tabla = comando.ExecuteScalar().ToString();

                if (cantidad_tabla == "0")
                {
                    errores += "Error en la tabla" + " " + tabla + " " + "no existe en la Base de datos";
                }
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al cargar los datos" + ex.Message);
                //errores += "error en la BD " + " " + ex;
            }
            finally
            {
                conexion.desconexion(conect);
            }
            /* Final para busqueda de tabla en BD */

            /* Inicio busqueda de cantidades de campos en la una tabla */
            if (String.IsNullOrEmpty(errores))
            {
                int cantidadT = 0;

                foreach (TextBox dato in alias)
                {
                    cantidadT++;
                }

                string cantidadTotalCampos = "";
                string cantidadCampos = "SELECT count(COLUMN_NAME) FROM INFORMATION_SCHEMA.COLUMNS WHERE table_name = '" + tabla + "' AND table_schema = '" + BD + "'";
                conect = conexion.conexion();

                try
                {
                    //MySqlCommand buscarCantidad = new MySqlCommand(cantidadCampos, conexionBD);
                    OdbcCommand buscarCantidad = new OdbcCommand(cantidadCampos, conect);
                    cantidadTotalCampos = buscarCantidad.ExecuteScalar().ToString();
                    int cantidadEntero = int.Parse(cantidadTotalCampos);

                    if (cantidadT > cantidadEntero)
                    {
                        errores += "Error los campos del arreglo son mayores al de la tabla " + " " + tabla;
                    }
                    else if (cantidadT < cantidadEntero)
                    {
                        errores += "Error los campos del arreglo son menores al de la tabla " + " " + tabla;
                    }
                }
                catch (OdbcException ex)
                {
                    MessageBox.Show("Error al cargar los datos " + ex.Message);
                }
                finally
                {
                    conexion.desconexion(conect);
                }
            }
            /* Final búsqueda de cantidades de campos en una tabla */


            /* Inicio de busqueda de columnas en la BD */
            if (String.IsNullOrEmpty(errores))
            {
                string[] arreglo;
                int cantidad = 0;

                foreach (TextBox dato in alias)
                {
                    cantidad++;
                }

                arreglo = new string[cantidad];
                string cantidadColumnas = "";
                int i = 0;

                foreach (TextBox dato in alias)
                {
                    arreglo[i] = dato.Tag.ToString();
                    string sqlQ = "SELECT count(*) FROM information_schema.COLUMNS WHERE TABLE_SCHEMA = '" + BD + "' AND TABLE_NAME = '" + tabla + "' AND COLUMN_NAME = '" + arreglo[i] + "'";
                    //conexionBD.Open();
                    conect = conexion.conexion();
                    //MessageBox.Show(arreglo[i]);

                    try
                    {
                        //MySqlCommand buscarColumna = new MySqlCommand(sqlQ, conexionBD);
                        OdbcCommand buscarColumna = new OdbcCommand(sqlQ, conect);
                        cantidadColumnas = buscarColumna.ExecuteScalar().ToString();

                        if (cantidadColumnas == "0")
                        {
                            errores += "Error el campo" + " " + arreglo[i] + " " + "dentro de la tabla" + " " + tabla + " " + "no esta definido en la Base de datos";
                            break;
                        }
                    }
                    catch (OdbcException ex)
                    {
                        MessageBox.Show("Error al cargar los datos " + ex.Message);
                    }
                    finally
                    {
                        conexion.desconexion(conect);
                    }

                    i++;
                }

            }
            /* Final de busqueda de columnas en la BD */
            return errores;
        }
        public void funSalida(Form menu)
        {
            menu.Show();
        }

        public OdbcDataAdapter llenarTbl(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            Conexion cn = new Conexion();

            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "select * from " + tabla + ";";
            OdbcConnection conn = cn.conexion();
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conn);
            cn.desconexion(conn);

            return dataTable;
        }

    }//fin de clase
}
