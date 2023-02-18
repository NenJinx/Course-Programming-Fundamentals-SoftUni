using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int fieldSize = int.Parse(Console.ReadLine());
            string[] separator = { " " };

            int[] indexesWithLadyBugs = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries).
            Select(int.Parse).ToArray();
            int[] initialField = new int[fieldSize];
            for (int i = 0; i < indexesWithLadyBugs.Length; i++)
            {
                int busyPlace = indexesWithLadyBugs[i];
                if (busyPlace < 0 || busyPlace > fieldSize - 1)
                {
                    continue;
                }
                initialField[busyPlace] = 1;
            }

            string command = string.Empty;
            int newPosition = 0;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split(' ').ToArray();
                int ladyBugPosition = int.Parse(cmdArgs[0]);
                string ladyBugFlyDirection = cmdArgs[1];
                int ladyBugFly = int.Parse(cmdArgs[2]);

                if (ladyBugPosition < 0 || ladyBugPosition > initialField.Length - 1)
                {
                    continue;
                }
                else if (initialField[ladyBugPosition] == 0)
                {
                    continue;
                }
                if (ladyBugFly == 0)
                {                    
                        continue;                  
                }
                if (ladyBugFlyDirection == "left")
                {
                    newPosition = ladyBugPosition - ladyBugFly;
                    if (newPosition < 0)
                    {
                        initialField[ladyBugPosition] = 0;
                        continue;
                    }

                    else if (initialField[newPosition] == 1)
                    {
                        for (int i = newPosition; i > -1; i -= ladyBugFly)
                        {
                            if (initialField[i] == 0)
                            {
                                initialField[i] = 1;
                                initialField[ladyBugPosition] = 0;
                                break;
                            }
                            else if (i - ladyBugFly < 0)
                            {
                                initialField[ladyBugPosition] = 0;
                                break;
                            }
                            else if (initialField[i] == 1)
                            {
                                continue;
                            }
                        }
                    }
                    else
                    {
                        initialField[newPosition] = 1;
                        initialField[ladyBugPosition] = 0;
                    }
                }
                else if (ladyBugFlyDirection == "right")
                {
                    newPosition = ladyBugPosition + ladyBugFly;
                    if (newPosition > initialField.Length - 1)
                    {
                        initialField[ladyBugPosition] = 0;
                        continue;
                    }

                    else if (initialField[newPosition] == 1)
                    {
                        for (int i = newPosition; i < initialField.Length; i += ladyBugFly)
                        {
                            if (initialField[i] == 0)
                            {
                                initialField[i] = 1;
                                initialField[ladyBugPosition] = 0;
                                break;
                            }
                            else if (i + ladyBugFly > initialField.Length - 1)
                            {
                                initialField[ladyBugPosition] = 0;
                                break;
                            }
                            else if (initialField[i] == 1)
                            {
                                continue;
                            }
                        }
                    }
                    else
                    {
                        initialField[newPosition] = 1;
                        initialField[ladyBugPosition] = 0;
                    }
                }              
            }
            Console.WriteLine(string.Join(" ", initialField));
        }
    }
}





