using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char keySymb = '>';

            int startIndex = -1;
            int keySymbIndex = -2;
            int count = 0;
            while (keySymbIndex != -1)
            {
                keySymbIndex = text.IndexOf(keySymb, startIndex + 1);
                if (keySymbIndex == -1)
                {
                    continue;
                }
                startIndex = keySymbIndex;
                count++;
            }

            int start = 0;
            int remainingStrenght = 0;
            for (int i = 0; i < count; i++)
            {
                int symbIndex = text.IndexOf(keySymb, start);
                int strenght = text[symbIndex + 1] - 48;
                if (remainingStrenght > 0)
                {
                    strenght += remainingStrenght;
                    remainingStrenght = 0;
                }
                int nextSymb = text.IndexOf(keySymb, symbIndex + 1);
                if (nextSymb > -1)
                {
                    string substr = text.Substring(symbIndex + 1, nextSymb - symbIndex - 1);
                    if (strenght <= substr.Length)
                    {
                        text = text.Remove(symbIndex + 1, strenght);
                    }
                    else
                    {
                        text = text.Remove(symbIndex + 1, substr.Length);
                        remainingStrenght += strenght - substr.Length;
                    }
                    start = symbIndex + 1; 
                }
                else
                {
                    string substr = text.Substring(symbIndex + 1, text.Length - 1 - symbIndex);
                    if (strenght <= substr.Length)
                    {
                        text = text.Remove(keySymb + 1, strenght);
                    }
                    else
                    {
                        text = text.Remove(symbIndex + 1, substr.Length);
                    }
                }
            }
            Console.WriteLine(text);

        }
    }
}

