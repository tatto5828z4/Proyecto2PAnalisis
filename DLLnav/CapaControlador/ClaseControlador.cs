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
        }

        public void funAsignarSalidadControl(Form menu)
        {
            if (String.IsNullOrEmpty(errores))
            {
                modelo.funSalida(menu);
            }
            else
            {
                MessageBox.Show(errores);
                menu.Close();
            }
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
