using Ejercicios.Lambda;
using Ejercicios.Linq;

Linq linq = new Linq();
linq.QuerySintaxNumerosPares();

Lambda lambda = new Lambda();
lambda.LambdaNumerosPares();
lambda.LambdaOrdearLista();
lambda.LambdaObtenerNombres();

lambda.LambdaExisteNombre("AnA");
lambda.LambdaExisteNombre(null);
lambda.LambdaExisteNombre(string.Empty);

await Task.Delay(-1);