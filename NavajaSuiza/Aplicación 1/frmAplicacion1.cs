using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaSuiza.Aplicación_1
{
    public partial class FrmAplicacion1 : Form
    {
        public FrmAplicacion1()
        {
            InitializeComponent();
        }

        public static string ComprobarNum(string numero)
        {
            bool EsPrimo;
            int NumeroIntroducido;
            string mensaje = " ";

            bool elementovalido = int.TryParse(numero, out NumeroIntroducido);

            if (elementovalido)
            {
                EsPrimo = EsPrimo(NumeroIntroducido);

                if (EsPrimo)
                {
                    mensaje = "El número es primo";
                }
                else
                {
                    mensaje = " El número no es primo";
                }
            }
            return mensaje;
        }
            public static bool EsPrimo(int NumeroIntroducido)
        {
            bool esprimo = true;
            if (NumeroIntroducido > 1)
            {
                for (int i = 2; i < NumeroIntroducido && esprimo; i++)
                {
                    if (NumeroIntroducido % i == 0)
                    {
                        esprimo = false;
                    }
                }
            }
            else
            {
                esprimo = false;
            }
            return esprimo;

        }
        private void ComprobarPrimos(object sender, EventArgs e)
        {
            int numero, contador, i;
            contador = 0;
            i = 1;
            numero = int.Parse(textBox1.Text);
            while (i <= numero)
            {
                if (numero % i == 0)
                {
                    contador = contador + 1;
                }
                i = i + 1;
            }
            if (contador > 2)
            {
                MessageBox.Show("El numero introducido no es primo");
            }
            else
            {
                MessageBox.Show("El numero introducido si que es primo");
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 5;
        }
    }
}
