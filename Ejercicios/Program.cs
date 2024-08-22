using Ejercicios.Lambda;
using Ejercicios.Linq;

Linq linq = new Linq();
//linq.QuerySintaxNumerosPares();
//linq.QuerySintaxOrdenLista();
//linq.QuerySintaxConsultaNombre();


Lambda lambda = new Lambda();
//lambda.LambdaNumerosPares();
//lambda.LambdaOrdenaLista();
//lambda.LambdaObtenerNombre();

Console.Write("Nombre a buscar: ");
string nombre = Console.ReadLine();
if (string.IsNullOrEmpty(nombre))
{
    Console.WriteLine("Debe ingresar un Nombre!");
    return;
}
else
{
    linq.QuerySintaxConsultaporNombre(nombre);
    Console.WriteLine("----------------------------------");
    lambda.LambdaBuscarporNombre(nombre);
}