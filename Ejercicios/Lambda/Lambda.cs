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

        public void LambdaOrderList() {
            string[] orderList = { "Ana", "Juan", "Tati" };

            var nombresOrder = orderList.OrderBy(n => n.Length);

            Console.WriteLine("Lista ordenada(Lambda Syntax):");
            foreach (var nombre in nombresOrder)
            {
                Console.WriteLine(nombre);
            }
        }


        public void LambdaConsultaNombre()
        {

            List<Person> personas = new List<Person>
            {
                new Person { Name = "Ana", Age = 23 },
                new Person { Name = "Juan", Age = 30 },
                new Person { Name= "Pedro",Age = 21 }
            };

            var nombresPersonasLambda = personas.Select(p => p.Name);

            Console.WriteLine("Nombres de personas (Lambda Syntax):");
            foreach (var nombre in nombresPersonasLambda)
            {
                Console.WriteLine(nombre);
            }
        }

        public void LambdaConsultaNombreParametro(string name)
        {

            var people = new List<Person>
            {
                new Person { Name = "Ana", Age = 23 },
                new Person { Name = "Juan", Age = 30 },
                new Person { Name= "Pedro",Age = 21 }
            };

            Console.WriteLine("Existe nombre enviado:");
            Console.WriteLine(people.Any(p => p.Name.Equals(name)));
        }


        //consulta nombres le pasamos un nombre para que obtenga el nombre, el metodo recibe un parametro y retorna si existe o no

        //como manejar los nulos con lamda 

        //usar consulta nombre con parametro string y retorne si existe o no el nombre 

    }
}
