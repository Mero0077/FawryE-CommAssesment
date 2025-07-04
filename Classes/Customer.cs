using FawryE_CommAssesment2.Classes.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryE_CommAssesment2.Classes
{
    public class Customer
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }

        public Customer(string name, decimal balance)
        {
            Name = name;
            Balance = balance;
        }

        public void DeductBalance(decimal amount)
        {
            if (amount > Balance)
            {
                throw new Exception("Insufficient balance.");
            }
            Balance -= amount;
        }
    }

}
