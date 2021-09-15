using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using navModelo;

namespace navControlador
{
    public class CapaControlador
    {
        string errores = "";

        CapaModelo modelo = new CapaModelo();
        public void funAsignarAliasContro(TextBox[] alias, string tabla, string BD)
        {
            errores = modelo.funAsignarAlias(alias, tabla, BD);

            MessageBox.Show(errores);
        }
    }
}
