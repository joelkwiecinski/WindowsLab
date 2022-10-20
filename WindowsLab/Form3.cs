using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsLab
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            bool numeroConvertido = double.TryParse(txtNumero.Text, out double numeroIngresado);
            if (numeroConvertido)
            {
                multiplicar(numeroIngresado);
            }
            else
            {
                MessageBox.Show("Hay algún problema con el número ingresado. Revisa e intenta nuevamente.");
            }
        }


        private void multiplicar(double numero)
        {
            string mensajeTabla = "";
            for (int i = 1; i <= 12; i++)
            {
                double multiplicado = numero * i;
                if (mensajeTabla == "")
                {
                    mensajeTabla = numero + "x" + i + " = " + multiplicado;
                }
                else
                {
                    mensajeTabla += "\n" + numero + "x" + i + " = " + multiplicado;
                }
            }
            MessageBox.Show("Las tablas de multiplicar para este número son: \n" + mensajeTabla);
        }
    }
}
