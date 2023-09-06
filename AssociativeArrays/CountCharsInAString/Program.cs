using System;
using System.Collections.Generic;

namespace CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> countSymbols = new Dictionary<char, int>();

            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                char symbol = word[i];
                if (symbol == ' ')
                {
                    continue;
                }
                if (!countSymbols.ContainsKey(symbol))
                {
                    countSymbols.Add(symbol, 0);
                }

                countSymbols[symbol]++;
            }
            foreach (var item in countSymbols)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
