using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int addendOne = int.Parse(Console.ReadLine());
                int addendTwo = int.Parse(Console.ReadLine());

                Sum(addendOne, addendTwo);
                int diminutive = int.Parse(Console.ReadLine());
                Console.WriteLine(Subtracting(diminutive,addendOne,addendTwo));
            }
        }
        static int Sum(int numberOne, int numberTwo)
        {
            int sum = numberOne + numberTwo;

            return sum;
        }

        static int Subtracting(int diminutive,int addendOne,int addendTwo)
        {
            int subtracting = Sum(addendOne, addendTwo) - diminutive;
            return subtracting;
        }
    }
}

