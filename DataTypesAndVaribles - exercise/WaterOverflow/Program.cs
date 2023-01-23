using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines, waterQuantities, maxInfusedLiters = 0;

            numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                waterQuantities = int.Parse(Console.ReadLine());
                maxInfusedLiters+=waterQuantities;
                if (maxInfusedLiters > 255)
                {
                    maxInfusedLiters -= waterQuantities;
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(maxInfusedLiters);
        }
    }
}
