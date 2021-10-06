using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02EdicionDatos
{
    public partial class fmEdicionDatos : Form
    {
        fmAcercaDe ventanaAcercaDe;
        fmIntroduccionDatos ventanaIntroduccionDatos = new fmIntroduccionDatos(); // hay que hacerlo estatico
        public fmEdicionDatos()
        {
            InitializeComponent();
        }

        private void tbEuros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnCambiar.PerformClick();
            }
            //metodo isdigit comprueba que lo tecleado es un digito
            //averiguar tecla pulsada a traves de keys."xxx"
            switch (e.KeyChar)
            {
                case (char)8: case '1': case '2': case '3': case '4': case '5': case '6': case '7':
                case '8': case '9': case '0': case ',': break;
                default:
                    e.KeyChar = (char)0; //anular pulsacion
                    break;
            }


        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
       
            Single total, formatea; //como un float pero monetario
            try
            {
                if (Convert.ToSingle(tbPesetas.Text) > 0)
                {
                    formatea = Convert.ToSingle(tbPesetas.Text);
                    total = Convert.ToSingle(tbPesetas.Text) / 166.386f;
                    tbEuros.Text = total.ToString("#,###,##0.00");
                    tbPesetas.Text = formatea.ToString("##,###,###,##0");
                }

                if (Convert.ToSingle(tbEuros.Text) > 0)
                {
                    formatea = Convert.ToSingle(tbEuros.Text);
                    total = Convert.ToSingle(tbEuros.Text) * 166.386f;
                    tbPesetas.Text = total.ToString("#,###,###,##0");
                    tbEuros.Text = formatea.ToString("#,###,##0,00");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

           
        }

        private void tbEuros_TextChanged(object sender, EventArgs e)
        {
            btnCambiar.Enabled = true;

        }

        private void tbPesetas_Click(object sender, EventArgs e)
        {
            tbEuros.Text = "0";
            tbPesetas.Text = "0";
            TextBox miTextBox = (TextBox)sender;
            miTextBox.SelectAll();
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            ventanaAcercaDe = new fmAcercaDe(); // esta es la forma de hacerlo dinamico
            ventanaAcercaDe.ShowDialog();
            ventanaAcercaDe.Dispose(); // se usa en dinamico para destruir el objeto y que no ocupe memoria (revisar por si me he equivocado)
        }

        private void btnIntroducirDatos_Click(object sender, EventArgs e)
        {
            /*
            ventanaIntroduccionDatos = new fmIntroduccionDatos();
            ventanaIntroduccionDatos.ShowDialog();
            ventanaIntroduccionDatos.Dispose();
            */
            pnDatos.Visible = true;
            ventanaIntroduccionDatos.tbNombreMostrar = tbNombrePrincipal;
            tbNombrePrincipal.Text = "";

            if (ventanaIntroduccionDatos.ShowDialog() == DialogResult.OK)
            {
                pnDatos.Visible = true;
                //para ppoder referirme a objetos de otras propiedades ...
                laNombre.Text = ventanaIntroduccionDatos.tbNombre.Text;
                laDireccion.Text = ventanaIntroduccionDatos.tbDireccion.Text;
                laLocalidad.Text = ventanaIntroduccionDatos.tbLocalidad.Text;
                laTelefono.Text = ventanaIntroduccionDatos.tbTelefono.Text;
                laEmail.Text = ventanaIntroduccionDatos.tbEmail.Text;
                laCodigoPostal.Text = ventanaIntroduccionDatos.tbCodigoPostal.Text;
                laDniCif.Text = ventanaIntroduccionDatos.tbDniCif.Text;
            }
            else
            {
                pnDatos.Visible = false; // esto borra los datos del panel. no se si lo quiero, en casa hacer bien si es posible, revisar el 
            }

        }

        private void fmEdicionDatos_Load(object sender, EventArgs e)
        {

        }

        private void pnDatos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
