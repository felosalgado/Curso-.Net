using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ejercicios.DelegadosEventos.Delegado;

namespace Ejercicios.DelegadosEventos
{
    public class TemperaturaSensor
    {
        // Definir un evento basado en el delegado.
        public event TemperaturaExcedidaEventHandler TemperaturaExcedida;
        private double _umbral;
        public TemperaturaSensor(double umbral)
        {
            _umbral = umbral;
        }
        public void VerificarTemperatura(double currentTemperature)
        {
            // Si la temperatura excede el umbral, dispara el evento.
            if (currentTemperature > _umbral)
            {
                OnTemperatureExceeded(currentTemperature);
            }
        }
        // Método protegido para invocar el evento
        protected virtual void OnTemperatureExceeded(double currentTemperature)
        {
            // Si hay suscriptores al evento, se notifican.
            TemperaturaExcedida?.Invoke(currentTemperature);
        }

    }
}
