using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sep = { ", " };
            List<string> names = Console.ReadLine().Split(sep, StringSplitOptions.RemoveEmptyEntries).ToList();
            Dictionary<string, int> namesAndKm = new Dictionary<string, int>();
            for (int i = 0; i < names.Count; i++)
            {
                if (!namesAndKm.ContainsKey(names[i]))
                {
                    namesAndKm[names[i]] = 0;
                }
            }
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end of race")
            {
                string pattern = @"[A-Za-z]+";
                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(input);
                string name = string.Empty;
                int value = 0;
                foreach (Match item in matches)
                {
                    name += item.Value;
                }
                pattern = @"\d+";
                regex = new Regex(pattern);
                matches = regex.Matches(input);
                foreach (Match item in matches)
                {
                    for (int i = 0; i < item.Value.Length; i++)
                    {
                        value += item.Value[i] - 48;
                    }
                }
                if (namesAndKm.ContainsKey(name))
                {
                    namesAndKm[name] += value;
                }
            }
            int counter = 1;
            foreach (var item in namesAndKm.OrderByDescending(x => x.Value).Take(3))
            {
                string place = counter == 1 ? "st" : counter == 2 ? "nd" : "rd";
                Console.WriteLine($"{counter}{place} place: {item.Key}");
                counter++;
            }


        }
    }
}
