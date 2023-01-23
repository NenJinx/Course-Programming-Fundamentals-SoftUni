using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int theBiggestDivisor = 0;

            if (n % 2 == 0)
            {
                theBiggestDivisor = 2;
            }
            if (n % 3 == 0)
            {
                theBiggestDivisor = 3;
            }
            if (n % 6 == 0)
            {
                theBiggestDivisor = 6;
            }
            if (n % 7 == 0)
            {
                theBiggestDivisor = 7;
            }
            if (n % 10 == 0)
            {
                theBiggestDivisor = 10;
            }

            if (theBiggestDivisor == 0)
            {
                Console.WriteLine("Not divisible");
            }
            //This also is valid
            //if (n % 2 != 0 && n % 3 != 0 && n % 6 != 0 && n % 7 != 0 && n % 10 != 0)
                //Console.WriteLine("Not divisible");
            else
                Console.WriteLine($"The number is divisible by {theBiggestDivisor}");



        }
    }
}
