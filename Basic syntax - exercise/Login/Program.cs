using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            string username, password, passwordReversed = "";
            int loginAttempt = 0;
            username = Console.ReadLine();
            password = Console.ReadLine();
            loginAttempt++;            
            
            for (int i = username.Length - 1; i >= 0; i--)
            {
                char symbol = username[i];
                passwordReversed += symbol;
            }

            while (loginAttempt <= 4)
            {
                if (passwordReversed == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }

                if (loginAttempt == 4 && passwordReversed != password)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }


                if (password != passwordReversed && loginAttempt != 4)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }

                password = Console.ReadLine();
                loginAttempt++;

            }

        }
    }
}
