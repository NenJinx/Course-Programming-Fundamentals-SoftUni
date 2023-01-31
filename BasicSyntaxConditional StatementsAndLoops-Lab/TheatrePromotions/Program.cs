using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatrePromotions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Day / Age   0 <= age <= 18  18 < age <= 64  64 < age <= 122
            //Weekday          12$	            18$	           12$
            //Weekend          15$	            20$	           15$
            //Holiday          5$	            12$	           10$

            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int price = 0;
            
            if (day == "Weekday")
            {
                if (age >= 0 && age <= 18)
                {
                    price= 12;
                }
                else if(age > 18 && age <=64)
                {
                    price = 18;
                }
                else if (age >64 && age <= 122)
                {
                    price = 12;
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            else if (day == "Weekend")
            {
                if (age >= 0 && age <= 18)
                {
                    price = 15;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 20;
                }
                else if (age > 64 && age <= 122)
                {
                    price = 15;
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            else if (day == "Holiday")
            {
                if (age >= 0 && age <= 18)
                {
                    price = 5;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 12;
                }
                else if (age > 64 && age <= 122)
                {
                    price = 10;
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            
            if (price > 0)
            {
                Console.WriteLine($"{price}$");
                
            }
        }
    }
}
