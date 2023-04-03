using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DestintionMapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(=|\/)([A-Z][A-Za-z]{2,})+\1";

            string data = Console.ReadLine();
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(data);

            int travelPoints = 0;

            List<string> destinations = new List<string>();

            foreach (Match item in matches)
            {
                travelPoints += item.Groups[2].Length;
                string currentDestination = item.Groups[2].Value;
                destinations.Add(currentDestination);
            }

            Console.WriteLine("Destinations: " + String.Join(", ", destinations));
            Console.WriteLine("Travel Points: " + travelPoints);
        }
    }
}
