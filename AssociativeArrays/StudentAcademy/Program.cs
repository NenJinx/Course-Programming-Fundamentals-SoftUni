using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentDiary = new Dictionary<string, List<double>>();

            int nPair = int.Parse(Console.ReadLine());
            for (int i = 0; i < nPair; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentDiary.ContainsKey(studentName))
                {
                    studentDiary[studentName] = new List<double>();
                }
                studentDiary[studentName].Add(grade);
            }

            foreach (var studentName in studentDiary)
            {
                double allGradeSum = studentName.Value.Sum();
                double average = allGradeSum / studentName.Value.Count;
                
                if (average < 4.50)
                {
                    continue;
                }

                Console.WriteLine($"{studentName.Key} -> {average,0:f2}");
            }
        }
    }
}
