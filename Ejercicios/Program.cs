using Ejercicios.Lambda;
using Ejercicios.Linq;
using Ejercicios.Asincrona;
using Ejercicios.DelegadosEventos;

Linq linq = new Linq();
linq.QuerySintaxNumerosPares();
linq.QuerySintaxOrdenaLista();
linq.QuerySintaxConsultaNombre();
linq.QuerySintaxConsultaNombreParametro("Pedro");

//Lambda lambda = new Lambda();
//lambda.LambdaNumerosPares();
//lambda.LambdaOrdenaLista();
//lambda.LambdaConsultaNombre();

Lambda lambda = new Lambda();
lambda.LambdaNumerosPares();
lambda.LambdaOrdenaLista();
lambda.LambdaObtenerNombre();
lambda.UtilizarNulls(null);
