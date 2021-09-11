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
    public partial class pruebas : Form
    {
        public pruebas()
        {
            InitializeComponent();
        }

        private void pruebas_Load(object sender, EventArgs e)
        {
            cmbBoxPrueba.Items.Add("Combo Opción 1");
            cmbBoxPrueba.Items.Add("Combo Opción 2");
            cmbBoxPrueba.Items.Add("Combo Opción 3");
            List<Control> contrs = new List<Control>();

            for(int i = 0; i < this.Controls.Count; i++)
            {
                contrs.Add(this.Controls[i]);
            }
            navegador1.pruebasAsignar(contrs);
        }
    }
}
