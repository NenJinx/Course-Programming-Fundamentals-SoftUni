using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdAstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"(\||#)(?<product>[A-Z][a-z]+ ?[A-Z]?[a-z]+)\1(?<date>[0-9]{2}/[0-9]{2}/[0-9]{2})\1(?<calories>[0-9]+)\1");
            MatchCollection matches = regex.Matches(input);
            int totalCalories = 0;
            foreach (Match match in matches)
            {
                totalCalories += int.Parse(match.Groups["calories"].Value);
            }
            int days = totalCalories / 2000;
            Console.WriteLine($"You have food to last you for: {days} days!");
            foreach (Match item in matches)
            {
                Console.WriteLine($"Item: {item.Groups["product"].Value}, Best before: {item.Groups["date"].Value}, Nutrition: {item.Groups["calories"].Value}");
            }
        }
    }
}
