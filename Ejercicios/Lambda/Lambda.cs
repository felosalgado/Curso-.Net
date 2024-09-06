using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Lambda
{
    public class Lambda
    {
        public void LambdaNumerosPares()
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var numerosParesLambda = numeros.Where(n => n % 2 == 0);
            Console.WriteLine("Números pares (Lambda Syntax):");
            foreach (var numero in numerosParesLambda)
            {
                Console.WriteLine(numero);
            }
        }
        public void LambdaOrdenaLista()
        {
            string[] nombres = { "Ana", "Juan", "Pedro", "María" };

            var nombresOrdena = nombres.OrderBy(x => x.Length);
            Console.WriteLine("Nombres ordenados por longitud");
            foreach (var nombre in nombresOrdena)
            {
                Console.WriteLine($"el nombre es: {nombre}");
            }

        }

        public void LambdaObtenerNombre()
        {
            List<Persona> personas = new List<Persona>
            {
                new Persona {Nombre ="Noah",edad=9},
                new Persona{Nombre="Juan", edad=25},
                new Persona{Nombre="Pedro", edad=30}
            };

            foreach (var persona in personas.ToList())
            {
                Console.WriteLine($"los nombres son: {persona.Nombre}");
            }
        }

        public void UtilizarNulls(string? Criterio)
        {
            List<Persona> personas = new List<Persona>
            {
                new Persona {Nombre ="Noah",edad=9},
                new Persona{Nombre="Juan", edad=25},
                new Persona{Nombre="Pedro", edad=30}
            };
            var utilizarNull = personas.Where(x => Criterio == null || x.Nombre.Equals(Criterio)).Select(x => x.Nombre).ToList();

            foreach (var persona in utilizarNull)
            {
                Console.WriteLine($"Se aplica en lambda la validacion de null");
            }
        }
    }
}
