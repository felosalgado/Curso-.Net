using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Ejercicios.Linq
//{
//    public class Linq
//    {
//        public void QuerySintaxNumerosPares()
//        {
//            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//            var numerosPares = from n in numeros
//                               where n % 2 == 0
//                               select n;
//            Console.WriteLine("Números pares (Query Syntax):");
//            foreach (var numero in numerosPares)
//            {
//                Console.WriteLine(numero);
//            }
//        }


//<<<<<<< HEAD

//        public void QuerySintaxOrdenLista()
//        {
//            string[] nombres = { "Ana", "Juan", "Pedro", "Maria" };
//            var nombresOrdenados = from n in nombres
//                                   orderby n.Length
//                                   select n;

//            Console.WriteLine("Ordenar Nombres QuerySintaxOrdenLista:");

//            foreach (var nombre in nombresOrdenados)
//            {
//                Console.WriteLine($"El nombre es: {nombre}");
//            }
//        }

//=======
//        public void QuerySintaxOrdenaLista()
//        {
//            string[] nombres = { "Ana", "Juan", "Pedro", "María" };

//            var nombresOrdenados = from n in nombres
//                                   orderby n.Length
//                                   select n;
//            Console.WriteLine("Nombres ordenados por longitud");

//            foreach (var nombre in nombresOrdenados)
//            {
//                Console.WriteLine($"el nombre es: {nombre}");
//            }

//        }
//>>>>>>> 1cf695bf6a55fe41dc29267289ceb3abf9873826

//        public void QuerySintaxConsultaNombre()
//        {
//            List<Persona> personas = new List<Persona>
//            {
//<<<<<<< HEAD
//                new Persona { Nombre = "Ana", edad = 23 },
//                new Persona { Nombre = "Juan", edad = 30 },
//                new Persona { Nombre = "Pedro", edad = 21 }
//=======
//                new Persona { Nombre = "Ana", edad=23 },
//                new Persona {Nombre = "Juan", edad=30 },
//                new Persona { Nombre= "Pedro",edad=21 }
//>>>>>>> 1cf695bf6a55fe41dc29267289ceb3abf9873826
//            };

//            var nombrePersona = from p in personas
//                                select p.Nombre;

//<<<<<<< HEAD
//            Console.WriteLine("Ordenar Nombres QuerySintaxConsultaNombre:");

//            foreach (var nombre in nombrePersona)
//            {
//                Console.WriteLine($"El nombre es: {nombre}");
//            }

//        }



//        public void QuerySintaxConsultaporNombre(string nombre)
//        {

//            List<Persona> personas = new List<Persona>
//            {
//                new Persona { Nombre = "Ana", edad = 23 },
//                new Persona { Nombre = "Juan", edad = 30 },
//                null,
//                new Persona { Nombre = "Pedro", edad = 21 }
//            };

//            var buscaPersona = from p in personas
//                               where p != null && p.Nombre == nombre
//                               select (p.Nombre, p.edad);

//            Console.WriteLine("Buscar por Nombre QuerySintaxConsultaporNombre:");

//            if (!buscaPersona.Any())
//            {
//                Console.WriteLine($"La persona: {nombre} no existe");
//            }
//            else
//            {
//                foreach (var registro in buscaPersona)
//                {
//                    Console.WriteLine($"La persona: {registro.Nombre} existe y tiene {registro.edad} años");
//                }
//            }
//=======
//            Console.WriteLine("Nombres de personas (Query Syntax):");
//            foreach (var nombre in nombrePersona)
//            {
//                Console.WriteLine(nombre);
//            }


//>>>>>>> 1cf695bf6a55fe41dc29267289ceb3abf9873826

//        }

//    }
//}
