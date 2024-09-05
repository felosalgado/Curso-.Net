using Ejercicios.VariasInyecciones.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.VariasInyecciones.Fachada.Servicio
{
    public class PaymentProcessor :IOrderProcessor
    {
        private readonly IPaymentService _paymentService;
        public PaymentProcessor(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }
        public void Process(Order order)
        {
            _paymentService.ProcessPayment(order);
        }
    }
}
