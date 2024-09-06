using Ejercicios.InyeccionDependencias.ConInterfaces.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.InyeccionDependencias.ConInterfaces
{
    public class Carro 
    {
        private readonly IMotor _motor;
        // Dependencia inyectada a través del constructor
        public Carro(IMotor motor)
        {
            _motor = motor;
        }

        public void StartCar()
        {
            _motor.Start();
        }


    }
}
