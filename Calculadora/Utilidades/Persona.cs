using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Utilidades
{
    public class Persona
    {
        public string nombre { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public Persona() { }
        public Persona(string nombre, string telefono, string correo)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.correo = correo;
        }
    }
}
