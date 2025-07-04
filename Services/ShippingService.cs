using FawryE_CommAssesment2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryE_CommAssesment2.Services
{
    public class ShippingService
    {
        public void Ship(List<(IProductShippable item, int quantity)> items)
        {
            Console.WriteLine("** Shipment notice **");
            double totalWeight = 0;

            foreach (var entry in items)
            {
                var name = entry.item.GetName();
                var weight = entry.item.GetWeight() * entry.quantity;
                totalWeight += weight;

                Console.WriteLine($"{entry.quantity}x {name} {weight * 1000}");    
            }

            Console.WriteLine($"Total package weight {totalWeight}kg");
        }
    }

}
