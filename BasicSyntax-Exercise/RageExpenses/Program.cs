using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount, breakHeadsetCount, breakMouseCount, breakKeyboardCount, breakDisplayCount;
            double headsetPrice, mousePrice, keyboardPrice, displayPrice, expenses;

            lostGamesCount = int.Parse(Console.ReadLine());
            headsetPrice = double.Parse(Console.ReadLine());
            mousePrice = double.Parse(Console.ReadLine());
            keyboardPrice = double.Parse(Console.ReadLine());
            displayPrice = double.Parse(Console.ReadLine());

            breakHeadsetCount = lostGamesCount / 2;
            breakMouseCount = lostGamesCount / 3;
            breakKeyboardCount = lostGamesCount / 6;
            breakDisplayCount = lostGamesCount / 12;

            expenses = breakHeadsetCount * headsetPrice + breakMouseCount * mousePrice +
                breakKeyboardCount * keyboardPrice + breakDisplayCount * displayPrice;

            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
