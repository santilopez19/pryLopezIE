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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnCargarProveedor = new System.Windows.Forms.Button();
            this.btnVerProveedor = new System.Windows.Forms.Button();
            this.txtDatosProveedor = new System.Windows.Forms.TextBox();
            this.txtRutaProveedor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 316);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(992, 171);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(33, 26);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(160, 240);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btnCargarProveedor
            // 
            this.btnCargarProveedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCargarProveedor.Location = new System.Drawing.Point(853, 131);
            this.btnCargarProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargarProveedor.Name = "btnCargarProveedor";
            this.btnCargarProveedor.Size = new System.Drawing.Size(140, 28);
            this.btnCargarProveedor.TabIndex = 3;
            this.btnCargarProveedor.Text = "Cargar Proveedor";
            this.btnCargarProveedor.UseVisualStyleBackColor = true;
            this.btnCargarProveedor.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnVerProveedor
            // 
            this.btnVerProveedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerProveedor.Location = new System.Drawing.Point(241, 131);
            this.btnVerProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerProveedor.Name = "btnVerProveedor";
            this.btnVerProveedor.Size = new System.Drawing.Size(140, 28);
            this.btnVerProveedor.TabIndex = 4;
            this.btnVerProveedor.Text = "Ver Proveedor";
            this.btnVerProveedor.UseVisualStyleBackColor = true;
            this.btnVerProveedor.Click += new System.EventHandler(this.btnVerProveedor_Click);
            // 
            // txtDatosProveedor
            // 
            this.txtDatosProveedor.Location = new System.Drawing.Point(437, 26);
            this.txtDatosProveedor.Multiline = true;
            this.txtDatosProveedor.Name = "txtDatosProveedor";
            this.txtDatosProveedor.Size = new System.Drawing.Size(396, 240);
            this.txtDatosProveedor.TabIndex = 5;
            // 
            // txtRutaProveedor
            // 
            this.txtRutaProveedor.Location = new System.Drawing.Point(437, 276);
            this.txtRutaProveedor.Name = "txtRutaProveedor";
            this.txtRutaProveedor.Size = new System.Drawing.Size(396, 22);
            this.txtRutaProveedor.TabIndex = 6;
            // 
            // Cargar_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtRutaProveedor);
            this.Controls.Add(this.txtDatosProveedor);
            this.Controls.Add(this.btnVerProveedor);
            this.Controls.Add(this.btnCargarProveedor);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCerrar);
            this.ForeColor = System.Drawing.Color.Lavender;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cargar_Proveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar_Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnCargarProveedor;
        private System.Windows.Forms.Button btnVerProveedor;
        private System.Windows.Forms.TextBox txtDatosProveedor;
        private System.Windows.Forms.TextBox txtRutaProveedor;
    }
}