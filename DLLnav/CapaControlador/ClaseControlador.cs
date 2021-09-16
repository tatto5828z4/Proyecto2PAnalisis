using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModelo;

namespace CapaControlador
{
    public class ClaseControlador
    {
        string errores = "";
       
        ClaseModelo modelo = new ClaseModelo();

        public void funAsignarAliasControl(TextBox[] alias, string tabla, string BD)
        {
            errores = modelo.funAsignarAlias(alias, tabla, BD);

            MessageBox.Show(errores);
        }

        public DataTable llenarTbl(string tablaDB)
        {
            OdbcDataAdapter dt = modelo.llenarTbl(tablaDB);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

    }
}
