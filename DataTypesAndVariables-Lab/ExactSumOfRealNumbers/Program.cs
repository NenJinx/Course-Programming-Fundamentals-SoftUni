using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactSumOfRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countN = int.Parse(Console.ReadLine());
            decimal sumOfRealNumber = 0;
            for (int i = 0; i < countN; i++)
            {
                decimal realNumber = decimal.Parse(Console.ReadLine());

                sumOfRealNumber += realNumber;
            }
            Console.WriteLine(sumOfRealNumber);
        }
    }
}
