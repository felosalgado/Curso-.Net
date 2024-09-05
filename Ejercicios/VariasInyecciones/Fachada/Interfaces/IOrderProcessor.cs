using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.VariasInyecciones.Fachada
{
    public interface IOrderProcessor
    {
        void Process(Order order);
    }
}
