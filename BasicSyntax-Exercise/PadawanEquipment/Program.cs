using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money, lightsaberPrice, robePrice, beltPrice, moneyForLightsabers,
                spareLightsabers, finalPriceLightsaber, moneyForRobes, moneyForBelts,
                finalPrice;
            int countStudents, freeBelt;

            money = double.Parse(Console.ReadLine());
            countStudents = int.Parse(Console.ReadLine());
            lightsaberPrice = double.Parse(Console.ReadLine());
            robePrice = double.Parse(Console.ReadLine());
            beltPrice = double.Parse(Console.ReadLine());

            moneyForLightsabers = countStudents * lightsaberPrice;
            spareLightsabers = Math.Ceiling(countStudents * 0.1);
            finalPriceLightsaber = moneyForLightsabers + (spareLightsabers * lightsaberPrice);
            freeBelt = countStudents / 6;
            moneyForRobes = countStudents * robePrice - freeBelt * beltPrice;
            moneyForBelts = countStudents * beltPrice;

            finalPrice = finalPriceLightsaber + moneyForRobes + moneyForBelts;

            if (finalPrice <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {finalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {finalPrice - money:f2}lv more.");
            }
        }
    }
}
