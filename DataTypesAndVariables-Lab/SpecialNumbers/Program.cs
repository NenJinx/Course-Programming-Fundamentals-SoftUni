using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int numberSum = 0;
            for (int i = 1; i <= n; i++)
            {
                string convertNum = i.ToString();
                for (int j = 0; j < convertNum.Length; j++)
                {
                    numberSum += convertNum[j] - 48;
                }
                if (numberSum == 5 || numberSum == 7 || numberSum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
                numberSum = 0;
            }
        }
    }
}
