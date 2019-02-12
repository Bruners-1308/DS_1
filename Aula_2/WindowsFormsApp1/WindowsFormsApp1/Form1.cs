using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btCalcula_Click(object sender, EventArgs e)
        {
            float numero1, numero2;
            string operador;
            float resultado;

            numero1 = float.Parse(txtNum1.Text);
            numero2 = Convert.ToSingle(txtNum2.Text);

            operador = txtOperador.Text;

            switch (operador)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;

                case "-":
                    resultado = numero1 - numero2;
                    break;

                case "*":
                    resultado = numero1 * numero2;
                    break;

                case "/"
                    :
                    resultado = numero1 / numero2;
                    break;

                default:
                    resultado = 0;
                    break;
            }


            /*if (txtOperador.Text == "+")
            {
                resultado = numero1 + numero2;
            }

            else if (txtOperador.Text == "-")
            {
                resultado = numero1 - numero2;
            }

            else if (txtOperador.Text == "*")
            {
                resultado = numero1 * numero2;
            }

            else if (txtOperador.Text == "/")
            {
                resultado = numero1 / numero2;
            }

            else
            {
                resultado = 0;
            }

    */
            txtResultado.Text = resultado.ToString();
        }
        
    }
}
