using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TownInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string townName;
            int area, population;
            townName = Console.ReadLine();
            population = int.Parse(Console.ReadLine());
            area = int.Parse(Console.ReadLine());
            Console.WriteLine($"Town {townName} has population of {population} and area {area} square km.");
        }
    }
}
