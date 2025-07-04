using FawryE_CommAssesment2.Classes.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryE_CommAssesment2.Classes.Order
{
    public class Order
    {
        public List<CartItem> Items { get; private set; }
        public decimal Subtotal { get; private set; }
        public decimal ShippingFee { get; private set; }
        public decimal Total { get; private set; }

        public Order(List<CartItem> items, decimal subtotal, decimal shippingFee, decimal total)
        {
            Items = new List<CartItem>(items);
            Subtotal = subtotal;
            ShippingFee = shippingFee;
            Total = total;
        }
    }

}
