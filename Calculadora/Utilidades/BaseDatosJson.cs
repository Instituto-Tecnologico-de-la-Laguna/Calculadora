using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Utilidades
{
    public class BaseDatosJson
    {
        public List <Persona> Personas {  get; set; }
        public DateTime UltimaActualizacion { get; set; }

        public BaseDatosJson() 
        {
            Personas = new List<Persona>();
            UltimaActualizacion = DateTime.Now;
        }
    }
}
