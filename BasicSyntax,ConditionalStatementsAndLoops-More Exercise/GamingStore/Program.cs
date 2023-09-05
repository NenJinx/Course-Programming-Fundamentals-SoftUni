using System;
namespace GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());

            string gameName = string.Empty;

            //OutFall 4   $39.99
            //CS: OG  $15.99
            //Zplinter Zell	$19.99
            //Honored 2   $59.99
            //RoverWatch  $29.99
            //RoverWatch Origins Edition  $39.99
            double gamePrice = 0;
            double totalSpent = 0;
            while ((gameName = Console.ReadLine()) != "Game Time")
            {
                if (gameName == "OutFall 4" || gameName == "CS: OG" || gameName == "Zplinter Zell" ||
                    gameName == "Honored 2" || gameName == "RoverWatch" || gameName == "RoverWatch " +
                    "Origins Edition")
                {
                    switch (gameName)
                    {
                        case "OutFall 4":
                            gamePrice = 39.99;
                            if (money >= gamePrice)
                            {
                                Console.WriteLine("Bought OutFall 4");
                                money -= gamePrice;
                                totalSpent += gamePrice;
                            }
                            else
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            break;
                        case "CS: OG":
                            gamePrice = 15.99;
                            if (money >= gamePrice)
                            {
                                Console.WriteLine("Bought CS: OG");
                                money -= gamePrice;
                                totalSpent += gamePrice;
                            }
                            else
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            break;
                        case "Zplinter Zell":
                            gamePrice = 19.99;
                            if (money >= gamePrice)
                            {
                                Console.WriteLine("Bought Zplinter Zell");
                                money -= gamePrice;
                                totalSpent += gamePrice;
                            }
                            else
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            break;
                        case "Honored 2":
                            gamePrice = 59.99;
                            if (money >= gamePrice)
                            {
                                Console.WriteLine("Bought Honored 2");
                                money -= gamePrice;
                                totalSpent += gamePrice;
                            }
                            else
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            break;
                        case "RoverWatch":
                            gamePrice = 29.99;
                            if (money >= gamePrice)
                            {
                                Console.WriteLine("Bought RoverWatch");
                                money -= gamePrice;
                                totalSpent += gamePrice;
                            }
                            else
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            break;
                        case "RoverWatch Origins Edition":
                            gamePrice = 39.99;
                            if (money >= gamePrice)
                            {
                                Console.WriteLine("Bought RoverWatch Origins Edition");
                                money -= gamePrice;
                                totalSpent += gamePrice;
                            }
                            else
                            {
                                Console.WriteLine("Too Expensive");
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
            }
            if (money > 0)
            {
                Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${money:f2}");
            }
            else
            {
                Console.WriteLine("Out of money!");
            }
        }
    }
}
