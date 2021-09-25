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

            //TextBox[] alias = { txtID, txtCodigoMarca, txtNombre, txtFecha, txtDescripcion, txtStock, txtPrecio, txtEstatus};
            TextBox[] alias = navegador1.funAsignandoTexts(this);
            navegador1.funAsignarAliasVista(alias, "producto", "pruebas");
            navegador1.funAsignarSalidadVista(this);
            navegador1.funLlenarComboControl(cbxCodMarca, "marca", "idMarca", "nombre","estatus");
            
            //inicio de elementos para dar de baja
            navegador1.campoEstado = "estado";
            //fin de elementos para dar de baja

            //inicio de elementos para ejecutar la ayuda
            navegador1.tablaAyuda = "ayuda";
            navegador1.campoAyuda = "idAyuda";
            navegador1.idAyuda = "1";
            //fin de elementos para ejecutar la ayuda

            navegador1.pideGrid(this.dvgConsulta);
            navegador1.llenaTabla();
            navegador1.pedirRef(this);
            //String cadena = txtprueba.Text;
            //navegador1.pruebaMensaje(cadena);



            //cbxCodMarca

        }

       /* public void ayudaR()
        {
            Help.ShowHelp(this, "Ayudas/AyudasSistemaReparto.chm", "ManualSistemaReparto.html");

        }
       */
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String dt = "";
            dt = dtProducto.Value.ToString("yyyy-MM-dd");//lo pasa al formato necesitado por mysql
            txtFecha.Text = dt;
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            //String cbx = cbxCodMarca.Text();
            //cbxCodMarca
            
        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                txtEstatus.Text = "A";
            }

        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                txtEstatus.Text = "I";
            }

        }

        private void navegador1_Load_1(object sender, EventArgs e)
        {

        }


        private void cbxCodMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            String cbx = cbxCodMarca.Text;
            txtCodigoMarca.Text = cbx;
            
        }

        private void navegador1_Load_2(object sender, EventArgs e)
        {

        }

        private void dvgConsulta_CurrentCellChanged(object sender, EventArgs e)
        {
            //navegador1.cargaData();
        }
    }
}
