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
            PopulateTreeView();
            this.tvwMostrarProveedores.NodeMouseClick += new TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
        }

        public void PopulateTreeView()
        {
            TreeNode rootNode;

            DirectoryInfo info = new DirectoryInfo(@"../../Resources/Proveedores");
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                tvwMostrarProveedores.Nodes.Add(rootNode);
            }
        }

        public void GetDirectories(DirectoryInfo[] subDirs,
            TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }
        public void treeView1_NodeMouseClick(object sender,TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            lstProveedores.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                    {new ListViewItem.ListViewSubItem(item, "Directory"),
             new ListViewItem.ListViewSubItem(item,
                dir.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                lstProveedores.Items.Add(item);
            }
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[]
                    { new ListViewItem.ListViewSubItem(item, "File"),
             new ListViewItem.ListViewSubItem(item,
                file.LastAccessTime.ToShortDateString())};

                item.SubItems.AddRange(subItems);
                lstProveedores.Items.Add(item);
            }

            lstProveedores.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        string leerLinea;
        string[] separarDatos;
        private bool grillaCreada = false;
        public static int pos = 0;
        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = dtvMostrarProveedor.CurrentRow.Index;
            
            verProveedores.txtNumero.Text = dtvMostrarProveedor[0, pos].Value.ToString();
            verProveedores.txtEntidad.Text = dtvMostrarProveedor[1, pos].Value.ToString();
            Ver_Proveedores.txtApertura.Text = dtvMostrarProveedor[2, pos].Value.ToString();
            Ver_Proveedores.txtExpediente.Text = dtvMostrarProveedor[3, pos].Value.ToString();
            Ver_Proveedores.txtJuzgado.Text = dtvMostrarProveedor[4, pos].Value.ToString();
            Ver_Proveedores.txtJurisdiccion.Text = dtvMostrarProveedor[5, pos].Value.ToString();
            Ver_Proveedores.txtDireccion.Text = dtvMostrarProveedor[6, pos].Value.ToString();
            Ver_Proveedores.txtLiquidador.Text = dtvMostrarProveedor[7, pos].Value.ToString();

            this.Hide();
            Ver_Proveedores.Show();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btnVerProveedor_Click(object sender, EventArgs e)
        {
        }

        private void Cargar_Proveedores_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            this.Hide();
            frmMenu.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            frmMenu frmMenu = new frmMenu();
            this.Hide();
            frmMenu.Show();
        }
        public void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!grillaCreada)
            {
                StreamReader sr = new StreamReader("../../Resources/Proveedores");

                string leerLinea;
                string[] separarDatos;

                leerLinea = sr.ReadLine();
                separarDatos = leerLinea.Split(';');

                for (int indice = 0; indice < separarDatos.Length; indice++)
                {
                    dtvMostrarProveedor.Columns.Add(separarDatos[indice], separarDatos[indice]);
                }

                while (sr.EndOfStream == false)
                {
                    leerLinea = sr.ReadLine();
                    separarDatos = leerLinea.Split(';');
                    dtvMostrarProveedor.Rows.Add(separarDatos);
                }

                sr.Close();

                grillaCreada = true;
            }
            else
            {
                dtvMostrarProveedor.Rows.Clear();
                dtvMostrarProveedor.Columns.Clear();

                StreamReader sr = new StreamReader("../../Resources/Proveedores");

                string leerLinea;
                string[] separarDatos;

                leerLinea = sr.ReadLine();
                separarDatos = leerLinea.Split(';');

                for (int indice = 0; indice < separarDatos.Length; indice++)
                {
                    dtvMostrarProveedor.Columns.Add(separarDatos[indice], separarDatos[indice]);
                }

                while (sr.EndOfStream == false)
                {
                    leerLinea = sr.ReadLine();
                    separarDatos = leerLinea.Split(';');
                    dtvMostrarProveedor.Rows.Add(separarDatos);

                }

                sr.Close();

                MessageBox.Show("Grilla actualizada");
            }

        }

        private void lstProveedores_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!grillaCreada)
            {
                StreamReader sr = new StreamReader("../../Resources/Proveedores");

                string leerLinea;
                string[] separarDatos;

                leerLinea = sr.ReadLine();
                separarDatos = leerLinea.Split(';');

                for (int indice = 0; indice < separarDatos.Length; indice++)
                {
                    dtvMostrarProveedor.Columns.Add(separarDatos[indice], separarDatos[indice]);
                }

                while (sr.EndOfStream == false)
                {
                    leerLinea = sr.ReadLine();
                    separarDatos = leerLinea.Split(';');
                    dtvMostrarProveedor.Rows.Add(separarDatos);
                }

                sr.Close();

                grillaCreada = true;
            }
            else
            {
                // Actualizamos los datos de la grilla
                dtvMostrarProveedor.Rows.Clear();
                dtvMostrarProveedor.Columns.Clear();

                StreamReader sr = new StreamReader("../../Resources/Proveedores");

                string leerLinea;
                string[] separarDatos;

                leerLinea = sr.ReadLine();
                separarDatos = leerLinea.Split(';');

                for (int indice = 0; indice < separarDatos.Length; indice++)
                {
                    dtvMostrarProveedor.Columns.Add(separarDatos[indice], separarDatos[indice]);
                }

                while (sr.EndOfStream == false)
                {
                    leerLinea = sr.ReadLine();
                    separarDatos = leerLinea.Split(';');
                    dtvMostrarProveedor.Rows.Add(separarDatos);

                }

                sr.Close();

                MessageBox.Show("Grilla actualizada");
            }

        }
    }
}
