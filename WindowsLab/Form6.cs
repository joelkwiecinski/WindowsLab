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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtApellido.Text != "")
            {
                imprimir(txtNombre.Text, txtApellido.Text);
                imprimir(txtNombre.Text, txtApellido.Text, dateFechaNacimiento.Value);
            }
            else
            {
                MessageBox.Show("Faltan datos.");
            }
        }

        private void imprimir(string nombre, string apellido)
        {
            MessageBox.Show("Bienvenido, " + nombre + " " + apellido + ".");
        }

        private void imprimir(string nombre, string apellido, DateTime fechaNacimiento)
        {
            int anoNacimiento = fechaNacimiento.Year;
            int diaNacimiento = fechaNacimiento.DayOfYear;

            if (diaNacimiento < DateTime.Today.DayOfYear)
            {
                int edad = DateTime.Today.Year - anoNacimiento;
                // Ya cumplió años
                MessageBox.Show(nombre + " " + apellido + " tiene " + edad + " años.");
            }
            else
            {
                int edad = (DateTime.Today.Year - 1) - anoNacimiento;
                // Todavía no cumple años
                MessageBox.Show(nombre + " " + apellido + " tiene " + edad + " años.");
            }
        }
    }
}
