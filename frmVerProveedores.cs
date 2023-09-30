using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryLopezSP1
{
    public partial class Ver_Proveedores : Form
    {
        public Ver_Proveedores()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Cargar_Proveedores frmCargar_Proveedores = new Cargar_Proveedores();
            this.Hide();
            frmCargar_Proveedores.Show();
        }

        private void Ver_Proveedores_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
