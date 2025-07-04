using FawryE_CommAssesment2.Classes.Products;
using FawryE_CommAssesment2.Interfaces;
using FawryE_CommAssesment2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryE_CommAssesment2.Classes.Cart
{

    public class Cart
    {
        public List<CartItem> Items { get; set; }

        public Cart()
        {
            Items = new List<CartItem>();
        }

        public void Add(Product product, int quantity)
        {
            if (quantity > product.Quantity)
                throw new Exception("Not enough stock for " + product.Name);

            Items.Add(new CartItem(product, quantity));
        }

        public void Checkout(Customer customer, ShippingService shippingService)
        {
            _ValidateItems(customer);

            decimal subtotal = _CalculateSubtotal();
            double totalWeight = _CalculateTotalShippingWeight();
            decimal shippingFee = (decimal)(totalWeight * 40);
            decimal totalAmount = subtotal + shippingFee;

            if (customer.Balance < totalAmount)
                throw new Exception("Insufficient balance.");

            _ProcessPaymentAndShipping(customer, shippingService, subtotal, shippingFee, totalAmount);

            _PrintReceipt(subtotal, shippingFee, totalAmount);
        }

        private void _ValidateItems(Customer customer)
        {
            if (Items.Count == 0)
                throw new Exception("Cart is empty.");

            foreach (var item in Items)
            {
                if (!item.Product.IsAvailable())
                    throw new Exception($"{item.Product.Name} is not available.");

                if (item.Product.IsExpired())
                    throw new Exception($"{item.Product.Name} is expired.");
            }
        }

        private decimal _CalculateSubtotal()
        {
            decimal subtotal = 0;
            foreach (var item in Items)
            {
                subtotal += item.GetCartItemtotal();
            }
            return subtotal;
        }

        private double _CalculateTotalShippingWeight()
        {
            double totalWeight = 0;
            foreach (var item in Items)
            {
                var product = item.Product;
                var shippable = product as IProductShippable;
                if (shippable != null)
                {
                    totalWeight += shippable.GetWeight() * item.Quantity;
                }
            }
            return totalWeight;
        }


        private void _ProcessPaymentAndShipping(Customer customer, ShippingService shippingService, decimal subtotal, decimal shippingFee, decimal totalAmount)
        {
            foreach (var item in Items)
            {
                item.Product.ReduceQuantity(item.Quantity);
            }

            customer.Balance -= totalAmount;

            var shippables = new List<(IProductShippable, int)>();
            foreach (var item in Items)
            {
                var shippable = item.Product as IProductShippable;
                if (shippable != null)
                {
                    shippables.Add((shippable, item.Quantity));
                }
            }

            if (shippables.Count > 0)
            {
                shippingService.Ship(shippables);
            }
        }


        private void _PrintReceipt(decimal subtotal, decimal shippingFee, decimal totalAmount)
        {
            Console.WriteLine("\n** Checkout receipt **");
            foreach (var item in Items)
            {
                Console.WriteLine($"{item.Quantity}x {item.Product.Name} {item.GetCartItemtotal()}");
            }
            Console.WriteLine("----------------------");
            Console.WriteLine($"Subtotal {subtotal}");
            Console.WriteLine($"Shipping {shippingFee}");
            Console.WriteLine($"Amount {totalAmount}");
        }

    }
}
