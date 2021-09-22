using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace DLL.nav
{
    public partial class navegador : UserControl
    {
        //Variables Globales
        TextBox[] campos;
        string tablas;
        string DB;
        int estado = 0;
        public string campoEstado = "";
        ClaseControlador control = new ClaseControlador();
        //Fin varaibles globales


        public navegador()
        {
            InitializeComponent();

        }

        /*private void pnlBgIngresar_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Hola");
        }*/

        public TextBox[] funAsignandoTexts(Control parent)
        {
            return control.ordenandoTextos(parent);
        }

        public void funAsignarAliasVista(TextBox[] alias, string tabla, string BD)
        {
            control.funAsignarAliasControl(alias, tabla, BD);
            campos = alias;
            tablas = tabla;
            DB = BD;
        }

        public void funAsignarSalidadVista(Form menu)
        {
            control.funAsignarSalidadControl(menu);
        }

        public void funLlenarComboControl(ComboBox cbx, string tabla, string value, string display, string estatus)
        {
            control.funLlenarComboControl( cbx,tabla,  value,  display,  estatus);

        }



        public void mensaje()
        {
            MessageBox.Show("Prueba de Funcion #2");
        }

        public void mensaje2()
        {
            MessageBox.Show("Prueba de Funcion #3");
        }

        /*private void pnlBgM_MouseClick(object sender, MouseEventArgs e)
        {
            mensaje();
        }

        private void pnlBgG_MouseClick(object sender, MouseEventArgs e)
        {
            mensaje2();
        }
        */
        public void pruebaMensaje(string cadena)
        {
            MessageBox.Show("La cadena es: " + cadena);
        }

        private void desactivarBotones(int tipo)
        {
            //desactivarBotones cambiara los .Enabled de los botones
            //indicados
            /*
             * 0 Desactiva los botones de cancelar y guardar
             * 1 Desactiva los botones de insertar, modificar y eliminar
             * 
             * Cada uno activará lo que el otro desactive
             * 0 Activa insertar, modificar y eliminar
             * 1 Actica Cancelar y Guardar
             */
            if (tipo == 0)
            {
                btnIngresar.Enabled = true;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                btnIngresar.Cursor = Cursors.Hand;
                btnModificar.Cursor = Cursors.Hand;
                btnEliminar.Cursor = Cursors.Hand;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnGuardar.Cursor = Cursors.No;
                btnCancelar.Cursor = Cursors.No;
            }
            else
            {
                btnIngresar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnIngresar.Cursor = Cursors.No;
                btnModificar.Cursor = Cursors.No;
                btnEliminar.Cursor = Cursors.No;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnGuardar.Cursor = Cursors.Hand;
                btnCancelar.Cursor = Cursors.Hand;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estado = 0;
            desactivarBotones(0);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            switch (estado)
            {
                case 1://Este nos sirve para ingresar

                    break;

                case 2://Modificar
                    string resultado;
                    resultado = control.modificar(campos, tablas);
                    MessageBox.Show(resultado);
                  /*  if(resultado == true)
                    {
                        MessageBox.Show("Modificación realizada con éxito!");
                    }
                    else
                    {
                        MessageBox.Show("Modificación no se realizó con éxito!");
                    }*/
                    break;


                case 3://Este es para eliminar

                    break;

                case 0://Error alguno de los otros casos no hizo su trabajo
                    MessageBox.Show("Error, no ha seleccionado ninguna función para guardar sus acciones");
                    break;
            }
            estado = 0;
            desactivarBotones(0);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            desactivarBotones(1);
        }

        private void btnModificar_Click(object sender, EventArgs e)//Boton de modificar campos dinámico
        {
            if (dvgConsulta != null)
            {
                if (dvgConsulta.RowCount - 1 > 0)
                {
                    int cuenta = campos.Length;
                    string referencia = campos[0].Tag.ToString();//Nos sirve para obtener el campo para hacer la consulta
                    string id = dvgConsulta.CurrentRow.Cells[0].Value.ToString();
                    var arList = control.consIndividual(id, tablas, cuenta, referencia);
                    for(int i=0; i<cuenta; i++)
                    {
                        campos[i].Text = (string)arList[i];
                    }
                    estado = 2;
                    desactivarBotones(1);
                }
                else
                {
                    MessageBox.Show("No tiene Registros");
                    return;
                }
                   
            }
            else
            {
                MessageBox.Show("No existe ninguna datagridview");
                return;
            }          
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            control.funEliminarControl(campos, tablas, campoEstado);

            desactivarBotones(1);
        }

        //boton de verificacion para navegacion sin registros
        public Boolean veriNavegar(){

            if (dvgConsulta.RowCount-1 > 0)
               
                return true;
            else 
                return false;
            }


        DataGridView dvgConsulta;
        //funcion para pedir datagridView
        public void pideGrid(DataGridView tabla)
        {
            dvgConsulta = tabla;
        }


        public void llenaTabla()
        {
            DataTable dt = control.llenarTbl(tablas);
            dvgConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgConsulta.DataSource = dt;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            //verificacion de la existencia de registros
            if (veriNavegar() == false) { 
            MessageBox.Show("No tiene registros actualmente, no se puede navegar");
                return;
              }

            //obtengo el indicie actual
            int actual = dvgConsulta.CurrentCell.RowIndex;


            int numColumnas = dvgConsulta.ColumnCount;//cuenta cuantos columnas 
            int numFilas = dvgConsulta.RowCount;
            //MessageBox.Show("cantidad de filas: "+numFilas);


            if (actual == numFilas - 2)
            {
                dvgConsulta.CurrentCell = dvgConsulta.Rows[0].Cells[0];
            }
            else
            {

                var arList = new ArrayList();//todos los campos a obtener de la tabla


                dvgConsulta.CurrentCell = dvgConsulta.Rows[actual + 1].Cells[0];
                //for para guardar todos los datos de la columnas
                for (int i = 0; i < numColumnas; i++)
                {
                    string col = dvgConsulta.CurrentRow.Cells[i].Value.ToString();
                    arList.Add(col);//vamos guardando todos los campos

                }
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            //verificacion de la existencia de registros
            if (veriNavegar() == false)
            {
                MessageBox.Show("No tiene registros actualmente, no se puede navegar");
                return;
            }

            //obtengo el indicie actual
            int actual = dvgConsulta.CurrentCell.RowIndex;


            //hacer un condicional para ver si no es el primer campo

            if (actual == 0)
            {
                // MessageBox.Show("Lo siento no puede retroceder mas esta en el primer campo");
                dvgConsulta.CurrentCell = dvgConsulta.Rows[dvgConsulta.RowCount - 2].Cells[0];
            }
            else
            {


                dvgConsulta.CurrentCell = dvgConsulta.Rows[actual - 1].Cells[0];
                var arList = new ArrayList();//todos los campos a obtener de la tabla

                int numColumnas = dvgConsulta.ColumnCount;//cuenta cuantos columnas 

                //for para guardar todos los datos de la columnas
                for (int i = 0; i < numColumnas; i++)
                {
                    string col = dvgConsulta.CurrentRow.Cells[i].Value.ToString();
                    arList.Add(col);//vamos guardando todos los campos

                }



                //string para ver los datos
                /*for (int i = 0; i < arList.Count; i++)
                {
                    MessageBox.Show("arlist[" + i + "] =" + arList[i]);
                }

                */
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

            //verificacion de la existencia de registros
            if (veriNavegar() == false)
            {
                MessageBox.Show("No tiene registros actualmente, no se puede navegar");
                return;
            }

            dvgConsulta.CurrentCell = dvgConsulta.Rows[0].Cells[0];

            var arList = new ArrayList();//todos los campos a obtener de la tabla

            int numColumnas = dvgConsulta.ColumnCount;//cuenta cuantos columnas 

            //for para guardar todos los datos de la columnas
            for (int i = 0; i < numColumnas; i++)
            {
                string col = dvgConsulta.CurrentRow.Cells[i].Value.ToString();
                arList.Add(col);//vamos guardando todos los campos

            }
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            //verificacion de la existencia de registros
            if (veriNavegar() == false)
            {
                MessageBox.Show("No tiene registros actualmente, no se puede navegar");
                return;
            }

            dvgConsulta.CurrentCell = dvgConsulta.Rows[dvgConsulta.RowCount - 2].Cells[0];

            var arList = new ArrayList();//todos los campos a obtener de la tabla

            int numColumnas = dvgConsulta.ColumnCount;//cuenta cuantos columnas 

            //for para guardar todos los datos de la columnas
            for (int i = 0; i < numColumnas; i++)
            {
                string col = dvgConsulta.CurrentRow.Cells[i].Value.ToString();
                arList.Add(col);//vamos guardando todos los campos

            }
        }

        private void navegador_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            llenaTabla();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            generic.Close();
        }
        Form generic;
        public void pedirRef(Form generico)
        {
            generic = generico;
        }

    }
}
