using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 1)
            {
                while (Math.Abs(n % 2) == 1)
                {
                    Console.WriteLine("Please write an even number.");
                    n = int.Parse(Console.ReadLine());
                }
                if (n < 0)
                {
                    Console.WriteLine("The number is: " + Math.Abs(n));
                }
                else
                {
                    Console.WriteLine("The number is: " + n);
                }
            }
            else
            {
                if (n < 0)
                {
                    Console.WriteLine("The number is: " + Math.Abs(n));
                }
                else
                {
                    Console.WriteLine("The number is: " + n);
                }
            }

        }
    }
}
