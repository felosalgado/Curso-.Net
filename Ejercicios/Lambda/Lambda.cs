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
    }
}
