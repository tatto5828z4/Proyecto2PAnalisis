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
    /*Josue Daniel Zapata Azañon - 9959-18-4829 - Creacion de form Reporte*/
    public partial class reporte : Form
    {
        public string ruta = "";

        public reporte()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument reporte = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            reporte.Load(@"" + ruta);
            crystalReportViewer1.ReportSource = reporte;
        }

        private void reporte_Load(object sender, EventArgs e)
        {

        }
    }
}
