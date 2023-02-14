using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int countOpenBracket = 0;
            int countCloseBracket= 0;

            for (int i = 1; i <= lines; i++)
            {
                string currentInput = Console.ReadLine();
                if (currentInput == "(")
                {
                    countOpenBracket++;
                }
                else if (currentInput == ")")
                {
                    countCloseBracket++;
                    if (countOpenBracket - countCloseBracket != 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }

            }
            if (countOpenBracket == countCloseBracket)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }


            //THIS ALSO IS VALID
            //int n = int.Parse(Console.ReadLine());
            //bool oneBracket = false;
            //int pairBrackets = 0;
            //string bracketType = string.Empty;

            //for (int i = 1; i <= n; i++)
            //{
            //    string command = Console.ReadLine();
            //    if (command == "(" || command == ")")
            //    {

            //        if (oneBracket == true && bracketType != command)
            //        {
            //            pairBrackets += 1;
            //            oneBracket = false;
            //            bracketType = string.Empty;
            //        }

            //        else
            //        {
            //            if (oneBracket == true)
            //            {
            //                Console.WriteLine("UNBALANCED");
            //                return;
            //            }
            //            else if (command == ")")
            //            {
            //                Console.WriteLine("UNBALANCED");
            //                return;
            //            }
            //            else
            //            {
            //                oneBracket = true;
            //                bracketType = command;
            //            }
            //        }

            //    }

            //}
            //if (oneBracket == false && pairBrackets > 0)
            //{
            //    Console.WriteLine("BALANCED");
            //}
            //else
            //{
            //    Console.WriteLine("UNBALANCED");
            //}
        }
    }
}
