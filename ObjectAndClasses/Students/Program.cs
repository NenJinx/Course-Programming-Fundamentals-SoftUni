using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(' ').
                    ToArray();
                string studentName = cmdArgs[0];
                string studentLastName = cmdArgs[1];
                double studentGrade = double.Parse(cmdArgs[2]);
                Student obj = new Student(studentName, studentLastName, studentGrade);
                students.Add(obj);
            }
            students = students.OrderByDescending(s => s.Grade).ToList();
            Console.WriteLine(string.Join("\n", students));
        }
    }
    public class Student
    {
        public Student(string name, string lastName, double grade)
        {
            FirstName = name;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";  
        }
    }
}





