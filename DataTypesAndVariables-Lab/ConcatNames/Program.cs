using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName, secondName, delimiter;
            firstName = Console.ReadLine();
            secondName = Console.ReadLine();
            delimiter = Console.ReadLine();
            Console.WriteLine($"{firstName}{delimiter}{secondName}");
        }
    }
}
