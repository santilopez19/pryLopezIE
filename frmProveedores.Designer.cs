namespace pryLopezSP1
{
    partial class Cargar_Proveedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cargar_Proveedores));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dtvMostrarProveedor = new System.Windows.Forms.DataGridView();
            this.tvwMostrarProveedores = new System.Windows.Forms.TreeView();
            this.imageListTreeViewProveedores = new System.Windows.Forms.ImageList(this.components);
            this.btnCargarProveedor = new System.Windows.Forms.Button();
            this.lblSeleccionar = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstProveedores = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.dtvMostrarProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCerrar.Location = new System.Drawing.Point(951, 511);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 28);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // dtvMostrarProveedor
            // 
            this.dtvMostrarProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvMostrarProveedor.Location = new System.Drawing.Point(33, 316);
            this.dtvMostrarProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.dtvMostrarProveedor.Name = "dtvMostrarProveedor";
            this.dtvMostrarProveedor.RowHeadersWidth = 51;
            this.dtvMostrarProveedor.Size = new System.Drawing.Size(992, 171);
            this.dtvMostrarProveedor.TabIndex = 1;
            this.dtvMostrarProveedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tvwMostrarProveedores
            // 
            this.tvwMostrarProveedores.ImageIndex = 0;
            this.tvwMostrarProveedores.ImageList = this.imageListTreeViewProveedores;
            this.tvwMostrarProveedores.Location = new System.Drawing.Point(33, 58);
            this.tvwMostrarProveedores.Margin = new System.Windows.Forms.Padding(4);
            this.tvwMostrarProveedores.Name = "tvwMostrarProveedores";
            this.tvwMostrarProveedores.SelectedImageIndex = 0;
            this.tvwMostrarProveedores.Size = new System.Drawing.Size(261, 240);
            this.tvwMostrarProveedores.TabIndex = 2;
            this.tvwMostrarProveedores.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageListTreeViewProveedores
            // 
            this.imageListTreeViewProveedores.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTreeViewProveedores.ImageStream")));
            this.imageListTreeViewProveedores.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTreeViewProveedores.Images.SetKeyName(0, "carpeta_pryIE1-removebg-preview.png");
            this.imageListTreeViewProveedores.Images.SetKeyName(1, "archivo_pryIE1-removebg-preview.png");
            // 
            // btnCargarProveedor
            // 
            this.btnCargarProveedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCargarProveedor.Location = new System.Drawing.Point(885, 270);
            this.btnCargarProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargarProveedor.Name = "btnCargarProveedor";
            this.btnCargarProveedor.Size = new System.Drawing.Size(140, 28);
            this.btnCargarProveedor.TabIndex = 3;
            this.btnCargarProveedor.Text = "Cargar Proveedor";
            this.btnCargarProveedor.UseVisualStyleBackColor = true;
            this.btnCargarProveedor.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblSeleccionar
            // 
            this.lblSeleccionar.AutoSize = true;
            this.lblSeleccionar.ForeColor = System.Drawing.Color.Black;
            this.lblSeleccionar.Location = new System.Drawing.Point(30, 25);
            this.lblSeleccionar.Name = "lblSeleccionar";
            this.lblSeleccionar.Size = new System.Drawing.Size(126, 16);
            this.lblSeleccionar.TabIndex = 6;
            this.lblSeleccionar.Text = "Seleccionar archivo";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVolver.Location = new System.Drawing.Point(33, 511);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 28);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryLopezSP1.Properties.Resources.LogoSegurosFL;
            this.pictureBox1.Location = new System.Drawing.Point(951, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lstProveedores
            // 
            this.lstProveedores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstProveedores.HideSelection = false;
            this.lstProveedores.Location = new System.Drawing.Point(312, 58);
            this.lstProveedores.Name = "lstProveedores";
            this.lstProveedores.Size = new System.Drawing.Size(459, 240);
            this.lstProveedores.SmallImageList = this.imageListTreeViewProveedores;
            this.lstProveedores.TabIndex = 9;
            this.lstProveedores.UseCompatibleStateImageBehavior = false;
            this.lstProveedores.View = System.Windows.Forms.View.Details;
            this.lstProveedores.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 78;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tipo";
            this.columnHeader2.Width = 79;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ult. Modificacion";
            this.columnHeader3.Width = 118;
            // 
            // Cargar_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lstProveedores);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblSeleccionar);
            this.Controls.Add(this.btnCargarProveedor);
            this.Controls.Add(this.tvwMostrarProveedores);
            this.Controls.Add(this.dtvMostrarProveedor);
            this.Controls.Add(this.btnCerrar);
            this.ForeColor = System.Drawing.Color.Lavender;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cargar_Proveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Cargar_Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvMostrarProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        public System.Windows.Forms.DataGridView dtvMostrarProveedor;
        private System.Windows.Forms.TreeView tvwMostrarProveedores;
        private System.Windows.Forms.Button btnCargarProveedor;
        private System.Windows.Forms.Label lblSeleccionar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView lstProveedores;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ImageList imageListTreeViewProveedores;
    }
}