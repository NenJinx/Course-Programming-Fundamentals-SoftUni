using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numberOfSnowballs, snowballSnow = 0, bestSnowballSnow = 0, bestSnowballTime = 0,
                    snowballTime = 0, snowballQuality = 0, bestSnowballQuality = 0;


            int powerNumber = 0;
            BigInteger snowballValue = 0, bestSnowballValue = 0;

            numberOfSnowballs = int.Parse(Console.ReadLine());
            //	On the first line, you will get the snowballSnow – an integer.
            //⦁	On the second line you will get the snowballTime – an integer.
            //⦁	On the third line, you will get the snowballQuality – an integer

            //For each snowball you must calculate its snowballValue by the following formula:
            //(snowballSnow / snowballTime) ^ snowballQuality
            //In the end, you must print the highest calculated snowballValue.


            for (int i = 1; i <= numberOfSnowballs; i++)
            {
                snowballSnow = int.Parse(Console.ReadLine());
                snowballTime = int.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());

                powerNumber = snowballSnow / snowballTime;
                snowballValue = BigInteger.Pow(powerNumber, snowballQuality);

                if (bestSnowballValue < snowballValue)
                {

                    bestSnowballSnow = snowballSnow;
                    bestSnowballTime = snowballTime;
                    bestSnowballQuality = snowballQuality;
                    bestSnowballValue = snowballValue;
                }
            }
            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestSnowballValue}" +
            $" ({bestSnowballQuality})");
        }
    }
}


