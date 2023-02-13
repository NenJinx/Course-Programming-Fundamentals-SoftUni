using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecryptingMessages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte key = byte.Parse(Console.ReadLine());
            byte countCharacters = byte.Parse(Console.ReadLine());
            string message = string.Empty;
            for (int i = 1; i <= countCharacters; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                ch += (char)key;
                char newChar = ch;
                message += newChar;
            }
            Console.WriteLine(message);
        }
    }
}
