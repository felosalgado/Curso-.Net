using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        public void QuerySintaxOrderList()
        {
            string[] nombres = { "Ana", "Pedro", "Maria" };

            var orderName = from n in nombres
                            orderby n.Length
                            select n;


            Console.WriteLine("Nombres ordenados");
            foreach (var nombre in orderName) { 
               Console.WriteLine($"El nombre es {nombre}");
            
            }
        }

        public void QuerySintaxConsultaNombres() {


            List<Person> personas = new List<Person>
            {
                new Person { Name = "Ana", Age =23 },
                new Person { Name = "Juan", Age=30 },
                new Person { Name = "Pedro",Age=21 }
            };

            var personName = from p in personas
                                select p.Name;

            Console.WriteLine("Nombres de personas (Query Syntax):");
            foreach (var name in personName)
            {
                Console.WriteLine(name);
            }
        }

        public void QuerySintaxConsultaNombresParametro(string name)
        {

            var people = new List<Person>
            {
                new Person { Name = "Ana", Age = 23 },
                new Person { Name = "Juan", Age = 30 },
                new Person { Name= "Pedro",Age = 21 }
            };

            var personName = (from p in people
                              where p.Name == name
                              select p).Any();
                             
                          

            Console.WriteLine("Existe nombre enviado:");
            Console.WriteLine(personName);
        }
    }
}
