using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPartOfTheASCII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int charIndexStart = int.Parse(Console.ReadLine());
            int charIndexFinish = int.Parse(Console.ReadLine());

            for (int i = charIndexStart; i <= charIndexFinish; i++)
            {
                char symb = (char)i;
                Console.Write(symb + " ");
            }
        }   

    }
}
