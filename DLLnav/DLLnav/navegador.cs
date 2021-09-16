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
        ClaseControlador control = new ClaseControlador();
        public navegador()
        {
            InitializeComponent();
            
        }

        /*private void pnlBgIngresar_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Hola");
        }*/

        public void funAsignarAliasVista(TextBox[] alias, string tabla, string BD)
        {
            control.funAsignarAliasControl(alias, tabla, BD);
        }

        public void funAsignarSalidadVista(Form menu)
        {
            control.funAsignarSalidadControl(menu);
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
            desactivarBotones(0);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            desactivarBotones(0);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            desactivarBotones(1);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            desactivarBotones(1);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            desactivarBotones(1);
        }

        DataGridView dvgConsulta;
        //funcion para pedir datagridView
        public void pideGrid(DataGridView tabla)
        {
            dvgConsulta = tabla;
        }


        public void llenaTabla(string tablaBD)
        {
            DataTable dt = control.llenarTbl(tablaBD);
            dvgConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgConsulta.DataSource = dt;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
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
    }
}
