using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                //int DNALenght = int.Parse(Console.ReadLine());
                //string[] separator = { "!" };
                //string input = string.Empty;
                //int longestSequence = int.MinValue;
                //int DNASample = 0;
                //int startingIndex = int.MaxValue;
                //int leftmostStartingIndex = int.MaxValue;
                //int count = 0;
                //int DNASum = 0;
                //int[] bestDNASequence = new int[DNALenght];
                //int sequence = 0; ;

                //int[] DNASequence = new int[DNALenght];

                //while ((input = Console.ReadLine()) != "Clone them!")
                //{
                //    DNASequence = input.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries).
                //        Select(int.Parse).ToArray();
                //    count += 1;
                //    for (int i = 0; i < DNASequence.Length; i++)
                //    {
                //        if (DNASequence[i] == 1)
                //        {
                //            startingIndex = i;
                //            sequence += 1;
                //            for (int g = i + 1; g < DNASequence.Length; g++)
                //            {
                //                if (DNASequence[g] == 1)
                //                {
                //                    sequence += 1;
                //                    i++;
                //                }
                //                else
                //                {
                //                    break;
                //                }
                //            }
                //                if (sequence >= longestSequence)

                //                {
                //                    if (sequence > longestSequence)
                //                    {
                //                        longestSequence = sequence;
                //                        DNASample = count;
                //                        DNASum = DNASequence.Sum();
                //                        leftmostStartingIndex = startingIndex;
                //                        bestDNASequence = DNASequence;
                //                    }

                //                    else if (sequence == longestSequence && startingIndex < leftmostStartingIndex)
                //                    {
                //                        longestSequence = sequence;
                //                        DNASample = count;
                //                        DNASum = DNASequence.Sum();
                //                        leftmostStartingIndex = startingIndex;
                //                        bestDNASequence = DNASequence;
                //                    }
                //                    else if (startingIndex == leftmostStartingIndex && DNASequence.Sum() > DNASum)
                //                    {
                //                        longestSequence = sequence;
                //                        DNASample = count;
                //                        DNASum = DNASequence.Sum();
                //                        leftmostStartingIndex = startingIndex;
                //                        bestDNASequence = DNASequence;
                //                    }
                //                }
                //                sequence = 0;
                //                startingIndex = 0;
                //            }


                //        else
                //            {
                //                continue;
                //            }

                //        }
                //    }
                //    Console.WriteLine($"Best DNA sample {DNASample} with sum: {DNASum}.");
                //    Console.WriteLine(string.Join(" ", bestDNASequence));
                //}







                int dnaLenght = int.Parse(Console.ReadLine());
                string input = Console.ReadLine();
                int[] dna = new int[dnaLenght];
                int lenght = 0;
                int index = 0;
                int sum = 0;
                int currRow = 0;
                int row = 0;

                while (input != "Clone them!")
                {
                    int[] currentDNA = input.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                    currRow++;

                    int currentSum = 0;
                    for (int i = 0; i < currentDNA.Length; i++)
                    {
                        if (currentDNA[i] == 1)
                        {
                            currentSum++;
                        }
                    }

                    int currentLenght = 0;
                    int currentIndex = 0;

                    for (int i = 0; i < currentDNA.Length; i++)
                    {
                        if (currentDNA[i] == 1)
                        {
                            currentLenght++;

                            if (currentLenght == 1)
                            {
                                currentIndex = 1;
                            }
                            if (currentLenght > lenght || currentLenght == lenght && (currentIndex < index || currentSum > sum))
                            {
                                lenght = currentLenght;
                                index = currentIndex;
                                row = currRow;
                                dna = currentDNA;
                                sum = currentSum;
                            }
                        }

                        else
                        {
                            currentIndex = 0;
                            currentLenght = 0;
                        }
                    }

                    input = Console.ReadLine();
                }

                if (row == 0)
                {
                    row = 1;
                }

                Console.WriteLine($"Best DNA sample {row} with {sum}.");
                Console.WriteLine(string.Join(" ", dna));

            }
        }

    }
}


