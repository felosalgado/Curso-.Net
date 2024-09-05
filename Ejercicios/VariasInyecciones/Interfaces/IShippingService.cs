using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.VariasInyecciones.Interfaces
{
    public interface IShippingService
    {
        void ShipOrder(Order order);
    }
}
