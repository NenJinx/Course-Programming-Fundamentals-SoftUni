using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int symbolsCount, sum = 0;

            symbolsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < symbolsCount; i++)
            {
                char symb = char.Parse(Console.ReadLine());

                sum += (int)symb;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}       
