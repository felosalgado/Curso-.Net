<<<<<<< HEAD
﻿//using Ejercicios.Lambda;
//using Ejercicios.Linq;
//using Ejercicios.Asincrona;
//using Ejercicios.DelegadosEventos;
=======
﻿using Ejercicios.Lambda;
using Ejercicios.Linq;
using Ejercicios.Asincrona;
using Ejercicios.DelegadosEventos;
using Ejercicios.InyeccionDependencias;
using Ejercicios.InyeccionDependencias.ConInterfaces;
>>>>>>> 57958fbe4ee0eaac437b8b283fdf2c4b8ecf79e5

////Linq linq = new Linq();
////linq.QuerySintaxNumerosPares();
////linq.QuerySintaxOrdenaLista();
////linq.QuerySintaxConsultaNombre();

////Lambda lambda = new Lambda();
////lambda.LambdaNumerosPares();
////lambda.LambdaOrdenaLista();
////lambda.LambdaConsultaNombre();

////Console.WriteLine("Iniciando solicitud...");

////Asincrona async = new Asincrona();
//// Llamada asíncrona a un método que realiza una solicitud HTTP
////string content = await async.GetWebContentAsync("https://www.example.com");
////Console.WriteLine("Contenido recibido:");
////Console.WriteLine(content);

//// Crear un sensor de temperatura con un umbral de 30 grados
//TemperaturaSensor sensor = new TemperaturaSensor(30.0);
//// Crear un sistema de alerta
//TemperaturaAlerta alert = new TemperaturaAlerta();
//// Suscribirse al evento
//sensor.TemperaturaExcedida += alert.OnTemperatureExceeded;
//// Simular mediciones de temperatura
//double[] temperatures = { 25.0, 28.0, 31.5, 29.0, 33.0 };
//foreach (var temp in temperatures)
//{
//    sensor.VerificarTemperatura(temp);
//}

//<<<<<<< HEAD
//Linq linq = new Linq();
////linq.QuerySintaxNumerosPares();
////linq.QuerySintaxOrdenLista();
////linq.QuerySintaxConsultaNombre();


//Lambda lambda = new Lambda();
<<<<<<< HEAD
////lambda.LambdaNumerosPares();
////lambda.LambdaOrdenaLista();
////lambda.LambdaObtenerNombre();
=======
//lambda.LambdaNumerosPares();
//lambda.LambdaOrdenaLista();
//lambda.LambdaConsultaNombre();

//Console.WriteLine("Iniciando solicitud...");

//Asincrona async = new Asincrona();
// Llamada asíncrona a un método que realiza una solicitud HTTP
//string content = await async.GetWebContentAsync("https://www.example.com");
//Console.WriteLine("Contenido recibido:");
//Console.WriteLine(content);

//// Crear un sensor de temperatura con un umbral de 30 grados
//TemperaturaSensor sensor = new TemperaturaSensor(30.0);
//// Crear un sistema de alerta
//TemperaturaAlerta alert = new TemperaturaAlerta();
//// Suscribirse al evento
//sensor.TemperaturaExcedida += alert.OnTemperatureExceeded;
//// Simular mediciones de temperatura
//double[] temperatures = { 25.0, 28.0, 31.5, 29.0, 33.0 };
//foreach (var temp in temperatures)
//{
//    sensor.VerificarTemperatura(temp);
//}

MotorElectrico objMotorElectrico = new MotorElectrico();
MotorDiesel objMotorDiesel = new MotorDiesel();
Carro objCarro = new Carro(objMotorDiesel);
objCarro.StartCar();
>>>>>>> 57958fbe4ee0eaac437b8b283fdf2c4b8ecf79e5

//Console.Write("Nombre a buscar: ");
//string nombre = Console.ReadLine();
//if (string.IsNullOrEmpty(nombre))
//{
//    Console.WriteLine("Debe ingresar un Nombre!");
//    return;
//}
//else
//{
//    linq.QuerySintaxConsultaporNombre(nombre);
//    Console.WriteLine("----------------------------------");
//    lambda.LambdaBuscarporNombre(nombre);
//}
//=======

//>>>>>>> 1cf695bf6a55fe41dc29267289ceb3abf9873826
