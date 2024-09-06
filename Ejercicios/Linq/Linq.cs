using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Linq
{
    public class Linq
    {
        public void QuerySintaxNumerosPares()
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var numerosPares = from n in numeros
                               where n % 2 == 0
                               select n;
            Console.WriteLine("Números pares (Query Syntax):");
            foreach (var numero in numerosPares)
            {
                Console.WriteLine(numero);
            }
        }
        public void QuerySintaxOrdenaLista()
        {
            string[] nombres = { "Ana", "Juan", "Pedro", "María" };
            var nombresOrdenados = from n in nombres
                                   orderby n.Length
                                   select n;
            Console.WriteLine("Nombres ordenados por longitud");
            foreach (var nombre in nombresOrdenados)
            {
                Console.WriteLine($"el nombre es: {nombre}");
            }
        }

        public void QuerySintaxConsultaNombre()
        {
            List<Persona> personas = new List<Persona>
            {
                new Persona {Nombre ="Noah",edad=9},
                new Persona{Nombre="Juan", edad=25},
                new Persona{Nombre="Pedro", edad=30}
            };

            var nombrePersona = from person in personas
                                select person.Nombre;

            foreach (var persona in nombrePersona)
            {
                Console.WriteLine($"los nombres son: {persona}");
            }
        }

        public void QuerySintaxConsultaNombreParametro(string Criterio)
        {
            List<Persona> personas = new List<Persona>
            {
                new Persona {Nombre ="Noah",edad=9},
                new Persona{Nombre="Juan", edad=25},
                new Persona{Nombre="Pedro", edad=30}
            };

            var nombrePersona = from person in personas
                                where person.Nombre == Criterio
                                select new { person.Nombre };


            if (nombrePersona.Any())
            {
                Console.WriteLine($"El nombre {Criterio} si existe ");
            }
            else
            {
                Console.WriteLine($"El nombre {Criterio} no existe ");
            }
        }
    }
}
