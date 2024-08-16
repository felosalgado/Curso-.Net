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

            var nombresOrdenadosLambda = nombres.OrderBy(n => n.Length);

            Console.WriteLine("Lista Ordenada (Lambda Syntax):");

            foreach (var nombre in nombresOrdenadosLambda)
            {
                Console.WriteLine(nombre);
            }


        }

        public void LambdaConsultaNombre()
        {
            List<Persona> personas = new List<Persona>
            {
                new Persona { Nombre = "Ana", edad=23 },
                new Persona {Nombre = "Juan", edad=30 },
                new Persona { Nombre= "Pedro",edad=21 }
            };

            var nombresPersonasLambda = personas.Select(p => p.Nombre);

            Console.WriteLine("Nombres de personas (Lambda Syntax):");
            foreach (var nombre in nombresPersonasLambda)
            {
                Console.WriteLine(nombre);
            }


        }
    }
}
