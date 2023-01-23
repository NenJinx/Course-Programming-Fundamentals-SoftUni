using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine(); 

            int digitsSum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                digitsSum += int.Parse(num[i].ToString());
            }

            Console.WriteLine(digitsSum);
        }
    }
}
