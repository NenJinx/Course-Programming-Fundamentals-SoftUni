using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] values = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int leftSum = 0;
            int rightSum = 0;
            bool equalSums = false;

            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 1; j < values.Length - i; j++)
                {
                    if (i == values.Length - 1)
                    {
                        break;
                    }
                    rightSum += values[j + i];
                }


                for (int m = i - 1; m >= 0; m--)
                {
                    if (i == 0)
                    {
                        break;
                    }
                    leftSum += values[m];
                }
                if (leftSum == rightSum)
                {
                    Console.Write(i);
                    equalSums = true;
                }
                rightSum = 0;
                leftSum = 0;
            }
            if (equalSums == false && values.Length > 1)
            {
                Console.WriteLine("no");
            }

        }
    }
}

