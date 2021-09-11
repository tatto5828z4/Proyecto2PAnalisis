using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace navModelo
{
    public class CapaModelo
    {
        //Conexiontwo conexion = new Conexiontwo();
        public string funAsignarAlias(TextBox[] alias, string tabla,string BD)
        {
            /* Inicio para busqueda de tabla en BD */
            string cantidad_tabla = "";
            string errores = "";
            string sql = "select count(*) FROM information_schema.TABLES WHERE TABLE_SCHEMA = '"+BD+"' AND TABLE_NAME = '"+tabla+"'";

            MySqlConnection conexionBD = Conexiontwo.conexion();
            conexionBD.Open();

            try
            {
                //OdbcCommand command = new OdbcCommand(sql, conexion.conexion());
                //cantidad_tabla = command.ExecuteScalar().ToString();

                MySqlCommand buscarTabla = new MySqlCommand(sql, conexionBD);
                cantidad_tabla = buscarTabla.ExecuteScalar().ToString();

                if (cantidad_tabla == "0")
                {
                    errores += "Error la tabla" + " " + tabla + " " + "no existe en la Base de datos";
                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Error al cargar los datos " + ex.Message);
                //errores += "error en la BD " + " " + ex;
            }
            finally
            {
                conexionBD.Close();
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
                string cantidadCampos = "SELECT count(COLUMN_NAME) FROM INFORMATION_SCHEMA.COLUMNS WHERE table_name = '"+tabla+"' AND table_schema = '"+BD+"'";
                conexionBD.Open();

                try
                {
                    MySqlCommand buscarCantidad = new MySqlCommand(cantidadCampos, conexionBD);
                    cantidadTotalCampos = buscarCantidad.ExecuteScalar().ToString();
                    int cantidadEntero = int.Parse(cantidadTotalCampos);

                    if (cantidadT > cantidadEntero)
                    {
                        errores += "Error los campos del arreglo son mayores al de la tabla " + " " + tabla;
                    }
                    else if(cantidadT < cantidadEntero)
                    {
                        errores += "Error los campos del arreglo son menores al de la tabla " + " " + tabla;
                    }
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show("Error al cargar los datos " + ex.Message);
                }
                finally
                {
                    conexionBD.Close();
                }
            }
            /* Final busqueda de cantidades de campos en la una tabla */

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
                    conexionBD.Open();
                    //MessageBox.Show(arreglo[i]);

                    try
                    {
                        MySqlCommand buscarColumna = new MySqlCommand(sqlQ, conexionBD);
                        cantidadColumnas = buscarColumna.ExecuteScalar().ToString();

                        if (cantidadColumnas == "0")
                        {
                            errores += "Error el campo" + " " + arreglo[i] + " " + "dentro de la tabla" + " " + tabla + " " + "no esta definido en la Base de datos";
                            break;
                        }
                    }
                    catch(MySqlException ex)
                    {
                        MessageBox.Show("Error al cargar los datos " + ex.Message);
                    }
                    finally
                    {
                        conexionBD.Close();
                    }

                    i++;
                }

            }
            /* Final de busqueda de columnas en la BD */


            return errores;

        }
    }

}
