using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "3:1")
            {
                List<string> cmdArgs = command.Split().ToList();
                string commandName = cmdArgs[0];
                if (commandName == "merge")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    else if (startIndex > input.Count - 1)
                    {
                        startIndex = input.Count - 1;
                    }
                    if (endIndex < 0)
                    {
                        endIndex = 0;
                    }
                    else if (endIndex > input.Count - 1)
                    {
                        endIndex = input.Count - 1;
                    }
                    List<string> tempList = new List<string>();
                    for (int i = startIndex; i <= endIndex; i++)
                    {

                        tempList.Add(input[i]);
                    }
                    input[startIndex] = string.Join("", tempList);
                    for (int i = startIndex + 1; i <= endIndex; i++)
                    {
                        input.RemoveAt(startIndex + 1);

                    }
                }
                else if (commandName == "divide")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int partitions = int.Parse(cmdArgs[2]);
                    List<string> tempList = new List<string>();
                    int partLength = input[index].Length / partitions;
                    int additionalPartLength = input[index].Length % int.Parse(cmdArgs[2]);
                    for (int i = 0; i < partitions; i++)
                    {
                        if (i == partitions - 1) partLength += additionalPartLength;
                        tempList.Add(input[index].Substring(0, partLength));
                        input[index] = input[index].Remove(0, partLength);
                    }
                    input.RemoveAt(int.Parse(cmdArgs[1]));
                    input.InsertRange(int.Parse(cmdArgs[1]), tempList);
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
