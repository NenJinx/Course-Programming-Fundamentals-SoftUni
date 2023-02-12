using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyInPounds, convertMoneyInDollars;
            moneyInPounds = double.Parse(Console.ReadLine());
            convertMoneyInDollars = moneyInPounds * 1.31;
            Console.WriteLine($"{convertMoneyInDollars:f3}");
        }
    }
}
