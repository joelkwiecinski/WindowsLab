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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = Interaction.InputBox("Ingresa tu nombre de usuario: ", "Carga de datos");
            while (nombreUsuario.Length <= 0)
            {
                MessageBox.Show("El dato ingresado no es correcto.");
                nombreUsuario = Interaction.InputBox("Ingresa tu nombre de usuario: ", "Carga de datos");
            }
            string sexoUsuario = Interaction.InputBox("Ingresa tu sexo (opciones masculino, femenino, prefiero no decirlo): ", "Carga de datos");
            while (sexoUsuario.Length <= 0)
            {
                MessageBox.Show("El dato ingresado no es correcto.");
                sexoUsuario = Interaction.InputBox("Ingresa tu sexo (opciones masculino, femenino, prefiero no decirlo): ", "Carga de datos");
            }
            string rolUsuario = Interaction.InputBox("Ingresa tu rol de usuario (Administrador, estándar o invitado): ", "Carga de datos");
            while (rolUsuario.Length <= 0)
            {
                MessageBox.Show("El dato ingresado no es correcto.");
                rolUsuario = Interaction.InputBox("Ingresa tu rol de usuario (Administrador, estándar o invitado): ", "Carga de datos");
            }
            VerifyUser(nombreUsuario, sexoUsuario, rolUsuario);
        }

        private void VerifyUser(string usuario, string sexo, string rol)
        {
            // Validamos rol
            if (rol.ToUpper() != "ADMINISTRADOR" && rol.ToUpper() != "ESTANDAR" && rol.ToUpper() != "INVITADO" && rol.ToUpper() != "ESTÁNDAR")
            {
                // Rol incorrecto
                MessageBox.Show("El rol ingresado no es correcto.");
            }
            else
            {
                if (sexo.ToUpper() != "FEMENINO" && sexo.ToUpper() != "MASCULINO" && sexo.ToUpper() != "NO DEFINIDO")
                {
                    // Sexo incorrecto
                    MessageBox.Show("El sexo ingresado es incorrecto.");
                }
                else
                {
                    lblUsuario.Text = "Usuario: " + usuario;
                    lblRol.Text = "Rol: " + rol;
                    lblSexo.Text = "Sexo: " + sexo;
                }
            }
        }
    }
}
