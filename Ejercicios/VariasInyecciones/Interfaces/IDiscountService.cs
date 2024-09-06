using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.VariasInyecciones.Interfaces
{
    public interface IDiscountService
    {
        void ApplyDiscount(Order order);
    }
}
