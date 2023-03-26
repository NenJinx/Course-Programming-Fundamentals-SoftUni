using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaeserCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] chars = text.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                int symb = chars[i] + 3;
                chars[i] = (char)symb;
            }
            Console.WriteLine(chars);
        }
    }
}
