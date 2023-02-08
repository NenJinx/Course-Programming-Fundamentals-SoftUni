using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishNameOfTheLastDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int lastDigit = n % 10;

            string numberName = string.Empty;
            switch (lastDigit)
            {
                case 0:
                    numberName = "zero";
                    break;
                case 1:
                    numberName = "one";
                    break;
                case 2:
                    numberName = "two";
                    break;
                case 3:
                    numberName = "three";
                    break;
                case 4:
                    numberName = "four";
                    break;
                case 5:
                    numberName = "five";
                    break;
                case 6:
                    numberName = "six";
                    break;
                case 7:
                    numberName = "seven";
                    break;
                case 8:
                    numberName = "eight";
                    break;
                case 9:
                    numberName = "nine";
                    break;
            }
            Console.WriteLine(numberName);

        }
    }
}
