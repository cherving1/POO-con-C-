using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaEntidad
{
    public class alumno : Persona
    {
        private string codigo;
        private string telefono;

        public string Codigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }
        public string Telefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }
        public string DeveloperDatosAlumno()
        {
            return "codigo :" + this.codigo + "Apellidos: " + this.Apellidos + "Nombres: " +
            this.Nombres + "edad:  " + Convert.ToString(this.Edad) + "Telefono: " + this.telefono;
        }
    }
}