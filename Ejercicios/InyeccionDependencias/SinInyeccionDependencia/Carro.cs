using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.InyeccionDependencias.SinInyeccionDependencia
{
    public class Carro
    {
        private Motor _motor;
        public Carro()
        {
            _motor = new Motor(); // Dependencia creada internamente
        }
        public void EncenderCarro()
        {
            _motor.Start();
        }

    }
}
