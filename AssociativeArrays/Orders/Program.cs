using System;
using System.Collections.Generic;

namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> productsAndQuantity = new Dictionary<string, double>();

            String[] separator = { " " };

            string command;

            Dictionary<string, double> productsAndPrice = new Dictionary<string, double>();
            while ((command = Console.ReadLine()) != "buy")
            {
                string[] cmdArgs = command.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                string product = cmdArgs[0];
                double price = double.Parse(cmdArgs[1]);
                int quantity = int.Parse(cmdArgs[2]);

                if (!productsAndQuantity.ContainsKey(product))
                {
                    productsAndQuantity[product] = 0;
                    productsAndPrice[product] = 0;
                }
                productsAndQuantity[product] += quantity;
                productsAndPrice[product] = price;
            }
            foreach (var product in productsAndPrice)
            {
                double price = productsAndQuantity[product.Key] * productsAndPrice[product.Key];
                Console.WriteLine($"{product.Key} -> {price,0:f2}");
            }
        }
    }
}
