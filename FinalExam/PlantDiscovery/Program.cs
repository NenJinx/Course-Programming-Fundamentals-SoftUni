using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantDiscovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> plantAndRarity = new Dictionary<string, int>();
            Dictionary<string, List<double>> plantAndRate = new Dictionary<string, List<double>>();

            String[] separator = { "<->" };
            for (int i = 0; i < n; i++)
            {
                string[] commandInfo = Console.ReadLine().Split(separator, StringSplitOptions.
                    RemoveEmptyEntries);
                string plant = commandInfo[0];
                int rarity = int.Parse(commandInfo[1]);

                if (!plantAndRarity.ContainsKey(plant))
                {
                    plantAndRarity[plant] = rarity;
                    plantAndRate[plant] = new List<double>();
                }
            }

            string command = "";

            while ((command = Console.ReadLine()) != "Exhibition")
            {
                string[] commandInfo = command.Split(new char[] { ' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries).
                    ToArray();

                string commandName = commandInfo[0];
                string plantName = commandInfo[1];

                if (commandName == "Rate")
                {
                    int value = int.Parse(commandInfo[2]);
                    if (plantAndRate.ContainsKey(plantName))
                    {
                        plantAndRate[plantName].Add(value);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (commandName == "Update")
                {
                    int value = int.Parse(commandInfo[2]);
                    if (plantAndRarity.ContainsKey(plantName))
                    {
                        plantAndRarity[plantName] = value;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (commandName == "Reset")
                {
                    if (plantAndRate.ContainsKey(plantName))
                    {
                        plantAndRate[plantName].Clear();
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (var rarity in plantAndRarity)
            {
                if (plantAndRate[rarity.Key].Count > 0)
                {
                    double average = plantAndRate[rarity.Key].Average();

                    Console.WriteLine($"- {rarity.Key}; Rarity: {rarity.Value}; Rating: " +
                                 $"{average:f2}");
                }
                else
                {
                    Console.WriteLine($"- {rarity.Key}; Rarity: {rarity.Value}; Rating: " +
                                 $"0.00");
                }
            }
        }
    }
}
