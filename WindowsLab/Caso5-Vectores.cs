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
    public partial class Caso5_Vectores : Form
    {

        string[] provincias;
        double[,] temperaturas;

        public Caso5_Vectores()
        {
            InitializeComponent();
        }

        private void btnIngresarTemperaturas_Click(object sender, EventArgs e)
        {
            provincias = new string[4];
            temperaturas = new double[4, 3];

            string mensajeFinal = "";
            double tempMedia = 0;
            string provinciaMayorTemp = "";
            
            for (int i = 0; i < provincias.Length; i++)
            {
                string nombreProvincia = Interaction.InputBox("Ingresa el nombre de la provincia " + (i + 1) + ":");
                while (nombreProvincia.Length <= 0)
                {
                    MessageBox.Show("Tenés que ingresar una provincia.");
                    nombreProvincia = Interaction.InputBox("Ingresa el nombre de la provincia " + (i + 1) + ":");
                }
                provincias[i] = nombreProvincia;

                mensajeFinal += nombreProvincia + "\n";


                double sumaTemps = 0;
                for (int j = 0; j < temperaturas.GetLength(1); j++)
                {
                    bool valorConvertido = double.TryParse(Interaction.InputBox("Ingresa la temperatura media de " + provincias[i] + " en el mes " + (j+1) + ":"), out double temperaturaIngresada);
                    while (!valorConvertido)
                    {
                        MessageBox.Show("Tenés que ingresar una temperatura en números.");
                        valorConvertido = double.TryParse(Interaction.InputBox("Ingresa la temperatura media de " + provincias[i] + " en el mes " + (j + 1) + ":"), out temperaturaIngresada);
                    }
                    temperaturas[i, j] = temperaturaIngresada;

                    sumaTemps += temperaturaIngresada;
                    mensajeFinal += "Temperatura " + (j + 1) + ": " + temperaturaIngresada + "\n";
                }

                if ((sumaTemps / 3) > tempMedia)
                {
                    provinciaMayorTemp = provincias[i];
                    tempMedia = sumaTemps / 3;
                }
                tempMedia = sumaTemps / 3;
                mensajeFinal += "Temperatura trimestral promedio: " + tempMedia + "\n\n";
            }

            mensajeFinal += "Provincia con mayor temperatura media: " + provinciaMayorTemp;

            MessageBox.Show(mensajeFinal);
        }
    }
}
