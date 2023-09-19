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
    public partial class frmIngreso : Form
    {
        public frmIngreso()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin InicioSesion = new frmLogin();
            InicioSesion.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBarIngreso.Increment(5);
            if(progressBarIngreso.Value<100)
            {
                progressBarIngreso.Value++;
            }
            if(progressBarIngreso.Value==100)
            {
                timer1.Enabled = false;
                frmLogin frmLogin= new frmLogin();
                this.Hide();
                frmLogin.Show();
            }
        }
    }
}
