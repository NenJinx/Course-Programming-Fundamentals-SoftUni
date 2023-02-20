using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] array = Console.ReadLine().Split(' ').
            ToArray();
            Array.Reverse(array);
            Console.WriteLine(string.Join(" ",array));
        }
    }
}
