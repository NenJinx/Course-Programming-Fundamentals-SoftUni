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
                int DNALenght = int.Parse(Console.ReadLine());
                string[] separator = { "!" };
                string input = string.Empty;
                int longestSequence = int.MinValue;
                int DNASample = 0;
                int startingIndex = int.MaxValue;
                int leftmostStartingIndex = int.MaxValue;
                int count = 0;
                int DNASum = 0;
                int[] bestDNASequence = new int[DNALenght];
                int sequence = 0; ;

                int[] DNASequence = new int[DNALenght];

                while ((input = Console.ReadLine()) != "Clone them!")
                {
                    DNASequence = input.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries).
                        Select(int.Parse).ToArray();
                    count += 1;
                    for (int i = 0; i < DNASequence.Length; i++)
                    {
                        if (DNASequence[i] == 1)
                        {
                            startingIndex = i;
                            sequence += 1;
                            for (int g = i + 1; g < DNASequence.Length; g++)
                            {
                                if (DNASequence[g] == 1)
                                {
                                    sequence += 1;
                                    i++;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            if (sequence > longestSequence || (sequence == longestSequence &&
                                startingIndex < leftmostStartingIndex) || (startingIndex == leftmostStartingIndex
                                && DNASequence.Sum() > DNASum))
                            {
                                longestSequence = sequence;
                                DNASample = count;
                                DNASum = DNASequence.Sum();
                                leftmostStartingIndex = startingIndex;
                                bestDNASequence = DNASequence;
                            }

                            sequence = 0;
                            startingIndex = 0;
                        }

                        else
                        {
                            continue;
                        }

                    }
                }
                if (DNASample == 0)
                {
                    DNASample = 1;
                }
                Console.WriteLine($"Best DNA sample {DNASample} with sum: {DNASum}.");
                Console.WriteLine(string.Join(" ", bestDNASequence));
            }

        }
    }

}



