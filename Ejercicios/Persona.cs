using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Persona
    {
        public string? Nombre { get; set; }
        public int Edad { get; set; }

        public List<Persona> GetPersonas()
        {
            var list = new List<Persona>()
            {
                new Persona{Nombre="Ana",Edad=20 },
                new Persona{Nombre="Juan",Edad=19 },
                new Persona{Nombre="Pedro",Edad=18 },
                new Persona{Nombre="Maria",Edad= 30},
                 new Persona{Nombre=null,Edad= 30},
            };




            return list;
        }
    }
}
