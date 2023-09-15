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
    public partial class Cargar_Proveedores : Form
    {
        public Cargar_Proveedores()
        {
            InitializeComponent();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(txtRutaProveedor.Text, false))
            {
                sw.WriteLine(txtDatosProveedor);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btnVerProveedor_Click(object sender, EventArgs e)
        {
            using(StreamReader sr=StreamReader(//ruta del archivo))
            {
                string linea;
             while((linea = sr.ReadLine()) != null)
                {
                    dataGridView1.AppendText(linea+"\n");
                }
            }
        }
    }
}
