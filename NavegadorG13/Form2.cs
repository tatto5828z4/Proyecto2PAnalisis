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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            TextBox[] alias = { txtID, txtCodigoMarca, txtNombre, txtFecha, txtDescripcion, txtStock, txtPrecio, txtEstatus};
            navegador1.funAsignarAliasVista(alias,"producto","pruebas");
            //navegador1.funAsignarSalida(this);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
