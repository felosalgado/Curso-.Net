using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        public void LambdaOrdearLista() 
        {
            string[] nombres = { "Ana", "Juan", "Pedro", "Maria" };
            var nombresOrdenados=nombres.OrderBy(n => n.Length).ToList();

            Console.WriteLine("Números pares (Lambda Syntax):");
            foreach (var nombre in nombresOrdenados)
            {
                Console.WriteLine(nombre);
            }

        }
        public void LambdaConsultaNombre()
        {
            string[] nombres = { "Ana", "Juan", "Pedro", "Maria" };
            var nombresOrdenados = nombres.OrderBy(n => n.Length).ToList();

            Console.WriteLine("Números pares (Lambda Syntax):");
            foreach (var nombre in nombresOrdenados)
            {
                Console.WriteLine(nombre);
            }

        }

        public void LambdaObtenerNombres()
        {
            var persona = new Persona();
            var personas = persona.GetPersonas();
            Console.WriteLine("NOmbres personas (Lambda Syntax):");
            personas.ForEach(c =>
            {
                Console.WriteLine(c.Nombre);
            });
        }

        public void LambdaExisteNombre(string? nombre)
        {
            var persona = new Persona();
            var personas = persona.GetPersonas();

            if (personas == null || !personas.Any())
            {
                Console.WriteLine("La lista de personas está vacía o es null.");
                return;
            }           
            string nombreBuscar = nombre ?? string.Empty;

            
            bool existe = personas.Any(p =>
                string.Equals(p.Nombre ?? string.Empty, nombreBuscar, StringComparison.OrdinalIgnoreCase));

            if (existe)
            {
                Console.WriteLine($"El nombre '{nombreBuscar}' existe en la lista.");
            }
            else
            {
                Console.WriteLine($"El nombre '{nombreBuscar}' no existe en la lista.");
            }
        }
    }
}
