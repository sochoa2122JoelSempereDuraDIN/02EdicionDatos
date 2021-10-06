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
        public TextBox tbNombreMostrar;
        bool dniValido = true;
        public fmIntroduccionDatos()
        {
            InitializeComponent();
        }
        //FUNCION VALIDARNIF
        public bool calculaLetraNif(int dni, char letra)
        {
            char letracorrecta;
            int resto; // resto de la funcion para saber la letra en la cadena 
            string letras = "TRWAGMYFPDXBNJZSQUHLCKE";
            resto = dni % 23;
            letracorrecta = letras[resto]; // esto es lo que devuelve la funcion 
            if (letracorrecta == letra)
                return true;
            else
                return false;
        }

        //FUNCION VALIDACIF
        public bool validaCif(string cif)
        {
            int Suma = 0, Control; byte n; bool Resulta = false;
            if (cif.Length == 9)
            {  //sumar las cifras pares
                Suma = Convert.ToInt32(Convert.ToString(cif[2])) +
                Convert.ToInt32(Convert.ToString(cif[4])) + Convert.ToInt32(Convert.ToString(cif[6]));

                for (n = 0; n <= 3; n++)
                {//suma los impares
                    string impares = Convert.ToString(Convert.ToInt32(Convert.ToString(cif[n * 2 + 1])) * 2);
                    Suma = Suma + Convert.ToInt32(Convert.ToString(impares[0]));
                    if (impares.Length > 1)
                        Suma = Suma + Convert.ToInt32(Convert.ToString(impares[1]));
                }
                Control = 10 - (Suma % 10);/////////////////////////////////////
                string primercar = Convert.ToString(cif[0]);
                if ((primercar.IndexOf("X") >= 0) || (primercar.IndexOf("P") >= 0))
                {   //Control tipo letra
                    Resulta = (cif[8] == (char)(64 + Control));
                }
                else
                {   //Control tipo número
                    if (Control == 10) Control = 0;
                    Resulta = (Convert.ToString(cif[8])) == Convert.ToString(Control);
                }
            }//DEL IF
            return Resulta;
        } //fin de la funcion

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

        private void fmIntroduccionDatos_Load(object sender, EventArgs e)
        {
            foreach ( Control miControl in Controls )
            {
                if (miControl is TextBox)
                {
                    miControl.Text = "";
                }
            }
        }

        private void fmIntroduccionDatos_Shown(object sender, EventArgs e)
        {
            tbNombre.Focus();
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (tbEmail.Text == "") return; //para que no siga con la validacion si se cambia de textbox
            string[] postArroba = tbEmail.Text.Split('@');
            if ((tbEmail.Text.IndexOf("@") < 0) || (tbEmail.Text.IndexOf(".") < 0)){
                try
                {
                    if (postArroba[1].IndexOf(".") < 0)
                    {
                        MessageBox.Show("Email Invalido");
                        tbEmail.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Email Invalido");
                    tbEmail.Focus();
                }
            }
           
        }

        private void tbContra2_Validating(object sender, CancelEventArgs e)
        {
            //comprobar que las contraseñas coincidan
            //opcionalmente poner un tamaño minimo
            if (tbContra2.Text == "")
            {
                tbContra1.Text = "";
                return;
            }
            if (tbContra1.Text != tbContra2.Text)
            {
                MessageBox.Show("Las contraseñas NO coinciden");
                tbContra2.Focus();
            }
        }

        private void tbDniCif_TextChanged(object sender, EventArgs e)
        {
            bool dniValido = true; string dni; char letra; char digi; bool esNumero = true;
            if (tbDniCif.Text == "") return;
            digi = (char)tbDniCif.Text[0];
            switch (digi)
            {
                case '1': case '2': case '3' : case '4' :
                case '5': case '6' : case '7' : case '8':
                case '9': case '0': break;
                default:
                    esNumero = false;
                    break;
            }
            if ((tbDniCif.Text.Length == 9) && (esNumero))
            {
                letra = tbDniCif.Text[8];
                dni = tbDniCif.Text.Substring(0, 8);
                if (!calculaLetraNif(Convert.ToInt32(dni),letra))
                {
                    MessageBox.Show(letra + "Letra mal");
                    dniValido = false;
                    tbDniCif.Focus();
                }
                else
                {
                    if ((tbDniCif.Text.Length == 9) && (!esNumero))
                    {
                        MessageBox.Show("CIF no valido");
                        dniValido = false;
                        tbDniCif.Focus();
                    }
                }
            }
            //intentar con el NIE tambien
            //en recursos aparecen los algoritmos de DNI CIF
        }

        private void tbDniCif_Validating(object sender, CancelEventArgs e)
        {
            if ((tbDniCif.Text.Length < 9)&&(tbDniCif.Text.Length >0))
            {
                MessageBox.Show("DNI/CIF debe tener 9 caracteres, completa con ceros");
                tbDniCif.Focus();
            }
        }

        private void tbDniCif_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((tbDniCif.Text.Length>0)&& (tbDniCif.Text.Length<8))
            {
                switch (e.KeyChar)
                {
                    case (char)8:case'1':case'2':
                    case '3':case '4':case '5':case '6':case '7':case '8':case '9': case '0': break;
                    default:
                        e.KeyChar = (char)0;
                        break;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (tbDniCif.Text == "")
            {
                MessageBox.Show("Falta el DNI");
                tbDniCif.Focus();
                return;
            }
            if (!dniValido)
            {
                MessageBox.Show("DNI no valido");
                tbDniCif.Focus();
                return;
            }
            if (tbNombre.Text == "")
            {
                MessageBox.Show("Falta el nombre");
                tbNombre.Focus();
                return;
            }
            DialogResult = DialogResult.OK; // cierra el formulario y devuelve un OK
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //asignado sin codigo a traves de la interfaz grafica con dialogresult.cancel
        }

        private void btnMostrarEnPrincipal_Click(object sender, EventArgs e)
        {
            tbNombreMostrar.Text = tbNombre.Text; //mirar si esta bien
        }
    }
}
