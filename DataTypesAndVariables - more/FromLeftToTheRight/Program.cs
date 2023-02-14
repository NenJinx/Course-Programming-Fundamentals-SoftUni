using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Data.SqlTypes;

namespace FromLeftToTheRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double biggerElement;
            string[] separator = { " " };
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                double[] array = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries).
                    Select(double.Parse).ToArray();
                Array.Sort(array);
                biggerElement = Math.Abs(array[1]);
                foreach (var item in biggerElement.ToString())
                {
                    sum += item - 48;
                }
                Console.WriteLine(sum);
                sum = 0;
            }
        }
    }
}
