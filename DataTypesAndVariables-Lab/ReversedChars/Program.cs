using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Char charOne = char.Parse(Console.ReadLine());
            Char charTwo = char.Parse(Console.ReadLine()); 
            Char charThree = char.Parse(Console.ReadLine());
     
            Console.WriteLine(charThree + " " + charTwo + " " + charOne);
          
        }
    }
}
