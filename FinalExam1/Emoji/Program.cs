using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Emoji
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\d+";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);
            double threshold = 1;
            foreach (Match match in matches)
            {
                for (int i = 0; i < match.Length; i++)
                {
                    threshold *= match.Value[i] - 48;
                }
            }
            pattern = @"(:{2}|\*{2})[A-Z][a-z]{2,}\1";
            regex = new Regex(pattern);
            matches = regex.Matches(text);
            int coolness = 0;
            List<string> emojis = new List<string>();
            foreach (Match match in matches)
            {
                for (int i = 0; i < match.Length; i++)
                {
                    if (match.Value[i] == 42 || match.Value[i] == 58)
                        continue;
                    else
                        coolness += match.Value[i];
                }
                if (coolness > threshold)
                {
                    emojis.Add(match.Value);
                }
                coolness = 0;
            }

            Console.WriteLine($"Cool threshold: {threshold}");
            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");
            Console.WriteLine(string.Join("\n", emojis));
        }
    }
}
