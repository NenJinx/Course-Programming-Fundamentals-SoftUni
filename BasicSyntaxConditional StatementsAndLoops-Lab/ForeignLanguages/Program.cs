﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeignLanguages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            switch (country)
            {
                case "USA":
                    Console.WriteLine("English");
                    break;
                case "England":
                    Console.WriteLine("English");
                    break;
                case "Argentina":
                    Console.WriteLine("Spanish");
                    break;
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;
                case "Spain":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
