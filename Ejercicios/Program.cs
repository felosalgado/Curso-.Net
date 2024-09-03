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
//Console.WriteLine("Iniciando solicitud...");

//Asincrona async = new Asincrona();
// Llamada asíncrona a un método que realiza una solicitud HTTP
//string content = await async.GetWebContentAsync("https://www.example.com");
//Console.WriteLine("Contenido recibido:");
//Console.WriteLine(content);

// Crear un sensor de temperatura con un umbral de 30 grados
TemperaturaSensor sensor = new TemperaturaSensor(30.0);
// Crear un sistema de alerta
TemperaturaAlerta alert = new TemperaturaAlerta();
// Suscribirse al evento
sensor.TemperaturaExcedida += alert.OnTemperatureExceeded;
// Simular mediciones de temperatura
double[] temperatures = { 25.0, 28.0, 31.5, 29.0, 33.0 };
foreach (var temp in temperatures)
{
    sensor.VerificarTemperatura(temp);
}