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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Form2 Prod = new Form2();
            Prod.MdiParent = this;
            Prod.Show();
        }
    }
}
