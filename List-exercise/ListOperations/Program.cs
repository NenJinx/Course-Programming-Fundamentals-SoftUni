using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listWithNumbers = Console.ReadLine().Split(' ').
           Select(int.Parse).ToList();

            string command = "";

            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArgs = command.Split(' ').
                ToArray();
                string commandName = commandArgs[0];

                if (commandName == "Add")
                {
                    int number = int.Parse(commandArgs[1]);
                    listWithNumbers.Add(number);
                }
                if (commandName == "Insert")
                {
                    int number = int.Parse(commandArgs[1]);
                    int numberIndex = int.Parse(commandArgs[2]);
                    if (numberIndex <= listWithNumbers.Count - 1 && numberIndex >= 0)
                    {
                        listWithNumbers.Insert(numberIndex, number);
                    }
                    else
                        Console.WriteLine("Invalid index");
                }
                else if (commandName == "Remove")
                {
                    int numberIndex = int.Parse(commandArgs[1]);
                    if (numberIndex <= listWithNumbers.Count - 1 & numberIndex >= 0)
                    {
                        listWithNumbers.RemoveAt(numberIndex);
                    }
                    else
                        Console.WriteLine("Invalid index");
                }

                else if (commandName == "Shift")
                {
                    string displacementDirection = commandArgs[1];
                    int lastPositionNumber = 0;
                    int count = int.Parse(commandArgs[2]);
                    int firstPositionNumber = 0;
                    if (displacementDirection == "left")
                    {
                        for (int j = 1; j <= count; j++)
                        {
                            firstPositionNumber = listWithNumbers[0];
                            for (int i = 0; i < listWithNumbers.Count - 1; i++)
                            {
                                listWithNumbers[i] = listWithNumbers[i + 1];
                            }
                            listWithNumbers[listWithNumbers.Count - 1] = firstPositionNumber;
                        }
                    }
                    else if (displacementDirection == "right")
                    {
                        for (int j = 1; j <= count; j++)
                        {
                            lastPositionNumber = listWithNumbers[listWithNumbers.Count - 1];
                            for (int k = 0; k < listWithNumbers.Count - 1; k++)
                            {
                                listWithNumbers[listWithNumbers.Count - 1 - k] =
                                    listWithNumbers[listWithNumbers.Count - 2 - k];
                            }
                            listWithNumbers[0] = lastPositionNumber;
                        }
                    }
                    else
                        Console.WriteLine("Invalid index");
                }
            }
            Console.WriteLine(string.Join(" ", listWithNumbers));
        }
    }
}
