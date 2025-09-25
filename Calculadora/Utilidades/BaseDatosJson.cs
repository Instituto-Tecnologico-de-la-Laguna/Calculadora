using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Utilidades
{
    public class BaseDatosJson
    {
        public List<Persona> Personas {  get; set; }
        public DateTime ultimaActualizacion;
        public int TotalRegistros { get; set; } 
        public BaseDatosJson() { 
            Personas = new List<Persona>();
            ultimaActualizacion = DateTime.Now;
        }
    }
}
