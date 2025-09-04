using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Utilities
{
    public class BaseDatosJson
    {
        public List<Persona> personas { get; set; }
        public DateTime UltimaActualizacion { get; set; }
        public BaseDatosJson()
        {
            personas = new List<Persona>();
            UltimaActualizacion = DateTime.Now;
        }
    }
}
