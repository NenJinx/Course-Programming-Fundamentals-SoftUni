using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatingEquality
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            double numOne = double.Parse(Console.ReadLine());
            double numTwo = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            bool isTrue = Math.Abs(numOne - numTwo) < eps;
            
            if (isTrue)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
