using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOrders, days, capsulesCount;
            double pricePerCapsule, orderPrice, totalPrice = 0;


            countOrders = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOrders; i++)
            {
                pricePerCapsule = double.Parse(Console.ReadLine());
                days = int.Parse(Console.ReadLine());
                capsulesCount = int.Parse(Console.ReadLine());
                orderPrice = (days * capsulesCount) * pricePerCapsule;
                totalPrice += orderPrice;
                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }

}


