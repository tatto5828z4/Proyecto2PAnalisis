using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavegadorPrototipo
{
    public partial class navegador : UserControl
    {
        public navegador()
        {
            InitializeComponent();
        }

        private void lblIngreso_Click(object sender, EventArgs e)
        {

        }

        private void lblIngresar_Click(object sender, EventArgs e)
        {

        }

        private void toolTipNavegador_Popup(object sender, PopupEventArgs e)
        {

        }

        private void navegador_Load(object sender, EventArgs e)
        {
            //Ingreso
            toolTipNavegador.SetToolTip(this.btnIngresar,"Ingresar Registro");
            //Modificación
            toolTipNavegador.SetToolTip(this.btnModificar, "Modificar Registro");
            //Guardar
            toolTipNavegador.SetToolTip(this.btnGuardar, "Guada la información");
            //Cancelar
            toolTipNavegador.SetToolTip(this.btnCancelar, "Cancela la operación");
            //Eliminar
            toolTipNavegador.SetToolTip(this.btnEliminar, "Elimnar Registro");
            //Consultas
            toolTipNavegador.SetToolTip(this.btnConsultar, "Abre el módulo de \nConsultas Inteligentes");
            //Reportes
            toolTipNavegador.SetToolTip(this.btnReportes, "Abre el módulo de Reportes");
            //Actualizar
            toolTipNavegador.SetToolTip(this.btnActualizar, "Actualiza la información mostrada\nen pantalla");
            //Inicio
            toolTipNavegador.SetToolTip(this.btnInicial, "Se mueve al registro inicial");
            //Anterior
            toolTipNavegador.SetToolTip(this.btnAnterior, "Se mueve al registro anterior");
            //Siguiente
            toolTipNavegador.SetToolTip(this.btnSiguiente, "Se mueve al registro siguiente");
            //Final
            toolTipNavegador.SetToolTip(this.btnFinal, "Se mueve al registro final");
            //Ayuda
            toolTipNavegador.SetToolTip(this.btnAyuda, "Abre la ventana de ayuda");
            //Salir
            toolTipNavegador.SetToolTip(this.btnSalir, "Cierra la ventana actual");
            //desactivar los botones al inicio
            desactivarBotones(0);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            pruebaRecogerDatos();
        }

        public void funAsignarAlias(TextBox[] alias)
        {
            string[] arreglo;
            int cantidad = 0;

            foreach (TextBox dato in alias)
            {
                cantidad++;
            }

            arreglo = new string[cantidad];
            int i = 0;

            foreach (TextBox dato in alias)
            {
                arreglo[i] = dato.Tag.ToString();
                MessageBox.Show("Lo que tiene es: " + arreglo[i]);
                i++;
            }
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
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
            }
            else
            {
                btnIngresar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        List<Control> pruebaControles;
        public void pruebasAsignar(List<Control> listaControles)
        {
            pruebaControles = listaControles;
        }

        public void pruebaRecogerDatos()
        {
            int x;
            x = pruebaControles.Count;

            for (int i = 0; i < x; i++)
            {
                MessageBox.Show("Control [" + i + "]: " + pruebaControles[i].Text);
                pruebaControles[i].Enabled = false;
            }
            MessageBox.Show("Prueba de integración Noel");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desactivarBotones(0);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            desactivarBotones(1);
        }
    }
}
