using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.DelegadosEventos
{
    public class TemperaturaAlerta
    {
        public void OnTemperatureExceeded(double currentTemperature)
        {
            Console.WriteLine($"¡Alerta! La temperatura ha excedido el umbral: {currentTemperature}°C");
        }

    }
}
