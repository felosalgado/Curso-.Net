using Ejercicios.VariasInyecciones.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.VariasInyecciones.Fachada.Servicio
{
    public class NotificationProcessor :IOrderProcessor
    {
        private readonly INotificationService _notificationService;
        public NotificationProcessor(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }
        public void Process(Order order)
        {
            _notificationService.SendNotification(order);
        }
    }
}
