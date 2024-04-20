using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static Persona persona= new Persona();
        private void tabPage1_Click(object sender, EventArgs e)
        {
          
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //asignar variables a los aatributos de la clase Persona
            persona.Apellidos = txtApellidos.Text;
            persona.Nombres = txtNombres.Text;
            persona.Edad = Convert.ToInt32(txtEdad.Text);
            MessageBox.Show("se registro correcamente el objeto persona");
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            MessageBox.Show(persona.DevolverDatos());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
