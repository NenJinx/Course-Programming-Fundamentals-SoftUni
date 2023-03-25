using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] textValues = Console.ReadLine().Split(' ');
            string text = textValues[0];
            string textOne = textValues[1];
            Console.WriteLine(SymbolsCodeSum(text, textOne));
        }
        static int SymbolsCodeSum(string firstText, string secondText)
        {
            int sum = 0;
            int shorter = 0;
            string longer = string.Empty;
            char[] symbs = new char[firstText.Length];
            symbs = firstText.ToCharArray();
            char[] symbsSecond = new char[secondText.Length];
            symbs = secondText.ToCharArray();
            if (firstText.Length < secondText.Length)
            {
                shorter = firstText.Length;
                longer = secondText;
            }
            else if (secondText.Length < firstText.Length)
            {
                shorter = secondText.Length;
                longer = firstText;
            }
            else
            {
                shorter = firstText.Length;
            }
            for (int i = 0; i < shorter; i++)
            {
                sum += firstText[i] * secondText[i];
            }
            for (int i = shorter; i < longer.Length; i++)
            {
                sum += longer[i];
            }
            return sum;
        }
    }
}
