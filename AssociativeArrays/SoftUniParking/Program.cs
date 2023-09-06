using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parkingUsersAndLicencePlates = new Dictionary<string, string>();

            int countUsers = int.Parse(Console.ReadLine());

            string licencePlate = "";
            for (int i = 0; i < countUsers; i++)
            {
                List<string> userAndLicencePlate = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();
                string username = userAndLicencePlate[1];
                if (userAndLicencePlate.Count > 2)
                {
                    licencePlate = userAndLicencePlate[2];
                }
                if (!parkingUsersAndLicencePlates.ContainsKey(username) && userAndLicencePlate[0] ==
                     "register")
                {
                    parkingUsersAndLicencePlates.Add(username, licencePlate);
                    Console.WriteLine($"{username} registered {licencePlate} successfully");
                }
                else if (parkingUsersAndLicencePlates.ContainsKey(username) && userAndLicencePlate[0] ==
                    "register")
                {
                    Console.WriteLine($"ERROR: already registered with plate number" +
                        $" {licencePlate}");
                }
                else if (parkingUsersAndLicencePlates.ContainsKey(username) && userAndLicencePlate[0] == "unregister")
                {
                    parkingUsersAndLicencePlates.Remove(username);
                    Console.WriteLine($"{username} unregistered successfully");
                }
                else if (!parkingUsersAndLicencePlates.ContainsKey(username) && userAndLicencePlate[0] == "unregister")
                {
                    Console.WriteLine($"ERROR: user {username} not found");
                }

            }
            foreach (var user in parkingUsersAndLicencePlates)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
