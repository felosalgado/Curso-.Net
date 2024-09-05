using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.VariasInyecciones.Fachada.Servicio
{
    public class DiscountProcessor : IOrderProcessor
    {
        private readonly IDiscountService _discountService;
        public DiscountProcessor(IDiscountService discountService)
        {
            _discountService = discountService;
        }
        public void Process(Order order)
        {
            _discountService.ApplyDiscount(order);
        }
    }
}
