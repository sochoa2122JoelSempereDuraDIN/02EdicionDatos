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
    public partial class fmIntroduccionDatos : Form
    {
        public fmIntroduccionDatos()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCodigoPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            //metodo isdigit comprueba que lo tecleado es un digito
            //averiguar tecla pulsada a traves de keys."xxx"
            switch (e.KeyChar)
            {
                case (char)8:
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                break;
                default:
                    e.KeyChar = (char)0; //anular pulsacion
                    break;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (ActiveControl is TextBox)
                {
                    SendKeys.Send("{TAB}");
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
