using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string command = string.Empty;
            string[] separator = { ":" };
            while ((command = Console.ReadLine()) != "Travel")
            {
                string[] commandArgs = command.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                string commandName = commandArgs[0];
                if (commandName == "Add Stop")
                {
                    int index = int.Parse(commandArgs[1]);
                    if (index < 0 || index > text.Length - 1)
                    {
                        Console.WriteLine(text);
                        continue;
                    }
                    string str = commandArgs[2];
                    text = text.Insert(index, str);
                    Console.WriteLine(text);

                }
                else if (commandName == "Remove Stop")
                {
                    int start = int.Parse(commandArgs[1]);
                    int end = int.Parse(commandArgs[2]);
                    if (start >= 0 && start <= end && end >= start && end <= text.Length - 1)
                    {
                        text = text.Remove(start, end - start + 1);
                    }
                    Console.WriteLine(text);
                }
                else if (commandName == "Switch")
                {
                    string oldStr = commandArgs[1];
                    string newStr = commandArgs[2];
                    if (text.Contains(oldStr))
                    {
                        text = text.Replace(oldStr, newStr);
                    }
                    Console.WriteLine(text);
                }
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {text}");
        }
    }
}
