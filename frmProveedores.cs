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
        private string GetNodePath(TreeNode node)
        {
            string path = node.Text;
            TreeNode currentNode = node.Parent;

            while (currentNode != null)
            {
                path = currentNode.Text + "\\" + path;
                currentNode = currentNode.Parent;
            }

            return path;
        }

        private void PopulateTreeView()
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

        private void GetDirectories(DirectoryInfo[] subDirs,
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
        void treeView1_NodeMouseClick(object sender,TreeNodeMouseClickEventArgs e)
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

        public string rutaProveedor = "";
        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;

            rutaProveedor = GetNodePath(selectedNode);
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string infoProveedor = lstProveedores.SelectedItems[0].Text.ToString();
            string rutaProveedorParcial = Path.Combine(rutaProveedor, infoProveedor);
            string rutaProveedorFinal = Path.Combine(@"../../Resources/Proveedores", rutaProveedorParcial);

            using (StreamReader reader = new StreamReader(rutaProveedorFinal))
            {
                reader.ReadLine();

                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    string[] parametros = linea.Split(';');
                    dtvMostrarProveedor.Rows.Add(parametros);
                }
            }
        }
    }
}
