using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.VariasInyecciones.Servicio
{
    public class OrderServices
    {
        private readonly IPaymentService _paymentService;
        private readonly IShippingService _shippingService;
        private readonly IInventoryService _inventoryService;
        private readonly INotificationService _notificationService;
        private readonly IDiscountService _discountService;
        private readonly ILoggingService _loggingService;

        public OrderServices(IPaymentService paymentService,
                                IShippingService shippingService,
                                IInventoryService inventoryService,
                        INotificationService notificationService,
                        IDiscountService discountService,
                        ILoggingService loggingService)
        {
            _paymentService = paymentService;
            _shippingService = shippingService;
            _inventoryService = inventoryService;
            _notificationService = notificationService;
            _discountService = discountService;
            _loggingService = loggingService;
        }

        public void ProcessOrder(Order order)
        {
            _discountService.ApplyDiscount(order);
            _paymentService.ProcessPayment(order);
            _inventoryService.UpdateInventory(order);
            _shippingService.ShipOrder(order);
            _notificationService.SendNotification(order);
            _loggingService.Log("Order processed successfully.");
        }


    }
}
