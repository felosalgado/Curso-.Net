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
        
    }
}
