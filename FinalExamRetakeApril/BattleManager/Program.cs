using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> nameHealthAndEnergy = new Dictionary<string, List<int>>();
            string command = string.Empty;
            string[] sep = { ":" };
            while ((command = Console.ReadLine()) != "Results")
            {
                string[] cmdArgs = command.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                string commandName = cmdArgs[0];
                if (commandName == "Add")
                {
                    string person = cmdArgs[1];
                    int health = int.Parse(cmdArgs[2]);
                    int energy = int.Parse(cmdArgs[3]);
                    if (nameHealthAndEnergy.ContainsKey(person))
                    {
                        nameHealthAndEnergy[person][0] += health;
                    }
                    else
                    {
                        nameHealthAndEnergy[person] = new List<int>();
                        nameHealthAndEnergy[person].Add(health);
                        nameHealthAndEnergy[person].Add(energy);
                    }
                }
                else if (commandName == "Attack")
                {
                    string attacker = cmdArgs[1];
                    string defender = cmdArgs[2];
                    int damage = int.Parse(cmdArgs[3]);
                    if (nameHealthAndEnergy.ContainsKey(attacker) && nameHealthAndEnergy.ContainsKey(defender))
                    {
                        nameHealthAndEnergy[defender][0] -= damage;
                        nameHealthAndEnergy[attacker][1] -= 1;
                        if (nameHealthAndEnergy[defender][0] <= 0)
                        {
                            nameHealthAndEnergy.Remove(defender);
                            Console.WriteLine($"{defender} was disqualified!");
                        }
                        if (nameHealthAndEnergy[attacker][1] <= 0)
                        {
                            nameHealthAndEnergy.Remove(attacker);
                            Console.WriteLine($"{attacker} was disqualified!");
                        }
                    }
                }
                else
                {
                    string user = cmdArgs[1];
                    if (user == "All")
                    {
                        nameHealthAndEnergy.Clear();
                    }
                    if (user != "All" && nameHealthAndEnergy.ContainsKey(user))
                    {
                        nameHealthAndEnergy.Remove(user);
                    }
                }
            }
            Console.WriteLine($"People count: {nameHealthAndEnergy.Count}");

            foreach (var name in nameHealthAndEnergy)
            {
                Console.WriteLine($"{name.Key} - {name.Value[0]} - {name.Value[1]}");
            }
        }
    }
}
