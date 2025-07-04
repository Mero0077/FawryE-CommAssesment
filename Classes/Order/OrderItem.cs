using FawryE_CommAssesment2.Classes.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryE_CommAssesment2.Classes.Order
{
    public class OrderItem
    {
        public Product Product { get; }
        public int Quantity { get; }

        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

    }
}
