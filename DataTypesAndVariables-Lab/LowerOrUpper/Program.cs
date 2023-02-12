using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowerOrUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch = char.Parse(Console.ReadLine());

            if (Char.IsUpper(ch))
            {
                Console.WriteLine("upper-case");
            }
            else if (Char.IsLower(ch))
            {
                Console.WriteLine("lower-case");
            }

        }
    }
}
