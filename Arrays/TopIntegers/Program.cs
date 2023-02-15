using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                bool isTop = true;
                for (int j = 1; j < arr.Length - i; j++)
                {
                    if (arr[i] > arr[j + i])
                    {
                        continue;
                    }
                    else
                    {
                        isTop = false;
                        break;
                    }
                }
                if (isTop)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
