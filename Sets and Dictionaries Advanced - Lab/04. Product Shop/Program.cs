using System;
using System.Collections.Generic;

namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<Product>> shops =
                new SortedDictionary<string, List<Product>>();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "Revision") break;
                string shopName = input[0];
                string productName = input[1];
                double productPrice = double.Parse(input[2]);
                if (shops.ContainsKey(shopName))
                {
                    shops[shopName].Add(new Product(productName, productPrice));
                }
                else
                {
                    shops.Add(shopName, new List<Product>());
                    shops[shopName].Add(new Product(productName, productPrice));
                }
            }

            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (Product product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
                }
            }
        }
    }

    class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
