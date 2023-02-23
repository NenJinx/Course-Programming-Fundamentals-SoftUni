using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine().Split(' ').
            Select(int.Parse).ToArray();

            int countNumsForFold = array.Length / 2;
            int sumFromLeft = 0;
            int sumFromRight = 0;

            int counterOne = countNumsForFold / 2 ;
            int counterTwo = countNumsForFold;
            //for (int i = 0; i < counterOne; i++)
            //{
            //    sumFromLeft = array[i] + array[counterOne];
            //    counterOne--;
            //    Console.Write($"{sumFromLeft} ");
            //}
            //for (int j = array.Length - 1; j > counterTwo; j--)
            //{
            //    sumFromRight = array[j] + array[counterTwo];
            //    counterTwo++;
            //    Console.Write($"{sumFromRight} ");
            //}

            for (int i = countNumsForFold / 2 - 1; i < countNumsForFold * 2; i++)
            {
                sumFromLeft = array[i] + array[counterOne];
                counterOne++;
                Console.Write($"{sumFromLeft} ");
            }
            for (int j = array.Length - 1; j > counterTwo; j--)
            {
                sumFromRight = array[j] + array[counterTwo];
                counterTwo++;
                Console.Write($"{sumFromRight} ");
            }


        }
    }
}
