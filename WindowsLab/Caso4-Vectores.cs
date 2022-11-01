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
    public partial class Form10 : Form
    {

        string[,] personas;

        public Form10()
        {
            InitializeComponent();
        }

        private void btnCargarPersonas_Click(object sender, EventArgs e)
        {
            personas = new string[5, 2];
            string personasMayores = "";
            for (int i = 0; i < personas.GetLength(0); i++)
            {
                string nombrePersona = Interaction.InputBox("Ingresa el nombre de la persona " + (i + 1) + ":");
                while (nombrePersona.Length <= 0)
                {
                    MessageBox.Show("Tenés que ingresar un nombre.");
                    nombrePersona = Interaction.InputBox("Ingresa el nombre de la persona " + (i + 1) + ":");
                }
                string edadPersona = Interaction.InputBox("Ingresa la edad de " + nombrePersona + ":");
                while (edadPersona.Length <= 0)
                {
                    MessageBox.Show("Tenés que ingresar una edad.");
                    edadPersona = Interaction.InputBox("Ingresa la edad de " + nombrePersona + ":");
                }
                personas[i, 0] = nombrePersona;
                personas[i, 1] = edadPersona;

                // Verificamos si es mayor
                if (Convert.ToDouble(edadPersona) >= 18)
                {
                    if (personasMayores == "")
                    {
                        personasMayores = nombrePersona;
                    } else
                    {
                        personasMayores += ", " + nombrePersona;
                    }
                }
            }

            MessageBox.Show("Mayores de edad:\n" + personasMayores);
        }
    }
}
