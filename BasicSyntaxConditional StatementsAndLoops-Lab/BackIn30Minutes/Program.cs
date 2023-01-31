using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackIn30Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours, minutes;
            hours = int.Parse(Console.ReadLine());
            minutes = int.Parse(Console.ReadLine());


            string timeOfLeavingModify = $"{hours}:{minutes}";
            DateTime timeOfLeaving = DateTime.Parse(timeOfLeavingModify);
            DateTime timeOfReturning = timeOfLeaving.AddMinutes(30);
            Console.WriteLine(timeOfReturning);
            //this also is valid
            //minutes += 30;
            //int minutesFromNextHour = 0;
            //if (minutes > 59)
            //{
            //    minutesFromNextHour = minutes - 60;
            //    minutes = 0;
            //    minutes += minutesFromNextHour;
               
            //    hours += 1;
            //    if (hours == 24)
            //    {
            //        hours = 0;
            //    }
            //}
            //if (minutes < 10)
            //{
            //    Console.WriteLine($"{hours}:0{minutes}");
            //}
            //else
            //    Console.WriteLine($"{hours}:{minutes}");
        }
    }
}
