using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {       
            string wordToProcess = Console.ReadLine();
            int vowelsNumber = 0;
            show("" + VowelsCalculate(vowelsNumber, wordToProcess));
        }

        static void show(string txt)
        {
            Console.WriteLine(txt);
        }
        static int VowelsCalculate(int vowelsCount,string inputWord)
        {
            for (int i = 0; i < inputWord.Length; i++)
            {
                string stringToProcess = inputWord;
                char letterToProcess = stringToProcess[i];
                if (letterToProcess == 'a' || letterToProcess == 'e' || letterToProcess == 'i'
                    || letterToProcess == 'o' || letterToProcess == 'u' || letterToProcess == 'y'
                   || letterToProcess == 'A' || letterToProcess == 'E' || letterToProcess == 'I'
                    || letterToProcess == 'O' || letterToProcess == 'U' || letterToProcess == 'Y')
                {
                    vowelsCount += 1;
                }
            }
            return vowelsCount;
        }
    }
}
