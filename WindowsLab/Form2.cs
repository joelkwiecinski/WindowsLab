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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnChequear_Click(object sender, EventArgs e)
        {
            if (txtEdad.Text != "")
            {
                bool edadConvertida = int.TryParse(txtEdad.Text, out int edadUsuario);
                if (edadConvertida)
                {
                    ChequearEdad(edadUsuario);
                }
                else
                {
                    MessageBox.Show("Hubo un error con el dato ingresado, verifica e intenta de nuevo.");
                }
            }
            else
            {
                MessageBox.Show("Ingresa tu edad para verificarla.");
            }
        }

        private void ChequearEdad (int edad)
        {
            if (edad == 0)
            {
                MessageBox.Show("Hay un error con la edad ingresada.");
            }
            else if (edad < 18)
            {
                MessageBox.Show("Sos menor de edad.");
            }
            else if (edad >= 18 && edad < 60)
            {
                MessageBox.Show("Sos mayor de edad.");
            }
            else if (edad > 60)
            {
                MessageBox.Show("Usted es un adulto mayor.");
            }
        }
    }
}
