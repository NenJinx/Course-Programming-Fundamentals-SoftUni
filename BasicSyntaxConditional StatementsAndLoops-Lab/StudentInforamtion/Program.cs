using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInforamtion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName;
            int age;
            double averageGrade;
            studentName= Console.ReadLine();
            age = int.Parse(Console.ReadLine());
            averageGrade= double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {studentName}, Age: {age}, Grade: {averageGrade:f2}");
        }
    }
}
