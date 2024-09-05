using Ejercicios.VariasInyecciones.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.VariasInyecciones.Fachada.Servicio
{
    public class OrderFachada
    {
        private readonly IEnumerable<IOrderProcessor> _processors;
        private readonly ILoggingService _loggingService;
        public OrderFachada(IEnumerable<IOrderProcessor> processors, ILoggingService loggingService)
        {
            _processors = processors;
            _loggingService = loggingService;
        }
        public void ProcessOrder(Order order)
        {
            // Recorre todos los procesadores inyectados y ejecuta su método Process
            foreach (var processor in _processors)
            {
                processor.Process(order);
            }
            // Registra un mensaje indicando que el pedido fue procesado exitosamente
            _loggingService.Log("Order processed successfully.");
        }
    }
}
