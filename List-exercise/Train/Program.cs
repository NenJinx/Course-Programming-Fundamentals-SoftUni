using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagonsCount = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int maxCappacity = int.Parse(Console.ReadLine());

            string command = string.Empty;
            string[] separator = { " " };
            while ((command = Console.ReadLine()) != "end")
            {
                List<string> cmdArgs = command.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (cmdArgs[0] == "Add")
                {
                    wagonsCount.Add(int.Parse(cmdArgs[1]));
                }
                else
                {

                    for (int j = 0; j < wagonsCount.Count; j++)
                    {
                        if (wagonsCount[j] + int.Parse(cmdArgs[0]) <= maxCappacity)
                        {
                            wagonsCount[j] += int.Parse(cmdArgs[0]);
                            break;
                        }
                    }
                }
            }
            printWagonsCount(wagonsCount);
        }


        static void printWagonsCount(List<int> wagonsCount)
        {
            foreach (int numbers in wagonsCount)
            {
                Console.Write(numbers + " ");
            }
        }
    }
}


