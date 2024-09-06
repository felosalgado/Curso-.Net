using Ejercicios.VariasInyecciones.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.VariasInyecciones.Fachada.Servicio
{
    public class InventoryProcessor :IOrderProcessor
    {
        private readonly IInventoryService _inventoryService;
        public InventoryProcessor(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }
        public void Process(Order order)
        {
            _inventoryService.UpdateInventory(order);
        }
    }
}
