namespace pryLopezSP1
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.msProveedores = new System.Windows.Forms.MenuStrip();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pctLogoFl = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.msProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoFl)).BeginInit();
            this.SuspendLayout();
            // 
            // msProveedores
            // 
            this.msProveedores.Dock = System.Windows.Forms.DockStyle.Left;
            this.msProveedores.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msProveedores.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresToolStripMenuItem});
            this.msProveedores.Location = new System.Drawing.Point(0, 0);
            this.msProveedores.Name = "msProveedores";
            this.msProveedores.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.msProveedores.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.msProveedores.Size = new System.Drawing.Size(110, 554);
            this.msProveedores.TabIndex = 0;
            this.msProveedores.Text = "menuStrip1";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeProveedoresToolStripMenuItem});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // listaDeProveedoresToolStripMenuItem
            // 
            this.listaDeProveedoresToolStripMenuItem.Name = "listaDeProveedoresToolStripMenuItem";
            this.listaDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.listaDeProveedoresToolStripMenuItem.Text = "Lista de Proveedores";
            this.listaDeProveedoresToolStripMenuItem.Click += new System.EventHandler(this.listaDeProveedoresToolStripMenuItem_Click);
            // 
            // pctLogoFl
            // 
            this.pctLogoFl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctLogoFl.Image = global::pryLopezSP1.Properties.Resources.SegurosFL;
            this.pctLogoFl.Location = new System.Drawing.Point(110, 0);
            this.pctLogoFl.Margin = new System.Windows.Forms.Padding(4);
            this.pctLogoFl.Name = "pctLogoFl";
            this.pctLogoFl.Size = new System.Drawing.Size(957, 554);
            this.pctLogoFl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogoFl.TabIndex = 1;
            this.pctLogoFl.TabStop = false;
            this.pctLogoFl.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(951, 511);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 28);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pctLogoFl);
            this.Controls.Add(this.msProveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msProveedores;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SegurosFL";
            this.msProveedores.ResumeLayout(false);
            this.msProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoFl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msProveedores;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.PictureBox pctLogoFl;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ToolStripMenuItem listaDeProveedoresToolStripMenuItem;
    }
}