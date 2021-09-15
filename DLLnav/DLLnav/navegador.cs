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

        private void pnlBgIngresar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlBgIngresar_MouseClick(object sender, MouseEventArgs e)
        {
            /*MessageBox.Show("Hola");*/
        }

        private void pnlContenidoI_Paint(object sender, PaintEventArgs e)
        {

        }

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

        private void pnlBgM_MouseClick(object sender, MouseEventArgs e)
        {
            mensaje();
        }

        private void pnlBgG_MouseClick(object sender, MouseEventArgs e)
        {
            mensaje2();
        }

        public void pruebaMensaje(string cadena)
        {
            MessageBox.Show("La cadena es: " + cadena);
        }
    }
}
