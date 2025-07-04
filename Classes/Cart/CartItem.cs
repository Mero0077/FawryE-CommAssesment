using FawryE_CommAssesment2.Classes.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryE_CommAssesment2.Classes.Cart
{
    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public CartItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public decimal GetCartItemtotal()
        {
            return Product.Price * Quantity;
        }
    }
}
