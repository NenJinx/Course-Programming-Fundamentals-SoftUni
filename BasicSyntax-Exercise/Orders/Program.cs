using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int startingYield = int.Parse(Console.ReadLine());
            const int consumeSpices = 26;
            const int yieldDrops = 10;
            int extractSpices = 0;
            int workerDays = 0;
            while (startingYield >= 100)
            {
                extractSpices += startingYield - consumeSpices;
                workerDays += 1;
                startingYield -= yieldDrops;
            }
            if (extractSpices < 26)
            {
                extractSpices = 0;
            }
            else 
            {
                extractSpices -= consumeSpices;
            }
            Console.WriteLine(workerDays);
            Console.WriteLine(extractSpices);
        }
    }
}
