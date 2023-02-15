using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers;

            numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sequenceLenght = 1;
            int longestSequence = 1;
            int longestSequenceContent = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {

                if (numbers[i + 1] == numbers[i])
                {
                    sequenceLenght += 1;
                }
                else
                {
                    sequenceLenght = 1;
                }

                if (sequenceLenght > longestSequence)
                {
                    longestSequence = sequenceLenght;
                    longestSequenceContent = numbers[i];
                }
            }

            for (int d = 0; d < longestSequence; d++)
            {
                Console.Write(longestSequenceContent + " ");
            }
        }
    }
}



