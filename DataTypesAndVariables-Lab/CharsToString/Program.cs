using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharsToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string chars = string.Empty;
            Char charOne = char.Parse(Console.ReadLine());
            chars += charOne;
            Char charTwo = char.Parse(Console.ReadLine());
            chars += charTwo;
            Char charThree = char.Parse(Console.ReadLine());
            chars += charThree;
            Console.WriteLine(chars);
        }
    }
}
