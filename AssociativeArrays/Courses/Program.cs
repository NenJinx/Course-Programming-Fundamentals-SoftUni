using System;
using System.Collections.Generic;

namespace Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> coursesList =
                new Dictionary<string, List<string>>();

            String[] separator = { " : " };

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split(separator,
                StringSplitOptions.RemoveEmptyEntries);
                string courseName = cmdArgs[0];
                string studentNames = cmdArgs[1];

                if (!coursesList.ContainsKey(courseName))
                {
                    coursesList[courseName] = new List<string>();
                }

                coursesList[courseName].Add(studentNames);
            }
            foreach (var courseName in coursesList)
            {
                Console.WriteLine($"{courseName.Key}: {courseName.Value.Count}");
                foreach (var studentNames in courseName.Value)
                {
                    Console.WriteLine($"-- {studentNames}");
                }
            }
        }
    }
}
