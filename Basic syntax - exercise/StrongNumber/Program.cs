using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            number = int.Parse(Console.ReadLine());

            string num = number.ToString();
             
            int resultByFac = 1;
            int result = 0;
            for (int i = 0; i < num.Length; i++)
            {
                int digit = int.Parse(num[i].ToString());
                for (int j = 1; j <= digit; j++)
                {
                    resultByFac *= j;
                }
                result += resultByFac;
                resultByFac = 1;
                
            }

            if (result == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
