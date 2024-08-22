using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.DelegadosEventos
{
    public class Delegado
    {
        // Definir un delegado que apunte a cualquier método que reciba un valor double (la temperatura) y no retorne nada.
        public delegate void TemperaturaExcedidaEventHandler(double temperaturaActual);

    }
}
