using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertMeterToKilometer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());

            double distanceConvertInKilometers = (double)distanceInMeters / 1000;

            Console.WriteLine($"{distanceConvertInKilometers:f2}");
        }
    }
}
