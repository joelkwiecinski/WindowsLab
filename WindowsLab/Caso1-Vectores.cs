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
    public partial class Form7 : Form
    {

        string[] alumnos;
        double[,] notasAlumnos;
        double[] promedios;
        double[] mayorNota;

        public Form7()
        {
            InitializeComponent();
        }

        private void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            GenerarInforme();
        }



        #region metodos

        private void GenerarInforme()
        {
            alumnos = new string[4];
            notasAlumnos = new double[4, 3];
            promedios = new double[4];
            mayorNota = new double[4];

            SolicitarAlumnos();
            SolicitarNotas();
            GenerarPromedios();
            InformarCondicion();
        }

        private void SolicitarAlumnos()
        {
            for (int i = 0; i < alumnos.Length; i++)
            {
                alumnos[i] = Interaction.InputBox("Ingrese el nombre del alumno " + (i + 1));
                while (alumnos[i].Length == 0)
                {
                    MessageBox.Show("Debe ingresar un nombre");
                    alumnos[i] = Interaction.InputBox("Ingrese el nombre del alumno " + (i + 1));
                }
            }
        }

        private void SolicitarNotas()
        {
            for (int i = 0; i < alumnos.Length; i++)
            {
                for (int j = 0; j < notasAlumnos.GetLength(1); j++)
                {
                    bool convertido = double.TryParse(Interaction.InputBox("Ingrese la nota de " + alumnos[i] + " en la MATERIA " + (j + 1)), out double notaIngresada);
                    while (!convertido)
                    {
                        MessageBox.Show("Debes ingresar una nota");
                        convertido = double.TryParse(Interaction.InputBox("Ingrese la nota de " + alumnos[i] + " en la MATERIA " + (j + 1)), out notaIngresada);
                    }
                    notasAlumnos[i, j] = notaIngresada;
                }
            }
        }

        private void GenerarPromedios()
        {
            for (int i = 0; i < alumnos.Length; i++)
            {
                double sumaTotal = 0;
                for (int j = 0; j < notasAlumnos.GetLength(1); j++)
                {
                    sumaTotal += notasAlumnos[i, j];
                }
                MessageBox.Show("El promedio de notas de " + alumnos[i] + " es " + (sumaTotal / notasAlumnos.GetLength(1)));
            }
        }

        private void InformarCondicion()
        {
            for (int i = 0; i < alumnos.Length; i++)
            {
                string mensajeParaMostrar = "";
                for (int j = 0; j < notasAlumnos.GetLength(1); j++)
                {
                    if (mensajeParaMostrar == "")
                    {
                        mensajeParaMostrar = alumnos[i] + " en la MATERIA " + (j + 1) + " sacó un " + notasAlumnos[i, j];
                    }
                    else
                    {
                        mensajeParaMostrar += "\n" + alumnos[i] + " en la MATERIA " + (j + 1) + " sacó un " + notasAlumnos[i, j];
                    }

                    if (notasAlumnos[i, j] < 4)
                    {
                        mensajeParaMostrar += ", debe ir a recuperatorio.";
                    }
                    else if (notasAlumnos[i, j] > 4 && notasAlumnos[i, j] <= 7)
                    {
                        mensajeParaMostrar += ", bien.";
                    }
                    else if (notasAlumnos[i, j] > 7)
                    {
                        mensajeParaMostrar += ", muy bien.";
                    }
                }
                MessageBox.Show(mensajeParaMostrar);
            }
        }

        #endregion
    }
}
