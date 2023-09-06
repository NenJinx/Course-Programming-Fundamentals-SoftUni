using System;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] textArray = text.ToCharArray();
            Array.Reverse(textArray);
            Console.WriteLine(string.Join("",textArray));
        }
    }
}
