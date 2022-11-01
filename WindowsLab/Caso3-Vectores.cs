using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsLab
{
    public partial class Form9 : Form
    {

        string[] operarios;
        double[,] sueldos;

        public Form9()
        {
            InitializeComponent();
        }

        private void btnCargarSueldos_Click(object sender, EventArgs e)
        {
            operarios = new string[4];
            sueldos = new double[4, 3];
            // Bucle para cargar los operarios
            for (int i = 0; i < operarios.Length; i++)
            {
                string nombreIngresado = Interaction.InputBox("Ingresa el nombre del operario " + (i + 1) + ":");
                while (nombreIngresado.Length <= 0)
                {
                    MessageBox.Show("Tenés que ingresar un nombre.");
                    nombreIngresado = Interaction.InputBox("Ingresa el nombre del operario " + (i + 1) + ":");
                }
                operarios[i] = nombreIngresado;

                // Bucle para cargar los ingresos de cada operario
                for (int j= 0; j < sueldos.GetLength(1); j++)
                {
                    bool sueldoConvertido = double.TryParse(Interaction.InputBox("Ingresa el sueldo " + (j + 1) + " del operario " + (i + 1) + ":"), out double sueldoIngresado);
                    while (!sueldoConvertido)
                    {
                        MessageBox.Show("Tenés que ingresar un sueldo.");
                        sueldoConvertido = double.TryParse(Interaction.InputBox("Ingresa el sueldo " + (j + 1) + " del operario " + (i + 1) + ":"), out sueldoIngresado);
                    }
                    sueldos[i,j] = sueldoIngresado;
                    
                }
            }

            double totalPagado = 0;
            double sueldoMaximo = 0;
            string operarioSueldoMaximo = "";
            for (int i = 0; i < sueldos.GetLength(0); i++)
            {
                for (int j = 0; j < sueldos.GetLength(1); j++)
                {
                    if (sueldos[i,j] > sueldoMaximo)
                    {
                        sueldoMaximo = sueldos[i, j];
                        operarioSueldoMaximo = operarios[i];
                    }
                    totalPagado += sueldos[i, j];
                }
            }

            MessageBox.Show("El total de sueldos pagado a todos los operarios da una suma de $" + totalPagado);
            MessageBox.Show("El operario que cobró el mayor sueldo fue " + operarioSueldoMaximo + " con un monto de $" + sueldoMaximo);
        }
    }
}
