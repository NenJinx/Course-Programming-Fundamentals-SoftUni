using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            int intValue;
            float floatValue;
            char charValue;
            bool boolValue;

            while ((command = Console.ReadLine()) != "END")
            {
                if (int.TryParse(command,out intValue))
                {
                    Console.WriteLine($"{command} is integer type");
                }
                else if (float.TryParse(command,out floatValue))
                {
                    Console.WriteLine($"{command} is floating point type");
                }
                else if (char.TryParse(command, out charValue))
                {
                    Console.WriteLine($"{command} is character type");
                }
                else if (bool.TryParse(command, out boolValue))
                {
                    Console.WriteLine($"{command} is boolean type");
                }
                else 
                {
                    Console.WriteLine($"{command} is string type");
                }

            }
        }
    }
}
