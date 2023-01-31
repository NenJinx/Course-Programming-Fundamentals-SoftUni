using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n * 2; i++)
            {
                if (i % 2 == 1)
                {
                    sum += i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine($"Sum: " + sum);
        }
    }
}
