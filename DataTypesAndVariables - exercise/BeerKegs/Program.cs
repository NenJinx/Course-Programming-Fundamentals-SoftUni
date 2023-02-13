using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfKegs, heightKeg;
            double radius, volume, biggestKeg = 0;
            string biggestKegName = "";
            numberOfKegs = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfKegs; i++)
            {
                string kegName = Console.ReadLine();
                radius = double.Parse(Console.ReadLine());
                heightKeg = int.Parse(Console.ReadLine());

                volume = 3.14 * radius * radius * heightKeg;
                if (volume > biggestKeg)
                {
                    biggestKeg = volume;
                    biggestKegName = kegName;
                }
            }
            Console.WriteLine(biggestKegName);
        }
    }
}
