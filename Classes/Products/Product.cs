using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryE_CommAssesment2.Classes.Products
{
    public abstract class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; protected set; }

        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public virtual bool IsAvailable()
        {
            return Quantity > 0;
        }

        public virtual void ReduceQuantity(int amount)
        {
            if (amount > Quantity)
                throw new Exception("Not enough stock for " + Name);
            Quantity -= amount;
        }

        public virtual void IncreaseQuantity(int amount)
        {
         
            Quantity += amount;
        }

        public virtual bool IsExpired()
        {
            return false;
        }
    }

}
