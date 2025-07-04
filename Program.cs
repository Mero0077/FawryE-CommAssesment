using FawryE_CommAssesment2.Classes;
using FawryE_CommAssesment2.Classes.Cart;
using FawryE_CommAssesment2.Classes.Products;
using FawryE_CommAssesment2.Services;

namespace FawryE_CommAssesment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!\n");

            var cheese = new ExpirableShippableProduct("Cheese", 100, 5, DateTime.Now.AddDays(10), 0.2);
            var biscuits = new ShippableProduct("Biscuits", 150, 5, 0.7);

            var customer = new Customer("Lily", 1000);
            var cart = new Cart();

            cart.Add(cheese, 2);
            cart.Add(biscuits, 1);

            var shippingService = new ShippingService();

            cart.Checkout(customer, shippingService);
        }
    }
}
