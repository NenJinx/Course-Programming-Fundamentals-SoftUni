using System;
using System.Collections.Generic;

namespace CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companiesAndWorkers = new Dictionary<string, List<string>>();
            String[] separator = { " -> " };
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                string companyName = cmdArgs[0];
                string employeeID = cmdArgs[1];
                
                if (!companiesAndWorkers.ContainsKey(companyName))
                {
                    companiesAndWorkers[companyName] = new List<string>();
                }
                if (companiesAndWorkers[companyName].Contains(employeeID))
                {
                    continue;
                }
                companiesAndWorkers[companyName].Add(employeeID);
            }
            foreach (var companyName in companiesAndWorkers)
            {
                Console.WriteLine($"{companyName.Key}");
                foreach (var employeeID in companyName.Value)
                {
                    Console.WriteLine($"-- {employeeID}");
                }
            }
        }
    }
}
