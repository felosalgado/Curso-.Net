using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Ejercicios.Lambda
//{
//    public class Lambda
//    {
//        public void LambdaNumerosPares()
//        {
//            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//            var numerosParesLambda = numeros.Where(n => n % 2 == 0);
//            Console.WriteLine("Números pares (Lambda Syntax):");
//            foreach (var numero in numerosParesLambda)
//            {
//                Console.WriteLine(numero);
//            }
//        }


//<<<<<<< HEAD

//        public void LambdaOrdenaLista()
//        {
//            string[] nombres = { "Ana", "Juan", "Pedro", "Maria" };
//            var nombresOrdenadosLambda = nombres.OrderBy(n => n.Length);
//            Console.WriteLine("Lista Ordenada Lambda syntax");
//=======
//        public void LambdaOrdenaLista() 
//        {
//            string[] nombres = { "Ana", "Juan", "Pedro", "María" };

//            var nombresOrdenadosLambda = nombres.OrderBy(n => n.Length);

//            Console.WriteLine("Lista Ordenada (Lambda Syntax):");
//>>>>>>> 1cf695bf6a55fe41dc29267289ceb3abf9873826

//            foreach (var nombre in nombresOrdenadosLambda)
//            {
//                Console.WriteLine(nombre);
//            }
//<<<<<<< HEAD
//        }



//        public void LambdaObtenerNombre()
//        {
//            List<Persona> personas = new List<Persona>
//            {
//                new Persona { Nombre = "Ana", edad = 23 },
//                new Persona { Nombre = "Juan", edad = 30 },
//                new Persona { Nombre = "Pedro", edad = 21 }
//            };

//            var nombrePersona = personas.Select(p => p.Nombre);

//            foreach (var nombre in nombrePersona)
//            {
//                Console.WriteLine($"El nombre es: {nombre}");
//            }

//        }


//        public void LambdaBuscarporNombre(string nombre)
//        {

//            List<Persona> personas = new List<Persona>
//            {
//                new Persona { Nombre = "Ana", edad = 23 },
//                new Persona { Nombre = "Juan", edad = 30 },
//                null,
//                new Persona { Nombre = "Pedro", edad = 21 }
//            };

//            var buscaPersona = personas.Where(p => p != null && p.Nombre.Equals(nombre));

//            Console.WriteLine("Buscar por Nombre LambdaBuscarporNombre:");

//            if (!buscaPersona.Any())
//            {
//                Console.WriteLine($"La persona {nombre} no existe");
//            }
//            else
//            {
//                foreach (var registro in buscaPersona)
//                {
//                    Console.WriteLine($"La persona: {registro.Nombre} existe y tiene {registro.edad} años");
//                }
//            }

//=======


//        }

//        public void LambdaConsultaNombre()
//        {
//            List<Persona> personas = new List<Persona>
//            {
//                new Persona { Nombre = "Ana", edad=23 },
//                new Persona {Nombre = "Juan", edad=30 },
//                new Persona { Nombre= "Pedro",edad=21 }
//            };

//            var nombresPersonasLambda = personas.Select(p => p.Nombre);

//            Console.WriteLine("Nombres de personas (Lambda Syntax):");
//            foreach (var nombre in nombresPersonasLambda)
//            {
//                Console.WriteLine(nombre);
//            }


//>>>>>>> 1cf695bf6a55fe41dc29267289ceb3abf9873826
//        }

//    }

    

//}
