using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resoursesAndQuantity = new Dictionary<string, int>();

            string resourceCommand;

            while ((resourceCommand = Console.ReadLine())!= "stop")
            {
                int quantity = int.Parse(Console.ReadLine());   

                if (!resoursesAndQuantity.ContainsKey(resourceCommand))
                {
                    resoursesAndQuantity[resourceCommand] = 0;                     
                }
                resoursesAndQuantity[resourceCommand] += quantity;            
            }

            foreach (var resource in resoursesAndQuantity)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }

        }
    }
}
