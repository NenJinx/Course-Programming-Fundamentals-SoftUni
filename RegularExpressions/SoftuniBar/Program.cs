using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SoftuniBar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>[A-Za-z]+)>[^|$%.]*\|(?<quantity>\d+)[^|$%.]*\|[^|$%.]*?(?<price>\d+\.?\d+)\$";
            Regex regex = new Regex(pattern);
            string command = string.Empty;
            string name = string.Empty;
            string product = string.Empty;
            double price = 0;
            double total = 0;

            while ((command = Console.ReadLine()) != "end of shift")
            {
                Match match = regex.Match(command);
                if (match.Success)
                {
                    name = match.Groups["name"].Value;
                    product = match.Groups["product"].Value;
                    price = double.Parse(match.Groups["price"].Value) * double.Parse(match.Groups["quantity"].Value);
                    Console.WriteLine($"{name}: {product} - {price:f2}");
                    total += price;
                }
            }
            Console.WriteLine($"Total income: {total:f2}");
        }
    }
}
