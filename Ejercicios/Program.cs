using Ejercicios.Lambda;
using Ejercicios.Linq;

Linq linq = new Linq();
linq.QuerySintaxNumerosPares();
linq.QuerySintaxOrdenaLista();
linq.QuerySintaxConsultaNombre();
linq.QuerySintaxConsultaNombreParametro("Pedro");

Lambda lambda = new Lambda();
lambda.LambdaNumerosPares();
lambda.LambdaOrdenaLista();
lambda.LambdaObtenerNombre();
lambda.UtilizarNulls(null);