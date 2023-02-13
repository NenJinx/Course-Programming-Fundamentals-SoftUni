using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {           

            //Create a program that receives four integer numbers.
            //You should perform the following operations:
            //⦁	Add first to the second.
            //⦁	Divide(integer) the result of the first operation by the third number.
            //⦁	Multiply the result of the second operation by the fourth number.
            //Print the result after the last operation.


            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
            int numberFour = int.Parse(Console.ReadLine());

            int sumOfFirstTwoNumbers, sumOfFirstTwoNumbersDivideOnThirdNumber,
                sumOfFirstTwoNumbersDivideOnThirdNumberMultiplyWithNumberFour;

            sumOfFirstTwoNumbers = numberOne + numberTwo;
            sumOfFirstTwoNumbersDivideOnThirdNumber = sumOfFirstTwoNumbers / numberThree;
            sumOfFirstTwoNumbersDivideOnThirdNumberMultiplyWithNumberFour =
                sumOfFirstTwoNumbersDivideOnThirdNumber * numberFour;

            Console.WriteLine(sumOfFirstTwoNumbersDivideOnThirdNumberMultiplyWithNumberFour);
        }
    }
}
