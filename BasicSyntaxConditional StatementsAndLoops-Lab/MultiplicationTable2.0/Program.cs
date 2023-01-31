using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int n = int.Parse(Console.ReadLine());
                int multiplicationTableStart = int.Parse(Console.ReadLine());
                int sum = 0;
                if (multiplicationTableStart > 10)
                {
                    sum = n * multiplicationTableStart;
                    Console.WriteLine($"{n} X {multiplicationTableStart} = {sum}");
                }
                for (int i = multiplicationTableStart; i <= 10; i++)
                {                    
                    sum = n * i;
                    Console.WriteLine($"{n} X {i} = {sum}");
                }

            }
        }
    }

}
    

