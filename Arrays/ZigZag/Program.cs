using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ZigZag
{
    internal class Program
    {
        static void Main(string[] args)
        
        {

            int n = int.Parse(Console.ReadLine());

            int[] firstArray, secondArray;

            firstArray = new int[n];
            secondArray = new int[n];

            for (int i = 1; i <= n; i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                int firstNum = numbers[0];
                int secondNum = numbers[1];

                if (i % 2 != 0)
                {
                    firstArray[i - 1] = firstNum;   
                    secondArray[i - 1] = secondNum;
                }
                else
                {
                    firstArray[i - 1] = secondNum;
                    secondArray[i - 1] = firstNum;
                }

            }
                Console.WriteLine(string.Join(" ", firstArray));
                Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}
