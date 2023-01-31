using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugTheCodeHolidaysBetweenTwoDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.Parse(Console.ReadLine());
            //"dd.mm.yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.Parse(Console.ReadLine());
            //"dd.mm.yyyy", CultureInfo.InvariantCulture);
            var holidaysCount = 0;
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday ||
                    date.DayOfWeek == DayOfWeek.Sunday)
                    holidaysCount++;
            }
            Console.WriteLine(holidaysCount);

        }
    }
}
