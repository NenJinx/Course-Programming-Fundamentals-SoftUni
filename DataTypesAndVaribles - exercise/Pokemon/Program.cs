using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int pokePower, distance, countTargets = 0, y, startPower;
            double halfPower = 0;
            pokePower = int.Parse(Console.ReadLine());
            distance = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            halfPower = (double)pokePower / 2;
            while (pokePower >= distance)
            {
                pokePower = pokePower - distance;
                countTargets++;
                if (pokePower == halfPower && y > 0)
                {
                    pokePower = pokePower / y;
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(countTargets);

        }
    }

}


