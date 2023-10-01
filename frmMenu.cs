using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLopezSP1
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void verClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cargarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cargarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void listaDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cargar_Proveedores frmCargar_Proveedores = new Cargar_Proveedores();
            this.Hide();
            frmCargar_Proveedores.Show();
        }
    }
}
