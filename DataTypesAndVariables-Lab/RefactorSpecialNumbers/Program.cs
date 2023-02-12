using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int kolkko = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            //int obshto = 0;
            int sum = 0;
            //int takova = 0;
            int digit = 0;
            bool specialNum = false;
            for (int ch = 1; ch <= n; ch++)
            {
                digit = ch;
                while (ch > 0)
                {
                    sum += ch % 10;
                    ch = ch / 10;
                }
                specialNum = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", digit, specialNum);
                sum = 0;
                ch = digit;
            }

        }
    }
}
