using Ejercicios.InyeccionDependencias.ConInterfaces.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.InyeccionDependencias.ConInterfaces
{
    public class MotorDiesel : IMotor
    {
        public void Start() => Console.WriteLine("Motor dicel encendido.");

    }
}
