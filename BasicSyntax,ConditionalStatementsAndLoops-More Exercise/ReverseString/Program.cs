using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] textArray = text.ToCharArray();
            Array.Reverse(textArray);
            Console.WriteLine(string.Join("",textArray));
        }
    }
}
