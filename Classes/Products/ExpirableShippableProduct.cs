using FawryE_CommAssesment2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryE_CommAssesment2.Classes.Products
{
    public class ExpirableShippableProduct : Product, IProductExpirable, IProductShippable
    {
        public DateTime ExpiryDate { get; set; }
        public double Weight { get; set; } 

        public ExpirableShippableProduct(string name, decimal price, int quantity, DateTime expiryDate, double weight)
            : base(name, price, quantity)
        {
            ExpiryDate = expiryDate;
            Weight = weight;
        }

        public override bool IsExpired()
        {
            return DateTime.Now > ExpiryDate;
        }

        public override bool IsAvailable()
        {
            return base.IsAvailable() && !IsExpired();
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
