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
    public partial class SegurosFL : Form
    {
        public SegurosFL()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cargarNuevoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            Cargar_Proveedores Cargar_Proveedores = new Cargar_Proveedores();
            Cargar_Proveedores.Show();
        }

        private void modificarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            Modificar_Proveedores Modificar_Proveedores = new Modificar_Proveedores();
            Modificar_Proveedores.Show();
        }

        private void verProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            Ver_Proveedores Ver_Proveedores = new Ver_Proveedores();
            Ver_Proveedores.Show();
        }

        private void verClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            Ver_Clientes Ver_Clientes = new Ver_Clientes();
            Ver_Clientes.Show();
        }

        private void cargarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            Cargar_Clientes Cargar_Clientes = new Cargar_Clientes();
            Cargar_Clientes.Show();
        }

        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            Ver_Productos Ver_Productos = new Ver_Productos();
            Ver_Productos.Show();
        }

        private void cargarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            Cargar_productos Cargar_productos = new Cargar_productos();
            Cargar_productos.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
