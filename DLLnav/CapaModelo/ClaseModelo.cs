using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Collections;
using System.Data;

namespace CapaModelo
{
    public class ClaseModelo
    {
        Conexion conexion = new Conexion();
        string tablaBD = "";
        TextBox[] arreglo;
        string rutaAyudaCHM = "";
        string rutaAyudaHTML = "";
      


        public TextBox[] funTexts(Control parent)
        {
            int contador = 0;

            foreach (Control ctr in parent.Controls)
            {
                if (ctr is TextBox)
                {
                    contador++;
                }
            }

            TextBox[] alias = new TextBox[contador];

            contador = 0;
            foreach (Control ctr in parent.Controls)
            {

                if (ctr is TextBox)
                {
                    alias[contador] = (TextBox)ctr;
                    contador++;
                }

            }

            return alias;
        }

        public void funDeshabilitarTexts(Control parent)
        {
            foreach (Control ctr in parent.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Enabled = false;
                }

                if(ctr is ComboBox)
                {
                    ctr.Enabled = false;
                }

                if(ctr is DateTimePicker)
                {
                    ctr.Enabled = false;
                }

                if(ctr is RadioButton)
                {
                    ctr.Enabled = false;
                }
            }
        }

        public int funUltimoEntero(string tabla, string campoB)
        {
            string ultimoEntero = "";
            int enteroSumado = 0;
            OdbcDataReader leer = null;

            string sql = "SELECT" + " " + campoB + " " + "FROM" + " " + tabla + " " +  "ORDER BY" + " " + campoB + " " + "DESC LIMIT 1";
            OdbcConnection conect = conexion.conexion();

            try
            {
                OdbcCommand comando = new OdbcCommand(sql, conect);
                leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    ultimoEntero = leer.GetString(0);
                    //enteroSumado += ultimoEntero; 
                    enteroSumado = int.Parse(ultimoEntero) + 1;
                }

            }
            catch(OdbcException ex)
            {
                MessageBox.Show("Error al cargar los datos" + ex.Message);
            }
            finally
            {
                conexion.desconexion(conect);
            }

            if(enteroSumado == 0)
            {
                enteroSumado = 1;
            }
            

            return enteroSumado;
        }


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

            if (String.IsNullOrEmpty(errores))
            {
                arreglo = alias;
            }
            /* Final de busqueda de columnas en la BD */
            return errores;
        }
        public void funSalida(Form menu)
        {
            menu.Show();
        }

        public void funLlenarCombo(ComboBox cbx,string tabla ,string value, string display,string estatus)
        {
            cbx.DataSource = null;
            cbx.Items.Clear();

            String psql = "SELECT * FROM " + " " + tabla + " " + "WHERE " + " " + estatus + "= 'A' ";

            //MySqlConnection conexionBD = Conexion.conexion();
            OdbcConnection conect = conexion.conexion();
            

            try
            {
                OdbcCommand comando = new OdbcCommand(psql, conect);
                //MySqlCommand llenarCombo = new MySqlCommand(psql, conexionBD);
                OdbcDataAdapter data = new OdbcDataAdapter(comando);

                DataTable dt = new DataTable();
                data.Fill(dt);

                cbx.ValueMember = value;
                cbx.DisplayMember = display;
                cbx.DataSource = dt;
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al leer los datos " + ex.Message);
            }
            finally
            {
                //conexionBD.Close();
                conexion.desconexion(conect);
            }
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
        public ArrayList consIndividual(string id, string tablas, int cuenta, string referencia)
        {
            Conexion cn = new Conexion();
            var arList = new ArrayList();
            OdbcConnection conn = cn.conexion();
            try
            {
                string busqueda = "select * from "+tablas+" where "+referencia+" = " + id + " ;";
                OdbcCommand busI = new OdbcCommand(busqueda, conn);
                OdbcDataReader lector = busI.ExecuteReader();
                while (lector.Read())
                {
                    for(int i=0; i < cuenta; i++)
                    {
                        arList.Add(lector[i].ToString());
                    }
                }
            }
            catch (OdbcException)
            {
                Console.WriteLine("Error en la consulta");
            }
            cn.desconexion(conn);
            return arList;
        }

        public bool modificar(TextBox[] campos, string tablas)
        {
            int resultado=0;
            Conexion cn = new Conexion();
            OdbcConnection conn = cn.conexion();
            string cad = "Entro a la conexion";
            string sentencia = "update "+tablas+" set ";
            for(int i = 1; i<campos.Length; i++)
            {
                if (i < campos.Length - 1)
                {
                    sentencia += campos[i].Tag.ToString() + " = '" + campos[i].Text + "', ";
                }
                else
                {
                    sentencia += campos[i].Tag.ToString() + " = '" + campos[i].Text + "' ";
                }
            }
            sentencia += "where "+campos[0].Tag.ToString()+" = '"+campos[0].Text+"';";
            cad = "Sentencia creada "+sentencia;
            try
            {
                OdbcCommand ingreso = new OdbcCommand(sentencia, conn);
                cad = "Se logró conexion";
                ingreso.ExecuteNonQuery();
                cad = "se ejecutó la sentencia";
                resultado = 1;
            }
            catch (OdbcException Error)
            {
                cad = Error.Message;
                Console.WriteLine("Error al actualizar " + Error);

            }
            cn.desconexion(conn);
            if (resultado== 1)
                {
                    return true;
                }
            else
            {
                return false;
            }
        }

        public void eliminar(TextBox[] arreglo, string tabla, string campoEstado)
        {
            Conexion cn = new Conexion();
            OdbcConnection conexion = cn.conexion();

            for (int i = 0; i < arreglo.Length; i++)
            {
                
                if (arreglo[i].Tag.ToString() == campoEstado)
                {
                    
                    if (arreglo[i].Text== "A" || arreglo[i].Text =="I")
                    {
                        string sql = "UPDATE" + " " + tabla + " " + "SET" + " " + campoEstado + " ="+"'"+arreglo[i].Text+"'"+ " "+"WHERE" + " " + arreglo[0].Tag.ToString() + " = " + arreglo[0].Text;
                        //MessageBox.Show(sql);
                        try
                        {
                            OdbcCommand eliminar = new OdbcCommand(sql, conexion);
                            eliminar.ExecuteNonQuery();

                            MessageBox.Show("Registro dado de baja correctamente");
                        }
                        catch (OdbcException error)
                        {
                            MessageBox.Show("Error al eliminar el registro " + error.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un estado válido, A=Activo, I=Inactivo");
                        break;
                    }
                    
                }
            }

        }
        
        public void funAyuda(string idAyuda, string nombreCampo ,string tablaA, Control parent)
        {
            OdbcDataReader leer = null;

            string sql = "SELECT * FROM " + " " + tablaA + " " + "WHERE " + " " + nombreCampo +  "=" + idAyuda;

            OdbcConnection conect = conexion.conexion();

            try{

                OdbcCommand comando = new OdbcCommand(sql, conect);
                leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    rutaAyudaCHM = leer.GetString(1);
                    
                    rutaAyudaHTML = leer.GetString(2);
                }

                
            }
            catch (OdbcException ex) { 

                MessageBox.Show("Error al cargar los datos" + ex.Message);

            }

            finally
            {
                conexion.desconexion(conect);

            }

          
            Help.ShowHelp(parent, rutaAyudaCHM,rutaAyudaHTML);
          
        }


    }//fin de clase
}//fin de clase
