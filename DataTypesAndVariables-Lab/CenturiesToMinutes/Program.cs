    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace CenturiesToMinutes
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                int centuries = int.Parse(Console.ReadLine());
                int centuriesInYears = centuries * 100;
                int yearsInDays = (int)(centuriesInYears * 365.2422);
                int daysInHours = yearsInDays * 24;
                int hoursInMinutes = daysInHours * 60;

                Console.WriteLine($"{centuries} centuries = {centuriesInYears} years = {yearsInDays} days = {daysInHours}" +
                      $" hours = {hoursInMinutes} minutes");

            }
        }
    }
