using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            TextBox[] alias = { txtID, txtCodigoMarca, txtNombre, txtFecha, txtDescripcion, txtStock, txtPrecio, txtEstatus};
            navegador1.funAsignarAliasVista(alias, "producto", "pruebas");
            navegador1.funAsignarSalidadVista(this);
            navegador1.pideGrid(this.dvgConsulta);
            navegador1.llenaTabla();
            navegador1.pedirRef(this);
            //String cadena = txtprueba.Text;
            //navegador1.pruebaMensaje(cadena);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String dt = "";
            dt = dtProducto.Value.ToString();
            txtFecha.Text = dt;
        }
    }
}
