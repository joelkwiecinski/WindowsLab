using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsLab
{
    public partial class Form8 : Form
    {

        double[] precioProductos;

        public Form8()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            cargarProductos();
        }


        #region metodos

        private void cargarProductos()
        {
            precioProductos = new double[8];
            double sumaPrecios = 0;
            for (int i = 0; i < precioProductos.Length; i++)
            {
                bool conversionHecha = double.TryParse(Interaction.InputBox("Ingresa el precio del producto " + (i + 1) + ":"), out double precioProducto);
                while (!conversionHecha)
                {
                    MessageBox.Show("Debes ingresar el precio del producto en números.");
                    conversionHecha = double.TryParse(Interaction.InputBox("Ingresa el precio del producto " + (i + 1) + ":"), out precioProducto);
                }
                precioProductos[i] = precioProducto;
                sumaPrecios += precioProducto;
            }
            MessageBox.Show("La suma de todos los precios da un total de $" + sumaPrecios + ".");
        }

        #endregion
    }
}
