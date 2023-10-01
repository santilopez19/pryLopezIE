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
            this.Dispose();

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero.Text != "" & txtEntidad.Text != "" & txtApertura.Text != "" & txtNumero.Text != "" & txtJuzgado.Text != "" & txtJurisdiccion.Text != "" & txtDireccion.Text != "" & txtLiquidadorResponsable.Text != "")
            {
                btnGrabar.Enabled = true;
            }
            else
            {
                btnGrabar.Enabled = false;
            }
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero.Text != "" & txtEntidad.Text != "" & txtApertura.Text != "" & txtNumero.Text != "" & txtJuzgado.Text != "" & txtJurisdiccion.Text != "" & txtDireccion.Text != "" & txtLiquidadorResponsable.Text != "")
            {
                btnGrabar.Enabled = true;
            }
            else
            {
                btnGrabar.Enabled = false;
            }
        }

        private void txtJurisdiccion_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero.Text != "" & txtEntidad.Text != "" & txtApertura.Text != "" & txtNumero.Text != "" & txtJuzgado.Text != "" & txtJurisdiccion.Text != "" & txtDireccion.Text != "" & txtLiquidadorResponsable.Text != "")
            {
                btnGrabar.Enabled = true;
            }
            else
            {
                btnGrabar.Enabled = false;
            }
        }

        private void txtJuzgado_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero.Text != "" & txtEntidad.Text != "" & txtApertura.Text != "" & txtNumero.Text != "" & txtJuzgado.Text != "" & txtJurisdiccion.Text != "" & txtDireccion.Text != "" & txtLiquidadorResponsable.Text != "")
            {
                btnGrabar.Enabled = true;
            }
            else
            {
                btnGrabar.Enabled = false;
            }
        }

        private void txtNExpediente_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero.Text != "" & txtEntidad.Text != "" & txtApertura.Text != "" & txtNumero.Text != "" & txtJuzgado.Text != "" & txtJurisdiccion.Text != "" & txtDireccion.Text != "" & txtLiquidadorResponsable.Text != "")
            {
                btnGrabar.Enabled = true;
            }
            else
            {
                btnGrabar.Enabled = false;
            }
        }

        private void txtApertura_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero.Text != "" & txtEntidad.Text != "" & txtApertura.Text != "" & txtNumero.Text != "" & txtJuzgado.Text != "" & txtJurisdiccion.Text != "" & txtDireccion.Text != "" & txtLiquidadorResponsable.Text != "")
            {
                btnGrabar.Enabled = true;
            }
            else
            {
                btnGrabar.Enabled = false;
            }
        }

        private void txtEntidad_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero.Text != "" & txtEntidad.Text != "" & txtApertura.Text != "" & txtNumero.Text != "" & txtJuzgado.Text != "" & txtJurisdiccion.Text != "" & txtDireccion.Text != "" & txtLiquidadorResponsable.Text != "")
            {
                btnGrabar.Enabled = true;
            }
            else
            {
                btnGrabar.Enabled = false;
            }

        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Cargar_Proveedores frmCargar_Proveedores = new Cargar_Proveedores();
            this.Hide();
            frmCargar_Proveedores.Show();
        }

    }
}
