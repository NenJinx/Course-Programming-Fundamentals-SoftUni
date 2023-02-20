using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] array = Console.ReadLine().Split(' ').
            Select(double.Parse).ToArray();
            foreach (var item in array)
            {
                int round = (int)Math.Round(item,MidpointRounding.AwayFromZero);
                Console.WriteLine(item + " => " + round);
                //Console.WriteLine(item + " => " + Math.Round(item,
                //    MidpointRounding.AwayFromZero));
            }

        }
    }
}
