using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.InyeccionDependencias.ConInyeccionDependencia
{
    public class Carro
    {
        private readonly Motor _motor;
        // Dependencia inyectada a través del constructor
        public Carro(Motor motor)
        {
            _motor = motor;
        }
        public void StartCar()
        {
            _motor.Start();
        }

    }
}
