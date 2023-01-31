using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 theCountOfPeople;
            System.String typeOfTheGroup, theDayOfTheWeek;

            theCountOfPeople = Int32.Parse(Console.ReadLine());
            typeOfTheGroup = Console.ReadLine();
            theDayOfTheWeek = Console.ReadLine();

            double totalPrice = 0;

            if (theCountOfPeople < 30 && typeOfTheGroup == "Students" &&
                theDayOfTheWeek == "Friday")
            {
                totalPrice = theCountOfPeople * 8.45;
            }
            else if (theCountOfPeople < 30 && typeOfTheGroup == "Students" &&
                theDayOfTheWeek == "Saturday")
            {
                totalPrice = theCountOfPeople * 9.8;
            }
            else if (theCountOfPeople < 30 && typeOfTheGroup == "Students" &&
                theDayOfTheWeek == "Sunday")
            {
                totalPrice = theCountOfPeople * 10.46;
            }


            else if (theCountOfPeople >= 30 && typeOfTheGroup == "Students" &&
                theDayOfTheWeek == "Friday")
            {
                totalPrice = (theCountOfPeople * 8.45) * 0.85;
            }
            else if (theCountOfPeople >= 30 && typeOfTheGroup == "Students" &&
                theDayOfTheWeek == "Saturday")
            {
                totalPrice = (theCountOfPeople * 9.8) * 0.85;
            }
            else if (theCountOfPeople >= 30 && typeOfTheGroup == "Students" &&
                theDayOfTheWeek == "Sunday")
            {
                totalPrice = (theCountOfPeople * 10.46) * 0.85;
            }

            else if (theCountOfPeople < 100 && typeOfTheGroup == "Business" &&
                theDayOfTheWeek == "Friday")
            {
                totalPrice = theCountOfPeople * 10.90;
            }
            else if (theCountOfPeople < 100 && typeOfTheGroup == "Business" &&
                theDayOfTheWeek == "Saturday")
            {
                totalPrice = theCountOfPeople * 15.60;
            }
            else if (theCountOfPeople < 100 && typeOfTheGroup == "Business" &&
                theDayOfTheWeek == "Sunday")
            {
                totalPrice = theCountOfPeople * 16;
            }
            else if (theCountOfPeople >= 100 && typeOfTheGroup == "Business" &&
                theDayOfTheWeek == "Friday")
            {
                totalPrice = (theCountOfPeople * 10.90) - (10 * 10.9);
            }
            else if (theCountOfPeople >= 100 && typeOfTheGroup == "Business" &&
                theDayOfTheWeek == "Saturday")
            {
                totalPrice = (theCountOfPeople * 15.6) - (10 * 15.6);
            }
            else if (theCountOfPeople >= 100 && typeOfTheGroup == "Business" &&
                theDayOfTheWeek == "Sunday")
            {
                totalPrice = (theCountOfPeople * 16) - (10 * 16);
            }
            else if (theCountOfPeople < 10 && typeOfTheGroup == "Regular" &&
                theDayOfTheWeek == "Friday")
            {
                totalPrice = theCountOfPeople * 15;
            }
            else if (theCountOfPeople < 10 && typeOfTheGroup == "Regular" &&
                theDayOfTheWeek == "Saturday")
            {
                totalPrice = theCountOfPeople * 20;
            }
            else if (theCountOfPeople < 10 && typeOfTheGroup == "Regular" &&
                theDayOfTheWeek == "Sunday")
            {
                totalPrice = theCountOfPeople * 22.5;
            }

            else if (theCountOfPeople > 20 && typeOfTheGroup == "Regular" &&
                theDayOfTheWeek == "Friday")
            {
                totalPrice = theCountOfPeople * 15;
            }
            else if (theCountOfPeople > 20 && typeOfTheGroup == "Regular" &&
                theDayOfTheWeek == "Saturday")
            {
                totalPrice = theCountOfPeople * 20;
            }
            else if (theCountOfPeople > 20 && typeOfTheGroup == "Regular" &&
                theDayOfTheWeek == "Sunday")
            {
                totalPrice = theCountOfPeople * 22.5;
            }

            else if (theCountOfPeople >= 10 && theCountOfPeople <= 20 && typeOfTheGroup == "Regular" &&
                theDayOfTheWeek == "Friday")
            {
                totalPrice = (theCountOfPeople * 15) * 0.95;
            }
            else if (theCountOfPeople >= 10 && theCountOfPeople <= 20 && typeOfTheGroup == "Regular" &&
                theDayOfTheWeek == "Saturday")
            {
                totalPrice = (theCountOfPeople * 20) * 0.95;
            }
            else if (theCountOfPeople >= 10 && theCountOfPeople <= 20 && typeOfTheGroup == "Regular" &&
                theDayOfTheWeek == "Sunday")
            {
                totalPrice = (theCountOfPeople * 22.50) * 0.95;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
