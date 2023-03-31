using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            string pattern = @">>(?<name>[A-z]+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)";
            Regex regex = new Regex(pattern);
            double productsCost = 0;
            List <string>names = new List<string>();
            while ((command = Console.ReadLine()) != "Purchase")
            {
                Match match = regex.Match(command);
                if (match.Success)
                {
                    productsCost += double.Parse(match.Groups["price"].Value) * double.Parse(match.Groups["quantity"].Value);
                    names.Add(match.Groups["name"].Value);
                }
            }
            Console.WriteLine("Bought furniture:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine($"Total money spend: {productsCost}");
        }
    }
}
