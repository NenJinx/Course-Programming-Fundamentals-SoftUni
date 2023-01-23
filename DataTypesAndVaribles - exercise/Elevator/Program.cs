using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople, capacity;

            numberOfPeople = int.Parse(Console.ReadLine());
            capacity = int.Parse(Console.ReadLine());
            int coursesCount = numberOfPeople / capacity;

            if (numberOfPeople % capacity != 0)
            {
                coursesCount += 1;
                Console.WriteLine(coursesCount);
            }
            else
                Console.WriteLine(coursesCount);

        }
    }
}
