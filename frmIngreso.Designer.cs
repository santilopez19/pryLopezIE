namespace pryLopezSP1
{
    partial class frmIngreso
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngreso));
            this.pctLogoFl = new System.Windows.Forms.PictureBox();
            this.pbCarga = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoFl)).BeginInit();
            this.SuspendLayout();
            // 
            // pctLogoFl
            // 
            this.pctLogoFl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctLogoFl.Image = global::pryLopezSP1.Properties.Resources.SegurosFL;
            this.pctLogoFl.Location = new System.Drawing.Point(0, 0);
            this.pctLogoFl.Margin = new System.Windows.Forms.Padding(4);
            this.pctLogoFl.Name = "pctLogoFl";
            this.pctLogoFl.Size = new System.Drawing.Size(880, 538);
            this.pctLogoFl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogoFl.TabIndex = 0;
            this.pctLogoFl.TabStop = false;
            this.pctLogoFl.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbCarga
            // 
            this.pbCarga.BackColor = System.Drawing.Color.SkyBlue;
            this.pbCarga.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.pbCarga.Location = new System.Drawing.Point(271, 385);
            this.pbCarga.Margin = new System.Windows.Forms.Padding(4);
            this.pbCarga.Name = "pbCarga";
            this.pbCarga.Size = new System.Drawing.Size(320, 28);
            this.pbCarga.Step = 100;
            this.pbCarga.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(880, 538);
            this.Controls.Add(this.pbCarga);
            this.Controls.Add(this.pctLogoFl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frminicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoFl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctLogoFl;
        private System.Windows.Forms.ProgressBar pbCarga;
        private System.Windows.Forms.Timer timer1;
    }
}

