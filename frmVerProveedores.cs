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

        public void btnVolver_Click(object sender, EventArgs e)
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

        public void txtNumero_TextChanged(object sender, EventArgs e)
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

        public void txtDireccion_TextChanged(object sender, EventArgs e)
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

        public void txtJurisdiccion_TextChanged(object sender, EventArgs e)
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

        public void txtJuzgado_TextChanged(object sender, EventArgs e)
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

        public void txtNExpediente_TextChanged(object sender, EventArgs e)
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

        public void txtApertura_TextChanged(object sender, EventArgs e)
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

        public void txtEntidad_TextChanged(object sender, EventArgs e)
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

        public static string rutaArchivo = "../../Resources";
        public void btnGrabar_Click(object sender, EventArgs e)
        {
            string posicion = Cargar_Proveedores.pos.ToString();
            List<string> lista = new List<string>();
            using (StreamReader leer = new StreamReader(rutaArchivo))
            {
                string linea;
                while ((linea = leer.ReadLine()) != null)
                {
                    string[] parametros = linea.Split(';');

                    if (parametros[0] != posicion)
                    {
                        lista.Add(linea);
                    }
                    else
                    {
                        string lineaDos = txtNumero.Text + ";" + txtEntidad.Text + ";" + txtApertura.Text + ";" + txtNExpediente.Text + ";" + txtJuzgado.Text + ";" + txtJurisdiccion.Text + ";" + txtDireccion.Text + ";" + txtLiquidadorResponsable.Text + ";";
                        lista.Add(lineaDos);
                    }
                }
            }

            using (StreamWriter escribir = new StreamWriter(rutaArchivo))
            {
                foreach (string linea in lista)
                {
                    escribir.WriteLine(linea);
                }
            }

            MessageBox.Show("Proveedor Modificado");
            this.Hide();

            txtNumero.Clear();
            txtEntidad.Clear();
            txtApertura.Clear();
            txtNExpediente.Clear();
            txtJuzgado.Clear();
            txtJurisdiccion.Clear();
            txtDireccion.Clear();
            txtLiquidadorResponsable.Clear();
        }

    }
}
