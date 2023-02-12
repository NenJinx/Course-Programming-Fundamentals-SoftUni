using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorVolumeOfPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Length: ");
            double lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            double basic = lenght * width;
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            double s = height / 3;
            double volume = basic * s;
            Console.Write($"Pyramid Volume: {volume:f2}");
        }
    }
}
