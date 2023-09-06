using System;
namespace Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countSymbolsForSms = int.Parse(Console.ReadLine());

            string letters = "abcdefghijklmnopqrstuvwxyz";
            char symbolSpace = ' ';
            string sms = string.Empty;
            for (int i = 0; i < countSymbolsForSms; i++)
            {
                int letterFromKeyboard = int.Parse(Console.ReadLine());
                if (letterFromKeyboard == 0)
                {
                   sms += symbolSpace;
                    continue;
                }
                int mainDigit = letterFromKeyboard.ToString()[0] - 48;
                int countPressingButton = letterFromKeyboard.ToString().Length;
                int offset = (mainDigit - 2) * 3;
                if (mainDigit == 8 || mainDigit == 9)
                {
                   offset += 1;
               }
               int letterIndex = offset + countPressingButton - 1;
               sms += letters[letterIndex];

            }
            Console.WriteLine(sms);
        }
    }
}






