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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (rdBtnRectangulo.Checked)
            {
                // Seleccionamos rectángulo
                CalcularArea("rectangulo");
            }
            else if (rdBtnCirculo.Checked)
            {
                // Seleccionamos círculo
                CalcularArea("circulo");
            }
            else if (rdBtnTrapecio.Checked)
            {
                // Seleccionamos trapecio
                CalcularArea("trapecio");
            } else
            {
                // El usuario logró romper la interfaz
                MessageBox.Show("Hubo un error.");
            }
        }

        private void CalcularArea(string forma)
        {
            switch (forma)
            {
                case "rectangulo":
                    bool baseConvertida = double.TryParse(Interaction.InputBox("Ingresa el ancho de la base: ", "Carga de datos"), out double baseRectangulo);
                    while (!baseConvertida)
                    {
                        MessageBox.Show("Hubo un error con el número ingresado, intenta nuevamente.");
                        baseConvertida = double.TryParse(Interaction.InputBox("Ingresa el ancho de la base: ", "Carga de datos"), out baseRectangulo);
                    }
                    bool altoConvertido = double.TryParse(Interaction.InputBox("Ingresa el alto del rectángulo: ", "Carga de datos"), out double altoRectangulo);
                    while (!altoConvertido)
                    {
                        MessageBox.Show("Hubo un error con el número ingresado, intenta nuevamente.");
                        altoConvertido = double.TryParse(Interaction.InputBox("Ingresa el alto del rectángulo: ", "Carga de datos"), out altoRectangulo);
                    }
                    // Tenemos los datos
                    double areaRectangulo = baseRectangulo * altoRectangulo;
                    MessageBox.Show("El área del rectángulo es: " + areaRectangulo);
                    break;
                case "circulo":
                    bool diametroConvertido = double.TryParse(Interaction.InputBox("Ingresa el diámetro del círculo: ", "Carga de datos"), out double diametroCirculo);
                    while (!diametroConvertido)
                    {
                        MessageBox.Show("Hubo un error con el número ingresado, intenta nuevamente.");
                        diametroConvertido = double.TryParse(Interaction.InputBox("Ingresa el diámetro del círculo ", "Carga de datos"), out diametroCirculo);
                    }
                    // Tenemos el diámetro
                    double areaCirculo = Math.Pow((diametroCirculo / 2), 2) * 3.14159265359;
                    MessageBox.Show("El área del círculo es: " + areaCirculo);
                    break;
                case "trapecio":
                    bool anchoInfConvertido = double.TryParse(Interaction.InputBox("Ingresa el ancho de la base inferior: ", "Carga de datos"), out double anchoInfTrapecio);
                    while (!anchoInfConvertido)
                    {
                        MessageBox.Show("Hubo un error con el número ingresado, intenta nuevamente.");
                        anchoInfConvertido = double.TryParse(Interaction.InputBox("Ingresa el ancho de la base inferior: ", "Carga de datos"), out anchoInfTrapecio);
                    }
                    bool anchoSupConvertido = double.TryParse(Interaction.InputBox("Ingresa el ancho de la base superior: ", "Carga de datos"), out double anchoSupTrapecio);
                    while (!anchoSupConvertido)
                    {
                        MessageBox.Show("Hubo un error con el número ingresado, intenta nuevamente.");
                        anchoSupConvertido = double.TryParse(Interaction.InputBox("Ingresa el ancho de la base superior: ", "Carga de datos"), out anchoSupTrapecio);
                    }
                    bool alturaConvertida = double.TryParse(Interaction.InputBox("Ingresa la altura del trapecio: ", "Carga de datos"), out double altoTrapecio);
                    while (!alturaConvertida)
                    {
                        MessageBox.Show("Hubo un error con el número ingresado, intenta nuevamente.");
                        alturaConvertida = double.TryParse(Interaction.InputBox("Ingresa la altura del trapecio: ", "Carga de datos"), out altoTrapecio);
                    }
                    // Tenemos los datos
                    double areaTrapecio = ((anchoInfTrapecio + anchoSupTrapecio) * altoTrapecio) / 2;
                    MessageBox.Show("El área del trapecio es: " + areaTrapecio);
                    break;
            }
        }
    }
}
