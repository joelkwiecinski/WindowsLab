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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtAncho.Text.Contains("."))
            {
                txtAncho.Text.Replace(".", ",");
            }
            if (txtAlto.Text.Contains("."))
            {
                txtAlto.Text.Replace(".", ",");
            }
            AreaRectangulo(txtAncho.Text, txtAlto.Text);
        }

        private void AreaRectangulo(string anchoRect, string altoRect)
        {
            if (txtAncho.Text.Contains("."))
            {
                txtAncho.Text.Replace(".", ",");
            }
            if (txtAlto.Text.Contains("."))
            {
                txtAlto.Text.Replace(".", ",");
            }

            bool baseConvertida = double.TryParse(txtAncho.Text, out double baseRectangulo);
            bool altoConvertido = double.TryParse(txtAlto.Text, out double altoRectangulo);

            if (baseConvertida && altoConvertido)
            {
                double area = baseRectangulo * altoRectangulo;
                MessageBox.Show("El área del rectángulo es " + area);
            }
            else
            {
                MessageBox.Show("Hubo algún problema con los datos ingresados, revisa que sean correctos.");
            }
        }
    }
}
