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
            string[] nombres = { "Ana", "Juan", "Pedro", "Maria" };
            var nombresOrdenadosLambda = nombres.OrderBy(n => n.Length);
            Console.WriteLine("Lista Ordenada Lambda syntax");

            foreach (var nombre in nombresOrdenadosLambda)
            {
                Console.WriteLine(nombre);
            }
        }



        public void LambdaObtenerNombre()
        {
            List<Persona> personas = new List<Persona>
            {
                new Persona { Nombre = "Ana", edad = 23 },
                new Persona { Nombre = "Juan", edad = 30 },
                new Persona { Nombre = "Pedro", edad = 21 }
            };

            var nombrePersona = personas.Select(p => p.Nombre);

            foreach (var nombre in nombrePersona)
            {
                Console.WriteLine($"El nombre es: {nombre}");
            }

        }


        public void LambdaBuscarporNombre(string nombre)
        {

            List<Persona> personas = new List<Persona>
            {
                new Persona { Nombre = "Ana", edad = 23 },
                new Persona { Nombre = "Juan", edad = 30 },
                null,
                new Persona { Nombre = "Pedro", edad = 21 }
            };

            var buscaPersona = personas.Where(p => p != null && p.Nombre.Equals(nombre));

            Console.WriteLine("Buscar por Nombre LambdaBuscarporNombre:");

            if (!buscaPersona.Any())
            {
                Console.WriteLine($"La persona {nombre} no existe");
            }
            else
            {
                foreach (var registro in buscaPersona)
                {
                    Console.WriteLine($"La persona: {registro.Nombre} existe y tiene {registro.edad} años");
                }
            }

        }

    }

    

}
