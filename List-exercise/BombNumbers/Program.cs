using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').
            Select(int.Parse).ToList();

            int[] array = Console.ReadLine().Split(' ').
            Select(int.Parse).ToArray();

            int sum = 0;
            int power = array[1];
            int bomb = array[0];

            int bombIndex = 0;
            while ((bombIndex = list.IndexOf(bomb)) > -1)
            {
                int startPowerIndex = bombIndex - power;
                int finalPowerIndex = bombIndex + power;

                if (startPowerIndex >= 0 && finalPowerIndex <= list.Count - 1)
                {
                    list.RemoveRange(startPowerIndex, power * 2 + 1);
                }
                else if (startPowerIndex < 0 && finalPowerIndex <= list.Count - 1)
                {
                    list.RemoveRange(0, (power * 2) + 1 + startPowerIndex);
                }
                else if (startPowerIndex >= 0 && finalPowerIndex > list.Count - 1)
                {
                    list.RemoveRange(startPowerIndex, (power + 1) + ((list.Count - 1) - bombIndex));
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }

            Console.WriteLine(sum);
        }
    }
}
