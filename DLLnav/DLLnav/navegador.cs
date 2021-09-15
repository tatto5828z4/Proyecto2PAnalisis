using System;
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
    }
}
