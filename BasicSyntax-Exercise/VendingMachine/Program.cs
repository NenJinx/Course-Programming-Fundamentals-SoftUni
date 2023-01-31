using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double money = 0;
            double coin = 0;
            while (command != "Start")
            {
                coin = double.Parse(command);

                if (coin != 0.1 && coin != 0.2 && coin != 0.5 && coin != 1 && coin != 2)
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
                else
                {
                    money += coin;
                }
                command = Console.ReadLine();
            }

            string productCommand = Console.ReadLine();
            
            while (productCommand != "End")
            {
                if (productCommand == "Nuts")
                {
                    if (money < 2)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        money -= 2;
                        Console.WriteLine("Purchased nuts");
                    }
                }
                else if (productCommand == "Water")
                {
                    if (money < 0.7)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        money -= 0.7;
                        Console.WriteLine("Purchased water");
                    }
                }
                else if(productCommand == "Crisps")
                    if (money < 1.5)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        money -= 1.5;
                        Console.WriteLine("Purchased crisps");
                    }
                else if (productCommand == "Soda")
                {
                    if (money < 0.8)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        money -= 0.8;
                        Console.WriteLine("Purchased soda");
                    }
                }
                else if(productCommand == "Coke")
                {
                    if (money < 1)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        money -= 1;
                        Console.WriteLine("Purchased coke");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                productCommand = Console.ReadLine();
            }

            Console.WriteLine($"Change: {money:f2}");
        }
    }
}
