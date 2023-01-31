using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, sum = 0;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            for (int i = x; i <= y; i++)
            {
                Console.Write(i + " ");
                sum += i;               
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: { sum}");
        }
    }
}
