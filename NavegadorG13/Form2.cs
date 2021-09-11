using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavegadorG13
{
    public partial class Frm2 : Form
    {
        public Frm2()
        {
            InitializeComponent();
            txtFecha.Visible = false;
            txtEstatus.Visible = false;
            txtCodigoMarca.Visible = false;
            TextBox[] alias = { txtID, txtCodigoMarca, txtNombre, txtFecha, txtDescripcion, txtStock, txtPrecio, txtEstatus};
            navegador1.funAsignarAliasVista(alias,"producto","pruebas");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String dt="";
            dt = dtProducto.Value.ToString();
            txtFecha.Text = dt;
        }
    }
}
