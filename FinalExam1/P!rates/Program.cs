using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] separator = { "||" };
            string[] separatorOne = { "=>" };
            Dictionary<string, int> citiesAndGold = new Dictionary<string, int>();
            Dictionary<string, int> citiesAndPopulation = new Dictionary<string, int>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Sail")
            {
                string[] cmdArgs = command.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                string city = cmdArgs[0];
                int population = int.Parse(cmdArgs[1]);
                int gold = int.Parse(cmdArgs[2]);

                if (!citiesAndGold.ContainsKey(city))
                {
                    citiesAndGold[city] = gold;
                }
                else
                {
                    citiesAndGold[city] += gold;
                }
                if (!citiesAndPopulation.ContainsKey(city))
                {
                    citiesAndPopulation[city] = population;
                }
                else
                {
                    citiesAndPopulation[city] += population;
                }
            }
            string nextCommand = string.Empty;
            while ((nextCommand = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = nextCommand.Split(separatorOne, StringSplitOptions.RemoveEmptyEntries);
                string cmdName = cmdArgs[0];
                if (cmdName == "Plunder")
                {
                    string town = cmdArgs[1];
                    int people = int.Parse(cmdArgs[2]);
                    int stolenGold = int.Parse(cmdArgs[3]);

                    citiesAndGold[town] -= stolenGold;
                    citiesAndPopulation[town] -= people;

                    Console.WriteLine($"{town} plundered! {stolenGold} gold stolen, {people} citizens killed.");
                    if (citiesAndGold[town] == 0 || citiesAndPopulation[town] == 0)
                    {
                        Console.WriteLine($"{town} has been wiped off the map!");
                        citiesAndPopulation.Remove(town);
                        citiesAndGold.Remove(town);
                    }
                }
                else if (cmdName == "Prosper")
                {
                    string town = cmdArgs[1];
                    int growthGold = int.Parse(cmdArgs[2]);
                    if (growthGold < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                        continue;
                    }
                    else
                    {
                        citiesAndGold[town] += growthGold;
                        Console.WriteLine($"{growthGold} gold added to the city treasury. {town} now has {citiesAndGold[town]} gold.");
                    }
                }
            }

            if (citiesAndGold.Count > 0 || citiesAndPopulation.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {citiesAndPopulation.Count} " +
                    $"wealthy settlements to go to:");
                foreach (var city in citiesAndPopulation)
                {
                    Console.Write($"{city.Key} -> Population: {city.Value} citizens, Gold: {citiesAndGold[city.Key]} kg");
       
                }
            }
        }
    }
}
