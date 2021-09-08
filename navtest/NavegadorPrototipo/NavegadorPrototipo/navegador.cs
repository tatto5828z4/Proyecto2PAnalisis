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
        }
    }
}
