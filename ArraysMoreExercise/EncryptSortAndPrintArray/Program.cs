using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncryptSortAndPrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int numberOfStrings = int.Parse(Console.ReadLine());
            string[] names = new string[numberOfStrings]; 
            int[] valueOfString = new int[numberOfStrings];

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
                int sumVowel = 0;
                int sumCons = 0;

                foreach (char index in names[i])
                {
                    if (index == 'a' || index == 'e' || index == 'o' || index == 'i' ||
                        index == 'u' || index == 'A' || index == 'E' || index == 'O' ||
                        index == 'I' || index == 'U')
                    {
                        sumVowel += (int)(index * names[i].Length);
                    }
                    else
                    {
                        sumCons += (int)(index / names[i].Length);
                    }
                }

                int sumOfString = sumCons + sumVowel;
                valueOfString[i] = sumOfString;
            }

            Array.Sort(valueOfString);
            foreach (int value in valueOfString)
            {
                Console.WriteLine(value);
            }





        }
    }
}

