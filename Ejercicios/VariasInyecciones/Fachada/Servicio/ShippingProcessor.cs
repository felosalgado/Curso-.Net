using Ejercicios.VariasInyecciones.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.VariasInyecciones.Fachada.Servicio
{
    public class ShippingProcessor :IOrderProcessor
    {
        private readonly IShippingService _shippingService;
        public ShippingProcessor(IShippingService shippingService)
        {
            _shippingService = shippingService;
        }
        public void Process(Order order)
        {
            _shippingService.ShipOrder(order);
        }
    }
}
