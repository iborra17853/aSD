﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaSuiza.Aplicación_3
{
    public partial class FrmAplicacion3 : Form
    {
        public FrmAplicacion3()
        {
            InitializeComponent();
        }

       

        private void RealizarApl3(object sender, EventArgs e)
        {
            int numero, exponente, resultado, i ;

            numero = int.Parse(textBox1.Text);
            exponente = int.Parse(textBox2.Text);
            resultado = 1;
            i = 1;


            if (numero > 0)

                for (i = 1; i <= exponente; i++)
                {

                    resultado = resultado * numero;
                }
            MessageBox.Show("El resultado es" + " " + resultado);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 4;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 4;

        }

        private void FrmAplicacion3_Load(object sender, EventArgs e)
        {

        }
    }
}
