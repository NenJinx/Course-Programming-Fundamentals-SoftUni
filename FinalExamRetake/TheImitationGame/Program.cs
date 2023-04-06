using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheImitationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Decode")
            {
                string[] cmdArgs = command.Split('|');
                string commandName = cmdArgs[0];
                if (commandName == "Move")
                {
                    int number = int.Parse(cmdArgs[1]);
                    string substr = message.Substring(0, number);
                    message = message.Insert(message.Length, substr);
                    message = message.Remove(0, number);
                }
                else if (commandName == "Insert")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string value = cmdArgs[2];
                    message = message.Insert(index, value);
                }
                else if (commandName == "ChangeAll")
                {
                    string substring = cmdArgs[1];
                    string replacement = cmdArgs[2];
                    if (message.Contains(substring))
                    {
                        message = message.Replace(substring, replacement);
                    }
                }
            }
            Console.WriteLine("The decrypted message is: " + message);
        }
    }
}



