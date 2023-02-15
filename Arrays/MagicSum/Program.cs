using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers;
            numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 1; j < numbers.Length - i; j++)
                {
                    if (numbers[i] + numbers[j + i] == number)
                    {
                        Console.WriteLine(numbers[i] + " " + numbers[j + i]);
                    }
                }


            }

        }
    }
}

