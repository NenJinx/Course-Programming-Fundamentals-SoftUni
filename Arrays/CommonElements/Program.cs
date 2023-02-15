using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray, secondArray;

            firstArray = Console.ReadLine().Split(' ').ToArray();
            secondArray = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < secondArray.Length; i++)
            {

                for (int j = 0; j < firstArray.Length; j++)
                {

                    if (secondArray[i] == firstArray[j])
                    {
                        Console.Write(secondArray[i] + " ");

                    }
                }

            }

        }

    }
}

