using FawryE_CommAssesment2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryE_CommAssesment2.Classes.Products
{
    public class ShippableProduct : Product, IProductShippable
    {
        public double Weight { get; set; }

        public ShippableProduct(string name, decimal price, int quantity, double weight)
            : base(name, price, quantity)
        {
            Weight = weight;
        }

        public string GetName()
        {
            return Name;
        }

        public double GetWeight()
        {
            return Weight;
        }
    }

}
