using FawryE_CommAssesment2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryE_CommAssesment2.Classes.Products
{
    public class ExpirableProduct : Product, IProductExpirable
    {
        public DateTime ExpiryDate { get; set; }

        public ExpirableProduct(string name, decimal price, int quantity, DateTime expiryDate)
            : base(name, price, quantity)
        {
            ExpiryDate = expiryDate;
        }

        public override bool IsExpired()
        {
            return DateTime.Now > ExpiryDate;
        }

        public override bool IsAvailable()
        {
            return base.IsAvailable() && !IsExpired();
        }
    }

}
